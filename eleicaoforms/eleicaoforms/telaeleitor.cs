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
            AlteraIdiomaEleitor();
        }

        private void btneleitor_Click(object sender, EventArgs e)
        {
            if (VarGlobal.idiomaIngles == true)
            {
                try
                {
                    VarGlobal.quantidadeEleitor = Convert.ToInt32(txtboxeleitor.Text);
                    MessageBox.Show("Updated quantity!\nThe new quantity is: " + VarGlobal.quantidadeEleitor);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Enter only numbers");
                    txtboxeleitor.Clear();
                }
            }
            else
            {
                try
                {
                    VarGlobal.quantidadeEleitor = Convert.ToInt32(txtboxeleitor.Text);
                    MessageBox.Show("Quantidade atualizada!\nA quantidade nova é: " + VarGlobal.quantidadeEleitor);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Digite apenas numeros");
                    txtboxeleitor.Clear();
                }
            }
        }

        private void telaeleitor_Load(object sender, EventArgs e)
        {
            lblmostraeleitor.Text = txtboxeleitor.Text;
            lblmostraeleitor.Text = VarGlobal.quantidadeEleitor.ToString();

        }

        private void txtboxeleitor_TextChanged(object sender, EventArgs e)
        {

        }
        public void AlteraIdiomaEleitor()
        {
            if(VarGlobal.idiomaIngles == true)
            {
                btneleitor.Text = "Update";
                Lblprincipal.Text = "The current number of voters is:";
                Lblquantidade.Text = "Enter the new quantity";
            }
            else if(VarGlobal.idiomaIngles == false)
            {

            }
            
        }
    }
}
