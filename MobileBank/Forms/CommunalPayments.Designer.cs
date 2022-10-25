namespace MobileBank.Forms
{
    partial class CommunalPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommunalPayments));
            this.btn_close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_servicesCommunalPayments = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txB_personalAccountCommunalPayments = new System.Windows.Forms.TextBox();
            this.lbL_currency = new System.Windows.Forms.Label();
            this.txB_sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TransferCommunalPayments = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txB_cardCvv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txB_cardDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txB_card_numberUser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(396, 15);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label14.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(49, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 22);
            this.label14.TabIndex = 35;
            this.label14.Text = "Коммунальные платежи";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Услуги";
            // 
            // cmb_servicesCommunalPayments
            // 
            this.cmb_servicesCommunalPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_servicesCommunalPayments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_servicesCommunalPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_servicesCommunalPayments.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_servicesCommunalPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_servicesCommunalPayments.FormattingEnabled = true;
            this.cmb_servicesCommunalPayments.Location = new System.Drawing.Point(119, 78);
            this.cmb_servicesCommunalPayments.Name = "cmb_servicesCommunalPayments";
            this.cmb_servicesCommunalPayments.Size = new System.Drawing.Size(210, 27);
            this.cmb_servicesCommunalPayments.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(116, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Лицевой счёт";
            // 
            // txB_personalAccountCommunalPayments
            // 
            this.txB_personalAccountCommunalPayments.BackColor = System.Drawing.Color.DimGray;
            this.txB_personalAccountCommunalPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_personalAccountCommunalPayments.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_personalAccountCommunalPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_personalAccountCommunalPayments.Location = new System.Drawing.Point(119, 134);
            this.txB_personalAccountCommunalPayments.MaxLength = 12;
            this.txB_personalAccountCommunalPayments.Name = "txB_personalAccountCommunalPayments";
            this.txB_personalAccountCommunalPayments.Size = new System.Drawing.Size(210, 26);
            this.txB_personalAccountCommunalPayments.TabIndex = 49;
            this.txB_personalAccountCommunalPayments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_personalAccountCommunalPayments_KeyPress);
            // 
            // lbL_currency
            // 
            this.lbL_currency.AutoSize = true;
            this.lbL_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbL_currency.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_currency.ForeColor = System.Drawing.Color.DimGray;
            this.lbL_currency.Location = new System.Drawing.Point(335, 204);
            this.lbL_currency.Name = "lbL_currency";
            this.lbL_currency.Size = new System.Drawing.Size(39, 19);
            this.lbL_currency.TabIndex = 54;
            this.lbL_currency.Text = "RUB";
            // 
            // txB_sum
            // 
            this.txB_sum.BackColor = System.Drawing.Color.DimGray;
            this.txB_sum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_sum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_sum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_sum.Location = new System.Drawing.Point(119, 199);
            this.txB_sum.MaxLength = 12;
            this.txB_sum.Name = "txB_sum";
            this.txB_sum.Size = new System.Drawing.Size(210, 26);
            this.txB_sum.TabIndex = 52;
            this.txB_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_sum_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(118, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "...................................................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(116, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Сумма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.GreenYellow;
            this.label5.Location = new System.Drawing.Point(118, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "...................................................";
            // 
            // btn_TransferCommunalPayments
            // 
            this.btn_TransferCommunalPayments.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_TransferCommunalPayments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TransferCommunalPayments.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_TransferCommunalPayments.ForeColor = System.Drawing.Color.Black;
            this.btn_TransferCommunalPayments.Location = new System.Drawing.Point(33, 466);
            this.btn_TransferCommunalPayments.Name = "btn_TransferCommunalPayments";
            this.btn_TransferCommunalPayments.Size = new System.Drawing.Size(368, 45);
            this.btn_TransferCommunalPayments.TabIndex = 60;
            this.btn_TransferCommunalPayments.Text = "Оплатить";
            this.btn_TransferCommunalPayments.UseVisualStyleBackColor = false;
            this.btn_TransferCommunalPayments.Click += new System.EventHandler(this.Btn_TransferCommunalPayments_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txB_cardCvv);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txB_cardDate);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txB_card_numberUser);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(33, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 180);
            this.panel2.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(15, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "............................................................................";
            // 
            // txB_cardCvv
            // 
            this.txB_cardCvv.BackColor = System.Drawing.Color.DimGray;
            this.txB_cardCvv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_cardCvv.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txB_cardCvv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_cardCvv.Location = new System.Drawing.Point(259, 122);
            this.txB_cardCvv.MaxLength = 3;
            this.txB_cardCvv.Name = "txB_cardCvv";
            this.txB_cardCvv.Size = new System.Drawing.Size(37, 23);
            this.txB_cardCvv.TabIndex = 45;
            this.txB_cardCvv.Text = "***";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(255, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "CVV-код";
            // 
            // txB_cardDate
            // 
            this.txB_cardDate.BackColor = System.Drawing.Color.DimGray;
            this.txB_cardDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_cardDate.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txB_cardDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_cardDate.Location = new System.Drawing.Point(18, 122);
            this.txB_cardDate.MaxLength = 5;
            this.txB_cardDate.Name = "txB_cardDate";
            this.txB_cardDate.ReadOnly = true;
            this.txB_cardDate.Size = new System.Drawing.Size(50, 23);
            this.txB_cardDate.TabIndex = 43;
            this.txB_cardDate.Text = "07/26";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(14, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Срок действия";
            // 
            // txB_card_numberUser
            // 
            this.txB_card_numberUser.BackColor = System.Drawing.Color.DimGray;
            this.txB_card_numberUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_card_numberUser.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_card_numberUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_card_numberUser.Location = new System.Drawing.Point(18, 42);
            this.txB_card_numberUser.MaxLength = 19;
            this.txB_card_numberUser.Name = "txB_card_numberUser";
            this.txB_card_numberUser.ReadOnly = true;
            this.txB_card_numberUser.Size = new System.Drawing.Size(308, 26);
            this.txB_card_numberUser.TabIndex = 41;
            this.txB_card_numberUser.Text = "0000 0000 0000 0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(15, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "............................................................................";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(14, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Номер карты";
            // 
            // CommunalPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(434, 532);
            this.Controls.Add(this.btn_TransferCommunalPayments);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txB_personalAccountCommunalPayments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbL_currency);
            this.Controls.Add(this.txB_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_servicesCommunalPayments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommunalPayments";
            this.Text = "CommunalPayments";
            this.Load += new System.EventHandler(this.CommunalPayments_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommunalPayments_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CommunalPayments_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CommunalPayments_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_servicesCommunalPayments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txB_personalAccountCommunalPayments;
        private System.Windows.Forms.Label lbL_currency;
        private System.Windows.Forms.TextBox txB_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TransferCommunalPayments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txB_cardCvv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txB_cardDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txB_card_numberUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}