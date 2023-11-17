namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    partial class UserControl2
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
            vistaInformes = new DataGridView();
            DTPfechaInicio = new DateTimePicker();
            DTPfechaFin = new DateTimePicker();
            btnFiltrar = new Button();
            txtNroInforme = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)vistaInformes).BeginInit();
            SuspendLayout();
            // 
            // vistaInformes
            // 
            vistaInformes.BackgroundColor = SystemColors.ActiveCaption;
            vistaInformes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vistaInformes.Location = new Point(15, 184);
            vistaInformes.Name = "vistaInformes";
            vistaInformes.RowHeadersWidth = 51;
            vistaInformes.RowTemplate.Height = 29;
            vistaInformes.Size = new Size(1285, 629);
            vistaInformes.TabIndex = 1;
            // 
            // DTPfechaInicio
            // 
            DTPfechaInicio.CalendarFont = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            DTPfechaInicio.Cursor = Cursors.Hand;
            DTPfechaInicio.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            DTPfechaInicio.Format = DateTimePickerFormat.Short;
            DTPfechaInicio.Location = new Point(540, 123);
            DTPfechaInicio.Name = "DTPfechaInicio";
            DTPfechaInicio.RightToLeft = RightToLeft.No;
            DTPfechaInicio.Size = new Size(250, 40);
            DTPfechaInicio.TabIndex = 2;
            DTPfechaInicio.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // DTPfechaFin
            // 
            DTPfechaFin.CalendarFont = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            DTPfechaFin.Cursor = Cursors.Hand;
            DTPfechaFin.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            DTPfechaFin.Format = DateTimePickerFormat.Short;
            DTPfechaFin.Location = new Point(819, 123);
            DTPfechaFin.Name = "DTPfechaFin";
            DTPfechaFin.RightToLeft = RightToLeft.No;
            DTPfechaFin.Size = new Size(250, 40);
            DTPfechaFin.TabIndex = 3;
            DTPfechaFin.Value = new DateTime(2023, 11, 15, 0, 0, 0, 0);
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.Cyan;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrar.Location = new Point(1096, 122);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(204, 41);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtNroInforme
            // 
            txtNroInforme.Font = new Font("Bahnschrift SemiBold SemiConden", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txtNroInforme.Location = new Point(15, 122);
            txtNroInforme.Name = "txtNroInforme";
            txtNroInforme.Size = new Size(502, 40);
            txtNroInforme.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(543, 57);
            label1.TabIndex = 7;
            label1.Text = "Seleccione o Filtre informes";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.MidnightBlue;
            Controls.Add(label1);
            Controls.Add(txtNroInforme);
            Controls.Add(btnFiltrar);
            Controls.Add(DTPfechaFin);
            Controls.Add(DTPfechaInicio);
            Controls.Add(vistaInformes);
            Name = "UserControl2";
            Size = new Size(1319, 825);
            Load += UserControl2_Load;
            ((System.ComponentModel.ISupportInitialize)vistaInformes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView vistaInformes;
        private DateTimePicker DTPfechaInicio;
        private DateTimePicker DTPfechaFin;
        private Button btnFiltrar;
        private TextBox txtNroInforme;
        private Label label1;
    }
}
