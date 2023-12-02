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
            verInforme = new ListView();
            label1 = new Label();
            label2 = new Label();
            verArticulos = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // verInforme
            // 
            verInforme.Location = new Point(12, 120);
            verInforme.Name = "verInforme";
            verInforme.Size = new Size(581, 621);
            verInforme.TabIndex = 0;
            verInforme.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 42);
            label1.Name = "label1";
            label1.Size = new Size(296, 48);
            label1.TabIndex = 1;
            label1.Text = "Datos del Informe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(621, 42);
            label2.Name = "label2";
            label2.Size = new Size(310, 48);
            label2.TabIndex = 2;
            label2.Text = "Articulos Vendidos";
            // 
            // verArticulos
            // 
            verArticulos.FormattingEnabled = true;
            verArticulos.ItemHeight = 20;
            verArticulos.Location = new Point(621, 120);
            verArticulos.Name = "verArticulos";
            verArticulos.Size = new Size(549, 424);
            verArticulos.TabIndex = 3;
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
            // 
            // FormPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1182, 753);
            Controls.Add(button1);
            Controls.Add(verArticulos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(verInforme);
            Name = "FormPopup";
            Text = "Ver Informe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView verInforme;
        private Label label1;
        private Label label2;
        private ListBox verArticulos;
        private Button button1;
    }
}