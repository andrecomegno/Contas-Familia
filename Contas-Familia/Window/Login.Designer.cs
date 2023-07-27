
namespace Contas_Familia
{
    partial class Login
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
            this.bt_enter = new System.Windows.Forms.Button();
            this.pl_menu = new System.Windows.Forms.Panel();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.build = new System.Windows.Forms.Label();
            this.txt_creator = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.txt_password = new Contas_Familia.Script.RJTextBox();
            this.txt_name = new Contas_Familia.Script.RJTextBox();
            this.pl_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_enter
            // 
            this.bt_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(74)))), ((int)(((byte)(111)))));
            this.bt_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_enter.FlatAppearance.BorderSize = 0;
            this.bt_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enter.ForeColor = System.Drawing.Color.White;
            this.bt_enter.Location = new System.Drawing.Point(58, 203);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(184, 58);
            this.bt_enter.TabIndex = 5;
            this.bt_enter.Text = "ENTER";
            this.bt_enter.UseVisualStyleBackColor = false;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // pl_menu
            // 
            this.pl_menu.BackColor = System.Drawing.Color.Black;
            this.pl_menu.Controls.Add(this.bt_exit);
            this.pl_menu.Controls.Add(this.bt_minimize);
            this.pl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_menu.Location = new System.Drawing.Point(0, 0);
            this.pl_menu.Name = "pl_menu";
            this.pl_menu.Size = new System.Drawing.Size(300, 38);
            this.pl_menu.TabIndex = 76;
            this.pl_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
            // 
            // bt_exit
            // 
            this.bt_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_exit.BackColor = System.Drawing.Color.Gray;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.White;
            this.bt_exit.Location = new System.Drawing.Point(266, 5);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(27, 26);
            this.bt_exit.TabIndex = 70;
            this.bt_exit.Text = "X";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_minimize
            // 
            this.bt_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimize.BackColor = System.Drawing.Color.Gray;
            this.bt_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimize.FlatAppearance.BorderSize = 0;
            this.bt_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimize.ForeColor = System.Drawing.Color.White;
            this.bt_minimize.Location = new System.Drawing.Point(233, 5);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(27, 26);
            this.bt_minimize.TabIndex = 71;
            this.bt_minimize.Text = "🗕";
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.build);
            this.panel2.Controls.Add(this.txt_creator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 30);
            this.panel2.TabIndex = 77;
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.build.Location = new System.Drawing.Point(262, 8);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(31, 13);
            this.build.TabIndex = 1;
            this.build.Text = "v 1.1";
            // 
            // txt_creator
            // 
            this.txt_creator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_creator.AutoSize = true;
            this.txt_creator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_creator.Location = new System.Drawing.Point(3, 8);
            this.txt_creator.Name = "txt_creator";
            this.txt_creator.Size = new System.Drawing.Size(155, 13);
            this.txt_creator.TabIndex = 0;
            this.txt_creator.Text = "Developed by: André Comegno";
            // 
            // lb_login
            // 
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Location = new System.Drawing.Point(0, 62);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(300, 50);
            this.lb_login.TabIndex = 78;
            this.lb_login.Text = "LOGIN";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txt_password.Location = new System.Drawing.Point(25, 165);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_password.PasswordChar = true;
            this.txt_password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(250, 31);
            this.txt_password.TabIndex = 7;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = false;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
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
            this.txt_name.Location = new System.Drawing.Point(25, 126);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_name.PasswordChar = false;
            this.txt_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name.PlaceholderText = "Name";
            this.txt_name.Size = new System.Drawing.Size(250, 31);
            this.txt_name.TabIndex = 6;
            this.txt_name.Texts = "";
            this.txt_name.UnderlinedStyle = false;
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(300, 397);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pl_menu);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.bt_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pl_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_enter;
        private Script.RJTextBox txt_name;
        private Script.RJTextBox txt_password;
        private System.Windows.Forms.Panel pl_menu;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label build;
        private System.Windows.Forms.Label txt_creator;
        private System.Windows.Forms.Label lb_login;
    }
}