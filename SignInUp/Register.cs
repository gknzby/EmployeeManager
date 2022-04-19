using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.SignInUp
{
    class Register
    {
        string[] userInfo;

        public Register(string[] _userInfo)
        {
            userInfo = _userInfo;
        }
        public List<string> RegisterControl()
        {
            List<string> result = new List<string>();

            if (!InputControl.Name(userInfo[0]))
                result.Add("Geçerli bir ad giriniz.");
            if (!InputControl.Name(userInfo[1]))
                result.Add("Geçerli bir soyad giriniz.");
            if(!InputControl.Mail(userInfo[2]))
                result.Add("Geçerli bir e-posta adresi giriniz.");
            if (!InputControl.Password(userInfo[3]))
                result.Add("Şifre 8 ile 16 karakter arasında olmalıdır.");
            if (!InputControl.Phone(userInfo[4]))
                result.Add("Geçerli bir telefon numarası giriniz.");
            if (!InputControl.BirthDate(userInfo[5], userInfo[6], userInfo[7]))
                result.Add("Geçerli bir doğum tarihi giriniz.");

            return result;
        }
        private bool NameControl()
        {
            if (userInfo[0].Length < 2 || userInfo[0].Length > 36)
                return false;
            return true;
        }
        private bool SurnameControl()
        {
            if (userInfo[1].Length < 2 || userInfo[1].Length > 36)
                return false;
            return true;
        }
        private bool MailControl()
        {
            int atCount = userInfo[2].Split('@').Length - 1;
            int dotCount = userInfo[2].Split('.').Length - 1;

            if (atCount != 1 || dotCount != 1)
                return false;
            if (userInfo[2].Length < 12 || userInfo[2].Length > 36)
                return false;
            if (userInfo[2].IndexOf('@') > userInfo[2].IndexOf('.'))
                return false;
            if (userInfo[2].IndexOf('.') + 1 == userInfo.Length)
                return false;

            return true;
        }
        private bool PasswordControl()
        {
            if (userInfo[3].Length < 8 || userInfo[3].Length > 16)
                return false;
            return true;
        }
        private bool PhoneControl()
        {
            if (userInfo[4].Length != 10)
                return false;
            for (int i = 0; i < 11; i++)
                if (userInfo[4][i] < 48 || userInfo[4][i] > 57)
                    return false;
            return true;
        }
        private bool BirthDateControl()
        {
            if (userInfo[5].Length < 1 || userInfo[5].Length > 2)
                return false;
            for (int i = 0; i < userInfo[5].Length; i++)
                if (userInfo[5][i] < 48 || userInfo[5][i] > 57)
                    return false;

            if (userInfo[6].Length < 1 || userInfo[6].Length > 2)
                return false;
            for (int i = 0; i < userInfo[6].Length; i++)
                if (userInfo[6][i] < 48 || userInfo[6][i] > 57)
                    return false;

            if (userInfo[7].Length != 4)
                return false;
            for (int i = 0; i < 4; i++)
                if (userInfo[7][i] < 48 || userInfo[7][i] > 57)
                    return false;

            if (int.Parse(userInfo[7]) < 1900 || int.Parse(userInfo[7]) > 2020)
                return false;
            else
            {
                if (int.Parse(userInfo[6]) < 1 || int.Parse(userInfo[6]) > 12)
                    return false;
                else
                {
                    int year = int.Parse(userInfo[7]);
                    int month = int.Parse(userInfo[6]);
                    int day = int.Parse(userInfo[5]);

                    if (day < 1)
                        return false;

                    if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day > 31)
                        return false;
                    else if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                        return false;
                    else if ((year % 4 == 0 && day > 29) || (year % 4 != 0 && day > 28))
                        return false;
                }
            }
            return true;
        }

    }
}
