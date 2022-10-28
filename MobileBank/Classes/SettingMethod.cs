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
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (CheackUser)");
                return false;
            }
        }

        internal static Boolean CheackBankCardNumber(string cardNumber)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (CheackBankCardNumber)");
                return false;
            }
        }

        internal static void CourseCurrency(Label lbL_сourse_euro, Label lbL_сourse_dollar)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (CourseCurrency)");
            }
        }

        internal static void SelectBankCardMainForm(Label lbL_client_FIO, Label lbL_card_number, ComboBox cmb_card, 
            Label lbL_cardCvv, Label lbL_cardDate, Label lbL_balanceCard, Label lbl_currency, PictureBox picB_masterCard, PictureBox picB_visa)
        {
            try
            {
                lbL_card_number.Text = "";
                string payment_system = "";
                string querySelectCard = $"SELECT bank_card_number, bank_card_cvv_code, bank_card_date, " +
                    $"bank_card_paymentSystem, bank_card_balance, bank_card_currency, bank_card_pin FROM bank_card WHERE bank_card_number = '{cmb_card.GetItemText(cmb_card.SelectedItem)}'";
                string querySelectClientCard = $"SELECT client_last_name, client_first_name, client_middle_name FROM client WHERE id_client = {DataStorage.idClient}";

                using (MySqlCommand command = new MySqlCommand(querySelectClientCard, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        lbL_client_FIO.Text = "";
                        while (reader.Read())
                        {
                            lbL_client_FIO.Text += reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString();
                        }
                    }
                    DataBaseConnection.GetInstance.CloseConnection();
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
                            lbL_cardCvv.Text = reader[1].ToString();
                            DateTime dateTime = (DateTime)reader[2];
                            var dateTimeMM = dateTime.ToString("MM");
                            var dateTimeYY = dateTime.ToString("yy");
                            lbL_cardDate.Text = dateTimeMM + "/" + dateTimeYY;
                            payment_system = reader[3].ToString();
                            lbL_balanceCard.Text = Math.Round(Convert.ToDouble(reader[4]), 2).ToString();
                            lbl_currency.Text = reader[5].ToString();
                            DataStorage.card_pin = reader[6].ToString();
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
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (SelectBankCardMainForm)");
            }
            
        }

        internal static void Loading_cmb_card_MainForm(ComboBox cmb_card)
        {
            try
            {
                string querystring = $"SELECT id_bank_card, bank_card_number FROM bank_card WHERE id_client = {DataStorage.idClient}";
                using (MySqlCommand command = new MySqlCommand(querystring, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    DataTable card_number = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(card_number);
                        if (card_number.Rows.Count > 0)
                        {
                            cmb_card.DataSource = card_number;
                            cmb_card.ValueMember = "id_bank_card";
                            cmb_card.DisplayMember = "bank_card_number";
                        }
                        else
                        {
                            cmb_card.Text = "У Вас отсутсвуют банковские карты";
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (Loading_cmb_card_MainForm)");
            }      
        }

        internal static void Loading_serviceTypeMobile_cmd(ComboBox cmb_serviceTypeMobile)
        {
            try
            {
                var queryChooseOperator = $"SELECT id_service, serviceName, serviceBalance, serviceType FROM clientServices WHERE serviceType = 'Mobile'";
                using (MySqlCommand command = new MySqlCommand(queryChooseOperator, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    DataTable serviceTypeMobile = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(serviceTypeMobile);
                        if (serviceTypeMobile.Rows.Count > 0)
                        {
                            cmb_serviceTypeMobile.DataSource = serviceTypeMobile;
                            cmb_serviceTypeMobile.ValueMember = "id_service";
                            cmb_serviceTypeMobile.DisplayMember = "serviceName";
                        }
                        else
                        {
                            cmb_serviceTypeMobile.Text = "";
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (Loading_serviceTypeMobile_cmd)");
            }  
        }
        internal static void Loading_serviceTypeInternetTV_cmd(ComboBox cmb_serviceTypeMobile)
        {
            try
            {
                var queryChooseOperator = $"SELECT id_service, serviceName, serviceBalance, serviceType FROM clientServices WHERE serviceType = 'Internet'";
                using (MySqlCommand command = new MySqlCommand(queryChooseOperator, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    DataTable serviceTypeMobile = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(serviceTypeMobile);
                        if (serviceTypeMobile.Rows.Count > 0)
                        {
                            cmb_serviceTypeMobile.DataSource = serviceTypeMobile;
                            cmb_serviceTypeMobile.ValueMember = "id_service";
                            cmb_serviceTypeMobile.DisplayMember = "serviceName";
                        }
                        else
                        {
                            cmb_serviceTypeMobile.Text = "";
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (Loading_serviceTypeInternetTV_cmd)");
            }            
        }
        internal static void Loading_servicesCommunalPayments_cmd(ComboBox cmb_servicesCommunalPayments)
        {
            try
            {
                var queryChooseOperator = $"SELECT id_service, serviceName, serviceBalance, serviceType FROM clientServices WHERE serviceType = 'Communal'";
                using (MySqlCommand command = new MySqlCommand(queryChooseOperator, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    DataTable servicesCommunalPayments = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(servicesCommunalPayments);
                        if (servicesCommunalPayments.Rows.Count > 0)
                        {
                            cmb_servicesCommunalPayments.DataSource = servicesCommunalPayments;
                            cmb_servicesCommunalPayments.ValueMember = "id_service";
                            cmb_servicesCommunalPayments.DisplayMember = "serviceName";
                        }
                        else
                        {
                            cmb_servicesCommunalPayments.Text = "";
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (Loading_servicesCommunalPayments_cmd)");
            }
        }

        internal static void Loading_servicesHelpChildrenPayments_cmd(ComboBox cmb_servicesHelpChildrenPayments)
        {
            try
            {
                var queryChooseOperator = $"SELECT id_service, serviceName, serviceBalance, serviceType FROM clientServices WHERE serviceType = 'Help'";
                using (MySqlCommand command = new MySqlCommand(queryChooseOperator, DataBaseConnection.GetInstance.GetConnection()))
                {
                    DataBaseConnection.GetInstance.OpenConnection();
                    DataTable servicesHelpChildrenPayments = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(servicesHelpChildrenPayments);
                        if (servicesHelpChildrenPayments.Rows.Count > 0)
                        {
                            cmb_servicesHelpChildrenPayments.DataSource = servicesHelpChildrenPayments;
                            cmb_servicesHelpChildrenPayments.ValueMember = "id_service";
                            cmb_servicesHelpChildrenPayments.DisplayMember = "serviceName";
                        }
                        else
                        {
                            cmb_servicesHelpChildrenPayments.Text = "";
                        }
                        DataBaseConnection.GetInstance.CloseConnection();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (Loading_servicesHelpChildrenPayments_cmd)");
            }
            
        }

        internal static void RefreshUserClientPersonalData(Label lbL_FIO_user, Label lbL_Phone_user, Label lbL_email_user)
        {
            try
            {
                var queryPIB = $"SELECT CONCAT(client_last_name, ' ', client_first_name, ' ', client_middle_name), client_phone_number, client_email FROM client WHERE id_client = '{DataStorage.idClient}'";

                if (InternetСheck.CheackSkyNET())
                {
                    using (MySqlCommand command = new MySqlCommand(queryPIB, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lbL_FIO_user.Text = reader[0].ToString();
                                lbL_Phone_user.Text = reader[1].ToString();
                                lbL_email_user.Text = reader[2].ToString();
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (RefreshUserClientPersonalData)");
            }
        }

        internal static Boolean CheackUserPassword(string txB_client_password_old)
        {
            try
            {
                var passUser = md5.hashPassword(txB_client_password_old);
                string MySqlRequest = $"SELECT client_password FROM client WHERE client_password = '{passUser}'";

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
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (CheackUserPassword)");
                return false;
            }  
        }

        internal static bool LoadingCreditStatus(string cardNumberUser, Label lbL_CreditNotPaid)
        {
            try
            {
                var reg3 = new Regex(" ");
                cardNumberUser = reg3.Replace(cardNumberUser, "");

                var repayment_date = "";
                var queryCreditDate = $"SELECT repayment_date FROM credits WHERE id_bank_card  = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{cardNumberUser}')";
                
                if (InternetСheck.CheackSkyNET())
                {
                    using (MySqlCommand command = new MySqlCommand(queryCreditDate, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        DataBaseConnection.GetInstance.OpenConnection();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                repayment_date = reader[0].ToString();
                            }
                            reader.Close();
                        }
                    }
                    if(String.IsNullOrEmpty(repayment_date))
                    {
                        return true;
                    }
                    else
                    {
                        DateTime dateTimeNow = DateTime.Now;

                        DateTime repaymentDate = Convert.ToDateTime(repayment_date);

                        if (repaymentDate < dateTimeNow)
                        {
                            var creditStatus = "";
                            var queryCreditStatus = $"SELECT credit_status FROM credits WHERE id_bank_card  = (SELECT id_bank_card FROM bank_card WHERE bank_card_number = '{cardNumberUser}')";

                            using (MySqlCommand command = new MySqlCommand(queryCreditStatus, DataBaseConnection.GetInstance.GetConnection()))
                            {
                                DataBaseConnection.GetInstance.OpenConnection();
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        creditStatus = reader[0].ToString();
                                    }
                                    reader.Close();
                                }
                            }
                            if(creditStatus == "0")
                            {
                                lbL_CreditNotPaid.Visible = true;
                                return false;
                            }
                            else return true;


                        }
                        else
                        {
                            return true;
                        }
                    }   
                }
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода (LoadingCreditStatus)");
                return true;
            }
        }
    }
}
