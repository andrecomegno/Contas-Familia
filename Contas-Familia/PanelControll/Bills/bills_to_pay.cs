using System;
using System.Drawing;
using System.Windows.Forms;
using Contas_Familia.Window;

namespace Contas_Familia.PanelControll
{
    public partial class bills_to_pay : UserControl
    {
        // JANELA PAINEL SIZE
        private bool _button_pl;

        public bills_to_pay()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                Painel_Reg(_button_pl = !_button_pl);
                DialogResult dr = MessageBox.Show("Saved with success", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // PROXIMA TELA
                family uc = new family();
                Main.Instance.addControl(uc);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Painel_Reg(_button_pl = !_button_pl);
        }

        void Painel_Reg(bool reg)
        {
            if (reg)
            {
                pl_reg.Size = new Size(830, 50);
            }
            else
            {
                pl_reg.Size = new Size(830, 480);                
            }
        }
    }
}
