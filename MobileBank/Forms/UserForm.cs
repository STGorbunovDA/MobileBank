using MobileBank.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class UserForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public UserForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            if (!FormClose.GetInstance.FClose())
                this.Close();
        }

        void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                SettingMethod.RefreshUserClientPersonalData(lbL_FIO_user, lbL_Phone_user, lbL_email_user);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки персональных данных клиента (UserForm_Load)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControl();
                SettingMethod.RefreshUserClientPersonalData(lbL_FIO_user, lbL_Phone_user, lbL_email_user);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки персональных данных клиента (Btn_update_Click)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ClearControl()
        {
            lbL_FIO_user.Text = string.Empty;
            lbL_Phone_user.Text = string.Empty;
            lbL_email_user.Text = string.Empty;
        }

        #region перет.

        void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void Panel4_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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

        void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void Panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        void Btn_ChangeNumberPhone_Click(object sender, EventArgs e)
        {
            ChangePhoneNumber phoneNumber = new ChangePhoneNumber();
            if (Application.OpenForms["ChangePhoneNumber"] == null)
            {
                phoneNumber.Show();
            }
        }

        void Btn_ChangePasswordAccount_Click(object sender, EventArgs e)
        {
            ChangePasswordUserAccount changePasswordUser = new ChangePasswordUserAccount();
            if (Application.OpenForms["ChangePasswordUserAccount"] == null)
            {
                changePasswordUser.Show();
            }

        }

        void Btn_ChangeEmail_Click(object sender, EventArgs e)
        {
            ChangeEmail changeEmail = new ChangeEmail();
            if (Application.OpenForms["ChangeEmail"] == null)
            {
                changeEmail.Show();
            }
        }
    }
}
