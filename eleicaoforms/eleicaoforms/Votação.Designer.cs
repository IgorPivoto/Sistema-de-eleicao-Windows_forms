namespace eleicaoforms
{
    partial class Votação
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
            rtxmostracandidato = new RichTextBox();
            LblmostraCandidato = new Label();
            btncliqueAqui = new Button();
            tbxVotar = new TextBox();
            LblNumeroVoto = new Label();
            LblNulo = new Label();
            LblImportante = new Label();
            btnVotar = new Button();
            SuspendLayout();
            // 
            // rtxmostracandidato
            // 
            rtxmostracandidato.Location = new Point(12, 160);
            rtxmostracandidato.Name = "rtxmostracandidato";
            rtxmostracandidato.ReadOnly = true;
            rtxmostracandidato.Size = new Size(240, 278);
            rtxmostracandidato.TabIndex = 1;
            rtxmostracandidato.Text = "";
            rtxmostracandidato.TextChanged += S_TextChanged;
            // 
            // LblmostraCandidato
            // 
            LblmostraCandidato.AutoSize = true;
            LblmostraCandidato.Location = new Point(12, 76);
            LblmostraCandidato.Name = "LblmostraCandidato";
            LblmostraCandidato.Size = new Size(227, 40);
            LblmostraCandidato.TabIndex = 2;
            LblmostraCandidato.Text = "Clique no botão abaixo para ver \r\na lista de candidatos dispoiveis.";
            // 
            // btncliqueAqui
            // 
            btncliqueAqui.Location = new Point(12, 125);
            btncliqueAqui.Name = "btncliqueAqui";
            btncliqueAqui.Size = new Size(98, 29);
            btncliqueAqui.TabIndex = 3;
            btncliqueAqui.Text = "clique aqui.";
            btncliqueAqui.UseVisualStyleBackColor = true;
            btncliqueAqui.Click += button1_Click;
            // 
            // tbxVotar
            // 
            tbxVotar.Location = new Point(331, 160);
            tbxVotar.Name = "tbxVotar";
            tbxVotar.Size = new Size(190, 27);
            tbxVotar.TabIndex = 4;
            tbxVotar.TextChanged += textBox1_TextChanged;
            // 
            // LblNumeroVoto
            // 
            LblNumeroVoto.AutoSize = true;
            LblNumeroVoto.Location = new Point(331, 134);
            LblNumeroVoto.Name = "LblNumeroVoto";
            LblNumeroVoto.Size = new Size(396, 20);
            LblNumeroVoto.TabIndex = 5;
            LblNumeroVoto.Text = "Digite aqui o numero do candidato que você deseja votar.";
            // 
            // LblNulo
            // 
            LblNulo.AutoSize = true;
            LblNulo.Location = new Point(331, 270);
            LblNulo.Name = "LblNulo";
            LblNulo.Size = new Size(319, 40);
            LblNulo.TabIndex = 6;
            LblNulo.Text = "Caso queira votar nulo ou branco, coloque um \r\nnumero que não seja de senhum candidato.\r\n";
            // 
            // LblImportante
            // 
            LblImportante.AutoSize = true;
            LblImportante.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LblImportante.ForeColor = Color.Red;
            LblImportante.Location = new Point(331, 222);
            LblImportante.Name = "LblImportante";
            LblImportante.Size = new Size(167, 31);
            LblImportante.TabIndex = 7;
            LblImportante.Text = "IMPORTANTE!";
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(527, 160);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(94, 29);
            btnVotar.TabIndex = 8;
            btnVotar.Text = "Votar!";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // Votação
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVotar);
            Controls.Add(LblImportante);
            Controls.Add(LblNulo);
            Controls.Add(LblNumeroVoto);
            Controls.Add(tbxVotar);
            Controls.Add(btncliqueAqui);
            Controls.Add(LblmostraCandidato);
            Controls.Add(rtxmostracandidato);
            Name = "Votação";
            Text = "Votação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtxmostracandidato;
        private Label LblmostraCandidato;
        private Button btncliqueAqui;
        private TextBox tbxVotar;
        private Label LblNumeroVoto;
        private Label LblNulo;
        private Label LblImportante;
        private Button btnVotar;
    }
}