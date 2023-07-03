using System;
using Contas_Familia.Window;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll
{
    public partial class register_name : UserControl
    {

        public register_name()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            bills_to_pay uc = new bills_to_pay();
            Main.Instance.addControl(uc);
        }
    }
}
