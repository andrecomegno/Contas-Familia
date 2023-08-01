
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pl_top = new System.Windows.Forms.Panel();
            this.bt_family = new System.Windows.Forms.Button();
            this.bt_dashboard = new System.Windows.Forms.Button();
            this.lb_dashboard = new System.Windows.Forms.Label();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.pl_dashboard = new System.Windows.Forms.Panel();
            this.pl_graphic = new System.Windows.Forms.Panel();
            this.chart_paypal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pl_total = new System.Windows.Forms.Panel();
            this.pl_name_member = new System.Windows.Forms.Label();
            this.lb_total_paid = new System.Windows.Forms.Label();
            this.txt_total_month = new System.Windows.Forms.Label();
            this.lb_total_month = new System.Windows.Forms.Label();
            this.txt_total_paid = new System.Windows.Forms.Label();
            this.lb_total_year = new System.Windows.Forms.Label();
            this.txt_total_year = new System.Windows.Forms.Label();
            this.pl_profile = new System.Windows.Forms.Panel();
            this.lb_family_name = new System.Windows.Forms.Label();
            this.bt_logout = new FontAwesome.Sharp.IconButton();
            this.bt_settings = new FontAwesome.Sharp.IconButton();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_title_family = new System.Windows.Forms.Label();
            this.cb_member_family = new Contas_Familia.Script.RJComboBox();
            this.im_profile_image = new Contas_Familia.Script.RJCircularPictureBox();
            this.pl_top.SuspendLayout();
            this.pl_mid.SuspendLayout();
            this.pl_dashboard.SuspendLayout();
            this.pl_graphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_paypal)).BeginInit();
            this.pl_total.SuspendLayout();
            this.pl_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_profile_image)).BeginInit();
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
            this.pl_graphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_graphic.Controls.Add(this.chart_paypal);
            this.pl_graphic.Location = new System.Drawing.Point(34, 189);
            this.pl_graphic.Name = "pl_graphic";
            this.pl_graphic.Size = new System.Drawing.Size(432, 381);
            this.pl_graphic.TabIndex = 2;
            // 
            // chart_paypal
            // 
            this.chart_paypal.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart_paypal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_paypal.Legends.Add(legend2);
            this.chart_paypal.Location = new System.Drawing.Point(19, 17);
            this.chart_paypal.Name = "chart_paypal";
            this.chart_paypal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "payday";
            series2.YValuesPerPoint = 30;
            this.chart_paypal.Series.Add(series2);
            this.chart_paypal.Size = new System.Drawing.Size(398, 348);
            this.chart_paypal.TabIndex = 101;
            this.chart_paypal.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.DimGray;
            title2.Name = "Title1";
            title2.Text = "Arrearage";
            this.chart_paypal.Titles.Add(title2);
            // 
            // pl_total
            // 
            this.pl_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_total.Controls.Add(this.cb_member_family);
            this.pl_total.Controls.Add(this.pl_name_member);
            this.pl_total.Controls.Add(this.lb_total_paid);
            this.pl_total.Controls.Add(this.txt_total_month);
            this.pl_total.Controls.Add(this.lb_total_month);
            this.pl_total.Controls.Add(this.txt_total_paid);
            this.pl_total.Controls.Add(this.lb_total_year);
            this.pl_total.Controls.Add(this.txt_total_year);
            this.pl_total.Location = new System.Drawing.Point(487, 15);
            this.pl_total.Name = "pl_total";
            this.pl_total.Size = new System.Drawing.Size(667, 157);
            this.pl_total.TabIndex = 1;
            // 
            // pl_name_member
            // 
            this.pl_name_member.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_name_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl_name_member.ForeColor = System.Drawing.Color.White;
            this.pl_name_member.Location = new System.Drawing.Point(61, 41);
            this.pl_name_member.Name = "pl_name_member";
            this.pl_name_member.Size = new System.Drawing.Size(200, 25);
            this.pl_name_member.TabIndex = 131;
            this.pl_name_member.Text = "Member Family";
            this.pl_name_member.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_total_paid
            // 
            this.lb_total_paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_total_paid.AutoSize = true;
            this.lb_total_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_paid.ForeColor = System.Drawing.Color.White;
            this.lb_total_paid.Location = new System.Drawing.Point(311, 117);
            this.lb_total_paid.Name = "lb_total_paid";
            this.lb_total_paid.Size = new System.Drawing.Size(110, 25);
            this.lb_total_paid.TabIndex = 128;
            this.lb_total_paid.Text = "Total Paid";
            this.lb_total_paid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_total_month
            // 
            this.txt_total_month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_total_month.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total_month.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_total_month.Location = new System.Drawing.Point(427, 10);
            this.txt_total_month.Name = "txt_total_month";
            this.txt_total_month.Size = new System.Drawing.Size(182, 36);
            this.txt_total_month.TabIndex = 125;
            this.txt_total_month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_total_month
            // 
            this.lb_total_month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_total_month.AutoSize = true;
            this.lb_total_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_month.ForeColor = System.Drawing.Color.White;
            this.lb_total_month.Location = new System.Drawing.Point(294, 21);
            this.lb_total_month.Name = "lb_total_month";
            this.lb_total_month.Size = new System.Drawing.Size(127, 25);
            this.lb_total_month.TabIndex = 124;
            this.lb_total_month.Text = "Total Month";
            this.lb_total_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_total_paid
            // 
            this.txt_total_paid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_total_paid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total_paid.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_paid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_total_paid.Location = new System.Drawing.Point(427, 106);
            this.txt_total_paid.Name = "txt_total_paid";
            this.txt_total_paid.Size = new System.Drawing.Size(182, 36);
            this.txt_total_paid.TabIndex = 129;
            this.txt_total_paid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_total_year
            // 
            this.lb_total_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_total_year.AutoSize = true;
            this.lb_total_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_year.ForeColor = System.Drawing.Color.White;
            this.lb_total_year.Location = new System.Drawing.Point(309, 69);
            this.lb_total_year.Name = "lb_total_year";
            this.lb_total_year.Size = new System.Drawing.Size(112, 25);
            this.lb_total_year.TabIndex = 126;
            this.lb_total_year.Text = "Total Year";
            this.lb_total_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_total_year
            // 
            this.txt_total_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_total_year.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_total_year.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_total_year.Location = new System.Drawing.Point(427, 58);
            this.txt_total_year.Name = "txt_total_year";
            this.txt_total_year.Size = new System.Drawing.Size(182, 36);
            this.txt_total_year.TabIndex = 127;
            this.txt_total_year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cb_member_family
            // 
            this.cb_member_family.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_member_family.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_member_family.BorderColor = System.Drawing.Color.Transparent;
            this.cb_member_family.BorderSize = 0;
            this.cb_member_family.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_member_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_member_family.ForeColor = System.Drawing.Color.Black;
            this.cb_member_family.IconColor = System.Drawing.Color.Black;
            this.cb_member_family.Items.AddRange(new object[] {
            "All"});
            this.cb_member_family.ListBackColor = System.Drawing.Color.White;
            this.cb_member_family.ListTextColor = System.Drawing.Color.DimGray;
            this.cb_member_family.Location = new System.Drawing.Point(61, 69);
            this.cb_member_family.MinimumSize = new System.Drawing.Size(200, 30);
            this.cb_member_family.Name = "cb_member_family";
            this.cb_member_family.Size = new System.Drawing.Size(200, 30);
            this.cb_member_family.TabIndex = 132;
            this.cb_member_family.Texts = "";
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
            ((System.ComponentModel.ISupportInitialize)(this.chart_paypal)).EndInit();
            this.pl_total.ResumeLayout(false);
            this.pl_total.PerformLayout();
            this.pl_profile.ResumeLayout(false);
            this.pl_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im_profile_image)).EndInit();
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
        private System.Windows.Forms.Label lb_total_month;
        private System.Windows.Forms.Label lb_userName;
        private FontAwesome.Sharp.IconButton bt_settings;
        private FontAwesome.Sharp.IconButton bt_logout;
        private Script.RJCircularPictureBox im_profile_image;
        private System.Windows.Forms.Label txt_total_month;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_paypal;
        private System.Windows.Forms.Label pl_name_member;
        private System.Windows.Forms.Label lb_total_paid;
        private System.Windows.Forms.Label txt_total_paid;
        private System.Windows.Forms.Label lb_total_year;
        private System.Windows.Forms.Label txt_total_year;
        private Script.RJComboBox cb_member_family;
        private System.Windows.Forms.Label lb_family_name;
        private System.Windows.Forms.Label lb_title_family;
    }
}
