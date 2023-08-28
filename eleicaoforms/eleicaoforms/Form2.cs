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
    public partial class janellacadastro : Form
    {
        public janellacadastro()
        {
            InitializeComponent();
            AlteraIdioma();
        }

        private void Btnconf_Click(object sender, EventArgs e)
        {

            if (VarGlobal.trancaCandidato == true)
            {
                MessageBox.Show("Essa opção esta bloqueada");
                Close();
            }
            else
            {

                VarGlobal.nomeCandidato = txtboxcand.Text;
                if (VarGlobal.Candidatos.Contains(VarGlobal.nomeCandidato))
                {
                    if(VarGlobal.idiomaIngles==true)
                    {
                        MessageBox.Show("This candidate has already been added!");
                    }
                    else
                    {
                        MessageBox.Show("Esse candidato já foi adicionado!");
                    }
                    
                    Close();
                }
                else
                {
                    VarGlobal.Candidatos.Add(VarGlobal.nomeCandidato);
                    if(VarGlobal.idiomaIngles == true)
                    {
                        MessageBox.Show("Registered candidate!");
                    }
                    else
                    {
                        MessageBox.Show("Candidato cadastrado!");
                    }                   
                    Close();
                }

            }

        }

        private void Txtboxcand_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nomecand_Click(object sender, EventArgs e)
        {

        }

        public void AlteraIdioma()
        {
            if (VarGlobal.idiomaIngles == true)
            {
                nomecand.Text = "enter candidate's name";
                btnconf.Text = "Confirm";
            }
            else if(VarGlobal.idiomaIngles == false)
            {
                
            }
        }
    }
}
