
namespace Contas_Familia.Window
{
    partial class Main
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
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.bt_maximize = new System.Windows.Forms.Button();
            this.pl_left = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_menu_collapse = new FontAwesome.Sharp.IconButton();
            this.bt_settings_2 = new FontAwesome.Sharp.IconButton();
            this.bt_dashboard = new FontAwesome.Sharp.IconButton();
            this.bt_settings = new FontAwesome.Sharp.IconButton();
            this.bt_home = new FontAwesome.Sharp.IconButton();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.pl_footer = new System.Windows.Forms.Panel();
            this.build = new System.Windows.Forms.Label();
            this.txt_creator = new System.Windows.Forms.Label();
            this.pl_top.SuspendLayout();
            this.pl_left.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.Black;
            this.pl_top.Controls.Add(this.bt_exit);
            this.pl_top.Controls.Add(this.bt_minimize);
            this.pl_top.Controls.Add(this.bt_maximize);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1222, 33);
            this.pl_top.TabIndex = 0;
            this.pl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_top_MouseDown);
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
            this.bt_exit.Location = new System.Drawing.Point(1190, 3);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(27, 26);
            this.bt_exit.TabIndex = 70;
            this.bt_exit.Text = "X";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_fechar_Click);
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
            this.bt_minimize.Location = new System.Drawing.Point(1124, 3);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(27, 26);
            this.bt_minimize.TabIndex = 71;
            this.bt_minimize.Text = "🗕";
            this.bt_minimize.UseVisualStyleBackColor = false;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_maximize
            // 
            this.bt_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximize.BackColor = System.Drawing.Color.Gray;
            this.bt_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_maximize.FlatAppearance.BorderSize = 0;
            this.bt_maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximize.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_maximize.ForeColor = System.Drawing.Color.White;
            this.bt_maximize.Location = new System.Drawing.Point(1157, 3);
            this.bt_maximize.Name = "bt_maximize";
            this.bt_maximize.Size = new System.Drawing.Size(27, 26);
            this.bt_maximize.TabIndex = 72;
            this.bt_maximize.Text = "❐";
            this.bt_maximize.UseVisualStyleBackColor = false;
            this.bt_maximize.Click += new System.EventHandler(this.bt_maximize_Click);
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_left.Controls.Add(this.panel1);
            this.pl_left.Controls.Add(this.bt_dashboard);
            this.pl_left.Controls.Add(this.bt_settings);
            this.pl_left.Controls.Add(this.bt_home);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 33);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(210, 974);
            this.pl_left.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_menu_collapse);
            this.panel1.Controls.Add(this.bt_settings_2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 928);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 46);
            this.panel1.TabIndex = 0;
            // 
            // bt_menu_collapse
            // 
            this.bt_menu_collapse.AccessibleName = "";
            this.bt_menu_collapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_menu_collapse.BackColor = System.Drawing.Color.Transparent;
            this.bt_menu_collapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_menu_collapse.FlatAppearance.BorderSize = 0;
            this.bt_menu_collapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_menu_collapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_menu_collapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_menu_collapse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menu_collapse.ForeColor = System.Drawing.Color.White;
            this.bt_menu_collapse.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.bt_menu_collapse.IconColor = System.Drawing.Color.White;
            this.bt_menu_collapse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_menu_collapse.IconSize = 35;
            this.bt_menu_collapse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_menu_collapse.Location = new System.Drawing.Point(7, 5);
            this.bt_menu_collapse.Name = "bt_menu_collapse";
            this.bt_menu_collapse.Size = new System.Drawing.Size(40, 36);
            this.bt_menu_collapse.TabIndex = 61;
            this.bt_menu_collapse.Tag = "";
            this.bt_menu_collapse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_menu_collapse.UseVisualStyleBackColor = false;
            this.bt_menu_collapse.Click += new System.EventHandler(this.bt_menu_collapse_Click);
            // 
            // bt_settings_2
            // 
            this.bt_settings_2.AccessibleName = "";
            this.bt_settings_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_settings_2.BackColor = System.Drawing.Color.Transparent;
            this.bt_settings_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_settings_2.FlatAppearance.BorderSize = 0;
            this.bt_settings_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_settings_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_settings_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_settings_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_settings_2.ForeColor = System.Drawing.Color.White;
            this.bt_settings_2.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.bt_settings_2.IconColor = System.Drawing.Color.White;
            this.bt_settings_2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_settings_2.IconSize = 35;
            this.bt_settings_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_settings_2.Location = new System.Drawing.Point(161, 6);
            this.bt_settings_2.Name = "bt_settings_2";
            this.bt_settings_2.Size = new System.Drawing.Size(40, 36);
            this.bt_settings_2.TabIndex = 58;
            this.bt_settings_2.Tag = "";
            this.bt_settings_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_settings_2.UseVisualStyleBackColor = false;
            this.bt_settings_2.Click += new System.EventHandler(this.bt_settings_2_Click);
            // 
            // bt_dashboard
            // 
            this.bt_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
            this.bt_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_dashboard.FlatAppearance.BorderSize = 0;
            this.bt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dashboard.ForeColor = System.Drawing.Color.White;
            this.bt_dashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.bt_dashboard.IconColor = System.Drawing.Color.White;
            this.bt_dashboard.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_dashboard.IconSize = 35;
            this.bt_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dashboard.Location = new System.Drawing.Point(0, 100);
            this.bt_dashboard.Name = "bt_dashboard";
            this.bt_dashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_dashboard.Size = new System.Drawing.Size(210, 46);
            this.bt_dashboard.TabIndex = 61;
            this.bt_dashboard.Tag = "Dashboard";
            this.bt_dashboard.Text = "Dashboard";
            this.bt_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_dashboard.UseVisualStyleBackColor = false;
            this.bt_dashboard.Click += new System.EventHandler(this.bt_dashboard_Click);
            // 
            // bt_settings
            // 
            this.bt_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(74)))), ((int)(((byte)(111)))));
            this.bt_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_settings.FlatAppearance.BorderSize = 0;
            this.bt_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_settings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_settings.ForeColor = System.Drawing.Color.White;
            this.bt_settings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.bt_settings.IconColor = System.Drawing.Color.White;
            this.bt_settings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_settings.IconSize = 35;
            this.bt_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_settings.Location = new System.Drawing.Point(0, 152);
            this.bt_settings.Name = "bt_settings";
            this.bt_settings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_settings.Size = new System.Drawing.Size(210, 46);
            this.bt_settings.TabIndex = 60;
            this.bt_settings.Tag = "Settings";
            this.bt_settings.Text = "Settings";
            this.bt_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_settings.UseVisualStyleBackColor = false;
            this.bt_settings.Click += new System.EventHandler(this.bt_settings_Click);
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
            this.bt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.ForeColor = System.Drawing.Color.White;
            this.bt_home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.bt_home.IconColor = System.Drawing.Color.White;
            this.bt_home.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_home.IconSize = 35;
            this.bt_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_home.Location = new System.Drawing.Point(0, 204);
            this.bt_home.Name = "bt_home";
            this.bt_home.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_home.Size = new System.Drawing.Size(210, 46);
            this.bt_home.TabIndex = 59;
            this.bt_home.Tag = "Home";
            this.bt_home.Text = "Home";
            this.bt_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // pl_mid
            // 
            this.pl_mid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_mid.Location = new System.Drawing.Point(210, 33);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1012, 974);
            this.pl_mid.TabIndex = 3;
            // 
            // pl_footer
            // 
            this.pl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_footer.Controls.Add(this.build);
            this.pl_footer.Controls.Add(this.txt_creator);
            this.pl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_footer.Location = new System.Drawing.Point(0, 1007);
            this.pl_footer.Name = "pl_footer";
            this.pl_footer.Size = new System.Drawing.Size(1222, 24);
            this.pl_footer.TabIndex = 69;
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.build.Location = new System.Drawing.Point(12, 6);
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
            this.txt_creator.Location = new System.Drawing.Point(1060, 7);
            this.txt_creator.Name = "txt_creator";
            this.txt_creator.Size = new System.Drawing.Size(155, 13);
            this.txt_creator.TabIndex = 0;
            this.txt_creator.Text = "Developed by: André Comegno";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1222, 1031);
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_left);
            this.Controls.Add(this.pl_footer);
            this.Controls.Add(this.pl_top);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pl_top.ResumeLayout(false);
            this.pl_left.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pl_footer.ResumeLayout(false);
            this.pl_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.Panel pl_mid;
        private System.Windows.Forms.Button bt_minimize;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_maximize;
        private System.Windows.Forms.Panel pl_footer;
        private System.Windows.Forms.Label txt_creator;
        private System.Windows.Forms.Label build;
        private FontAwesome.Sharp.IconButton bt_home;
        private FontAwesome.Sharp.IconButton bt_settings_2;
        private FontAwesome.Sharp.IconButton bt_dashboard;
        private FontAwesome.Sharp.IconButton bt_settings;
        private FontAwesome.Sharp.IconButton bt_menu_collapse;
        private System.Windows.Forms.Panel panel1;
    }
}