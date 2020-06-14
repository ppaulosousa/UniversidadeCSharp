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
    public partial class frmAluno : Form 
    {
        public List<Aluno> al;
        public List<Docente> dc;
        int i = 0;
        public frmAluno()
        {
            InitializeComponent();
        }

        private void frmAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmUniversidade fr = (frmUniversidade)this.Owner;
            fr.al = this.al;
        }

        private void MostraDados(Aluno al)
        {
            txtN_Aluno.Text = al.N_Aluno.ToString();
            txtBI.Text = al.BI.ToString();
            txtNome.Text = al.Nome;
            txtMorada.Text = al.Morada;
            txtCP.Text = al.Codigo_Postal.ToString();
            txtTelemovel.Text = al.Telemovel.ToString();
            txtemail.Text = al.Email;
            txtCurso.Text = al.Curso;
        }

        private void LimpaDados()
        {
            txtN_Aluno.Text = "";
            txtNome.Text = "";
            txtMorada.Text = "";
            txtCP.Text = "";
            txtTelemovel.Text = "";
            txtBI.Text = "";
            txtemail.Text = "";
            txtCurso.Text = "";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (al.Count > 0)
            {
                MostraDados(al[i = 0]);
            }
            else
                MessageBox.Show("Aluno inexistente.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Aluno novo = new Aluno();
            novo.nt = new List<Notas>();
            al.Add(novo);
            i = al.Count - 1;
            MostraDados(al[i]);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtN_Aluno.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtMorada.Text)
                    || string.IsNullOrEmpty(txtCP.Text) || string.IsNullOrEmpty(txtTelemovel.Text) ||
                    string.IsNullOrEmpty(txtBI.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtCurso.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            Aluno a = new Aluno();
            a.N_Aluno = int.Parse(txtN_Aluno.Text);
            a.BI = int.Parse(txtBI.Text);
            a.Nome = txtNome.Text;
            a.Morada = txtMorada.Text;
            a.Codigo_Postal = int.Parse(txtCP.Text);
            a.Telemovel = int.Parse(txtTelemovel.Text);
            a.Email = txtemail.Text;
            a.Curso = txtCurso.Text;
            al.Add(a);
            MessageBox.Show("Aluno registrado com sucesso.");
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (al.Count > 0)
            {
                MostraDados(al[i = al.Count - 1]);
            }
            else
                MessageBox.Show("Fim da lista.");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (al.Count > 0)
            {
                if (i > 0)
                    MostraDados(al[--i]);
                else
                    MessageBox.Show("Não pode andar para trás");
            }
            else
                MessageBox.Show("Aluno inexistente.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (al.Count > 0)
            {
                if (i < al.Count-1)
                    MostraDados(al[++i]);
                else
                    MessageBox.Show("Não pode andar para frente");
            }
            else
                MessageBox.Show("Aluno inexistente.");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (al.Count > 0)
            {
                al.RemoveAt(i);
                if (i > al.Count - 1)
                    i = al.Count - 1;
                if (al.Count > 0)
                    MostraDados(al[i]);
                else
                    LimpaDados();
            }
            else
                MessageBox.Show("Não existe dados.");
        }

        

        private void btnNotas_Click(object sender, EventArgs e)
        {
            foreach (Form fr in this.OwnedForms)
                if (fr.GetType() == typeof(frmNotasDiciplinas))
                {
                    fr.Activate();
                    return;
                }
            frmNotasDiciplinas frm = new frmNotasDiciplinas();
            frm.nt = this.al[i].nt;
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

        private void txtN_Aluno_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtN_Aluno.Text))
            {
                int k = 0;
                if (!int.TryParse(txtN_Aluno.Text, out k))
                {
                    MessageBox.Show("Apenas número.");
                    e.Cancel = true;
                }
            }
        }


    }
}
