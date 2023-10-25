namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    partial class usuarios
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
            VistaUser = new DataGridView();
            InUsusario = new Button();
            EdUsuario = new Button();
            ElUsuario = new Button();
            label3 = new Label();
            nombre = new TextBox();
            Contrasena = new TextBox();
            checkBoxAdmin = new CheckBox();
            checkBoxOper = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)VistaUser).BeginInit();
            SuspendLayout();
            // 
            // VistaUser
            // 
            VistaUser.BackgroundColor = SystemColors.ActiveCaption;
            VistaUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VistaUser.GridColor = SystemColors.GradientActiveCaption;
            VistaUser.Location = new Point(720, 14);
            VistaUser.Name = "VistaUser";
            VistaUser.RowHeadersWidth = 51;
            VistaUser.RowTemplate.Height = 29;
            VistaUser.Size = new Size(536, 655);
            VistaUser.TabIndex = 0;
            VistaUser.CellContentClick += VistaUser_CellContentClick;
            // 
            // InUsusario
            // 
            InUsusario.BackColor = Color.SkyBlue;
            InUsusario.Cursor = Cursors.Hand;
            InUsusario.FlatAppearance.BorderSize = 0;
            InUsusario.FlatStyle = FlatStyle.Flat;
            InUsusario.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            InUsusario.Location = new Point(27, 596);
            InUsusario.Name = "InUsusario";
            InUsusario.Size = new Size(205, 73);
            InUsusario.TabIndex = 1;
            InUsusario.Text = "Insertar";
            InUsusario.UseVisualStyleBackColor = false;
            InUsusario.Click += InUsusario_Click;
            // 
            // EdUsuario
            // 
            EdUsuario.BackColor = Color.SkyBlue;
            EdUsuario.Cursor = Cursors.Hand;
            EdUsuario.FlatAppearance.BorderSize = 0;
            EdUsuario.FlatStyle = FlatStyle.Flat;
            EdUsuario.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            EdUsuario.Location = new Point(248, 596);
            EdUsuario.Name = "EdUsuario";
            EdUsuario.Size = new Size(205, 73);
            EdUsuario.TabIndex = 2;
            EdUsuario.Text = "Editar";
            EdUsuario.UseVisualStyleBackColor = false;
            EdUsuario.Click += EdUsuario_Click;
            // 
            // ElUsuario
            // 
            ElUsuario.BackColor = Color.SkyBlue;
            ElUsuario.Cursor = Cursors.Hand;
            ElUsuario.FlatAppearance.BorderSize = 0;
            ElUsuario.FlatStyle = FlatStyle.Flat;
            ElUsuario.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ElUsuario.Location = new Point(468, 596);
            ElUsuario.Name = "ElUsuario";
            ElUsuario.Size = new Size(205, 73);
            ElUsuario.TabIndex = 3;
            ElUsuario.Text = "Eliminar";
            ElUsuario.UseVisualStyleBackColor = false;
            ElUsuario.Click += ElUsuario_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Bahnschrift Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 24);
            label3.Name = "label3";
            label3.Size = new Size(236, 57);
            label3.TabIndex = 6;
            label3.Text = "Ingrese Datos";
            // 
            // nombre
            // 
            nombre.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nombre.Location = new Point(27, 132);
            nombre.Name = "nombre";
            nombre.PlaceholderText = "Ingrese Nombre de Usuario";
            nombre.Size = new Size(646, 35);
            nombre.TabIndex = 7;
            nombre.TextChanged += textBox1_TextChanged;
            // 
            // Contrasena
            // 
            Contrasena.Font = new Font("Bahnschrift SemiBold SemiConden", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Contrasena.Location = new Point(27, 195);
            Contrasena.Name = "Contrasena";
            Contrasena.PlaceholderText = "Ingrese Contraseña (solo letras y numeros)";
            Contrasena.Size = new Size(646, 35);
            Contrasena.TabIndex = 8;
            Contrasena.TextChanged += textBox1_TextChanged_1;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxAdmin.Location = new Point(231, 333);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(170, 38);
            checkBoxAdmin.TabIndex = 9;
            checkBoxAdmin.Text = "Administrador";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxOper
            // 
            checkBoxOper.AutoSize = true;
            checkBoxOper.Font = new Font("Bahnschrift Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxOper.Location = new Point(231, 396);
            checkBoxOper.Name = "checkBoxOper";
            checkBoxOper.Size = new Size(118, 38);
            checkBoxOper.TabIndex = 10;
            checkBoxOper.Text = "Operario";
            checkBoxOper.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 267);
            label1.Name = "label1";
            label1.Size = new Size(388, 34);
            label1.TabIndex = 11;
            label1.Text = "Seleccione el tipo de Accesibilidad";
            label1.Click += label1_Click;
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(label1);
            Controls.Add(checkBoxOper);
            Controls.Add(checkBoxAdmin);
            Controls.Add(Contrasena);
            Controls.Add(nombre);
            Controls.Add(label3);
            Controls.Add(ElUsuario);
            Controls.Add(EdUsuario);
            Controls.Add(InUsusario);
            Controls.Add(VistaUser);
            Name = "usuarios";
            Size = new Size(1276, 692);
            Load += usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)VistaUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView VistaUser;
        private Button InUsusario;
        private Button EdUsuario;
        private Button ElUsuario;
        private Label label3;
        private TextBox nombre;
        private TextBox Contrasena;
        private CheckBox checkBoxAdmin;
        private CheckBox checkBoxOper;
        private Label label1;
    }
}
