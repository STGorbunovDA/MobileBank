using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class RegistrationForm : Form
    {
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

        void Btn_close_Click(object sender, System.EventArgs e)
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
        void ChB_generatePassword_Click(object sender, System.EventArgs e)
        {
            if (chB_generatePassword.Checked)
            {
                string abc = "0123456789#?!@$^&*-qwertyuiopasdfghjklzxcvbnm0123456789#?!@$^&*-QWERTYUIOPASDFGHJKLZXCVBNM#?!@$^&*-0123456789"; //набор символов
                int kol = 9; // кол-во символов
                string result = "";

                Random rnd = new Random();
                int lng = abc.Length - 1;
                for (int i = 0; i < kol; i++)
                    result += abc[rnd.Next(lng)];
                txB_client_password.Text = result;
                txB_client_password_replay.Text = result;
            }
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
            txB_client_last_name.Select();
        }

        void txB_client_phone_number_Click(object sender, System.EventArgs e)
        {
            if (txB_client_phone_number.Text == "")
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
            try
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Information;

                string caption = "Дата сохранения";
                if (!Regex.IsMatch(txB_client_last_name.Text, "[А-Яa-я]+$"))
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
                if (string.IsNullOrEmpty(cmb_client_gender.SelectedItem.ToString()))
                {
                    MessageBox.Show("Пожалуйста выберите пол!", caption, btn, ico);
                    cmb_client_gender.Select();
                    return;
                }
                if (!Regex.IsMatch(txB_client_password.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$^&*-]).{8,}$"))
                {
                    MessageBox.Show("Пожалуйста введите пароль!\n(Не менее 8-ми символов, без кириллицы, хотя-бы одна заглавная и с символами #?!@$^&*-)", caption, btn, ico);
                    txB_client_middle_name.Select();
                    return;
                }
                if (!Regex.IsMatch(txB_client_password_replay.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$^&*-]).{8,}$"))
                {
                    MessageBox.Show("Пожалуйста введите пароль!\n(Не менее 8-ми символов, без кириллицы, хотя-бы одна заглавная и с символами #?!@$^&*-)", caption, btn, ico);
                    txB_client_password_replay.Select();
                    return;
                }
                if (txB_client_password.Text != txB_client_password_replay.Text)
                {
                    MessageBox.Show("Ваш пароль и пароль подтверждения не совпадают!", caption, btn, ico);
                    txB_client_password_replay.Select();
                    return;
                }
                if (!Regex.IsMatch(txb_client_email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    MessageBox.Show("Пожалуйста введите вашу почту", caption, btn, ico);
                    txB_client_password_replay.Select();
                    return;
                }
                if (!Regex.IsMatch(txB_client_phone_number.Text, "^[+][7][9][0-9]"))
                {
                    MessageBox.Show("Пожалуйста введите номер телефона коректно!", caption, btn, ico);
                    txB_client_phone_number.Select();
                    return;
                }
                if (InternetСheck.CheackSkyNET())
                {
                    if (!SettingMethod.CheackUser(txB_client_phone_number.Text))
                    {
                        DialogResult result = MessageBox.Show("Вы хотите сохранить запись?", "Сохранение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var passUser = md5.hashPassword(txB_client_password.Text);
                            string MySqlRequest = $"INSERT INTO client (client_last_name, client_first_name, client_middle_name, client_gender," +
                                $"client_password, client_email, client_phone_number) VALUES ('{txB_client_last_name.Text}', '{txB_client_first_name.Text}'," +
                                $"'{txB_client_middle_name.Text}', '{cmb_client_gender.Text}', '{passUser}', '{txb_client_email.Text}'," +
                                $"'{txB_client_phone_number.Text}')";
                            DataBaseConnection.GetInstance.OpenConnection();
                            using (MySqlCommand commandAddNewUser = new MySqlCommand(MySqlRequest, DataBaseConnection.GetInstance.GetConnection()))
                            {
                                if (commandAddNewUser.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Запись успешно сохранена", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Btn_clear_registrationForm_Click(sender, e);
                                    DataBaseConnection.GetInstance.CloseConnection();
                                    this.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Номер телефона уже существует. Невозможно зарегистрировать аккаунт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txB_client_phone_number.SelectAll();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Btn_save_client_Click", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
