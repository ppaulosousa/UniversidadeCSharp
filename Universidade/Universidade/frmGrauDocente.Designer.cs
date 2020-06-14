namespace Universidade
{
    partial class frmGrauDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrauDocente));
            this.txtGrau = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmFormation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGrau
            // 
            this.txtGrau.Location = new System.Drawing.Point(12, 34);
            this.txtGrau.Name = "txtGrau";
            this.txtGrau.Size = new System.Drawing.Size(622, 20);
            this.txtGrau.TabIndex = 0;
            this.txtGrau.Enter += new System.EventHandler(this.txtGrau_Enter);
            this.txtGrau.Leave += new System.EventHandler(this.txtGrau_Leave);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(12, 84);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(622, 20);
            this.txtLocal.TabIndex = 1;
            this.txtLocal.Enter += new System.EventHandler(this.txtLocal_Enter);
            this.txtLocal.Leave += new System.EventHandler(this.txtLocal_Leave);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFormation,
            this.clmLocal,
            this.clmDate});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(622, 174);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmFormation
            // 
            this.clmFormation.Text = "Formação";
            this.clmFormation.Width = 328;
            // 
            // clmLocal
            // 
            this.clmLocal.Text = "Instituição";
            this.clmLocal.Width = 150;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Data de Obtenção";
            this.clmDate.Width = 136;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(15, 133);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(145, 20);
            this.dtpData.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data de obtenção";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(540, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(398, 343);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(101, 35);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Remover dado";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Grau:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Local:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(540, 343);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 35);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Registrar Obtenções";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frmGrauDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 390);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtGrau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrauDocente";
            this.Text = "Obtenção de Grau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrauDocente_FormClosing);
            this.Shown += new System.EventHandler(this.frmGrauDocente_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrau;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmFormation;
        private System.Windows.Forms.ColumnHeader clmLocal;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
    }
}