using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileBank.Classes;
using MySql.Data.MySqlClient;

namespace MobileBank.Forms
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void Btn_close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (InternetСheck.CheackSkyNET())
                    SettingMethod.CourseCurrency(lbL_сourse_euro, lbL_сourse_dollar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки курсы валют с сайта Центробанка", "Системная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (InternetСheck.CheackSkyNET())
                    SettingMethod.Loading_cmb_card_MainForm(cmb_card);

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки номера банковской карты клиента", "Системная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                lbL_card_number.BringToFront();
                lbL_card_number.Text = "";
                lbL_cardDate.BringToFront();
                lbL_cardDate.Text = "";
                lbL_client_FIO.BringToFront();
                lbL_client_FIO.Text = "";
                picB_visa.Visible = false;
                picB_masterCard.Visible = false;
                if (cmb_card.Text != "У Вас отсутсвуют банковские карты")
                {
                    if (InternetСheck.CheackSkyNET())
                        SettingMethod.SelectBankCardMainForm(lbL_client_FIO, lbL_card_number, cmb_card, lbL_cardCvv, lbL_cardDate, lbL_balanceCard, lbl_currency, picB_masterCard, picB_visa);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки label-ов кредитной карты", "Системная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void Btn_adding_card_Click(object sender, EventArgs e)
        {
            AddBankCard addBankCard = new AddBankCard();
            if (Application.OpenForms["AddBankCard"] == null)
            {
                addBankCard.Show();
            }
        }

        void LbL_cardCvv_Click(object sender, EventArgs e)
        {
            if (lbL_cardCvv.Text == "***")
                lbL_cardCvv.Text = DataStorage.cardCVV;
            else lbL_cardCvv.Text = "***";
        }

        void Btn_udpate_Click(object sender, EventArgs e)
        {
            SettingMethod.Loading_cmb_card_MainForm(cmb_card);
            if (cmb_card.Text != "У Вас отсутсвуют банковские карты")
                SettingMethod.SelectBankCardMainForm(lbL_client_FIO, lbL_card_number, cmb_card, lbL_cardCvv, lbL_cardDate, lbL_balanceCard, lbl_currency, picB_masterCard, picB_visa);
        }

        void Cmb_card_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_card.Text != "У Вас отсутсвуют банковские карты")
                SettingMethod.SelectBankCardMainForm(lbL_client_FIO, lbL_card_number, cmb_card, lbL_cardCvv, lbL_cardDate, lbL_balanceCard, lbl_currency, picB_masterCard, picB_visa);
        }

        void Btn_MoneyTransferCard_Click(object sender, EventArgs e)
        {
            MoneyTransferCardForm moneyTransferCardForm = new MoneyTransferCardForm();
            if (Application.OpenForms["MoneyTransferCardForm"] == null)
            {
                DataStorage.NumberTransferCard = txB_NumberTransferCardMoney.Text;

                DataStorage.cardNumberUser = cmb_card.GetItemText(cmb_card.SelectedItem);
                DataStorage.cardDate = lbL_cardDate.Text;
                DataStorage.dolar = lbL_сourse_dollar.Text;
                DataStorage.euro = lbL_сourse_euro.Text;
                moneyTransferCardForm.Show();
            }


        }

        #region Key-press Key-UP
        
        int i = 0;
        void TxB_NumberTransferCardMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
                if (i < 4)
                {
                    i++;
                }
                else
                {
                    i = 0;
                    txB_NumberTransferCardMoney.Text += ' ';
                }
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


        #endregion

        
    }
}
