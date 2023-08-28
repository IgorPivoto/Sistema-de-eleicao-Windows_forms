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
            label2 = new Label();
            btncliqueAqui = new Button();
            tbxVotar = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(227, 40);
            label2.TabIndex = 2;
            label2.Text = "Clique no botão abaixo para ver \r\na lista de candidatos dispoiveis.";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 134);
            label3.Name = "label3";
            label3.Size = new Size(396, 20);
            label3.TabIndex = 5;
            label3.Text = "Digite aqui o numero do candidato que você deseja votar.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 270);
            label1.Name = "label1";
            label1.Size = new Size(319, 40);
            label1.TabIndex = 6;
            label1.Text = "Caso queira votar nulo ou branco, coloque um \r\nnumero que não seja de senhum candidato.\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(331, 222);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 7;
            label4.Text = "IMPORTANTE!";
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
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(tbxVotar);
            Controls.Add(btncliqueAqui);
            Controls.Add(label2);
            Controls.Add(rtxmostracandidato);
            Name = "Votação";
            Text = "Votação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtxmostracandidato;
        private Label label2;
        private Button btncliqueAqui;
        private TextBox tbxVotar;
        private Label label3;
        private Label label1;
        private Label label4;
        private Button btnVotar;
    }
}