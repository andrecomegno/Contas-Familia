using Contas_Familia.Script;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Contas_Familia
{
    public partial class Login : Form
    {
        public static Login Instance;
        public int id_login;
        public string userName;

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
                MySqlCommand objCmdLogin = new MySqlCommand("select id_login, username, password from familypayday.login where username=@username and password=@password ", database.getConnection());
                objCmdLogin.Parameters.AddWithValue("@username", txt_name.Texts);
                objCmdLogin.Parameters.AddWithValue("@password", txt_password.Texts);

                var login = objCmdLogin.ExecuteScalar();

                if (String.IsNullOrEmpty(txt_name.Texts))
                {
                    txt_name.BorderColor = Color.Red;
                    txt_name.BorderSize = 3;
                }
                else if (String.IsNullOrEmpty(txt_password.Texts))
                {
                    txt_password.BorderColor = Color.Red;
                    txt_password.BorderSize = 3;
                }
                else
                {
                    if (login != null)
                    {
                        // COLETA O ID LOGADO
                        MySqlDataReader dr = objCmdLogin.ExecuteReader();
                        while (dr.Read())
                        {
                            id_login = dr.GetInt32("id_login");
                            userName = dr.GetString("username");
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User or Password not found !", "Failed !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTERNAL ERROR: " + ex, "INTERNAL ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txt_name.Texts = string.Empty;
                txt_password.Texts = string.Empty;
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

        #region CLEAN NOTIFICATION TEXTOBOX
        private void txt_name_Leave(object sender, EventArgs e)
        {
            txt_name.BorderColor = Color.Transparent;
            txt_name.BorderSize = 0;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            txt_password.BorderColor = Color.Transparent;
            txt_password.BorderSize = 0;
        }
        #endregion

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
