using System;
using System.Drawing;
using System.Windows.Forms;
using Contas_Familia.PanelControll.Home;
using Contas_Familia.Script;
using Contas_Familia.Window;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Contas_Familia.PanelControll.Bills
{
    public partial class bills_to_pay : UserControl
    {
        private int id_register_family = list_family.Instance.select_id_register_family;

        // NOME DOS MEMBROS DA FAMILIA, E OS ID`S
        private int[] id_family_member = new int[10];
        private string[] family_member = new string[10];

        // BOTÃO EDITAR
        private bool[] _edit = new bool[10];

        public bills_to_pay()
        {
            InitializeComponent();
            StartPanelFamily();           
        }

        void Table()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select ID_FAMILY_MEMBER, FAMILY_MEMBER, ID_REGISTER_FAMILY from familypayday.family_member where id_register_family = @id_register_family ", database.getConnection());
            cmd.Parameters.AddWithValue("@id_register_family", id_register_family);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                int index = 0;
                while (dr.Read() && index < 10)
                {
                    id_family_member[index] = dr.GetInt32("id_family_member");
                    family_member[index] = dr.GetString("family_member");
                    index++;
                }               
            }

            DataTextBox();
            database.closeConnection();
        }

        // PAINEL DE CADA MEMBRO DA FAMILIA DIMINIU/AUMENTA DE TAMANHO AO CLICAR NO BOTÃO EDITAR
        void PanelContent(bool reg, Panel pl_content, IconButton button)
        {
            if (reg)
            {
                pl_content.Size = new Size(830, 500);
                button.IconChar = IconChar.AngleUp;

            }
            else
            {
                pl_content.Size = new Size(830, 70);
                button.IconChar = IconChar.AngleDown;
            }
        }

        #region BUTTON TABELA MEMBER FAMILY
        private void bt_edit_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_cancel_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_delet_01_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_cancel_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_delet_02_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_cancel_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_delet_03_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_04_Click(object sender, EventArgs e) => PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);

        private void bt_cancel_04_Click(object sender, EventArgs e) => PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);

        private void bt_delet_04_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_cancel_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_delet_05_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_cancel_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_delet_06_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_cancel_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_delet_07_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_cancel_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_delet_08_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_cancel_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_delet_09_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_cancel_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_delet_10_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }
        #endregion

        // ATRIBIU OS NOMES DE CADA MEMBRO DA FAMILIA AO TEXTO BOX
        void DataTextBox()
        {
            txt_name_01.Texts = family_member[0];
            txt_name_02.Texts = family_member[1];
            txt_name_03.Texts = family_member[2];
            txt_name_04.Texts = family_member[3];
            txt_name_05.Texts = family_member[4];
            txt_name_06.Texts = family_member[5];
            txt_name_07.Texts = family_member[6];
            txt_name_08.Texts = family_member[7];
            txt_name_09.Texts = family_member[8];
            txt_name_10.Texts = family_member[9];
        }

        // PAINEL DOS MEMBROS DA FAMILIA
        void StartPanelFamily()
        {
            PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);
            PanelContent(_edit[1], pl_content_02, bt_edit_02);
            PanelContent(_edit[2], pl_content_03, bt_edit_03);
            PanelContent(_edit[3], pl_content_04, bt_edit_04);
            PanelContent(_edit[4], pl_content_05, bt_edit_05);
            PanelContent(_edit[5], pl_content_06, bt_edit_06);
            PanelContent(_edit[6], pl_content_07, bt_edit_07);
            PanelContent(_edit[7], pl_content_08, bt_edit_08);
            PanelContent(_edit[8], pl_content_09, bt_edit_09);
            PanelContent(_edit[9], pl_content_10, bt_edit_10);
        }

        private void bills_to_pay_Load(object sender, EventArgs e)
        {
            Main.Instance.ButtonMenuDisabled(true);

            Table();            
        }
    }
}
