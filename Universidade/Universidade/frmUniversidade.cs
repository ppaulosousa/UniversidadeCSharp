using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Universidade
{
    public partial class frmUniversidade : Form
    {
        public List<Aluno> al = new List<Aluno>();
        public List<Docente> dc = new List<Docente>();
        public List<DadosPessoais> dp;

        int i = 0;
        public frmUniversidade()
        {
            InitializeComponent();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            foreach (Form fr in this.OwnedForms)
                if (fr.GetType() == typeof(frmDocente))
                {
                    fr.Activate();
                    return;
                }
            frmDocente frm = new frmDocente();
            frm.dc = this.dc;
            frm.Show(this);
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            foreach(Form fr in this.OwnedForms)
                if (fr.GetType() == typeof(frmAluno))
            {
                fr.Activate();
                return;
            }
            frmAluno frm = new frmAluno();
            frm.al = this.al;
            frm.Show(this);
        }
        
        private int ComparaNomes( DadosPessoais d1, DadosPessoais d2)
        {
            return string.Compare(d1.Nome, d2.Nome);
        }

        private void btnListaDados_Click(object sender, EventArgs e)
        {
            dp = new List<DadosPessoais>();
            dp = dp.Concat(al).ToList();
            dp = dp.Concat(dc).ToList();
            List<DadosPessoais> dis = dp.Distinct().ToList();
            dis.Sort(ComparaNomes);



            foreach (Form fr in this.OwnedForms)
                if (fr.GetType() == typeof(frmListaDados))
                    {
                        fr.Activate();
                        return;
                    }
                
            frmListaDados frm = new frmListaDados();
            frm.dp = dis;
            frm.Show(this);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ofdImport.ShowDialog(this) == DialogResult.OK)
            {
                ImportExport ie = new ImportExport();
                string filename = ofdImport.FileName;
                StreamReader sr = new StreamReader(filename);
                XmlSerializer s = new XmlSerializer(typeof(ImportExport));
                ie = (ImportExport)s.Deserialize(sr);
                this.al = ie.al;
                this.dc = ie.dc;
                i = 0;
                
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (sfdExport.ShowDialog(this) == DialogResult.OK)
            {
                ImportExport ie = new ImportExport();
                ie.al = this.al;
                ie.dc = this.dc;

                string filename = sfdExport.FileName;
                if (File.Exists(filename))
                    File.Delete(filename);
                StreamWriter sw = new StreamWriter(filename);
                XmlSerializer s = new XmlSerializer(typeof(ImportExport));
                s.Serialize(sw, ie);
                sw.Close();

            }
        }
    }
} 
