namespace NesneProje.SignInUp
{
    partial class RegisterForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBDay = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtBDay = new System.Windows.Forms.TextBox();
            this.txtBMonth = new System.Windows.Forms.TextBox();
            this.txtBYear = new System.Windows.Forms.TextBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.lblPhoneFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(37, 119);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(36, 239);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(67, 16);
            this.lblPsw.TabIndex = 2;
            this.lblPsw.Text = "Password";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(36, 201);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 16);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(37, 314);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblBDay
            // 
            this.lblBDay.AutoSize = true;
            this.lblBDay.Location = new System.Drawing.Point(36, 355);
            this.lblBDay.Name = "lblBDay";
            this.lblBDay.Size = new System.Drawing.Size(65, 16);
            this.lblBDay.TabIndex = 5;
            this.lblBDay.Text = "Birth Date";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(173, 31);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(53, 16);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "Sign-up";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(261, 422);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(119, 46);
            this.btnKayıt.TabIndex = 7;
            this.btnKayıt.Text = "Sign up";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnRegister);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 422);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackToLogin);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 22);
            this.txtName.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(156, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(222, 22);
            this.txtSurname.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(158, 198);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 22);
            this.txtMail.TabIndex = 11;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(158, 234);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(222, 22);
            this.txtPsw.TabIndex = 12;
            this.txtPsw.UseSystemPasswordChar = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(158, 311);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 22);
            this.txtPhone.TabIndex = 13;
            // 
            // txtBDay
            // 
            this.txtBDay.Location = new System.Drawing.Point(158, 352);
            this.txtBDay.Name = "txtBDay";
            this.txtBDay.Size = new System.Drawing.Size(28, 22);
            this.txtBDay.TabIndex = 14;
            // 
            // txtBMonth
            // 
            this.txtBMonth.Location = new System.Drawing.Point(192, 352);
            this.txtBMonth.Name = "txtBMonth";
            this.txtBMonth.Size = new System.Drawing.Size(28, 22);
            this.txtBMonth.TabIndex = 15;
            // 
            // txtBYear
            // 
            this.txtBYear.Location = new System.Drawing.Point(226, 352);
            this.txtBYear.Name = "txtBYear";
            this.txtBYear.Size = new System.Drawing.Size(74, 22);
            this.txtBYear.TabIndex = 16;
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(310, 355);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(81, 16);
            this.lblDateFormat.TabIndex = 17;
            this.lblDateFormat.Text = "dd/mm/yyyy";
            // 
            // lblPhoneFormat
            // 
            this.lblPhoneFormat.AutoSize = true;
            this.lblPhoneFormat.Location = new System.Drawing.Point(160, 291);
            this.lblPhoneFormat.Name = "lblPhoneFormat";
            this.lblPhoneFormat.Size = new System.Drawing.Size(85, 16);
            this.lblPhoneFormat.TabIndex = 18;
            this.lblPhoneFormat.Text = "(5551234567)";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 504);
            this.Controls.Add(this.lblPhoneFormat);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.txtBYear);
            this.Controls.Add(this.txtBMonth);
            this.Controls.Add(this.txtBDay);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblBDay);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "RegisterForm";
            this.Text = "Employee Manager - Sign-up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfterClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBDay;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtBDay;
        private System.Windows.Forms.TextBox txtBMonth;
        private System.Windows.Forms.TextBox txtBYear;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.Label lblPhoneFormat;
    }
}