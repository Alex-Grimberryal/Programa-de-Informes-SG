namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    partial class Seleccionador_deArticulos
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
            CBArticulo = new ComboBox();
            txtCantidad = new TextBox();
            ArtVend = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            InArtvend = new Button();
            ElArtvend = new Button();
            ModArtvend = new Button();
            ((System.ComponentModel.ISupportInitialize)ArtVend).BeginInit();
            SuspendLayout();
            // 
            // CBArticulo
            // 
            CBArticulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CBArticulo.FormattingEnabled = true;
            CBArticulo.Location = new Point(39, 157);
            CBArticulo.Name = "CBArticulo";
            CBArticulo.Size = new Size(374, 36);
            CBArticulo.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Bahnschrift SemiBold SemiConden", 13F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.Location = new Point(473, 157);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Ingrese solo numeros";
            txtCantidad.Size = new Size(373, 34);
            txtCantidad.TabIndex = 1;
            // 
            // ArtVend
            // 
            ArtVend.BackgroundColor = SystemColors.ActiveCaption;
            ArtVend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ArtVend.Location = new Point(39, 290);
            ArtVend.Name = "ArtVend";
            ArtVend.RowHeadersWidth = 51;
            ArtVend.RowTemplate.Height = 29;
            ArtVend.Size = new Size(808, 730);
            ArtVend.TabIndex = 2;
            ArtVend.CellContentClick += ArtVend_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 107);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 3;
            label1.Text = "Articulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(474, 107);
            label2.Name = "label2";
            label2.Size = new Size(110, 34);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 26);
            label3.Name = "label3";
            label3.Size = new Size(570, 57);
            label3.TabIndex = 5;
            label3.Text = "Seleccione articulos a vender";
            // 
            // InArtvend
            // 
            InArtvend.BackColor = Color.Cyan;
            InArtvend.FlatAppearance.BorderSize = 0;
            InArtvend.FlatStyle = FlatStyle.Flat;
            InArtvend.Font = new Font("Bahnschrift SemiBold SemiConden", 13F, FontStyle.Bold, GraphicsUnit.Point);
            InArtvend.Location = new Point(40, 222);
            InArtvend.Name = "InArtvend";
            InArtvend.Size = new Size(246, 34);
            InArtvend.TabIndex = 6;
            InArtvend.Text = "INSERTAR";
            InArtvend.UseVisualStyleBackColor = false;
            InArtvend.Click += button1_Click;
            // 
            // ElArtvend
            // 
            ElArtvend.BackColor = Color.Cyan;
            ElArtvend.FlatAppearance.BorderSize = 0;
            ElArtvend.FlatStyle = FlatStyle.Flat;
            ElArtvend.Font = new Font("Bahnschrift SemiBold SemiConden", 13F, FontStyle.Bold, GraphicsUnit.Point);
            ElArtvend.Location = new Point(600, 222);
            ElArtvend.Name = "ElArtvend";
            ElArtvend.Size = new Size(246, 34);
            ElArtvend.TabIndex = 7;
            ElArtvend.Text = "ELIMINAR";
            ElArtvend.UseVisualStyleBackColor = false;
            ElArtvend.Click += ElArtvend_Click;
            // 
            // ModArtvend
            // 
            ModArtvend.BackColor = Color.Cyan;
            ModArtvend.FlatAppearance.BorderSize = 0;
            ModArtvend.FlatStyle = FlatStyle.Flat;
            ModArtvend.Font = new Font("Bahnschrift SemiBold SemiConden", 13F, FontStyle.Bold, GraphicsUnit.Point);
            ModArtvend.Location = new Point(323, 222);
            ModArtvend.Name = "ModArtvend";
            ModArtvend.Size = new Size(247, 34);
            ModArtvend.TabIndex = 8;
            ModArtvend.Text = "MODIFICAR";
            ModArtvend.UseVisualStyleBackColor = false;
            ModArtvend.Click += ModArtvend_Click;
            // 
            // Seleccionador_deArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(882, 1055);
            Controls.Add(ModArtvend);
            Controls.Add(ElArtvend);
            Controls.Add(InArtvend);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ArtVend);
            Controls.Add(txtCantidad);
            Controls.Add(CBArticulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Seleccionador_deArticulos";
            Text = "Form1";
            Load += Seleccionador_deArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)ArtVend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBArticulo;
        private TextBox txtCantidad;
        private DataGridView ArtVend;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button InArtvend;
        private Button ElArtvend;
        private Button ModArtvend;
    }
}