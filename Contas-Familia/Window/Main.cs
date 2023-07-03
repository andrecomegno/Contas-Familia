using System;
using System.Windows.Forms;
using Contas_Familia.PanelControll.Dashboard;
using Contas_Familia.PanelControll.Home;
using Contas_Familia.PanelControll.Settings;

namespace Contas_Familia.Window
{
    public partial class Main : Form
    {
        public static Main Instance;

        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            Instance = this;

            home uc = new home();
            addControll(uc);
        }

        public void addControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_mid.Controls.Clear();
            pl_mid.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // BOTÕES JANELA
        private void bt_minimize_Click(object sender, EventArgs e)
        {

        }

        private void bt_maximize_Click(object sender, EventArgs e)
        {

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        // BOTÕES LATERAL
        private void bt_home_Click(object sender, EventArgs e)
        {
            home();
        }

        private void bt_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard();
        }

        private void bt_settings_Click(object sender, EventArgs e)
        {
            Setting();
        }

        private void bt_settings_2_Click(object sender, EventArgs e)
        {
            Setting();
        }

        private void bt_menu_back_Click(object sender, EventArgs e)
        {
            Menu_Back();
        }

        void home()
        {
            home uc = new home();
            addControll(uc);
        }

        void Dashboard()
        {
            family uc = new family();
            addControll(uc);
        }

        void Setting()
        {
            setting uc = new setting();
            addControll(uc);
        }

        void Menu_Back()
        {

        }


    }
}
