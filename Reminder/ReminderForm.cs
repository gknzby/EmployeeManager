using NesneProje.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.Reminder
{
    public partial class ReminderForm : Form
    {
        int dtgIndex = -1;
        int changeStat = 0;
        Form appForm;
        Users.User currentUser;
        ReminderManager remMng;

        public ReminderForm(Form _appForm, Users.User _currentUser, ReminderManager _remMng)
        {
            InitializeComponent();

            appForm = _appForm;
            currentUser = _currentUser;
            remMng = _remMng;

            ListReminders();
        }

        private void ReminderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changeStat == 1)
            {
                var closeMsg = MessageBox.Show("Değişiklilerinizi kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (closeMsg == DialogResult.Yes)
                {
                    remMng.SaveReminders();
                    appForm.Show();
                }
                else if (closeMsg == DialogResult.No)
                {
                    appForm.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                appForm.Show();
            }
        }

        private void ListReminders()
        {
            dataGridRems.Rows.Clear();
            string[] rem;
            for(int i = 0; i < remMng.RemList.Count; i++)
            {
                rem = remMng.RemList[i].GetInfo();
                string done = rem[0] == "1" ? "+" : "-";
                string rDate = rem[3] + "/" + rem[2] + "/" + rem[1] + " " + rem[4] + ":" + rem[5];

                dataGridRems.Rows.Add(done, rem[6], rDate);
            }
        }

        private void AddRem(object sender, EventArgs e)
        {
            string[] rem = new string[9];
            rem[0] = chkDone.Checked ? "1" : "0";
            rem[1] = txtYear.Text;
            rem[2] = txtMonth.Text;
            rem[3] = txtDay.Text;
            rem[4] = txtHour.Text;
            rem[5] = txtMin.Text;
            rem[6] = txtTitle.Text;
            rem[7] = txtDesc.Text;

            List<string> result;
            result = remMng.FormControl(rem);
            if (result.Count != 0)
            {
                string errorMsg = "";
                for (int i = 0; i < result.Count; i++)
                    errorMsg += result[i] + "\n";

                MessageBox.Show(errorMsg, "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            remMng.AddRem(rem);
            ListReminders();
            changeStat = 1;
        }

        private void ShowReminder()
        {
            if (dtgIndex < 0 || dataGridRems.Rows.Count - 1 < dtgIndex || dtgIndex >= remMng.RemList.Count)
            {
                return;
            }
            txtTitle.Text = remMng.RemList[dtgIndex].Title;
            txtDesc.Text = remMng.RemList[dtgIndex].Desc;
            txtYear.Text = remMng.RemList[dtgIndex].Year.ToString();
            txtMonth.Text = remMng.RemList[dtgIndex].Month.ToString();
            txtDay.Text = remMng.RemList[dtgIndex].Day.ToString();
            txtHour.Text = remMng.RemList[dtgIndex].Hour.ToString();
            txtMin.Text = remMng.RemList[dtgIndex].Min.ToString();
            chkDone.Checked = remMng.RemList[dtgIndex].Done == 1 ? true : false;
        }

        private void dataGridRems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgIndex = e.RowIndex;
            ShowReminder();
        }

        private void ChangeReminder(object sender, EventArgs e)
        {
            if (dtgIndex < 0 || dataGridRems.Rows.Count - 1 < dtgIndex)
            {
                MessageBox.Show("Önce aşağıdan bir kayıt seçiniz", "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string[] rem = new string[9];
            rem[0] = chkDone.Checked ? "1" : "0";
            rem[1] = txtYear.Text;
            rem[2] = txtMonth.Text;
            rem[3] = txtDay.Text;
            rem[4] = txtHour.Text;
            rem[5] = txtMin.Text;
            rem[6] = txtTitle.Text;
            rem[7] = txtDesc.Text;

            List<string> result;
            result = remMng.FormControl(rem);
            if (result.Count != 0)
            {
                string errorMsg = "";
                for (int i = 0; i < result.Count; i++)
                    errorMsg += result[i] + "\n";

                MessageBox.Show(errorMsg, "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            remMng.ChangeRem(dtgIndex, rem);
            ListReminders();
            changeStat = 1;

        }
        private void RemoveReminder(object sender, EventArgs e)
        {
            if (dtgIndex < 0 || dataGridRems.Rows.Count - 1 < dtgIndex)
            {
                MessageBox.Show("Önce aşağıdan bir kayıt seçiniz", "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            remMng.RemoveRem(dtgIndex);
            ListReminders();
            changeStat = 1;
        }

        private void SaveReminders(object sender, EventArgs e)
        {
            remMng.SaveReminders();
            appForm.Show();
            changeStat = 0;
            this.Close();
        }

        private void CancelChanges(object sender, EventArgs e)
        {
            appForm.Show();
            this.Close();
        }
    }
}
