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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contrasena = new System.Windows.Forms.MaskedTextBox();
            this.LabelUsuario = new System.Windows.Forms.TextBox();
            this.LabelContrasena = new System.Windows.Forms.TextBox();
            this.OpcionInicioSesion = new System.Windows.Forms.RadioButton();
            this.BotonInicioSesion = new System.Windows.Forms.Button();
            this.BotonRegistroCuenta = new System.Windows.Forms.Button();
            this.OpcionCuentaNueva = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.Khaki;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(253, 157);
            this.Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(237, 30);
            this.Usuario.TabIndex = 0;
            // 
            // Contrasena
            // 
            this.Contrasena.BackColor = System.Drawing.Color.Khaki;
            this.Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena.Location = new System.Drawing.Point(253, 191);
            this.Contrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(237, 30);
            this.Contrasena.TabIndex = 1;
            this.Contrasena.UseSystemPasswordChar = true;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.BackColor = System.Drawing.Color.Khaki;
            this.LabelUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelUsuario.Location = new System.Drawing.Point(91, 157);
            this.LabelUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.ReadOnly = true;
            this.LabelUsuario.Size = new System.Drawing.Size(125, 30);
            this.LabelUsuario.TabIndex = 2;
            this.LabelUsuario.Text = "Usuario:";
            // 
            // LabelContrasena
            // 
            this.LabelContrasena.BackColor = System.Drawing.Color.Khaki;
            this.LabelContrasena.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelContrasena.Location = new System.Drawing.Point(91, 191);
            this.LabelContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelContrasena.Name = "LabelContrasena";
            this.LabelContrasena.ReadOnly = true;
            this.LabelContrasena.Size = new System.Drawing.Size(125, 30);
            this.LabelContrasena.TabIndex = 3;
            this.LabelContrasena.Text = "Contraseña:";
            this.LabelContrasena.TextChanged += new System.EventHandler(this.LabelContrasena_TextChanged);
            // 
            // OpcionInicioSesion
            // 
            this.OpcionInicioSesion.AutoSize = true;
            this.OpcionInicioSesion.BackColor = System.Drawing.Color.Khaki;
            this.OpcionInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionInicioSesion.Location = new System.Drawing.Point(91, 95);
            this.OpcionInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpcionInicioSesion.Name = "OpcionInicioSesion";
            this.OpcionInicioSesion.Size = new System.Drawing.Size(144, 20);
            this.OpcionInicioSesion.TabIndex = 4;
            this.OpcionInicioSesion.TabStop = true;
            this.OpcionInicioSesion.Text = "Ya estoy registrado";
            this.OpcionInicioSesion.UseVisualStyleBackColor = false;
            this.OpcionInicioSesion.CheckedChanged += new System.EventHandler(this.OpcionInicioSesion_CheckedChanged);
            // 
            // BotonInicioSesion
            // 
            this.BotonInicioSesion.BackColor = System.Drawing.Color.Khaki;
            this.BotonInicioSesion.Enabled = false;
            this.BotonInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInicioSesion.Location = new System.Drawing.Point(2, 311);
            this.BotonInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonInicioSesion.Name = "BotonInicioSesion";
            this.BotonInicioSesion.Size = new System.Drawing.Size(179, 63);
            this.BotonInicioSesion.TabIndex = 5;
            this.BotonInicioSesion.Text = "Iniciar sesión";
            this.BotonInicioSesion.UseVisualStyleBackColor = false;
            this.BotonInicioSesion.Click += new System.EventHandler(this.BotonInicioSesion_Click);
            // 
            // BotonRegistroCuenta
            // 
            this.BotonRegistroCuenta.BackColor = System.Drawing.Color.Khaki;
            this.BotonRegistroCuenta.Enabled = false;
            this.BotonRegistroCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegistroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegistroCuenta.Location = new System.Drawing.Point(366, 311);
            this.BotonRegistroCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonRegistroCuenta.Name = "BotonRegistroCuenta";
            this.BotonRegistroCuenta.Size = new System.Drawing.Size(179, 63);
            this.BotonRegistroCuenta.TabIndex = 6;
            this.BotonRegistroCuenta.Text = "Registrar la cuenta";
            this.BotonRegistroCuenta.UseVisualStyleBackColor = false;
            this.BotonRegistroCuenta.Click += new System.EventHandler(this.BotonRegistroCuenta_Click);
            // 
            // OpcionCuentaNueva
            // 
            this.OpcionCuentaNueva.AutoSize = true;
            this.OpcionCuentaNueva.BackColor = System.Drawing.Color.Khaki;
            this.OpcionCuentaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionCuentaNueva.Location = new System.Drawing.Point(90, 119);
            this.OpcionCuentaNueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpcionCuentaNueva.Name = "OpcionCuentaNueva";
            this.OpcionCuentaNueva.Size = new System.Drawing.Size(145, 20);
            this.OpcionCuentaNueva.TabIndex = 7;
            this.OpcionCuentaNueva.TabStop = true;
            this.OpcionCuentaNueva.Text = "No estoy registrado";
            this.OpcionCuentaNueva.UseVisualStyleBackColor = false;
            this.OpcionCuentaNueva.CheckedChanged += new System.EventHandler(this.OpcionCuentaNueva_CheckedChanged);
            // 
            // PantallaSesionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(613, 428);
            this.Controls.Add(this.OpcionCuentaNueva);
            this.Controls.Add(this.BotonRegistroCuenta);
            this.Controls.Add(this.BotonInicioSesion);
            this.Controls.Add(this.OpcionInicioSesion);
            this.Controls.Add(this.LabelContrasena);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.Usuario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaSesionUsuario";
            this.Text = "REGISTRATE Y INICIO SESION";
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
        private System.Windows.Forms.TextBox FechaP;
    }
}

