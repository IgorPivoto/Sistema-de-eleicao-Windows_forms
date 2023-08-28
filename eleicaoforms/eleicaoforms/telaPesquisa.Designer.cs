namespace eleicaoforms
{
    partial class telaPesquisa
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
            txtboxpesquisanome = new TextBox();
            LblnomeCandidato = new Label();
            btnpesquisa = new Button();
            SuspendLayout();
            // 
            // txtboxpesquisanome
            // 
            txtboxpesquisanome.Location = new Point(157, 85);
            txtboxpesquisanome.Name = "txtboxpesquisanome";
            txtboxpesquisanome.Size = new Size(196, 27);
            txtboxpesquisanome.TabIndex = 0;
            txtboxpesquisanome.TextChanged += TextBox1_TextChanged;
            // 
            // LblnomeCandidato
            // 
            LblnomeCandidato.AutoSize = true;
            LblnomeCandidato.Location = new Point(157, 43);
            LblnomeCandidato.Name = "LblnomeCandidato";
            LblnomeCandidato.Size = new Size(196, 20);
            LblnomeCandidato.TabIndex = 1;
            LblnomeCandidato.Text = "digite o nome do candidato";
            // 
            // btnpesquisa
            // 
            btnpesquisa.Location = new Point(359, 85);
            btnpesquisa.Name = "btnpesquisa";
            btnpesquisa.Size = new Size(94, 29);
            btnpesquisa.TabIndex = 2;
            btnpesquisa.Text = "pesquisar";
            btnpesquisa.UseVisualStyleBackColor = true;
            btnpesquisa.Click += Btnpesquisa_Click;
            // 
            // telaPesquisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 213);
            Controls.Add(btnpesquisa);
            Controls.Add(LblnomeCandidato);
            Controls.Add(txtboxpesquisanome);
            Name = "telaPesquisa";
            Text = "telaPesquisa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxpesquisanome;
        private Label LblnomeCandidato;
        private Button btnpesquisa;
    }
}