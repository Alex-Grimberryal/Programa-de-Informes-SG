namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(147, 208);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(216, 27);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(147, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 215);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 268);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(113, 399);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(185, 49);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(13, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 112);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(407, 523);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            RightToLeft = RightToLeft.No;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}