
namespace Contas_Familia.PanelControll.Register
{
    partial class register_name
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
            this.pl_reg = new System.Windows.Forms.Panel();
            this.bt_next = new System.Windows.Forms.Button();
            this.txt_name = new Contas_Familia.Script.RJTextBox();
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_register = new System.Windows.Forms.Label();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.pl_reg.SuspendLayout();
            this.pl_top.SuspendLayout();
            this.pl_mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_reg
            // 
            this.pl_reg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_reg.Controls.Add(this.bt_next);
            this.pl_reg.Controls.Add(this.txt_name);
            this.pl_reg.Location = new System.Drawing.Point(146, 6);
            this.pl_reg.Name = "pl_reg";
            this.pl_reg.Size = new System.Drawing.Size(830, 50);
            this.pl_reg.TabIndex = 11;
            // 
            // bt_next
            // 
            this.bt_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_next.BackColor = System.Drawing.Color.Gray;
            this.bt_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_next.FlatAppearance.BorderSize = 0;
            this.bt_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_next.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_next.ForeColor = System.Drawing.Color.White;
            this.bt_next.Location = new System.Drawing.Point(694, 7);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(122, 36);
            this.bt_next.TabIndex = 67;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = false;
            this.bt_next.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.BorderColor = System.Drawing.Color.White;
            this.txt_name.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_name.BorderRadius = 0;
            this.txt_name.BorderSize = 2;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.Location = new System.Drawing.Point(16, 12);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_name.PasswordChar = false;
            this.txt_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name.PlaceholderText = "Name";
            this.txt_name.Size = new System.Drawing.Size(250, 31);
            this.txt_name.TabIndex = 7;
            this.txt_name.Texts = "";
            this.txt_name.UnderlinedStyle = false;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_top.Controls.Add(this.lb_register);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1078, 51);
            this.pl_top.TabIndex = 98;
            // 
            // lb_register
            // 
            this.lb_register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_register.ForeColor = System.Drawing.Color.White;
            this.lb_register.Location = new System.Drawing.Point(3, 12);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(1072, 31);
            this.lb_register.TabIndex = 97;
            this.lb_register.Text = "REGISTER";
            this.lb_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_mid
            // 
            this.pl_mid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_mid.Controls.Add(this.pl_reg);
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_mid.Location = new System.Drawing.Point(0, 51);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1078, 457);
            this.pl_mid.TabIndex = 144;
            // 
            // register_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_top);
            this.Name = "register_name";
            this.Size = new System.Drawing.Size(1078, 965);
            this.pl_reg.ResumeLayout(false);
            this.pl_top.ResumeLayout(false);
            this.pl_mid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_reg;
        private System.Windows.Forms.Button bt_next;
        private Script.RJTextBox txt_name;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_register;
        private System.Windows.Forms.Panel pl_mid;
    }
}
