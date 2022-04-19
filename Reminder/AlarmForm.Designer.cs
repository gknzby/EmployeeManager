namespace NesneProje.Reminder
{
    partial class AlarmForm
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
            this.components = new System.ComponentModel.Container();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSilence = new System.Windows.Forms.Button();
            this.lblRemind = new System.Windows.Forms.Label();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(81, 92);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(393, 29);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "named reminder\'s time has passed!";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(380, 150);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(115, 40);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Completed";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.DoneReminder);
            // 
            // btnSilence
            // 
            this.btnSilence.Location = new System.Drawing.Point(31, 150);
            this.btnSilence.Name = "btnSilence";
            this.btnSilence.Size = new System.Drawing.Size(112, 40);
            this.btnSilence.TabIndex = 2;
            this.btnSilence.Text = "Silence";
            this.btnSilence.UseVisualStyleBackColor = true;
            this.btnSilence.Click += new System.EventHandler(this.SilienceReminder);
            // 
            // lblRemind
            // 
            this.lblRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemind.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRemind.Location = new System.Drawing.Point(81, 63);
            this.lblRemind.Name = "lblRemind";
            this.lblRemind.Size = new System.Drawing.Size(363, 29);
            this.lblRemind.TabIndex = 3;
            this.lblRemind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerAlarm
            // 
            this.timerAlarm.Enabled = true;
            this.timerAlarm.Interval = 200;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 219);
            this.Controls.Add(this.lblRemind);
            this.Controls.Add(this.btnSilence);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmForm";
            this.Text = "AlarmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSilence;
        private System.Windows.Forms.Label lblRemind;
        private System.Windows.Forms.Timer timerAlarm;
    }
}