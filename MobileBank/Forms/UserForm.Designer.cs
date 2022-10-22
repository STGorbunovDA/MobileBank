namespace MobileBank.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.picB_user = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbL_email_user = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbL_Phone_user = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbL_FIO_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ChangePasswordAccount = new System.Windows.Forms.Button();
            this.btn_ChangeEmail = new System.Windows.Forms.Button();
            this.btn_ChangeNumberPhone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_user)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(548, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.picB_user);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 44);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(462, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 23);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "обновить";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // picB_user
            // 
            this.picB_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_user.BackgroundImage")));
            this.picB_user.Location = new System.Drawing.Point(6, 6);
            this.picB_user.Name = "picB_user";
            this.picB_user.Size = new System.Drawing.Size(32, 35);
            this.picB_user.TabIndex = 34;
            this.picB_user.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lbL_email_user);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbL_Phone_user);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbL_FIO_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 263);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp);
            // 
            // lbL_email_user
            // 
            this.lbL_email_user.AutoSize = true;
            this.lbL_email_user.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_email_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_email_user.Location = new System.Drawing.Point(60, 207);
            this.lbL_email_user.Name = "lbL_email_user";
            this.lbL_email_user.Size = new System.Drawing.Size(38, 16);
            this.lbL_email_user.TabIndex = 40;
            this.lbL_email_user.Text = "email";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // lbL_Phone_user
            // 
            this.lbL_Phone_user.AutoSize = true;
            this.lbL_Phone_user.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_Phone_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_Phone_user.Location = new System.Drawing.Point(60, 155);
            this.lbL_Phone_user.Name = "lbL_Phone_user";
            this.lbL_Phone_user.Size = new System.Drawing.Size(60, 16);
            this.lbL_Phone_user.TabIndex = 38;
            this.lbL_Phone_user.Text = "Телефон";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // lbL_FIO_user
            // 
            this.lbL_FIO_user.AutoSize = true;
            this.lbL_FIO_user.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbL_FIO_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbL_FIO_user.Location = new System.Drawing.Point(60, 102);
            this.lbL_FIO_user.Name = "lbL_FIO_user";
            this.lbL_FIO_user.Size = new System.Drawing.Size(34, 16);
            this.lbL_FIO_user.TabIndex = 36;
            this.lbL_FIO_user.Text = "ФИО";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(92, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Личные данные";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btn_ChangePasswordAccount);
            this.panel3.Controls.Add(this.btn_ChangeEmail);
            this.panel3.Controls.Add(this.btn_ChangeNumberPhone);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(341, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 263);
            this.panel3.TabIndex = 5;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseUp);
            // 
            // btn_ChangePasswordAccount
            // 
            this.btn_ChangePasswordAccount.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ChangePasswordAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangePasswordAccount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangePasswordAccount.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangePasswordAccount.Location = new System.Drawing.Point(12, 83);
            this.btn_ChangePasswordAccount.Name = "btn_ChangePasswordAccount";
            this.btn_ChangePasswordAccount.Size = new System.Drawing.Size(225, 48);
            this.btn_ChangePasswordAccount.TabIndex = 43;
            this.btn_ChangePasswordAccount.Text = "Изменить пароль для аккаунта";
            this.btn_ChangePasswordAccount.UseVisualStyleBackColor = false;
            this.btn_ChangePasswordAccount.Click += new System.EventHandler(this.Btn_ChangePasswordAccount_Click);
            // 
            // btn_ChangeEmail
            // 
            this.btn_ChangeEmail.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangeEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeEmail.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeEmail.Location = new System.Drawing.Point(12, 191);
            this.btn_ChangeEmail.Name = "btn_ChangeEmail";
            this.btn_ChangeEmail.Size = new System.Drawing.Size(225, 48);
            this.btn_ChangeEmail.TabIndex = 42;
            this.btn_ChangeEmail.Text = "Сменить эл. почту";
            this.btn_ChangeEmail.UseVisualStyleBackColor = false;
            this.btn_ChangeEmail.Click += new System.EventHandler(this.Btn_ChangeEmail_Click);
            // 
            // btn_ChangeNumberPhone
            // 
            this.btn_ChangeNumberPhone.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ChangeNumberPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ChangeNumberPhone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeNumberPhone.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeNumberPhone.Location = new System.Drawing.Point(12, 137);
            this.btn_ChangeNumberPhone.Name = "btn_ChangeNumberPhone";
            this.btn_ChangeNumberPhone.Size = new System.Drawing.Size(225, 48);
            this.btn_ChangeNumberPhone.TabIndex = 35;
            this.btn_ChangeNumberPhone.Text = "Изменить номер телефона";
            this.btn_ChangeNumberPhone.UseVisualStyleBackColor = false;
            this.btn_ChangeNumberPhone.Click += new System.EventHandler(this.Btn_ChangeNumberPhone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(90, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Настройка";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(590, 320);
            this.panel4.TabIndex = 41;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseUp);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(590, 320);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_user)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picB_user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbL_email_user;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbL_Phone_user;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbL_FIO_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ChangePasswordAccount;
        private System.Windows.Forms.Button btn_ChangeEmail;
        private System.Windows.Forms.Button btn_ChangeNumberPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
    }
}