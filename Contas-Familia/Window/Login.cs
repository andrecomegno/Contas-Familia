using Contas_Familia.Script;
using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Contas_Familia
{
    public partial class Login : Form
    {
        public static Login Instance;
        public string id_login;
        public string name;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            Instance = this;
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            ButtonEnter();
        }

        void ButtonEnter()
        {
            try
            {
                // BANCO DE DADOS
                configdb database = new configdb();
                database.openConnection();

                // SELECT TABELA LOGIN
                MySqlCommand objCmdLogin = new MySqlCommand("select id_login, name, password from familypayday.login where name=@name and password=@password ", database.getConnection());
                objCmdLogin.Parameters.AddWithValue("@name", txt_name.Texts);
                objCmdLogin.Parameters.AddWithValue("@password", txt_password.Texts);

                var login = objCmdLogin.ExecuteScalar();

                if (login != null)
                {
                    // COLETA O ID LOGADO
                    MySqlDataReader dr = objCmdLogin.ExecuteReader();
                    while (dr.Read())
                    {
                        id_login = dr["id_login"].ToString();
                        name = dr["name"].ToString();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("User or Password not found !", "Failed !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTERNAL ERROR: " + ex, "INTERNAL ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
               // limpar
            }
        }


        // BOTÃO TOPO
        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //DROG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pl_top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
