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
    public partial class RecordForm : Form
    {
        Record rec;
        PhoneBook pBook;
        List<Record> recList;
        int stat;

        public RecordForm(Record _rec) //Just show record
        {
            InitializeComponent();
            DisableTxt();
            rec = _rec;
            ShowInfo();
            stat = 0;
        }
        public RecordForm(PhoneBook _pBook, List<Record> _recList) //Add new record
        {
            InitializeComponent();
            recList = _recList;
            stat = 1;
            pBook = _pBook;
        }
        public RecordForm(PhoneBook _pBook, Record _rec, List<Record> _recList) //Change record
        {
            InitializeComponent();
            rec = _rec;
            recList = _recList;
            ShowInfo();
            stat = 2;
            pBook = _pBook;
        }

        public void ShowInfo()
        {
            txtName.Text = rec.Name;
            txtSurname.Text = rec.Surname;
            txtPhone.Text = rec.Phone;
            txtAddress.Text = rec.Address;
            txtDescription.Text = rec.Description;
            txtMail.Text = rec.Mail;
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            string[] recInfo;
            if (stat != 0)
            {
                recInfo = new string[6];
                recInfo[0] = txtName.Text;
                recInfo[1] = txtSurname.Text;
                recInfo[2] = txtPhone.Text;
                recInfo[3] = txtAddress.Text;
                recInfo[4] = txtDescription.Text;
                recInfo[5] = txtMail.Text;

                List<string> result;
                result = pBook.FormControl(recInfo);

                if (result.Count != 0)
                {
                    string errorMsg = "";
                    for (int i = 0; i < result.Count; i++)
                        errorMsg += result[i] + "\n";

                    MessageBox.Show(errorMsg, "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (stat == 1)
                    addRecord(recInfo);
                else if (stat == 2)
                    changeRecord(recInfo);
            }



            this.Close();
        }
        public void changeRecord(string[] recInfo)
        {
            rec.ChangeRecord(recInfo);
        }
        public void addRecord(string[] recInfo)
        {
            rec = new Record(recInfo[0], recInfo[1], recInfo[2], recInfo[3], recInfo[4], recInfo[5]);
            pBook.AddRecord(rec);
        }
        private void DisableTxt()
        {
            txtName.ReadOnly = true;
            txtSurname.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtMail.ReadOnly = true;
        }

    }
}
