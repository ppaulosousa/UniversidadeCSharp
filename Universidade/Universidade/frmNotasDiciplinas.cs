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
    public partial class frmNotasDiciplinas : Form
    {

        public int idx;
        public List<Notas> nt;

        public frmNotasDiciplinas()
        {
            InitializeComponent();          
        }

        private void frmNotasDiciplinas_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAluno fr = (frmAluno)this.Owner;
            fr.al[idx].nt = this.nt;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Notas nt = new Notas();
            nt.Disciplina = txtDisciplina.Text;
            nt.Nota = cboNota.Text;

            if (string.IsNullOrEmpty(txtDisciplina.Text))
            {
                MessageBox.Show("Insira a Disciplina");
            }
            if (cboNota.SelectedIndex == -1)
            {
                MessageBox.Show("Insira a Nota");
            }

            ListViewItem newlist = new ListViewItem(nt.Disciplina);
            newlist.SubItems.Add(nt.Nota);
            listView1.Items.Add(newlist);



        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem); // Removendo o item selecionado
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nt = new List<Notas>();
            foreach (ListViewItem item in listView1.Items)
            {
                Notas n = new Notas
                {
                    Disciplina = item.Text,
                    Nota = item.SubItems[1].Text
                };
                nt.Add(n);
            }
            MessageBox.Show("Notas registradas.");
        }


        private void frmNotasDiciplinas_Shown(object sender, EventArgs e)
        {
            
            foreach (Notas n in nt)
            {
                ListViewItem newlist = new ListViewItem(n.Disciplina);
                newlist.SubItems.Add(n.Nota);
                listView1.Items.Add(newlist);
            }
        }
    }
}
