namespace eleicaoforms
{
    partial class Telainicial
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
            lblEscolha = new Label();
            btncadastro = new Button();
            btnele = new Button();
            btnpesquisa = new Button();
            btnVotar = new Button();
            btnMostraresultado = new Button();
            btnSair = new Button();
            btnIdioma = new Button();
            SuspendLayout();
            // 
            // lblEscolha
            // 
            lblEscolha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEscolha.AutoSize = true;
            lblEscolha.Location = new Point(307, 33);
            lblEscolha.Name = "lblEscolha";
            lblEscolha.Size = new Size(73, 20);
            lblEscolha.TabIndex = 0;
            lblEscolha.Text = "ESCOLHA";
            lblEscolha.Click += Txtescolha_Click;
            // 
            // btncadastro
            // 
            btncadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btncadastro.Location = new Point(249, 56);
            btncadastro.Name = "btncadastro";
            btncadastro.Size = new Size(187, 43);
            btncadastro.TabIndex = 1;
            btncadastro.Text = "Cadastrar candidato";
            btncadastro.UseVisualStyleBackColor = true;
            btncadastro.Click += Btncadastro_Click;
            // 
            // btnele
            // 
            btnele.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnele.Location = new Point(249, 104);
            btnele.Name = "btnele";
            btnele.Size = new Size(187, 43);
            btnele.TabIndex = 2;
            btnele.Text = "Atualizar eleitores";
            btnele.UseVisualStyleBackColor = true;
            btnele.Click += Button1_Click;
            // 
            // btnpesquisa
            // 
            btnpesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnpesquisa.Location = new Point(249, 154);
            btnpesquisa.Margin = new Padding(3, 4, 3, 4);
            btnpesquisa.Name = "btnpesquisa";
            btnpesquisa.Size = new Size(187, 43);
            btnpesquisa.TabIndex = 3;
            btnpesquisa.Text = "Pesquisar candidato";
            btnpesquisa.UseVisualStyleBackColor = true;
            btnpesquisa.Click += Btnpesquisa_Click;
            // 
            // btnVotar
            // 
            btnVotar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVotar.Location = new Point(249, 204);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(187, 43);
            btnVotar.TabIndex = 4;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += BtnVotar_Click;
            // 
            // btnMostraresultado
            // 
            btnMostraresultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMostraresultado.Location = new Point(249, 253);
            btnMostraresultado.Name = "btnMostraresultado";
            btnMostraresultado.Size = new Size(187, 43);
            btnMostraresultado.TabIndex = 5;
            btnMostraresultado.Text = "Resultado da eleição";
            btnMostraresultado.UseVisualStyleBackColor = true;
            btnMostraresultado.Click += BtnMostraresultado_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.Location = new Point(585, 396);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(115, 43);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += BtnSair_Click;
            // 
            // btnIdioma
            // 
            btnIdioma.Location = new Point(12, 396);
            btnIdioma.Name = "btnIdioma";
            btnIdioma.Size = new Size(115, 43);
            btnIdioma.TabIndex = 7;
            btnIdioma.Text = "idioma";
            btnIdioma.UseVisualStyleBackColor = true;
            btnIdioma.Click += BtnIdioma_Click;
            // 
            // Telainicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 451);
            Controls.Add(btnIdioma);
            Controls.Add(btnSair);
            Controls.Add(btnMostraresultado);
            Controls.Add(btnVotar);
            Controls.Add(btnpesquisa);
            Controls.Add(btnele);
            Controls.Add(btncadastro);
            Controls.Add(lblEscolha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Telainicial";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEscolha;
        private Button btncadastro;
        private Button btnele;
        private Button btnpesquisa;
        private Button btnVotar;
        private Button btnMostraresultado;
        private Button btnSair;
        private Button btnIdioma;
    }
}