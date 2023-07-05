using Contas_Familia.PanelControll.Bills;
using Contas_Familia.Window;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll.Dashboard
{
    public partial class dashboard : UserControl
    {

        public static dashboard Instance;

        public dashboard()
        {
            InitializeComponent();

            Instance = this;
        }

        public void addControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_mid.Controls.Clear();
            pl_mid.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bt_home_Click(object sender, EventArgs e) => Home();

        private void bt_family_Click(object sender, EventArgs e) => Family();


        public void Home()
        {
            dashboard uc = new dashboard();
            Main.Instance.addControll(uc);

            bt_home.BackColor = Color.CornflowerBlue;
            bt_family.BackColor = Color.LightSlateGray;
        }

        public void Family()
        {
            bills_to_pay uc = new bills_to_pay();
            addControll(uc);

            bt_family.BackColor = Color.CornflowerBlue;
            bt_home.BackColor = Color.LightSlateGray;
        }


    }

}
