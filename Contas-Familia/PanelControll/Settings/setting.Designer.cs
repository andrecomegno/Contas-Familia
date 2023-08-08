
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
            this.pl_account_01 = new System.Windows.Forms.Panel();
            this.pl_account = new System.Windows.Forms.Panel();
            this.bt_save_01 = new System.Windows.Forms.Button();
            this.bt_cancel_01 = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.Label();
            this.txt_password = new Contas_Familia.Script.RJTextBox();
            this.lb_title_01 = new System.Windows.Forms.Label();
            this.txt_repeat_password = new Contas_Familia.Script.RJTextBox();
            this.pl_top.SuspendLayout();
            this.pl_account_01.SuspendLayout();
            this.pl_account.SuspendLayout();
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
            // pl_account_01
            // 
            this.pl_account_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_account_01.Controls.Add(this.pl_account);
            this.pl_account_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_account_01.Location = new System.Drawing.Point(0, 51);
            this.pl_account_01.Name = "pl_account_01";
            this.pl_account_01.Size = new System.Drawing.Size(1078, 281);
            this.pl_account_01.TabIndex = 0;
            // 
            // pl_account
            // 
            this.pl_account.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_account.Controls.Add(this.bt_save_01);
            this.pl_account.Controls.Add(this.bt_cancel_01);
            this.pl_account.Controls.Add(this.txt_username);
            this.pl_account.Controls.Add(this.txt_password);
            this.pl_account.Controls.Add(this.lb_title_01);
            this.pl_account.Controls.Add(this.txt_repeat_password);
            this.pl_account.Location = new System.Drawing.Point(283, 11);
            this.pl_account.Name = "pl_account";
            this.pl_account.Size = new System.Drawing.Size(509, 243);
            this.pl_account.TabIndex = 101;
            // 
            // bt_save_01
            // 
            this.bt_save_01.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_save_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save_01.FlatAppearance.BorderSize = 0;
            this.bt_save_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save_01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save_01.ForeColor = System.Drawing.Color.White;
            this.bt_save_01.Location = new System.Drawing.Point(134, 177);
            this.bt_save_01.Name = "bt_save_01";
            this.bt_save_01.Size = new System.Drawing.Size(122, 36);
            this.bt_save_01.TabIndex = 106;
            this.bt_save_01.Text = "Save";
            this.bt_save_01.UseVisualStyleBackColor = false;
            this.bt_save_01.Click += new System.EventHandler(this.bt_save_01_Click);
            // 
            // bt_cancel_01
            // 
            this.bt_cancel_01.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_cancel_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel_01.FlatAppearance.BorderSize = 0;
            this.bt_cancel_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel_01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel_01.ForeColor = System.Drawing.Color.White;
            this.bt_cancel_01.Location = new System.Drawing.Point(262, 177);
            this.bt_cancel_01.Name = "bt_cancel_01";
            this.bt_cancel_01.Size = new System.Drawing.Size(122, 36);
            this.bt_cancel_01.TabIndex = 105;
            this.bt_cancel_01.Text = "Cancel";
            this.bt_cancel_01.UseVisualStyleBackColor = false;
            this.bt_cancel_01.Click += new System.EventHandler(this.bt_cancel_01_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_username.Location = new System.Drawing.Point(134, 45);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(250, 31);
            this.txt_username.TabIndex = 104;
            this.txt_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderColor = System.Drawing.Color.White;
            this.txt_password.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_password.BorderRadius = 0;
            this.txt_password.BorderSize = 2;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.Location = new System.Drawing.Point(134, 97);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_password.PasswordChar = true;
            this.txt_password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(250, 31);
            this.txt_password.TabIndex = 10;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = false;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lb_title_01
            // 
            this.lb_title_01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_01.ForeColor = System.Drawing.Color.White;
            this.lb_title_01.Location = new System.Drawing.Point(3, 10);
            this.lb_title_01.Name = "lb_title_01";
            this.lb_title_01.Size = new System.Drawing.Size(503, 31);
            this.lb_title_01.TabIndex = 98;
            this.lb_title_01.Text = "Account";
            this.lb_title_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_repeat_password
            // 
            this.txt_repeat_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_repeat_password.BorderColor = System.Drawing.Color.White;
            this.txt_repeat_password.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_repeat_password.BorderRadius = 0;
            this.txt_repeat_password.BorderSize = 2;
            this.txt_repeat_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repeat_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_repeat_password.Location = new System.Drawing.Point(134, 136);
            this.txt_repeat_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_repeat_password.Multiline = false;
            this.txt_repeat_password.Name = "txt_repeat_password";
            this.txt_repeat_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_repeat_password.PasswordChar = true;
            this.txt_repeat_password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_repeat_password.PlaceholderText = "Repeat Password";
            this.txt_repeat_password.Size = new System.Drawing.Size(250, 31);
            this.txt_repeat_password.TabIndex = 11;
            this.txt_repeat_password.Texts = "";
            this.txt_repeat_password.UnderlinedStyle = false;
            this.txt_repeat_password.Leave += new System.EventHandler(this.txt_repeat_password_Leave);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_account_01);
            this.Controls.Add(this.pl_top);
            this.Name = "setting";
            this.Size = new System.Drawing.Size(1078, 965);
            this.Load += new System.EventHandler(this.setting_Load);
            this.pl_top.ResumeLayout(false);
            this.pl_account_01.ResumeLayout(false);
            this.pl_account.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_setting;
        private System.Windows.Forms.Panel pl_account_01;
        private Script.RJTextBox txt_password;
        private Script.RJTextBox txt_repeat_password;
        private System.Windows.Forms.Label lb_title_01;
        private System.Windows.Forms.Panel pl_account;
        private System.Windows.Forms.Label txt_username;
        private System.Windows.Forms.Button bt_save_01;
        private System.Windows.Forms.Button bt_cancel_01;
    }
}
