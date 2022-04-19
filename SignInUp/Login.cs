using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.SignInUp
{
    class Login
    {
        private readonly Users.UserManagement userMng;

        public Login(Users.UserManagement _userMng)
        {
            userMng = _userMng;
        }
        public string UserLogin(string mail, string psw)
        {
            Users.User _user;
            _user = userMng.FindUserByMail(mail);
            if (_user.UserType == -1)
            {
                return "Mail adresi bulunamadı";
            }
            else if(_user.Password != psw)
            {
                return "Yanlış Şifre";
            }

            return "Giriş Başarılı";
        }
    }
}
