using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contas_Familia.PanelControll.Dashboard
{
    public partial class family : UserControl
    {
        // JANELA PAINEL SIZE
        private bool _save_00, _save_01, _save_02, _save_03, _save_04;

        public family()
        {
            InitializeComponent();

            Painel_Reg(_save_00, pl_family_00);
            Painel_Reg(_save_01, pl_family_01);
            Painel_Reg(_save_02, pl_family_02);
            Painel_Reg(_save_03, pl_family_03);
            Painel_Reg(_save_04, pl_family_04);
        }

        void Painel_Reg(bool reg, Panel pl_family)
        {
            if (reg)
            {
                pl_family.Size = new Size(830, 480);
            }
            else
            {
                pl_family.Size = new Size(830, 50);                
            }
        }

        private void bt_save_00_Click(object sender, EventArgs e)
        {
            Painel_Reg(_save_00 = !_save_00, pl_family_00);
        }

        private void bt_save_01_Click(object sender, EventArgs e)
        {
            Painel_Reg(_save_01 = !_save_01, pl_family_01);
        }

        private void bt_save_02_Click(object sender, EventArgs e)
        {
            Painel_Reg(_save_02 = !_save_02, pl_family_02);
        }

        private void bt_save_03_Click(object sender, EventArgs e)
        {
            Painel_Reg(_save_03 = !_save_03, pl_family_03);
        }

        private void bt_save_04_Click(object sender, EventArgs e)
        {
            Painel_Reg(_save_04 = !_save_04, pl_family_04);
        }
    }
}
