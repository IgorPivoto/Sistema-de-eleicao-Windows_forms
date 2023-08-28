namespace eleicaoforms
{
    partial class pesquisacandidato
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
            lblopcao = new Label();
            btnlistaCandidato = new Button();
            btnpesquisacandidato = new Button();
            SuspendLayout();
            // 
            // lblopcao
            // 
            lblopcao.AutoSize = true;
            lblopcao.Location = new Point(129, 9);
            lblopcao.Name = "lblopcao";
            lblopcao.Size = new Size(129, 20);
            lblopcao.TabIndex = 0;
            lblopcao.Text = "escolha as opcoes";
            lblopcao.Click += Label1_Click;
            // 
            // btnlistaCandidato
            // 
            btnlistaCandidato.Location = new Point(106, 70);
            btnlistaCandidato.Name = "btnlistaCandidato";
            btnlistaCandidato.Size = new Size(174, 29);
            btnlistaCandidato.TabIndex = 1;
            btnlistaCandidato.Text = "ver lista de candidato";
            btnlistaCandidato.UseVisualStyleBackColor = true;
            btnlistaCandidato.Click += BtnlistaCandidato_Click;
            // 
            // btnpesquisacandidato
            // 
            btnpesquisacandidato.Location = new Point(106, 125);
            btnpesquisacandidato.Name = "btnpesquisacandidato";
            btnpesquisacandidato.Size = new Size(174, 29);
            btnpesquisacandidato.TabIndex = 2;
            btnpesquisacandidato.Text = "Pesquisar candidato";
            btnpesquisacandidato.UseVisualStyleBackColor = true;
            btnpesquisacandidato.Click += Btnpesquisacandidato_Click;
            // 
            // pesquisacandidato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 263);
            Controls.Add(btnpesquisacandidato);
            Controls.Add(btnlistaCandidato);
            Controls.Add(lblopcao);
            Name = "pesquisacandidato";
            Text = "pesquisacandidato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblopcao;
        private Button btnlistaCandidato;
        private Button btnpesquisacandidato;
    }
}