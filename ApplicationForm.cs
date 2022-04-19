using NesneProje.Reminder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje
{
    public partial class ApplicationForm : Form
    {
        Form loginForm;
        Form userMngForm;
        Form phoneBookForm;
        Form noteBookForm;
        Form profileForm;
        Form bmoForm;
        Form remForm;
        Users.UserManagement userMng;
        Users.User currentUser;
        Reminder.ReminderManager remMng;
        
        public ApplicationForm(Form _loginForm, Users.UserManagement _userMng, string mail)
        {
            InitializeComponent();
            loginForm = _loginForm;
            userMng = _userMng;
            Users.User _user = userMng.FindUserByMail(mail);
            switch (_user.UserType)
            {
                case 0: //admin
                    currentUser = new Users.AdminUser();
                    break;
                case 1: //standart
                    currentUser = new Users.StandartUser();
                    break;
                case 2: //part-time
                    currentUser = new Users.ParttimeUser();
                    break;
            }
            ShowHideComponents();
            currentUser.copyInfo(_user);
            remMng = new Reminder.ReminderManager(currentUser.UserID);
        }
        private void ShowHideComponents()
        {
            if (currentUser.UserMngAccess())
            {

            }
            else
            {
                btnManageForm.Hide();

            }
        }

        private void AfterClosed(object sender, FormClosedEventArgs e)
        {

            loginForm.Show();
        }

        private void OpenUserMng(object sender, EventArgs e)
        {
            if(currentUser.UserMngAccess())
            {
                userMngForm = new Users.UserManageForm(this, userMng, currentUser);
                userMngForm.Show();
                this.Hide();
            }
            
        }

        private void OpenPhoneBook(object sender, EventArgs e)
        {
            phoneBookForm = new PhoneBook.PhoneBookForm(this, currentUser.UserID);
            phoneBookForm.Show();
            this.Hide();
        }

        private void OpenNoteBook(object sender, EventArgs e)
        {
            noteBookForm = new NoteBook.NoteBookForm(this, currentUser.UserID);
            noteBookForm.Show();
            this.Hide();
        }

        private void OpenProfile(object sender, EventArgs e)
        {
            profileForm = new Users.ProfileManageForm(this, currentUser, userMng);
            profileForm.Show();
            this.Hide();
        }

        private void OpenBMOCalculator(object sender, EventArgs e)
        {
            bmoForm = new Users.BMOCalculator(this, currentUser, userMng);
            bmoForm.Show();
            this.Hide();
        }

        private void OpenReminder(object sender, EventArgs e)
        {
            remForm = new Reminder.ReminderForm(this, currentUser, remMng);
            remForm.Show();
            this.Hide();
        }

        private void remTimer_Tick(object sender, EventArgs e)
        {
            DateTime dNow = DateTime.Now;
            DateTime d1970 = new DateTime(1970, 1, 1);
            TimeSpan tSpan = dNow - d1970;
            Reminder.AlarmForm alarmForm;
            double mili = tSpan.TotalMilliseconds;

            for (int i = 0; i < remMng.RemList.Count; i++)
            {
                if (remMng.RemList[i].Done == 0 && remMng.RemList[i].Milis < mili)
                {
                    remMng.RemList[i].Done = 1;
                    alarmForm = new Reminder.AlarmForm(i, remMng);
                    alarmForm.Show();
                }
            }

        }
    }
}
