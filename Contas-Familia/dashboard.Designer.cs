
namespace Contas_Familia
{
    partial class dashboard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_dashboard = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pl_dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_dashboard
            // 
            this.pl_dashboard.Controls.Add(this.panel1);
            this.pl_dashboard.Controls.Add(this.pl_mid);
            this.pl_dashboard.Controls.Add(this.pl_top);
            this.pl_dashboard.Location = new System.Drawing.Point(12, 12);
            this.pl_dashboard.Name = "pl_dashboard";
            this.pl_dashboard.Size = new System.Drawing.Size(1189, 764);
            this.pl_dashboard.TabIndex = 0;
            // 
            // pl_top
            // 
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1189, 129);
            this.pl_top.TabIndex = 0;
            // 
            // pl_mid
            // 
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_mid.Location = new System.Drawing.Point(0, 129);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1189, 469);
            this.pl_mid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 291);
            this.panel1.TabIndex = 2;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 788);
            this.Controls.Add(this.pl_dashboard);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pl_dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_dashboard;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pl_mid;
    }
}

