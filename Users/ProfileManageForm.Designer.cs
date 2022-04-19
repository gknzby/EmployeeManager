namespace NesneProje.Users
{
    partial class ProfileManageForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.txtBYear = new System.Windows.Forms.TextBox();
            this.txtBMonth = new System.Windows.Forms.TextBox();
            this.txtBDay = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBDay = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(263, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelChanges);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(387, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 33);
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveChanges);
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(479, 246);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(81, 16);
            this.lblDateFormat.TabIndex = 62;
            this.lblDateFormat.Text = "dd/mm/yyyy";
            // 
            // txtBYear
            // 
            this.txtBYear.Location = new System.Drawing.Point(395, 243);
            this.txtBYear.Name = "txtBYear";
            this.txtBYear.Size = new System.Drawing.Size(74, 22);
            this.txtBYear.TabIndex = 61;
            this.txtBYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtBYear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // txtBMonth
            // 
            this.txtBMonth.Location = new System.Drawing.Point(361, 243);
            this.txtBMonth.Name = "txtBMonth";
            this.txtBMonth.Size = new System.Drawing.Size(28, 22);
            this.txtBMonth.TabIndex = 60;
            this.txtBMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtBMonth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // txtBDay
            // 
            this.txtBDay.Location = new System.Drawing.Point(327, 243);
            this.txtBDay.Name = "txtBDay";
            this.txtBDay.Size = new System.Drawing.Size(28, 22);
            this.txtBDay.TabIndex = 59;
            this.txtBDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtBDay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(325, 206);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 22);
            this.txtPhone.TabIndex = 58;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(327, 95);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(222, 22);
            this.txtPsw.TabIndex = 57;
            this.txtPsw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtPsw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(327, 62);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 22);
            this.txtMail.TabIndex = 56;
            this.txtMail.Enter += new System.EventHandler(this.AddStack);
            this.txtMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtMail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(327, 169);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(222, 22);
            this.txtSurname.TabIndex = 55;
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtSurname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(327, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 22);
            this.txtName.TabIndex = 54;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            // 
            // lblBDay
            // 
            this.lblBDay.AutoSize = true;
            this.lblBDay.Location = new System.Drawing.Point(205, 246);
            this.lblBDay.Name = "lblBDay";
            this.lblBDay.Size = new System.Drawing.Size(65, 16);
            this.lblBDay.TabIndex = 53;
            this.lblBDay.Text = "Birth Date";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(204, 209);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 52;
            this.lblPhone.Text = "Phone";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(203, 62);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 16);
            this.lblMail.TabIndex = 51;
            this.lblMail.Text = "Mail";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(203, 100);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(67, 16);
            this.lblPsw.TabIndex = 50;
            this.lblPsw.Text = "Password";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(206, 172);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 49;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(206, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 48;
            this.lblName.Text = "Name";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(65, 24);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(66, 16);
            this.lblUserInfo.TabIndex = 68;
            this.lblUserInfo.Text = "My Profile";
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(27, 62);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(128, 128);
            this.picUser.TabIndex = 69;
            this.picUser.TabStop = false;
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(27, 209);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(128, 33);
            this.btnPhoto.TabIndex = 70;
            this.btnPhoto.Text = "Change Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.LoadPhoto);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(24, 263);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 16);
            this.lblSalary.TabIndex = 72;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(68, 260);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(87, 22);
            this.txtSalary.TabIndex = 71;
            // 
            // ProfileManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 345);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.txtBYear);
            this.Controls.Add(this.txtBMonth);
            this.Controls.Add(this.txtBDay);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBDay);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "ProfileManageForm";
            this.Text = "Employee Manager - Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileManageForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyMng);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProfileManageForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.TextBox txtBYear;
        private System.Windows.Forms.TextBox txtBMonth;
        private System.Windows.Forms.TextBox txtBDay;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBDay;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
    }
}