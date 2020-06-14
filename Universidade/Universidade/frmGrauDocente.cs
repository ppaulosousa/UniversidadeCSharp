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
    public partial class frmGrauDocente : Form // FORMCLOSING OK
    {

        public int idx;
        public List<Grau> gr;

        public frmGrauDocente()
        {
            InitializeComponent();
        }

        private void frmGrauDocente_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDocente fr = (frmDocente)this.Owner;
            fr.dc[idx].gr = this.gr;
        }

        private void txtGrau_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))  //Verificar se Textbox está vazia
            {
                tb.Text = "Insira a sua obtenção de grau";
            }
        }

        private void txtGrau_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if( tb.Text == "Insira a sua obtenção de grau")
            {
                tb.Clear();
            }
        }

        private void txtLocal_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(string.IsNullOrEmpty(tb.Text))
            {
                tb.Text = "Insira o local de obtenção";
            }
        }

        private void txtLocal_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text == "Insira o local de obtenção")
            {
                tb.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Grau gr = new Grau();
            gr.Grau_obtencao = txtGrau.Text;
            gr.Local = txtLocal.Text;
            gr.Dt_obtencao = dtpData.Value.ToShortDateString();

            if (string.IsNullOrEmpty(txtGrau.Text) || string.IsNullOrEmpty(txtLocal.Text))
            {
                MessageBox.Show("Falta requisito.");
            }

            ListViewItem newList = new ListViewItem(gr.Grau_obtencao);
            newList.SubItems.Add(gr.Local);
            newList.SubItems.Add(gr.Dt_obtencao);
            listView1.Items.Add(newList);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem); //Removendo item da lista
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            gr = new List<Grau>();
            foreach (ListViewItem item in listView1.Items)
            {
                Grau g = new Grau
                {
                    Grau_obtencao = item.Text,
                    Local = item.SubItems[1].Text,
                    Dt_obtencao = item.SubItems[2].Text
                };
                gr.Add(g);
            }
            MessageBox.Show("Notas registradas.");
        }


        private void frmGrauDocente_Shown(object sender, EventArgs e)
        {

            foreach (Grau g in gr)
            {
                
                ListViewItem newList = new ListViewItem(g.Grau_obtencao);
                newList.SubItems.Add(g.Local);
                newList.SubItems.Add(g.Dt_obtencao);
                listView1.Items.Add(newList);
            }
        }
    }
}
