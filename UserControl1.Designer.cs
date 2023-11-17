namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            monto = new TextBox();
            fecha = new TextBox();
            telefono = new TextBox();
            email = new TextBox();
            cliente = new TextBox();
            nroRegistro = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            tecnico = new TextBox();
            NtAdd = new TextBox();
            direccion = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            RegistrarInforme = new Button();
            panel5 = new Panel();
            AbrirModalArticulos = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(monto);
            panel1.Controls.Add(fecha);
            panel1.Controls.Add(telefono);
            panel1.Controls.Add(email);
            panel1.Controls.Add(cliente);
            panel1.Controls.Add(nroRegistro);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(27, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 776);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // monto
            // 
            monto.BackColor = Color.LightCyan;
            monto.BorderStyle = BorderStyle.None;
            monto.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            monto.Location = new Point(283, 682);
            monto.Multiline = true;
            monto.Name = "monto";
            monto.Size = new Size(294, 36);
            monto.TabIndex = 15;
            monto.TextChanged += textBox7_TextChanged;
            // 
            // fecha
            // 
            fecha.BackColor = Color.LightCyan;
            fecha.BorderStyle = BorderStyle.None;
            fecha.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fecha.Location = new Point(283, 621);
            fecha.Multiline = true;
            fecha.Name = "fecha";
            fecha.Size = new Size(294, 36);
            fecha.TabIndex = 14;
            fecha.TextChanged += textBox6_TextChanged;
            // 
            // telefono
            // 
            telefono.BackColor = Color.LightCyan;
            telefono.BorderStyle = BorderStyle.None;
            telefono.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            telefono.Location = new Point(434, 296);
            telefono.Multiline = true;
            telefono.Name = "telefono";
            telefono.PlaceholderText = "Celular";
            telefono.Size = new Size(143, 36);
            telefono.TabIndex = 12;
            // 
            // email
            // 
            email.BackColor = Color.LightCyan;
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            email.Location = new Point(283, 296);
            email.Multiline = true;
            email.Name = "email";
            email.PlaceholderText = "Correo Electronico";
            email.Size = new Size(128, 36);
            email.TabIndex = 11;
            // 
            // cliente
            // 
            cliente.BackColor = Color.LightCyan;
            cliente.BorderStyle = BorderStyle.None;
            cliente.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cliente.Location = new Point(283, 236);
            cliente.Multiline = true;
            cliente.Name = "cliente";
            cliente.PlaceholderText = "Apellido paterno - materno -nombres";
            cliente.Size = new Size(294, 36);
            cliente.TabIndex = 10;
            cliente.TextChanged += textBox2_TextChanged;
            // 
            // nroRegistro
            // 
            nroRegistro.BackColor = Color.LightCyan;
            nroRegistro.BorderStyle = BorderStyle.None;
            nroRegistro.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nroRegistro.Location = new Point(283, 170);
            nroRegistro.Multiline = true;
            nroRegistro.Name = "nroRegistro";
            nroRegistro.Size = new Size(294, 36);
            nroRegistro.TabIndex = 9;
            nroRegistro.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DeepSkyBlue;
            label7.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(46, 296);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(186, 36);
            label7.TabIndex = 8;
            label7.Text = "       Contacto       ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(46, 682);
            label6.Name = "label6";
            label6.Size = new Size(187, 36);
            label6.TabIndex = 7;
            label6.Text = "     Monto Total     ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DeepSkyBlue;
            label5.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 621);
            label5.Name = "label5";
            label5.Size = new Size(188, 36);
            label5.TabIndex = 6;
            label5.Text = "          Fecha         ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DeepSkyBlue;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 360);
            label4.Name = "label4";
            label4.Size = new Size(187, 72);
            label4.TabIndex = 5;
            label4.Text = "       Articulos \r\n     solicitados      ";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DeepSkyBlue;
            label3.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 236);
            label3.Name = "label3";
            label3.Size = new Size(188, 36);
            label3.TabIndex = 4;
            label3.Text = "         Cliente        ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DeepSkyBlue;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 170);
            label2.Name = "label2";
            label2.Size = new Size(190, 36);
            label2.TabIndex = 3;
            label2.Text = "   N° de Registro   ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepSkyBlue;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 37);
            label1.Name = "label1";
            label1.Size = new Size(444, 72);
            label1.TabIndex = 2;
            label1.Text = "     Nuevo Registro     ";
            // 
            // panel2
            // 
            panel2.Location = new Point(630, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 776);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(tecnico);
            panel3.Controls.Add(NtAdd);
            panel3.Controls.Add(direccion);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(679, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(616, 406);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // tecnico
            // 
            tecnico.BackColor = Color.LightCyan;
            tecnico.BorderStyle = BorderStyle.None;
            tecnico.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tecnico.Location = new Point(284, 335);
            tecnico.Multiline = true;
            tecnico.Name = "tecnico";
            tecnico.Size = new Size(294, 36);
            tecnico.TabIndex = 18;
            tecnico.TextChanged += textBox10_TextChanged;
            // 
            // NtAdd
            // 
            NtAdd.BackColor = Color.LightCyan;
            NtAdd.BorderStyle = BorderStyle.None;
            NtAdd.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NtAdd.Location = new Point(284, 144);
            NtAdd.Multiline = true;
            NtAdd.Name = "NtAdd";
            NtAdd.Size = new Size(294, 167);
            NtAdd.TabIndex = 17;
            NtAdd.TextChanged += textBox9_TextChanged;
            // 
            // direccion
            // 
            direccion.BackColor = Color.LightCyan;
            direccion.BorderStyle = BorderStyle.None;
            direccion.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            direccion.Location = new Point(284, 37);
            direccion.Multiline = true;
            direccion.Name = "direccion";
            direccion.Size = new Size(294, 72);
            direccion.TabIndex = 16;
            direccion.TextChanged += textBox8_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DeepSkyBlue;
            label10.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(38, 335);
            label10.Name = "label10";
            label10.Size = new Size(178, 36);
            label10.TabIndex = 6;
            label10.Text = " Técnico a cargo ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DeepSkyBlue;
            label9.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(38, 144);
            label9.Name = "label9";
            label9.Size = new Size(183, 72);
            label9.TabIndex = 5;
            label9.Text = "          Notas    \r\n     Adicionales    ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DeepSkyBlue;
            label8.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 37);
            label8.Name = "label8";
            label8.Size = new Size(185, 72);
            label8.TabIndex = 4;
            label8.Text = "    Dirección de    \r\n     Instalación";
            // 
            // panel4
            // 
            panel4.Location = new Point(630, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(638, 776);
            panel4.TabIndex = 1;
            // 
            // RegistrarInforme
            // 
            RegistrarInforme.BackColor = Color.LightSteelBlue;
            RegistrarInforme.Font = new Font("Bahnschrift SemiBold Condensed", 72F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrarInforme.Location = new Point(718, 481);
            RegistrarInforme.Name = "RegistrarInforme";
            RegistrarInforme.Size = new Size(557, 288);
            RegistrarInforme.TabIndex = 3;
            RegistrarInforme.Text = "REGISTRAR";
            RegistrarInforme.UseVisualStyleBackColor = false;
            RegistrarInforme.Click += button1_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Controls.Add(AbrirModalArticulos);
            panel5.Location = new Point(283, 362);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 241);
            panel5.TabIndex = 16;
            // 
            // AbrirModalArticulos
            // 
            AbrirModalArticulos.Font = new Font("Bahnschrift SemiBold Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AbrirModalArticulos.Location = new Point(19, 7);
            AbrirModalArticulos.Name = "AbrirModalArticulos";
            AbrirModalArticulos.Size = new Size(252, 33);
            AbrirModalArticulos.TabIndex = 0;
            AbrirModalArticulos.Text = "Ingresar Articulos";
            AbrirModalArticulos.UseVisualStyleBackColor = true;
            AbrirModalArticulos.Click += AbrirModalArticulos_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(RegistrarInforme);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(1319, 825);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private TextBox telefono;
        private TextBox email;
        private TextBox cliente;
        private TextBox nroRegistro;
        private TextBox fecha;
        private TextBox monto;
        private TextBox direccion;
        private TextBox tecnico;
        private TextBox NtAdd;
        private Button RegistrarInforme;
        private Panel panel5;
        private Button AbrirModalArticulos;
    }
}
