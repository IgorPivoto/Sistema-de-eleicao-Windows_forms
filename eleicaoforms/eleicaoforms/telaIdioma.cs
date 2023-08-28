using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.DataFormats;

namespace eleicaoforms
{
    public partial class telaIdioma : Form
    {
        public telaIdioma()
        {
            InitializeComponent();
        }


        //private CultureInfo currentCulture;

        private void btnIngles_Click(object sender, EventArgs e)
        {
            lblIdioma.Text = "choose the language";
            Close();
            VarGlobal.idiomaIngles = true;
            /*currentCulture = new CultureInfo("en-US"); // Defina o idioma desejado (neste caso, inglês)
            Thread.CurrentThread.CurrentUICulture = currentCulture;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(telaIdioma));
            resources.ApplyResources(this, "$this");*/
        }

        private void btnPortugues_Click(object sender, EventArgs e)
        {

        }
    }
}
