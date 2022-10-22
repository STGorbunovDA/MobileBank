namespace MobileBank.Forms
{
    partial class ChangePasswordUserAccount
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
            this.btn_ChangePasswordAccount = new System.Windows.Forms.Button();
            this.txB_client_password = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chB_visibilityPassword = new System.Windows.Forms.CheckBox();
            this.txB_client_password_old = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_ChangePasswordAccount
            // 
            this.btn_ChangePasswordAccount.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ChangePasswordAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangePasswordAccount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangePasswordAccount.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangePasswordAccount.Location = new System.Drawing.Point(12, 240);
            this.btn_ChangePasswordAccount.Name = "btn_ChangePasswordAccount";
            this.btn_ChangePasswordAccount.Size = new System.Drawing.Size(288, 48);
            this.btn_ChangePasswordAccount.TabIndex = 44;
            this.btn_ChangePasswordAccount.Text = "Изменить пароль";
            this.btn_ChangePasswordAccount.UseVisualStyleBackColor = false;
            this.btn_ChangePasswordAccount.Click += new System.EventHandler(this.Btn_ChangePasswordAccount_Click);
            // 
            // txB_client_password
            // 
            this.txB_client_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txB_client_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_client_password.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_client_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_client_password.Location = new System.Drawing.Point(12, 151);
            this.txB_client_password.MaxLength = 50;
            this.txB_client_password.Name = "txB_client_password";
            this.txB_client_password.Size = new System.Drawing.Size(288, 26);
            this.txB_client_password.TabIndex = 42;
            this.txB_client_password.UseSystemPasswordChar = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(51, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(202, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "Введите новый пароль";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.GreenYellow;
            this.label15.Location = new System.Drawing.Point(11, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(291, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = ".......................................................................";
            // 
            // chB_visibilityPassword
            // 
            this.chB_visibilityPassword.AutoSize = true;
            this.chB_visibilityPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chB_visibilityPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chB_visibilityPassword.Location = new System.Drawing.Point(188, 191);
            this.chB_visibilityPassword.Name = "chB_visibilityPassword";
            this.chB_visibilityPassword.Size = new System.Drawing.Size(112, 17);
            this.chB_visibilityPassword.TabIndex = 45;
            this.chB_visibilityPassword.Text = "показать пароли";
            this.chB_visibilityPassword.UseVisualStyleBackColor = true;
            this.chB_visibilityPassword.Click += new System.EventHandler(this.ChB_visibilityPassword_Click);
            // 
            // txB_client_password_old
            // 
            this.txB_client_password_old.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txB_client_password_old.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txB_client_password_old.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txB_client_password_old.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txB_client_password_old.Location = new System.Drawing.Point(12, 78);
            this.txB_client_password_old.MaxLength = 50;
            this.txB_client_password_old.Name = "txB_client_password_old";
            this.txB_client_password_old.Size = new System.Drawing.Size(288, 26);
            this.txB_client_password_old.TabIndex = 47;
            this.txB_client_password_old.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Введите старый пароль";
            // 
            // ChangePasswordUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(320, 317);
            this.Controls.Add(this.txB_client_password_old);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chB_visibilityPassword);
            this.Controls.Add(this.btn_ChangePasswordAccount);
            this.Controls.Add(this.txB_client_password);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordUserAccount";
            this.Text = "ChangePasswordUserAccount";
            this.Load += new System.EventHandler(this.ChangePasswordUserAccount_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePasswordUserAccount_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePasswordUserAccount_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangePasswordUserAccount_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_ChangePasswordAccount;
        private System.Windows.Forms.TextBox txB_client_password;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chB_visibilityPassword;
        private System.Windows.Forms.TextBox txB_client_password_old;
        private System.Windows.Forms.Label label1;
    }
}