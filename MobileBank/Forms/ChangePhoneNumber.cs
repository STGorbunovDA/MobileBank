using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class ChangePhoneNumber : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ChangePhoneNumber()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            if (!FormClose.GetInstance.FClose())
                this.Close();
        }

        void ChangePhoneNumber_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void ChangePhoneNumber_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void ChangePhoneNumber_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void ChangePhoneNumber_Load(object sender, EventArgs e)
        {
            txB_client_phone_number.Select();
        }

        void Btn_ChangeNumberPhone_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Information;
                string caption = "Ошибка";

                if (!Regex.IsMatch(txB_client_phone_number.Text, "^[+][7][9][0-9]{9}$"))
                {
                    MessageBox.Show("Пожалуйста введите номер телефона корректно!", caption, btn, ico);
                    txB_client_phone_number.Select();
                    return;
                }
                var phoneNumber = txB_client_phone_number.Text;

                var changeNumberPhoneQuery = $"UPDATE client SET client_phone_number = '{phoneNumber}' WHERE id_client = '{DataStorage.idClient}'";
                using (MySqlCommand command = new MySqlCommand(changeNumberPhoneQuery, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Номер телефона изменен", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBaseConnection.GetInstance.CloseConnection();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Номер телефона не изменён", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Btn_ChangeNumberPhone_Click", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
