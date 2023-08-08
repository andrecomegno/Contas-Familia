
namespace Contas_Familia.PanelControll.Home
{
    partial class edit_family_name
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
            this.pl_list_family = new System.Windows.Forms.Panel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.txt_family_name_edit = new Contas_Familia.Script.RJTextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.pl_list_family.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_list_family
            // 
            this.pl_list_family.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.pl_list_family.Controls.Add(this.bt_save);
            this.pl_list_family.Controls.Add(this.bt_cancel);
            this.pl_list_family.Controls.Add(this.txt_family_name_edit);
            this.pl_list_family.Controls.Add(this.lb_title);
            this.pl_list_family.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_list_family.Location = new System.Drawing.Point(0, 0);
            this.pl_list_family.Name = "pl_list_family";
            this.pl_list_family.Size = new System.Drawing.Size(560, 275);
            this.pl_list_family.TabIndex = 143;
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save.FlatAppearance.BorderSize = 0;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.White;
            this.bt_save.Location = new System.Drawing.Point(152, 83);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(122, 36);
            this.bt_save.TabIndex = 113;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.LightSlateGray;
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.White;
            this.bt_cancel.Location = new System.Drawing.Point(280, 83);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(122, 36);
            this.bt_cancel.TabIndex = 112;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // txt_family_name_edit
            // 
            this.txt_family_name_edit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_family_name_edit.BorderColor = System.Drawing.Color.White;
            this.txt_family_name_edit.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txt_family_name_edit.BorderRadius = 0;
            this.txt_family_name_edit.BorderSize = 2;
            this.txt_family_name_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_family_name_edit.ForeColor = System.Drawing.Color.Black;
            this.txt_family_name_edit.Location = new System.Drawing.Point(152, 45);
            this.txt_family_name_edit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_family_name_edit.Multiline = false;
            this.txt_family_name_edit.Name = "txt_family_name_edit";
            this.txt_family_name_edit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_family_name_edit.PasswordChar = false;
            this.txt_family_name_edit.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_family_name_edit.PlaceholderText = "";
            this.txt_family_name_edit.Size = new System.Drawing.Size(250, 31);
            this.txt_family_name_edit.TabIndex = 109;
            this.txt_family_name_edit.Texts = "";
            this.txt_family_name_edit.UnderlinedStyle = false;
            this.txt_family_name_edit.Leave += new System.EventHandler(this.txt_family_name_edit_Leave);
            // 
            // lb_title
            // 
            this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.White;
            this.lb_title.Location = new System.Drawing.Point(3, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(554, 31);
            this.lb_title.TabIndex = 110;
            this.lb_title.Text = "Edit Account Family";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_family_name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pl_list_family);
            this.Name = "edit_family_name";
            this.Size = new System.Drawing.Size(560, 302);
            this.Load += new System.EventHandler(this.edit_family_name_Load);
            this.pl_list_family.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_list_family;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private Script.RJTextBox txt_family_name_edit;
        private System.Windows.Forms.Label lb_title;
    }
}
