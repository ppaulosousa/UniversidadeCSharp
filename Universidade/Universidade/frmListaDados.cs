using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Universidade
{
    public partial class frmListaDados : Form 
    {

        public List<DadosPessoais> dp;
        public frmListaDados()
        {
            InitializeComponent();
        }


        private void frmListaDados_Shown(object sender, EventArgs e)
        {
            ltbDados.Items.Clear();

            foreach (DadosPessoais d in dp)
            {
                ltbDados.Items.Add(d.Nome + "  -  " + d.Telemovel + "  -  " + d.Email);
            }
        }
    }
    
}
