namespace Universidade
{
    partial class frmUniversidade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUniversidade));
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.btnListaDados = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocente
            // 
            this.btnDocente.Location = new System.Drawing.Point(90, 63);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(113, 23);
            this.btnDocente.TabIndex = 0;
            this.btnDocente.Text = "Cadastro Docente";
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(90, 106);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(113, 23);
            this.btnAluno.TabIndex = 1;
            this.btnAluno.Text = "Cadastro Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bem vindo, escolha a opção:";
            // 
            // ofdImport
            // 
            this.ofdImport.FileName = "univerdidade.xml";
            this.ofdImport.Filter = "*.xml|XML Files|*.*|All Files";
            // 
            // sfdExport
            // 
            this.sfdExport.Filter = "*.xml|XML Files|*.*|All Files";
            // 
            // btnListaDados
            // 
            this.btnListaDados.Location = new System.Drawing.Point(90, 151);
            this.btnListaDados.Name = "btnListaDados";
            this.btnListaDados.Size = new System.Drawing.Size(113, 23);
            this.btnListaDados.TabIndex = 7;
            this.btnListaDados.Text = "Lista de Dados";
            this.btnListaDados.UseVisualStyleBackColor = true;
            this.btnListaDados.Click += new System.EventHandler(this.btnListaDados_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(230, 224);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 46;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(149, 224);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 45;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmUniversidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 259);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnListaDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnDocente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUniversidade";
            this.Text = "Gestão Universidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.Button btnListaDados;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
    }
}

