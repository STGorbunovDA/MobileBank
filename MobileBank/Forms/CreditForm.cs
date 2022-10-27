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
    public partial class CreditForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        Random rand = new Random();
        Validations validations = new Validations();

        public CreditForm()
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

        void CreditForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void CreditForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void CreditForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void CreditForm_Load(object sender, EventArgs e)
        {
            txB_sumCredit.Text = trB_sumCredit.Value.ToString();
            txB_monthsCredit.Text = trB_monthsCredit.Value.ToString();
            panel_arrangeCredit.Visible = false;
            btn_TransferHelpChildrenPayments.Visible = false;

            var totalSum = "";
            var sum = "";
            DateTime dateTime = new DateTime();
            var idCredit = "";

            double creditTotalSumToCheack = 0;
            double creditSumToCheack = 0;

            var queryCheckCreditStatus = $"SELECT credit_total_sum, credit_sum where id_bank_card = {DataStorage.cardNumberUser}";


        }
    }
}
