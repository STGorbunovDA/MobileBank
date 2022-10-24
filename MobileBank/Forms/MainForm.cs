using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MobileBank.Classes;

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
            try
            {
                SettingMethod.Loading_cmb_card_MainForm(cmb_card);
                if (cmb_card.Text != "У Вас отсутсвуют банковские карты")
                    SettingMethod.SelectBankCardMainForm(lbL_client_FIO, lbL_card_number, cmb_card, lbL_cardCvv, lbL_cardDate, lbL_balanceCard, lbl_currency, picB_masterCard, picB_visa);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка обновления (Btn_udpate_Click)", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cmb_card_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmb_card.Text != "У Вас отсутсвуют банковские карты")
                    SettingMethod.SelectBankCardMainForm(lbL_client_FIO, lbL_card_number, cmb_card, lbL_cardCvv, lbL_cardDate, lbL_balanceCard, lbl_currency, picB_masterCard, picB_visa);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка загрузки в ComboBox (Cmb_card_SelectionChangeCommitted)", "Ошибка метода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Btn_MoneyTransferCard_Click(object sender, EventArgs e)
        {
            MoneyTransferCardForm moneyTransferCardForm = new MoneyTransferCardForm();
            if (Application.OpenForms["MoneyTransferCardForm"] == null)
            {
                if (cmb_card.Text != "")
                {
                    txB_NumberTransferCardMoney.Text = txB_NumberTransferCardMoney.Text.Replace(" ", "");
                    DataStorage.NumberTransferCard = txB_NumberTransferCardMoney.Text;
                    DataStorage.cardNumberUser = cmb_card.GetItemText(cmb_card.SelectedItem).Trim();
                    DataStorage.cardDate = lbL_cardDate.Text.Trim();
                    DataStorage.dolar = lbL_сourse_dollar.Text.Trim();
                    DataStorage.euro = lbL_сourse_euro.Text.Trim();
                    DataStorage.currency = lbl_currency.Text.Trim();
                    DataStorage.balanceCard = lbL_balanceCard.Text.Trim();
                    moneyTransferCardForm.ShowDialog();
                    txB_NumberTransferCardMoney.Text = "";
                    Btn_udpate_Click(sender, e);
                }
            }
        }

        #region Key-press Key-UP

        int spaceTxB_NumberTransferCardMoney = 0;
        void TxB_NumberTransferCardMoney_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                if (txB_NumberTransferCardMoney.TextLength == 0)
                    spaceTxB_NumberTransferCardMoney = 0;

                if (txB_NumberTransferCardMoney.TextLength < 19)
                {
                    if (e.KeyChar == (char)Keys.Back)
                        spaceTxB_NumberTransferCardMoney--;
                    if (spaceTxB_NumberTransferCardMoney < 4)
                    {
                        spaceTxB_NumberTransferCardMoney++;
                    }
                    else
                    {
                        spaceTxB_NumberTransferCardMoney = 1;
                        txB_NumberTransferCardMoney.Text += ' ';
                        txB_NumberTransferCardMoney.SelectionStart = txB_NumberTransferCardMoney.Text.Length;
                    }
                }
                else if (txB_NumberTransferCardMoney.TextLength == 19)
                    spaceTxB_NumberTransferCardMoney = 1;
                else spaceTxB_NumberTransferCardMoney = 0;
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

        void PicB_user_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            if (Application.OpenForms["UserForm"] == null)
            {
                user.Show();
            }
        }

        void LbL_HistoryTransactions_Click(object sender, EventArgs e)
        {
            HistoryTransactions historyTransactions = new HistoryTransactions();
            if (Application.OpenForms["HistoryTransactions"] == null)
            {
                historyTransactions.Show();
            }
        }

        void TxB_transferMobilePhone_Click(object sender, EventArgs e)
        {
            if (txB_transferMobilePhone.Text == "")
            {
                txB_transferMobilePhone.Text = "+79";
                txB_transferMobilePhone.SelectionStart = txB_transferMobilePhone.Text.Length;
            }
        }

        void Btn_transferMobilePhone_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txB_transferMobilePhone.Text, "^[+][7][9][0-9]{9}$"))
            {
                MessageBox.Show("Пожалуйста введите номер телефона корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txB_transferMobilePhone.Select();
                return;
            }
            MobilePhoneTransferForm mobilePhoneTransfer = new MobilePhoneTransferForm();
            if (Application.OpenForms["MobilePhoneTransferForm"] == null)
            {
                DataStorage.cardNumberUser = cmb_card.GetItemText(cmb_card.SelectedItem);
                DataStorage.phoneNumber = txB_transferMobilePhone.Text;

                DataStorage.cardDate = lbL_cardDate.Text.Trim();
                DataStorage.dolar = lbL_сourse_dollar.Text.Trim();
                DataStorage.euro = lbL_сourse_euro.Text.Trim();
                DataStorage.currency = lbl_currency.Text.Trim();
                DataStorage.balanceCard = lbL_balanceCard.Text.Trim();
                mobilePhoneTransfer.ShowDialog();
                Btn_udpate_Click(sender, e);
                txB_transferMobilePhone.Text = "";
            }
        }

        void Btn_communalPayments_Click(object sender, EventArgs e)
        {
            CommunalPayments communalPayments = new CommunalPayments();
            if (Application.OpenForms["CommunalPayments"] == null)
            {
                DataStorage.cardNumberUser = cmb_card.GetItemText(cmb_card.SelectedItem);
                DataStorage.cardDate = lbL_cardDate.Text.Trim();
                DataStorage.dolar = lbL_сourse_dollar.Text.Trim();
                DataStorage.euro = lbL_сourse_euro.Text.Trim();
                DataStorage.currency = lbl_currency.Text.Trim();
                DataStorage.balanceCard = lbL_balanceCard.Text.Trim();
                communalPayments.ShowDialog();
                Btn_udpate_Click(sender, e);
            }
        }
    }
}
