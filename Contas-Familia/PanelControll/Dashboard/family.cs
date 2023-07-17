using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Contas_Familia.PanelControll.Home;
using Contas_Familia.Script;
using Contas_Familia.Window;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Contas_Familia.PanelControll.Dashboard
{
    public partial class family : UserControl
    {
        // ID`S
        private int id_register_family = list_family.Instance.select_id_register_family;        
        private int[] id_register_family_member = new int[10];

        // MEMBROS DA FAMILIA
        private string[] family_member = new string[10];

        // BOTÃO EDITAR
        private bool[] _edit = new bool[10];

        // BOTÃO SALVAR - ATRIBUI NOVOS DADOS A TABELA
        string credit_card_name;
        DateTime credit_card_payday;
        string store_name;
        string product_name;
        string card_credit_installment;
        decimal total_payble;
        decimal total_payable_installment;

        public family()
        {
            InitializeComponent();
            StartPanelFamily();
        }

        #region TABLES
        // TODAS AS TABELAS DOS MEMBROS, ATRIBUIDAS COM OS SEUS SEGUINTES NOMES REGISTRADOS
        private void TableAll()
        {
            configdb database = new configdb();
            database.openConnection();

            DataGridView[] dataGridViews = { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6, dataGridView7, dataGridView8, dataGridView9, dataGridView10 };
            Panel[] panels = { pl_content_01, pl_content_02, pl_content_03, pl_content_04, pl_content_05, pl_content_06, pl_content_07, pl_content_08, pl_content_09, pl_content_10 };
            Label[] lbNames = { lb_name_01, lb_name_02, lb_name_03, lb_name_04, lb_name_05, lb_name_06, lb_name_07, lb_name_08, lb_name_09, lb_name_10 };
            Label[] lbtotal = { txt_total_01, txt_total_02, txt_total_03, txt_total_04, txt_total_05, txt_total_06, txt_total_07, txt_total_08, txt_total_09, txt_total_10 };

            string query = "select ID_REGISTER_FAMILY_MEMBER, FAMILY_MEMBER, ID_REGISTER_FAMILY from familypayday.register_family_member";

            // NOVA DATAGRIDVIEW, OCULTA, UTILIZADA SOMENTE PARA COLETAR OS MEMBROS DA FAMILIA
            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());

            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);                
                dgv_family_member.DataSource = dt;
            }

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                int index = 0;
                while (dr.Read() && index < 10)
                {
                    if (!dr.IsDBNull(dr.GetOrdinal("id_register_family_member")))
                    {
                        id_register_family_member[index] = dr.GetInt32("id_register_family_member");
                    }

                    if (!dr.IsDBNull(dr.GetOrdinal("family_member")))
                    {
                        family_member[index] = dr.GetString("family_member");
                    }

                    index++;
                }
            }

            // ATRIBUI TODOS OS MEMBROS DA FAMILIA NO LABEL TEXT
            for (int i = 0; i < dgv_family_member.Rows.Count; i++)
            {
                // PASSA TODOS OS MEMBROS AO LABEL
                lbNames[i].Text = family_member[i];

                // TODAS AS DATAGRIDVIEWS, PASSANDO OS MEMBROS DA FAMILIA PARA CADA TABELA
                dataGridViews[i].DataSource = ExecuteQuery(lbNames[i].Text);
            }

            // HABILITA / DESABILITA TODAS OS PAINEIS 
            for (int i = 0; i < dataGridViews.Length; i++)
            {
                // TOTAL DAS DIVIDAS DE CADA TABELAS
                lbtotal[i].Text = SumTotal(dataGridViews[i]).ToString("c");

                if (String.IsNullOrEmpty(lbNames[i].Text) || dgv_family_member.Rows.Count == 0)
                {
                    panels[i].Visible = false;
                }
                else
                {
                    panels[i].Visible = true;
                }               
            }

            // CONFIGURAÇÃO DE TODOS OS DATAGRIDVIEW
            foreach (DataGridView dataGridView in dataGridViews)
            {
                SettingsDataGridViewColumns(dataGridView);
            }

            database.closeConnection();

            // VERIFICA SE EXISTE ALGUMA PAINEL VISIVEL SE NAO TIVER, MOSTRA O AVISO PARA ADD UM NOVO MEMBRO  
            bool anyPanelVisible = false;
            foreach (Panel panel in panels)
            {
                if (panel.Visible)
                {
                    anyPanelVisible = true;
                    // SAI DO LOOP ASSIM QUE ENCONTRAR UM PAINEL VISIVEL
                    break; 
                }
            }

            // VARIAVEL PARA AUMENTAR / DIMINUIR O TAMANHO DO PAINEL 
            pl_add.Size = anyPanelVisible ? new Size(1222, 70) : new Size(1222, 458);
        }

        // SOMAR O VALOR TOTAL DAS DIVIDAS A PAGAR
        private double SumTotal(DataGridView dataGridViews)
        {
            double total = 0;
            for (int i = 0; i < dataGridViews.Rows.Count; i++)
            {
                var cellValue = dataGridViews.Rows[i].Cells["total_payable_installment"].Value;
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()) && double.TryParse(cellValue.ToString(), out double installment))
                {
                    total += installment;
                }
            }
            return total;
        }

        // EXECUTAR A CONSULTA E RETORNAR O DATATABLE
        private DataTable ExecuteQuery(string familyMemberName)
        {
            configdb database = new configdb();
            using (MySqlConnection connection = database.getConnection())
            {
                connection.Open();
                string query = "select rfm.id_register_family_member, rfm.family_member, cc.credit_card_name, cc.credit_card_payday, pr.store_name, pr.product_name, cc.credit_card_installment, tcc.total_payble, tcc.total_payable_installment, rf.id_register_family, cc.id_credit_card, pr.id_products from familypayday.login lo left join familypayday.register_family rf on rf.id_login = lo.id_login left join familypayday.register_family_member rfm on rfm.id_register_family = rf.id_register_family left join familypayday.products pr on pr.id_register_family_member = rfm.id_register_family_member left join familypayday.credit_card cc on cc.id_products = pr.id_products left join familypayday.total_credit_card tcc on tcc.id_credit_card = cc.id_credit_card where rfm.family_member = @family_member ";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@family_member", familyMemberName);

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // CONFIGURAR AS COLUNAS DO DATAGRIDVIEW
        private void SettingsDataGridViewColumns(DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count >= 12)
            {
                dataGridView.Columns[0].Visible = false; // id_register_family_member
                dataGridView.Columns[1].Visible = false; // family_member
                dataGridView.Columns[2].HeaderText = "CARTÕES";
                dataGridView.Columns[3].HeaderText = "VENCIMENTO";
                dataGridView.Columns[4].HeaderText = "LOJAS";
                dataGridView.Columns[5].HeaderText = "PRODUTOS";
                dataGridView.Columns[6].HeaderText = "PARCELAMENTO";
                dataGridView.Columns[7].HeaderText = "VALOR TOTAL";
                dataGridView.Columns[8].HeaderText = "VALOR PARCELADO";
                dataGridView.Columns[9].Visible = false; // id_register_family
                dataGridView.Columns[10].Visible = false; // id_credit_card
                dataGridView.Columns[11].Visible = false; // id_products
            }
        }

        // TABELA NOVO MEMBRO DA FAMILIA
        void AddNewFamilyMember()
        {
            configdb database = new configdb();
            database.openConnection();

            // ADD NOVO MEMBRO DA FAMILIA
            MySqlCommand cmd = new MySqlCommand("INSERT INTO familypayday.register_family_member (id_register_family_member, family_member, id_register_family) VALUES (null, @family_member, @id_register_family)", database.getConnection());
            cmd.Parameters.Add("@family_member", MySqlDbType.VarChar, 45).Value = txt_add_family_name.Texts;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;

            cmd.ExecuteNonQuery();
            database.closeConnection();

        }

        // TABELA DELETAR MEMBRO
        void TableDelete(int id_member, Panel pl)
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM familypayday.register_family_member WHERE id_register_family_member = @id_register_family_member and id_register_family = @id_register_family", database.getConnection());
            cmd.Parameters.Add("@id_register_family_member", MySqlDbType.Int32).Value = id_member;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;
            cmd.ExecuteNonQuery();

            database.closeConnection();
        }

        #endregion

        #region BUTTON TABELA MEMBER FAMILY

        // BOTÃO 1
        private void bt_edit_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_cancel_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_delete_01_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[0], pl_content_01, lb_name_01);

        private void bt_save_01_Click(object sender, EventArgs e) => BT_Save(dataGridView1, id_register_family_member[0], lb_name_01.Text);

        // BOTÃO 2
        private void bt_edit_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_cancel_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_delet_02_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[1], pl_content_02, lb_name_02);

        private void bt_save_02_Click(object sender, EventArgs e) => BT_Save(dataGridView2, id_register_family_member[1], lb_name_02.Text);

        // BOTÃO 3
        private void bt_edit_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_cancel_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_delet_03_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[2], pl_content_03, lb_name_03);

        private void bt_save_03_Click(object sender, EventArgs e) => BT_Save(dataGridView3, id_register_family_member[2], lb_name_03.Text);

        // BOTÃO 4
        private void bt_edit_04_Click(object sender, EventArgs e) => PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);

        private void bt_cancel_04_Click(object sender, EventArgs e) => PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);

        private void bt_delet_04_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[3], pl_content_04, lb_name_04);

        private void bt_save_04_Click(object sender, EventArgs e) => BT_Save(dataGridView4, id_register_family_member[3], lb_name_04.Text);

        // BOTÃO 5
        private void bt_edit_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_cancel_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_delet_05_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[4], pl_content_05, lb_name_05);

        private void bt_save_05_Click(object sender, EventArgs e) => BT_Save(dataGridView5, id_register_family_member[4], lb_name_05.Text);

        // BOTÃO 6
        private void bt_edit_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_cancel_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_delet_06_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[5], pl_content_06, lb_name_06);

        private void bt_save_06_Click(object sender, EventArgs e) => BT_Save(dataGridView6, id_register_family_member[5], lb_name_06.Text);

        // BOTÃO 7
        private void bt_edit_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_cancel_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_delet_07_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[6], pl_content_07, lb_name_07);

        private void bt_save_07_Click(object sender, EventArgs e) => BT_Save(dataGridView7, id_register_family_member[6], lb_name_07.Text);

        // BOTÃO 8
        private void bt_edit_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_cancel_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_delet_08_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[7], pl_content_08, lb_name_08);

        private void bt_save_08_Click(object sender, EventArgs e) => BT_Save(dataGridView8, id_register_family_member[7], lb_name_08.Text);

        // BOTÃO 9
        private void bt_edit_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_cancel_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_delet_09_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[8], pl_content_09, lb_name_09);

        private void bt_save_09_Click(object sender, EventArgs e) => BT_Save(dataGridView9, id_register_family_member[8], lb_name_09.Text);

        // BOTÃO 10
        private void bt_edit_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_cancel_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_delet_10_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[9], pl_content_10, lb_name_10);

        private void bt_save_10_Click(object sender, EventArgs e) => BT_Save(dataGridView10, id_register_family_member[9], lb_name_10.Text);

        void BT_Cancel(DataGridView dataGridViews, bool reg, Panel pl_content, IconButton button)
        {
            try
            {

            }
            finally
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
        }

        void BT_Save(DataGridView dataGridViews, int id, string member)
        {
            try
            {
                if (dataGridViews.Rows.Count > 1)
                {
                    for (int i = 0; i < dataGridViews.Rows.Count - 1; i++)
                    {
                        // ID - COLUNA 0
                        dataGridViews.Rows[i].Cells[0].Value = id;
                        // NOME DO MEMBRO DA FAMILIA - COLUNA - 1
                        dataGridViews.Rows[i].Cells[1].Value = member;
                        // NOME DO CARTÃO DE CREDITO - COLUNA - 2
                        credit_card_name = dataGridViews.Rows[i].Cells[2].Value.ToString();
                        // VENCIMENTO DO CARTÃO DE CREDITO - COLUNA - 3
                        credit_card_payday = Convert.ToDateTime(dataGridViews.Rows[i].Cells[3].Value);
                        // NOME DA LOJA - COLUNA - 4
                        store_name = dataGridViews.Rows[i].Cells[4].Value.ToString();
                        // NOME DO PRODUTO - COLUNA - 5
                        product_name = dataGridViews.Rows[i].Cells[5].Value.ToString();
                        // PARCELAMENTO  - COLUNA - 6
                        card_credit_installment = dataGridViews.Rows[i].Cells[6].Value.ToString();
                        // VALOR TOTAL DA COMPRA - COLUNA - 7
                        total_payble = Convert.ToDecimal(dataGridViews.Rows[i].Cells[7].Value);
                        // VALOR A PAGAR PARCELADO - COLUNA - 8
                        total_payable_installment = Convert.ToDecimal(dataGridViews.Rows[i].Cells[8].Value);
                    }

                    // BANCO DE DADOS
                    configdb database = new configdb();
                    database.openConnection();

                    // PRODUTOS
                    MySqlCommand cmdProducts = new MySqlCommand("INSERT INTO familypayday.products (id_products, store_name, product_name, id_register_family_member) VALUES (null, @store_name, @product_name, @id_register_family_member)", database.getConnection());
                    cmdProducts.Parameters.Add("@store_name", MySqlDbType.VarChar, 50).Value = store_name;
                    cmdProducts.Parameters.Add("@product_name", MySqlDbType.VarChar, 245).Value = product_name;
                    cmdProducts.Parameters.Add("@id_register_family_member", MySqlDbType.Int32).Value = id;

                    cmdProducts.ExecuteNonQuery();
                    long id_products = cmdProducts.LastInsertedId;

                    // CARTÃO DE CREDITO
                    MySqlCommand cmdCreditCard = new MySqlCommand("INSERT INTO familypayday.credit_card (id_credit_card, credit_card_name, credit_card_payday, credit_card_installment, id_products) VALUES (null, @credit_card_name, @credit_card_payday, @credit_card_installment, @id_products)", database.getConnection());
                    cmdCreditCard.Parameters.Add("@credit_card_name", MySqlDbType.VarChar, 45).Value = credit_card_name;
                    cmdCreditCard.Parameters.Add("@credit_card_payday", MySqlDbType.Date).Value = credit_card_payday;
                    cmdCreditCard.Parameters.Add("@credit_card_installment", MySqlDbType.VarChar, 7).Value = card_credit_installment;
                    cmdCreditCard.Parameters.Add("@id_products", MySqlDbType.Int32).Value = id_products;

                    cmdCreditCard.ExecuteNonQuery();
                    long id_credit_card = cmdCreditCard.LastInsertedId;

                    // TOTAL
                    MySqlCommand cmdTotal = new MySqlCommand("INSERT INTO familypayday.total_credit_card (id_total_credit_card, total_payble, total_payable_installment, id_credit_card) VALUES (null, @total_payble, @total_payable_installment, @id_credit_card)", database.getConnection());
                    cmdTotal.Parameters.Add("@total_payble", MySqlDbType.Decimal).Value = total_payble;
                    cmdTotal.Parameters.Add("@total_payable_installment", MySqlDbType.Decimal).Value = total_payable_installment;
                    cmdTotal.Parameters.Add("@id_credit_card", MySqlDbType.Int32).Value = id_credit_card;

                    cmdTotal.ExecuteNonQuery();

                    database.closeConnection();
                }
            }
            finally
            {
                MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BT_Delete(int id_member, Panel pl, Label lbname)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // TABELA DELETAR 
                        TableDelete(id_member, pl);
                        // DESABILITA O PAINEL DO MEMBRO DA FAMILIA
                        pl.Visible = false;
                        // LIMPA O NOME DO MEMBRO NO PAINEL
                        lbname.Text = string.Empty;
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTERNAL ERROR: " + ex, "INTERNAL ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region ADD NEW FAMILY MEMEBR
        // ADD NOVO MEMBRO DA FAMILIA
        private void bt_add_Click(object sender, EventArgs e)
        {
            ButtonAddFamilyName(bt_add, bt_save, bt_cancel, true);
            TextAddFamilyName(txt_add_family_name, true);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_add_family_name.Texts))
                {
                    txt_add_family_name.BorderColor = Color.Red;
                    txt_add_family_name.BorderSize = 3;
                }
                else
                {
                    AddNewFamilyMember();
                    MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // ATUALIZA OS PAINEL QUANDO CRIADO UM NOVO MEMBRO DA FAMILIA
                    TableAll();
                    

                    ButtonAddFamilyName(bt_add, bt_save, bt_cancel, false);
                    TextAddFamilyName(txt_add_family_name, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTERNAL ERROR: " + ex, "INTERNAL ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            ButtonAddFamilyName(bt_add, bt_save, bt_cancel, false);
            TextAddFamilyName(txt_add_family_name, false);
        }

        // ADD, SALVAR, CANCELAR DO NOVO MEMBRO DA FAMILIA
        void ButtonAddFamilyName(Button bt_01, Button bt_02, Button bt_03, bool _bt)
        {
            if (_bt)
            {
                bt_01.Visible = false;
                bt_02.Visible = true;
                bt_03.Visible = true;
            }
            else
            {
                bt_01.Visible = true;
                bt_02.Visible = false;
                bt_03.Visible = false;
            }
        }

        // CAMPO TEXTO NOVO MEMBRO DA FAMILIA
        void TextAddFamilyName(RJTextBox add, bool _on)
        {
            if (_on)
            {
                add.Enabled = true;
                add.BackColor = Color.White;
            }
            else
            {
                add.Enabled = false;
                add.BackColor = Color.FromArgb(32, 34, 37);
                add.Texts = string.Empty;
            }
        }
        #endregion

        // PAINEL DOS MEMBROS DA FAMILIA
        void StartPanelFamily()
        {
            PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);
            PanelContent(_edit[1], pl_content_02, bt_edit_02);
            PanelContent(_edit[2], pl_content_03, bt_edit_03);
            PanelContent(_edit[3], pl_content_04, bt_edit_04);
            PanelContent(_edit[4], pl_content_05, bt_edit_05);
            PanelContent(_edit[5], pl_content_06, bt_edit_06);
            PanelContent(_edit[6], pl_content_07, bt_edit_07);
            PanelContent(_edit[7], pl_content_08, bt_edit_08);
            PanelContent(_edit[8], pl_content_09, bt_edit_09);
            PanelContent(_edit[9], pl_content_10, bt_edit_10);

            // TABELA OCULTA DOS MEMBBROS DA FAMILIA
            //pl_table_member_family.Visible = false;
        }

        private void txt_add_family_name_Leave(object sender, EventArgs e)
        {
            txt_add_family_name.BorderColor = Color.Transparent;
            txt_add_family_name.BorderSize = 0;
        }

        // PAINEL DE CADA MEMBRO DA FAMILIA DIMINIU/AUMENTA DE TAMANHO AO CLICAR NO BOTÃO EDITAR
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

        private void family_Load(object sender, EventArgs e)
        {
            Main.Instance.ButtonMenuDisabled(true);            
            TableAll();
        }


    }
}
