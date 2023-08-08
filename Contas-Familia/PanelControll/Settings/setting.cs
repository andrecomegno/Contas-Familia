using System;
using System.Drawing;
using System.Windows.Forms;
using Contas_Familia.Script;
using MySql.Data.MySqlClient;

namespace Contas_Familia.PanelControll.Settings
{
    public partial class setting : UserControl
    {
        public static setting Instance;
        private int id_login = Login.Instance.id_login;
        private string userName = Login.Instance.userName;

        public setting()
        {
            InitializeComponent();
            Instance = this;
        }

        #region TABLE EDIT LOGIN
        void TableAccount()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            //UPDATE
            string query = "update familypayday.login set password = @password WHERE (id_login = @id_login)";

            // NOME DA FAMILIA
            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.Add("@id_login", MySqlDbType.Int32).Value = id_login;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar, 8).Value = txt_password.Texts;

            cmd.ExecuteNonQuery();

            database.closeConnection();
        }
        #endregion

        #region BUTTONS
        void BT_Save()
        {
            // VERIFICA SE AS SENHAS SAO IGUAIS 
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
                // VERIFICA MONINA DE 8 CARACTERES 
                if (txt_password.Texts.Length < 8)
                {
                    MessageBox.Show("Minimum password of 8 characters !", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TableAccount();
                    MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    CleanTexts(txt_password, txt_repeat_password);
                }
            }
        }

        // LIMPA O TEXTBOX
        void CleanTexts(RJTextBox password, RJTextBox re_password)
        {
            password.Texts = string.Empty;
            re_password.Texts = string.Empty;
        }

        void BT_Cancel() => CleanTexts(txt_password, txt_repeat_password);
        private void bt_save_01_Click(object sender, EventArgs e) => BT_Save();
        private void bt_cancel_01_Click(object sender, EventArgs e) => BT_Cancel();
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

        private void setting_Load(object sender, EventArgs e) => txt_username.Text = userName;

    }
}
