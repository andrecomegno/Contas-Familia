﻿using Contas_Familia.PanelControll.Home;
using Contas_Familia.Script;
using Contas_Familia.Window;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

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

            Main.Instance.ButtonMenuDisabled(true);
        }

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

        #region Panel Total Family
        void TabelaComboBox()
        {
            configdb database = new configdb();
            database.openConnection();

            string query = "select family_member, id_register_family from familypayday.register_family_member where id_register_family = @id_register_family order by family_member asc";
            
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

            database.closeConnection();

            // INICIAR COMO TODOS OS NOMES DA FAMILIA
            cb_member_family.SelectedIndex = 0;
        }

        void LabelTotal()
        {

        } 
        #endregion

        private void dashboard_Load(object sender, EventArgs e)
        {
            Starting();
        }


    }

}
