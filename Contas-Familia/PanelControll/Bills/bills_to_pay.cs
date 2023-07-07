using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Contas_Familia.PanelControll.Register;
using Contas_Familia.Script;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Contas_Familia.PanelControll.Bills
{
    public partial class bills_to_pay : UserControl
    {
        private long id_register_family = register_family.Instance.id_register_family;

        public string[] id;
        public string[] name;


        // BOTÃO EDITAR
        private bool[] _edit = new bool[10];

        public bills_to_pay()
        {
            InitializeComponent();

            PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);
            PanelContent(_edit[1], pl_content_02, bt_edit_02);
        }

        void Table()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select * from familypayday.family_member where id_register_family = '" + id_register_family + "' ", database.getConnection());

            using (MySqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    int id = rd.GetInt32("id_family_member");
                    string name = rd.GetString("family_member");

                    MessageBox.Show("ID: " + id);
                    MessageBox.Show("Name: " + name);

                    
                }
            }

            database.closeConnection();
        }

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

        private void bt_edit_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_cancel_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void txt_delet_01_Click(object sender, EventArgs e)
        {
            PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_cancel_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void txt_delet_02_Click(object sender, EventArgs e)
        {
            PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

            // DETELAR MEMBRO DA FAMILIA
        }

        private void bills_to_pay_Load(object sender, EventArgs e)
        {
            Table();
        }
    }
}
