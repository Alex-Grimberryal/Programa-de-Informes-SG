namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    partial class tecnicos
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
            txtAP = new TextBox();
            txtnombre = new TextBox();
            label3 = new Label();
            txtDNI = new TextBox();
            txtAM = new TextBox();
            txtcelular = new TextBox();
            ElTecnico = new Button();
            ModTecnico = new Button();
            InTecnico = new Button();
            VistaTecnicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)VistaTecnicos).BeginInit();
            SuspendLayout();
            // 
            // txtAP
            // 
            txtAP.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAP.Location = new Point(28, 236);
            txtAP.Name = "txtAP";
            txtAP.PlaceholderText = "Ingrese Apellido Paterno";
            txtAP.Size = new Size(426, 35);
            txtAP.TabIndex = 13;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.Location = new Point(28, 175);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Ingrese Nombre del Tecnico";
            txtnombre.Size = new Size(426, 35);
            txtnombre.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 30);
            label3.Name = "label3";
            label3.Size = new Size(416, 57);
            label3.TabIndex = 11;
            label3.Text = "Ingrese Datos del Tecnico";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtDNI.Location = new Point(28, 116);
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "Ingrese DNI del Tecnico (SOLO 8 DIGITOS)";
            txtDNI.Size = new Size(426, 35);
            txtDNI.TabIndex = 14;
            // 
            // txtAM
            // 
            txtAM.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtAM.Location = new Point(28, 295);
            txtAM.Name = "txtAM";
            txtAM.PlaceholderText = "Ingrese Apellido Materno";
            txtAM.Size = new Size(426, 35);
            txtAM.TabIndex = 15;
            // 
            // txtcelular
            // 
            txtcelular.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtcelular.Location = new Point(28, 356);
            txtcelular.Name = "txtcelular";
            txtcelular.PlaceholderText = "Ingrese nro de Celular";
            txtcelular.Size = new Size(426, 35);
            txtcelular.TabIndex = 16;
            // 
            // ElTecnico
            // 
            ElTecnico.BackColor = Color.SkyBlue;
            ElTecnico.Cursor = Cursors.Hand;
            ElTecnico.FlatAppearance.BorderSize = 0;
            ElTecnico.FlatStyle = FlatStyle.Flat;
            ElTecnico.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ElTecnico.Location = new Point(325, 587);
            ElTecnico.Name = "ElTecnico";
            ElTecnico.Size = new Size(129, 73);
            ElTecnico.TabIndex = 19;
            ElTecnico.Text = "Eliminar";
            ElTecnico.UseVisualStyleBackColor = false;
            ElTecnico.Click += ElTecnico_Click;
            // 
            // ModTecnico
            // 
            ModTecnico.BackColor = Color.SkyBlue;
            ModTecnico.Cursor = Cursors.Hand;
            ModTecnico.FlatAppearance.BorderSize = 0;
            ModTecnico.FlatStyle = FlatStyle.Flat;
            ModTecnico.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ModTecnico.Location = new Point(176, 587);
            ModTecnico.Name = "ModTecnico";
            ModTecnico.Size = new Size(129, 73);
            ModTecnico.TabIndex = 18;
            ModTecnico.Text = "Editar";
            ModTecnico.UseVisualStyleBackColor = false;
            ModTecnico.Click += ModTecnico_Click;
            // 
            // InTecnico
            // 
            InTecnico.BackColor = Color.SkyBlue;
            InTecnico.Cursor = Cursors.Hand;
            InTecnico.FlatAppearance.BorderSize = 0;
            InTecnico.FlatStyle = FlatStyle.Flat;
            InTecnico.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            InTecnico.Location = new Point(26, 587);
            InTecnico.Name = "InTecnico";
            InTecnico.Size = new Size(129, 73);
            InTecnico.TabIndex = 17;
            InTecnico.Text = "Insertar";
            InTecnico.UseVisualStyleBackColor = false;
            InTecnico.Click += InTecnico_Click;
            // 
            // VistaTecnicos
            // 
            VistaTecnicos.BackgroundColor = SystemColors.ActiveCaption;
            VistaTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            VistaTecnicos.DefaultCellStyle = dataGridViewCellStyle1;
            VistaTecnicos.GridColor = SystemColors.GradientActiveCaption;
            VistaTecnicos.Location = new Point(483, 19);
            VistaTecnicos.Name = "VistaTecnicos";
            VistaTecnicos.RowHeadersWidth = 51;
            VistaTecnicos.RowTemplate.Height = 29;
            VistaTecnicos.Size = new Size(777, 655);
            VistaTecnicos.TabIndex = 20;
            VistaTecnicos.SelectionChanged += VistaTecnicos_SelectionChanged;
            // 
            // tecnicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(VistaTecnicos);
            Controls.Add(ElTecnico);
            Controls.Add(ModTecnico);
            Controls.Add(InTecnico);
            Controls.Add(txtcelular);
            Controls.Add(txtAM);
            Controls.Add(txtDNI);
            Controls.Add(txtAP);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Name = "tecnicos";
            Size = new Size(1276, 692);
            Load += tecnicos_Load;
            ((System.ComponentModel.ISupportInitialize)VistaTecnicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAP;
        private TextBox txtnombre;
        private Label label3;
        private TextBox txtDNI;
        private TextBox txtAM;
        private TextBox txtcelular;
        private Button ElTecnico;
        private Button ModTecnico;
        private Button InTecnico;
        private DataGridView VistaTecnicos;
    }
}
