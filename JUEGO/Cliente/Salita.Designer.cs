namespace Cliente
{
    partial class Salita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelUsuarioConsultado = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.LabelConsulta = new System.Windows.Forms.TextBox();
            this.Consulta = new System.Windows.Forms.ComboBox();
            this.LabelResultado = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.CONSULTAR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FechaP = new System.Windows.Forms.TextBox();
            this.DESCONECTAR = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.LC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelUsuarioConsultado
            // 
            this.LabelUsuarioConsultado.BackColor = System.Drawing.Color.Khaki;
            this.LabelUsuarioConsultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelUsuarioConsultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuarioConsultado.Location = new System.Drawing.Point(35, 25);
            this.LabelUsuarioConsultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelUsuarioConsultado.Name = "LabelUsuarioConsultado";
            this.LabelUsuarioConsultado.ReadOnly = true;
            this.LabelUsuarioConsultado.Size = new System.Drawing.Size(87, 30);
            this.LabelUsuarioConsultado.TabIndex = 0;
            this.LabelUsuarioConsultado.TabStop = false;
            this.LabelUsuarioConsultado.Text = "Usuario:";
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.Khaki;
            this.Usuario.Location = new System.Drawing.Point(139, 31);
            this.Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(199, 22);
            this.Usuario.TabIndex = 1;
            // 
            // LabelConsulta
            // 
            this.LabelConsulta.BackColor = System.Drawing.Color.Khaki;
            this.LabelConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConsulta.Location = new System.Drawing.Point(35, 154);
            this.LabelConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelConsulta.Name = "LabelConsulta";
            this.LabelConsulta.ReadOnly = true;
            this.LabelConsulta.Size = new System.Drawing.Size(99, 30);
            this.LabelConsulta.TabIndex = 2;
            this.LabelConsulta.TabStop = false;
            this.LabelConsulta.Text = "Consulta:";
            // 
            // Consulta
            // 
            this.Consulta.BackColor = System.Drawing.Color.Khaki;
            this.Consulta.FormattingEnabled = true;
            this.Consulta.Items.AddRange(new object[] {
            "Partidas ganadas",
            "Puntos obtenidos",
            "Partidas jugadas",
            "Usuario que jugo en dicha fecha"});
            this.Consulta.Location = new System.Drawing.Point(164, 161);
            this.Consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(228, 24);
            this.Consulta.TabIndex = 4;
            // 
            // LabelResultado
            // 
            this.LabelResultado.BackColor = System.Drawing.Color.Khaki;
            this.LabelResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResultado.Location = new System.Drawing.Point(35, 254);
            this.LabelResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.ReadOnly = true;
            this.LabelResultado.Size = new System.Drawing.Size(103, 30);
            this.LabelResultado.TabIndex = 5;
            this.LabelResultado.TabStop = false;
            this.LabelResultado.Text = "Resultado:";
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.Color.Khaki;
            this.Resultado.Location = new System.Drawing.Point(143, 258);
            this.Resultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(199, 22);
            this.Resultado.TabIndex = 6;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // CONSULTAR
            // 
            this.CONSULTAR.BackColor = System.Drawing.Color.Khaki;
            this.CONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONSULTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSULTAR.Location = new System.Drawing.Point(374, 240);
            this.CONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CONSULTAR.Name = "CONSULTAR";
            this.CONSULTAR.Size = new System.Drawing.Size(187, 52);
            this.CONSULTAR.TabIndex = 7;
            this.CONSULTAR.Text = "Consultar";
            this.CONSULTAR.UseVisualStyleBackColor = false;
            this.CONSULTAR.Click += new System.EventHandler(this.BotonConsulta_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Khaki;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(35, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(191, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Fecha de la Partida:";
            // 
            // FechaP
            // 
            this.FechaP.BackColor = System.Drawing.Color.Khaki;
            this.FechaP.Location = new System.Drawing.Point(283, 79);
            this.FechaP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaP.Name = "FechaP";
            this.FechaP.Size = new System.Drawing.Size(199, 22);
            this.FechaP.TabIndex = 9;
            // 
            // DESCONECTAR
            // 
            this.DESCONECTAR.BackColor = System.Drawing.Color.Khaki;
            this.DESCONECTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DESCONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DESCONECTAR.Location = new System.Drawing.Point(44, 334);
            this.DESCONECTAR.Name = "DESCONECTAR";
            this.DESCONECTAR.Size = new System.Drawing.Size(294, 93);
            this.DESCONECTAR.TabIndex = 11;
            this.DESCONECTAR.Text = "DESCONECTAR";
            this.DESCONECTAR.UseVisualStyleBackColor = false;
            this.DESCONECTAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Khaki;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(576, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 356);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(611, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista Conectados";
            // 
            // LC
            // 
            this.LC.BackColor = System.Drawing.Color.Khaki;
            this.LC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LC.Location = new System.Drawing.Point(616, 414);
            this.LC.Name = "LC";
            this.LC.Size = new System.Drawing.Size(187, 109);
            this.LC.TabIndex = 14;
            this.LC.Text = "Clica para ver lista conectados";
            this.LC.UseVisualStyleBackColor = false;
            this.LC.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cliente.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(932, 543);
            this.Controls.Add(this.LC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.DESCONECTAR);
            this.Controls.Add(this.FechaP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CONSULTAR);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.LabelConsulta);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.LabelUsuarioConsultado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Salita";
            this.Text = "Salita";
            this.Load += new System.EventHandler(this.Salita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LabelUsuarioConsultado;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox LabelConsulta;
        private System.Windows.Forms.ComboBox Consulta;
        private System.Windows.Forms.TextBox LabelResultado;
        private System.Windows.Forms.Button CONSULTAR;
        public System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox FechaP;
        private System.Windows.Forms.Button DESCONECTAR;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LC;
    }
}