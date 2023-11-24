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
            txtDNI = new TextBox();
            label11 = new Label();
            CBtecnico = new ComboBox();
            NtAdd = new TextBox();
            txtDireccion = new TextBox();
            label9 = new Label();
            txtTelefono = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            txtCliente = new TextBox();
            nroRegistro = new TextBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            DTPfechaActual = new DateTimePicker();
            label5 = new Label();
            panel5 = new Panel();
            AbrirModalArticulos = new Button();
            txtMonto = new TextBox();
            label6 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(CBtecnico);
            panel1.Controls.Add(NtAdd);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtCliente);
            panel1.Controls.Add(nroRegistro);
            panel1.Controls.Add(label7);
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
            // txtDNI
            // 
            txtDNI.BackColor = Color.LightCyan;
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDNI.Location = new Point(283, 299);
            txtDNI.Multiline = true;
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Ingrese DNI";
            txtDNI.Size = new Size(294, 36);
            txtDNI.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DeepSkyBlue;
            label11.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(46, 299);
            label11.Name = "label11";
            label11.Size = new Size(185, 36);
            label11.TabIndex = 19;
            label11.Text = "            DNI           ";
            // 
            // CBtecnico
            // 
            CBtecnico.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CBtecnico.FormattingEnabled = true;
            CBtecnico.Location = new Point(285, 425);
            CBtecnico.Name = "CBtecnico";
            CBtecnico.Size = new Size(294, 32);
            CBtecnico.TabIndex = 18;
            // 
            // NtAdd
            // 
            NtAdd.BackColor = Color.LightCyan;
            NtAdd.BorderStyle = BorderStyle.None;
            NtAdd.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NtAdd.Location = new Point(285, 577);
            NtAdd.Multiline = true;
            NtAdd.Name = "NtAdd";
            NtAdd.PlaceholderText = "Ingrese indicaciones extra (opcional)";
            NtAdd.Size = new Size(294, 167);
            NtAdd.TabIndex = 17;
            NtAdd.TextChanged += textBox9_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.LightCyan;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(285, 481);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Ingrese direccion";
            txtDireccion.Size = new Size(294, 72);
            txtDireccion.TabIndex = 16;
            txtDireccion.TextChanged += textBox8_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DeepSkyBlue;
            label9.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(48, 577);
            label9.Name = "label9";
            label9.Size = new Size(183, 72);
            label9.TabIndex = 5;
            label9.Text = "          Notas    \r\n     Adicionales    ";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightCyan;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTelefono.Location = new Point(436, 360);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Celular";
            txtTelefono.Size = new Size(143, 36);
            txtTelefono.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DeepSkyBlue;
            label8.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(48, 481);
            label8.Name = "label8";
            label8.Size = new Size(185, 72);
            label8.TabIndex = 4;
            label8.Text = "    Dirección de    \r\n     Instalación";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightCyan;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(285, 360);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo Electronico";
            txtEmail.Size = new Size(128, 36);
            txtEmail.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DeepSkyBlue;
            label10.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(48, 425);
            label10.Name = "label10";
            label10.Size = new Size(190, 36);
            label10.TabIndex = 6;
            label10.Text = "  Técnico a cargo  ";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.LightCyan;
            txtCliente.BorderStyle = BorderStyle.None;
            txtCliente.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCliente.Location = new Point(283, 236);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Apellido paterno - materno -nombres";
            txtCliente.Size = new Size(294, 36);
            txtCliente.TabIndex = 10;
            txtCliente.TextChanged += textBox2_TextChanged;
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
            label7.Location = new Point(48, 360);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(186, 36);
            label7.TabIndex = 8;
            label7.Text = "       Contacto       ";
            label7.Click += label7_Click;
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
            label1.Location = new Point(91, 25);
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
            // DTPfechaActual
            // 
            DTPfechaActual.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DTPfechaActual.Format = DateTimePickerFormat.Short;
            DTPfechaActual.Location = new Point(262, 29);
            DTPfechaActual.Name = "DTPfechaActual";
            DTPfechaActual.Size = new Size(317, 32);
            DTPfechaActual.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DeepSkyBlue;
            label5.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 25);
            label5.Name = "label5";
            label5.Size = new Size(188, 36);
            label5.TabIndex = 6;
            label5.Text = "          Fecha         ";
            label5.Click += label5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Controls.Add(AbrirModalArticulos);
            panel5.Location = new Point(264, 79);
            panel5.Name = "panel5";
            panel5.Size = new Size(315, 241);
            panel5.TabIndex = 16;
            // 
            // AbrirModalArticulos
            // 
            AbrirModalArticulos.Font = new Font("Bahnschrift SemiBold Condensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AbrirModalArticulos.Location = new Point(19, 7);
            AbrirModalArticulos.Name = "AbrirModalArticulos";
            AbrirModalArticulos.Size = new Size(278, 33);
            AbrirModalArticulos.TabIndex = 0;
            AbrirModalArticulos.Text = "Ingresar Articulos";
            AbrirModalArticulos.UseVisualStyleBackColor = true;
            AbrirModalArticulos.Click += AbrirModalArticulos_Click;
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.LightCyan;
            txtMonto.BorderStyle = BorderStyle.None;
            txtMonto.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMonto.Location = new Point(264, 351);
            txtMonto.Multiline = true;
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(315, 36);
            txtMonto.TabIndex = 15;
            txtMonto.TextChanged += textBox7_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 351);
            label6.Name = "label6";
            label6.Size = new Size(187, 36);
            label6.TabIndex = 7;
            label6.Text = "     Monto Total     ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DeepSkyBlue;
            label4.Font = new Font("Bahnschrift SemiBold Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 77);
            label4.Name = "label4";
            label4.Size = new Size(187, 72);
            label4.TabIndex = 5;
            label4.Text = "       Articulos \r\n     solicitados      ";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(DTPfechaActual);
            panel3.Controls.Add(txtMonto);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(679, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(616, 406);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Location = new Point(630, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(638, 776);
            panel4.TabIndex = 1;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(1319, 825);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtCliente;
        private TextBox nroRegistro;
        private TextBox txtMonto;
        private TextBox txtDireccion;
        private TextBox NtAdd;
        private Panel panel5;
        private Button AbrirModalArticulos;
        private ComboBox CBtecnico;
        private DateTimePicker DTPfechaActual;
        private TextBox txtDNI;
        private Label label11;
    }
}
