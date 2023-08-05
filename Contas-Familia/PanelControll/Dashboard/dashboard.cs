using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Contas_Familia.Script;
using Contas_Familia.Window;
using MySql.Data.MySqlClient;
using Contas_Familia.PanelControll.Home;

namespace Contas_Familia.PanelControll.Dashboard
{
    public partial class dashboard : UserControl
    {
        public static dashboard Instance;

        private int id_register_family = list_family.Instance.sl_id_register_family;
        private string userName = Login.Instance.userName;

        private string year;
        private string nameMember;

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

            string query = "select rf.family_name, rfm.family_member, cc.credit_card_payday, sum(tcc.total_payable_installment) AS total, rfm.id_register_family_member, rf.id_register_family from familypayday.login lo join familypayday.register_family rf on rf.id_login = lo.id_login join familypayday.register_family_member rfm on rfm.id_register_family = rf.id_register_family join familypayday.products pr on pr.id_register_family_member = rfm.id_register_family_member join familypayday.credit_card_list ccl on ccl.id_products = pr.id_products join familypayday.credit_card cc on cc.id_credit_card_list = ccl.id_credit_card_list join familypayday.total_credit_card tcc on tcc.id_credit_card = cc.id_credit_card where rf.id_register_family = @id_register_family and YEAR(credit_card_payday) like @dateNow and rfm.family_member like @nameMember group by rfm.id_register_family_member";

            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.AddWithValue("@id_register_family", id_register_family);
            cmd.Parameters.AddWithValue("@dateNow", "%" + year);
            cmd.Parameters.AddWithValue("@nameMember", nameMember);

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

            // AVISO QUE NAO TEM DADOS PARA MOSTRAR
            if (chart_paypal.Series.Any(s => s.Points.Count > 0))
                lb_alert_no_data.Visible = false;
            else
                lb_alert_no_data.Visible = true;
        }

        private void cb_year_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cb_year.SelectedIndex)
                {
                    case 0:
                        // TODOS OS ANOS
                        year = "%";
                        break;
                    default:
                        // SELECIONA O ANO NO COMBOBOX
                        year = cb_year.SelectedItem.ToString();
                        break;
                }
            }
            finally
            {
                // RESETA O GRAFICO
                Graphic();
            }
        }

        private void cb_member_family_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cb_member_family.SelectedIndex)
                {
                    case 0:
                        // TODOS OS MEMBROS DA FAMILIA
                        nameMember = "%";
                        break;
                    default:
                        // SELECIONA O NOME DO COMBOBOX
                        nameMember = cb_member_family.SelectedItem.ToString();
                        break;
                }
            }
            finally
            {
                // RESETA O GRAFICO
                Graphic();
            }
        }

        void TabelaComboBox()
        {
            configdb database = new configdb();
            database.openConnection();

            string queryMembers = "select family_member, id_register_family from familypayday.register_family_member where id_register_family = @id_register_family order by family_member asc";

            MySqlCommand cmdMembers = new MySqlCommand(queryMembers, database.getConnection());
            cmdMembers.Parameters.AddWithValue("@id_register_family", id_register_family);

            using (MySqlDataReader dr = cmdMembers.ExecuteReader())
            {
                while (dr.Read())
                {
                    // ATRIBUI TODOS OS MEMBROS DA FAMILIA AO COMBOBOX
                    cb_member_family.Items.Add(dr.GetString(0));
                }
            }

            string queryYear = "select YEAR (credit_card_payday) AS Ano from familypayday.credit_card group by YEAR (credit_card_payday)";

            MySqlCommand cmdYear = new MySqlCommand(queryYear, database.getConnection());

            using (MySqlDataReader dr = cmdYear.ExecuteReader())
            {
                while (dr.Read())
                {
                    // ATRIBUI TODOS AS DATAS AO COMBOBOX
                    cb_year.Items.Add(dr.GetString(0));
                }
            }            

            database.closeConnection();            

            // INICIAR O COMBOBOX COM OS TITULOS PARA SELECIONAR
            cb_member_family.SelectedIndex = 0;
            cb_year.SelectedIndex = 0;            
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
        private void bt_settings_Click(object sender, EventArgs e) => Main.Instance.Setting();

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Main.Instance.Home();
            Main.Instance.ButtonMenuDisabled(false);
        }
        #endregion

        private void dashboard_Load(object sender, EventArgs e) => Starting();


    }

}
