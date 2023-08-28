namespace eleicaoforms
{
    partial class janellacadastro
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
            nomecand = new Label();
            txtboxcand = new TextBox();
            btnconf = new Button();
            SuspendLayout();
            // 
            // nomecand
            // 
            nomecand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nomecand.AutoSize = true;
            nomecand.Location = new Point(194, 39);
            nomecand.Name = "nomecand";
            nomecand.Size = new Size(198, 20);
            nomecand.TabIndex = 0;
            nomecand.Text = "Digite o nome do candidato";
            nomecand.Click += Nomecand_Click;
            // 
            // txtboxcand
            // 
            txtboxcand.Location = new Point(194, 91);
            txtboxcand.Name = "txtboxcand";
            txtboxcand.Size = new Size(198, 27);
            txtboxcand.TabIndex = 1;
            txtboxcand.TextChanged += Txtboxcand_TextChanged;
            // 
            // btnconf
            // 
            btnconf.Location = new Point(398, 89);
            btnconf.Name = "btnconf";
            btnconf.Size = new Size(94, 29);
            btnconf.TabIndex = 2;
            btnconf.Text = "confirmar";
            btnconf.UseVisualStyleBackColor = true;
            btnconf.Click += Btnconf_Click;
            // 
            // janellacadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 201);
            Controls.Add(btnconf);
            Controls.Add(txtboxcand);
            Controls.Add(nomecand);
            Name = "janellacadastro";
            Text = "janelacadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nomecand;
        private TextBox txtboxcand;
        private Button btnconf;
    }
}