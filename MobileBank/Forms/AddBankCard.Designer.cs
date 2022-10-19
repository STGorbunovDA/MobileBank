namespace MobileBank.Forms
{
    partial class AddBankCard
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
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbL_enterNumberPhone = new System.Windows.Forms.Label();
            this.cmB_type_card = new System.Windows.Forms.ComboBox();
            this.cmB_currency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmB_payment_system = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save_client = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txB_cardPin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(267, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип карты";
            // 
            // lbL_enterNumberPhone
            // 
            this.lbL_enterNumberPhone.AutoSize = true;
            this.lbL_enterNumberPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_enterNumberPhone.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbL_enterNumberPhone.Location = new System.Drawing.Point(12, 103);
            this.lbL_enterNumberPhone.Name = "lbL_enterNumberPhone";
            this.lbL_enterNumberPhone.Size = new System.Drawing.Size(287, 16);
            this.lbL_enterNumberPhone.TabIndex = 10;
            this.lbL_enterNumberPhone.Text = "......................................................................";
            // 
            // cmB_type_card
            // 
            this.cmB_type_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmB_type_card.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmB_type_card.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmB_type_card.FormattingEnabled = true;
            this.cmB_type_card.Items.AddRange(new object[] {
            "Дебетовая",
            "Кредитная"});
            this.cmB_type_card.Location = new System.Drawing.Point(15, 73);
            this.cmB_type_card.Name = "cmB_type_card";
            this.cmB_type_card.Size = new System.Drawing.Size(280, 27);
            this.cmB_type_card.TabIndex = 11;
            this.cmB_type_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmB_type_card_KeyPress);
            // 
            // cmB_currency
            // 
            this.cmB_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmB_currency.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmB_currency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmB_currency.FormattingEnabled = true;
            this.cmB_currency.Items.AddRange(new object[] {
            "RUB",
            "USD",
            "EUR"});
            this.cmB_currency.Location = new System.Drawing.Point(15, 155);
            this.cmB_currency.Name = "cmB_currency";
            this.cmB_currency.Size = new System.Drawing.Size(280, 27);
            this.cmB_currency.TabIndex = 14;
            this.cmB_currency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmB_currency_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Валюта";
            // 
            // cmB_payment_system
            // 
            this.cmB_payment_system.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmB_payment_system.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmB_payment_system.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmB_payment_system.FormattingEnabled = true;
            this.cmB_payment_system.Items.AddRange(new object[] {
            "Visa",
            "Mastercard"});
            this.cmB_payment_system.Location = new System.Drawing.Point(15, 238);
            this.cmB_payment_system.Name = "cmB_payment_system";
            this.cmB_payment_system.Size = new System.Drawing.Size(280, 27);
            this.cmB_payment_system.TabIndex = 17;
            this.cmB_payment_system.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmB_payment_system_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Платёжная система";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "PIN-код";
            // 
            // btn_save_client
            // 
            this.btn_save_client.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_save_client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_client.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save_client.ForeColor = System.Drawing.Color.Black;
            this.btn_save_client.Location = new System.Drawing.Point(15, 374);
            this.btn_save_client.Name = "btn_save_client";
            this.btn_save_client.Size = new System.Drawing.Size(280, 46);
            this.btn_save_client.TabIndex = 33;
            this.btn_save_client.Text = "Создать";
            this.btn_save_client.UseVisualStyleBackColor = false;
            this.btn_save_client.Click += new System.EventHandler(this.Btn_save_and_client_new_card_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txB_cardPin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_save_client);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmB_payment_system);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmB_currency);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmB_type_card);
            this.panel1.Controls.Add(this.lbL_enterNumberPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 445);
            this.panel1.TabIndex = 34;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // txB_cardPin
            // 
            this.txB_cardPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txB_cardPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_cardPin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_cardPin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_cardPin.Location = new System.Drawing.Point(16, 320);
            this.txB_cardPin.Name = "txB_cardPin";
            this.txB_cardPin.Size = new System.Drawing.Size(279, 20);
            this.txB_cardPin.TabIndex = 38;
            this.txB_cardPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_cardPin_KeyPress);
            this.txB_cardPin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxB_cardPin_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(13, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "......................................................................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "......................................................................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(13, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "......................................................................";
            // 
            // AddBankCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(303, 445);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBankCard";
            this.Text = "AddBankCard";
            this.Load += new System.EventHandler(this.AddBankCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbL_enterNumberPhone;
        private System.Windows.Forms.ComboBox cmB_type_card;
        private System.Windows.Forms.ComboBox cmB_currency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmB_payment_system;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save_client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txB_cardPin;
    }
}