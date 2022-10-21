namespace MobileBank.Forms
{
    partial class Validations
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
            this.txB_cardPin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_confirm_card_pin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(234, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txB_cardPin
            // 
            this.txB_cardPin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txB_cardPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_cardPin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_cardPin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_cardPin.Location = new System.Drawing.Point(12, 58);
            this.txB_cardPin.Name = "txB_cardPin";
            this.txB_cardPin.Size = new System.Drawing.Size(240, 20);
            this.txB_cardPin.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.GreenYellow;
            this.label6.Location = new System.Drawing.Point(9, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "............................................................";
            // 
            // btn_confirm_card_pin
            // 
            this.btn_confirm_card_pin.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_confirm_card_pin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirm_card_pin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_confirm_card_pin.ForeColor = System.Drawing.Color.Black;
            this.btn_confirm_card_pin.Location = new System.Drawing.Point(11, 112);
            this.btn_confirm_card_pin.Name = "btn_confirm_card_pin";
            this.btn_confirm_card_pin.Size = new System.Drawing.Size(241, 46);
            this.btn_confirm_card_pin.TabIndex = 40;
            this.btn_confirm_card_pin.Text = "Подтвердить";
            this.btn_confirm_card_pin.UseVisualStyleBackColor = false;
            this.btn_confirm_card_pin.Click += new System.EventHandler(this.Btn_confirm_card_pin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 39;
            this.label7.Text = "PIN-код";
            // 
            // Validations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(270, 170);
            this.Controls.Add(this.txB_cardPin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_confirm_card_pin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Validations";
            this.Text = "Validations";
            this.Load += new System.EventHandler(this.Validations_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Validations_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Validations_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Validations_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txB_cardPin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_confirm_card_pin;
        private System.Windows.Forms.Label label7;
    }
}