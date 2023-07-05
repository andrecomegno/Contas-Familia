
namespace Contas_Familia.PanelControll.Dashboard
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_dashboard = new System.Windows.Forms.Label();
            this.pl_left = new System.Windows.Forms.Panel();
            this.pl_right = new System.Windows.Forms.Panel();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_family = new System.Windows.Forms.Button();
            this.pl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_top.Controls.Add(this.bt_family);
            this.pl_top.Controls.Add(this.bt_home);
            this.pl_top.Controls.Add(this.lb_dashboard);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1222, 67);
            this.pl_top.TabIndex = 146;
            // 
            // lb_dashboard
            // 
            this.lb_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dashboard.ForeColor = System.Drawing.Color.White;
            this.lb_dashboard.Location = new System.Drawing.Point(3, 12);
            this.lb_dashboard.Name = "lb_dashboard";
            this.lb_dashboard.Size = new System.Drawing.Size(1216, 31);
            this.lb_dashboard.TabIndex = 97;
            this.lb_dashboard.Text = "DASHBOARD";
            this.lb_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_left
            // 
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 67);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(40, 931);
            this.pl_left.TabIndex = 147;
            // 
            // pl_right
            // 
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_right.Location = new System.Drawing.Point(1182, 67);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(40, 931);
            this.pl_right.TabIndex = 148;
            // 
            // pl_mid
            // 
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_mid.Location = new System.Drawing.Point(40, 67);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1142, 931);
            this.pl_mid.TabIndex = 150;
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.ForeColor = System.Drawing.Color.White;
            this.bt_home.Location = new System.Drawing.Point(92, 39);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(77, 25);
            this.bt_home.TabIndex = 119;
            this.bt_home.Text = "Home";
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_family
            // 
            this.bt_family.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_family.FlatAppearance.BorderSize = 0;
            this.bt_family.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_family.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_family.ForeColor = System.Drawing.Color.White;
            this.bt_family.Location = new System.Drawing.Point(175, 39);
            this.bt_family.Name = "bt_family";
            this.bt_family.Size = new System.Drawing.Size(77, 25);
            this.bt_family.TabIndex = 120;
            this.bt_family.Text = "Family";
            this.bt_family.UseVisualStyleBackColor = false;
            this.bt_family.Click += new System.EventHandler(this.bt_family_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.pl_left);
            this.Controls.Add(this.pl_top);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1222, 998);
            this.pl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_dashboard;
        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.Panel pl_right;
        private System.Windows.Forms.Panel pl_mid;
        private System.Windows.Forms.Button bt_family;
        private System.Windows.Forms.Button bt_home;
    }
}
