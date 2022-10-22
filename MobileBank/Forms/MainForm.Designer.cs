namespace MobileBank.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbL_HistoryTransactions = new System.Windows.Forms.PictureBox();
            this.picB_user = new System.Windows.Forms.PictureBox();
            this.lbL_сourse_dollar = new System.Windows.Forms.Label();
            this.lbL_сourse_euro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_adding_card = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_card = new System.Windows.Forms.ComboBox();
            this.picB_bancCard = new System.Windows.Forms.PictureBox();
            this.lbL_card_number = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbL_cardDate = new System.Windows.Forms.Label();
            this.lbL_client_FIO = new System.Windows.Forms.Label();
            this.picB_visa = new System.Windows.Forms.PictureBox();
            this.picB_masterCard = new System.Windows.Forms.PictureBox();
            this.lbL_cardCvv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbL_balanceCard = new System.Windows.Forms.Label();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.btn_udpate = new System.Windows.Forms.Button();
            this.panel_MoneyTransferCard = new System.Windows.Forms.Panel();
            this.btn_MoneyTransferCard = new System.Windows.Forms.Button();
            this.txB_NumberTransferCardMoney = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbL_HistoryTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_bancCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_visa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_masterCard)).BeginInit();
            this.panel_MoneyTransferCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lbL_HistoryTransactions);
            this.panel1.Controls.Add(this.picB_user);
            this.panel1.Controls.Add(this.lbL_сourse_dollar);
            this.panel1.Controls.Add(this.lbL_сourse_euro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // lbL_HistoryTransactions
            // 
            this.lbL_HistoryTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbL_HistoryTransactions.BackgroundImage")));
            this.lbL_HistoryTransactions.Location = new System.Drawing.Point(50, 6);
            this.lbL_HistoryTransactions.Name = "lbL_HistoryTransactions";
            this.lbL_HistoryTransactions.Size = new System.Drawing.Size(32, 32);
            this.lbL_HistoryTransactions.TabIndex = 34;
            this.lbL_HistoryTransactions.TabStop = false;
            this.lbL_HistoryTransactions.Click += new System.EventHandler(this.LbL_HistoryTransactions_Click);
            // 
            // picB_user
            // 
            this.picB_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_user.BackgroundImage")));
            this.picB_user.Location = new System.Drawing.Point(12, 6);
            this.picB_user.Name = "picB_user";
            this.picB_user.Size = new System.Drawing.Size(32, 35);
            this.picB_user.TabIndex = 33;
            this.picB_user.TabStop = false;
            this.picB_user.Click += new System.EventHandler(this.PicB_user_Click);
            // 
            // lbL_сourse_dollar
            // 
            this.lbL_сourse_dollar.AutoSize = true;
            this.lbL_сourse_dollar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_сourse_dollar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_сourse_dollar.Location = new System.Drawing.Point(621, 15);
            this.lbL_сourse_dollar.Name = "lbL_сourse_dollar";
            this.lbL_сourse_dollar.Size = new System.Drawing.Size(59, 16);
            this.lbL_сourse_dollar.TabIndex = 5;
            this.lbL_сourse_dollar.Text = "Доллар";
            // 
            // lbL_сourse_euro
            // 
            this.lbL_сourse_euro.AutoSize = true;
            this.lbL_сourse_euro.BackColor = System.Drawing.Color.DimGray;
            this.lbL_сourse_euro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_сourse_euro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_сourse_euro.Location = new System.Drawing.Point(537, 15);
            this.lbL_сourse_euro.Name = "lbL_сourse_euro";
            this.lbL_сourse_euro.Size = new System.Drawing.Size(38, 16);
            this.lbL_сourse_euro.TabIndex = 2;
            this.lbL_сourse_euro.Text = "Евро";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(597, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(609, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(523, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "€";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(686, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_adding_card
            // 
            this.btn_adding_card.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_adding_card.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adding_card.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_adding_card.ForeColor = System.Drawing.Color.Black;
            this.btn_adding_card.Location = new System.Drawing.Point(470, 88);
            this.btn_adding_card.Name = "btn_adding_card";
            this.btn_adding_card.Size = new System.Drawing.Size(90, 27);
            this.btn_adding_card.TabIndex = 10;
            this.btn_adding_card.Text = "Добавить";
            this.btn_adding_card.UseVisualStyleBackColor = false;
            this.btn_adding_card.Click += new System.EventHandler(this.Btn_adding_card_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(152, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Карты:";
            // 
            // cmb_card
            // 
            this.cmb_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_card.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_card.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_card.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_card.FormattingEnabled = true;
            this.cmb_card.Location = new System.Drawing.Point(229, 87);
            this.cmb_card.Name = "cmb_card";
            this.cmb_card.Size = new System.Drawing.Size(235, 27);
            this.cmb_card.TabIndex = 19;
            this.cmb_card.SelectionChangeCommitted += new System.EventHandler(this.Cmb_card_SelectionChangeCommitted);
            // 
            // picB_bancCard
            // 
            this.picB_bancCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picB_bancCard.BackColor = System.Drawing.Color.Transparent;
            this.picB_bancCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_bancCard.BackgroundImage")));
            this.picB_bancCard.Location = new System.Drawing.Point(156, 133);
            this.picB_bancCard.Name = "picB_bancCard";
            this.picB_bancCard.Size = new System.Drawing.Size(404, 225);
            this.picB_bancCard.TabIndex = 20;
            this.picB_bancCard.TabStop = false;
            // 
            // lbL_card_number
            // 
            this.lbL_card_number.AutoSize = true;
            this.lbL_card_number.BackColor = System.Drawing.Color.DimGray;
            this.lbL_card_number.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_card_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_card_number.Location = new System.Drawing.Point(234, 193);
            this.lbL_card_number.Name = "lbL_card_number";
            this.lbL_card_number.Size = new System.Drawing.Size(279, 33);
            this.lbL_card_number.TabIndex = 21;
            this.lbL_card_number.Text = "4276 4200 4302 8918";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(416, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 10);
            this.label5.TabIndex = 7;
            this.label5.Text = "MONTH/YEAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(378, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 10);
            this.label6.TabIndex = 22;
            this.label6.Text = "VALID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(378, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 10);
            this.label7.TabIndex = 23;
            this.label7.Text = "THRU";
            // 
            // lbL_cardDate
            // 
            this.lbL_cardDate.AutoSize = true;
            this.lbL_cardDate.BackColor = System.Drawing.Color.DimGray;
            this.lbL_cardDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_cardDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_cardDate.Location = new System.Drawing.Point(420, 312);
            this.lbL_cardDate.Name = "lbL_cardDate";
            this.lbL_cardDate.Size = new System.Drawing.Size(57, 23);
            this.lbL_cardDate.TabIndex = 24;
            this.lbL_cardDate.Text = "11/24";
            // 
            // lbL_client_FIO
            // 
            this.lbL_client_FIO.AutoSize = true;
            this.lbL_client_FIO.BackColor = System.Drawing.Color.DimGray;
            this.lbL_client_FIO.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_client_FIO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_client_FIO.Location = new System.Drawing.Point(175, 254);
            this.lbL_client_FIO.Name = "lbL_client_FIO";
            this.lbL_client_FIO.Size = new System.Drawing.Size(215, 23);
            this.lbL_client_FIO.TabIndex = 25;
            this.lbL_client_FIO.Text = "Иванов Иван Иванович";
            // 
            // picB_visa
            // 
            this.picB_visa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picB_visa.BackColor = System.Drawing.Color.DimGray;
            this.picB_visa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_visa.BackgroundImage")));
            this.picB_visa.Location = new System.Drawing.Point(486, 298);
            this.picB_visa.Name = "picB_visa";
            this.picB_visa.Size = new System.Drawing.Size(50, 50);
            this.picB_visa.TabIndex = 26;
            this.picB_visa.TabStop = false;
            // 
            // picB_masterCard
            // 
            this.picB_masterCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picB_masterCard.BackColor = System.Drawing.Color.DimGray;
            this.picB_masterCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_masterCard.BackgroundImage")));
            this.picB_masterCard.Location = new System.Drawing.Point(488, 298);
            this.picB_masterCard.Name = "picB_masterCard";
            this.picB_masterCard.Size = new System.Drawing.Size(50, 50);
            this.picB_masterCard.TabIndex = 27;
            this.picB_masterCard.TabStop = false;
            // 
            // lbL_cardCvv
            // 
            this.lbL_cardCvv.AutoSize = true;
            this.lbL_cardCvv.BackColor = System.Drawing.Color.DimGray;
            this.lbL_cardCvv.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_cardCvv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_cardCvv.Location = new System.Drawing.Point(187, 233);
            this.lbL_cardCvv.Name = "lbL_cardCvv";
            this.lbL_cardCvv.Size = new System.Drawing.Size(20, 10);
            this.lbL_cardCvv.TabIndex = 28;
            this.lbL_cardCvv.Text = "CVV";
            this.lbL_cardCvv.Click += new System.EventHandler(this.LbL_cardCvv_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(200, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Баланс:";
            // 
            // lbL_balanceCard
            // 
            this.lbL_balanceCard.AutoSize = true;
            this.lbL_balanceCard.BackColor = System.Drawing.Color.DimGray;
            this.lbL_balanceCard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_balanceCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_balanceCard.Location = new System.Drawing.Point(266, 305);
            this.lbL_balanceCard.Name = "lbL_balanceCard";
            this.lbL_balanceCard.Size = new System.Drawing.Size(41, 19);
            this.lbL_balanceCard.TabIndex = 30;
            this.lbL_balanceCard.Text = "0.00";
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.BackColor = System.Drawing.Color.DimGray;
            this.lbl_currency.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_currency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_currency.Location = new System.Drawing.Point(218, 323);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(27, 13);
            this.lbl_currency.TabIndex = 31;
            this.lbl_currency.Text = "RUB";
            // 
            // btn_udpate
            // 
            this.btn_udpate.BackColor = System.Drawing.Color.Transparent;
            this.btn_udpate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_udpate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_udpate.ForeColor = System.Drawing.Color.Gray;
            this.btn_udpate.Image = ((System.Drawing.Image)(resources.GetObject("btn_udpate.Image")));
            this.btn_udpate.Location = new System.Drawing.Point(667, 52);
            this.btn_udpate.Name = "btn_udpate";
            this.btn_udpate.Size = new System.Drawing.Size(43, 41);
            this.btn_udpate.TabIndex = 7;
            this.btn_udpate.UseVisualStyleBackColor = false;
            this.btn_udpate.Click += new System.EventHandler(this.Btn_udpate_Click);
            // 
            // panel_MoneyTransferCard
            // 
            this.panel_MoneyTransferCard.BackColor = System.Drawing.Color.DimGray;
            this.panel_MoneyTransferCard.Controls.Add(this.btn_MoneyTransferCard);
            this.panel_MoneyTransferCard.Controls.Add(this.txB_NumberTransferCardMoney);
            this.panel_MoneyTransferCard.Controls.Add(this.label10);
            this.panel_MoneyTransferCard.Controls.Add(this.label9);
            this.panel_MoneyTransferCard.Controls.Add(this.pictureBox1);
            this.panel_MoneyTransferCard.Location = new System.Drawing.Point(12, 385);
            this.panel_MoneyTransferCard.Name = "panel_MoneyTransferCard";
            this.panel_MoneyTransferCard.Size = new System.Drawing.Size(324, 108);
            this.panel_MoneyTransferCard.TabIndex = 32;
            // 
            // btn_MoneyTransferCard
            // 
            this.btn_MoneyTransferCard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MoneyTransferCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MoneyTransferCard.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_MoneyTransferCard.ForeColor = System.Drawing.Color.Black;
            this.btn_MoneyTransferCard.Location = new System.Drawing.Point(282, 44);
            this.btn_MoneyTransferCard.Name = "btn_MoneyTransferCard";
            this.btn_MoneyTransferCard.Size = new System.Drawing.Size(30, 30);
            this.btn_MoneyTransferCard.TabIndex = 7;
            this.btn_MoneyTransferCard.Text = ">";
            this.btn_MoneyTransferCard.UseVisualStyleBackColor = false;
            this.btn_MoneyTransferCard.Click += new System.EventHandler(this.Btn_MoneyTransferCard_Click);
            // 
            // txB_NumberTransferCardMoney
            // 
            this.txB_NumberTransferCardMoney.BackColor = System.Drawing.Color.DimGray;
            this.txB_NumberTransferCardMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_NumberTransferCardMoney.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_NumberTransferCardMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_NumberTransferCardMoney.Location = new System.Drawing.Point(10, 48);
            this.txB_NumberTransferCardMoney.MaxLength = 19;
            this.txB_NumberTransferCardMoney.Name = "txB_NumberTransferCardMoney";
            this.txB_NumberTransferCardMoney.Size = new System.Drawing.Size(251, 26);
            this.txB_NumberTransferCardMoney.TabIndex = 40;
            this.txB_NumberTransferCardMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_NumberTransferCardMoney_KeyPress);
            this.txB_NumberTransferCardMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxB_NumberTransferCardMoney_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(7, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "...............................................................";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(42, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Перевод на карту";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(722, 716);
            this.Controls.Add(this.panel_MoneyTransferCard);
            this.Controls.Add(this.btn_udpate);
            this.Controls.Add(this.lbl_currency);
            this.Controls.Add(this.lbL_balanceCard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbL_cardCvv);
            this.Controls.Add(this.picB_masterCard);
            this.Controls.Add(this.picB_visa);
            this.Controls.Add(this.lbL_client_FIO);
            this.Controls.Add(this.lbL_cardDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbL_card_number);
            this.Controls.Add(this.picB_bancCard);
            this.Controls.Add(this.cmb_card);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_adding_card);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbL_HistoryTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_bancCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_visa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_masterCard)).EndInit();
            this.panel_MoneyTransferCard.ResumeLayout(false);
            this.panel_MoneyTransferCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbL_сourse_euro;
        private System.Windows.Forms.Label lbL_сourse_dollar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_adding_card;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_card;
        private System.Windows.Forms.PictureBox picB_bancCard;
        private System.Windows.Forms.Label lbL_card_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbL_cardDate;
        private System.Windows.Forms.Label lbL_client_FIO;
        private System.Windows.Forms.PictureBox picB_visa;
        private System.Windows.Forms.PictureBox picB_masterCard;
        private System.Windows.Forms.Label lbL_cardCvv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbL_balanceCard;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.Button btn_udpate;
        private System.Windows.Forms.Panel panel_MoneyTransferCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_MoneyTransferCard;
        private System.Windows.Forms.TextBox txB_NumberTransferCardMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picB_user;
        private System.Windows.Forms.PictureBox lbL_HistoryTransactions;
    }
}