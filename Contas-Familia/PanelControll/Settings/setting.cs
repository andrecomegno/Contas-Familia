using Contas_Familia.Script;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll.Settings
{
    public partial class setting : UserControl
    {

        private string userName = Login.Instance.userName;
        private string familyName;

        public setting()
        {
            InitializeComponent();
        }

        void Starting()
        {
            txt_username.Text = userName;
            pl_account_02.Visible = false;
        }

        void TableAccount()
        {
            // BANCO DE DADOS 
        }

        #region BUTTONS
        void BT_Save_Account()
        {
            if (String.IsNullOrEmpty(txt_password.Texts))
            {
                txt_password.BorderColor = Color.Red;
                txt_password.BorderSize = 3;
            }
            else if (String.IsNullOrEmpty(txt_repeat_password.Texts))
            {
                txt_repeat_password.BorderColor = Color.Red;
                txt_repeat_password.BorderSize = 3;
            }
            else if (txt_password.Texts != txt_repeat_password.Texts)
            {
                MessageBox.Show("Different Password !", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CleanTexts(txt_password, txt_repeat_password, txt_family_name_edit);
                MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BT_Cancel() => CleanTexts(txt_password, txt_repeat_password, txt_family_name_edit);

        private void bt_save_01_Click(object sender, EventArgs e) => BT_Save_Account();
        private void bt_cancel_01_Click(object sender, EventArgs e) => BT_Cancel();

        private void bt_cancel_02_Click(object sender, EventArgs e) => BT_Cancel();

        #endregion

        #region CLEAN NOTIFICATION TEXTOBOX
        private void txt_password_Leave(object sender, EventArgs e)
        {
            txt_password.BorderColor = Color.Transparent;
            txt_password.BorderSize = 0;
        }       

        private void txt_repeat_password_Leave(object sender, EventArgs e)
        {
            txt_repeat_password.BorderColor = Color.Transparent;
            txt_repeat_password.BorderSize = 0;
        }
        #endregion

        void CleanTexts(RJTextBox password, RJTextBox re_password, RJTextBox family_name)
        {
            password.Texts = string.Empty;
            re_password.Texts = string.Empty;
            family_name.Texts = string.Empty;
        }

        private void setting_Load(object sender, EventArgs e)
        {
            Starting();
        }


    }
}
