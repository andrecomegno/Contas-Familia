using System;
using Contas_Familia.Window;
using System.Windows.Forms;
using System.Drawing;
using Contas_Familia.PanelControll.Dashboard;

namespace Contas_Familia.PanelControll.Register
{
    public partial class register_name : UserControl
    {

        private bool _next;

        public register_name()
        {
            InitializeComponent();

            PanelContent(_next, pl_content);
        }

        private void bt_next_Click(object sender, EventArgs e) => PanelContent(_next = !_next, pl_content);

        private void bt_save_Click(object sender, EventArgs e) => Dashboard();

        void PanelContent(bool reg, Panel pl_family)
        {
            if (reg)
            {
                pl_family.Size = new Size(830, 500);
            }
            else
            {
                pl_family.Size = new Size(830, 70);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e) => Dashboard();

        void Dashboard()
        {
            dashboard uc = new dashboard();
            Main.Instance.addControll(uc);

            // SELECIONAR BOTÃO DASHBOARD
            Main.Instance.Dashboard();

            // ABRIR JANELA FAMILY DO DASHBOARD
            dashboard.Instance.Family();
        }
    }
}
