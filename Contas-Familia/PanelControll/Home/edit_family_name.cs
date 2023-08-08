using System;
using Contas_Familia.Script;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Contas_Familia.PanelControll.Home
{
    public partial class edit_family_name : UserControl
    {
        // COLETA OS DADOS 
        private int id_login = Login.Instance.id_login;
        private int id_register_family = list_family.Instance.sl_id_register_family;
        private string family_name = list_family.Instance.sl_family_name;

        public edit_family_name()
        {
            InitializeComponent();
        }

        #region TABLE EDIT FAMILY NAME
        void TableEditFamilyName()
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            //UPDATE
            string query = "update familypayday.register_family set family_name = @family_name WHERE (id_register_family = @id_register_family) and (id_login = @id_login)";

            // NOME DA FAMILIA
            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;
            cmd.Parameters.Add("@family_name", MySqlDbType.VarChar, 50).Value = txt_family_name_edit.Texts;
            cmd.Parameters.Add("@id_login", MySqlDbType.Int32).Value = id_login;
            cmd.ExecuteNonQuery();

            database.closeConnection();
        }
        #endregion

        #region BUTTONS
        void BT_Save()
        {
            try
            {
                if (String.IsNullOrEmpty(txt_family_name_edit.Texts))
                {
                    txt_family_name_edit.BorderColor = Color.Red;
                    txt_family_name_edit.BorderSize = 3;
                }
                else
                {
                    TableEditFamilyName();

                    MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Code" + erro + "Internal Error ", "FATAL ERROR");
            }
            finally
            {
                BT_Cancel();
            }
        }

        void BT_Cancel()
        {
            list_family uc = new list_family();
            home.Instance.addControll(uc);
        }

        private void bt_cancel_Click(object sender, EventArgs e) => BT_Cancel();
        private void bt_save_Click(object sender, EventArgs e) => BT_Save();
        #endregion

        #region CLEAN NOTIFICATION TEXTOBOX
        private void txt_family_name_edit_Leave(object sender, EventArgs e)
        {
            txt_family_name_edit.BorderColor = Color.Transparent;
            txt_family_name_edit.BorderSize = 0;
        }
        #endregion

        private void edit_family_name_Load(object sender, EventArgs e) => txt_family_name_edit.Texts = family_name;


    }
}
