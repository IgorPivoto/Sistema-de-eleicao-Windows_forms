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
    public partial class Votação : Form
    {

        public Votação()
        {
            InitializeComponent();
        }


        private void S_TextChanged(object sender, EventArgs e)//rtxmostracandidato
        {
            this.btncliqueAqui.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int P = 0;
            string textoCandidatos = "";

            foreach (var item in VarGlobal.Candidatos)
            {
                textoCandidatos += "Candidato(a): " + item + "\nO número do candidato(a) é: " + (P + 1) + "\n\n";
                P++;
            }
            rtxmostracandidato.ReadOnly = true;
            rtxmostracandidato.Text = textoCandidatos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int eleitoresVotados = 0;

        private void btnVotar_Click(object sender, EventArgs e)
        {
            
                if (VarGlobal.quantidadeEleitor == 0)
                {
                    MessageBox.Show("Todos os eleitores ja votaram!");
                    this.Close();
                    telainicial telainicial = new telainicial();
                    telainicial.Show();
                }
                else
                {
                    int voto;
                    if (int.TryParse(tbxVotar.Text, out voto))
                    {
                        VarGlobal.votos[voto - 1]++; // -1 para poder colocar o voto no candidato certo
                        MessageBox.Show("Voto computado com sucesso!");
                        tbxVotar.Clear();
                        eleitoresVotados++;
                        if(eleitoresVotados >= VarGlobal.quantidadeEleitor)
                        {
                            VarGlobal.trancaCandidato = true;
                            VarGlobal.trancaEleitor = true;
                            VarGlobal.quantidadeEleitor = 0;
                            this.Close();
                            telainicial telainicial = new telainicial();
                            telainicial.Show();
                        }
                    }
 
                }
            }
        }
    }

    