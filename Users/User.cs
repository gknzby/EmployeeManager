using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Users
{
    public class User
    {
        //Variables//
        private string userID;
        string name = "Ad";
        string surname = "Soyad";
        string mail = "ad_soyad@mail.com";
        string password = "kullanicisifre";
        int userType = 1;
        long phoneNumber = 5555555555;
        int[] birthDate = { 1, 1, 1970 };
        float bmoSalary = 0;
        /////////////

        //GetSet//
        public string UserID { get => userID; set => userID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public int UserType { get => userType; set => userType = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int[] BirthDate { get => birthDate; set => birthDate = value; }
        public float BmoSalary { get => bmoSalary; set => bmoSalary = value; }


        //////////

        //Functions//
        public User()
        {
            DateTime dt1970 = new DateTime(1970, 1, 1);
            DateTime current = DateTime.Now;
            TimeSpan span = current - dt1970;
            string[] miliNum = span.TotalMilliseconds.ToString().Split(',');
            userID = "u" + miliNum[0];
        }
        public void DefineUser(string _name, string _surname, string _mail, string _psw, int _userType, long _phone, int[] _birthDate)
        {
            name = _name;
            surname = _surname;
            mail = _mail;
            password = _psw;
            userType = _userType;
            phoneNumber = _phone;
            birthDate = _birthDate;
        }
        public string[] getInfo()
        {
            string[] userInfo = new string[10];

            userInfo[0] = userID;
            userInfo[1] = userType.ToString();
            userInfo[2] = mail;
            userInfo[3] = password;
            userInfo[4] = name;
            userInfo[5] = surname;
            userInfo[6] = phoneNumber.ToString();
            userInfo[7] = birthDate[0].ToString();
            userInfo[8] = birthDate[1].ToString();
            userInfo[9] = birthDate[2].ToString();

            return userInfo;
        }
        public virtual bool UserMngAccess()
        { return false; }
        public void copyInfo(User _user)
        {
            userID = _user.UserID;
            userType = _user.UserType;
            mail = _user.Mail;
            password = _user.Password;
            name = _user.Name;
            surname = _user.Surname;
            phoneNumber = _user.PhoneNumber;
            birthDate = _user.BirthDate;
            bmoSalary = _user.BmoSalary;
        }

        public virtual float GetSalary()
        { return bmoSalary; }
        /////////////
    }
}
