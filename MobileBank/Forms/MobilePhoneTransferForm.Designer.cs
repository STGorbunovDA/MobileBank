namespace MobileBank.Forms
{
    partial class MobilePhoneTransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobilePhoneTransferForm));
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txB_transferMobilePhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_serviceTypeMobileOperator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txB_sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbL_currency = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbL_commissionTransferPhone = new System.Windows.Forms.Label();
            this.lbL_paymentTransferPhone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txB_cardCvv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txB_cardDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txB_card_numberUser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_TransferPhone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(420, 14);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(79, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 0);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // txB_transferMobilePhone
            // 
            this.txB_transferMobilePhone.BackColor = System.Drawing.Color.DimGray;
            this.txB_transferMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_transferMobilePhone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_transferMobilePhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_transferMobilePhone.Location = new System.Drawing.Point(117, 78);
            this.txB_transferMobilePhone.MaxLength = 12;
            this.txB_transferMobilePhone.Name = "txB_transferMobilePhone";
            this.txB_transferMobilePhone.Size = new System.Drawing.Size(210, 26);
            this.txB_transferMobilePhone.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Номер";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.GreenYellow;
            this.label15.Location = new System.Drawing.Point(116, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 16);
            this.label15.TabIndex = 45;
            this.label15.Text = "...................................................";
            // 
            // cmb_serviceTypeMobileOperator
            // 
            this.cmb_serviceTypeMobileOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_serviceTypeMobileOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_serviceTypeMobileOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_serviceTypeMobileOperator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_serviceTypeMobileOperator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_serviceTypeMobileOperator.FormattingEnabled = true;
            this.cmb_serviceTypeMobileOperator.Location = new System.Drawing.Point(117, 126);
            this.cmb_serviceTypeMobileOperator.Name = "cmb_serviceTypeMobileOperator";
            this.cmb_serviceTypeMobileOperator.Size = new System.Drawing.Size(210, 27);
            this.cmb_serviceTypeMobileOperator.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(114, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Сумма";
            // 
            // txB_sum
            // 
            this.txB_sum.BackColor = System.Drawing.Color.DimGray;
            this.txB_sum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_sum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_sum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_sum.Location = new System.Drawing.Point(117, 186);
            this.txB_sum.MaxLength = 12;
            this.txB_sum.Name = "txB_sum";
            this.txB_sum.Size = new System.Drawing.Size(210, 26);
            this.txB_sum.TabIndex = 48;
            this.txB_sum.TextChanged += new System.EventHandler(this.TxB_sumTransferPhone_TextChanged_1);
            this.txB_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_sumTransferPhone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(116, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "...................................................";
            // 
            // lbL_currency
            // 
            this.lbL_currency.AutoSize = true;
            this.lbL_currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbL_currency.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_currency.ForeColor = System.Drawing.Color.DimGray;
            this.lbL_currency.Location = new System.Drawing.Point(333, 191);
            this.lbL_currency.Name = "lbL_currency";
            this.lbL_currency.Size = new System.Drawing.Size(39, 19);
            this.lbL_currency.TabIndex = 50;
            this.lbL_currency.Text = "RUB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(116, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Комиссия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(116, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "К оплате:";
            // 
            // lbL_commissionTransferPhone
            // 
            this.lbL_commissionTransferPhone.AutoSize = true;
            this.lbL_commissionTransferPhone.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbL_commissionTransferPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_commissionTransferPhone.Location = new System.Drawing.Point(251, 245);
            this.lbL_commissionTransferPhone.Name = "lbL_commissionTransferPhone";
            this.lbL_commissionTransferPhone.Size = new System.Drawing.Size(13, 13);
            this.lbL_commissionTransferPhone.TabIndex = 53;
            this.lbL_commissionTransferPhone.Text = "0";
            // 
            // lbL_paymentTransferPhone
            // 
            this.lbL_paymentTransferPhone.AutoSize = true;
            this.lbL_paymentTransferPhone.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbL_paymentTransferPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_paymentTransferPhone.Location = new System.Drawing.Point(251, 279);
            this.lbL_paymentTransferPhone.Name = "lbL_paymentTransferPhone";
            this.lbL_paymentTransferPhone.Size = new System.Drawing.Size(13, 13);
            this.lbL_paymentTransferPhone.TabIndex = 54;
            this.lbL_paymentTransferPhone.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(333, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "RUB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(333, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "RUB";
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
            this.panel2.Location = new System.Drawing.Point(45, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 180);
            this.panel2.TabIndex = 57;
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
            // btn_TransferPhone
            // 
            this.btn_TransferPhone.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_TransferPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TransferPhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_TransferPhone.ForeColor = System.Drawing.Color.Black;
            this.btn_TransferPhone.Location = new System.Drawing.Point(45, 520);
            this.btn_TransferPhone.Name = "btn_TransferPhone";
            this.btn_TransferPhone.Size = new System.Drawing.Size(368, 45);
            this.btn_TransferPhone.TabIndex = 58;
            this.btn_TransferPhone.Text = "Пополнить счёт";
            this.btn_TransferPhone.UseVisualStyleBackColor = false;
            this.btn_TransferPhone.Click += new System.EventHandler(this.Btn_TransferPhone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(48, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 22);
            this.label4.TabIndex = 60;
            this.label4.Text = "Пополнение мобильного";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // MobilePhoneTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(456, 585);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_TransferPhone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbL_paymentTransferPhone);
            this.Controls.Add(this.lbL_commissionTransferPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbL_currency);
            this.Controls.Add(this.txB_transferMobilePhone);
            this.Controls.Add(this.txB_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_serviceTypeMobileOperator);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MobilePhoneTransferForm";
            this.Text = "MobilePhoneTransferForm";
            this.Load += new System.EventHandler(this.MobilePhoneTransferForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MobilePhoneTransferForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MobilePhoneTransferForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MobilePhoneTransferForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txB_transferMobilePhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_serviceTypeMobileOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txB_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbL_currency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbL_commissionTransferPhone;
        private System.Windows.Forms.Label lbL_paymentTransferPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txB_cardCvv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txB_cardDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txB_card_numberUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_TransferPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}