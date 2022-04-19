namespace NesneProje.Reminder
{
    partial class ReminderForm
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
            this.dataGridRems = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRems
            // 
            this.dataGridRems.AllowUserToAddRows = false;
            this.dataGridRems.AllowUserToDeleteRows = false;
            this.dataGridRems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDone,
            this.colTitle,
            this.colTime});
            this.dataGridRems.Location = new System.Drawing.Point(12, 12);
            this.dataGridRems.Name = "dataGridRems";
            this.dataGridRems.ReadOnly = true;
            this.dataGridRems.RowHeadersWidth = 5;
            this.dataGridRems.RowTemplate.Height = 24;
            this.dataGridRems.Size = new System.Drawing.Size(380, 340);
            this.dataGridRems.TabIndex = 0;
            this.dataGridRems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRems_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(424, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(288, 22);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Text = "Title";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(424, 51);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(288, 228);
            this.txtDesc.TabIndex = 6;
            this.txtDesc.Text = "Notes";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(562, 298);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(33, 22);
            this.txtYear.TabIndex = 7;
            this.txtYear.Text = "2021";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(515, 298);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(23, 22);
            this.txtMonth.TabIndex = 8;
            this.txtMonth.Text = "01";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(468, 298);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(23, 22);
            this.txtDay.TabIndex = 9;
            this.txtDay.Text = "01";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(689, 298);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(23, 22);
            this.txtMin.TabIndex = 10;
            this.txtMin.Text = "00";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(642, 298);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(23, 22);
            this.txtHour.TabIndex = 11;
            this.txtHour.Text = "00";
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Location = new System.Drawing.Point(605, 331);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(95, 20);
            this.chkDone.TabIndex = 13;
            this.chkDone.Text = "Completed";
            this.chkDone.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(605, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddRem);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(496, 370);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(107, 37);
            this.btnChange.TabIndex = 15;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.ChangeReminder);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkRed;
            this.btnDel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDel.Location = new System.Drawing.Point(424, 370);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(67, 37);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.RemoveReminder);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 37);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveReminders);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(12, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 37);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.CancelChanges);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = ":";
            // 
            // colDone
            // 
            this.colDone.HeaderText = "O";
            this.colDone.MinimumWidth = 6;
            this.colDone.Name = "colDone";
            this.colDone.ReadOnly = true;
            this.colDone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDone.Width = 24;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTitle.Width = 125;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Date";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTime.Width = 125;
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 424);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkDone);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridRems);
            this.Name = "ReminderForm";
            this.Text = "Employee Manager - Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReminderForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.CheckBox chkDone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
    }
}