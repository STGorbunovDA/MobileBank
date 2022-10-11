using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        void LoginForm_Load(object sender, EventArgs e)
        {
            txB_enterNumberPhone.Visible = false;
            txB_enterPassword.Visible = false;
            txB_enterPassword.PasswordChar = '*';
        }

        void LbL_enterNumberPhone_Click(object sender, EventArgs e)
        {
            txB_enterNumberPhone.Visible = true;
            lbL_enterNumberPhone.Visible = false;
        }

        void LbL_enterPassword_Click(object sender, EventArgs e)
        {
            txB_enterPassword.Visible = true;
            lbL_enterPassword.Visible = false;
        }

        void ChB_visibilityPassword_Click(object sender, EventArgs e)
        {
            if(chB_visibilityPassword.Checked) txB_enterPassword.UseSystemPasswordChar = true;
            else txB_enterPassword.UseSystemPasswordChar = false;
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
    }
}
