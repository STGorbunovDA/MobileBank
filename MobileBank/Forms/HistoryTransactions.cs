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
    public partial class HistoryTransactions : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public HistoryTransactions()
        {
            InitializeComponent();
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void HistoryTransactions_Load(object sender, EventArgs e)
        {
            var querySelectTransaction = $"SELECT transaction_type, transaction_destination, transaction_date, transaction_number, transaction_money, transaction_currency " +
                $"from transactions inner join bank_card on transactions.id_bank_card  = bank_card.id_bank_card inner join client on client.id_client = bank_card.id_client " +
                $"where client.id_client = '{DataStorage.idClient}'";

            using (MySqlCommand command = new MySqlCommand(querySelectTransaction, DataBaseConnection.GetInstance.GetConnection()))
            {
                DataBaseConnection.GetInstance.OpenConnection();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem lvitem = new ListViewItem(reader[0].ToString());
                        lvitem.SubItems.Add(reader[1].ToString());
                        lvitem.SubItems.Add(reader[2].ToString());
                        lvitem.SubItems.Add(reader[3].ToString());
                        lvitem.SubItems.Add(reader[4].ToString());
                        lvitem.SubItems.Add(reader[5].ToString());
                        listView1.Items.Add(lvitem);
                    }
                    reader.Close();
                    listView1.Sort();
                }
            }
        }
    }
}
