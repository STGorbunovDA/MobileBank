using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class ChangeEmail : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ChangeEmail()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ChangeEmail_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void ChangeEmail_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void ChangeEmail_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void ChangeEmail_Load(object sender, EventArgs e)
        {
            txb_client_email.Select();
        }

        private void Btn_ChangeEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Information;
                string caption = "Ошибка";

                if (!Regex.IsMatch(txb_client_email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    MessageBox.Show("Пожалуйста введите вашу почту", caption, btn, ico);
                    txb_client_email.Select();
                    return;
                }
                var clientEmail = txb_client_email.Text;

                var changeNumberPhoneQuery = $"UPDATE client SET client_email = '{clientEmail}' WHERE id_client = '{DataStorage.idClient}'";
                using (MySqlCommand command = new MySqlCommand(changeNumberPhoneQuery, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Почта изменена", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBaseConnection.GetInstance.CloseConnection();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Почта не изменёна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Btn_ChangeEmail_Click", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
