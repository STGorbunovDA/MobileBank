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

        public AddBankCard()
        {
            InitializeComponent();
        }

        void Btn_closeLoginForm_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        void AddBankCard_Load(object sender, EventArgs e)
        {
            cmB_PIN_code.Text = cmB_PIN_code.Items[0].ToString();
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
            var type_card = cmB_type_card.GetItemText(cmB_type_card.SelectedItem);
            var currency = cmB_currency.GetItemText(cmB_currency.SelectedItem);
            var payment_system = cmB_payment_system.GetItemText(cmB_payment_system.SelectedItem);

        }
    }
}
