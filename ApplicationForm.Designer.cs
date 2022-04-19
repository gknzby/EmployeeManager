namespace NesneProje
{
    partial class ApplicationForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnManageForm = new System.Windows.Forms.Button();
            this.btnPhoneBook = new System.Windows.Forms.Button();
            this.btnNoteBook = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBMO = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.remTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnManageForm
            // 
            this.btnManageForm.Location = new System.Drawing.Point(12, 341);
            this.btnManageForm.Name = "btnManageForm";
            this.btnManageForm.Size = new System.Drawing.Size(324, 38);
            this.btnManageForm.TabIndex = 0;
            this.btnManageForm.Text = "User Management";
            this.btnManageForm.UseVisualStyleBackColor = true;
            this.btnManageForm.Click += new System.EventHandler(this.OpenUserMng);
            // 
            // btnPhoneBook
            // 
            this.btnPhoneBook.Location = new System.Drawing.Point(12, 12);
            this.btnPhoneBook.Name = "btnPhoneBook";
            this.btnPhoneBook.Size = new System.Drawing.Size(324, 38);
            this.btnPhoneBook.TabIndex = 1;
            this.btnPhoneBook.Text = "Phonebook";
            this.btnPhoneBook.UseVisualStyleBackColor = true;
            this.btnPhoneBook.Click += new System.EventHandler(this.OpenPhoneBook);
            // 
            // btnNoteBook
            // 
            this.btnNoteBook.Location = new System.Drawing.Point(12, 70);
            this.btnNoteBook.Name = "btnNoteBook";
            this.btnNoteBook.Size = new System.Drawing.Size(324, 38);
            this.btnNoteBook.TabIndex = 2;
            this.btnNoteBook.Text = "Notebook";
            this.btnNoteBook.UseVisualStyleBackColor = true;
            this.btnNoteBook.Click += new System.EventHandler(this.OpenNoteBook);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 400);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(324, 38);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Account";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.OpenProfile);
            // 
            // btnBMO
            // 
            this.btnBMO.Location = new System.Drawing.Point(12, 132);
            this.btnBMO.Name = "btnBMO";
            this.btnBMO.Size = new System.Drawing.Size(324, 38);
            this.btnBMO.TabIndex = 4;
            this.btnBMO.Text = "Minimum Wage Calculator";
            this.btnBMO.UseVisualStyleBackColor = true;
            this.btnBMO.Click += new System.EventHandler(this.OpenBMOCalculator);
            // 
            // btnReminder
            // 
            this.btnReminder.Location = new System.Drawing.Point(12, 197);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(324, 38);
            this.btnReminder.TabIndex = 5;
            this.btnReminder.Text = "Reminder";
            this.btnReminder.UseVisualStyleBackColor = true;
            this.btnReminder.Click += new System.EventHandler(this.OpenReminder);
            // 
            // remTimer
            // 
            this.remTimer.Enabled = true;
            this.remTimer.Interval = 1000;
            this.remTimer.Tick += new System.EventHandler(this.remTimer_Tick);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.btnBMO);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnNoteBook);
            this.Controls.Add(this.btnPhoneBook);
            this.Controls.Add(this.btnManageForm);
            this.Name = "ApplicationForm";
            this.Text = "Employee Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfterClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageForm;
        private System.Windows.Forms.Button btnPhoneBook;
        private System.Windows.Forms.Button btnNoteBook;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBMO;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Timer remTimer;
    }
}

