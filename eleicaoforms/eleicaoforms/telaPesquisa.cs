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
            AlteraidiomaPesquisanome();
        }

        private void Btnpesquisa_Click(object sender, EventArgs e)
        {
            VarGlobal.nomeCandidato = txtboxpesquisanome.Text;
            int P = VarGlobal.Candidatos.IndexOf(VarGlobal.nomeCandidato);
            if (P == -1)
            {
                if (VarGlobal.idiomaIngles == true)
                {
                    MessageBox.Show("Candidate doesnt exist or was not found, check that you have written correctly.");
                }
                else
                {
                    MessageBox.Show("Candidato não existe ou não foi encontrado, verifique se escreveu corretamente.");
                }               
            }
            else
            {
                if(VarGlobal.idiomaIngles == true)
                {
                    MessageBox.Show("The candidate's name is: " + VarGlobal.nomeCandidato + "\nAnd the candidate's number is: " + (P + 1));
                }
                else
                {
                    MessageBox.Show("O nome do candidato(a) é: " + VarGlobal.nomeCandidato + "\nE o numero do candidato(a) é: " + (P + 1));
                }          
            }
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AlteraidiomaPesquisanome()
        {
            if (VarGlobal.idiomaIngles == true)
            {
                LblnomeCandidato.Text = "Enter the candidate's name";
                btnpesquisa.Text = "research";
            }     
            else if (VarGlobal.idiomaIngles == false)
            {

            }
        }
    }
}
