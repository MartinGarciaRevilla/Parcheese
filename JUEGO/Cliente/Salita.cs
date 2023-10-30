using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente
{
    public partial class Salita : Form
    {
        Socket server;
        public Salita(Socket server)
        {
            InitializeComponent();
            this.server = server;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            if ((Usuario.Text != "") && (Consulta.SelectedIndex == 0)) //Queremos saber el número de partidas ganadas del jugador consultado
            {
                string mensaje = "4/" + Usuario.Text;
                // Enviamos al servidor la consulta deseada
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

            if ((Usuario.Text != "") && (Consulta.SelectedIndex == 1)) //Queremos saber los puntos totales del jugador consultado
            {
                string mensaje = "3/" + Usuario.Text;
                // Enviamos al servidor la consulta 
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }

            if ((Usuario.Text != "") && (Consulta.SelectedIndex == 2)) //Queremos saber el número de partidas jugadas del jugador consultado
            {
                string mensaje = "5/" + Usuario.Text;
                // Enviamos al servidor la consulta 
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

            }
            if ((FechaP.Text != "") && (Consulta.SelectedIndex == 3)) //Queremos saber el nombre de la persona que jugó la partida que reciba como parámetro
            {
                string mensaje = "6/" + FechaP.Text;
                // Enviamos al servidor la consulta 
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
            }
        }

        public void ModificarResultado(string resultado)
        {
            Resultado.Text = resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void Salita_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "7/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

        }

        
        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostraInfoBoton(object sender, EventArgs e)
        {
            // Obtén el texto del botón
            string textoBoton = LC.Text;

            // Crea un elemento en el ListView y agrega la información del botón
            ListViewItem item = new ListViewItem(textoBoton);
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
