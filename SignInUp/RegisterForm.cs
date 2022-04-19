using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.SignInUp
{
    public partial class RegisterForm : Form
    {
        Form loginForm;
        Users.UserManagement userMng;
        Users.User newUser;
        Register rgs;
        public RegisterForm(Form _loginForm, Users.UserManagement _userMng)
        {
            InitializeComponent();
            userMng = _userMng;
            loginForm = _loginForm;
        }
        private void AfterClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        private void btnRegister(object sender, EventArgs e)
        {
            newUser = new Users.User();
            string[] userInfo = new string[8];
            userInfo[0] = txtName.Text;
            userInfo[1] = txtSurname.Text;
            userInfo[2] = txtMail.Text;
            userInfo[3] = txtPsw.Text;
            userInfo[4] = txtPhone.Text;
            userInfo[5] = txtBDay.Text;
            userInfo[6] = txtBMonth.Text;
            userInfo[7] = txtBYear.Text;

            rgs = new Register(userInfo);
            List<string> result = rgs.RegisterControl();

            if(result.Count != 0)
            {
                string errorMsg = "";
                for (int i = 0; i < result.Count; i++)
                    errorMsg += result[i] + "\n";

                MessageBox.Show(errorMsg, "Hatalı Kayıt!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            long phoneNumber = long.Parse(userInfo[4]);
            int[] bDate = { int.Parse(userInfo[5]), int.Parse(userInfo[6]), int.Parse(userInfo[7]) };

            int userType;
            if (userMng.UserList.Count == 0)
                userType = 0;
            else
                userType = 1;

            newUser.DefineUser(userInfo[0], userInfo[1], userInfo[2], userInfo[3], userType, phoneNumber, bDate);

            userMng.AddUser(newUser);

            loginForm.Show();
            this.Close();
        }
        private void btnBackToLogin(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
