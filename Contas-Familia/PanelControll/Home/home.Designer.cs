
namespace Contas_Familia.PanelControll.Home
{
    partial class home
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
            this.lb_home = new System.Windows.Forms.Label();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.pl_family = new System.Windows.Forms.Panel();
            this.bt_new_family = new FontAwesome.Sharp.IconButton();
            this.pl_top.SuspendLayout();
            this.pl_mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_top.Controls.Add(this.lb_home);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1078, 51);
            this.pl_top.TabIndex = 0;
            // 
            // lb_home
            // 
            this.lb_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.Color.White;
            this.lb_home.Location = new System.Drawing.Point(3, 12);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(1072, 31);
            this.lb_home.TabIndex = 97;
            this.lb_home.Text = "HOME";
            this.lb_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_mid
            // 
            this.pl_mid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_mid.Controls.Add(this.pl_family);
            this.pl_mid.Controls.Add(this.bt_new_family);
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_mid.Location = new System.Drawing.Point(0, 51);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1078, 457);
            this.pl_mid.TabIndex = 143;
            // 
            // pl_family
            // 
            this.pl_family.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_family.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_family.Location = new System.Drawing.Point(366, 51);
            this.pl_family.Name = "pl_family";
            this.pl_family.Size = new System.Drawing.Size(560, 300);
            this.pl_family.TabIndex = 99;
            // 
            // bt_new_family
            // 
            this.bt_new_family.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_new_family.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_new_family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_new_family.FlatAppearance.BorderSize = 0;
            this.bt_new_family.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_new_family.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_new_family.ForeColor = System.Drawing.Color.White;
            this.bt_new_family.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.bt_new_family.IconColor = System.Drawing.Color.White;
            this.bt_new_family.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_new_family.IconSize = 35;
            this.bt_new_family.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_new_family.Location = new System.Drawing.Point(131, 51);
            this.bt_new_family.Name = "bt_new_family";
            this.bt_new_family.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_new_family.Size = new System.Drawing.Size(210, 46);
            this.bt_new_family.TabIndex = 100;
            this.bt_new_family.Tag = "";
            this.bt_new_family.Text = "NEW FAMILY";
            this.bt_new_family.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_new_family.UseVisualStyleBackColor = false;
            this.bt_new_family.Click += new System.EventHandler(this.bt_new_family_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_top);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1078, 965);
            this.pl_top.ResumeLayout(false);
            this.pl_mid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Panel pl_mid;
        private System.Windows.Forms.Panel pl_family;
        private FontAwesome.Sharp.IconButton bt_new_family;
    }
}
