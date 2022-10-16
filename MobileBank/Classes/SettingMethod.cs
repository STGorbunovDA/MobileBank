using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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

        internal static void CourseCurrency()
        {
            WebClient client = new WebClient();
            string page = client.DownloadString("https://cbr.ru/");

            const string key = "<div class=\"col-md-2 col-xs-9 _right mono-num\">";
            int index = page.IndexOf(key);
            string rateStr = page.Substring(index + key.Length);
            index = rateStr.IndexOf("</ div >");
            rateStr = rateStr.Substring(0, index).Trim();
        }



    }
}
