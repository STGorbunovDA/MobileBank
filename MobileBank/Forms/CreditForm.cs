using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
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
                DateTime dateRegistration = new DateTime();
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

                    if (creditSumToCheack >= creditTotalSumToCheack)
                    {
                        var queryDeleteCredits = $"DELETE FROM credits WHERE id_bank_card = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{DataStorage.cardNumberUser}')";

                        using (MySqlCommand command = new MySqlCommand(queryDeleteCredits, DataBaseConnection.GetInstance.GetConnection()))
                        {
                            DataBaseConnection.GetInstance.OpenConnection();
                            command.ExecuteNonQuery();
                            DataBaseConnection.GetInstance.CloseConnection();
                        }
                    }
                    var querySelectIdCard = $"SELECT credits.id_bank_card, credits.credit_total_sum, credits.credit_sum, credits.credit_date, " +
                        $"credits.id_credit FROM credits INNER JOIN bank_card on credits.id_bank_card = bank_card.id_bank_card WHERE " +
                        $"bank_card.bank_card_number = '{DataStorage.cardNumberUser}'";

                    using (MySqlCommand command = new MySqlCommand(querySelectIdCard, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalSum = reader[1].ToString();
                                sum = reader[2].ToString();
                                dateRegistration = Convert.ToDateTime(reader[3].ToString());
                                idCredit = reader[4].ToString();

                            }
                            reader.Close();
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }

                    lbL_sum.Text = Math.Round(Convert.ToDouble(sum), 2).ToString();
                    lbL_totalSum.Text = Math.Round(Convert.ToDouble(totalSum), 2).ToString();
                    lbL_dateRegistration.Text = dateRegistration.ToShortDateString();

                    double toPaySum = 0;

                    DateTime repaymentDate = new DateTime();
                    var querySelectRepayment = $"SELECT repayment_date, repayment_sum FROM credits WHERE id_credit = '{idCredit}'";

                    using (MySqlCommand command = new MySqlCommand(querySelectRepayment, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                repaymentDate = Convert.ToDateTime(reader[0].ToString());
                                toPaySum = Convert.ToDouble(reader[1].ToString());
                            }
                            reader.Close();
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }
                    lbL_repaymentSum.Text = Math.Round(toPaySum, 2).ToString();
                    lbL_repaymentDate.Text = repaymentDate.ToShortDateString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки формы кредита (CreditForm_Load)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        void TxB_sumCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }

        }

        void TxB_monthsCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }

        }

        void CalculatorCredit()
        {
            try
            {
                if (txB_sumCredit.Text != "0" && !String.IsNullOrEmpty(txB_sumCredit.Text) && !String.IsNullOrEmpty(txB_monthsCredit.Text)
                    && Convert.ToInt32(txB_monthsCredit.Text) < 61 && Convert.ToInt32(txB_sumCredit.Text) < 1000000)
                {
                    double mothlyRate = 0.01;
                    double sum = Convert.ToDouble(txB_sumCredit.Text);
                    double result = 0;
                    int numberOfMonths = Convert.ToInt32(txB_monthsCredit.Text);

                    if (numberOfMonths <= 10)
                        result = sum * (mothlyRate + (mothlyRate / (Math.Pow(1 + mothlyRate, numberOfMonths) - 1)));
                    else if (numberOfMonths > 10)
                        result = sum * ((mothlyRate - 0.003) + (mothlyRate / (Math.Pow(1 + mothlyRate, numberOfMonths) - 1)));
                    else if (numberOfMonths > 20)
                        result = sum * ((mothlyRate - 0.004) + (mothlyRate / (Math.Pow(1 + mothlyRate, numberOfMonths) - 1)));
                    else if (numberOfMonths > 30)
                        result = sum * ((mothlyRate - 0.005) + (mothlyRate / (Math.Pow(1 + mothlyRate, numberOfMonths) - 1)));
                    else if (numberOfMonths > 40)
                        result = sum * ((mothlyRate - 0.006) + (mothlyRate / (Math.Pow(1 + mothlyRate, numberOfMonths) - 1)));
                    else if (numberOfMonths > 50)
                        result = sum * ((mothlyRate - 0.007) + (mothlyRate / (Math.Pow(1 + mothlyRate, numberOfMonths) - 1)));

                    lbL_sumCredit.Text = Math.Round(result, 2).ToString();
                    var podschet = (Convert.ToDouble(txB_monthsCredit.Text) * Convert.ToDouble(lbL_sumCredit.Text) - Convert.ToDouble(txB_sumCredit.Text)) / Convert.ToDouble(txB_sumCredit.Text) * 100;
                    lbL_percentCredit.Text = Math.Round(podschet, 2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void TrB_sumCredit_Scroll(object sender, EventArgs e)
        {
            txB_sumCredit.Text = trB_sumCredit.Value.ToString();
            CalculatorCredit();
        }

        void TrB_monthsCredit_Scroll(object sender, EventArgs e)
        {
            txB_monthsCredit.Text = trB_monthsCredit.Value.ToString();
            CalculatorCredit();
        }

        void TxB_sumCredit_Click(object sender, EventArgs e)
        {
            if (txB_sumCredit.Text != "0" && !String.IsNullOrEmpty(txB_sumCredit.Text) && !String.IsNullOrEmpty(txB_monthsCredit.Text)
                && Convert.ToInt32(txB_sumCredit.Text) < 1000000)
                trB_sumCredit.Value = Convert.ToInt32(txB_sumCredit.Text);
            CalculatorCredit();
        }

        void TxB_monthsCredit_Click(object sender, EventArgs e)
        {
            if (txB_monthsCredit.Text != "0" && !String.IsNullOrEmpty(txB_sumCredit.Text) && !String.IsNullOrEmpty(txB_monthsCredit.Text)
                && Convert.ToInt32(txB_monthsCredit.Text) < 60)
                trB_monthsCredit.Value = Convert.ToInt32(txB_monthsCredit.Text);
            CalculatorCredit();
        }

        void Btn_arrangeCredit_Click(object sender, EventArgs e)
        {
            if (txB_monthsCredit.Text != "0" && !String.IsNullOrEmpty(txB_sumCredit.Text) && !String.IsNullOrEmpty(txB_monthsCredit.Text)
                && Convert.ToInt32(txB_monthsCredit.Text) < 60 && Convert.ToInt32(txB_sumCredit.Text) < 1000000)
            {
                trB_sumCredit.Value = Convert.ToInt32(txB_sumCredit.Text);
                trB_monthsCredit.Value = Convert.ToInt32(txB_monthsCredit.Text);
                CalculatorCredit();

                validations.ShowDialog();

                if (DataStorage.attemptsPin < 3)
                {
                    var idCredits = "";
                    var querySelectId = $"SELECT id_credit FROM credits WHERE id_bank_card =  (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{DataStorage.cardNumberUser}')";
                    using (MySqlCommand command = new MySqlCommand(querySelectId, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idCredits = reader[0].ToString();
                            }
                            reader.Close();
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }
                    if (String.IsNullOrEmpty(idCredits))
                    {
                        var totalSum = Convert.ToDouble(lbL_sumCredit.Text) * Convert.ToDouble(txB_monthsCredit.Text);
                        

                        DateTime dateTime = DateTime.Now;
                        var dateTimeNow = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

                        DateTime creditDateTime = dateTime.AddMonths(1);
                        var repaymentDate = creditDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                        var repaymentSum = lbL_sumCredit.Text;

                        var queryCredit = $"INSERT INTO credits(credit_total_sum, credit_sum, credit_date, credit_status, repayment_date, repayment_sum, id_bank_card) VALUES ('{totalSum}'," +
                        $"'0', '{dateTimeNow}', '0', '{repaymentDate}', '{repaymentSum}', (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{DataStorage.cardNumberUser}'))";

                        using (MySqlCommand command = new MySqlCommand(queryCredit, DataBaseConnection.GetInstance.GetConnection()))
                        {
                            DataBaseConnection.GetInstance.OpenConnection();
                            command.ExecuteNonQuery();
                            DataBaseConnection.GetInstance.CloseConnection();
                        }
                        var sumCard = txB_sumCredit.Text;
                        var queryEnrollmentCardCredit = $"UPDATE bank_card SET bank_card_balance = bank_card_balance + '{sumCard}' WHERE bank_card_number = '{DataStorage.cardNumberUser}'";
                        
                        using (MySqlCommand command = new MySqlCommand(queryEnrollmentCardCredit, DataBaseConnection.GetInstance.GetConnection()))
                        {
                            DataBaseConnection.GetInstance.OpenConnection();
                            command.ExecuteNonQuery();
                            DataBaseConnection.GetInstance.CloseConnection();
                        }
                        MessageBox.Show("Кредит оформлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("У вас уже есть кредит", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else MessageBox.Show("Некорректный ввод параметров кредитования", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        void TxB_monthsCredit_TextChanged(object sender, EventArgs e)
        {
            if (txB_monthsCredit.Text != "0" && !String.IsNullOrEmpty(txB_sumCredit.Text) && !String.IsNullOrEmpty(txB_monthsCredit.Text)
                 && Convert.ToInt32(txB_monthsCredit.Text) < 61)
                trB_monthsCredit.Value = Convert.ToInt32(txB_monthsCredit.Text);
            CalculatorCredit();
        }

        void TxB_sumCredit_TextChanged(object sender, EventArgs e)
        {
            if (txB_sumCredit.Text != "0" && !String.IsNullOrEmpty(txB_sumCredit.Text) && !String.IsNullOrEmpty(txB_monthsCredit.Text)
                && Convert.ToInt32(txB_sumCredit.Text) < 1000000)
                trB_sumCredit.Value = Convert.ToInt32(txB_sumCredit.Text);
            CalculatorCredit();
        }

        void Btn_TransferHelpChildrenPayments_Click(object sender, EventArgs e)
        {

        }
    }
}
