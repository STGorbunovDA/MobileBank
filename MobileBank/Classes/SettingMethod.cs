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



    }
}
