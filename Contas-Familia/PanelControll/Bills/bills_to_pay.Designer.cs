
namespace Contas_Familia.PanelControll.Bills
{
    partial class bills_to_pay
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
            this.pl_family_01 = new System.Windows.Forms.Panel();
            this.bt_edit_01 = new FontAwesome.Sharp.IconButton();
            this.bt_cancel_01 = new System.Windows.Forms.Button();
            this.bt_delet_01 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pl_left = new System.Windows.Forms.Panel();
            this.pl_right = new System.Windows.Forms.Panel();
            this.pl_top = new System.Windows.Forms.Panel();
            this.pl_content_01 = new System.Windows.Forms.Panel();
            this.pl_content_02 = new System.Windows.Forms.Panel();
            this.pl_family_02 = new System.Windows.Forms.Panel();
            this.bt_edit_02 = new FontAwesome.Sharp.IconButton();
            this.bt_cancel_02 = new System.Windows.Forms.Button();
            this.bt_delet_02 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_name_02 = new Contas_Familia.Script.RJTextBox();
            this.txt_name_01 = new Contas_Familia.Script.RJTextBox();
            this.pl_family_01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pl_content_01.SuspendLayout();
            this.pl_content_02.SuspendLayout();
            this.pl_family_02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_family_01
            // 
            this.pl_family_01.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pl_family_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_family_01.Controls.Add(this.bt_edit_01);
            this.pl_family_01.Controls.Add(this.bt_cancel_01);
            this.pl_family_01.Controls.Add(this.bt_delet_01);
            this.pl_family_01.Controls.Add(this.dataGridView1);
            this.pl_family_01.Controls.Add(this.txt_name_01);
            this.pl_family_01.Location = new System.Drawing.Point(4, 6);
            this.pl_family_01.Name = "pl_family_01";
            this.pl_family_01.Size = new System.Drawing.Size(830, 480);
            this.pl_family_01.TabIndex = 10;
            // 
            // bt_edit_01
            // 
            this.bt_edit_01.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_edit_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_edit_01.FlatAppearance.BorderSize = 0;
            this.bt_edit_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit_01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_01.ForeColor = System.Drawing.Color.White;
            this.bt_edit_01.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.bt_edit_01.IconColor = System.Drawing.Color.White;
            this.bt_edit_01.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_edit_01.IconSize = 35;
            this.bt_edit_01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit_01.Location = new System.Drawing.Point(694, 12);
            this.bt_edit_01.Name = "bt_edit_01";
            this.bt_edit_01.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_edit_01.Size = new System.Drawing.Size(122, 36);
            this.bt_edit_01.TabIndex = 71;
            this.bt_edit_01.Tag = "";
            this.bt_edit_01.Text = "Edit";
            this.bt_edit_01.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_edit_01.UseVisualStyleBackColor = false;
            this.bt_edit_01.Click += new System.EventHandler(this.bt_edit_01_Click);
            // 
            // bt_cancel_01
            // 
            this.bt_cancel_01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel_01.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_cancel_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel_01.FlatAppearance.BorderSize = 0;
            this.bt_cancel_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel_01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel_01.ForeColor = System.Drawing.Color.White;
            this.bt_cancel_01.Location = new System.Drawing.Point(694, 421);
            this.bt_cancel_01.Name = "bt_cancel_01";
            this.bt_cancel_01.Size = new System.Drawing.Size(122, 36);
            this.bt_cancel_01.TabIndex = 69;
            this.bt_cancel_01.Text = "Cancelar";
            this.bt_cancel_01.UseVisualStyleBackColor = false;
            this.bt_cancel_01.Click += new System.EventHandler(this.bt_cancel_01_Click);
            // 
            // bt_delet_01
            // 
            this.bt_delet_01.BackColor = System.Drawing.Color.Crimson;
            this.bt_delet_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delet_01.FlatAppearance.BorderSize = 0;
            this.bt_delet_01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delet_01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delet_01.ForeColor = System.Drawing.Color.White;
            this.bt_delet_01.Location = new System.Drawing.Point(16, 421);
            this.bt_delet_01.Name = "bt_delet_01";
            this.bt_delet_01.Size = new System.Drawing.Size(122, 36);
            this.bt_delet_01.TabIndex = 68;
            this.bt_delet_01.Text = "Delet";
            this.bt_delet_01.UseVisualStyleBackColor = false;
            this.bt_delet_01.Click += new System.EventHandler(this.txt_delet_01_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 350);
            this.dataGridView1.TabIndex = 8;
            // 
            // pl_left
            // 
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 0);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(120, 2078);
            this.pl_left.TabIndex = 100;
            // 
            // pl_right
            // 
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_right.Location = new System.Drawing.Point(958, 0);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(120, 2078);
            this.pl_right.TabIndex = 101;
            // 
            // pl_top
            // 
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(120, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(838, 18);
            this.pl_top.TabIndex = 149;
            // 
            // pl_content_01
            // 
            this.pl_content_01.Controls.Add(this.pl_family_01);
            this.pl_content_01.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_content_01.Location = new System.Drawing.Point(120, 18);
            this.pl_content_01.Name = "pl_content_01";
            this.pl_content_01.Size = new System.Drawing.Size(838, 500);
            this.pl_content_01.TabIndex = 150;
            // 
            // pl_content_02
            // 
            this.pl_content_02.Controls.Add(this.pl_family_02);
            this.pl_content_02.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_content_02.Location = new System.Drawing.Point(120, 518);
            this.pl_content_02.Name = "pl_content_02";
            this.pl_content_02.Size = new System.Drawing.Size(838, 500);
            this.pl_content_02.TabIndex = 154;
            // 
            // pl_family_02
            // 
            this.pl_family_02.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pl_family_02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_family_02.Controls.Add(this.bt_edit_02);
            this.pl_family_02.Controls.Add(this.bt_cancel_02);
            this.pl_family_02.Controls.Add(this.bt_delet_02);
            this.pl_family_02.Controls.Add(this.dataGridView2);
            this.pl_family_02.Controls.Add(this.txt_name_02);
            this.pl_family_02.Location = new System.Drawing.Point(4, 6);
            this.pl_family_02.Name = "pl_family_02";
            this.pl_family_02.Size = new System.Drawing.Size(830, 480);
            this.pl_family_02.TabIndex = 10;
            // 
            // bt_edit_02
            // 
            this.bt_edit_02.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_edit_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_edit_02.FlatAppearance.BorderSize = 0;
            this.bt_edit_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_edit_02.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit_02.ForeColor = System.Drawing.Color.White;
            this.bt_edit_02.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.bt_edit_02.IconColor = System.Drawing.Color.White;
            this.bt_edit_02.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_edit_02.IconSize = 35;
            this.bt_edit_02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_edit_02.Location = new System.Drawing.Point(694, 12);
            this.bt_edit_02.Name = "bt_edit_02";
            this.bt_edit_02.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_edit_02.Size = new System.Drawing.Size(122, 36);
            this.bt_edit_02.TabIndex = 71;
            this.bt_edit_02.Tag = "";
            this.bt_edit_02.Text = "Edit";
            this.bt_edit_02.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_edit_02.UseVisualStyleBackColor = false;
            this.bt_edit_02.Click += new System.EventHandler(this.bt_edit_02_Click);
            // 
            // bt_cancel_02
            // 
            this.bt_cancel_02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel_02.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_cancel_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel_02.FlatAppearance.BorderSize = 0;
            this.bt_cancel_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel_02.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel_02.ForeColor = System.Drawing.Color.White;
            this.bt_cancel_02.Location = new System.Drawing.Point(694, 421);
            this.bt_cancel_02.Name = "bt_cancel_02";
            this.bt_cancel_02.Size = new System.Drawing.Size(122, 36);
            this.bt_cancel_02.TabIndex = 69;
            this.bt_cancel_02.Text = "Cancelar";
            this.bt_cancel_02.UseVisualStyleBackColor = false;
            this.bt_cancel_02.Click += new System.EventHandler(this.bt_cancel_02_Click);
            // 
            // bt_delet_02
            // 
            this.bt_delet_02.BackColor = System.Drawing.Color.Crimson;
            this.bt_delet_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delet_02.FlatAppearance.BorderSize = 0;
            this.bt_delet_02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delet_02.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delet_02.ForeColor = System.Drawing.Color.White;
            this.bt_delet_02.Location = new System.Drawing.Point(16, 421);
            this.bt_delet_02.Name = "bt_delet_02";
            this.bt_delet_02.Size = new System.Drawing.Size(122, 36);
            this.bt_delet_02.TabIndex = 68;
            this.bt_delet_02.Text = "Delet";
            this.bt_delet_02.UseVisualStyleBackColor = false;
            this.bt_delet_02.Click += new System.EventHandler(this.txt_delet_02_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(800, 350);
            this.dataGridView2.TabIndex = 8;
            // 
            // txt_name_02
            // 
            this.txt_name_02.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name_02.BorderColor = System.Drawing.Color.White;
            this.txt_name_02.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_name_02.BorderRadius = 0;
            this.txt_name_02.BorderSize = 2;
            this.txt_name_02.Enabled = false;
            this.txt_name_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name_02.Location = new System.Drawing.Point(16, 12);
            this.txt_name_02.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name_02.Multiline = false;
            this.txt_name_02.Name = "txt_name_02";
            this.txt_name_02.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_name_02.PasswordChar = false;
            this.txt_name_02.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name_02.PlaceholderText = "";
            this.txt_name_02.Size = new System.Drawing.Size(250, 31);
            this.txt_name_02.TabIndex = 7;
            this.txt_name_02.Texts = "";
            this.txt_name_02.UnderlinedStyle = false;
            // 
            // txt_name_01
            // 
            this.txt_name_01.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name_01.BorderColor = System.Drawing.Color.White;
            this.txt_name_01.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_name_01.BorderRadius = 0;
            this.txt_name_01.BorderSize = 2;
            this.txt_name_01.Enabled = false;
            this.txt_name_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name_01.Location = new System.Drawing.Point(16, 12);
            this.txt_name_01.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name_01.Multiline = false;
            this.txt_name_01.Name = "txt_name_01";
            this.txt_name_01.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_name_01.PasswordChar = false;
            this.txt_name_01.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name_01.PlaceholderText = "";
            this.txt_name_01.Size = new System.Drawing.Size(250, 31);
            this.txt_name_01.TabIndex = 7;
            this.txt_name_01.Texts = "";
            this.txt_name_01.UnderlinedStyle = false;
            // 
            // bills_to_pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_content_02);
            this.Controls.Add(this.pl_content_01);
            this.Controls.Add(this.pl_top);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.pl_left);
            this.Name = "bills_to_pay";
            this.Size = new System.Drawing.Size(1078, 2078);
            this.Load += new System.EventHandler(this.bills_to_pay_Load);
            this.pl_family_01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pl_content_01.ResumeLayout(false);
            this.pl_content_02.ResumeLayout(false);
            this.pl_family_02.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_family_01;
        private System.Windows.Forms.Button bt_cancel_01;
        private System.Windows.Forms.Button bt_delet_01;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Script.RJTextBox txt_name_01;
        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.Panel pl_right;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Panel pl_content_01;
        private FontAwesome.Sharp.IconButton bt_edit_01;
        private System.Windows.Forms.Panel pl_content_02;
        private System.Windows.Forms.Panel pl_family_02;
        private FontAwesome.Sharp.IconButton bt_edit_02;
        private System.Windows.Forms.Button bt_cancel_02;
        private System.Windows.Forms.Button bt_delet_02;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Script.RJTextBox txt_name_02;
    }
}
