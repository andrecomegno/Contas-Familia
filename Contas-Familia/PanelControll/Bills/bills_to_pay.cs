using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll.Bills
{
    public partial class bills_to_pay : UserControl
    {
        // BOTÃO EDITAR
        private bool[] _edit = new bool[10];

        public bills_to_pay()
        {
            InitializeComponent();

            PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);
            PanelContent(_edit[1], pl_content_02, bt_edit_02);
        }

        void PanelContent(bool reg, Panel pl_content, IconButton button)
        {
            if (reg)
            {
                pl_content.Size = new Size(830, 500);
                button.IconChar = IconChar.AngleUp;

            }
            else
            {
                pl_content.Size = new Size(830, 70);
                button.IconChar = IconChar.AngleDown;
            }
        }

        private void bt_edit_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_cancel_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void txt_delet_01_Click(object sender, EventArgs e)
        {
            PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_cancel_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void txt_delet_02_Click(object sender, EventArgs e)
        {
            PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

            // DETELAR MEMBRO DA FAMILIA
        }




    }
}
