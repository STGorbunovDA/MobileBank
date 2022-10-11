using System;
using System.Drawing;
using System.Windows.Forms;

namespace MobileBank
{
    public partial class LoginForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public LoginForm()
        {
            InitializeComponent();
        }

        void LoginForm_Load(object sender, EventArgs e)
        {
            txB_enterPassword.UseSystemPasswordChar = true;
        }

        void ChB_visibilityPassword_Click(object sender, EventArgs e)
        {
            if (chB_visibilityPassword.Checked)
            {
                txB_enterPassword.UseSystemPasswordChar = false;
            }
            else if (!chB_visibilityPassword.Checked)
                txB_enterPassword.UseSystemPasswordChar = true;
        }

        void LbL_CreateAccount_MouseEnter(object sender, EventArgs e)
        {
            lbL_CreateAccount.ForeColor = Color.GreenYellow;
        }

        void LbL_CreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lbL_CreateAccount.ForeColor = Color.White;
        }

        void Btn_closeLoginForm_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
