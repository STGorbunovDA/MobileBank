namespace MobileBank.Forms
{
    partial class ChangePhoneNumber
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
            this.txB_client_phone_number = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_ChangeNumberPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(284, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // txB_client_phone_number
            // 
            this.txB_client_phone_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txB_client_phone_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_client_phone_number.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_client_phone_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_client_phone_number.Location = new System.Drawing.Point(15, 85);
            this.txB_client_phone_number.MaxLength = 12;
            this.txB_client_phone_number.Name = "txB_client_phone_number";
            this.txB_client_phone_number.Size = new System.Drawing.Size(288, 26);
            this.txB_client_phone_number.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(43, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 19);
            this.label16.TabIndex = 32;
            this.label16.Text = "Введите номер телефона";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.GreenYellow;
            this.label15.Location = new System.Drawing.Point(12, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(291, 16);
            this.label15.TabIndex = 34;
            this.label15.Text = ".......................................................................";
            // 
            // btn_ChangeNumberPhone
            // 
            this.btn_ChangeNumberPhone.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ChangeNumberPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangeNumberPhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeNumberPhone.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeNumberPhone.Location = new System.Drawing.Point(15, 147);
            this.btn_ChangeNumberPhone.Name = "btn_ChangeNumberPhone";
            this.btn_ChangeNumberPhone.Size = new System.Drawing.Size(288, 48);
            this.btn_ChangeNumberPhone.TabIndex = 36;
            this.btn_ChangeNumberPhone.Text = "Изменить номер телефона";
            this.btn_ChangeNumberPhone.UseVisualStyleBackColor = false;
            this.btn_ChangeNumberPhone.Click += new System.EventHandler(this.Btn_ChangeNumberPhone_Click);
            // 
            // ChangePhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(320, 221);
            this.Controls.Add(this.btn_ChangeNumberPhone);
            this.Controls.Add(this.txB_client_phone_number);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePhoneNumber";
            this.Text = "ChangePhoneNumber";
            this.Load += new System.EventHandler(this.ChangePhoneNumber_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePhoneNumber_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePhoneNumber_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangePhoneNumber_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txB_client_phone_number;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_ChangeNumberPhone;
    }
}