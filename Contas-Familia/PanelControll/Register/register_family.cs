using System;
using Contas_Familia.Window;
using System.Windows.Forms;
using System.Drawing;
using Contas_Familia.PanelControll.Dashboard;
using Contas_Familia.Script;
using MySql.Data.MySqlClient;

namespace Contas_Familia.PanelControll.Register
{
    public partial class register_family : UserControl
    {
        public static register_family Instance;
        private bool _next;
        public long id_register_family;
        private string id_login = Login.Instance.id_login;

        public register_family()
        {
            InitializeComponent();

            PanelContent(_next, pl_content);
            Instance = this;
        }

        // BOTÕES
        void Next()
        {
            if (String.IsNullOrEmpty(txt_family_name.Texts))
            {
                txt_family_name.BorderColor = Color.Red;
                txt_family_name.BorderSize = 3;
            }
            else
            {
                PanelContent(_next = !_next, pl_content);
            }
        }
        
        void Button_Save()
        {
            if (String.IsNullOrEmpty(txt_name_01.Texts))
            {
                txt_name_01.BorderColor = Color.Red;
                txt_name_01.BorderSize = 3;
            }
            else
            {
                try
                {
                    Family();

                    MessageBox.Show("Family Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    dashboard uc = new dashboard();
                    Main.Instance.addControll(uc);

                    // SELECIONAR BOTÃO DASHBOARD
                    Main.Instance.Dashboard();

                    // ABRIR JANELA FAMILY DO DASHBOARD
                    dashboard.Instance.Family();
                }                
            }
        }

        void Family()
        {
            configdb database = new configdb();
            database.openConnection();

            // INSERT TABELA CADASTRO FAMILIA
            MySqlCommand CmdRegisterFamily = new MySqlCommand("INSERT INTO familypayday.register_family (id_register_family, family_name, id_login) values (null, @family_name, @id_login)", database.getConnection());

            CmdRegisterFamily.Parameters.Add("@family_name", MySqlDbType.VarChar, 45).Value = txt_family_name.Texts;
            CmdRegisterFamily.Parameters.Add("@id_login", MySqlDbType.Int32).Value = id_login;

            CmdRegisterFamily.ExecuteNonQuery();
            // LONG ID
            id_register_family = CmdRegisterFamily.LastInsertedId;

            // TODOS OS TEXTO BOX 
            string[] textBoxValues = { txt_name_01.Texts, txt_name_02.Texts, txt_name_03.Texts, txt_name_04.Texts, txt_name_05.Texts, txt_name_06.Texts, txt_name_07.Texts, txt_name_08.Texts, txt_name_09.Texts, txt_name_10.Texts };
            // CONTADOR DE MEMBROS DA FAMILIA
            int familyMemberCount = 1; 

            // CRIADO UM LOOP
            for (int i = 0; i < textBoxValues.Length; i++)
            {
                // VERIFICA SE O TEXTBOX ESTÁ PREENCHIDO, SE ESTIVER, VAI SALVAR OS DADOS
                if (!string.IsNullOrEmpty(textBoxValues[i]))
                {
                    // INSERT TABELA CADASTRO MEMBRO DA FAMILIA
                    MySqlCommand cmdFamilyMember = new MySqlCommand("INSERT INTO familypayday.family_member (id_family_member, family_member, family_amount, id_register_family) VALUES (null, @family_member, @family_amount, @id_register_family)", database.getConnection());

                    cmdFamilyMember.Parameters.Add("@family_member", MySqlDbType.VarChar, 45).Value = textBoxValues[i];
                    cmdFamilyMember.Parameters.Add("@family_amount", MySqlDbType.Int32).Value = familyMemberCount;
                    cmdFamilyMember.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;

                    cmdFamilyMember.ExecuteNonQuery();

                    // CONTAGEM
                    familyMemberCount++;
                }
            }

            database.closeConnection();
        }

        void Cancel()
        {
            dashboard uc = new dashboard();
            Main.Instance.addControll(uc);

            // SELECIONAR BOTÃO DASHBOARD
            Main.Instance.Dashboard();
        }
        
        private void bt_next_Click(object sender, EventArgs e) => Next();

        private void bt_save_Click(object sender, EventArgs e) => Button_Save();

        private void bt_cancel_Click(object sender, EventArgs e) => Cancel();

        // PAINEL CASCATA DO REGISTO DA FAMILIA
        void PanelContent(bool reg, Panel pl_family)
        {
            if (reg)
            {
                pl_family.Size = new Size(830, 500);
            }
            else
            {
                pl_family.Size = new Size(830, 70);
            }
        }

        #region CLEAN NOTIFICATION TEXTOBOX
        private void txt_family_name_Leave(object sender, EventArgs e)
        {
            txt_family_name.BorderColor = Color.Transparent;
            txt_family_name.BorderSize = 0;
        }

        private void txt_name_01_Leave(object sender, EventArgs e)
        {
            txt_name_01.BorderColor = Color.Transparent;
            txt_name_01.BorderSize = 0;
        }

        private void txt_name_02_Leave(object sender, EventArgs e)
        {
            txt_name_02.BorderColor = Color.Transparent;
            txt_name_02.BorderSize = 0;
        }

        private void txt_name_03_Leave(object sender, EventArgs e)
        {
            txt_name_03.BorderColor = Color.Transparent;
            txt_name_03.BorderSize = 0;
        }

        private void txt_name_04_Leave(object sender, EventArgs e)
        {
            txt_name_04.BorderColor = Color.Transparent;
            txt_name_04.BorderSize = 0;
        }

        private void txt_name_05_Leave(object sender, EventArgs e)
        {
            txt_name_05.BorderColor = Color.Transparent;
            txt_name_05.BorderSize = 0;
        }

        private void txt_name_06_Leave(object sender, EventArgs e)
        {
            txt_name_06.BorderColor = Color.Transparent;
            txt_name_06.BorderSize = 0;
        }

        private void txt_name_07_Leave(object sender, EventArgs e)
        {
            txt_name_07.BorderColor = Color.Transparent;
            txt_name_07.BorderSize = 0;
        }

        private void txt_name_08_Leave(object sender, EventArgs e)
        {
            txt_name_08.BorderColor = Color.Transparent;
            txt_name_08.BorderSize = 0;
        }

        private void txt_name_09_Leave(object sender, EventArgs e)
        {
            txt_name_09.BorderColor = Color.Transparent;
            txt_name_09.BorderSize = 0;
        }

        private void txt_name_10_Leave(object sender, EventArgs e)
        {
            txt_name_10.BorderColor = Color.Transparent;
            txt_name_10.BorderSize = 0;
        }
        #endregion
    }
}
