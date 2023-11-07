namespace Cliente
{
    partial class PantallaSesionUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.MaskedTextBox();
            this.LabelUsuario = new System.Windows.Forms.TextBox();
            this.LabelContrasena = new System.Windows.Forms.TextBox();
            this.OpcionInicioSesion = new System.Windows.Forms.RadioButton();
            this.BotonInicioSesion = new System.Windows.Forms.Button();
            this.BotonRegistroCuenta = new System.Windows.Forms.Button();
            this.OpcionCuentaNueva = new System.Windows.Forms.RadioButton();
            this.BotonCierreSesion = new System.Windows.Forms.Button();
            this.TablaUsuariosConectados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelUsuarioConsultado = new System.Windows.Forms.TextBox();
            this.UsuarioaConsultar = new System.Windows.Forms.TextBox();
            this.LabelConsulta = new System.Windows.Forms.TextBox();
            this.Consulta = new System.Windows.Forms.ComboBox();
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.LabelResultado = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuariosConectados)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(253, 82);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(237, 30);
            this.Usuario.TabIndex = 0;
            // 
            // Contrasena
            // 
            this.Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena.Location = new System.Drawing.Point(253, 191);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(237, 30);
            this.Contrasena.TabIndex = 1;
            this.Contrasena.UseSystemPasswordChar = true;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelUsuario.Location = new System.Drawing.Point(91, 82);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.ReadOnly = true;
            this.LabelUsuario.Size = new System.Drawing.Size(90, 30);
            this.LabelUsuario.TabIndex = 2;
            this.LabelUsuario.Text = "Usuario:";
            // 
            // LabelContrasena
            // 
            this.LabelContrasena.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelContrasena.Location = new System.Drawing.Point(91, 191);
            this.LabelContrasena.Name = "LabelContrasena";
            this.LabelContrasena.ReadOnly = true;
            this.LabelContrasena.Size = new System.Drawing.Size(125, 30);
            this.LabelContrasena.TabIndex = 3;
            this.LabelContrasena.Text = "Contraseña:";
            // 
            // OpcionInicioSesion
            // 
            this.OpcionInicioSesion.AutoSize = true;
            this.OpcionInicioSesion.Location = new System.Drawing.Point(102, 128);
            this.OpcionInicioSesion.Name = "OpcionInicioSesion";
            this.OpcionInicioSesion.Size = new System.Drawing.Size(218, 20);
            this.OpcionInicioSesion.TabIndex = 4;
            this.OpcionInicioSesion.TabStop = true;
            this.OpcionInicioSesion.Text = "Tengo ya una cuenta registrada";
            this.OpcionInicioSesion.UseVisualStyleBackColor = true;
            this.OpcionInicioSesion.CheckedChanged += new System.EventHandler(this.OpcionInicioSesion_CheckedChanged);
            // 
            // BotonInicioSesion
            // 
            this.BotonInicioSesion.Enabled = false;
            this.BotonInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInicioSesion.Location = new System.Drawing.Point(102, 261);
            this.BotonInicioSesion.Name = "BotonInicioSesion";
            this.BotonInicioSesion.Size = new System.Drawing.Size(179, 63);
            this.BotonInicioSesion.TabIndex = 5;
            this.BotonInicioSesion.Text = "Iniciar sesión";
            this.BotonInicioSesion.UseVisualStyleBackColor = true;
            this.BotonInicioSesion.Click += new System.EventHandler(this.BotonInicioSesion_Click);
            // 
            // BotonRegistroCuenta
            // 
            this.BotonRegistroCuenta.Enabled = false;
            this.BotonRegistroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegistroCuenta.Location = new System.Drawing.Point(297, 261);
            this.BotonRegistroCuenta.Name = "BotonRegistroCuenta";
            this.BotonRegistroCuenta.Size = new System.Drawing.Size(179, 63);
            this.BotonRegistroCuenta.TabIndex = 6;
            this.BotonRegistroCuenta.Text = "Registrar la cuenta";
            this.BotonRegistroCuenta.UseVisualStyleBackColor = true;
            this.BotonRegistroCuenta.Click += new System.EventHandler(this.BotonRegistroCuenta_Click);
            // 
            // OpcionCuentaNueva
            // 
            this.OpcionCuentaNueva.AutoSize = true;
            this.OpcionCuentaNueva.Location = new System.Drawing.Point(102, 155);
            this.OpcionCuentaNueva.Name = "OpcionCuentaNueva";
            this.OpcionCuentaNueva.Size = new System.Drawing.Size(215, 20);
            this.OpcionCuentaNueva.TabIndex = 7;
            this.OpcionCuentaNueva.TabStop = true;
            this.OpcionCuentaNueva.Text = "No tengo una cuenta registrada";
            this.OpcionCuentaNueva.UseVisualStyleBackColor = true;
            this.OpcionCuentaNueva.CheckedChanged += new System.EventHandler(this.OpcionCuentaNueva_CheckedChanged);
            // 
            // BotonCierreSesion
            // 
            this.BotonCierreSesion.Enabled = false;
            this.BotonCierreSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCierreSesion.Location = new System.Drawing.Point(201, 330);
            this.BotonCierreSesion.Name = "BotonCierreSesion";
            this.BotonCierreSesion.Size = new System.Drawing.Size(179, 63);
            this.BotonCierreSesion.TabIndex = 8;
            this.BotonCierreSesion.Text = "Cerrar sesión";
            this.BotonCierreSesion.UseVisualStyleBackColor = true;
            this.BotonCierreSesion.Click += new System.EventHandler(this.BotonCierreSesion_Click);
            // 
            // TablaUsuariosConectados
            // 
            this.TablaUsuariosConectados.AllowUserToAddRows = false;
            this.TablaUsuariosConectados.AllowUserToDeleteRows = false;
            this.TablaUsuariosConectados.AllowUserToOrderColumns = true;
            this.TablaUsuariosConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaUsuariosConectados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.TablaUsuariosConectados.Location = new System.Drawing.Point(1017, 30);
            this.TablaUsuariosConectados.Name = "TablaUsuariosConectados";
            this.TablaUsuariosConectados.ReadOnly = true;
            this.TablaUsuariosConectados.RowHeadersWidth = 51;
            this.TablaUsuariosConectados.RowTemplate.Height = 24;
            this.TablaUsuariosConectados.RowTemplate.ReadOnly = true;
            this.TablaUsuariosConectados.Size = new System.Drawing.Size(321, 191);
            this.TablaUsuariosConectados.TabIndex = 9;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // LabelUsuarioConsultado
            // 
            this.LabelUsuarioConsultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelUsuarioConsultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuarioConsultado.Location = new System.Drawing.Point(590, 30);
            this.LabelUsuarioConsultado.Name = "LabelUsuarioConsultado";
            this.LabelUsuarioConsultado.ReadOnly = true;
            this.LabelUsuarioConsultado.Size = new System.Drawing.Size(87, 30);
            this.LabelUsuarioConsultado.TabIndex = 10;
            this.LabelUsuarioConsultado.TabStop = false;
            this.LabelUsuarioConsultado.Text = "Usuario:";
            // 
            // UsuarioaConsultar
            // 
            this.UsuarioaConsultar.Location = new System.Drawing.Point(704, 37);
            this.UsuarioaConsultar.Name = "UsuarioaConsultar";
            this.UsuarioaConsultar.Size = new System.Drawing.Size(198, 22);
            this.UsuarioaConsultar.TabIndex = 11;
            // 
            // LabelConsulta
            // 
            this.LabelConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConsulta.Location = new System.Drawing.Point(590, 118);
            this.LabelConsulta.Name = "LabelConsulta";
            this.LabelConsulta.ReadOnly = true;
            this.LabelConsulta.Size = new System.Drawing.Size(99, 30);
            this.LabelConsulta.TabIndex = 12;
            this.LabelConsulta.TabStop = false;
            this.LabelConsulta.Text = "Consulta:";
            // 
            // Consulta
            // 
            this.Consulta.FormattingEnabled = true;
            this.Consulta.Items.AddRange(new object[] {
            "Partidas ganadas",
            "Puntos obtenidos",
            "Partidas jugadas"});
            this.Consulta.Location = new System.Drawing.Point(718, 127);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(184, 24);
            this.Consulta.TabIndex = 13;
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonConsulta.Location = new System.Drawing.Point(643, 178);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(149, 29);
            this.BotonConsulta.TabIndex = 14;
            this.BotonConsulta.Text = "Consultar";
            this.BotonConsulta.UseVisualStyleBackColor = true;
            // 
            // LabelResultado
            // 
            this.LabelResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultado.Location = new System.Drawing.Point(590, 294);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.ReadOnly = true;
            this.LabelResultado.Size = new System.Drawing.Size(102, 30);
            this.LabelResultado.TabIndex = 15;
            this.LabelResultado.TabStop = false;
            this.LabelResultado.Text = "Resultado:";
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(718, 302);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(198, 22);
            this.Resultado.TabIndex = 16;
            // 
            // timer1
            // 
          
            // 
            // PantallaSesionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 410);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.BotonConsulta);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.LabelConsulta);
            this.Controls.Add(this.UsuarioaConsultar);
            this.Controls.Add(this.LabelUsuarioConsultado);
            this.Controls.Add(this.TablaUsuariosConectados);
            this.Controls.Add(this.BotonCierreSesion);
            this.Controls.Add(this.OpcionCuentaNueva);
            this.Controls.Add(this.BotonRegistroCuenta);
            this.Controls.Add(this.BotonInicioSesion);
            this.Controls.Add(this.OpcionInicioSesion);
            this.Controls.Add(this.LabelContrasena);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.Usuario);
            this.Name = "PantallaSesionUsuario";
            this.Text = "Head Soccer - Inicio de sesión/Registro";
            
            ((System.ComponentModel.ISupportInitialize)(this.TablaUsuariosConectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.MaskedTextBox Contrasena;
        private System.Windows.Forms.TextBox LabelUsuario;
        private System.Windows.Forms.TextBox LabelContrasena;
        private System.Windows.Forms.RadioButton OpcionInicioSesion;
        private System.Windows.Forms.Button BotonInicioSesion;
        private System.Windows.Forms.Button BotonRegistroCuenta;
        private System.Windows.Forms.RadioButton OpcionCuentaNueva;
        private System.Windows.Forms.Button BotonCierreSesion;
        private System.Windows.Forms.DataGridView TablaUsuariosConectados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.TextBox LabelUsuarioConsultado;
        private System.Windows.Forms.TextBox UsuarioaConsultar;
        private System.Windows.Forms.TextBox LabelConsulta;
        private System.Windows.Forms.ComboBox Consulta;
        private System.Windows.Forms.Button BotonConsulta;
        private System.Windows.Forms.TextBox LabelResultado;
        public System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Timer timer1;
    }
}

