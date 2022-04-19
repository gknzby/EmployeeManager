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
    public partial class LoginForm : Form
    {
        ApplicationForm appForm;
        RegisterForm regForm;
        Users.UserManagement userMng;
        Login lgn;

        public LoginForm()
        {
            InitializeComponent();
            userMng = new Users.UserManagement();
            userMng.LoadUsers();
            lgn = new Login(userMng);

            
        }
        ~LoginForm()
        {

        }

        private void BtnLogin(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string psw = txtPsw.Text;

            string result = lgn.UserLogin(mail, psw);

            lblError.Text = result;

            if (result == "Giriş Başarılı")
            {
                lblError.ForeColor = Color.Green;
                appForm = new ApplicationForm(this, userMng, mail);
                appForm.Show();
                this.Hide();
            }
        }
        private void BtnRegister(object sender, EventArgs e)
        {
            regForm = new RegisterForm(this, userMng);
            this.Hide();
            regForm.Show();
        }

        private void ExitSave(object sender, FormClosingEventArgs e)
        {
            userMng.SaveUsers();
        }
    }
}
