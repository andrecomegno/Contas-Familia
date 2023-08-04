using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Contas_Familia.Script;
using Contas_Familia.Window;
using MySql.Data.MySqlClient;
using Contas_Familia.PanelControll.Home;
using System.Linq;

namespace Contas_Familia.PanelControll.Dashboard
{
    public partial class dashboard : UserControl
    {
        public static dashboard Instance;

        private int id_register_family = list_family.Instance.sl_id_register_family;
        private string userName = Login.Instance.userName;

        public dashboard()
        {
            InitializeComponent();
            Instance = this;
        }

        void Starting()
        {
            LabelNameFamilyAndLogin();
            TabelaComboBox();
            Graphic();

            // DESATIVA O MENU HOME 
            Main.Instance.ButtonMenuDisabled(true);
        }

        #region Panel Graphic
        void Graphic()
        {
            configdb database = new configdb();
            database.openConnection();

            string query = "select rf.family_name, rfm.family_member, cc.credit_card_payday, sum(tcc.total_payable_installment) AS total, rfm.id_register_family_member, rf.id_register_family from familypayday.login lo join familypayday.register_family rf on rf.id_login = lo.id_login join familypayday.register_family_member rfm on rfm.id_register_family = rf.id_register_family join familypayday.products pr on pr.id_register_family_member = rfm.id_register_family_member join familypayday.credit_card_list ccl on ccl.id_products = pr.id_products join familypayday.credit_card cc on cc.id_credit_card_list = ccl.id_credit_card_list join familypayday.total_credit_card tcc on tcc.id_credit_card = cc.id_credit_card where rf.id_register_family = @id_register_family and cc.credit_card_payday like @dateNow group by rfm.id_register_family_member";

            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.AddWithValue("@id_register_family", id_register_family);
            cmd.Parameters.AddWithValue("@dateNow", "%" + DateTime.Now.Year); 

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart_paypal.DataSource = dt;
                chart_paypal.Series["payday"].XValueMember = "family_member";
                chart_paypal.Series["payday"].YValueMembers = "total";
                chart_paypal.Series["payday"].IsValueShownAsLabel = true;
                chart_paypal.Series["payday"].LabelFormat = "C2";               

                chart_paypal.DataBind();
            }

            database.closeConnection();

            if (chart_paypal.Series.Any(s => s.Points.Count > 0))
            {
                lb_alert_no_data.Visible = false;
            }
            else
            {
                lb_alert_no_data.Visible = true;
            }
        }

        void TabelaComboBox()
        {
            configdb database = new configdb();
            database.openConnection();

            string query = "select family_member, id_register_family from familypayday.register_family_member where id_register_family = '1' order by family_member asc";

            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.AddWithValue("@id_register_family", id_register_family);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    // ATRIBUI TODOS OS MEMBROS DA FAMILIA AO COMBOBOX
                    cb_member_family.Items.Add(dr.GetString(0));
                }
            }

            string query2 = "select family_member, id_register_family from familypayday.register_family_member where id_register_family = '1' order by family_member asc";

            MySqlCommand cmd2 = new MySqlCommand(query2, database.getConnection());
            cmd2.Parameters.AddWithValue("@id_register_family", id_register_family);

            using (MySqlDataReader dr = cmd2.ExecuteReader())
            {
                while (dr.Read())
                {
                    // ATRIBUI TODOS OS MEMBROS DA FAMILIA AO COMBOBOX
                    cb_name_member.Items.Add(dr.GetString(0));
                }
            }

            database.closeConnection();

            // INICIAR O COMBOBOX COM OS TITULOS PARA SELECIONAR
            cb_member_family.SelectedIndex = 0;
            cb_name_member.SelectedIndex = 0;
        }

        #endregion

        #region Menu Top 
        private void bt_dashboard_Click(object sender, EventArgs e) => Dashboard();

        private void bt_family_Click(object sender, EventArgs e) => Family();

        public void Dashboard()
        {
            dashboard uc = new dashboard();
            Main.Instance.addControll(uc);

            bt_dashboard.BackColor = Color.FromArgb(48, 134, 200);
            bt_family.BackColor = Color.FromArgb(27, 74, 111);
        }

        public void Family()
        {
            family uc = new family();
            addControll(uc);

            bt_family.BackColor = Color.FromArgb(48, 134, 200);
            bt_dashboard.BackColor = Color.FromArgb(27, 74, 111);
        }

        public void addControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_mid.Controls.Clear();
            pl_mid.Controls.Add(userControl);
            userControl.BringToFront();
        }
        #endregion

        #region Panel User Login
        void LabelNameFamilyAndLogin()
        {
            // ATRIBUI O NOME DA CONTA LOGADA
            lb_userName.Text = userName;            
            // ATRIBUI O NOME DA FAMILIA LOGADA
            lb_family_name.Text = list_family.Instance.sl_family_name + " !";
        }

        // Botões
        private void bt_settings_Click(object sender, EventArgs e)
        {
            Main.Instance.Setting();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Main.Instance.Home();
            Main.Instance.ButtonMenuDisabled(false);
        }
        #endregion

        private void dashboard_Load(object sender, EventArgs e)
        {
            Starting();
        }


    }

}
