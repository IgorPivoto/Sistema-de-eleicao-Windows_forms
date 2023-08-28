using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace eleicaoforms
{
    public partial class janellacadastro : Form
    {
        public janellacadastro()
        {
            InitializeComponent();
        }

        private void btnconf_Click(object sender, EventArgs e)
        {
             
            if (VarGlobal.trancaCandidato == true)
            {
                MessageBox.Show("Essa opção esta bloqueada");
                Close();
            }
            else
            {
                VarGlobal.nomeCandidato = txtboxcand.Text;
                if (VarGlobal.Candidatos.Contains(VarGlobal.nomeCandidato))
                {
                    MessageBox.Show("Esse candidato ja foi adicionado!");
                    Close();
                }
                else
                {
                    VarGlobal.Candidatos.Add(VarGlobal.nomeCandidato);
                    MessageBox.Show("Candidato cadastrado!");                    
                    Close();
                }
            }

        }

        private void txtboxcand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
