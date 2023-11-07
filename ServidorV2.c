#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>
#include <mysql.h>

pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;



typedef struct{
	char nombre[20];
	int socket;
}Conectado;
typedef struct{
	Conectado Conectados[100];
	int num;
}ListaConectados;

int contador;

//Acceso excluyenteint i;
int sockets[100];

MYSQL *conn;
int R;
// Estructura especial para almacenar resultados de consultas 
MYSQL_RES *resultado;
MYSQL_ROW row;
char ConsultaResult [250];

// añdir el conectados a la hora de logearse en el client y a la hora de deslogearse añadir eliminar conectados,para mostrar la lista hemos de añadir una consulta que la muestre

ListaConectados miLista;

int PonJugador(ListaConectados *miLista, char nombre[20], int socket)
{
if(miLista->num == 100){
		printf("Lista de conectados llena.");
	 return -1;
}
else
	{
		strcpy(miLista->Conectados[miLista->num].nombre,nombre);
		miLista->Conectados[miLista->num].socket = socket;
		miLista->num++;
		return 0;
	}
}
int DamePos(ListaConectados *miLista, char nombre[20])//devuelve la posicion de la lista de conectados del usuario.
{
	int i=0;
	int encontrado=0;
	while((i<miLista->num)&&(!encontrado)){
		if(strcmp(miLista->Conectados[i].nombre,nombre)==0)
			encontrado = 1;
		if(!encontrado)
			i++;
		
	}
	if (encontrado)
		return i;
	else
		return -1;
}

int Eliminar(ListaConectados *miLista, char nombre[20])
{
	pthread_mutex_lock(&mutex);
	int pos = DamePos(miLista,nombre);
	if (pos == -1)
		return -1;
	else
	{
		int i;
		for(i=pos;i<miLista->num-1;i++)
			miLista->Conectados[i] = miLista->Conectados[i+1];
		miLista->num--;
		return 0;
	}
	pthread_mutex_unlock(&mutex);
} 

void DameConectados(ListaConectados *miLista,char conectados[300])
{
	pthread_mutex_lock(&mutex);
	sprintf(conectados,"%d",miLista->num);
	int i;
	for(i=0;i<miLista->num;i++)
	   sprintf(conectados,"%s/%s",conectados,miLista->Conectados[i].nombre);

	pthread_mutex_unlock(&mutex);
}

void Registrarse(MYSQL *conn, char Usuario[80], char Contrasena[80], char respuesta[512])
{
	pthread_mutex_lock(&mutex);
	memset(ConsultaResult, 0, strlen(ConsultaResult));
	strcpy (ConsultaResult,"SELECT Jugador.Nombre FROM Jugador WHERE Jugador.Nombre = '");
	strcat (ConsultaResult, Usuario);
	strcat (ConsultaResult,"'");
			
	R = mysql_query (conn, ConsultaResult);
	if (R!= 0)
	{
		printf ("Error al consultar datos de la base %u %s\n",
		mysql_errno(conn), mysql_error(conn));
	}
	else if (R == 0)
	{
		//Recogemos el resultado de la consulta en una
		//tabla virtual MySQL
		respuesta = mysql_store_result (conn);
				
		//Recogemos el resultado de la primera fila
		row = mysql_fetch_row (respuesta);
				
		//Si no encuentra ningún usuario con ese nombre
		if (row == NULL)
		{
			//Abrimos otra vez MySQL para poder contar el número total de jugadores
			memset(ConsultaResult, 0, strlen(ConsultaResult));
			strcpy (ConsultaResult,"SELECT Jugador.Identificador FROM Jugador");
			int consulta2 = mysql_query (conn, ConsultaResult);
			if (consulta2 != 0)
			{
				printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
				sprintf(respuesta, "2/%s/ERROR", Usuario);
			}
			else if (consulta2 == 0)
			{
				respuesta = mysql_store_result (conn);
				row = mysql_fetch_row (respuesta);
				int JugadoresInicial;
				char JugadoresFinal[100];
						
				while(row != NULL)
				{
					JugadoresInicial = atoi(row[0]);
							
					//Obtenemos la siguiente fila para el siguiente loop
					row = mysql_fetch_row (respuesta);
				}
						
				JugadoresInicial++;
				sprintf(JugadoresFinal, "%d", JugadoresInicial);
						
				memset(ConsultaResult, 0, strlen(ConsultaResult));
				strcpy (ConsultaResult, "INSERT INTO Jugador VALUES(");
				strcat (ConsultaResult, JugadoresFinal);
				strcat (ConsultaResult, ", '");
				strcat (ConsultaResult, Usuario);
				strcat (ConsultaResult, "', '");
				strcat (ConsultaResult, Contrasena);
				strcat (ConsultaResult, "')");
						
				R = mysql_query (conn, ConsultaResult);
				if (R == 0)
				{
					sprintf(respuesta, "2/%s/SI", Usuario);
				}
				else if (R != 0)
				{
					printf ("Error al introducir datos en la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
					sprintf(respuesta, "2/%s/ERROR", Usuario);
				}			
			}		
		}		
		//Si se encuentra un usuario con ese nombre
		else if (row != NULL)
		{
			sprintf(respuesta, "2/%s/NO", Usuario);
		}
	}
	pthread_mutex_unlock(&mutex);
}




void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	//int socket_conn = * (int *) socket;
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar == 0)
	{
		// Ahora recibimos la petici?n
		ret=read(sock_conn, peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que anadirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		printf ("Peticion: %s\n", peticion);
		
		//Vamos a ver que quieren
		char *p = strtok(peticion, "/");
		int NumeroConsulta =  atoi (p);
		
		if (NumeroConsulta != 0)
		{
			//Nos conectamos a la base de datos MySQL
			conn = mysql_init(NULL);
			if (conn==NULL) {
				printf ("Error al crear la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
			}
			
			//Inicializamos la conexi�n al servidor MySQL
			conn = mysql_real_connect (conn, "localhost","root", "mysql", "Juego", 0, NULL, 0);
			if (conn==NULL) {
				printf ("Error al inicializar la conexion: %u %s\n", 
						mysql_errno(conn), mysql_error(conn));
			}
			
		}
		
		if (NumeroConsulta == 0) //peticion de desconexion
		{
			char Usuario[80];
			Eliminar(&miLista,Usuario);
			terminar=1;
		}
		else if (NumeroConsulta == 1) //Piden iniciar sesion con su cuenta
		{
			char Usuario[80];
			char Contrasena[80];
			p = strtok(NULL, "/");
			strcpy (Usuario, p); // Ya tenemos el usuario
			p = strtok(NULL, "/");
			strcpy (Contrasena, p); //Conseguimos la contrasena
			
			printf ("Codigo: %d, Nombre: %s, Contrasena: %s\n", NumeroConsulta, Usuario, Contrasena);
			
			//Comprobamos que el usuario ya esta registrado previamente
			
			strcpy (ConsultaResult,"SELECT Jugador.Nombre FROM Jugador WHERE Jugador.Nombre = '");
			strcat (ConsultaResult, Usuario);
			strcat (ConsultaResult,"' AND Jugador.Contrasena = '");
			strcat (ConsultaResult, Contrasena);
			strcat (ConsultaResult,"'");
			
			//Si vemos que no nos sale ningun usuario, informamos
			R = mysql_query (conn, ConsultaResult);
			if (R != 0)
			{
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
			}
			else if (R == 0)
			{
				//Recogemos el resultado de la consulta en una
				//tabla virtual MySQL
				resultado = mysql_store_result (conn);
				
				//Recogemos el resultado de la primera fila
				row = mysql_fetch_row (resultado);
				
				//Cerramos la conexión con el servidor
				mysql_close (conn);
				
				//Si no encuentra ningún usuario con ese nombre
				if (row == NULL)
				{
					sprintf(respuesta, "1/%s/NO", Usuario);
				}
				
				//Si se encuentra un usuario con ese nombre
				else if (row != NULL)
				{
					//Se hace un string del primer valor obtenido de la
					//columna generada con la consulta
					strcpy(respuesta, row[0]);
					
					//Se comprueba que el nombre obtenido es el del usuario
					//introducido
					if(strcmp(respuesta, Usuario) == 0)
					{
			 			sprintf(respuesta, "1/%s/SI", Usuario);
			            PonJugador(&miLista, Usuario, sock_conn);
					}
					
					//Para evitar errores, en caso de que salga algun resultado,
					//se hace de todos modos la comparacion para asegurarse que esta
					//todo bien
					else if(strcmp(respuesta, Usuario) != 0)
					{
						sprintf(respuesta, "1/%s/NO", Usuario);
					}
				}
			}
		}
		else if (NumeroConsulta == 2) //Piden crearse una nueva cuenta
		{
			char Usuario[80];
			char Contrasena[80];
			p = strtok(NULL, "/");
			strcpy (Usuario, p); // Ya tenemos el usuario
			p = strtok(NULL, "/");
			strcpy (Contrasena, p); //Conseguimos la contrasena
			
			printf ("Codigo: %d, Nombre: %s, Contrasena: %s\n", NumeroConsulta, Usuario, Contrasena);
			Registrarse(conn,Usuario,Contrasena,respuesta);
		}
		else if (NumeroConsulta == 3) //Piden calcular los puntos que ha obtenido un jugador en todas las partidas
		{
			int PuntosTotales = 0;
			char Usuario[80];
			p = strtok(NULL, "/");
			strcpy (Usuario, p); // Ya tenemos el usuario
			
			printf ("Codigo: %d, Nombre: %s\n", NumeroConsulta, Usuario);
			
			//Creamos el string para poder hacer la consulta a MySQL
			//con una variable, que es el nombre del jugador buscado
			char ConsultaResult [80];
			strcpy (ConsultaResult,"SELECT Participacion.Puntos FROM Participacion,Jugador WHERE Jugador.Nombre = '");
			strcat (ConsultaResult, Usuario);
			strcat (ConsultaResult,"' AND Jugador.Identificador = Participacion.Jugador");
			
			//Consulta SQL para obtener una tabla con
			//los datos solicitados de la base de datos
			R = mysql_query (conn, ConsultaResult);
			if (R != 0) {
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
			}
			
			//Recogemos el resultado de la consulta en una
			//tabla virtual MySQL
			resultado = mysql_store_result (conn);
			
			//Recogemos el resultado de la primera fila
			row = mysql_fetch_row (resultado);
			
			//Analizamos para empezar la primera fila para saber
			//si hemos obtenido resultados con la consulta
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			
			//En caso de obtener resultados, se analiza cada fila hasta llegar
			//a la primera fila con un valor nulo
			else
				while (row != NULL) {
					
					//Convertimos a int la columna 0, que es la que contiene
					//los puntos de la partida analizada
					
					int PuntosPartida = atoi(row[0]);
					
					PuntosTotales = PuntosTotales + PuntosPartida;
					
					//Obtenemos la siguiente fila para el siguiente loop
					row = mysql_fetch_row (resultado);
			}
				
			sprintf(respuesta, "3/%d", PuntosTotales);
		}
		
		else if (NumeroConsulta == 4) //Consulta para el numero total de partidas ganadas por un jugador
		{
			int PartidasGanadas = 0;
			char Usuario[80];
			p = strtok(NULL, "/");
			strcpy (Usuario, p); // Ya tenemos el usuario
			
			printf ("Codigo: %d, Nombre: %s\n", NumeroConsulta, Usuario);
			
			//Creamos el string para poder hacer la consulta a MySQL
			//con una variable, que es la lista de partidas ganadas por el jugador buscado
			char ConsultaResult [80];
			strcpy (ConsultaResult,"SELECT Partida.Identificador FROM Partida, Jugador WHERE Jugador.Nombre = '");
			strcat (ConsultaResult, Usuario);
			strcat (ConsultaResult,"' AND Jugador.Identificador = Partida.Ganador");
			
			//Consulta SQL para obtener una tabla con
			//los datos solicitados de la base de datos
			R = mysql_query (conn, ConsultaResult);
			if (R != 0) {
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
			}
			
			//Recogemos el resultado de la consulta en una
			//tabla virtual MySQL
			resultado = mysql_store_result (conn);
			
			//Recogemos el resultado de la primera fila
			row = mysql_fetch_row (resultado);
			
			//Analizamos para empezar la primera fila para saber
			//si hemos obtenido resultados con la consulta
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			
			//En caso de obtener resultados, se analiza cada fila hasta llegar
			//a la primera fila con un valor nulo
			else
				while (row != NULL) {
					
					//Sumamos 1 partida ganada por cada fila analizada
					PartidasGanadas++;
					
					//Obtenemos la siguiente fila para el siguiente loop
					row = mysql_fetch_row (resultado);
			}
				
				sprintf(respuesta, "4/%d", PartidasGanadas);
		}
		else if (NumeroConsulta == 5) //Consulta para el numero total de partidas jugadas por un jugador
		{
			int PartidasJugadas = 0;
			char Usuario[80];
			p = strtok(NULL, "/");
			strcpy (Usuario, p); // Ya tenemos el usuario
			
			printf ("Codigo: %d, Nombre: %s\n", NumeroConsulta, Usuario);
			
			//Creamos el string para poder hacer la consulta a MySQL
			//con una variable, que es la lista de partidas ganadas por el jugador buscado
			char ConsultaResult [80];
			strcpy (ConsultaResult,"SELECT Participacion.Partida FROM Participacion, Jugador WHERE Jugador.Nombre = '");
			strcat (ConsultaResult, Usuario);
			strcat (ConsultaResult,"' AND Jugador.Identificador = Participacion.Jugador");
			
			//Consulta SQL para obtener una tabla con
			//los datos solicitados de la base de datos
			R = mysql_query (conn, ConsultaResult);
			if (R != 0) {
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
			}
			
			//Recogemos el resultado de la consulta en una
			//tabla virtual MySQL
			resultado = mysql_store_result (conn);
			
			//Recogemos el resultado de la primera fila
			row = mysql_fetch_row (resultado);
			
			//Analizamos para empezar la primera fila para saber
			//si hemos obtenido resultados con la consulta
			if (row == NULL)
				printf ("No se han obtenido datos en la consulta\n");
			
			//En caso de obtener resultados, se analiza cada fila hasta llegar
			//a la primera fila con un valor nulo
			else
				while (row != NULL) {
					
					//Sumamos 1 partida ganada por cada fila analizada
					PartidasJugadas++;
					
					//Obtenemos la siguiente fila para el siguiente loop
					row = mysql_fetch_row (resultado);
			}
				
				sprintf(respuesta, "5/%d", PartidasJugadas);
		}
		if(NumeroConsulta == 6)
		{
			char Usuario[200];
			DameConectados(&miLista,Usuario);
			sprintf(respuesta,"6/%s",Usuario);
		}
		if (NumeroConsulta != 0)
		{
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos respuesta
			write (sock_conn, respuesta, strlen(respuesta));
		}
	}
	// Se acabo el servicio para este cliente
	close(sock_conn); 
}


int main(int argc, char *argv[])
{
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creando el socket\n");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind\n");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen\n");
	
	contador = 0;
	
	pthread_t thread;
	int i=0;
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
	}
}
