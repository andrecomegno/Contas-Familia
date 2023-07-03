
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
            this.pl_reg = new System.Windows.Forms.Panel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.txt_delet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_name = new Contas_Familia.Script.RJTextBox();
            this.pl_top = new System.Windows.Forms.Panel();
            this.lb_bill_to_pay = new System.Windows.Forms.Label();
            this.pl_mid = new System.Windows.Forms.Panel();
            this.pl_reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pl_top.SuspendLayout();
            this.pl_mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_reg
            // 
            this.pl_reg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pl_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_reg.Controls.Add(this.bt_save);
            this.pl_reg.Controls.Add(this.bt_cancel);
            this.pl_reg.Controls.Add(this.txt_delet);
            this.pl_reg.Controls.Add(this.dataGridView1);
            this.pl_reg.Controls.Add(this.txt_name);
            this.pl_reg.Location = new System.Drawing.Point(146, 6);
            this.pl_reg.Name = "pl_reg";
            this.pl_reg.Size = new System.Drawing.Size(830, 480);
            this.pl_reg.TabIndex = 10;
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save.FlatAppearance.BorderSize = 0;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(694, 7);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(122, 36);
            this.bt_save.TabIndex = 70;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.Location = new System.Drawing.Point(694, 421);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(122, 36);
            this.bt_cancel.TabIndex = 69;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // txt_delet
            // 
            this.txt_delet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_delet.BackColor = System.Drawing.Color.Crimson;
            this.txt_delet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_delet.FlatAppearance.BorderSize = 0;
            this.txt_delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_delet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_delet.ForeColor = System.Drawing.Color.White;
            this.txt_delet.Location = new System.Drawing.Point(16, 421);
            this.txt_delet.Name = "txt_delet";
            this.txt_delet.Size = new System.Drawing.Size(122, 36);
            this.txt_delet.TabIndex = 68;
            this.txt_delet.Text = "Delet";
            this.txt_delet.UseVisualStyleBackColor = false;
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
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.BorderColor = System.Drawing.Color.White;
            this.txt_name.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_name.BorderRadius = 0;
            this.txt_name.BorderSize = 2;
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.Location = new System.Drawing.Point(16, 12);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_name.PasswordChar = false;
            this.txt_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name.PlaceholderText = "";
            this.txt_name.Size = new System.Drawing.Size(250, 31);
            this.txt_name.TabIndex = 7;
            this.txt_name.Texts = "";
            this.txt_name.UnderlinedStyle = false;
            // 
            // pl_top
            // 
            this.pl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.pl_top.Controls.Add(this.lb_bill_to_pay);
            this.pl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_top.Location = new System.Drawing.Point(0, 0);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1078, 51);
            this.pl_top.TabIndex = 99;
            // 
            // lb_bill_to_pay
            // 
            this.lb_bill_to_pay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_bill_to_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bill_to_pay.ForeColor = System.Drawing.Color.White;
            this.lb_bill_to_pay.Location = new System.Drawing.Point(3, 12);
            this.lb_bill_to_pay.Name = "lb_bill_to_pay";
            this.lb_bill_to_pay.Size = new System.Drawing.Size(1072, 31);
            this.lb_bill_to_pay.TabIndex = 97;
            this.lb_bill_to_pay.Text = "BILLS TO PAY";
            this.lb_bill_to_pay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_mid
            // 
            this.pl_mid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pl_mid.Controls.Add(this.pl_reg);
            this.pl_mid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_mid.Location = new System.Drawing.Point(0, 51);
            this.pl_mid.Name = "pl_mid";
            this.pl_mid.Size = new System.Drawing.Size(1078, 541);
            this.pl_mid.TabIndex = 145;
            // 
            // bills_to_pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_mid);
            this.Controls.Add(this.pl_top);
            this.Name = "bills_to_pay";
            this.Size = new System.Drawing.Size(1078, 965);
            this.pl_reg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pl_top.ResumeLayout(false);
            this.pl_mid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_reg;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button txt_delet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Script.RJTextBox txt_name;
        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label lb_bill_to_pay;
        private System.Windows.Forms.Panel pl_mid;
        private System.Windows.Forms.Button bt_save;
    }
}
