using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.PhoneBook
{
    public partial class PhoneBookForm : Form
    {
        int dtgIndex = -1;
        Form appForm;
        Form recForm;
        List<Record> recList;
        PhoneBook pBook;
        int changeStat = 0;

        public PhoneBookForm(Form _appForm, string userID)
        {
            InitializeComponent();
            appForm = _appForm;
            pBook = new PhoneBook(userID);
            recList = pBook.Recs;
            LoadRecords();
            ListRecords();
        }
        private void ListRecords()
        {
            dataGridPBook.Rows.Clear();
            string[] rec;
            for(int i = 0; i < recList.Count; i++)
            {
                rec = recList[i].GetInfo();
                dataGridPBook.Rows.Add(rec[0], rec[1], rec[2], rec[3], rec[4], rec[5]);
            }
        }

        private void AddRecord(object sender, EventArgs e)
        {
            recForm = new RecordForm(pBook, recList);
            recForm.Show();
            changeStat = 1;
        }

        private void PhoneBookForm_MouseEnter(object sender, EventArgs e)
        {
            ListRecords();
        }

        private void DataGridPBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgIndex = e.RowIndex;
        }
        private void ChangeRecord(object sender, EventArgs e)
        {
            if (dtgIndex < 0 || dataGridPBook.Rows.Count - 1 < dtgIndex)
            {
                MessageBox.Show("Önce aşağıdan bir kayıt seçiniz", "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            recForm = new RecordForm(pBook, recList[dtgIndex], recList);
            recForm.Show();
            changeStat = 1;
        }

        private void ShowRecord(object sender, EventArgs e)
        {
            if (dtgIndex < 0 || dataGridPBook.Rows.Count - 1 < dtgIndex)
            {
                MessageBox.Show("Önce aşağıdan bir kayıt seçiniz", "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            recForm = new RecordForm(recList[dtgIndex]);
            recForm.Show();
        }

        private void RemoveRecord(object sender, EventArgs e)
        {
            if (dtgIndex < 0 || dataGridPBook.Rows.Count - 1 < dtgIndex)
            {
                MessageBox.Show("Önce aşağıdan bir kayıt seçiniz", "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            pBook.RemoveRecord(recList[dtgIndex]);
            ListRecords();
            changeStat = 1;
        }

        private void SaveRecords(object sender, EventArgs e)
        {
            pBook.SaveUserRecords();
            appForm.Show();
            changeStat = 0;
            this.Close();
        }
        
        private void LoadRecords()
        {
            pBook.LoadUserRecords();
        }

        private void CancelChanges(object sender, EventArgs e)
        {
            appForm.Show();
            this.Close();
        }

        private void PhoneBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changeStat == 1)
            {
                var closeMsg = MessageBox.Show("Değişiklilerinizi kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (closeMsg == DialogResult.Yes)
                {
                    pBook.SaveUserRecords();
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
    }
}
