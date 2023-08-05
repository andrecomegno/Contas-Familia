
namespace Contas_Familia.PanelControll.Settings
{
    partial class setting
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_setting = new System.Windows.Forms.Label();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pl_top.SuspendLayout();
            this.pl_mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_top.Controls.Add(this.lb_setting);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1078, 51);
            this.pl_top.TabIndex = 99;
            // 
            // lb_setting
            // 
            this.lb_setting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_setting.ForeColor = System.Drawing.Color.White;
            this.lb_setting.Location = new System.Drawing.Point(3, 12);
            this.lb_setting.Name = "lb_setting";
            this.lb_setting.Size = new System.Drawing.Size(1072, 31);
            this.lb_setting.TabIndex = 97;
            this.lb_setting.Text = "SETTING";
            this.lb_setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_mid
            // 
            this.pl_mid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_mid.Controls.Add(this.panel1);
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_mid.Location = new System.Drawing.Point(0, 51);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1078, 457);
            this.pl_mid.TabIndex = 145;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(46, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 168);
            this.panel1.TabIndex = 0;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_top);
            this.Name = "setting";
            this.Size = new System.Drawing.Size(1078, 965);
            this.pl_top.ResumeLayout(false);
            this.pl_mid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_setting;
        private System.Windows.Forms.Panel pl_mid;
        private System.Windows.Forms.Panel panel1;
    }
}
