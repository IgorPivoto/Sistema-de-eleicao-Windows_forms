namespace eleicaoforms
{
    public partial class telainicial : Form
    {

        public telainicial()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            if (VarGlobal.trancaCandidato == true)
            {
                MessageBox.Show("Essa opção esta bloqueada");
            }
            else
            {
                janellacadastro tela = new janellacadastro();
                tela.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VarGlobal.trancaEleitor == true)
            {
                MessageBox.Show("Essa opção esta bloqueada");
            }
            else
            {
                telaeleitor tela = new telaeleitor();
                tela.Show();
            }
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            pesquisacandidato tela = new pesquisacandidato();
            tela.Show();
        }


        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (VarGlobal.quantidadeEleitor == 0)
            {
                MessageBox.Show("Todos os eleitores ja votaram!");

            }
            else
            {
                Votação telaVotacao = new Votação();
                telaVotacao.Show();
                this.Hide();
            }
        }

        private void btnMostraresultado_Click(object sender, EventArgs e)
        {
            telaResultado tela = new telaResultado();
            tela.Show();
        }
    }
}