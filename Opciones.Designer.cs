namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    partial class Opciones
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
            articulos = new Button();
            MyC = new Button();
            tec = new Button();
            usuarios = new Button();
            expPDF = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(22, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1276, 692);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // articulos
            // 
            articulos.BackColor = Color.DarkTurquoise;
            articulos.BackgroundImageLayout = ImageLayout.None;
            articulos.Cursor = Cursors.Hand;
            articulos.FlatAppearance.BorderSize = 0;
            articulos.FlatStyle = FlatStyle.Flat;
            articulos.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            articulos.Location = new Point(22, 21);
            articulos.Name = "articulos";
            articulos.Size = new Size(224, 66);
            articulos.TabIndex = 1;
            articulos.Text = "Articulos";
            articulos.UseVisualStyleBackColor = false;
            articulos.Click += button1_Click;
            // 
            // MyC
            // 
            MyC.BackColor = Color.DarkTurquoise;
            MyC.BackgroundImageLayout = ImageLayout.None;
            MyC.Cursor = Cursors.Hand;
            MyC.FlatAppearance.BorderSize = 0;
            MyC.FlatStyle = FlatStyle.Flat;
            MyC.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            MyC.Location = new Point(289, 21);
            MyC.Name = "MyC";
            MyC.Size = new Size(224, 66);
            MyC.TabIndex = 2;
            MyC.Text = "Marcas y Categorias";
            MyC.UseVisualStyleBackColor = false;
            MyC.Click += MyC_Click;
            // 
            // tec
            // 
            tec.BackColor = Color.DarkTurquoise;
            tec.BackgroundImageLayout = ImageLayout.None;
            tec.Cursor = Cursors.Hand;
            tec.FlatAppearance.BorderSize = 0;
            tec.FlatStyle = FlatStyle.Flat;
            tec.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tec.Location = new Point(549, 21);
            tec.Name = "tec";
            tec.Size = new Size(224, 66);
            tec.TabIndex = 3;
            tec.Text = "Tecnicos";
            tec.UseVisualStyleBackColor = false;
            tec.Click += tec_Click;
            // 
            // usuarios
            // 
            usuarios.BackColor = Color.DarkTurquoise;
            usuarios.BackgroundImageLayout = ImageLayout.None;
            usuarios.Cursor = Cursors.Hand;
            usuarios.FlatAppearance.BorderSize = 0;
            usuarios.FlatStyle = FlatStyle.Flat;
            usuarios.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            usuarios.Location = new Point(814, 21);
            usuarios.Name = "usuarios";
            usuarios.Size = new Size(224, 66);
            usuarios.TabIndex = 2;
            usuarios.Text = "Usuarios";
            usuarios.UseVisualStyleBackColor = false;
            usuarios.Click += usuarios_Click;
            // 
            // expPDF
            // 
            expPDF.BackColor = Color.DarkTurquoise;
            expPDF.BackgroundImageLayout = ImageLayout.None;
            expPDF.Cursor = Cursors.Hand;
            expPDF.FlatAppearance.BorderSize = 0;
            expPDF.FlatStyle = FlatStyle.Flat;
            expPDF.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            expPDF.Location = new Point(1074, 21);
            expPDF.Name = "expPDF";
            expPDF.Size = new Size(224, 66);
            expPDF.TabIndex = 2;
            expPDF.Text = "Exportar Data";
            expPDF.UseVisualStyleBackColor = false;
            expPDF.Click += expPDF_Click;
            // 
            // Opciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(expPDF);
            Controls.Add(usuarios);
            Controls.Add(tec);
            Controls.Add(MyC);
            Controls.Add(articulos);
            Controls.Add(panel1);
            Name = "Opciones";
            Size = new Size(1319, 825);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button articulos;
        private Button MyC;
        private Button tec;
        private Button usuarios;
        private Button expPDF;
    }
}
