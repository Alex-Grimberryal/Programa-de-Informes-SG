namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    partial class ExportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportData));
            txtRutaDestino = new TextBox();
            panel1 = new Panel();
            LABEL1 = new Label();
            btnSeleccionarRuta = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRutaDestino
            // 
            txtRutaDestino.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtRutaDestino.Location = new Point(40, 208);
            txtRutaDestino.Name = "txtRutaDestino";
            txtRutaDestino.PlaceholderText = "Ingrese ruta de destino";
            txtRutaDestino.Size = new Size(745, 40);
            txtRutaDestino.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LABEL1);
            panel1.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(830, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 656);
            panel1.TabIndex = 1;
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Location = new Point(14, 80);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(402, 504);
            LABEL1.TabIndex = 0;
            LABEL1.Text = resources.GetString("LABEL1.Text");
            // 
            // btnSeleccionarRuta
            // 
            btnSeleccionarRuta.BackColor = Color.Turquoise;
            btnSeleccionarRuta.Cursor = Cursors.Hand;
            btnSeleccionarRuta.FlatAppearance.BorderSize = 0;
            btnSeleccionarRuta.FlatStyle = FlatStyle.Flat;
            btnSeleccionarRuta.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionarRuta.Location = new Point(40, 264);
            btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            btnSeleccionarRuta.Size = new Size(745, 43);
            btnSeleccionarRuta.TabIndex = 2;
            btnSeleccionarRuta.Text = "Buscar Ruta";
            btnSeleccionarRuta.UseVisualStyleBackColor = false;
            btnSeleccionarRuta.Click += btnSeleccionarRuta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 98);
            label2.Name = "label2";
            label2.Size = new Size(327, 53);
            label2.TabIndex = 3;
            label2.Text = "Generar Respaldo";
            // 
            // ExportData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(label2);
            Controls.Add(btnSeleccionarRuta);
            Controls.Add(panel1);
            Controls.Add(txtRutaDestino);
            Name = "ExportData";
            Size = new Size(1276, 692);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRutaDestino;
        private Panel panel1;
        private Label LABEL1;
        private Button btnSeleccionarRuta;
        private Label label2;
    }
}
