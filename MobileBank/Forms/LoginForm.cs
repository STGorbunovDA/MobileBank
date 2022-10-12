using MobileBank.Classes;
using MobileBank.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MobileBank
{
    public partial class LoginForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        #region перетаскивание формы без бордера метод CyberDanger

        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[System.Runtime.InteropServices.DllImport("user32.dll")]

        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int IParam);

        //[System.Runtime.InteropServices.DllImport("user32.dll")]

        //public static extern bool ReleaseCapture();

        #endregion

        void LoginForm_Load(object sender, EventArgs e)
        {
            txB_enterPassword.UseSystemPasswordChar = true;
            txB_enterNumberPhone.Select();
        }

        void ChB_visibilityPassword_Click(object sender, EventArgs e)
        {
            if (chB_visibilityPassword.Checked)
            {
                txB_enterPassword.UseSystemPasswordChar = false;
            }
            else if (!chB_visibilityPassword.Checked)
                txB_enterPassword.UseSystemPasswordChar = true;
        }

        void LbL_CreateAccount_MouseEnter(object sender, EventArgs e)
        {
            lbL_CreateAccount.ForeColor = Color.GreenYellow;
        }

        void LbL_CreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lbL_CreateAccount.ForeColor = Color.White;
        }

        void Btn_closeLoginForm_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void LbL_CreateAccount_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        void Btn_EnterLoginForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (InternetСheck.CheackSkyNET())
                {
                    var loginUserPhone = txB_enterNumberPhone.Text;
                    var passUser = md5.hashPassword(txB_enterPassword.Text);

                    string querystring = $"SELECT id_client, client_phone_number, client_password FROM client WHERE client_phone_number = '{loginUserPhone}' AND client_password = '{passUser}'";

                    using (MySqlCommand command = new MySqlCommand(querystring, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count == 1)
                            { 
                                
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин и пароль");
                                DataBaseConnection.GetInstance.CloseConnection();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Системная ошибка авторизации!");
            }
        }
    }
}
