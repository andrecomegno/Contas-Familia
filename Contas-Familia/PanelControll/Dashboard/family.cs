using System;
using System.Collections.Generic;
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

        private string[] family_member = new string[10];

        // BOTÃO EDITAR
        private bool[] _edit = new bool[10];

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

            Panel[] panels = { pl_content_01, pl_content_02, pl_content_03, pl_content_04, pl_content_05, pl_content_06, pl_content_07, pl_content_08, pl_content_09, pl_content_10 };
            // TABELAS
            DataGridView[] dataGridViews = { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5,  dataGridView6, dataGridView7, dataGridView8, dataGridView9, dataGridView10 };
            // NOMES DOS MEMBROS DA FAMILIA
            Label[] lbNames = { lb_name_01, lb_name_02, lb_name_03, lb_name_04, lb_name_05, lb_name_06, lb_name_07, lb_name_08, lb_name_09, lb_name_10 };

            MySqlCommand cmd = new MySqlCommand("select rfm.id_register_family_member, rfm.family_member, cc.credit_card_name, cc.credit_card_payday, pr.store_name, pr.product_name, cc.credit_card_installment, tcc.total_payble, tcc.total_payable_installment, rf.id_register_family, cc.id_credit_card, pr.id_products from familypayday.login lo left join familypayday.register_family rf on rf.id_login = lo.id_login left join familypayday.register_family_member rfm on rfm.id_register_family = rf.id_register_family left join familypayday.products pr on pr.id_register_family_member = rfm.id_register_family_member left join familypayday.credit_card cc on cc.id_products = pr.id_products left join familypayday.total_credit_card tcc on tcc.id_credit_card = cc.id_credit_card where rfm.family_member like @family_member '%' ", database.getConnection());
            // UTILIZADO O lbNames[0].Text PADRÃO PARA INICIAR, A BUSCA PELO NOME DOS MEMBROS DA FAMILIA
            cmd.Parameters.AddWithValue("@family_member", lbNames[0].Text);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                int index = 0;
                while (dr.Read() && index < 10)
                {
                    id_register_family_member[index] = dr.GetInt32("id_register_family_member");
                    family_member[index] = dr.GetString("family_member");
                    index++;
                }
            }

            // LISTA PARA ARMANEZAR OS NOMES JA ATRIBUIDOS
            List<string> SaveNameList = new List<string>();

            // DATAGRIDVIEW NOME DO MEMBRO DA FAMILIA
            for (int i = 0; i < dataGridViews.Length; i++)
            {
                // VERIFICA SE O NOME JA FOI ATRIBUIDO
                if (i < family_member.Length && !SaveNameList.Contains(family_member[i]))
                {
                    lbNames[i].Text = family_member[i];

                    // Adiciona o nome à lista de nomes atribuídos
                    SaveNameList.Add(family_member[i]);
                }

                // DESATIVA E ATIVA OS PAINEIS 
                if (String.IsNullOrEmpty(lbNames[i].Text))
                {
                    panels[i].Visible = false;
                }
                else
                {
                    panels[i].Visible = true;
                }

                dataGridViews[i].DataSource = ExecuteQuery(lbNames[i].Text);
            }


            // CONFIGURAÇÃO DO DATAGRIDVIEW
            foreach (DataGridView dataGridView in dataGridViews)
            {
                ConfigureDataGridViewColumns(dataGridView);
            }

            database.closeConnection();
        }

        // EXECUTAR A CONSULTA E RETORNAR O DATATABLE
        private DataTable ExecuteQuery(string familyMemberName)
        {
            configdb database = new configdb();
            using (MySqlConnection connection = database.getConnection())
            {
                connection.Open();
                string query = "select rfm.id_register_family_member, rfm.family_member, cc.credit_card_name, cc.credit_card_payday, pr.store_name, pr.product_name, cc.credit_card_installment, tcc.total_payble, tcc.total_payable_installment, rf.id_register_family, cc.id_credit_card, pr.id_products from familypayday.login lo left join familypayday.register_family rf on rf.id_login = lo.id_login left join familypayday.register_family_member rfm on rfm.id_register_family = rf.id_register_family left join familypayday.products pr on pr.id_register_family_member = rfm.id_register_family_member left join familypayday.credit_card cc on cc.id_products = pr.id_products left join familypayday.total_credit_card tcc on tcc.id_credit_card = cc.id_credit_card where rfm.family_member like @family_member '%' ";

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
        private void ConfigureDataGridViewColumns(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "ID MEMBRO FAMILIA"; // id_register_family_member
            dataGridView.Columns[1].HeaderText = "NOME";
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

        // TABELA DELETAR MEMBRO DA FAMILIA
        void DeleteFamilyMembro(int id_member, Panel pl)
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM familypayday.register_family_member WHERE id_register_family_member = @id_register_family_member and id_register_family = @id_register_family", database.getConnection());
            cmd.Parameters.Add("@id_register_family_member", MySqlDbType.Int32).Value = id_member;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;

            cmd.ExecuteNonQuery();
            database.closeConnection();

            pl.Visible = false;
        }
        #endregion

        #region BUTTON TABELA MEMBER FAMILY
        private void bt_edit_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_cancel_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_delete_01_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[0], pl_content_01);
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
                PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);
            }
        }

        private void bt_save_01_Click(object sender, EventArgs e) => BT_Save(dataGridView1, id_register_family_member[0], lb_name_01.Text);

        private void bt_edit_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_cancel_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_delet_02_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[1], pl_content_02);
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
                PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);
            }
        }

        private void bt_save_02_Click(object sender, EventArgs e) => BT_Save(dataGridView2, id_register_family_member[1], lb_name_02.Text);

        private void bt_edit_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_cancel_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_delet_03_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[2], pl_content_03);
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
                PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);
            }
        }

        private void bt_edit_04_Click(object sender, EventArgs e) => PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);

        private void bt_cancel_04_Click(object sender, EventArgs e) => PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);

        private void bt_delet_04_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[3], pl_content_04);
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
                PanelContent(_edit[3] = !_edit[3], pl_content_04, bt_edit_04);
            }
        }

        private void bt_edit_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_cancel_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_delet_05_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[4], pl_content_05);
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
                PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);
            }
        }

        private void bt_edit_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_cancel_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_delet_06_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[5], pl_content_06);
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
                PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);
            }
        }

        private void bt_edit_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_cancel_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_delet_07_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[6], pl_content_07);
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
                PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);
            }
        }

        private void bt_edit_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_cancel_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_delet_08_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[7], pl_content_08);
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
                PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);
            }
        }

        private void bt_edit_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_cancel_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_delet_09_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[8], pl_content_09);
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
                PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);
            }
        }

        private void bt_edit_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_cancel_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_delet_10_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (dr)
                {
                    case DialogResult.Yes:
                        // MEMBRO FAMILIA DELETADO 
                        DeleteFamilyMembro(id_register_family_member[9], pl_content_10);
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
                PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);
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
                AddNewFamilyMember();
                MessageBox.Show("Saved successfully !", "Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // ATUALIZA OS PAINEL QUANDO CRIADO UM NOVO MEMBRO DA FAMILIA
                TableAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTERNAL ERROR: " + ex, "INTERNAL ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                ButtonAddFamilyName(bt_add, bt_save, bt_cancel, false);
                TextAddFamilyName(txt_add_family_name, false);
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
        }

        private void family_Load(object sender, EventArgs e)
        {
            Main.Instance.ButtonMenuDisabled(true);

            TableAll();
        }

    }
}
