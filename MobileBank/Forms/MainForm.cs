using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileBank.Classes;
using MySql.Data.MySqlClient;

namespace MobileBank.Forms
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();
        }
        void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void Btn_closeLoginForm_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (InternetСheck.CheackSkyNET())
                    SettingMethod.CourseCurrency(lbL_сourse_euro, lbL_сourse_dollar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки курсы валют с сайта Центробанка", "Системная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (InternetСheck.CheackSkyNET())
                {
                    string querystring = $"SELECT bank_card_number FROM bank_card WHERE id_client = {DataStorage.idClient}";
                    using (MySqlCommand command = new MySqlCommand(querystring, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        DataTable card_number = new DataTable();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(card_number);
                            if (card_number.Rows.Count > 0)
                            {
                                cmb_card_number.DataSource = card_number;
                                cmb_card_number.DisplayMember = "bank_card_number";
                            }
                            else
                            {
                                cmb_card_number.Text = "У Вас отсутсвуют банковские карты";
                            }
                            DataBaseConnection.GetInstance.CloseConnection();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки номера банковской карты клиента", "Системная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Btn_adding_card_Click(object sender, EventArgs e)
        {
            AddBankCard addBankCard = new AddBankCard();
            if (Application.OpenForms["AddBankCard"] == null)
            {
                addBankCard.Show();
            }
        }
    }
}
