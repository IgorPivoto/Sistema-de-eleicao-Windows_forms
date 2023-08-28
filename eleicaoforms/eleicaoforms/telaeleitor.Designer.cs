namespace eleicaoforms
{
    partial class telaeleitor
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
            Lblprincipal = new Label();
            txtboxeleitor = new TextBox();
            btneleitor = new Button();
            Lblquantidade = new Label();
            lblmostraeleitor = new Label();
            SuspendLayout();
            // 
            // Lblprincipal
            // 
            Lblprincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lblprincipal.AutoSize = true;
            Lblprincipal.Location = new Point(277, 36);
            Lblprincipal.Name = "Lblprincipal";
            Lblprincipal.Size = new Size(233, 20);
            Lblprincipal.TabIndex = 0;
            Lblprincipal.Text = "A quantidade de eleitores atual é:";
            // 
            // txtboxeleitor
            // 
            txtboxeleitor.Location = new Point(295, 220);
            txtboxeleitor.Name = "txtboxeleitor";
            txtboxeleitor.Size = new Size(115, 27);
            txtboxeleitor.TabIndex = 1;
            txtboxeleitor.TextChanged += txtboxeleitor_TextChanged;
            // 
            // btneleitor
            // 
            btneleitor.Location = new Point(416, 220);
            btneleitor.Name = "btneleitor";
            btneleitor.Size = new Size(94, 29);
            btneleitor.TabIndex = 2;
            btneleitor.Text = "Atualizar quantidade de eleitores";
            btneleitor.UseVisualStyleBackColor = true;
            btneleitor.Click += btneleitor_Click;
            // 
            // Lblquantidade
            // 
            Lblquantidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Lblquantidade.AutoSize = true;
            Lblquantidade.Location = new Point(319, 176);
            Lblquantidade.Name = "Lblquantidade";
            Lblquantidade.Size = new Size(175, 20);
            Lblquantidade.TabIndex = 3;
            Lblquantidade.Text = "Insira a nova quantidade:";
            // 
            // lblmostraeleitor
            // 
            lblmostraeleitor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblmostraeleitor.AutoSize = true;
            lblmostraeleitor.Location = new Point(510, 36);
            lblmostraeleitor.Name = "lblmostraeleitor";
            lblmostraeleitor.Size = new Size(0, 20);
            lblmostraeleitor.TabIndex = 4;
            // 
            // telaeleitor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblmostraeleitor);
            Controls.Add(Lblquantidade);
            Controls.Add(btneleitor);
            Controls.Add(txtboxeleitor);
            Controls.Add(Lblprincipal);
            Name = "telaeleitor";
            Text = "telaeleitor";
            Load += telaeleitor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lblprincipal;
        private TextBox txtboxeleitor;
        private Button btneleitor;
        private Label Lblquantidade;
        private Label lblmostraeleitor;
    }
}