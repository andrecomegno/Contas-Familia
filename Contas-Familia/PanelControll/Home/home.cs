using Contas_Familia.Window;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll
{
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
            List_Family();
        }

        private void List_Family()
        {
            list_family uc = new list_family();
            addControl(uc);
        }

        private void addControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_family.Controls.Clear();
            pl_family.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bt_new_family_Click(object sender, System.EventArgs e)
        {
            register_name uc = new register_name();
            Main.Instance.addControl(uc);
        }
    }
}
