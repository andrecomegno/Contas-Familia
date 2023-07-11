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
        private int id_register_family = list_family.Instance.select_id_register_family;

        // NOME DOS MEMBROS DA FAMILIA, E OS ID`S
        private int[] id_family_member = new int[10];
        private string[] family_member = new string[10];        

        // BOTÃO EDITAR
        private bool[] _edit = new bool[10];

        public family()
        {
            InitializeComponent();
            StartPanelFamily();            
        }

        #region TABLES
        // TODAS AS TABELAS DOS MEMBROS, ATRIBUIDAS COM OS SEUS SEGUINTES NOMES REGISTRADOS
        private void TableAll()
        { 
            // TABELAS
            DataGridView[] dataGridViews = { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5,  dataGridView6, dataGridView7, dataGridView8, dataGridView9, dataGridView10 };
            // NOMES DOS MEMBROS DA FAMILIA
            string[] lbNames = { lb_name_01.Text, lb_name_02.Text, lb_name_03.Text, lb_name_04.Text, lb_name_05.Text, lb_name_06.Text, lb_name_07.Text, lb_name_08.Text, lb_name_09.Text, lb_name_10.Text };

            // DATAGRIDVIEW NOME DO MEMBRO DA FAMILIA
            for (int i = 0; i < dataGridViews.Length; i++)
            {
                dataGridViews[i].DataSource = ExecuteQuery(lbNames[i]);
            }

            // CONFIGURAÇÃO DO DATAGRIDVIEW
            foreach (DataGridView dataGridView in dataGridViews)
            {
                ConfigureDataGridViewColumns(dataGridView);
            }
        }

        // EXECUTAR A CONSULTA E RETORNAR O DATATABLE
        private DataTable ExecuteQuery(string familyMemberName)
        {
            configdb database = new configdb();
            using (MySqlConnection connection = database.getConnection())
            {
                connection.Open();
                string query = "select fm.id_family_member, rf.id_register_family, cc.id_credit_card, pr.id_products, cc.credit_card_name, cc.credit_card_pay_day, pr.store_name, pr.product_name, cc.credit_card_installment, tcc.total_payble, tcc.total_payable_installment from familypayday.register_family rf left join familypayday.family_member fm on fm.id_register_family = rf.id_register_family left join familypayday.total_credit_card tcc on tcc.id_total_credit_card = tcc.id_total_credit_card left join familypayday.credit_card cc on cc.id_total_credit_card = tcc.id_total_credit_card left join familypayday.products pr on pr.id_credit_card = cc.id_credit_card where fm.family_member like @family_member '%';";

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
            dataGridView.Columns[0].Visible = false; // id_family_member
            dataGridView.Columns[1].Visible = false; // id_register_family
            dataGridView.Columns[2].Visible = false; // id_credit_card
            dataGridView.Columns[3].Visible = false; // id_products
            dataGridView.Columns[4].HeaderText = "CARTÕES";
            dataGridView.Columns[5].HeaderText = "VENCIMENTO";
            dataGridView.Columns[6].HeaderText = "LOJAS";
            dataGridView.Columns[7].HeaderText = "PRODUTOS";
            dataGridView.Columns[8].HeaderText = "PARCELAMENTO";
            dataGridView.Columns[9].HeaderText = "VALOR TOTAL";
            dataGridView.Columns[10].HeaderText = "VALOR PARCELADO";
        }

        // TABELA DOS MEMBROS DA FAMILIA
        void TableFamilyMember()
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("select ID_FAMILY_MEMBER, FAMILY_MEMBER, ID_REGISTER_FAMILY from familypayday.family_member where id_register_family = @id_register_family ", database.getConnection());
            cmd.Parameters.AddWithValue("@id_register_family", id_register_family);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                int index = 0;
                while (dr.Read() && index < 10)
                {
                    id_family_member[index] = dr.GetInt32("id_family_member");
                    family_member[index] = dr.GetString("family_member");
                    index++;
                }               
            }

            DataTextBox();
            database.closeConnection();            
        }

        // ATRIBUI OS NOMES DE CADA MEMBRO DA FAMILIA AO TEXTOBOX, E DESABILITA O PANEL DAQUELES QUE ESTAO SEM NOME
        void DataTextBox()
        {
            Panel[] panels = { pl_content_01, pl_content_02, pl_content_03, pl_content_04, pl_content_05, pl_content_06, pl_content_07, pl_content_08, pl_content_09, pl_content_10 };
            // NOME DOS MEMBROS DA FAMILIA
            Label[] labels = { lb_name_01, lb_name_02, lb_name_03, lb_name_04, lb_name_05, lb_name_06, lb_name_07, lb_name_08, lb_name_09, lb_name_10 };
            // CONTA OS MEMBROS DA FAMILIA
            int numLabels = labels.Length;

            for (int i = 0; i < numLabels; i++)
            {
                // ATRIBUI OS NOMES 
                if (i < family_member.Length)
                {
                    labels[i].Text = family_member[i];
                }

                // DESATIVA E ATIVA OS PAINEIS 
                if (String.IsNullOrEmpty(labels[i].Text))
                {
                    panels[i].Visible = false;
                }
                else
                {
                    panels[i].Visible = true;
                }
            }
        }

        // TABELA NOVO MEMBRO DA FAMILIA
        void AddNewFamilyMember()
        {
            configdb database = new configdb();
            database.openConnection();

            // ADD NOVO MEMBRO DA FAMILIA
            MySqlCommand cmd = new MySqlCommand("INSERT INTO familypayday.family_member (id_family_member, family_member, id_register_family) VALUES (null, @family_member, @id_register_family)", database.getConnection());
            cmd.Parameters.Add("@family_member", MySqlDbType.VarChar, 45).Value = txt_add_family_name.Texts;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;

            cmd.ExecuteNonQuery();
            database.closeConnection();
        }

        // TABELA DELETAR MEMBRO DA FAMILIA
        void DeleteFamilyMembro(int id_member)
        {
            configdb database = new configdb();
            database.openConnection();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM familypayday.family_member WHERE id_family_member = @id_family_member and id_register_family = @id_register_family", database.getConnection());
            cmd.Parameters.Add("@id_family_member", MySqlDbType.Int32).Value = id_member;
            cmd.Parameters.Add("@id_register_family", MySqlDbType.Int32).Value = id_register_family;

            cmd.ExecuteNonQuery();
            database.closeConnection();            
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

        #region BUTTON TABELA MEMBER FAMILY
        private void bt_edit_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_cancel_01_Click(object sender, EventArgs e) => PanelContent(_edit[0] = !_edit[0], pl_content_01, bt_edit_01);

        private void bt_delet_01_Click(object sender, EventArgs e)
        {
            try
            {
                // MEMBRO FAMILIA DELETADO 
                DeleteFamilyMembro(id_family_member[0]);
                // DESATIVA O PAINEL
                pl_content_01.Visible = false;
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

        private void bt_edit_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_cancel_02_Click(object sender, EventArgs e) => PanelContent(_edit[1] = !_edit[1], pl_content_02, bt_edit_02);

        private void bt_delet_02_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteFamilyMembro(id_family_member[1]);
                pl_content_02.Visible = false;
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

        private void bt_edit_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_cancel_03_Click(object sender, EventArgs e) => PanelContent(_edit[2] = !_edit[2], pl_content_03, bt_edit_03);

        private void bt_delet_03_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteFamilyMembro(id_family_member[2]);
                pl_content_03.Visible = false;
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
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_cancel_05_Click(object sender, EventArgs e) => PanelContent(_edit[4] = !_edit[4], pl_content_05, bt_edit_05);

        private void bt_delet_05_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_cancel_06_Click(object sender, EventArgs e) => PanelContent(_edit[5] = !_edit[5], pl_content_06, bt_edit_06);

        private void bt_delet_06_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_cancel_07_Click(object sender, EventArgs e) => PanelContent(_edit[6] = !_edit[6], pl_content_07, bt_edit_07);

        private void bt_delet_07_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_cancel_08_Click(object sender, EventArgs e) => PanelContent(_edit[7] = !_edit[7], pl_content_08, bt_edit_08);

        private void bt_delet_08_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_cancel_09_Click(object sender, EventArgs e) => PanelContent(_edit[8] = !_edit[8], pl_content_09, bt_edit_09);

        private void bt_delet_09_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
        }

        private void bt_edit_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_cancel_10_Click(object sender, EventArgs e) => PanelContent(_edit[9] = !_edit[9], pl_content_10, bt_edit_10);

        private void bt_delet_10_Click(object sender, EventArgs e)
        {
            // DETELAR MEMBRO DA FAMILIA
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
                TableFamilyMember();
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
            TableFamilyMember();
        }
    }
}
