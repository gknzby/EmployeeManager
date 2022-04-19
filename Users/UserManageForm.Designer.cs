namespace NesneProje.Users
{
    partial class UserManageForm
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
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserList = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.cmbBxType = new System.Windows.Forms.ComboBox();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(895, 339);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(81, 16);
            this.lblDateFormat.TabIndex = 33;
            this.lblDateFormat.Text = "dd/mm/yyyy";
            // 
            // txtBYear
            // 
            this.txtBYear.Location = new System.Drawing.Point(811, 336);
            this.txtBYear.Name = "txtBYear";
            this.txtBYear.Size = new System.Drawing.Size(74, 22);
            this.txtBYear.TabIndex = 32;
            // 
            // txtBMonth
            // 
            this.txtBMonth.Location = new System.Drawing.Point(777, 336);
            this.txtBMonth.Name = "txtBMonth";
            this.txtBMonth.Size = new System.Drawing.Size(28, 22);
            this.txtBMonth.TabIndex = 31;
            // 
            // txtBDay
            // 
            this.txtBDay.Location = new System.Drawing.Point(743, 336);
            this.txtBDay.Name = "txtBDay";
            this.txtBDay.Size = new System.Drawing.Size(28, 22);
            this.txtBDay.TabIndex = 30;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(741, 299);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 22);
            this.txtPhone.TabIndex = 29;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(743, 188);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(222, 22);
            this.txtPsw.TabIndex = 28;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(743, 155);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 22);
            this.txtMail.TabIndex = 27;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(743, 262);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(222, 22);
            this.txtSurname.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(743, 225);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 22);
            this.txtName.TabIndex = 25;
            // 
            // lblBDay
            // 
            this.lblBDay.AutoSize = true;
            this.lblBDay.Location = new System.Drawing.Point(621, 339);
            this.lblBDay.Name = "lblBDay";
            this.lblBDay.Size = new System.Drawing.Size(61, 16);
            this.lblBDay.TabIndex = 23;
            this.lblBDay.Text = "Birth Day";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(620, 302);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Phone";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(619, 155);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 16);
            this.lblMail.TabIndex = 21;
            this.lblMail.Text = "Mail";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(619, 193);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(67, 16);
            this.lblPsw.TabIndex = 20;
            this.lblPsw.Text = "Password";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(622, 265);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(622, 228);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(621, 122);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(96, 16);
            this.lblUserType.TabIndex = 35;
            this.lblUserType.Text = "Personal Type";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(743, 87);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(222, 22);
            this.txtUserID.TabIndex = 38;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(621, 87);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(20, 16);
            this.lblUserID.TabIndex = 37;
            this.lblUserID.Text = "ID";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(27, 374);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(516, 22);
            this.txtFind.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(27, 402);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(425, 22);
            this.textBox4.TabIndex = 40;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(458, 401);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(85, 23);
            this.btnFind.TabIndex = 41;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(797, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 33);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ChangeUserInfo);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(622, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelChanges);
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Location = new System.Drawing.Point(108, 47);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(84, 16);
            this.lblUserList.TabIndex = 44;
            this.lblUserList.Text = "Personal List";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(794, 47);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(95, 16);
            this.lblUserInfo.TabIndex = 45;
            this.lblUserInfo.Text = "Kullanıcı Bilgisi";
            // 
            // cmbBxType
            // 
            this.cmbBxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxType.FormattingEnabled = true;
            this.cmbBxType.Items.AddRange(new object[] {
            "Admin",
            "Full-Time",
            "Part-Time"});
            this.cmbBxType.Location = new System.Drawing.Point(743, 122);
            this.cmbBxType.Name = "cmbBxType";
            this.cmbBxType.Size = new System.Drawing.Size(220, 24);
            this.cmbBxType.TabIndex = 47;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnName,
            this.clmnSurname,
            this.clmnMail});
            this.dataGridUsers.Location = new System.Drawing.Point(27, 87);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.RowHeadersWidth = 15;
            this.dataGridUsers.RowTemplate.Height = 24;
            this.dataGridUsers.Size = new System.Drawing.Size(516, 281);
            this.dataGridUsers.TabIndex = 49;
            this.dataGridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedUserInfo);
            // 
            // clmnName
            // 
            this.clmnName.HeaderText = "Name";
            this.clmnName.MinimumWidth = 6;
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            this.clmnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnName.Width = 80;
            // 
            // clmnSurname
            // 
            this.clmnSurname.HeaderText = "Surname";
            this.clmnSurname.MinimumWidth = 6;
            this.clmnSurname.Name = "clmnSurname";
            this.clmnSurname.ReadOnly = true;
            this.clmnSurname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnSurname.Width = 80;
            // 
            // clmnMail
            // 
            this.clmnMail.HeaderText = "Mail";
            this.clmnMail.MinimumWidth = 6;
            this.clmnMail.Name = "clmnMail";
            this.clmnMail.ReadOnly = true;
            this.clmnMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnMail.Width = 160;
            // 
            // UserManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 453);
            this.Controls.Add(this.dataGridUsers);
            this.Controls.Add(this.cmbBxType);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblUserList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblUserType);
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
            this.Name = "UserManageForm";
            this.Text = "Employee Manager - Admin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserManageForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserList;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.ComboBox cmbBxType;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMail;
    }
}