using Contas_Familia.PanelControll.Register;
using Contas_Familia.Window;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll.Home
{
    public partial class home : UserControl
    {
        public static home Instance;

        public home()
        {
            InitializeComponent();
            List_Family();

            Instance = this;
        }

        private void List_Family()
        {
            list_family uc = new list_family();
            addControll(uc);
        }

        public void addControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_family.Controls.Clear();
            pl_family.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void bt_new_family_Click(object sender, System.EventArgs e)
        {
            register_family uc = new register_family();
            Main.Instance.addControll(uc);
        }
    }
}
