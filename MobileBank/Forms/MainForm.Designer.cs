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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbL_сourse_dollar = new System.Windows.Forms.Label();
            this.lbL_сourse_euro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_closeLoginForm = new System.Windows.Forms.Button();
            this.btn_adding_card = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_card_number = new System.Windows.Forms.ComboBox();
            this.picB_update = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_update)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lbL_сourse_dollar);
            this.panel1.Controls.Add(this.lbL_сourse_euro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_closeLoginForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            // btn_closeLoginForm
            // 
            this.btn_closeLoginForm.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_closeLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeLoginForm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_closeLoginForm.ForeColor = System.Drawing.Color.Gray;
            this.btn_closeLoginForm.Location = new System.Drawing.Point(686, 12);
            this.btn_closeLoginForm.Name = "btn_closeLoginForm";
            this.btn_closeLoginForm.Size = new System.Drawing.Size(24, 23);
            this.btn_closeLoginForm.TabIndex = 1;
            this.btn_closeLoginForm.Text = "X";
            this.btn_closeLoginForm.UseVisualStyleBackColor = false;
            this.btn_closeLoginForm.Click += new System.EventHandler(this.Btn_closeLoginForm_Click);
            // 
            // btn_adding_card
            // 
            this.btn_adding_card.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_adding_card.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adding_card.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_adding_card.ForeColor = System.Drawing.Color.Gray;
            this.btn_adding_card.Location = new System.Drawing.Point(453, 69);
            this.btn_adding_card.Name = "btn_adding_card";
            this.btn_adding_card.Size = new System.Drawing.Size(103, 27);
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
            this.label4.Location = new System.Drawing.Point(155, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Карты:";
            // 
            // cmb_card_number
            // 
            this.cmb_card_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_card_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_card_number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_card_number.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_card_number.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_card_number.FormattingEnabled = true;
            this.cmb_card_number.Items.AddRange(new object[] {
            "МУЖ",
            "ЖЕН"});
            this.cmb_card_number.Location = new System.Drawing.Point(225, 68);
            this.cmb_card_number.Name = "cmb_card_number";
            this.cmb_card_number.Size = new System.Drawing.Size(222, 27);
            this.cmb_card_number.TabIndex = 19;
            // 
            // picB_update
            // 
            this.picB_update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picB_update.BackColor = System.Drawing.Color.Transparent;
            this.picB_update.Location = new System.Drawing.Point(198, 112);
            this.picB_update.Name = "picB_update";
            this.picB_update.Size = new System.Drawing.Size(319, 190);
            this.picB_update.TabIndex = 20;
            this.picB_update.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(722, 498);
            this.Controls.Add(this.picB_update);
            this.Controls.Add(this.cmb_card_number);
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
            ((System.ComponentModel.ISupportInitialize)(this.picB_update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_closeLoginForm;
        private System.Windows.Forms.Label lbL_сourse_euro;
        private System.Windows.Forms.Label lbL_сourse_dollar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_adding_card;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_card_number;
        private System.Windows.Forms.PictureBox picB_update;
    }
}