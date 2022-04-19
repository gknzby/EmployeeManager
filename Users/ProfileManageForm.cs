using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.Users
{
    public partial class ProfileManageForm : Form
    {
        Form appForm;
        User currentUser;
        UserManagement userMng;
        Image pPhoto;
        PhotoManager pMng;
        List<string[]> changeStack;
        int stackIndex;
        bool ctrlKey;

        public ProfileManageForm(Form _appForm, User _currentUser, UserManagement _userMng)
        {
            InitializeComponent();
            appForm = _appForm;
            currentUser = _currentUser;
            userMng = _userMng;
            pMng = new PhotoManager();
            changeStack = new List<string[]>();
            stackIndex = 0;
            ShowInfo();
        }
        public void ShowInfo()
        {
            txtName.Text = currentUser.Name;
            txtSurname.Text = currentUser.Surname;
            txtMail.Text = currentUser.Mail;
            txtPsw.Text = currentUser.Password;
            txtPhone.Text = currentUser.PhoneNumber.ToString();
            txtBDay.Text = currentUser.BirthDate[0].ToString();
            txtBMonth.Text = currentUser.BirthDate[1].ToString();
            txtBYear.Text = currentUser.BirthDate[2].ToString();
            txtSalary.Text = currentUser.BmoSalary.ToString();

            picUser.Image = pMng.GetPhoto(currentUser.UserID);
        }


        private void ProfileManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appForm.Show();
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            string[] userInfo = new string[8];
            userInfo[0] = txtName.Text;
            userInfo[1] = txtSurname.Text;
            userInfo[2] = txtMail.Text;
            userInfo[3] = txtPsw.Text;
            userInfo[4] = txtPhone.Text;
            userInfo[5] = txtBDay.Text;
            userInfo[6] = txtBMonth.Text;
            userInfo[7] = txtBYear.Text;

            List<string> result = UserManagement.ChangeControl(userInfo);

            if (result.Count != 0)
            {
                string errorMsg = "";
                for (int i = 0; i < result.Count; i++)
                    errorMsg += result[i] + "\n";

                MessageBox.Show(errorMsg, "Hatalı Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int index = userMng.GetUserIndex(currentUser.UserID);

            long phone = long.Parse(txtPhone.Text);
            int[] bDate = new int[3];
            bDate[0] = int.Parse(txtBDay.Text);
            bDate[1] = int.Parse(txtBMonth.Text);
            bDate[2] = int.Parse(txtBYear.Text);

            userMng.UserList[index].DefineUser(userInfo[0], userInfo[1], userInfo[2], userInfo[3], currentUser.UserType, phone, bDate);

            currentUser.Name = userInfo[0];
            currentUser.Surname = userInfo[1];
            currentUser.Mail = userInfo[2];
            currentUser.Password = userInfo[3];
            currentUser.PhoneNumber = phone;
            currentUser.BirthDate = bDate;

            this.Close();
        }

        private void CancelChanges(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool ThumbnailCallback()
        {
            return false;
        }
        private void LoadPhoto(object sender, EventArgs e)
        {
            OpenFileDialog photoFileDialog = new OpenFileDialog();

            photoFileDialog.InitialDirectory = "c:\\";
            photoFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            photoFileDialog.FilterIndex = 0;
            photoFileDialog.RestoreDirectory = true;

            if (photoFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = photoFileDialog.FileName;
                Image _img = Image.FromFile(fileName);
                Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                pPhoto = _img.GetThumbnailImage(128, 128, myCallback, IntPtr.Zero);
                pMng.SavePhoto(currentUser.UserID, pPhoto);
                picUser.Image = pPhoto;
            }

        }

        private void AddStack(object sender, EventArgs e)
        {
            while (stackIndex < changeStack.Count)
                changeStack.RemoveAt(stackIndex);

            string[] userInfo = new string[8];
            userInfo[0] = txtName.Text;
            userInfo[1] = txtSurname.Text;
            userInfo[2] = txtMail.Text;
            userInfo[3] = txtPsw.Text;
            userInfo[4] = txtPhone.Text;
            userInfo[5] = txtBDay.Text;
            userInfo[6] = txtBMonth.Text;
            userInfo[7] = txtBYear.Text;

            changeStack.Add(userInfo);
            stackIndex++;
        }
        private void PreviousStep()
        {
            string[] userInfo = changeStack[stackIndex--];
            txtName.Text= userInfo[0];
            txtSurname.Text = userInfo[1];
            txtMail.Text = userInfo[2];
            txtPsw.Text = userInfo[3];
            txtPhone.Text = userInfo[4];
            txtBDay.Text = userInfo[5];
            txtBMonth.Text = userInfo[6];
            txtBYear.Text = userInfo[7];
        }
        private void NextStep()
        {
            if (stackIndex == changeStack.Count)
                return;

            string[] userInfo = changeStack[++stackIndex];
            txtName.Text = userInfo[0];
            txtSurname.Text = userInfo[1];
            txtMail.Text = userInfo[2];
            txtPsw.Text = userInfo[3];
            txtPhone.Text = userInfo[4];
            txtBDay.Text = userInfo[5];
            txtBMonth.Text = userInfo[6];
            txtBYear.Text = userInfo[7];
        }

        private void HotkeyMng(object sender, KeyEventArgs e)
        {
            if (!ctrlKey)
            {
                if (e.KeyCode == Keys.Control)
                {
                    ctrlKey = true;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Z)
                {
                    PreviousStep();
                }
                else if (e.KeyCode == Keys.Y)
                {
                    NextStep();
                }
                else if (e.KeyCode == Keys.Control)
                    return;
                else
                    ctrlKey = false;
            }
        }

        private void ProfileManageForm_KeyUp(object sender, KeyEventArgs e)
        {
            ctrlKey = false;
        }
    }
}
 
