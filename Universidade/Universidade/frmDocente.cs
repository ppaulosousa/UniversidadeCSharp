using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Universidade
{
    public partial class frmDocente : Form
    {
        public List<Docente> dc;
        int i = 0;
        public frmDocente()
        {
            InitializeComponent();
        }

        private void frmDocente_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmUniversidade fr = (frmUniversidade)this.Owner;
            fr.dc = this.dc;
        }

        private void MostraDados(Docente dc)
        {
            txtN_Docente.Text = dc.N_Docente.ToString();
            txtNome.Text = dc.Nome;
            txtMorada.Text = dc.Morada;
            txtCP.Text = dc.Codigo_Postal.ToString();
            txtTelemovel.Text = dc.Telemovel.ToString();
            txtBI.Text = dc.BI.ToString();
            txtemail.Text = dc.Email;
            txtHoras.Text = dc.Horas_semanais.ToString();
        }

        private void LimpaDados()
        {
            txtN_Docente.Text = "";
            txtNome.Text = "";
            txtMorada.Text = "";
            txtCP.Text = "";
            txtTelemovel.Text = "";
            txtBI.Text = "";
            txtemail.Text = "";
            txtHoras.Text = "";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (dc.Count > 0)
            {
                MostraDados(dc[i = 0]);
            }
            else
                MessageBox.Show("Docente inexistente.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Docente novo = new Docente();
            novo.gr = new List<Grau>();
            dc.Add(novo);
            i = dc.Count - 1;
            MostraDados(dc[i]);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(txtN_Docente.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtMorada.Text)
                    || string.IsNullOrEmpty(txtCP.Text) || string.IsNullOrEmpty(txtTelemovel.Text) ||
                    string.IsNullOrEmpty(txtBI.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtHoras.Text))
                {
                    MessageBox.Show("Preencha todos os campos.");
                    return;
                }
                Docente d = new Docente();
                d.N_Docente = int.Parse(txtN_Docente.Text);
                d.Nome = txtNome.Text;
                d.Morada = txtMorada.Text;
                d.Codigo_Postal = int.Parse(txtCP.Text);
                d.Telemovel = int.Parse(txtTelemovel.Text);
                d.BI = int.Parse(txtBI.Text);
                d.Email = txtemail.Text;
                d.Horas_semanais = int.Parse(txtHoras.Text);
                dc.Add(d);
                MessageBox.Show("Docente registrado com sucesso");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (dc.Count > 0)
            {
                MostraDados(dc[i = dc.Count - 1]);
            }
            else
                MessageBox.Show("Fim da lista.");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (dc.Count > 0)
            {
                if (i > 0)
                    MostraDados(dc[--i]);
                else
                    MessageBox.Show("Não pode andar para trás");
            }
            else
                MessageBox.Show("Docente inexistente.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dc.Count > 0)
            {
                if (i < dc.Count - 1)
                    MostraDados(dc[++i]);
                else
                    MessageBox.Show("Não pode andar para frente");
            }
            else
                MessageBox.Show("Docente inexistente.");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dc.Count > 0)
            {
                dc.RemoveAt(i);
                if (i > dc.Count - 1)
                    i = dc.Count - 1;
                if (dc.Count > 0)
                    MostraDados(dc[i]);
                else
                    LimpaDados();
            }
            else
                MessageBox.Show("Docente inexistente.");
        }

        private void btnGrau_Click(object sender, EventArgs e)
        {
            foreach (Form fr in this.OwnedForms)
                if (fr.GetType() == typeof(frmGrauDocente))
                {
                    fr.Activate();
                    return;
                }
            frmGrauDocente frm = new frmGrauDocente();
            frm.gr = this.dc[i].gr;
            frm.idx = i;
            frm.Show(this);
        }

        private void txtTelemovel_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelemovel.Text))
            {
                int k = 0;
                if (!int.TryParse(txtTelemovel.Text, out k))
                {
                    MessageBox.Show("Apenas número.");
                    e.Cancel = true;
                }
            }
        }

        private void txtN_Docente_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtN_Docente.Text))
            {
                int k = 0;
                if (!int.TryParse(txtN_Docente.Text, out k))
                {
                    MessageBox.Show("Apenas número.");
                    e.Cancel = true;
                }
            }
        }

    }
}
