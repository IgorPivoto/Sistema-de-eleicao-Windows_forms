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
            label1 = new Label();
            label2 = new Label();
            rtxmostraResultado = new RichTextBox();
            btnResultado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 20);
            label1.TabIndex = 0;
            label1.Text = "O resultado da eleicao será exibido logo abaixo.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 131);
            label2.Name = "label2";
            label2.Size = new Size(272, 20);
            label2.TabIndex = 1;
            label2.Text = "Clique no botão para saber o resultado:";
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
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "telaResultado";
            Text = "telaResultado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox rtxmostraResultado;
        private Button btnResultado;
    }
}