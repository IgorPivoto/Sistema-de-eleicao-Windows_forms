using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eleicaoforms
{
    public partial class pesquisacandidato : Form
    {
        public pesquisacandidato()
        {
            InitializeComponent();
            AlteraIdiomapesquisa();
        }

        private void BtnlistaCandidato_Click(object sender, EventArgs e)
        {
            int P = 0;
            if(VarGlobal.idiomaIngles == true)
            {
                foreach (var item in VarGlobal.Candidatos)
                {
                    MessageBox.Show("The candidate: " + item + " " + "\nThe Candidate number is: " + (P + 1));
                    P++;
                }
            }
            else
            {
                foreach (var item in VarGlobal.Candidatos)
                {
                    MessageBox.Show("candidato(a):" + item + " " + "\nO numero do candidato(a) é:" + (P + 1));
                    P++;
                }
            }

            Close();
        }

        private void Btnpesquisacandidato_Click(object sender, EventArgs e)
        {
            telaPesquisa tela = new telaPesquisa();
            tela.Show();
            Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void AlteraIdiomapesquisa()
        {
            if (VarGlobal.idiomaIngles == true)
            {
                lblopcao.Text = "choose the options";
                btnlistaCandidato.Text = "see candidate list";
                btnpesquisacandidato.Text = "search candidate";
            }
            else if (VarGlobal.idiomaIngles == false)
            {

            }
        }
    }
}
