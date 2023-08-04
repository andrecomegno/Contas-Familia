
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_family = new System.Windows.Forms.Button();
            this.bt_dashboard = new System.Windows.Forms.Button();
            this.lb_dashboard = new System.Windows.Forms.Label();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.pl_dashboard = new System.Windows.Forms.Panel();
            this.pl_graphic = new System.Windows.Forms.Panel();
            this.cb_member_family = new Contas_Familia.Script.RJComboBox();
            this.cb_name_member = new Contas_Familia.Script.RJComboBox();
            this.pl_total = new System.Windows.Forms.Panel();
            this.pl_profile = new System.Windows.Forms.Panel();
            this.lb_title_family = new System.Windows.Forms.Label();
            this.lb_family_name = new System.Windows.Forms.Label();
            this.im_profile_image = new Contas_Familia.Script.RJCircularPictureBox();
            this.bt_logout = new FontAwesome.Sharp.IconButton();
            this.bt_settings = new FontAwesome.Sharp.IconButton();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_alert_no_data = new System.Windows.Forms.Label();
            this.chart_paypal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pl_top.SuspendLayout();
            this.pl_mid.SuspendLayout();
            this.pl_dashboard.SuspendLayout();
            this.pl_graphic.SuspendLayout();
            this.pl_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_profile_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_paypal)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_top.Controls.Add(this.bt_family);
            this.pl_top.Controls.Add(this.bt_dashboard);
            this.pl_top.Controls.Add(this.lb_dashboard);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1222, 67);
            this.pl_top.TabIndex = 146;
            // 
            // bt_family
            // 
            this.bt_family.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(74)))), ((int)(((byte)(111)))));
            this.bt_family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_family.FlatAppearance.BorderSize = 0;
            this.bt_family.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_family.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_family.ForeColor = System.Drawing.Color.White;
            this.bt_family.Location = new System.Drawing.Point(211, 39);
            this.bt_family.Name = "bt_family";
            this.bt_family.Size = new System.Drawing.Size(77, 25);
            this.bt_family.TabIndex = 120;
            this.bt_family.Text = "Family";
            this.bt_family.UseVisualStyleBackColor = false;
            this.bt_family.Click += new System.EventHandler(this.bt_family_Click);
            // 
            // bt_dashboard
            // 
            this.bt_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(134)))), ((int)(((byte)(200)))));
            this.bt_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_dashboard.FlatAppearance.BorderSize = 0;
            this.bt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dashboard.ForeColor = System.Drawing.Color.White;
            this.bt_dashboard.Location = new System.Drawing.Point(92, 39);
            this.bt_dashboard.Name = "bt_dashboard";
            this.bt_dashboard.Size = new System.Drawing.Size(108, 25);
            this.bt_dashboard.TabIndex = 119;
            this.bt_dashboard.Text = "Dashboard";
            this.bt_dashboard.UseVisualStyleBackColor = false;
            this.bt_dashboard.Click += new System.EventHandler(this.bt_dashboard_Click);
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
            // pl_mid
            // 
            this.pl_mid.Controls.Add(this.pl_dashboard);
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_mid.Location = new System.Drawing.Point(0, 67);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1222, 931);
            this.pl_mid.TabIndex = 150;
            // 
            // pl_dashboard
            // 
            this.pl_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_dashboard.Controls.Add(this.pl_graphic);
            this.pl_dashboard.Controls.Add(this.pl_total);
            this.pl_dashboard.Controls.Add(this.pl_profile);
            this.pl_dashboard.Location = new System.Drawing.Point(18, 6);
            this.pl_dashboard.Name = "pl_dashboard";
            this.pl_dashboard.Size = new System.Drawing.Size(1188, 718);
            this.pl_dashboard.TabIndex = 0;
            // 
            // pl_graphic
            // 
            this.pl_graphic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_graphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_graphic.Controls.Add(this.lb_alert_no_data);
            this.pl_graphic.Controls.Add(this.cb_member_family);
            this.pl_graphic.Controls.Add(this.cb_name_member);
            this.pl_graphic.Controls.Add(this.chart_paypal);
            this.pl_graphic.Location = new System.Drawing.Point(34, 189);
            this.pl_graphic.Name = "pl_graphic";
            this.pl_graphic.Size = new System.Drawing.Size(1120, 426);
            this.pl_graphic.TabIndex = 2;
            // 
            // cb_member_family
            // 
            this.cb_member_family.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_member_family.BorderColor = System.Drawing.Color.Transparent;
            this.cb_member_family.BorderSize = 0;
            this.cb_member_family.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_member_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_member_family.ForeColor = System.Drawing.Color.Black;
            this.cb_member_family.IconColor = System.Drawing.Color.Black;
            this.cb_member_family.Items.AddRange(new object[] {
            "Select Name",
            "All"});
            this.cb_member_family.ListBackColor = System.Drawing.Color.White;
            this.cb_member_family.ListTextColor = System.Drawing.Color.DimGray;
            this.cb_member_family.Location = new System.Drawing.Point(128, 9);
            this.cb_member_family.MinimumSize = new System.Drawing.Size(200, 30);
            this.cb_member_family.Name = "cb_member_family";
            this.cb_member_family.Size = new System.Drawing.Size(200, 30);
            this.cb_member_family.TabIndex = 132;
            this.cb_member_family.Texts = "";
            // 
            // cb_name_member
            // 
            this.cb_name_member.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_name_member.BorderColor = System.Drawing.Color.Transparent;
            this.cb_name_member.BorderSize = 0;
            this.cb_name_member.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_name_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_name_member.ForeColor = System.Drawing.Color.Black;
            this.cb_name_member.IconColor = System.Drawing.Color.Black;
            this.cb_name_member.Items.AddRange(new object[] {
            "Year"});
            this.cb_name_member.ListBackColor = System.Drawing.Color.White;
            this.cb_name_member.ListTextColor = System.Drawing.Color.DimGray;
            this.cb_name_member.Location = new System.Drawing.Point(19, 9);
            this.cb_name_member.MinimumSize = new System.Drawing.Size(80, 30);
            this.cb_name_member.Name = "cb_name_member";
            this.cb_name_member.Size = new System.Drawing.Size(94, 30);
            this.cb_name_member.TabIndex = 133;
            this.cb_name_member.Texts = "";
            // 
            // pl_total
            // 
            this.pl_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_total.Location = new System.Drawing.Point(487, 15);
            this.pl_total.Name = "pl_total";
            this.pl_total.Size = new System.Drawing.Size(667, 157);
            this.pl_total.TabIndex = 1;
            // 
            // pl_profile
            // 
            this.pl_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_profile.Controls.Add(this.lb_title_family);
            this.pl_profile.Controls.Add(this.lb_family_name);
            this.pl_profile.Controls.Add(this.im_profile_image);
            this.pl_profile.Controls.Add(this.bt_logout);
            this.pl_profile.Controls.Add(this.bt_settings);
            this.pl_profile.Controls.Add(this.lb_userName);
            this.pl_profile.Location = new System.Drawing.Point(34, 15);
            this.pl_profile.Name = "pl_profile";
            this.pl_profile.Size = new System.Drawing.Size(432, 157);
            this.pl_profile.TabIndex = 0;
            // 
            // lb_title_family
            // 
            this.lb_title_family.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_title_family.AutoSize = true;
            this.lb_title_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_family.ForeColor = System.Drawing.Color.White;
            this.lb_title_family.Location = new System.Drawing.Point(14, 12);
            this.lb_title_family.Name = "lb_title_family";
            this.lb_title_family.Size = new System.Drawing.Size(107, 25);
            this.lb_title_family.TabIndex = 125;
            this.lb_title_family.Text = "Hi, Family";
            this.lb_title_family.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_family_name
            // 
            this.lb_family_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_family_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_family_name.ForeColor = System.Drawing.Color.White;
            this.lb_family_name.Location = new System.Drawing.Point(123, 12);
            this.lb_family_name.Name = "lb_family_name";
            this.lb_family_name.Size = new System.Drawing.Size(237, 26);
            this.lb_family_name.TabIndex = 124;
            this.lb_family_name.Text = "Unknown";
            this.lb_family_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // im_profile_image
            // 
            this.im_profile_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.im_profile_image.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.im_profile_image.BorderColor = System.Drawing.Color.RoyalBlue;
            this.im_profile_image.BorderColor2 = System.Drawing.Color.HotPink;
            this.im_profile_image.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.im_profile_image.BorderSize = 2;
            this.im_profile_image.GradientAngle = 50F;
            this.im_profile_image.Image = global::Contas_Familia.Properties.Resources.user;
            this.im_profile_image.Location = new System.Drawing.Point(24, 45);
            this.im_profile_image.Name = "im_profile_image";
            this.im_profile_image.Size = new System.Drawing.Size(100, 100);
            this.im_profile_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_profile_image.TabIndex = 4;
            this.im_profile_image.TabStop = false;
            // 
            // bt_logout
            // 
            this.bt_logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_logout.BackColor = System.Drawing.Color.Transparent;
            this.bt_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_logout.FlatAppearance.BorderSize = 0;
            this.bt_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_logout.ForeColor = System.Drawing.Color.White;
            this.bt_logout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.bt_logout.IconColor = System.Drawing.Color.White;
            this.bt_logout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_logout.IconSize = 35;
            this.bt_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.Location = new System.Drawing.Point(379, 113);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(41, 36);
            this.bt_logout.TabIndex = 63;
            this.bt_logout.Tag = "";
            this.bt_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_settings
            // 
            this.bt_settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.bt_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_settings.FlatAppearance.BorderSize = 0;
            this.bt_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_settings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_settings.ForeColor = System.Drawing.Color.White;
            this.bt_settings.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.bt_settings.IconColor = System.Drawing.Color.White;
            this.bt_settings.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_settings.IconSize = 35;
            this.bt_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_settings.Location = new System.Drawing.Point(377, 7);
            this.bt_settings.Name = "bt_settings";
            this.bt_settings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bt_settings.Size = new System.Drawing.Size(47, 41);
            this.bt_settings.TabIndex = 61;
            this.bt_settings.Tag = "";
            this.bt_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_settings.UseVisualStyleBackColor = false;
            this.bt_settings.Click += new System.EventHandler(this.bt_settings_Click);
            // 
            // lb_userName
            // 
            this.lb_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.ForeColor = System.Drawing.Color.White;
            this.lb_userName.Location = new System.Drawing.Point(138, 72);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(273, 31);
            this.lb_userName.TabIndex = 123;
            this.lb_userName.Text = "Unknown";
            this.lb_userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_alert_no_data
            // 
            this.lb_alert_no_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_alert_no_data.BackColor = System.Drawing.Color.White;
            this.lb_alert_no_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alert_no_data.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_alert_no_data.Location = new System.Drawing.Point(22, 188);
            this.lb_alert_no_data.Name = "lb_alert_no_data";
            this.lb_alert_no_data.Size = new System.Drawing.Size(1081, 25);
            this.lb_alert_no_data.TabIndex = 110;
            this.lb_alert_no_data.Text = "No Data";
            this.lb_alert_no_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart_paypal
            // 
            this.chart_paypal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.Name = "ChartArea1";
            this.chart_paypal.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend5.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend5.Name = "Legend1";
            this.chart_paypal.Legends.Add(legend5);
            this.chart_paypal.Location = new System.Drawing.Point(19, 45);
            this.chart_paypal.Name = "chart_paypal";
            this.chart_paypal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "payday";
            series5.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.YValuesPerPoint = 30;
            this.chart_paypal.Series.Add(series5);
            this.chart_paypal.Size = new System.Drawing.Size(1084, 360);
            this.chart_paypal.TabIndex = 109;
            this.chart_paypal.Text = "chart";
            title5.BackColor = System.Drawing.Color.Transparent;
            title5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title5.ForeColor = System.Drawing.Color.DimGray;
            title5.Name = "Title1";
            title5.Text = "Members Family - Outgoing";
            this.chart_paypal.Titles.Add(title5);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_top);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1222, 998);
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.pl_top.ResumeLayout(false);
            this.pl_mid.ResumeLayout(false);
            this.pl_dashboard.ResumeLayout(false);
            this.pl_graphic.ResumeLayout(false);
            this.pl_profile.ResumeLayout(false);
            this.pl_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_profile_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_paypal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_dashboard;
        private System.Windows.Forms.Panel pl_mid;
        private System.Windows.Forms.Button bt_family;
        private System.Windows.Forms.Button bt_dashboard;
        private System.Windows.Forms.Panel pl_dashboard;
        private System.Windows.Forms.Panel pl_profile;
        private System.Windows.Forms.Panel pl_total;
        private System.Windows.Forms.Panel pl_graphic;
        private System.Windows.Forms.Label lb_userName;
        private FontAwesome.Sharp.IconButton bt_settings;
        private FontAwesome.Sharp.IconButton bt_logout;
        private Script.RJCircularPictureBox im_profile_image;
        private Script.RJComboBox cb_member_family;
        private System.Windows.Forms.Label lb_family_name;
        private System.Windows.Forms.Label lb_title_family;
        private Script.RJComboBox cb_name_member;
        private System.Windows.Forms.Label lb_alert_no_data;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_paypal;
    }
}
