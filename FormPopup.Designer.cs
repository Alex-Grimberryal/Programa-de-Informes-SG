namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    partial class FormPopup
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
            label1 = new Label();
            label2 = new Label();
            verArticulos = new ListBox();
            button1 = new Button();
            panel1 = new Panel();
            direccion = new Label();
            direcion = new Label();
            redactor = new Label();
            monto = new Label();
            tecnico = new Label();
            fecha = new Label();
            correo = new Label();
            telefono = new Label();
            dni = new Label();
            nombre = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            inf = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 99);
            label1.Name = "label1";
            label1.Size = new Size(296, 48);
            label1.TabIndex = 1;
            label1.Text = "Datos del Informe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(752, 99);
            label2.Name = "label2";
            label2.Size = new Size(310, 48);
            label2.TabIndex = 2;
            label2.Text = "Articulos Vendidos";
            // 
            // verArticulos
            // 
            verArticulos.FormattingEnabled = true;
            verArticulos.ItemHeight = 20;
            verArticulos.Location = new Point(621, 160);
            verArticulos.Name = "verArticulos";
            verArticulos.Size = new Size(549, 384);
            verArticulos.TabIndex = 3;
            verArticulos.SelectedIndexChanged += verArticulos_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiBold SemiConden", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(621, 568);
            button1.Name = "button1";
            button1.Size = new Size(549, 173);
            button1.TabIndex = 4;
            button1.Text = "GENERAR PDF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(direccion);
            panel1.Controls.Add(direcion);
            panel1.Controls.Add(redactor);
            panel1.Controls.Add(monto);
            panel1.Controls.Add(tecnico);
            panel1.Controls.Add(fecha);
            panel1.Controls.Add(correo);
            panel1.Controls.Add(telefono);
            panel1.Controls.Add(dni);
            panel1.Controls.Add(nombre);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 581);
            panel1.TabIndex = 5;
            // 
            // direccion
            // 
            direccion.AutoSize = true;
            direccion.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            direccion.Location = new Point(20, 430);
            direccion.Name = "direccion";
            direccion.Size = new Size(247, 34);
            direccion.TabIndex = 18;
            direccion.Text = "Direccion Instalaciòn:";
            // 
            // direcion
            // 
            direcion.AutoSize = true;
            direcion.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            direcion.Location = new Point(285, 430);
            direcion.Name = "direcion";
            direcion.Size = new Size(36, 34);
            direcion.TabIndex = 17;
            direcion.Text = "   ";
            // 
            // redactor
            // 
            redactor.AutoSize = true;
            redactor.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            redactor.Location = new Point(285, 486);
            redactor.Name = "redactor";
            redactor.Size = new Size(36, 34);
            redactor.TabIndex = 16;
            redactor.Text = "   ";
            redactor.Click += redactor_Click;
            // 
            // monto
            // 
            monto.AutoSize = true;
            monto.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            monto.Location = new Point(285, 376);
            monto.Name = "monto";
            monto.Size = new Size(36, 34);
            monto.TabIndex = 15;
            monto.Text = "   ";
            // 
            // tecnico
            // 
            tecnico.AutoSize = true;
            tecnico.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tecnico.Location = new Point(285, 312);
            tecnico.Name = "tecnico";
            tecnico.Size = new Size(36, 34);
            tecnico.TabIndex = 14;
            tecnico.Text = "   ";
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            fecha.Location = new Point(285, 248);
            fecha.Name = "fecha";
            fecha.Size = new Size(36, 34);
            fecha.TabIndex = 13;
            fecha.Text = "   ";
            // 
            // correo
            // 
            correo.AutoSize = true;
            correo.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            correo.Location = new Point(285, 186);
            correo.Name = "correo";
            correo.Size = new Size(36, 34);
            correo.TabIndex = 12;
            correo.Text = "   ";
            correo.Click += correo_Click;
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            telefono.Location = new Point(285, 124);
            telefono.Name = "telefono";
            telefono.Size = new Size(36, 34);
            telefono.TabIndex = 11;
            telefono.Text = "   ";
            // 
            // dni
            // 
            dni.AutoSize = true;
            dni.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            dni.Location = new Point(285, 67);
            dni.Name = "dni";
            dni.Size = new Size(36, 34);
            dni.TabIndex = 10;
            dni.Text = "   ";
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            nombre.Location = new Point(285, 17);
            nombre.Name = "nombre";
            nombre.Size = new Size(36, 34);
            nombre.TabIndex = 9;
            nombre.Text = "   ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(20, 533);
            label11.Name = "label11";
            label11.Size = new Size(214, 34);
            label11.TabIndex = 8;
            label11.Text = "Notas Adicionales:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(20, 486);
            label10.Name = "label10";
            label10.Size = new Size(115, 34);
            label10.TabIndex = 7;
            label10.Text = "Redactor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(20, 376);
            label9.Name = "label9";
            label9.Size = new Size(146, 34);
            label9.TabIndex = 6;
            label9.Text = "Monto Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 312);
            label8.Name = "label8";
            label8.Size = new Size(100, 34);
            label8.TabIndex = 5;
            label8.Text = "Técnico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(20, 248);
            label7.Name = "label7";
            label7.Size = new Size(86, 34);
            label7.TabIndex = 4;
            label7.Text = "Fecha:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 186);
            label6.Name = "label6";
            label6.Size = new Size(223, 34);
            label6.TabIndex = 3;
            label6.Text = "Correo Electronico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 124);
            label5.Name = "label5";
            label5.Size = new Size(111, 34);
            label5.TabIndex = 2;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 67);
            label4.Name = "label4";
            label4.Size = new Size(58, 34);
            label4.TabIndex = 1;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 17);
            label3.Name = "label3";
            label3.Size = new Size(229, 34);
            label3.TabIndex = 0;
            label3.Text = "Nombre del Cliente:";
            // 
            // inf
            // 
            inf.AutoSize = true;
            inf.Font = new Font("Bahnschrift SemiBold SemiConden", 24F, FontStyle.Bold, GraphicsUnit.Point);
            inf.Location = new Point(443, 26);
            inf.Name = "inf";
            inf.Size = new Size(47, 48);
            inf.TabIndex = 6;
            inf.Text = "   ";
            // 
            // FormPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1182, 753);
            Controls.Add(inf);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(verArticulos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPopup";
            Text = "Ver Informe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ListBox verArticulos;
        private Button button1;
        private Panel panel1;
        private Label inf;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label dni;
        private Label nombre;
        private Label label11;
        private Label label10;
        private Label redactor;
        private Label monto;
        private Label tecnico;
        private Label fecha;
        private Label correo;
        private Label telefono;
        private Label label13;
        private Label direcion;
        private Label direccion;
    }
}