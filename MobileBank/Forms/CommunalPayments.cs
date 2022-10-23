using MobileBank.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class CommunalPayments : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public CommunalPayments()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            StartPosition = FormStartPosition.CenterScreen;
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CommunalPayments_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void CommunalPayments_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void CommunalPayments_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void CommunalPayments_Load(object sender, EventArgs e)
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

            lbL_currency.Text = DataStorage.currency;
            txB_card_numberUser.Text = txB_card_numberUser.Text.Trim();
            txB_cardDate.Text = DataStorage.cardDate;
            txB_cardCvv.Text = "";
            txB_personalAccountCommunalPayments.Select();
        }

        void TxB_sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void TxB_personalAccountCommunalPayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        void Btn_TransferCommunalPayments_Click(object sender, EventArgs e)
        {

        }
    }
}
