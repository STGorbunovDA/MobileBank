namespace MobileBank.Forms
{
    partial class ChangeEmail
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
            this.txb_client_email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_ChangeEmail = new System.Windows.Forms.Button();
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
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // txb_client_email
            // 
            this.txb_client_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txb_client_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_client_email.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_client_email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txb_client_email.Location = new System.Drawing.Point(18, 71);
            this.txb_client_email.MaxLength = 50;
            this.txb_client_email.Name = "txb_client_email";
            this.txb_client_email.Size = new System.Drawing.Size(288, 26);
            this.txb_client_email.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(57, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "Введите новую почту";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.GreenYellow;
            this.label15.Location = new System.Drawing.Point(15, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(291, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = ".......................................................................";
            // 
            // btn_ChangeEmail
            // 
            this.btn_ChangeEmail.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangeEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeEmail.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeEmail.Location = new System.Drawing.Point(18, 133);
            this.btn_ChangeEmail.Name = "btn_ChangeEmail";
            this.btn_ChangeEmail.Size = new System.Drawing.Size(288, 48);
            this.btn_ChangeEmail.TabIndex = 40;
            this.btn_ChangeEmail.Text = "Сменить эл. почту";
            this.btn_ChangeEmail.UseVisualStyleBackColor = false;
            this.btn_ChangeEmail.Click += new System.EventHandler(this.Btn_ChangeEmail_Click);
            // 
            // ChangeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(320, 221);
            this.Controls.Add(this.btn_ChangeEmail);
            this.Controls.Add(this.txb_client_email);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeEmail";
            this.Text = "ChangeEmail";
            this.Load += new System.EventHandler(this.ChangeEmail_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeEmail_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeEmail_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeEmail_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txb_client_email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_ChangeEmail;
    }
}