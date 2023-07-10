using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Contas_Familia.PanelControll.Dashboard;
using Contas_Familia.PanelControll.Home;
using Contas_Familia.PanelControll.Settings;
using FontAwesome.Sharp;

namespace Contas_Familia.Window
{
    public partial class Main : Form
    {
        public static Main Instance;

        // MENU RECOLHER
        bool _menuCollapse;

        public Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Instance = this;

            try
            {
                new Login().ShowDialog();
            }
            finally
            {
                home uc = new home();
                addControll(uc);

                ButtonMenuDisabled(false);
            } 
        }

        public void addControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pl_mid.Controls.Clear();
            pl_mid.Controls.Add(userControl);
            userControl.BringToFront();
        }

        // BOTÕES JANELA
        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                MenuCollapse(_menuCollapse);
            }
            else
            {
                WindowState = FormWindowState.Normal;
                MenuCollapse(!_menuCollapse);
            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)
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

        // RECOLHER MENU LATERAL
        private void MenuCollapse(bool _collapse)
        {
            if (_collapse)
            {
                pl_left.Width = 60;
                bt_menu_collapse.IconChar = IconChar.AngleRight;

                foreach (Button menuButton in pl_left.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
            else
            {
                pl_left.Width = 210;
                bt_menu_collapse.IconChar = IconChar.AngleLeft;

                foreach (Button menuButton in pl_left.Controls.OfType<Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        // BOTÕES LATERAL
        private void bt_home_Click(object sender, EventArgs e) => Home();

        private void bt_dashboard_Click(object sender, EventArgs e) => Dashboard();

        private void bt_settings_Click(object sender, EventArgs e) => Setting();

        private void bt_settings_2_Click(object sender, EventArgs e) => Setting();

        private void bt_menu_collapse_Click(object sender, EventArgs e) => Menu_Collapse();

        private void Menu_Collapse() => MenuCollapse(_menuCollapse = !_menuCollapse);

        public void Home()
        {
            bt_home.BackColor = Color.FromArgb(48, 134, 200);
            bt_settings.BackColor = Color.FromArgb(27, 74, 111);

            home uc = new home();
            addControll(uc);
        }

        public void Dashboard()
        {
            bt_dashboard.BackColor = Color.FromArgb(48, 134, 200);
            bt_settings.BackColor = Color.FromArgb(27, 74, 111);

            dashboard uc = new dashboard();
            addControll(uc);
        }

        public void Setting()
        {
            bt_settings.BackColor = Color.FromArgb(48, 134, 200);

            bt_home.BackColor = Color.FromArgb(27, 74, 111);
            bt_dashboard.BackColor = Color.FromArgb(27, 74, 111);

            setting uc = new setting();
            addControll(uc);
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

        // DESATIVA O MENU HOME QUANDO EFETURAR UM CADASTRO OU SELECIONAR UMA NOVA FAMILIA
        public void ButtonMenuDisabled(bool menu)
        {
            if (!menu)
            {
                bt_dashboard.Visible = false;
                bt_home.Location = new Point(0, 100);
                bt_home.Visible = true;
            }
            else
            {
                bt_home.Visible = false;
                bt_dashboard.Visible = true;
            }
        }
    }
}
