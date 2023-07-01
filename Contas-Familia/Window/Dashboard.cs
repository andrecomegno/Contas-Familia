using Contas_Familia.Painel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contas_Familia.Window
{
    public partial class Dashboard : Form
    {
        public static Dashboard Instance;

        public Dashboard()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            Instance = this;
        }

        public void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_mid.Controls.Clear();
            pl_mid.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

        private void bt_test_Click(object sender, EventArgs e)
        {
            register_name uc = new register_name();
            addControl(uc);
        }
    }
}
