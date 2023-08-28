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
    public partial class telaResultado : Form
    {
        public telaResultado()
        {
            InitializeComponent();
            AlteraidiomaResultado();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VarGlobal.Candidatos.Count; i++)
            {
                int votosCandidato = VarGlobal.votos[i];
                if (VarGlobal.idiomaIngles == true)
                {
                    if (votosCandidato > 0)
                    {
                        string textoCandidato = "The candidate " + VarGlobal.Candidatos[i] + " have " + votosCandidato + " vote\n";
                        rtxmostraResultado.AppendText(textoCandidato); 
                    }
                }
                else
                {
                    if (votosCandidato > 0)
                    {
                        string textoCandidato = "O candidato(a) " + VarGlobal.Candidatos[i] + " tem " + votosCandidato + " votos\n";
                        rtxmostraResultado.AppendText(textoCandidato); 
                    }
                }               
            }
        }

        private void rtxmostraResultado_TextChanged(object sender, EventArgs e)
        {
            this.btnResultado.Enabled = true;
        }
        public void AlteraidiomaResultado()
        {
            if(VarGlobal.idiomaIngles == true)
            {
                LblPrincipal.Text = "The result of the election will be displayed below.";
                LblResultado.Text = "Click the button to know the result:";
                btnResultado.Text = "see";
            }
            else if (VarGlobal.idiomaIngles == false)
            {

            }                   
        }
    }
}
