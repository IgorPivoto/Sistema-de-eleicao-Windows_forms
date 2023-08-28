using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eleicaoforms
{
    public partial class telaeleitor : Form
    {
        public telaeleitor()
        {
            InitializeComponent();
        }

        private void btneleitor_Click(object sender, EventArgs e)
        {
            VarGlobal.quantidadeEleitor = Convert.ToInt32(txtboxeleitor.Text);
            MessageBox.Show("Quantidade atualizada!");
            Close();
        }

        private void telaeleitor_Load(object sender, EventArgs e)
        {
            lblmostraeleitor.Text = txtboxeleitor.Text;
            lblmostraeleitor.Text = VarGlobal.quantidadeEleitor.ToString();
            
        }

        private void txtboxeleitor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
