namespace eleicaoforms
{
    partial class telaIdioma
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
            lblIdioma = new Label();
            btnIngles = new Button();
            btnPortugues = new Button();
            SuspendLayout();
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(212, 9);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(126, 20);
            lblIdioma.TabIndex = 0;
            lblIdioma.Text = "Escolha o idioma.";
            // 
            // btnIngles
            // 
            btnIngles.Location = new Point(172, 119);
            btnIngles.Name = "btnIngles";
            btnIngles.Size = new Size(101, 35);
            btnIngles.TabIndex = 1;
            btnIngles.Text = "Ingles";
            btnIngles.UseVisualStyleBackColor = true;
            btnIngles.Click += btnIngles_Click;
            // 
            // btnPortugues
            // 
            btnPortugues.Location = new Point(279, 119);
            btnPortugues.Name = "btnPortugues";
            btnPortugues.Size = new Size(101, 35);
            btnPortugues.TabIndex = 2;
            btnPortugues.Text = "Portugues";
            btnPortugues.UseVisualStyleBackColor = true;
            btnPortugues.Click += btnPortugues_Click;
            // 
            // telaIdioma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 302);
            Controls.Add(btnPortugues);
            Controls.Add(btnIngles);
            Controls.Add(lblIdioma);
            Name = "telaIdioma";
            Text = "telaIdioma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdioma;
        private Button btnIngles;
        private Button btnPortugues;
    }
}