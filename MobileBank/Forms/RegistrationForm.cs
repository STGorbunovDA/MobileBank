using MobileBank.Classes;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class RegistrationForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        void RegistrationForm_Load(object sender, System.EventArgs e)
        {
            txB_client_last_name.Select();
            cmb_client_gender.Text = cmb_client_gender.Items[0].ToString();
            txB_client_password.UseSystemPasswordChar = true;
            txB_client_password_replay.UseSystemPasswordChar = true;
        }

        void Btn_closeRegistrationForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
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

        void ChB_visibilityPassword_Click(object sender, System.EventArgs e)
        {
            if (chB_visibilityPassword.Checked)
            {
                txB_client_password.UseSystemPasswordChar = false;
                txB_client_password_replay.UseSystemPasswordChar = false;
            }
            else if (!chB_visibilityPassword.Checked)
            {
                txB_client_password.UseSystemPasswordChar = true;
                txB_client_password_replay.UseSystemPasswordChar = true;
            }
        }

        void Btn_clear_registrationForm_Click(object sender, System.EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        void txB_client_phone_number_Click(object sender, System.EventArgs e)
        {
            if(txB_client_phone_number.Text == "")
            {
                txB_client_phone_number.Text = "+79";
                txB_client_phone_number.SelectionStart = txB_client_phone_number.Text.Length;
            }
        }

        void TxB_client_phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == '+' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_client_phone_number_KeyUp(object sender, KeyEventArgs e)
        {
            ProcessKbdCtrlShortcuts(sender, e);
        }
        void ProcessKbdCtrlShortcuts(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox t = (TextBox)sender;
                if (e.KeyData == (Keys.C | Keys.Control))
                {
                    t.Copy();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.X | Keys.Control))
                {
                    t.Cut();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.V | Keys.Control))
                {
                    t.Paste();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.A | Keys.Control))
                {
                    t.SelectAll();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.Z | Keys.Control))
                {
                    t.Undo();
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка метода ctrl+c+v (ProcessKbdCtrlShortcuts)");
            }
        }

        void Btn_save_client_Click(object sender, System.EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            string caption = "Дата сохранения";
            if(!Regex.IsMatch(txB_client_last_name.Text, "[А-Яa-я]+$" ))
            {
                MessageBox.Show("Пожалуйста введите фамилию повторно!", caption, btn, ico);
                txB_client_last_name.Select();
                return;
            }
            if (!Regex.IsMatch(txB_client_first_name.Text, "[А-Яa-я]+$"))
            {
                MessageBox.Show("Пожалуйста введите имя повторно!", caption, btn, ico);
                txB_client_first_name.Select();
                return;
            }
            if (!Regex.IsMatch(txB_client_middle_name.Text, "[А-Яa-я]+$"))
            {
                MessageBox.Show("Пожалуйста введите отчество повторно!", caption, btn, ico);
                txB_client_middle_name.Select();
                return;
            }
        }
    }
}
