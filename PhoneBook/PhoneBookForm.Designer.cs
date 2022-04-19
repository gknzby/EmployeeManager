namespace NesneProje.PhoneBook
{
    partial class PhoneBookForm
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
            this.dataGridPBook = new System.Windows.Forms.DataGridView();
            this.btnRecAdd = new System.Windows.Forms.Button();
            this.btnRecChange = new System.Windows.Forms.Button();
            this.btnRecShow = new System.Windows.Forms.Button();
            this.btnRecRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPBook
            // 
            this.dataGridPBook.AllowUserToAddRows = false;
            this.dataGridPBook.AllowUserToDeleteRows = false;
            this.dataGridPBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnSurname,
            this.columnPhone,
            this.columnAddress,
            this.columnDesc,
            this.columnMail});
            this.dataGridPBook.Location = new System.Drawing.Point(12, 74);
            this.dataGridPBook.Name = "dataGridPBook";
            this.dataGridPBook.ReadOnly = true;
            this.dataGridPBook.RowHeadersWidth = 5;
            this.dataGridPBook.RowTemplate.Height = 24;
            this.dataGridPBook.Size = new System.Drawing.Size(1062, 441);
            this.dataGridPBook.TabIndex = 0;
            this.dataGridPBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPBook_CellClick);
            // 
            // btnRecAdd
            // 
            this.btnRecAdd.Location = new System.Drawing.Point(962, 12);
            this.btnRecAdd.Name = "btnRecAdd";
            this.btnRecAdd.Size = new System.Drawing.Size(112, 38);
            this.btnRecAdd.TabIndex = 1;
            this.btnRecAdd.Text = "Add";
            this.btnRecAdd.UseVisualStyleBackColor = true;
            this.btnRecAdd.Click += new System.EventHandler(this.AddRecord);
            // 
            // btnRecChange
            // 
            this.btnRecChange.Location = new System.Drawing.Point(817, 12);
            this.btnRecChange.Name = "btnRecChange";
            this.btnRecChange.Size = new System.Drawing.Size(112, 38);
            this.btnRecChange.TabIndex = 2;
            this.btnRecChange.Text = "Update";
            this.btnRecChange.UseVisualStyleBackColor = true;
            this.btnRecChange.Click += new System.EventHandler(this.ChangeRecord);
            // 
            // btnRecShow
            // 
            this.btnRecShow.Location = new System.Drawing.Point(674, 12);
            this.btnRecShow.Name = "btnRecShow";
            this.btnRecShow.Size = new System.Drawing.Size(112, 38);
            this.btnRecShow.TabIndex = 3;
            this.btnRecShow.Text = "Show";
            this.btnRecShow.UseVisualStyleBackColor = true;
            this.btnRecShow.Click += new System.EventHandler(this.ShowRecord);
            // 
            // btnRecRemove
            // 
            this.btnRecRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRecRemove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecRemove.Location = new System.Drawing.Point(527, 12);
            this.btnRecRemove.Name = "btnRecRemove";
            this.btnRecRemove.Size = new System.Drawing.Size(112, 38);
            this.btnRecRemove.TabIndex = 4;
            this.btnRecRemove.Text = "Delete";
            this.btnRecRemove.UseVisualStyleBackColor = false;
            this.btnRecRemove.Click += new System.EventHandler(this.RemoveRecord);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveRecords);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(12, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 38);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelChanges);
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnName.Width = 125;
            // 
            // columnSurname
            // 
            this.columnSurname.HeaderText = "Surname";
            this.columnSurname.MinimumWidth = 6;
            this.columnSurname.Name = "columnSurname";
            this.columnSurname.ReadOnly = true;
            this.columnSurname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnSurname.Width = 125;
            // 
            // columnPhone
            // 
            this.columnPhone.HeaderText = "Phone";
            this.columnPhone.MinimumWidth = 6;
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.ReadOnly = true;
            this.columnPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnPhone.Width = 125;
            // 
            // columnAddress
            // 
            this.columnAddress.HeaderText = "Adress";
            this.columnAddress.MinimumWidth = 6;
            this.columnAddress.Name = "columnAddress";
            this.columnAddress.ReadOnly = true;
            this.columnAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnAddress.Width = 125;
            // 
            // columnDesc
            // 
            this.columnDesc.HeaderText = "Notes";
            this.columnDesc.MinimumWidth = 6;
            this.columnDesc.Name = "columnDesc";
            this.columnDesc.ReadOnly = true;
            this.columnDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnDesc.Width = 125;
            // 
            // columnMail
            // 
            this.columnMail.HeaderText = "Mail";
            this.columnMail.MinimumWidth = 6;
            this.columnMail.Name = "columnMail";
            this.columnMail.ReadOnly = true;
            this.columnMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnMail.Width = 125;
            // 
            // PhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 527);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRecRemove);
            this.Controls.Add(this.btnRecShow);
            this.Controls.Add(this.btnRecChange);
            this.Controls.Add(this.btnRecAdd);
            this.Controls.Add(this.dataGridPBook);
            this.Name = "PhoneBookForm";
            this.Text = "Employee Manager - Phonebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhoneBookForm_FormClosing);
            this.MouseEnter += new System.EventHandler(this.PhoneBookForm_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPBook;
        private System.Windows.Forms.Button btnRecAdd;
        private System.Windows.Forms.Button btnRecChange;
        private System.Windows.Forms.Button btnRecShow;
        private System.Windows.Forms.Button btnRecRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMail;
    }
}