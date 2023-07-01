using Contas_Familia.Window;
using System;
using System.Windows.Forms;

namespace Contas_Familia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            // ESCONDER O LOGIN 
            this.Hide();
            new Dashboard().Show();
        }
    }
}
