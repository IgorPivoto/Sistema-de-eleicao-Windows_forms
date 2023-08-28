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
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VarGlobal.Candidatos.Count; i++)
            {
                int votosCandidato = VarGlobal.votos[i];

                if (votosCandidato > 0)
                {
                    string textoCandidato = "O candidato(a) " + VarGlobal.Candidatos[i] + " teve " + votosCandidato + " votos\n";
                    rtxmostraResultado.AppendText(textoCandidato); // Adiciona o texto formatado à RichTextBox
                }
            }
        }

        private void rtxmostraResultado_TextChanged(object sender, EventArgs e)
        {
            this.btnResultado.Enabled = true;
        }
    }
}
