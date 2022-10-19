using MobileBank.Classes;
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

                txB_cardDate.Text = DataStorage.cardDate;
            txB_cardCvv.Text = "";
            txB_cardCvv.Select();
        }

        #region Key-press Key-UP

        void TxB_card_numberUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_card_numberUser_KeyUp(object sender, KeyEventArgs e)
        {
            ProcessKbdCtrlShortcuts(sender, e);
        }

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

        void TxB_NumberTransferCardMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {

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

            string caption = "Ошибка";

            if (txB_cardCvv.Text != "")
            {
                if (!Regex.IsMatch(txB_cardDate.Text, @"^(0[1-9]|1[0-2])/(([0-9]{4}|[0-9]{2})$)"))
                {
                    MessageBox.Show("Введите корректно месяц и дату[mm/yy]", caption, btn, ico);
                    txB_cardDate.Select();
                    return;
                }
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
