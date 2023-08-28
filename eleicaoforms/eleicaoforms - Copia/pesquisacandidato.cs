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
    public partial class pesquisacandidato : Form
    {
        public pesquisacandidato()
        {
            InitializeComponent();
        }

        private void btnlistaCandidato_Click(object sender, EventArgs e)
        {
            int P = 0;
            foreach (var item in VarGlobal.Candidatos)
            {
                MessageBox.Show("candidato(a):"+item + " " +"\nO numero do candidato(a) é:"+(P + 1));
                P++;
            }          
            Close();
        }

        private void btnpesquisacandidato_Click(object sender, EventArgs e)
        {
            telaPesquisa tela = new telaPesquisa();
            tela.Show();
        }
    }
}
