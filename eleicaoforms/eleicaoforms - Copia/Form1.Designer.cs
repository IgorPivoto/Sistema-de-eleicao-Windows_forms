namespace eleicaoforms
{
    partial class telainicial
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
            txtescolha = new Label();
            btncadastro = new Button();
            btnele = new Button();
            btnpesquisa = new Button();
            btnVotar = new Button();
            btnMostraresultado = new Button();
            SuspendLayout();
            // 
            // txtescolha
            // 
            txtescolha.AutoSize = true;
            txtescolha.Location = new Point(312, 33);
            txtescolha.Name = "txtescolha";
            txtescolha.Size = new Size(73, 20);
            txtescolha.TabIndex = 0;
            txtescolha.Text = "ESCOLHA";
            // 
            // btncadastro
            // 
            btncadastro.Location = new Point(261, 56);
            btncadastro.Name = "btncadastro";
            btncadastro.Size = new Size(187, 43);
            btncadastro.TabIndex = 1;
            btncadastro.Text = "Cadastrar candidato";
            btncadastro.UseVisualStyleBackColor = true;
            btncadastro.Click += btncadastro_Click;
            // 
            // btnele
            // 
            btnele.Location = new Point(261, 104);
            btnele.Name = "btnele";
            btnele.Size = new Size(187, 44);
            btnele.TabIndex = 2;
            btnele.Text = "Atualizar eleitores";
            btnele.UseVisualStyleBackColor = true;
            btnele.Click += button1_Click;
            // 
            // btnpesquisa
            // 
            btnpesquisa.Location = new Point(261, 155);
            btnpesquisa.Margin = new Padding(3, 4, 3, 4);
            btnpesquisa.Name = "btnpesquisa";
            btnpesquisa.Size = new Size(187, 41);
            btnpesquisa.TabIndex = 3;
            btnpesquisa.Text = "Pesquisar candidato";
            btnpesquisa.UseVisualStyleBackColor = true;
            btnpesquisa.Click += btnpesquisa_Click;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(261, 203);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(187, 42);
            btnVotar.TabIndex = 4;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // btnMostraresultado
            // 
            btnMostraresultado.Location = new Point(261, 251);
            btnMostraresultado.Name = "btnMostraresultado";
            btnMostraresultado.Size = new Size(187, 40);
            btnMostraresultado.TabIndex = 5;
            btnMostraresultado.Text = "Resultado da eleição";
            btnMostraresultado.UseVisualStyleBackColor = true;
            btnMostraresultado.Click += btnMostraresultado_Click;
            // 
            // telainicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 451);
            Controls.Add(btnMostraresultado);
            Controls.Add(btnVotar);
            Controls.Add(btnpesquisa);
            Controls.Add(btnele);
            Controls.Add(btncadastro);
            Controls.Add(txtescolha);
            Name = "telainicial";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtescolha;
        private Button btncadastro;
        private Button btnele;
        private Button btnpesquisa;
        private Button btnVotar;
        private Button btnMostraresultado;
    }
}