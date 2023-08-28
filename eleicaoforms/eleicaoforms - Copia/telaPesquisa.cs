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
    public partial class telaPesquisa : Form
    {
        public telaPesquisa()
        {
            InitializeComponent();
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            VarGlobal.nomeCandidato = txtboxpesquisanome.Text;
            int P = VarGlobal.Candidatos.IndexOf(VarGlobal.nomeCandidato);
            if (P == -1)
            {
                MessageBox.Show("Candidato não existe ou não foi encontrado, verifique se escreveu corretamente.");
            }
            else
            {
                MessageBox.Show("O nome do candidato(a) é: " + VarGlobal.nomeCandidato + "\nE o numero do candidato(a) é: " + (P + 1)); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
