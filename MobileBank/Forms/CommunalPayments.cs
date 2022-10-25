using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class CommunalPayments : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        Random rand = new Random();

        public CommunalPayments()
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

        void CommunalPayments_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void CommunalPayments_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void CommunalPayments_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void CommunalPayments_Load(object sender, EventArgs e)
        {
            txB_card_numberUser.Text = "";
            int tmp = 0;
            int tmp1 = 4;
            for (int m = 0; m < 4; m++)
            {
                for (int n = tmp; n < tmp1; n++)
                {
                    txB_card_numberUser.Text += DataStorage.cardNumberUser[n].ToString();
                }
                txB_card_numberUser.Text += " ";
                tmp += 4;
                tmp1 += 4;
            }

            lbL_currency.Text = DataStorage.currency;
            txB_card_numberUser.Text = txB_card_numberUser.Text.Trim();
            txB_cardDate.Text = DataStorage.cardDate;
            txB_cardCvv.Text = "";
            txB_personalAccountCommunalPayments.Select();

            SettingMethod.Loading_servicesCommunalPayments_cmd(cmb_servicesCommunalPayments);
        }

        void TxB_sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_personalAccountCommunalPayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void Btn_TransferCommunalPayments_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Information;

                string caption = "Отмена. Невозможно осуществить перевод средств";
                if (!String.IsNullOrEmpty(txB_sum.Text))
                {
                    if (txB_cardCvv.Text != "")
                    {
                        if (txB_personalAccountCommunalPayments.Text != "")
                        {
                            if (DataStorage.cardCVV != txB_cardCvv.Text)
                            {
                                MessageBox.Show("Вы ввели не корректный CVV-код", caption, btn, ico);
                                if (DataStorage.attemptsCVV < 3)
                                    DataStorage.attemptsCVV++;
                                else
                                {
                                    MessageBox.Show("Вы ввели неверный CVV-код более трёх раз", caption, btn, ico);
                                    this.Close();
                                }
                                txB_cardCvv.Select();
                                return;
                            }
                            if (DataStorage.cardDate != txB_cardDate.Text)
                            {
                                MessageBox.Show("Вы ввели не корректный дату Вашей карты", caption, btn, ico);
                                txB_cardCvv.Select();
                                return;
                            }
                            var reg = new Regex(" ");
                            var cardNumberUser = reg.Replace(txB_card_numberUser.Text, "");

                            if (DataStorage.cardNumberUser != cardNumberUser)
                            {
                                MessageBox.Show("Вы ввели не корректный номер Вашей карты", caption, btn, ico);
                                txB_cardCvv.Select();
                                return;
                            }
                            if (DataStorage.currency == "RUB")
                            {
                                if (Convert.ToDouble(txB_sum.Text) < 49.00)
                                {
                                    MessageBox.Show("Сумма перевода должна быть не меньше 50 RUB", caption, btn, ico);
                                    txB_sum.Select();
                                    return;
                                }
                            }
                            if (DataStorage.currency == "USD")
                            {
                                if (Convert.ToDouble(txB_sum.Text) < 1.00)
                                {
                                    MessageBox.Show("Сумма перевода должна быть не меньше 1 USD", caption, btn, ico);
                                    txB_sum.Select();
                                    return;
                                }
                            }
                            if (DataStorage.currency == "EUR")
                            {
                                if (Convert.ToDouble(txB_sum.Text) < 1.00)
                                {
                                    MessageBox.Show("Сумма перевода должна быть не меньше 1 EUR", caption, btn, ico);
                                    txB_sum.Select();
                                    return;
                                }
                            }
                            if (Convert.ToDouble(DataStorage.balanceCard) < Convert.ToDouble(txB_sum.Text))
                            {
                                MessageBox.Show($"Недостаточно денег на Вашем счёте: \"{DataStorage.balanceCard}\"", caption, btn, ico);
                                txB_sum.Select();
                                return;
                            }
                            var reg2 = new Regex(",");
                            double dollar = Convert.ToDouble(reg2.Replace(DataStorage.dollar.ToString(), "."));
                            double euro = Convert.ToDouble(reg2.Replace(DataStorage.euro.ToString(), "."));

                            var reg3 = new Regex(" ");
                            var card_numberUser = reg3.Replace(txB_card_numberUser.Text, "");

                            string totalSum = txB_sum.Text;
                            var cardCurrencyUser = DataStorage.currency;

                            Validations validations = new Validations();
                            validations.ShowDialog();

                            if (DataStorage.attemptsPin < 3)
                            {
                                if (InternetСheck.CheackSkyNET())
                                {
                                    #region для пополнения в рублях
                                    //var replenishmentRUB = "";
                                    //if (cardCurrencyUser == "RUB")
                                    //{
                                    //    replenishmentRUB = totalSum;
                                    //}
                                    //if(cardCurrencyUser == "USD")
                                    //{
                                    //    replenishmentRUB = (Convert.ToDouble(totalSum) * Convert.ToDouble(dollar)).ToString();
                                    //}
                                    //if (cardCurrencyUser == "EUR")
                                    //{
                                    //    replenishmentRUB = (Convert.ToDouble(totalSum) * Convert.ToDouble(euro)).ToString();
                                    //}
                                    #endregion

                                    DateTime transactionDate = DateTime.Now;
                                    var transactionDateMobile = transactionDate.ToString("yyyy-MM-dd HH:mm:ss");
                                    var transactionNumber = "C";

                                    for (int i = 0; i < 10; i++)
                                    {
                                        transactionNumber += Convert.ToString(rand.Next(0, 10));
                                    }
                                    var queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{totalSum}' WHERE bank_card_number = '{card_numberUser}'";
                                    var queryTransaction2 = $"INSERT INTO transactions (transaction_type, transaction_destination, transaction_date, " +
                                        $"transaction_number, transaction_money, transaction_currency, id_bank_card) VALUES ('Оплата {cmb_servicesCommunalPayments.Text}', " +
                                        $"'{txB_personalAccountCommunalPayments.Text}', '{transactionDateMobile}', '{card_numberUser}', '{totalSum}', " +
                                        $"'{cardCurrencyUser}', (select id_bank_card from bank_card where bank_card_number = '{card_numberUser}'))";
                                    var queryTransaction3 = $"UPDATE clientServices SET serviceBalance = serviceBalance + '{totalSum}' WHERE serviceName = '{cmb_servicesCommunalPayments.GetItemText(cmb_servicesCommunalPayments.SelectedItem)}' AND serviceType = 'Communal'";
                                    var queryTransaction4 = $"INSERT INTO clientPersonalAccount(personal_account, id_service, id_client) VALUES ('{txB_personalAccountCommunalPayments.Text}', (select id_service from clientServices where serviceName = '{cmb_servicesCommunalPayments.GetItemText(cmb_servicesCommunalPayments.SelectedItem)}'), '{DataStorage.idClient}')";
                                    using (MySqlCommand commandTransfer1 = new MySqlCommand(queryTransaction1, DataBaseConnection.GetInstance.GetConnection()))
                                    {
                                        DataBaseConnection.GetInstance.OpenConnection();
                                        if (commandTransfer1.ExecuteNonQuery() == 1)
                                        {
                                            DataBaseConnection.GetInstance.CloseConnection();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Перевод не выполнен queryTransaction1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    using (MySqlCommand commandTransfer2 = new MySqlCommand(queryTransaction2, DataBaseConnection.GetInstance.GetConnection()))
                                    {
                                        DataBaseConnection.GetInstance.OpenConnection();
                                        if (commandTransfer2.ExecuteNonQuery() == 1)
                                        {
                                            DataBaseConnection.GetInstance.CloseConnection();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Перевод не выполнен queryTransaction2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    using (MySqlCommand commandTransfer3 = new MySqlCommand(queryTransaction3, DataBaseConnection.GetInstance.GetConnection()))
                                    {
                                        DataBaseConnection.GetInstance.OpenConnection();
                                        if (commandTransfer3.ExecuteNonQuery() == 1)
                                        {
                                            DataBaseConnection.GetInstance.CloseConnection();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Перевод не выполнен queryTransaction3", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    using (MySqlCommand commandTransfer4 = new MySqlCommand(queryTransaction4, DataBaseConnection.GetInstance.GetConnection()))
                                    {
                                        DataBaseConnection.GetInstance.OpenConnection();
                                        if (commandTransfer4.ExecuteNonQuery() == 1)
                                        {
                                            DataBaseConnection.GetInstance.CloseConnection();
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Перевод не выполнен queryTransaction4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Вы ввели неверный CVV-код более трёх раз", caption, btn, ico);
                                this.Close();
                            }

                        }
                        else
                        {
                            txB_personalAccountCommunalPayments.Select();
                            MessageBox.Show("Лицевой счёт не должен быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        txB_cardCvv.Select();
                        MessageBox.Show("CVV-код не введён", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Сумма не должна быть пустой", caption, btn, ico);
                    txB_sum.Select();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка оплаты комунальных платежей (Btn_TransferCommunalPayments_Click)", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
