
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
            this.txt_nick = new Contas_Familia.Script.RJTextBox();
            this.txt_password = new Contas_Familia.Script.RJTextBox();
            this.SuspendLayout();
            // 
            // bt_enter
            // 
            this.bt_enter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_enter.FlatAppearance.BorderSize = 0;
            this.bt_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enter.ForeColor = System.Drawing.Color.White;
            this.bt_enter.Location = new System.Drawing.Point(48, 263);
            this.bt_enter.Name = "bt_enter";
            this.bt_enter.Size = new System.Drawing.Size(184, 58);
            this.bt_enter.TabIndex = 5;
            this.bt_enter.Text = "ENTER";
            this.bt_enter.UseVisualStyleBackColor = false;
            this.bt_enter.Click += new System.EventHandler(this.bt_enter_Click);
            // 
            // txt_nick
            // 
            this.txt_nick.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nick.BorderColor = System.Drawing.Color.White;
            this.txt_nick.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_nick.BorderRadius = 0;
            this.txt_nick.BorderSize = 2;
            this.txt_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nick.Location = new System.Drawing.Point(29, 101);
            this.txt_nick.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nick.Multiline = false;
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nick.PasswordChar = false;
            this.txt_nick.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nick.PlaceholderText = "NIck";
            this.txt_nick.Size = new System.Drawing.Size(250, 31);
            this.txt_nick.TabIndex = 6;
            this.txt_nick.Texts = "";
            this.txt_nick.UnderlinedStyle = false;
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
            this.txt_password.Location = new System.Drawing.Point(29, 140);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_password.PasswordChar = false;
            this.txt_password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(250, 31);
            this.txt_password.TabIndex = 7;
            this.txt_password.Texts = "";
            this.txt_password.UnderlinedStyle = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(300, 397);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_nick);
            this.Controls.Add(this.bt_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_enter;
        private Script.RJTextBox txt_nick;
        private Script.RJTextBox txt_password;
    }
}