using Contas_Familia.PanelControll.Dashboard;
using Contas_Familia.Script;
using Contas_Familia.Window;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll.Home
{
    public partial class list_family : UserControl
    {
        public static list_family Instance;

        public int id_login = Login.Instance.id_login;
        public int[] id_register_family = new int[10];
        public string[] family_name = new string[10];

        public int select_id_register_family;

        public list_family()
        {
            InitializeComponent();

            Instance = this;
        }

        void Table()
        {
            configdb database = new configdb();
            database.openConnection();

            // TABELA REGISTRO DO NOME DA FAMILIA
            MySqlCommand cmd = new MySqlCommand("select id_register_family, family_name, id_login from familypayday.register_family where id_login = @id_login ", database.getConnection());
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

            DateFamilyName();
            database.closeConnection();
        }

        void DateFamilyName()
        {
            bt_family_01.Text = family_name[0];
            bt_family_02.Text = family_name[1];
            bt_family_03.Text = family_name[2];
            bt_family_04.Text = family_name[3];
            bt_family_05.Text = family_name[4];
            bt_family_06.Text = family_name[5];
            bt_family_07.Text = family_name[6];
            bt_family_08.Text = family_name[7];
            bt_family_09.Text = family_name[8];
            bt_family_10.Text = family_name[9];
        }

        // LISTA DAS FAMILIA CRIADA
        private void bt_family_01_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[0];
            Next_Dashboard();
        }

        private void bt_family_02_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[1];
            Next_Dashboard();
        }

        private void bt_family_03_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[2];
            Next_Dashboard();
        }

        private void bt_family_04_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[3];
            Next_Dashboard();
        }

        private void bt_family_05_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[4];
            Next_Dashboard();
        }

        private void bt_family_06_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[5];
            Next_Dashboard();
        }

        private void bt_family_07_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[6];
            Next_Dashboard();
        }

        private void bt_family_08_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[7];
            Next_Dashboard();
        }

        private void bt_family_09_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[8];
            Next_Dashboard();
        }

        private void bt_family_10_Click(object sender, System.EventArgs e)
        {
            select_id_register_family = id_register_family[9];
            Next_Dashboard();
        }

        void Next_Dashboard()
        {
            dashboard uc = new dashboard();
            Main.Instance.addControll(uc);

            // SELECIONAR BOTÃO DASHBOARD
            Main.Instance.Dashboard();

            // ABRIR JANELA FAMILY DO DASHBOARD
            dashboard.Instance.Family();
        }



        private void list_family_Load(object sender, System.EventArgs e)
        {
            Table();
        }
    }
}
