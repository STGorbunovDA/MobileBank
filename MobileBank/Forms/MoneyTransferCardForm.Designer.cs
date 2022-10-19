namespace MobileBank.Forms
{
    partial class MoneyTransferCardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txB_sum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txB_NumberTransferCardMoney = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txB_cardCvv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txB_cardDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txB_card_numberUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(514, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.btn_Transfer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txB_sum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 518);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_Transfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Transfer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Transfer.ForeColor = System.Drawing.Color.Black;
            this.btn_Transfer.Location = new System.Drawing.Point(257, 416);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(202, 45);
            this.btn_Transfer.TabIndex = 49;
            this.btn_Transfer.Text = "Перевести";
            this.btn_Transfer.UseVisualStyleBackColor = false;
            this.btn_Transfer.Click += new System.EventHandler(this.Btn_Transfer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(88, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = ".................................";
            // 
            // txB_sum
            // 
            this.txB_sum.BackColor = System.Drawing.Color.DimGray;
            this.txB_sum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_sum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_sum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_sum.Location = new System.Drawing.Point(91, 416);
            this.txB_sum.Name = "txB_sum";
            this.txB_sum.Size = new System.Drawing.Size(130, 26);
            this.txB_sum.TabIndex = 42;
            this.txB_sum.Text = "0";
            this.txB_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_sum_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(87, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Сумма";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.txB_NumberTransferCardMoney);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(91, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 99);
            this.panel3.TabIndex = 47;
            // 
            // txB_NumberTransferCardMoney
            // 
            this.txB_NumberTransferCardMoney.BackColor = System.Drawing.Color.DimGray;
            this.txB_NumberTransferCardMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_NumberTransferCardMoney.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_NumberTransferCardMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_NumberTransferCardMoney.Location = new System.Drawing.Point(18, 42);
            this.txB_NumberTransferCardMoney.MaxLength = 19;
            this.txB_NumberTransferCardMoney.Name = "txB_NumberTransferCardMoney";
            this.txB_NumberTransferCardMoney.Size = new System.Drawing.Size(308, 26);
            this.txB_NumberTransferCardMoney.TabIndex = 41;
            this.txB_NumberTransferCardMoney.Text = "0000 0000 0000 0000";
            this.txB_NumberTransferCardMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_NumberTransferCardMoney_KeyPress);
            this.txB_NumberTransferCardMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxB_NumberTransferCardMoney_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(15, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(311, 16);
            this.label11.TabIndex = 40;
            this.label11.Text = "............................................................................";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(14, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Номер карты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(87, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Карта получателя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(87, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "C карты:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txB_cardCvv);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txB_cardDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txB_card_numberUser);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(91, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 180);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "............................................................................";
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
            this.txB_cardCvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_cardCvv_KeyPress);
            this.txB_cardCvv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxB_cardCvv_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(255, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "CVV-код";
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
            this.txB_cardDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxB_cardDate_KeyPress);
            this.txB_cardDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxB_cardDate_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Срок действия";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(15, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "............................................................................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номер карты";
            // 
            // MoneyTransferCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(550, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyTransferCardForm";
            this.Text = "MoneyTransferCardForm";
            this.Load += new System.EventHandler(this.MoneyTransferCardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txB_card_numberUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txB_cardCvv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txB_cardDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txB_NumberTransferCardMoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Transfer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txB_sum;
        private System.Windows.Forms.Label label7;
    }
}