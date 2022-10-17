using System;
using System.Windows.Forms;

namespace MobileBank.Forms
{
    public partial class AddBankCard : Form
    {
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
    }
}
