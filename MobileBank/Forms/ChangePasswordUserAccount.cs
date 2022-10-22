using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class ChangePasswordUserAccount : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ChangePasswordUserAccount()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ChangePasswordUserAccount_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void ChangePasswordUserAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void ChangePasswordUserAccount_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void Btn_ChangePasswordAccount_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Information;
                string caption = "Ошибка";

                if (!Regex.IsMatch(txB_client_password.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$^&*-]).{8,}$"))
                {
                    MessageBox.Show("Пожалуйста введите пароль!\n(Не менее 8-ми символов, без кириллицы, хотя-бы одна заглавная и с символами #?!@$^&*-)", caption, btn, ico);
                    txB_client_password.Select();
                    return;
                }
                if (!Regex.IsMatch(txB_client_password_old.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$^&*-]).{8,}$"))
                {
                    MessageBox.Show("Пожалуйста введите пароль!\n(Не менее 8-ми символов, без кириллицы, хотя-бы одна заглавная и с символами #?!@$^&*-)", caption, btn, ico);
                    txB_client_password.Select();
                    return;
                }

                if (SettingMethod.CheackUserPassword(txB_client_password_old.Text))
                {
                    var clientPassword = md5.hashPassword(txB_client_password.Text);

                    var changePasswordQuery = $"UPDATE client SET client_password = '{clientPassword}' WHERE id_client = '{DataStorage.idClient}'";
                    using (MySqlCommand command = new MySqlCommand(changePasswordQuery, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Пароль успешно изменен", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataBaseConnection.GetInstance.CloseConnection();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Пароль не изменён", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else MessageBox.Show("Старый пароль неверен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Btn_ChangePasswordAccount_Click", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ChB_visibilityPassword_Click(object sender, EventArgs e)
        {
            if (chB_visibilityPassword.Checked)
            {
                txB_client_password.UseSystemPasswordChar = false;
                txB_client_password_old.UseSystemPasswordChar = false;
            }
            else if (!chB_visibilityPassword.Checked)
            {
                txB_client_password.UseSystemPasswordChar = true;
                txB_client_password_old.UseSystemPasswordChar = true;
            }
        }

        void ChangePasswordUserAccount_Load(object sender, EventArgs e)
        {
            txB_client_password_old.Select();
        }
    }
}
