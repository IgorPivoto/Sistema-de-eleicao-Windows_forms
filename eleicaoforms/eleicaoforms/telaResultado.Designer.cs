namespace eleicaoforms
{
    partial class telaResultado
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
            LblPrincipal = new Label();
            LblResultado = new Label();
            rtxmostraResultado = new RichTextBox();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // LblPrincipal
            // 
            LblPrincipal.AutoSize = true;
            LblPrincipal.Location = new Point(128, 9);
            LblPrincipal.Name = "LblPrincipal";
            LblPrincipal.Size = new Size(331, 20);
            LblPrincipal.TabIndex = 0;
            LblPrincipal.Text = "O resultado da eleicao será exibido logo abaixo.\r\n";
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(128, 131);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(272, 20);
            LblResultado.TabIndex = 1;
            LblResultado.Text = "Clique no botão para saber o resultado:";
            // 
            // rtxmostraResultado
            // 
            rtxmostraResultado.Location = new Point(128, 162);
            rtxmostraResultado.Name = "rtxmostraResultado";
            rtxmostraResultado.Size = new Size(331, 276);
            rtxmostraResultado.TabIndex = 2;
            rtxmostraResultado.Text = "";
            rtxmostraResultado.TextChanged += rtxmostraResultado_TextChanged;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(406, 127);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(53, 29);
            btnResultado.TabIndex = 3;
            btnResultado.Text = "ver";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // telaResultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 450);
            Controls.Add(btnResultado);
            Controls.Add(rtxmostraResultado);
            Controls.Add(LblResultado);
            Controls.Add(LblPrincipal);
            Name = "telaResultado";
            Text = "telaResultado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPrincipal;
        private Label LblResultado;
        private RichTextBox rtxmostraResultado;
        private Button btnResultado;
    }
}