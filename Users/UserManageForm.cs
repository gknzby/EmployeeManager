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
    public partial class UserManageForm : Form
    {
        Form appForm;
        UserManagement userMng;
        User user;

        public UserManageForm(Form _appForm, UserManagement _userMng, User _user)
        {
            InitializeComponent();
            appForm = _appForm;
            userMng = _userMng;
            user = _user;
            ShowUserInfo(user);
            ListAllUsers();

            
        }
        private void ShowUserInfo(User infoUser)
        {
            txtUserID.Text = infoUser.UserID;
            txtMail.Text = infoUser.Mail;
            txtPsw.Text = infoUser.Password;
            txtName.Text = infoUser.Name;
            txtSurname.Text = infoUser.Surname;
            txtPhone.Text = infoUser.PhoneNumber.ToString();
            txtBDay.Text = infoUser.BirthDate[0].ToString();
            txtBMonth.Text = infoUser.BirthDate[1].ToString();
            txtBYear.Text = infoUser.BirthDate[2].ToString();

            cmbBxType.SelectedIndex = infoUser.UserType;
        }
        private void ListAllUsers()
        {
            for (int i = 0; i < userMng.UserList.Count; i++)
            {
                dataGridUsers.Rows.Add(userMng.UserList[i].Name, userMng.UserList[i].Surname, userMng.UserList[i].Mail);
            }
        }
        private void UserManageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            appForm.Show();
        }
        private void SelectedUserInfo(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || dataGridUsers.Rows.Count - 1 < index) return;
            DataGridViewRow dgvRow = dataGridUsers.Rows[index];
            string userMail = dgvRow.Cells[2].Value.ToString();
            User selectedUser = userMng.FindUserByMail(userMail);
            ShowUserInfo(selectedUser);
        }

        private void ChangeUserInfo(object sender, EventArgs e)
        {
            int index = userMng.GetUserIndex(txtUserID.Text);
            if (index < 0 || dataGridUsers.Rows.Count - 1 < index) return;

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

            long phone = long.Parse(userInfo[4]);
            int[] bDate = { int.Parse(userInfo[5]), int.Parse(userInfo[6]), int.Parse(userInfo[7]) };


            string ID = txtUserID.Text;
            int userType = cmbBxType.SelectedIndex;            

            userMng.UserList[index].DefineUser(userInfo[0], userInfo[1], userInfo[2], userInfo[3], userType, phone, bDate);
        }
        private void CancelChanges(object sender, EventArgs e)
        {
            appForm.Show();
            this.Close();
        }
    }
}
