using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace eleicaoforms
{
    public partial class Votação : Form
    {
        //public static bool IdiomaInglesT = true;

        public Votação()
        {
            InitializeComponent();
            AlteraidiomaVoto();
        }


        private void S_TextChanged(object sender, EventArgs e)//rtxmostracandidato
        {
            this.btncliqueAqui.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int P = 0;
            string textoCandidatos = "";
            if (VarGlobal.idiomaIngles == true)
            {
                foreach (var nome in VarGlobal.Candidatos)
                {
                    textoCandidatos += "candidate(a): " + nome + "\nCandidate number is: " + (P + 1) + "\n\n";
                    P++;
                }
            }
            else
            {
                foreach (var nome in VarGlobal.Candidatos)
                {
                    textoCandidatos += "Candidato(a): " + nome + "\nO número do candidato(a) é: " + (P + 1) + "\n\n";
                    P++;
                }
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
                Telainicial telainicial = new Telainicial();
                telainicial.Show();
            }
            else
            {

                int voto;
                if (int.TryParse(tbxVotar.Text, out voto))
                {
                    VarGlobal.votos[voto - 1]++; // -1 para poder colocar o voto no candidato certo
                    if(VarGlobal.idiomaIngles == true)
                    {
                        MessageBox.Show("Vote computed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Voto computado com sucesso!");
                    }             
                    tbxVotar.Clear();
                    eleitoresVotados++;
                    SoundPlayer somdavotação = new SoundPlayer("C:\\Users\\igorp\\Music\\som-de-finalização-de-votação.wav");
                    somdavotação.Play();

                    if (eleitoresVotados == VarGlobal.quantidadeEleitor)
                    {
                        
                        VarGlobal.trancaCandidato = true;
                        VarGlobal.trancaEleitor = true;
                        VarGlobal.quantidadeEleitor = 0;
                        this.Close();
                        Telainicial telainicial = new Telainicial();
                        telainicial.Show();
                        
                    }
                }
            }
        }
        public void AlteraidiomaVoto()
        {
            if (VarGlobal.idiomaIngles == true)
            {
                LblImportante.Text = "IMPORTANT";
                LblmostraCandidato.Text = "Click the button below to see \nthe list of available candidates.";
                LblNulo.Text = "If you want to vote null or blank, put a \nnumber that does not belong to any candidate.";
                LblNumeroVoto.Text = "Enter the number of the candidate you wish to vote for here.";
                btncliqueAqui.Text = "Click here.";
                btnVotar.Text = "Vote!";
            }  
            else if (VarGlobal.idiomaIngles ==  false)
            {

            }
        }
    }
}

