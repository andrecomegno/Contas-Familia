using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Contas_Familia.Script;
using Contas_Familia.Window;
using Contas_Familia.PanelControll.Dashboard;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace Contas_Familia.PanelControll.Home
{
    public partial class list_family : UserControl
    {
        public static list_family Instance;

        // LISTA DAS FAMILIA
        public int[] id_register_family = new int[10];
        public string[] family_name = new string[10];

        // LOGIN
        public int id_login = Login.Instance.id_login;

        // SELECIONAR UMA FAMILIA
        public int sl_id_register_family;
        public string sl_family_name;

        // BOTÕES
        private IconButton ButtonFamilyDelete;

        public list_family()
        {
            InitializeComponent();
            Instance = this;
        }

        void Table()
        {
            configdb database = new configdb();
            database.openConnection();

            string query = "select id_register_family, family_name, id_login from familypayday.register_family where id_login = @id_login ";

            // TABELA REGISTRO DO NOME DA FAMILIA
            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.AddWithValue("@id_login", id_login);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                int index = 0;
                while (dr.Read() && index < 10)
                {
                    id_register_family[index] = dr.GetInt32("id_register_family");
                    family_name[index] = dr.GetString("family_name");
                    index++;
                }
            }

            ButtonFamilyName();
            database.closeConnection();
        }

        #region Button Family Name
        // ADD OS NOMES DAS FAMILIAS NOS BOTÕES
        void ButtonFamilyName()
        {
            Button[] buttons = { bt_family_01, bt_family_02, bt_family_03, bt_family_04, bt_family_05, bt_family_06, bt_family_07, bt_family_08, bt_family_09, bt_family_10 };
            int numButtons = buttons.Length;

            for (int i = 0; i < numButtons; i++)
            {
                if (i < family_name.Length)
                {
                    buttons[i].Text = family_name[i];
                }
            }
        }

        // DESATIVA OS BOTÕES DAS FAMILIAS QUE AINDA NÃO FORAM CRIADAS
        void ButtonList()
        {
            IconButton[] buttons = { bt_family_01, bt_family_02, bt_family_03, bt_family_04, bt_family_05, bt_family_06, bt_family_07, bt_family_08, bt_family_09, bt_family_10 };

            foreach (IconButton button in buttons)
            {
                if (string.IsNullOrEmpty(button.Text))
                {
                    button.Enabled = false;
                }
            }
        }

        void Next_Dashboard()
        {
            dashboard uc = new dashboard();
            Main.Instance.addControll(uc);

            // SELECIONAR BOTÃO DASHBOARD
            Main.Instance.Dashboard();
        }

        private void bt_family_01_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                // MOUSE ESQUERDO
                case MouseButtons.Left:
                    // ADD O ID REGISTER FAMILY PARA O select_id_register_family
                    sl_id_register_family = id_register_family[0];
                    // ADD O NOME DA FAMILIA 
                    sl_family_name = family_name[0];
                    // IR PARA O DASHBOARD
                    Next_Dashboard();
                    break;
                // MOUSE DIREITO
                case MouseButtons.Right:
                    // ADD O ID REGISTER FAMILY PARA O select_id_register_family
                    sl_id_register_family = id_register_family[0];
                    // ATRIBUI O BOTÃO DELETADO A VARIAVEL ButtonFamilyDelete
                    ButtonFamilyDelete = bt_family_01;                    
                    break;
            }
        }

        private void bt_family_02_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[1];
                    sl_family_name = family_name[1];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[1];
                    ButtonFamilyDelete = bt_family_02;
                    break;
            }            
        }
        private void bt_family_03_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[2];
                    sl_family_name = family_name[2];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[2];
                    ButtonFamilyDelete = bt_family_03;
                    break;
            }
        }

        private void bt_family_04_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[3];
                    sl_family_name = family_name[3];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[3];
                    ButtonFamilyDelete = bt_family_04;
                    break;
            }
        }

        private void bt_family_05_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[4];
                    sl_family_name = family_name[4];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[4];
                    ButtonFamilyDelete = bt_family_05;
                    break;
            }
        }

        private void bt_family_06_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[5];
                    sl_family_name = family_name[5];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[5];
                    ButtonFamilyDelete = bt_family_06;
                    break;
            }
        }

        private void bt_family_07_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[6];
                    sl_family_name = family_name[6];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[6];
                    ButtonFamilyDelete = bt_family_07;
                    break;
            }
        }

        private void bt_family_08_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[7];
                    sl_family_name = family_name[7];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[7];
                    ButtonFamilyDelete = bt_family_08;
                    break;
            }
        }

        private void bt_family_09_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[8];
                    sl_family_name = family_name[8];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[8];
                    ButtonFamilyDelete = bt_family_09;
                    break;
            }
        }

        private void bt_family_10_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    sl_id_register_family = id_register_family[9];
                    sl_family_name = family_name[9];
                    Next_Dashboard();
                    break;
                case MouseButtons.Right:
                    sl_id_register_family = id_register_family[9];
                    ButtonFamilyDelete = bt_family_10;
                    break;
            }
        }
        #endregion

        #region MENU contextMenuStrip1
        void BT_Delete()
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE FAMILY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:
                    DeleteFamily();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }            
        }

        void DeleteFamily()
        {
            // EXCLUIR FAMILIA
            try
            {
                configdb database = new configdb();
                database.openConnection();

                MySqlCommand cmd = new MySqlCommand("delete from familypayday.register_family where (id_register_family = @id_register_family) and (id_login = @id_login)", database.getConnection());
                cmd.Parameters.AddWithValue("@id_register_family", sl_id_register_family);
                cmd.Parameters.AddWithValue("@id_login", id_login);

                cmd.ExecuteNonQuery();

                database.closeConnection();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Code" + erro + "Internal Error ", "FATAL ERROR");
            }
            finally
            {
                DeleteButtonFamily(ButtonFamilyDelete);
            }
        }

        // DESABILITAR BOTÃO DELETADO
        private void DeleteButtonFamily(IconButton bt)
        {
            bt.IconColor = Color.FromArgb(24, 25, 28);
            bt.BackColor = Color.FromArgb(24, 25, 28);
            bt.Text = string.Empty;
            bt.Enabled = false;
        }

        private void Delete_Click(object sender, EventArgs e) => BT_Delete();
        #endregion

        private void list_family_Load(object sender, EventArgs e)
        {
            Table();
            ButtonList();
        }

    }
}
