using MobileBank.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class AddBankCard : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        Random rand = new Random();

        public AddBankCard()
        {
            InitializeComponent();
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        void AddBankCard_Load(object sender, EventArgs e)
        {
            cmB_type_card.Text = cmB_type_card.Items[0].ToString();
            cmB_currency.Text = cmB_currency.Items[0].ToString();
            cmB_payment_system.Text = cmB_payment_system.Items[0].ToString();

            //cmB_PIN_code.Text = cmB_PIN_code.Items[0].ToString();
        }

        void panel1_MouseDown(object sender, MouseEventArgs e)
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

        void Btn_save_and_client_new_card_Click(object sender, EventArgs e)
        {
            try
            {
                if (InternetСheck.CheackSkyNET())
                {
                    var type_card = cmB_type_card.GetItemText(cmB_type_card.SelectedItem);
                    var currency = cmB_currency.GetItemText(cmB_currency.SelectedItem);
                    var payment_system = cmB_payment_system.GetItemText(cmB_payment_system.SelectedItem);
                    var cardNumber = "";
                    var cardPin = txB_cardPin.Text;
                    var cvvCode = "";
                    bool isCardFree = false;
                    DateTime dateTime = DateTime.Now;
                    DateTime cardDate1 = dateTime.AddYears(4);
                    var cardDate = cardDate1.ToString("yyyy-MM-dd");
                    

                    for (int i = 0; i < 3; i++)
                    {
                        cvvCode += Convert.ToString(rand.Next(0, 10));
                    }

                    do
                    {
                        if (payment_system == "Visa")
                        {
                            cardNumber += "4";
                            for (int i = 0; i < 15; i++)
                            {
                                cardNumber += Convert.ToString(rand.Next(0, 10));
                            }
                        }
                        else
                        {
                            cardNumber += "5";
                            for (int i = 0; i < 15; i++)
                            {
                                cardNumber += Convert.ToString(rand.Next(0, 10));
                            }
                        }
                        if (SettingMethod.CheackBankCardNumber(cardNumber))
                            isCardFree = true;
                    } while (isCardFree == false);

                    var queryAddNewCard = $"INSERT INTO bank_card (bank_card_type, bank_card_number, " +
                        $"bank_card_cvv_code, bank_card_balance, bank_card_currency, bank_card_paymentSystem, bank_card_date, " +
                        $"bank_card_pin, id_client) VALUES ('{type_card}', '{cardNumber}', '{cvvCode}', '{0.00}', " +
                        $"'{currency}', '{payment_system}', '{cardDate}', '{cardPin}', '{DataStorage.idClient}')";

                    DataBaseConnection.GetInstance.OpenConnection();
                    using (MySqlCommand commandAddNewUser = new MySqlCommand(queryAddNewCard, DataBaseConnection.GetInstance.GetConnection()))
                    {
                        if (commandAddNewUser.ExecuteNonQuery() == 1)
                        {
                            DataBaseConnection.GetInstance.CloseConnection();
                            MessageBox.Show("Карта успешно создана", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Карта не создана", "Данные не сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Btn_save_and_client_new_card_Click", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
        void TxB_cardPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_cardPin_KeyUp(object sender, KeyEventArgs e)
        {
            ProcessKbdCtrlShortcuts(sender, e);
        }

        void ProcessKbdCtrlShortcuts(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox t = (TextBox)sender;
                if (e.KeyData == (Keys.C | Keys.Control))
                {
                    t.Copy();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.X | Keys.Control))
                {
                    t.Cut();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.V | Keys.Control))
                {
                    t.Paste();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.A | Keys.Control))
                {
                    t.SelectAll();
                    e.Handled = true;
                }
                else if (e.KeyData == (Keys.Z | Keys.Control))
                {
                    t.Undo();
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка метода ctrl+c+v (ProcessKbdCtrlShortcuts)");
            }
        }

        void CmB_type_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        void CmB_currency_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        void CmB_payment_system_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
    
