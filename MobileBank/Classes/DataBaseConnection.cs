using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MobileBank.Classes
{
    class DataBaseConnection
    {
        static volatile DataBaseConnection Class;
        static object SyncObject = new object();
        public static DataBaseConnection GetInstance
        {
            get
            {
                if (Class == null)
                    lock (SyncObject)
                    {
                        if (Class == null)
                            Class = new DataBaseConnection();
                    }
                return Class;
            }
        }

        readonly MySqlConnection connection = new MySqlConnection("server=31.31.198.62;port=3306;username=u1748936_MBank_1;password=mRv-pEc-Gyf-3RS;database=u1748936_mobilebank;charset=utf8");

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода OpenConnection");
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода CloseConnection");
            }
        }

    }
}
