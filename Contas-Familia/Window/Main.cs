using System;
using Contas_Familia.PanelControll;
using System.Windows.Forms;

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
            addControl(uc);
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
    }
}
