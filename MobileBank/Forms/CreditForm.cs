using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class CreditForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        Random rand = new Random();
        Validations validations = new Validations();

        public CreditForm()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            StartPosition = FormStartPosition.CenterScreen;
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CreditForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void CreditForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void CreditForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void CreditForm_Load(object sender, EventArgs e)
        {
            try
            {
                txB_sumCredit.Text = trB_sumCredit.Value.ToString();
                txB_monthsCredit.Text = trB_monthsCredit.Value.ToString();
                panel_arrangeCredit.Visible = false;
                btn_TransferHelpChildrenPayments.Visible = false;

                var totalSum = "";
                var sum = "";
                DateTime dateTime = new DateTime();
                var idCredit = "";

                double creditTotalSumToCheack = 0;
                double creditSumToCheack = 0;

                var queryCheckCreditStatus = $"SELECT credit_total_sum, credit_sum FROM credits WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{DataStorage.cardNumberUser}')";

                using (MySqlCommand command = new MySqlCommand(queryCheckCreditStatus, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            creditTotalSumToCheack = Convert.ToDouble(reader[0]);
                            creditSumToCheack = Convert.ToDouble(reader[1]);
                        }
                        reader.Close();
                    }
                    DataBaseConnection.GetInstance.CloseConnection();
                }

                if (creditTotalSumToCheack == 0)
                {
                    this.Width = 545;
                    this.Height = 242;
                    btn_TransferHelpChildrenPayments.Visible = false;
                    panel_arrangeCredit.Visible = false;
                    pictureBox7.Location = new Point(12, 10);
                    pictureBox7.Size = new Size(32, 32);
                    btn_close.Location = new Point(509, 10);
                }
                else
                {
                    this.Width = 380;
                    this.Height = 308;
                    panel_arrangeCredit_2.Visible = false;
                    btn_TransferHelpChildrenPayments.Visible = true;
                    panel_arrangeCredit.Visible = true;
                    btn_close.Location = new Point(347, 10);
                    pictureBox7.Size = new Size(32, 32);
                    pictureBox7.Location = new Point(12, 10);
                }

                if (creditSumToCheack >= creditTotalSumToCheack)
                {
                    var queryDeleteCredits = $"DELETE FROM credits WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{DataStorage.cardNumberUser}')";

                    using (MySqlCommand command = new MySqlCommand(queryDeleteCredits, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки формы кредита (CreditForm_Load)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            

        }
    }
}
