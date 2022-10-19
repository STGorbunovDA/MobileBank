using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileBank.Classes
{
    class SettingMethod
    {
        internal static Boolean CheackUser(string txB_client_phone_number)
        {
            string MySqlRequest = $"SELECT client_phone_number FROM client WHERE client_phone_number = '{txB_client_phone_number}'";

            using (MySqlCommand command = new MySqlCommand(MySqlRequest, DataBaseConnection.GetInstance.GetConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }
        }

        internal static Boolean CheackBankCardNumber(string cardNumber)
        {
            var queryCheckCardNumber = $"SELECT * FROM bank_card WHERE bank_card_number = '{cardNumber}'";

            using (MySqlCommand command = new MySqlCommand(queryCheckCardNumber, DataBaseConnection.GetInstance.GetConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
            }
        }

        internal static void CourseCurrency(Label lbL_сourse_euro, Label lbL_сourse_dollar)
        {
            WebClient client = new WebClient();
            string page = client.DownloadString("https://cbr.ru/");

            const string key = "<div class=\"col-md-2 col-xs-9 _euro\">EUR</div>";
            int index = page.IndexOf(key);
            string rateStr = page.Substring(index + key.Length);
            index = rateStr.IndexOf("в‚Ѕ");
            rateStr = rateStr.Substring(0, index).Trim();
            var result = Regex.Match(rateStr, @"(.{7})\s*$");

            lbL_сourse_euro.Text = result.ToString().Trim();

            const string key2 = "<div class=\"col-md-2 col-xs-9 _dollar\">USD</div>";
            int index2 = page.IndexOf(key2);
            string rateStr2 = page.Substring(index2 + key2.Length);
            index2 = rateStr2.IndexOf("в‚Ѕ");
            rateStr2 = rateStr2.Substring(0, index2).Trim();
            var result2 = Regex.Match(rateStr2, @"(.{7})\s*$");

            lbL_сourse_dollar.Text = result2.ToString().Trim();

        }

        internal static string SelectBankCardMainForm(Label lbL_client_FIO, Label lbL_card_number, ComboBox cmb_card, 
            Label lbL_cardCvv, Label lbL_cardDate, Label lbL_balanceCard, Label lbl_currency, PictureBox picB_masterCard, PictureBox picB_visa)
        {
            var lbL_cardCW = "";
            lbL_card_number.Text = "";
            string payment_system = "";
            string querySelectCard = $"SELECT bank_card_number, bank_card_cvv_code, bank_card_date, " +
                $"bank_card_paymentSystem, bank_card_balance, bank_card_currency FROM bank_card WHERE bank_card_number = '{cmb_card.GetItemText(cmb_card.SelectedItem)}'";
            string querySelectClientCard = $"SELECT client_last_name, client_first_name, client_middle_name FROM client WHERE id_client = {DataStorage.idClient}";

            using (MySqlCommand command = new MySqlCommand(querySelectClientCard, DataBaseConnection.GetInstance.GetConnection()))
            {
                DataBaseConnection.GetInstance.OpenConnection();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lbL_client_FIO.Text += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                    }
                }
            }

            using (MySqlCommand command = new MySqlCommand(querySelectCard, DataBaseConnection.GetInstance.GetConnection()))
            {
                DataBaseConnection.GetInstance.OpenConnection();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cardNumber = reader[0].ToString();

                        int tmp = 0;
                        int tmp1 = 4;
                        for (int m = 0; m < 4; m++)
                        {
                            for (int n = tmp; n < tmp1; n++)
                            {
                                lbL_card_number.Text += cardNumber[n].ToString();
                            }
                            lbL_card_number.Text += " ";
                            tmp += 4;
                            tmp1 += 4;
                        }
                        lbL_cardCW = reader[1].ToString();
                        DateTime dateTime = (DateTime)reader[2];
                        var dateTimeMM = dateTime.ToString("MM");
                        var dateTimeYY = dateTime.ToString("yy");
                        lbL_cardDate.Text = dateTimeMM + "/" + dateTimeYY;
                        payment_system = reader[3].ToString();
                        lbL_balanceCard.Text = Math.Round(Convert.ToDouble(reader[4]), 2).ToString();
                        lbl_currency.Text = reader[5].ToString();
                        DataStorage.cardCVV = lbL_cardCvv.Text;
                        lbL_cardCvv.Text = "***";

                    }
                    reader.Close();

                    if (payment_system == "Visa")
                    {
                        picB_masterCard.Visible = false;
                        picB_visa.Visible = true;

                    }
                    else if (payment_system == "Mastercard")
                    {
                        picB_visa.Visible = false;
                        picB_masterCard.Visible = true;
                    }

                }
                DataBaseConnection.GetInstance.CloseConnection();
                return lbL_cardCW;
            }
        }

    }
}
