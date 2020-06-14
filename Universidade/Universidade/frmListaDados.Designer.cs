namespace Universidade
{
    partial class frmListaDados
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
            this.label1 = new System.Windows.Forms.Label();
            this.ltbDados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dados Pessoais";
            // 
            // ltbDados
            // 
            this.ltbDados.FormattingEnabled = true;
            this.ltbDados.Location = new System.Drawing.Point(15, 52);
            this.ltbDados.Name = "ltbDados";
            this.ltbDados.Size = new System.Drawing.Size(563, 173);
            this.ltbDados.TabIndex = 3;
            // 
            // frmListaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 271);
            this.Controls.Add(this.ltbDados);
            this.Controls.Add(this.label1);
            this.Name = "frmListaDados";
            this.Text = "Gestão de dados";
            this.Shown += new System.EventHandler(this.frmListaDados_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltbDados;
    }
}