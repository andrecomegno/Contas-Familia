using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contas_Familia.Painel
{
    public partial class bills_to_pay : UserControl
    {
        // JANELA PAINEL SIZE
        private bool _plReg;

        public bills_to_pay()
        {
            InitializeComponent();
            Painel_Reg(_plReg);
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            Painel_Reg(_plReg = !_plReg);
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Painel_Reg(_plReg = !_plReg);
        }

        void Painel_Reg(bool reg)
        {
            if (reg)
            {
                pl_reg.Size = new Size(830, 480);
            }
            else
            {
                pl_reg.Size = new Size(830, 50);
            }
        }
    }
}
