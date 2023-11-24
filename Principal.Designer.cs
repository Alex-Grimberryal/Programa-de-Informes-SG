namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panel1 = new Panel();
            lblBienvenido = new Label();
            label1 = new Label();
            panel2 = new Panel();
            opciones = new Button();
            pictureBox2 = new PictureBox();
            btnNuevoInforme = new Button();
            btnVerInformes = new Button();
            actividad = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(lblBienvenido);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 160);
            panel1.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Bahnschrift Condensed", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.Location = new Point(1425, 58);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(0, 41);
            lblBienvenido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 0);
            label1.Name = "label1";
            label1.Size = new Size(1365, 144);
            label1.TabIndex = 0;
            label1.Text = "SG COMUNICACIONES Y SEGURIDAD";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(opciones);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnNuevoInforme);
            panel2.Controls.Add(btnVerInformes);
            panel2.Location = new Point(1, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 876);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // opciones
            // 
            opciones.BackColor = Color.SkyBlue;
            opciones.FlatAppearance.BorderSize = 0;
            opciones.FlatStyle = FlatStyle.Flat;
            opciones.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            opciones.Location = new Point(-13, 479);
            opciones.Name = "opciones";
            opciones.Size = new Size(551, 202);
            opciones.TabIndex = 5;
            opciones.Text = "Opciones";
            opciones.UseVisualStyleBackColor = false;
            opciones.Click += opciones_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(68, 728);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(383, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnNuevoInforme
            // 
            btnNuevoInforme.BackColor = Color.SkyBlue;
            btnNuevoInforme.FlatAppearance.BorderSize = 0;
            btnNuevoInforme.FlatStyle = FlatStyle.Flat;
            btnNuevoInforme.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoInforme.Location = new Point(-13, 249);
            btnNuevoInforme.Name = "btnNuevoInforme";
            btnNuevoInforme.Size = new Size(551, 202);
            btnNuevoInforme.TabIndex = 1;
            btnNuevoInforme.Text = "Crear Nuevo Informe";
            btnNuevoInforme.UseVisualStyleBackColor = false;
            btnNuevoInforme.Click += btnNuevoInforme_Click_1;
            // 
            // btnVerInformes
            // 
            btnVerInformes.BackColor = Color.SkyBlue;
            btnVerInformes.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnVerInformes.FlatAppearance.BorderSize = 0;
            btnVerInformes.FlatStyle = FlatStyle.Flat;
            btnVerInformes.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerInformes.Location = new Point(-13, 22);
            btnVerInformes.Name = "btnVerInformes";
            btnVerInformes.Size = new Size(551, 202);
            btnVerInformes.TabIndex = 0;
            btnVerInformes.Text = "Ver Resumen de Actividades";
            btnVerInformes.UseVisualStyleBackColor = false;
            btnVerInformes.Click += BtnVerInformes_Click;
            // 
            // actividad
            // 
            actividad.Location = new Point(558, 179);
            actividad.Name = "actividad";
            actividad.Size = new Size(1319, 825);
            actividad.TabIndex = 2;
            actividad.Paint += actividad_Paint;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1541, 1031);
            Controls.Add(actividad);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "SG COMUNICACIONES Y SEGURIDAD";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnNuevoInforme;
        private Button btnVerInformes;
        private Panel actividad;
        private Label label1;
        private PictureBox pictureBox2;
        private Button opciones;
        private Label lblBienvenido;
    }
}