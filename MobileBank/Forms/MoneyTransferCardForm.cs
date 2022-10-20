﻿using MobileBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class MoneyTransferCardForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MoneyTransferCardForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void btn_close_Click(object sender, EventArgs e)
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

        void MoneyTransferCardForm_Load(object sender, EventArgs e)
        {
            txB_NumberTransferCardMoney.Text = "";
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
            if (DataStorage.NumberTransferCard != "")
            {
                txB_NumberTransferCardMoney.Text = "";
                int one = 0;
                int two = 4;
                for (int m = 0; m < 4; m++)
                {
                    for (int n = one; n < two; n++)
                    {
                        txB_NumberTransferCardMoney.Text += DataStorage.NumberTransferCard[n].ToString();
                    }
                    txB_NumberTransferCardMoney.Text += " ";
                    one += 4;
                    two += 4;
                }
            }
            lbl_currency.Text = DataStorage.currency;
            txB_card_numberUser.Text = txB_card_numberUser.Text.Trim();
            txB_NumberTransferCardMoney.Text = txB_NumberTransferCardMoney.Text.Trim();
            txB_cardDate.Text = DataStorage.cardDate;
            txB_cardCvv.Text = "";
            txB_cardCvv.Select();
        }

        #region Key-press Key-UP 

        void TxB_cardDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == '/')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_cardDate_KeyUp(object sender, KeyEventArgs e)
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

        void TxB_cardCvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_cardCvv_KeyUp(object sender, KeyEventArgs e)
        {
            ProcessKbdCtrlShortcuts(sender, e);
        }

        int spaceNumberTransferCardMoney = 0;
        void TxB_NumberTransferCardMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                if (txB_NumberTransferCardMoney.TextLength == 0)
                    spaceNumberTransferCardMoney = 0;
                if (txB_NumberTransferCardMoney.TextLength < 19)
                {
                    if (e.KeyChar == (char)Keys.Back)
                        spaceNumberTransferCardMoney--;
                    if (spaceNumberTransferCardMoney < 4)
                    {
                        spaceNumberTransferCardMoney++;
                    }
                    else
                    {
                        spaceNumberTransferCardMoney = 1;
                        txB_NumberTransferCardMoney.Text += ' ';
                        txB_NumberTransferCardMoney.SelectionStart = txB_NumberTransferCardMoney.Text.Length;
                    }
                }
                else if (txB_NumberTransferCardMoney.TextLength == 19)
                    spaceNumberTransferCardMoney = 1;
                else spaceNumberTransferCardMoney = 0;
            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_NumberTransferCardMoney_KeyUp(object sender, KeyEventArgs e)
        {
            ProcessKbdCtrlShortcuts(sender, e);
        }

        void TxB_sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void Btn_Transfer_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            string caption = "Отмена. Невозможно осуществить перевод средств";

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
                    if (Convert.ToDouble(txB_sum.Text) < 50.00)
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
                if(Convert.ToDouble(DataStorage.balanceCard) < Convert.ToDouble(txB_sum.Text))
                {
                    MessageBox.Show($"Недостаточно денег на Вашем счёте: \"{DataStorage.balanceCard}\"", caption, btn, ico); ;
                    txB_sum.Select();
                    return;
                }


                var reg2 = new Regex(",");
                double dolar = Convert.ToDouble(reg2.Replace(DataStorage.dolar.ToString(), "."));
                double euro = Convert.ToDouble(reg2.Replace(DataStorage.euro.ToString(), "."));

                txB_sum.Text += ".00";

                var cardCVVUser = txB_cardCvv.Text;
                var txB_cardDateUser = txB_cardDate.Text;
                var NumberTransferCardMoney = txB_NumberTransferCardMoney.Text;
                var sum = txB_sum.Text;
                var cardCurrencyUser = "";
                var cardCurrencyTransfer = "";
                var cardCVVCheck = "";
                var cardDateCheck = "";
                double cardBalanceCheckUser = 0;
                bool error = false;

                //в самом конце

                txB_sum.Text = "0";

            }
            else
            {
                txB_cardCvv.Select();
                MessageBox.Show("CVV-код не введён", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


    }
}