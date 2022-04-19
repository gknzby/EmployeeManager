using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Users
{
    public class UserManagement
    {
        //Variables//
        List<User> userList = new List<User>();
        FileReadWrite fileRW = new FileReadWrite();
        string defaultLocation = "userList.txt";
        /////////////


        //GetSet//
        public List<User> UserList { get => userList; set => userList = value; }
        //////////

        //Functions//
        public void AddUser(User newUser)
        {
            userList.Add(newUser);
        }
        public bool DeleteUser(User _user)
        {
            return userList.Remove(_user);
        }
        public User FindUserByMail(string mail)
        {
            for(int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Mail == mail)
                {
                    return userList[i];
                }
            }

            return CouldntFind();
        }
        public User FindUserById(string userID)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].UserID == userID)
                {
                    return userList[i];
                }
            }

            return CouldntFind();
        }
        public User FindUserByPhone(int phone)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].PhoneNumber == phone)
                {
                    return userList[i];
                }
            }

            return CouldntFind();
        }
        public List<User> FindUsersByName(string name)
        {
            List<User> _users = new List<User>();
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name.IndexOf(name) + userList[i].Surname.IndexOf(name) != -2)
                {
                    _users.Add(userList[i]);
                }
            }

            return _users;
        }
        private User CouldntFind()
        {
            User failure = new User();
            int[] bDay = { 1, 1, 1970 };
            failure.DefineUser("Kullanıcı", "Bulunamadı", "Hata", "Hata", -1, -1, bDay);
            return failure;
        }
        public void ChangeUser(User oldUser, string[] changes)
        {
            int _type = int.Parse(changes[5]);
            long _number = long.Parse(changes[6]);
            int[] _bDay = { int.Parse(changes[7]), int.Parse(changes[8]), int.Parse(changes[9]) };

            int indexOfUser = userList.IndexOf(oldUser);
            userList[indexOfUser].DefineUser(changes[1], changes[2], changes[3], changes[4], _type, _number, _bDay);
        }
        public void LoadUsers()
        {
            string[] uList = fileRW.CsvFileRead(defaultLocation);
            int userCount = uList.Length / 11;
            for(int i = 0; i < userCount; i++)
            {
                int fac = i * 11;
                User oldUser = new User();
                oldUser.UserID = uList[fac];
                int[] bDay = { int.Parse(uList[fac + 7]), int.Parse(uList[fac + 8]), int.Parse(uList[fac + 9]) };
                oldUser.DefineUser(uList[fac + 4], uList[fac + 5], uList[fac + 2], uList[fac + 3], int.Parse(uList[fac + 1]), long.Parse(uList[fac + 6]), bDay);
                oldUser.BmoSalary = float.Parse(uList[fac + 10]);
                userList.Add(oldUser);

            }
        }
        public void SaveUsers()
        {
            List<string> userStrLst = new List<string>();
            for(int i = 0; i < userList.Count; i++)
            {
                userStrLst.Add(userList[i].UserID);
                userStrLst.Add(userList[i].UserType.ToString());
                userStrLst.Add(userList[i].Mail);
                userStrLst.Add(userList[i].Password);
                userStrLst.Add(userList[i].Name);
                userStrLst.Add(userList[i].Surname);
                userStrLst.Add(userList[i].PhoneNumber.ToString());
                int[] bDay = userList[i].BirthDate;
                userStrLst.Add(bDay[0].ToString());
                userStrLst.Add(bDay[1].ToString());
                userStrLst.Add(bDay[2].ToString());
                userStrLst.Add(userList[i].BmoSalary.ToString());
            }
            fileRW.CsvFileWrite(defaultLocation, userStrLst);
        }
        public int GetUserIndex(string userID)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].UserID == userID)
                {
                    return i;
                }
            }
            return -1;
        }

        static public List<string> ChangeControl(string[] userInfo)
        {
            List<string> result = new List<string>();

            if (!InputControl.Name(userInfo[0]))
                result.Add("Geçerli bir ad giriniz.");
            if (!InputControl.Name(userInfo[1]))
                result.Add("Geçerli bir soyad giriniz.");
            if (!InputControl.Mail(userInfo[2]))
                result.Add("Geçerli bir e-posta adresi giriniz.");
            if (!InputControl.Password(userInfo[3]))
                result.Add("Şifre 8 ile 16 karakter arasında olmalıdır.");
            if (!InputControl.Phone(userInfo[4]))
                result.Add("Geçerli bir telefon numarası giriniz.");
            if (!InputControl.BirthDate(userInfo[5], userInfo[6], userInfo[7]))
                result.Add("Geçerli bir doğum tarihi giriniz.");

            return result;
        }

        /////////////


    }
}
