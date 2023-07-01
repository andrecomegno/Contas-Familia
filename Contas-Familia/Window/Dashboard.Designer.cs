
namespace Contas_Familia.Window
{
    partial class Dashboard
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
            this.pl_top = new System.Windows.Forms.Panel();
            this.pl_menu = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_minimizar = new System.Windows.Forms.Button();
            this.bt_maximizar = new System.Windows.Forms.Button();
            this.pl_left = new System.Windows.Forms.Panel();
            this.pl_right = new System.Windows.Forms.Panel();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.bt_test = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_creator = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Label();
            this.pl_top.SuspendLayout();
            this.pl_menu.SuspendLayout();
            this.pl_mid.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.Controls.Add(this.pl_menu);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1222, 66);
            this.pl_top.TabIndex = 0;
            // 
            // pl_menu
            // 
            this.pl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_menu.Controls.Add(this.bt_fechar);
            this.pl_menu.Controls.Add(this.bt_minimizar);
            this.pl_menu.Controls.Add(this.bt_maximizar);
            this.pl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_menu.Location = new System.Drawing.Point(0, 0);
            this.pl_menu.Name = "pl_menu";
            this.pl_menu.Size = new System.Drawing.Size(1222, 38);
            this.pl_menu.TabIndex = 73;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_fechar.BackColor = System.Drawing.Color.Gray;
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.FlatAppearance.BorderSize = 0;
            this.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechar.ForeColor = System.Drawing.Color.White;
            this.bt_fechar.Location = new System.Drawing.Point(1188, 5);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(27, 26);
            this.bt_fechar.TabIndex = 70;
            this.bt_fechar.Text = "X";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_minimizar
            // 
            this.bt_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimizar.BackColor = System.Drawing.Color.Gray;
            this.bt_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_minimizar.FlatAppearance.BorderSize = 0;
            this.bt_minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimizar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minimizar.ForeColor = System.Drawing.Color.White;
            this.bt_minimizar.Location = new System.Drawing.Point(1122, 5);
            this.bt_minimizar.Name = "bt_minimizar";
            this.bt_minimizar.Size = new System.Drawing.Size(27, 26);
            this.bt_minimizar.TabIndex = 71;
            this.bt_minimizar.Text = "🗕";
            this.bt_minimizar.UseVisualStyleBackColor = false;
            // 
            // bt_maximizar
            // 
            this.bt_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximizar.BackColor = System.Drawing.Color.Gray;
            this.bt_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_maximizar.FlatAppearance.BorderSize = 0;
            this.bt_maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximizar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_maximizar.ForeColor = System.Drawing.Color.White;
            this.bt_maximizar.Location = new System.Drawing.Point(1155, 5);
            this.bt_maximizar.Name = "bt_maximizar";
            this.bt_maximizar.Size = new System.Drawing.Size(27, 26);
            this.bt_maximizar.TabIndex = 72;
            this.bt_maximizar.Text = "❐";
            this.bt_maximizar.UseVisualStyleBackColor = false;
            // 
            // pl_left
            // 
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 66);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(72, 935);
            this.pl_left.TabIndex = 1;
            // 
            // pl_right
            // 
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_right.Location = new System.Drawing.Point(1150, 66);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(72, 935);
            this.pl_right.TabIndex = 2;
            // 
            // pl_mid
            // 
            this.pl_mid.Controls.Add(this.bt_test);
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_mid.Location = new System.Drawing.Point(0, 66);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1222, 965);
            this.pl_mid.TabIndex = 3;
            // 
            // bt_test
            // 
            this.bt_test.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_test.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_test.FlatAppearance.BorderSize = 0;
            this.bt_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_test.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_test.ForeColor = System.Drawing.Color.White;
            this.bt_test.Location = new System.Drawing.Point(473, 70);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(122, 36);
            this.bt_test.TabIndex = 68;
            this.bt_test.Text = "TEST";
            this.bt_test.UseVisualStyleBackColor = false;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.build);
            this.panel2.Controls.Add(this.txt_creator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1001);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 30);
            this.panel2.TabIndex = 69;
            // 
            // txt_creator
            // 
            this.txt_creator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_creator.AutoSize = true;
            this.txt_creator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_creator.Location = new System.Drawing.Point(1060, 10);
            this.txt_creator.Name = "txt_creator";
            this.txt_creator.Size = new System.Drawing.Size(155, 13);
            this.txt_creator.TabIndex = 0;
            this.txt_creator.Text = "Developed by: André Comegno";
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.build.Location = new System.Drawing.Point(12, 8);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(31, 13);
            this.build.TabIndex = 1;
            this.build.Text = "v 1.0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1222, 1031);
            this.Controls.Add(this.pl_left);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_top);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pl_top.ResumeLayout(false);
            this.pl_menu.ResumeLayout(false);
            this.pl_mid.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.Panel pl_right;
        private System.Windows.Forms.Panel pl_mid;
        private System.Windows.Forms.Button bt_minimizar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_maximizar;
        private System.Windows.Forms.Panel pl_menu;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_creator;
        private System.Windows.Forms.Label build;
    }
}