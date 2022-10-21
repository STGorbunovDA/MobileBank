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
    public partial class Validations : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Validations()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Validations_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void Validations_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void Validations_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void Validations_Load(object sender, EventArgs e)
        {
            txB_cardPin.Select();
        }

        void Btn_confirm_card_pin_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txB_cardPin.Text))
            {
                if (txB_cardPin.Text == DataStorage.card_pin)
                {
                    this.Close();
                }
                else 
                {
                    DataStorage.attemptsPin++;
                    MessageBox.Show("PIN-код не верный", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
