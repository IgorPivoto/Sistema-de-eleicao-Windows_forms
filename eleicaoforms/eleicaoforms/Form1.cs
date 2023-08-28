using System.Globalization;

namespace eleicaoforms
{
    public partial class Telainicial : Form
    {

        public Telainicial()
        {
            InitializeComponent();
            AlteraidiomaMenuprincipal();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Btncadastro_Click(object sender, EventArgs e)
        {
            if (VarGlobal.trancaCandidato == true)
            {
                if (VarGlobal.idiomaIngles == true)
                {
                    MessageBox.Show("This option is blocked");
                }
                else
                {
                    MessageBox.Show("Essa opção está bloqueada");
                }
            }
            else
            {
                janellacadastro tela = new janellacadastro();
                tela.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (VarGlobal.trancaEleitor == true)
            {
                if (VarGlobal.idiomaIngles == true)
                {
                    MessageBox.Show("This option is blocked");
                }
                else
                {
                    MessageBox.Show("Essa opção está bloqueada");
                }
            }
            else
            {
                telaeleitor tela = new telaeleitor();
                tela.Show();
            }
        }

        private void Btnpesquisa_Click(object sender, EventArgs e)
        {
            pesquisacandidato tela = new pesquisacandidato();
            tela.Show();
        }

        private void BtnVotar_Click(object sender, EventArgs e)
        {
            if (VarGlobal.quantidadeEleitor == 0)
            {
                if (VarGlobal.idiomaIngles == true)
                {
                    MessageBox.Show("All voters have already voted!");
                }
                else
                {
                    MessageBox.Show("Todos os eleitores já votaram!");
                }
            }
            else
            {
                Votação telaVotacao = new Votação();
                telaVotacao.Show();
                this.Hide();
            }

        }

        private void BtnMostraresultado_Click(object sender, EventArgs e)
        {
            telaResultado tela = new telaResultado();
            tela.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIdioma_Click(object sender, EventArgs e)
        {

            VarGlobal.idiomaIngles = !VarGlobal.idiomaIngles;

            if (VarGlobal.idiomaIngles == true)
            {
                lblEscolha.Text = "CHOICE";
                btnVotar.Text = "Vote";
                btnSair.Text = "Exit";
                btnpesquisa.Text = "Search candidate";
                btnMostraresultado.Text = "Election result";
                btnele.Text = "Update voters";
                btncadastro.Text = "Register candidate";
                btnIdioma.Text = "Language";
            }
            else if (VarGlobal.idiomaIngles == false)
            {
                lblEscolha.Text = "Escolha";
                btnVotar.Text = "Votar";
                btnSair.Text = "Sair";
                btnpesquisa.Text = "Pesquisar candidato";
                btnMostraresultado.Text = "Resultado da eleição";
                btnele.Text = "Atualizar eleitores";
                btncadastro.Text = "Registrar candidato";
                btnIdioma.Text = "Idioma";
            }

        }

        private void Txtescolha_Click(object sender, EventArgs e)
        {

        }

        public void AlteraidiomaMenuprincipal()
        {
            if (VarGlobal.idiomaIngles == true)
            {
                lblEscolha.Text = "CHOICE";
                btnVotar.Text = "vote";
                btnSair.Text = "exit";
                btnpesquisa.Text = "search candidate";
                btnMostraresultado.Text = "election result";
                btnele.Text = "update voters";
                btncadastro.Text = "register candidate";
                btnIdioma.Text = "language";
            }

        }
    }
}