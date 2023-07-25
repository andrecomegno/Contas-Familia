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

        // COLETAR DADOS DA TABELA AO SELECIONAR
        private int sl_id_register_family_member;
        private int sl_id_products;

        // MEMBROS DA FAMILIA
        private string[] family_member = new string[10];

        // BOTÃO EDITAR
        private bool[] _edit = new bool[10];

        // BOTÃO EDITAR NOME DO MEMBRO DA FAMILIA
        private bool[] _nameEdit = new bool[10];

        // BOTÃO SALVAR - ATRIBUI NOVOS DADOS A TABELA
        string credit_card_name;
        DateTime credit_card_payday;
        string store_name;
        string product_name;
        string card_credit_installment;
        decimal total_payble;
        decimal total_payable_installment;

        DateTimePicker dtp = new DateTimePicker();
        Rectangle rectangle;

        public family()
        {
            InitializeComponent();
            StartPanelFamily();

            dataGridView1.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }

        void teste()
        {
            /*
            DataGridView[] dataGridViews = { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6, dataGridView7, dataGridView8, dataGridView9, dataGridView10 };

            for (int i = 0; i < dataGridViews.Length; i++)
            {
                if (dtp[i] != null)
                {
                    dataGridViews[i].Controls.Add(dtp[i]);
                    dtp[i].Visible = false;
                    dtp[i].Format = DateTimePickerFormat.Custom;
                    dtp[i].TextChanged += new EventHandler(dtp_TextChange);
                }
            }
            */
        }

        #region TABLES
        // TODAS AS TABELAS DOS MEMBROS, ATRIBUIDAS COM OS SEUS SEGUINTES NOMES REGISTRADOS
        private void TableMain()
        {
            configdb database = new configdb();
            database.openConnection();

            DataGridView[] dataGridViews = { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6, dataGridView7, dataGridView8, dataGridView9, dataGridView10 };
            Panel[] panels = { pl_content_01, pl_content_02, pl_content_03, pl_content_04, pl_content_05, pl_content_06, pl_content_07, pl_content_08, pl_content_09, pl_content_10 };
            Label[] TxtNames = { txt_name_01, txt_name_02, txt_name_03, txt_name_04, txt_name_05, txt_name_06, txt_name_07, txt_name_08, txt_name_09, txt_name_10 };
            Label[] TxtTotal = { txt_total_01, txt_total_02, txt_total_03, txt_total_04, txt_total_05, txt_total_06, txt_total_07, txt_total_08, txt_total_09, txt_total_10 };

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
                TxtNames[i].Text = family_member[i];

                // TODAS AS DATAGRIDVIEWS, PASSANDO OS MEMBROS DA FAMILIA PARA CADA TABELA
                dataGridViews[i].DataSource = ExecuteQuery(TxtNames[i].Text);
            }

            // HABILITA / DESABILITA TODAS OS PAINEIS 
            for (int i = 0; i < dataGridViews.Length; i++)
            {
                // TOTAL DAS DIVIDAS DE CADA TABELAS
                TxtTotal[i].Text = SumTotal(dataGridViews[i]).ToString("c");

                if (String.IsNullOrEmpty(TxtNames[i].Text) || dgv_family_member.Rows.Count == 0)
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
            SearchPanels();

            //dtp.Visible = false;
        }

        // SOMAR O VALOR TOTAL DAS DIVIDAS A PAGAR
        private double SumTotal(DataGridView dataGridViews)
        {
            double total = 0;
            for (int i = 0; i < dataGridViews.Rows.Count; i++)
            {
                //  CELLS 8 = total_payable_installment
                var cellValue = dataGridViews.Rows[i].Cells[8].Value;
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
                dataGridView.Columns[2].HeaderText = "CARTÕES"; // credit_card_name
                dataGridView.Columns[3].HeaderText = "VENCIMENTO"; // credit_card_payday
                dataGridView.Columns[4].HeaderText = "LOJAS"; // store_name
                dataGridView.Columns[5].HeaderText = "PRODUTOS"; // product_name
                dataGridView.Columns[6].HeaderText = "PARCELAMENTO"; // credit_card_installment
                dataGridView.Columns[7].HeaderText = "VALOR TOTAL"; // total_payble
                dataGridView.Columns[8].HeaderText = "VALOR PARCELADO"; // total_payable_installment
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

            string query = "INSERT INTO familypayday.register_family_member (id_register_family_member, family_member, id_register_family) VALUES (null, @family_member, @id_register_family)";

            // ADD NOVO MEMBRO DA FAMILIA
            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());            
            cmd.Parameters.Add("@family_member", MySqlDbType.VarChar, 45).Value = txt_add_family_name.Texts;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;
            cmd.ExecuteNonQuery();

            database.closeConnection();
        }

        // TABELA DELETAR MEMBRO
        void TableDeleteMemberFamily(int id_member, Panel pl)
        {
            configdb database = new configdb();
            database.openConnection();

            string query = "DELETE FROM familypayday.register_family_member WHERE id_register_family_member = @id_register_family_member and id_register_family = @id_register_family";

            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.Add("@id_register_family_member", MySqlDbType.Int32).Value = id_member;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;
            cmd.ExecuteNonQuery();

            database.closeConnection();
        }

        // TABELA DELETAR QUANDO SELECIONADO UMA LINHA
        void TableDeleteBillToPay()
        {
            configdb database = new configdb();
            database.openConnection();

            string query = "DELETE FROM familypayday.products WHERE(ID_PRODUCTS = @ID_PRODUCTS) and (ID_REGISTER_FAMILY_MEMBER = @ID_REGISTER_FAMILY_MEMBER)";

            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.Add("@id_products", MySqlDbType.Int32).Value = sl_id_products;
            cmd.Parameters.Add("@id_register_family_member", MySqlDbType.Int32).Value = sl_id_register_family_member;
            cmd.ExecuteNonQuery();

            database.closeConnection();
        }

        // TABELA DE CONTAS A PAGAR
        void TableMemberPayDay(int id)
        {
            // BANCO DE DADOS
            configdb database = new configdb();
            database.openConnection();

            string queryProducts = "INSERT INTO familypayday.products (id_products, store_name, product_name, id_register_family_member) VALUES (null, @store_name, @product_name, @id_register_family_member)";
            string queryCreditCard = "INSERT INTO familypayday.credit_card (id_credit_card, credit_card_name, credit_card_payday, credit_card_installment, id_products) VALUES (null, @credit_card_name, @credit_card_payday, @credit_card_installment, @id_products)";
            string queryTotal = "INSERT INTO familypayday.total_credit_card (id_total_credit_card, total_payble, total_payable_installment, id_credit_card) VALUES (null, @total_payble, @total_payable_installment, @id_credit_card)";

            // PRODUTOS
            MySqlCommand cmdProducts = new MySqlCommand(queryProducts, database.getConnection());
            cmdProducts.Parameters.Add("@store_name", MySqlDbType.VarChar, 50).Value = store_name;
            cmdProducts.Parameters.Add("@product_name", MySqlDbType.VarChar, 245).Value = product_name;
            cmdProducts.Parameters.Add("@id_register_family_member", MySqlDbType.Int32).Value = id;
            cmdProducts.ExecuteNonQuery();
            long id_products = cmdProducts.LastInsertedId;

            // CARTÃO DE CREDITO
            MySqlCommand cmdCreditCard = new MySqlCommand(queryCreditCard, database.getConnection());
            cmdCreditCard.Parameters.Add("@credit_card_name", MySqlDbType.VarChar, 45).Value = credit_card_name;
            cmdCreditCard.Parameters.Add("@credit_card_payday", MySqlDbType.Date).Value = credit_card_payday;
            cmdCreditCard.Parameters.Add("@credit_card_installment", MySqlDbType.VarChar, 7).Value = card_credit_installment;
            cmdCreditCard.Parameters.Add("@id_products", MySqlDbType.Int32).Value = id_products;
            cmdCreditCard.ExecuteNonQuery();
            long id_credit_card = cmdCreditCard.LastInsertedId;

            // TOTAL
            MySqlCommand cmdTotal = new MySqlCommand(queryTotal, database.getConnection());
            cmdTotal.Parameters.Add("@total_payble", MySqlDbType.Decimal).Value = total_payble;
            cmdTotal.Parameters.Add("@total_payable_installment", MySqlDbType.Decimal).Value = total_payable_installment;
            cmdTotal.Parameters.Add("@id_credit_card", MySqlDbType.Int32).Value = id_credit_card;
            cmdTotal.ExecuteNonQuery();

            database.closeConnection();
        }

        // TABELA DE EDIÇÃO DO NOME DO MEMBRO DA FAMILIA
        void TableEditNameMember(int id, RJTextBox Editname)
        {
            configdb database = new configdb();
            database.openConnection();

            string query = "UPDATE familypayday.register_family_member SET family_member = @family_member WHERE (id_register_family_member = @id_register_family_member) and (id_register_family = @id_register_family) ";

            // EDITAR NOME DO MEMBRO DA FAMILIA
            MySqlCommand cmd = new MySqlCommand(query, database.getConnection());
            cmd.Parameters.Add("@family_member", MySqlDbType.VarChar, 45).Value = Editname.Texts;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;
            cmd.Parameters.Add("@id_register_family_member", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();

            database.closeConnection();
        }

        #endregion

        #region BUTTONS PANEL TABLE
        // BOTÃO SALVAR
        void BT_Save(DataGridView dataGridViews, int id, Label name)
        {
            // DATAGRIDVIEW, SALVAR NOVOS DADOS NA TABELA
            if (dataGridViews.Rows.Count > 1)
            {
                for (int i = 0; i < dataGridViews.Rows.Count - 1; i++)
                {
                    // ID - COLUNA 0
                    dataGridViews.Rows[i].Cells[0].Value = id;
                    // NOME DO MEMBRO DA FAMILIA - COLUNA - 1
                    dataGridViews.Rows[i].Cells[1].Value = name;
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

                // TABELA DAS CONTAS A PAGAR
                TableMemberPayDay(id);

                // ATUALIZA A TABELA
                TableMain();

                MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // BOTÃO DELETAR
        void BT_Delete(int id_member, Panel pl, Label name)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // TABELA DELETAR 
                        TableDeleteMemberFamily(id_member, pl);
                        // DESABILITA O PAINEL DO MEMBRO DA FAMILIA
                        pl.Visible = false;
                        // LIMPA O NOME DO MEMBRO NO PAINEL
                        name.Text = string.Empty;
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
            finally
            {
                // VERIFICA SE EXISTE ALGUMA PAINEL VISIVEL SE NAO TIVER, MOSTRA O AVISO PARA ADD UM NOVO MEMBRO  
                SearchPanels();
            }
        }

        // BOTÃO CAMCELAR
        void BT_Cancel(bool reg, Panel pl_content, IconButton button)
        {
            // RECOLHE O PAINEL
            PanelContent(reg, pl_content, button);
        }

        // BOTÃO DELETAR LINHA DA TABELA
        private void BT_DeleteRow(DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (dr)
            {
                case DialogResult.Yes:
                    // TABELA DELETAR 
                    TableDeleteBillToPay();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        // ATUALIZA A SOMA TOTAL DAS DIVIDAS DA TABELA, QUANDO DELETADO OU O VALOR PAGO 
        void SumTotalRefresh(DataGridView dataGridViews, Label total)
        {
            if (dataGridViews.Rows.Count > 1)
            {
                total.Text = SumTotal(dataGridViews).ToString("c");
            }
        }

        // BOTÃO 1
        private void bt_edit_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);
        private void bt_cancel_01_Click(object sender, EventArgs e) => BT_Cancel(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);
        private void bt_delete_01_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[0], pl_content_01, txt_name_01);
        private void bt_save_01_Click(object sender, EventArgs e) => BT_Save(dataGridView1, id_register_family_member[0], txt_name_01);
        // BOTÃO 2
        private void bt_edit_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);
        private void bt_cancel_02_Click(object sender, EventArgs e) => BT_Cancel(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);
        private void bt_delete_02_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[1], pl_content_02, txt_name_02);
        private void bt_save_02_Click(object sender, EventArgs e) => BT_Save(dataGridView2, id_register_family_member[1], txt_name_02);
        // BOTÃO 3
        private void bt_edit_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);
        private void bt_cancel_03_Click(object sender, EventArgs e) => BT_Cancel(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);
        private void bt_delete_03_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[2], pl_content_03, txt_name_03);
        private void bt_save_03_Click(object sender, EventArgs e) => BT_Save(dataGridView3, id_register_family_member[2], txt_name_03);
        // BOTÃO 4
        private void bt_edit_04_Click(object sender, EventArgs e) => PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);
        private void bt_cancel_04_Click(object sender, EventArgs e) => BT_Cancel(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);
        private void bt_delete_04_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[3], pl_content_04, txt_name_04);
        private void bt_save_04_Click(object sender, EventArgs e) => BT_Save(dataGridView4, id_register_family_member[3], txt_name_04);
        // BOTÃO 5
        private void bt_edit_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);
        private void bt_cancel_05_Click(object sender, EventArgs e) => BT_Cancel(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);
        private void bt_delete_05_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[4], pl_content_05, txt_name_05);
        private void bt_save_05_Click(object sender, EventArgs e) => BT_Save(dataGridView5, id_register_family_member[4], txt_name_05);
        // BOTÃO 6
        private void bt_edit_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);
        private void bt_cancel_06_Click(object sender, EventArgs e) => BT_Cancel(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);
        private void bt_delete_06_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[5], pl_content_06, txt_name_06);
        private void bt_save_06_Click(object sender, EventArgs e) => BT_Save(dataGridView6, id_register_family_member[5], txt_name_06);
        // BOTÃO 7
        private void bt_edit_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);
        private void bt_cancel_07_Click(object sender, EventArgs e) => BT_Cancel(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);
        private void bt_delete_07_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[6], pl_content_07, txt_name_07);
        private void bt_save_07_Click(object sender, EventArgs e) => BT_Save(dataGridView7, id_register_family_member[6], txt_name_07);        
        // BOTÃO 8
        private void bt_edit_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);
        private void bt_cancel_08_Click(object sender, EventArgs e) => BT_Cancel(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);
        private void bt_delete_08_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[7], pl_content_08, txt_name_08);
        private void bt_save_08_Click(object sender, EventArgs e) => BT_Save(dataGridView8, id_register_family_member[7], txt_name_08);
        // BOTÃO 9
        private void bt_edit_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);
        private void bt_cancel_09_Click(object sender, EventArgs e) => BT_Cancel(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);
        private void bt_delete_09_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[8], pl_content_09, txt_name_09);
        private void bt_save_09_Click(object sender, EventArgs e) => BT_Save(dataGridView9, id_register_family_member[8], txt_name_09);
        // BOTÃO 10
        private void bt_edit_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);
        private void bt_cancel_10_Click(object sender, EventArgs e) => BT_Cancel(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);
        private void bt_delete_10_Click(object sender, EventArgs e) => BT_Delete(id_register_family_member[9], pl_content_10, txt_name_10);
        private void bt_save_10_Click(object sender, EventArgs e) => BT_Save(dataGridView10, id_register_family_member[9], txt_name_10);

        // BOTÃO DELETAR LINHA DA TABELA
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView5_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView6_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView7_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView8_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView9_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);
        private void dataGridView10_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => BT_DeleteRow(e);

        // ATUALIZA TABELA QUANDO DELETA UMA LINHA
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView1, txt_total_01);
        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView2, txt_total_02);
        private void dataGridView3_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView3, txt_total_03);
        private void dataGridView4_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView4, txt_total_04);
        private void dataGridView5_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView5, txt_total_05);
        private void dataGridView6_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView6, txt_total_06);
        private void dataGridView7_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView7, txt_total_07);
        private void dataGridView8_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView8, txt_total_08);
        private void dataGridView9_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView9, txt_total_09);
        private void dataGridView10_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => SumTotalRefresh(dataGridView10, txt_total_10);

        #endregion

        #region EDIT NAME MEMBER FAMILY
        // BOTÃO SAVAR
        void BT_Save_Edit(bool _edit, int id, Label name, RJTextBox name_edit, Button delete, Button save, Button cancel)
        {
            // VERIFICA SE O CAMPO TEXTO ESTA VAZIO
            if (string.IsNullOrEmpty(name_edit.Texts))
            {
                name_edit.BorderColor = Color.Red;
                name_edit.BorderSize = 3;
            }
            else
            {
                // TABELA EDITAR NOME DO MEMBRO DA FAMILIA
                TableEditNameMember(id, name_edit);

                // DEPOIS DE SALVAR O NOVO NOME, RESETA TODOS OS BOTÕES E VARIAVEIS
                EditName(_edit, name, name_edit, delete, save, cancel);

                // ATUALIZA O NOME EDITADO
                TableMain();

                MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // BOTÃO CANCELAR
        void BT_Cancel_Edit(bool _edit, Label name, RJTextBox name_edit, Button delete, Button save, Button cancel)
        {
            // DEPOIS DE SALVAR O NOVO NOME, RESETA TODOS OS BOTÕES E VARIAVEIS
            EditName(_edit, name, name_edit, delete, save, cancel);
        }

        // BOTÃO EDIT 1
        private void bt_save_edit_01_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[0] = !_nameEdit[0], id_register_family_member[0], txt_name_01, txt_name_edit_01, bt_delete_01, bt_save_edit_01, bt_cancel_edit_01);
        private void bt_cancel_edit_01_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[0] = !_nameEdit[0], txt_name_01, txt_name_edit_01, bt_delete_01, bt_save_edit_01, bt_cancel_edit_01);
        // BOTÃO EDIT 2
        private void bt_save_edit_02_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[1] = !_nameEdit[1], id_register_family_member[1], txt_name_02, txt_name_edit_02, bt_delete_02, bt_save_edit_02, bt_cancel_edit_02);
        private void bt_cancel_edit_02_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[1] = !_nameEdit[1], txt_name_02, txt_name_edit_02, bt_delete_02, bt_save_edit_02, bt_cancel_edit_02);
        // BOTÃO EDIT 3
        private void bt_save_edit_03_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[2] = !_nameEdit[2], id_register_family_member[2], txt_name_03, txt_name_edit_03, bt_delete_03, bt_save_edit_03, bt_cancel_edit_03);
        private void bt_cancel_edit_03_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[2] = !_nameEdit[2], txt_name_03, txt_name_edit_03, bt_delete_03, bt_save_edit_03, bt_cancel_edit_03);
        // BOTÃO EDIT 4
        private void bt_save_edit_04_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[3] = !_nameEdit[3], id_register_family_member[3], txt_name_04, txt_name_edit_04, bt_delete_04, bt_save_edit_04, bt_cancel_edit_04);
        private void bt_cancel_edit_04_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[3] = !_nameEdit[3], txt_name_04, txt_name_edit_04, bt_delete_04, bt_save_edit_04, bt_cancel_edit_04);
        // BOTÃO EDIT 5
        private void bt_save_edit_05_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[4] = !_nameEdit[4], id_register_family_member[4], txt_name_05, txt_name_edit_05, bt_delete_05, bt_save_edit_05, bt_cancel_edit_05);
        private void bt_cancel_edit_05_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[4] = !_nameEdit[4], txt_name_05, txt_name_edit_05, bt_delete_05, bt_save_edit_05, bt_cancel_edit_05);
        // BOTÃO EDIT 6
        private void bt_save_edit_06_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[5] = !_nameEdit[5], id_register_family_member[5], txt_name_06, txt_name_edit_06, bt_delete_06, bt_save_edit_06, bt_cancel_edit_06);
        private void bt_cancel_edit_06_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[5] = !_nameEdit[5], txt_name_06, txt_name_edit_06, bt_delete_06, bt_save_edit_06, bt_cancel_edit_06);
        // BOTÃO EDIT 7
        private void bt_save_edit_07_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[6] = !_nameEdit[6], id_register_family_member[6], txt_name_07, txt_name_edit_07, bt_delete_07, bt_save_edit_07, bt_cancel_edit_07);
        private void bt_cancel_edit_07_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[6] = !_nameEdit[6], txt_name_07, txt_name_edit_07, bt_delete_07, bt_save_edit_07, bt_cancel_edit_07);
        // BOTÃO EDIT 8
        private void bt_save_edit_08_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[7] = !_nameEdit[7], id_register_family_member[7], txt_name_08, txt_name_edit_08, bt_delete_08, bt_save_edit_08, bt_cancel_edit_08);
        private void bt_cancel_edit_08_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[7] = !_nameEdit[7], txt_name_08, txt_name_edit_08, bt_delete_08, bt_save_edit_08, bt_cancel_edit_08);
        // BOTÃO EDIT 9
        private void bt_save_edit_09_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[8] = !_nameEdit[8], id_register_family_member[8], txt_name_09, txt_name_edit_09, bt_delete_09, bt_save_edit_09, bt_cancel_edit_09);
        private void bt_cancel_edit_09_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[8] = !_nameEdit[8], txt_name_09, txt_name_edit_09, bt_delete_09, bt_save_edit_09, bt_cancel_edit_09);
        // BOTÃO EDIT 10
        private void bt_save_edit_10_Click(object sender, EventArgs e) => BT_Save_Edit(_nameEdit[9] = !_nameEdit[9], id_register_family_member[9], txt_name_10, txt_name_edit_10, bt_delete_10, bt_save_edit_10, bt_cancel_edit_10);
        private void bt_cancel_edit_10_Click(object sender, EventArgs e) => BT_Cancel_Edit(_nameEdit[9] = !_nameEdit[9], txt_name_10, txt_name_edit_10, bt_delete_10, bt_save_edit_10, bt_cancel_edit_10);

        #endregion

        #region SELECT ROW, COLLECT TABLE DATA
        // SELECIONAR LINHA, COLETAR DADOS 
        void SelectDeleteRow(DataGridView dataGridViews)
        {
            if (dataGridViews.SelectedRows.Count > 0)
            {
                // OBTEM A LINHA SELECIONADA
                DataRowView selectedRow = dataGridViews.SelectedRows[0].DataBoundItem as DataRowView;

                if (selectedRow != null)
                {
                    // COLETA OS DADOS DA LINHA SELECIONADA DA TABELA
                    if (selectedRow["id_products"] != DBNull.Value && selectedRow["id_register_family_member"] != DBNull.Value)
                    {
                        sl_id_products = Convert.ToInt32(selectedRow["id_products"]);
                        sl_id_register_family_member = Convert.ToInt32(selectedRow["id_register_family_member"]);
                    }
                }
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView1);
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView2);
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView3);
        private void dataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView4);
        private void dataGridView5_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView5);
        private void dataGridView6_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView6);
        private void dataGridView7_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView7);
        private void dataGridView8_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView8);
        private void dataGridView9_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView9);
        private void dataGridView10_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelectDeleteRow(dataGridView10);
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
                    TableMain();                    

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

        #region ADD DATETIMEPICKER TABLE
        // ADD NA TABELA O DateTimePicker
        void AddDateTimePickerTable(DataGridView dataGridViews, DataGridViewCellEventArgs e, DateTimePicker _dtp, Rectangle _rectangle)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViews.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViews.Columns.Count)
            {
                switch (dataGridViews.Columns[e.ColumnIndex].Name)
                {
                    case "Column4":
                        _rectangle = dataGridViews.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        _dtp.Size = new Size(_rectangle.Width, _rectangle.Height);
                        _dtp.Location = new Point(_rectangle.X, _rectangle.Y);
                        _dtp.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void dtp_TextChange(Object sender, EventArgs e)
        {
            DataGridView[] dataGridViews = { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5, dataGridView6, dataGridView7, dataGridView8, dataGridView9, dataGridView10 };

            for (int i = 0; i < dataGridViews.Length; i++)
            {
                dataGridViews[i].CurrentCell.Value = dtp[i].Text.ToString();
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                switch (dataGridView1.Columns[e.ColumnIndex].Index)
                {
                    case 3:
                        rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(rectangle.Width, rectangle.Height);
                        dtp.Location = new Point(rectangle.X, rectangle.Y);
                        dtp.Visible = true;

                        break;
                    default:
                        break;
                }

                MessageBox.Show("1");
            }            
        }
        //=> AddDateTimePickerTable(dataGridView1, e, dtp[0], rectangle[0]);
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView2.Columns.Count)
            {
                switch (dataGridView2.Columns[e.ColumnIndex].Index)
                {
                    case 3:
                        rectangle = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        dtp.Size = new Size(rectangle.Width, rectangle.Height);
                        dtp.Location = new Point(rectangle.X, rectangle.Y);
                        dtp.Visible = true;
                        break;
                    default:
                        break;
                }

                MessageBox.Show("2");
            }
        } //=> AddDateTimePickerTable(dataGridView2, e, dtp[1], rectangle[1]);
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e){ }// => AddDateTimePickerTable(dataGridView3, e, dtp[2], rectangle[2]);
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e) { } // => AddDateTimePickerTable(dataGridView4, e, dtp[3], rectangle[3]);
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e) { }// => AddDateTimePickerTable(dataGridView5, e, dtp[4], rectangle[4]);
        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e) { }// => AddDateTimePickerTable(dataGridView6, e, dtp[5], rectangle[5]);
        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e) { }//=> AddDateTimePickerTable(dataGridView7, e, dtp[6], rectangle[6]);
        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e) { }// => AddDateTimePickerTable(dataGridView8, e, dtp[7], rectangle[7]);
        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e) { }//=> AddDateTimePickerTable(dataGridView9, e, dtp[8], rectangle[8]);
        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e) { }//=> AddDateTimePickerTable(dataGridView10, e, dtp[9], rectangle[9]);

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;

        }// => dtp[0].Visible = false;
        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }// => dtp[1].Visible = false;
        private void dataGridView3_Scroll(object sender, ScrollEventArgs e) { }// => dtp[2].Visible = false;
        private void dataGridView4_Scroll(object sender, ScrollEventArgs e) { }// => dtp[3].Visible = false;
        private void dataGridView5_Scroll(object sender, ScrollEventArgs e) { }// => dtp[4].Visible = false;
        private void dataGridView6_Scroll(object sender, ScrollEventArgs e) { }// => dtp[5].Visible = false;
        private void dataGridView7_Scroll(object sender, ScrollEventArgs e) { }// => dtp[6].Visible = false;
        private void dataGridView8_Scroll(object sender, ScrollEventArgs e) { }// => dtp[7].Visible = false;
        private void dataGridView9_Scroll(object sender, ScrollEventArgs e) { }// => dtp[8].Visible = false;
        private void dataGridView10_Scroll(object sender, ScrollEventArgs e) { }// => dtp[9].Visible = false;
        #endregion

        #region TEXT EDIT

        // TEXTO NOME LIMPAR AVISO 
        void TextNameEditLeave(RJTextBox name_edit)
        {
            name_edit.BorderColor = Color.Transparent;
            name_edit.BorderSize = 0;
        }

        // LOGICA EDITAR NOME DO MEMBRO DA FAMILIA
        void EditName(bool edit, Label name, RJTextBox name_edit, Button delete, Button save, Button cancel)
        {
            if (edit)
            {
                name.Visible = false;
                name_edit.Visible = true;

                delete.Visible = false;
                save.Visible = true;
                cancel.Visible = true;
                save.Location = new Point(277, 14);
                cancel.Location = new Point(405, 14);
            }
            else
            {
                name.Visible = true;
                name_edit.Visible = false;
                name_edit.Texts = string.Empty;

                name_edit.BorderColor = Color.Transparent;
                name_edit.BorderSize = 0;

                delete.Visible = true;
                save.Visible = false;
                cancel.Visible = false;
            }
        }

        // NOME DUPLO CLICK 
        private void txt_name_01_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[0] = !_nameEdit[0], txt_name_01, txt_name_edit_01, bt_delete_01, bt_save_edit_01, bt_cancel_edit_01);
        }

        private void txt_name_02_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[1] = !_nameEdit[1], txt_name_02, txt_name_edit_02, bt_delete_02, bt_save_edit_02, bt_cancel_edit_02);
        }

        private void txt_name_03_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[2] = !_nameEdit[2], txt_name_03, txt_name_edit_03, bt_delete_03, bt_save_edit_03, bt_cancel_edit_03);
        }

        private void txt_name_04_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[3] = !_nameEdit[3], txt_name_04, txt_name_edit_04, bt_delete_04, bt_save_edit_04, bt_cancel_edit_04);
        }

        private void txt_name_05_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[4] = !_nameEdit[4], txt_name_05, txt_name_edit_05, bt_delete_05, bt_save_edit_05, bt_cancel_edit_05);
        }

        private void txt_name_06_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[5] = !_nameEdit[5], txt_name_06, txt_name_edit_06, bt_delete_06, bt_save_edit_06, bt_cancel_edit_06);
        }

        private void txt_name_07_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[6] = !_nameEdit[6], txt_name_07, txt_name_edit_07, bt_delete_07, bt_save_edit_07, bt_cancel_edit_07);
        }

        private void txt_name_08_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[7] = !_nameEdit[7], txt_name_08, txt_name_edit_08, bt_delete_08, bt_save_edit_08, bt_cancel_edit_08);
        }

        private void txt_name_09_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[8] = !_nameEdit[8], txt_name_09, txt_name_edit_09, bt_delete_09, bt_save_edit_09, bt_cancel_edit_09);
        }

        private void txt_name_10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditName(_nameEdit[9] = !_nameEdit[9], txt_name_10, txt_name_edit_10, bt_delete_10, bt_save_edit_10, bt_cancel_edit_10);
        }

        // NOME EDITATR LEAVE
        private void txt_name_edit_01_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_01);
        }

        private void txt_name_edit_02_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_02);
        }

        private void txt_name_edit_03_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_03);
        }

        private void txt_name_edit_04_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_04);
        }

        private void txt_name_edit_05_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_05);
        }

        private void txt_name_edit_06_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_06);
        }

        private void txt_name_edit_07_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_07);
        }

        private void txt_name_edit_08_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_08);
        }

        private void txt_name_edit_09_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_09);
        }

        private void txt_name_edit_10_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_name_edit_10);
        }

        private void txt_add_family_name_Leave(object sender, EventArgs e)
        {
            TextNameEditLeave(txt_add_family_name);
        }
        #endregion

        #region STARTING
        // PAINEL DOS MEMBROS DA FAMILIA
        void StartPanelFamily()
        {
            // PAINEIS 
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
            pl_table_member_family.Visible = false;

            // TEXTBOX EDITAR NOME DO MEMBRO
            TextEditName();
            ButtonEditName();
        }

        // TODOS OS TEXTBOX EDIT NOME DO MEMBRO DA FAMILIA
        void TextEditName()
        {
            RJTextBox[] textedit = { txt_name_edit_01, txt_name_edit_02, txt_name_edit_03, txt_name_edit_04, txt_name_edit_05, txt_name_edit_06, txt_name_edit_07, txt_name_edit_08, txt_name_edit_09, txt_name_edit_10 };

            // DESABILITA TODOS OS TEXTO BOX 
            for (int i = 0; i < textedit.Length; i++)
            {
                textedit[i].Visible = false;
            }            
        }

        void ButtonEditName()
        {
            Button[] bt = { bt_save_edit_01, bt_save_edit_02, bt_save_edit_03, bt_save_edit_04, bt_save_edit_05, bt_save_edit_06, bt_save_edit_07, bt_save_edit_08, bt_save_edit_09, bt_save_edit_10,
                bt_cancel_edit_01, bt_cancel_edit_02, bt_cancel_edit_03, bt_cancel_edit_04, bt_cancel_edit_05, bt_cancel_edit_06, bt_cancel_edit_07, bt_cancel_edit_08, bt_cancel_edit_09, bt_cancel_edit_10 };

            // DESABILITA TODOS OS TEXTO BOX 
            for (int i = 0; i < bt.Length; i++)
            {
                bt[i].Visible = false;
            }
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
        #endregion

        // VERIFICA SE EXISTE ALGUMA PAINEL VISIVEL SE NAO TIVER, MOSTRA O AVISO PARA ADD UM NOVO MEMBRO  
        void SearchPanels()
        {
            Panel[] panels = { pl_content_01, pl_content_02, pl_content_03, pl_content_04, pl_content_05, pl_content_06, pl_content_07, pl_content_08, pl_content_09, pl_content_10 };
            // VARIVALE PARA VERIFICAR 
            bool anyPanelVisible = false;
            // PROCURAR TABELAS
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

        private void family_Load(object sender, EventArgs e)
        {
            Main.Instance.ButtonMenuDisabled(true);            
            TableMain();
        }




    }
}
