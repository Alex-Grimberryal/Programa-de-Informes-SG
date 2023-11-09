namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    partial class articulos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ElArticulo = new Button();
            ModArticulo = new Button();
            InArticulo = new Button();
            VistaArticulos = new DataGridView();
            label3 = new Label();
            txtnombre = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            CBCategoria = new ComboBox();
            CBMarca = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)VistaArticulos).BeginInit();
            SuspendLayout();
            // 
            // ElArticulo
            // 
            ElArticulo.BackColor = Color.SkyBlue;
            ElArticulo.Cursor = Cursors.Hand;
            ElArticulo.FlatAppearance.BorderSize = 0;
            ElArticulo.FlatStyle = FlatStyle.Flat;
            ElArticulo.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ElArticulo.Location = new Point(296, 591);
            ElArticulo.Name = "ElArticulo";
            ElArticulo.Size = new Size(129, 73);
            ElArticulo.TabIndex = 6;
            ElArticulo.Text = "Eliminar";
            ElArticulo.UseVisualStyleBackColor = false;
            ElArticulo.Click += ElArticulo_Click;
            // 
            // ModArticulo
            // 
            ModArticulo.BackColor = Color.SkyBlue;
            ModArticulo.Cursor = Cursors.Hand;
            ModArticulo.FlatAppearance.BorderSize = 0;
            ModArticulo.FlatStyle = FlatStyle.Flat;
            ModArticulo.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ModArticulo.Location = new Point(161, 591);
            ModArticulo.Name = "ModArticulo";
            ModArticulo.Size = new Size(129, 73);
            ModArticulo.TabIndex = 5;
            ModArticulo.Text = "Editar";
            ModArticulo.UseVisualStyleBackColor = false;
            ModArticulo.Click += ModArticulo_Click;
            // 
            // InArticulo
            // 
            InArticulo.BackColor = Color.SkyBlue;
            InArticulo.Cursor = Cursors.Hand;
            InArticulo.FlatAppearance.BorderSize = 0;
            InArticulo.FlatStyle = FlatStyle.Flat;
            InArticulo.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            InArticulo.Location = new Point(26, 591);
            InArticulo.Name = "InArticulo";
            InArticulo.Size = new Size(129, 73);
            InArticulo.TabIndex = 4;
            InArticulo.Text = "Insertar";
            InArticulo.UseVisualStyleBackColor = false;
            InArticulo.Click += InArticulo_Click;
            // 
            // VistaArticulos
            // 
            VistaArticulos.BackgroundColor = SystemColors.ActiveCaption;
            VistaArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            VistaArticulos.DefaultCellStyle = dataGridViewCellStyle1;
            VistaArticulos.GridColor = SystemColors.GradientActiveCaption;
            VistaArticulos.Location = new Point(481, 20);
            VistaArticulos.Name = "VistaArticulos";
            VistaArticulos.RowHeadersWidth = 51;
            VistaArticulos.RowTemplate.Height = 29;
            VistaArticulos.Size = new Size(777, 655);
            VistaArticulos.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 31);
            label3.Name = "label3";
            label3.Size = new Size(424, 57);
            label3.TabIndex = 8;
            label3.Text = "Ingrese Datos del Articulo";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.Location = new Point(26, 119);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Ingrese Nombre del Articulo";
            txtnombre.Size = new Size(426, 35);
            txtnombre.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecio.Location = new Point(26, 180);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Ingrese Precio del Articulo (Solo Numeros)";
            txtPrecio.Size = new Size(426, 35);
            txtPrecio.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 248);
            label1.Name = "label1";
            label1.Size = new Size(402, 34);
            label1.TabIndex = 12;
            label1.Text = "Seleccione la Categoria del Articulo";
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(28, 306);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(424, 28);
            CBCategoria.TabIndex = 13;
            // 
            // CBMarca
            // 
            CBMarca.FormattingEnabled = true;
            CBMarca.Location = new Point(28, 417);
            CBMarca.Name = "CBMarca";
            CBMarca.Size = new Size(424, 28);
            CBMarca.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 359);
            label2.Name = "label2";
            label2.Size = new Size(365, 34);
            label2.TabIndex = 14;
            label2.Text = "Seleccione la Marca del Articulo";
            // 
            // articulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(CBMarca);
            Controls.Add(label2);
            Controls.Add(CBCategoria);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(VistaArticulos);
            Controls.Add(ElArticulo);
            Controls.Add(ModArticulo);
            Controls.Add(InArticulo);
            Name = "articulos";
            Size = new Size(1276, 692);
            Load += articulos_Load;
            ((System.ComponentModel.ISupportInitialize)VistaArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ElArticulo;
        private Button ModArticulo;
        private Button InArticulo;
        private DataGridView VistaArticulos;
        private Label label3;
        private TextBox txtnombre;
        private TextBox txtPrecio;
        private Label label1;
        private ComboBox CBCategoria;
        private ComboBox CBMarca;
        private Label label2;
    }
}
