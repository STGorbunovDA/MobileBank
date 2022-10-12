using System;
using System.Net;
using System.Windows.Forms;

namespace MobileBank.Classes
{
    class InternetСheck
    {
        public static bool CheackSkyNET()
        {
            try
            {//if(new Ping().Send("yandex.ru").Status == IPStatus.Success)
                Dns.GetHostEntry("dotnet.beget.tech");
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show(@"Отсутствует подключение к Интернету. Проверьте настройки сети и повторите попытку",
                        "Сеть недоступна");
                return false;
            }
        }
    }
}
