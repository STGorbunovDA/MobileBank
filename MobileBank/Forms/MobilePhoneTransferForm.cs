using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class MobilePhoneTransferForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        Random rand = new Random();

        public MobilePhoneTransferForm()
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

        void MobilePhoneTransferForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void MobilePhoneTransferForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void MobilePhoneTransferForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void MobilePhoneTransferForm_Load(object sender, EventArgs e)
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
            txB_transferMobilePhone.Text = DataStorage.phoneNumber;
            lbL_currency.Text = DataStorage.currency;
            txB_card_numberUser.Text = txB_card_numberUser.Text.Trim();
            txB_cardDate.Text = DataStorage.cardDate;
            txB_cardCvv.Text = "";

            SettingMethod.Loading_serviceTypeMobile_cmd(cmb_serviceTypeMobileOperator);

            txB_transferMobilePhone.Select();
        }

        void TxB_sumTransferPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxB_sumTransferPhone_TextChanged_1(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txB_sum.Text))
            {
                if (lbL_currency.Text == "RUB")
                {
                    if (Convert.ToInt32(txB_sum.Text) > 49)
                    {
                        lbL_commissionTransferPhone.Text = (Convert.ToDouble(txB_sum.Text) / 100 * DataStorage.commissionPhoneTransfer).ToString();
                        lbL_paymentTransferPhone.Text = (Convert.ToDouble(lbL_commissionTransferPhone.Text) + Convert.ToDouble(txB_sum.Text)).ToString();
                    }
                    else 
                    {
                        lbL_commissionTransferPhone.Text = "";
                        lbL_paymentTransferPhone.Text = "";
                    }
                }
                else if (lbL_currency.Text == "USD")
                {
                    if (Convert.ToDouble(txB_sum.Text) > 0.99)
                    {
                        var reg2 = new Regex(",");
                        double dolar = Convert.ToDouble(reg2.Replace(DataStorage.dollar.ToString(), "."));
                        lbL_commissionTransferPhone.Text = (((Convert.ToDouble(txB_sum.Text) * dolar) / 100 * DataStorage.commissionPhoneTransfer) / dolar).ToString();
                        lbL_paymentTransferPhone.Text = (Convert.ToDouble(lbL_commissionTransferPhone.Text) + Convert.ToDouble(txB_sum.Text)).ToString();
                    }
                    else
                    {
                        lbL_commissionTransferPhone.Text = "";
                        lbL_paymentTransferPhone.Text = "";
                    }
                }
                else if (lbL_currency.Text == "USD")
                {
                    if (Convert.ToDouble(txB_sum.Text) > 0.99)
                    {
                        var reg2 = new Regex(",");
                        double euro = Convert.ToDouble(reg2.Replace(DataStorage.euro.ToString(), "."));
                        lbL_commissionTransferPhone.Text = (((Convert.ToDouble(txB_sum.Text) * euro) / 100 * DataStorage.commissionPhoneTransfer) / euro).ToString();
                        lbL_paymentTransferPhone.Text = (Convert.ToDouble(lbL_commissionTransferPhone.Text) + Convert.ToDouble(txB_sum.Text)).ToString();
                    }
                    else
                    {
                        lbL_commissionTransferPhone.Text = "";
                        lbL_paymentTransferPhone.Text = "";
                    }
                }
            } 
            else
            {
                lbL_commissionTransferPhone.Text = "";
                lbL_paymentTransferPhone.Text = "";
            }
        }

        void Btn_TransferPhone_Click(object sender, EventArgs e)
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
                        if (!Regex.IsMatch(txB_cardDate.Text, @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])"))
                        {
                            MessageBox.Show("Введите корректно месяц и дату[mm/yy]", caption, btn, ico);
                            txB_cardDate.Select();
                            return;
                        }
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
                        if (Convert.ToDouble(DataStorage.balanceCard) < Convert.ToDouble(lbL_paymentTransferPhone.Text))
                        {
                            MessageBox.Show($"Недостаточно денег на Вашем счёте: \"{DataStorage.balanceCard}\"", caption, btn, ico);
                            txB_sum.Select();
                            return;
                        }

                        if (cmb_serviceTypeMobileOperator.Text == "МТС")
                        {
                            var phoneOperatorCheack = txB_transferMobilePhone.Text.Substring(3, 2);
                            if (phoneOperatorCheack != "10" && phoneOperatorCheack != "11" && phoneOperatorCheack != "12" && phoneOperatorCheack != "13"
                                && phoneOperatorCheack != "14" && phoneOperatorCheack != "15" && phoneOperatorCheack != "16" && phoneOperatorCheack != "17"
                                && phoneOperatorCheack != "18" && phoneOperatorCheack != "19" && phoneOperatorCheack != "81" && phoneOperatorCheack != "82"
                                && phoneOperatorCheack != "83" && phoneOperatorCheack != "84" && phoneOperatorCheack != "85" && phoneOperatorCheack != "86"
                                && phoneOperatorCheack != "87" && phoneOperatorCheack != "88" && phoneOperatorCheack != "89")
                            {
                                MessageBox.Show($"Введите корректный номер телефона оператора МТС", caption, btn, ico);
                                txB_transferMobilePhone.Select();
                                return;
                            }
                        }
                        if (cmb_serviceTypeMobileOperator.Text == "Мегафон")
                        {
                            var phoneOperatorCheack = txB_transferMobilePhone.Text.Substring(3, 2);
                            if (phoneOperatorCheack != "24" && phoneOperatorCheack != "29" && phoneOperatorCheack != "34" && phoneOperatorCheack != "28"
                                && phoneOperatorCheack != "29" && phoneOperatorCheack != "38" && phoneOperatorCheack != "27" && phoneOperatorCheack != "29"
                                && phoneOperatorCheack != "38" && phoneOperatorCheack != "21" && phoneOperatorCheack != "31" && phoneOperatorCheack != "23"
                                && phoneOperatorCheack != "83" && phoneOperatorCheack != "84" && phoneOperatorCheack != "85" && phoneOperatorCheack != "86"
                                && phoneOperatorCheack != "33" && phoneOperatorCheack != "25" && phoneOperatorCheack != "26" && phoneOperatorCheack != "36" 
                                && phoneOperatorCheack != "22" && phoneOperatorCheack != "32" && phoneOperatorCheack != "20" && phoneOperatorCheack != "30")
                            {
                                MessageBox.Show($"Введите корректный номер телефона оператора Мегафон", caption, btn, ico);
                                txB_transferMobilePhone.Select();
                                return;
                            }
                        }
                        if (cmb_serviceTypeMobileOperator.Text == "Билайн")
                        {
                            var phoneOperatorCheack = txB_transferMobilePhone.Text.Substring(3, 2);
                            if (phoneOperatorCheack != "03" && phoneOperatorCheack != "05" && phoneOperatorCheack != "06" && phoneOperatorCheack != "09"
                                && phoneOperatorCheack != "60" && phoneOperatorCheack != "61" && phoneOperatorCheack != "62" && phoneOperatorCheack != "63"
                                && phoneOperatorCheack != "64" && phoneOperatorCheack != "65" && phoneOperatorCheack != "67" && phoneOperatorCheack != "76"
                                && phoneOperatorCheack != "01" && phoneOperatorCheack != "02" && phoneOperatorCheack != "08" && phoneOperatorCheack != "66"
                                && phoneOperatorCheack != "68")
                            {
                                MessageBox.Show($"Введите корректный номер телефона оператора Мегафон", caption, btn, ico);
                                txB_transferMobilePhone.Select();
                                return;
                            }
                        }
                        if (cmb_serviceTypeMobileOperator.Text == "Теле2")
                        {
                            var phoneOperatorCheack = txB_transferMobilePhone.Text.Substring(3, 2);
                            if (phoneOperatorCheack != "01" && phoneOperatorCheack != "02" && phoneOperatorCheack != "04" && phoneOperatorCheack != "05"
                                && phoneOperatorCheack != "08" && phoneOperatorCheack != "50" && phoneOperatorCheack != "51" && phoneOperatorCheack != "52"
                                && phoneOperatorCheack != "53" && phoneOperatorCheack != "58" && phoneOperatorCheack != "11" && phoneOperatorCheack != "99"
                                && phoneOperatorCheack != "96" && phoneOperatorCheack != "93" && phoneOperatorCheack != "00" && phoneOperatorCheack != "92"
                                && phoneOperatorCheack != "95")
                            {
                                MessageBox.Show($"Введите корректный номер телефона оператора Мегафон", caption, btn, ico);
                                txB_transferMobilePhone.Select();
                                return;
                            }
                        }


                        var reg2 = new Regex(",");
                        double dolar = Convert.ToDouble(reg2.Replace(DataStorage.dollar.ToString(), "."));
                        double euro = Convert.ToDouble(reg2.Replace(DataStorage.euro.ToString(), "."));

                        var reg3 = new Regex(" ");
                        var card_numberUser = reg3.Replace(txB_card_numberUser.Text, "");

                        string totalSum = lbL_paymentTransferPhone.Text;
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
                                var transactionNumber = "M";

                                for (int i = 0; i < 10; i++)
                                {
                                    transactionNumber += Convert.ToString(rand.Next(0, 10));
                                }
                                var queryTransaction1 = $"UPDATE bank_card SET bank_card_balance = bank_card_balance - '{totalSum}' WHERE bank_card_number = '{card_numberUser}'";
                                var queryTransaction2 = $"INSERT INTO transactions (transaction_type, transaction_destination, transaction_date, " +
                                    $"transaction_number, transaction_money, transaction_currency, id_bank_card) VALUES ('Пополнение мобильного', " +
                                    $"'{txB_transferMobilePhone.Text}', '{transactionDateMobile}', '{card_numberUser}', '{totalSum}', " +
                                    $"'{cardCurrencyUser}', (select id_bank_card from bank_card where bank_card_number = '{card_numberUser}'))";
                                var queryTransaction3 = $"UPDATE clientServices SET serviceBalance = serviceBalance + '{totalSum}' WHERE serviceName = '{cmb_serviceTypeMobileOperator.GetItemText(cmb_serviceTypeMobileOperator.SelectedItem)}' AND serviceType = 'Mobile'";

                                using (MySqlCommand commandTransfer1 = new MySqlCommand(queryTransaction1, DataBaseConnection.GetInstance.GetConnection()))
                                {
                                    DataBaseConnection.GetInstance.OpenConnection();
                                    if (commandTransfer1.ExecuteNonQuery() == 1)
                                    {
                                        using (MySqlCommand commandTransfer2 = new MySqlCommand(queryTransaction2, DataBaseConnection.GetInstance.GetConnection()))
                                        {
                                            if (commandTransfer2.ExecuteNonQuery() == 1)
                                            {
                                                using (MySqlCommand commandTransfer3 = new MySqlCommand(queryTransaction3, DataBaseConnection.GetInstance.GetConnection()))
                                                {
                                                    if (commandTransfer3.ExecuteNonQuery() == 1)
                                                    {

                                                        DataBaseConnection.GetInstance.CloseConnection();
                                                        MessageBox.Show($"Оплата на номер {txB_transferMobilePhone.Text} произведена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Перевод не выполнен queryTransaction3", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Перевод не выполнен queryTransaction2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Перевод не выполнен queryTransaction1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ошибка пополнения мобильного (Btn_TransferPhone_Click)", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
