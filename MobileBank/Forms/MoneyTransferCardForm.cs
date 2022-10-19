using MobileBank.Classes;
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
            txB_card_numberUser.Text = DataStorage.cardNumber;
            txB_NumberTransferCardMoney.Text = DataStorage.bankCard;
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
            if (txB_cardCvv.Text != "")
            {

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
