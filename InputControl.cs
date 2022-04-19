using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class InputControl
    {
        static public bool Name(string name)
        {
            if (name.Length < 2 || name.Length > 36)
                return false;
            return true;
        }
        static public bool Mail(string mail)
        {
            int atCount = mail.Split('@').Length - 1;
            int dotCount = mail.Split('.').Length - 1;

            if (atCount != 1 || dotCount != 1)
                return false;
            if (mail.Length < 12 || mail.Length > 36)
                return false;
            if (mail.IndexOf('@') > mail.IndexOf('.'))
                return false;
            if (mail.IndexOf('.') + 1 == mail.Length)
                return false;

            return true;
        }
        static public bool Password(string password)
        {
            if (password.Length < 8 || password.Length > 16)
                return false;
            return true;
        }
        static public bool Phone(string phone)
        {
            if (phone.Length != 10)
                return false;
            for (int i = 0; i < 10; i++)
                if (phone[i] < 48 || phone[i] > 57)
                    return false;
            return true;
        }
        static public bool BirthDate(string bDay, string bMonth, string bYear)
        {
            if (bDay.Length < 1 || bDay.Length > 2)
                return false;
            for (int i = 0; i < bDay.Length; i++)
                if (bDay[i] < 48 || bDay[i] > 57)
                    return false;

            if (bMonth.Length < 1 || bMonth.Length > 2)
                return false;
            for (int i = 0; i < bMonth.Length; i++)
                if (bMonth[i] < 48 || bMonth[i] > 57)
                    return false;

            if (bYear.Length != 4)
                return false;
            for (int i = 0; i < 4; i++)
                if (bYear[i] < 48 || bYear[i] > 57)
                    return false;

            if (int.Parse(bYear) < 1900 || int.Parse(bYear) > 2020)
                return false;
            else
            {
                if (int.Parse(bMonth) < 1 || int.Parse(bMonth) > 12)
                    return false;
                else
                {
                    int year = int.Parse(bYear);
                    int month = int.Parse(bMonth);
                    int day = int.Parse(bDay);

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

        static public int DateControl(string day, string month, string year)
        {
            DateTime dateT = DateTime.Now;
            int nYear = dateT.Year;
            int nMonth = dateT.Month;
            int nDay = dateT.Day;

            if (day.Length < 1 || day.Length > 2)
                return 0;
            for (int i = 0; i < day.Length; i++)
                if (day[i] < 48 || day[i] > 57)
                    return 0;

            if (month.Length < 1 || month.Length > 2)
                return 0;
            for (int i = 0; i < month.Length; i++)
                if (month[i] < 48 || month[i] > 57)
                    return 0;

            if (year.Length != 4)
                return 0;
            for (int i = 0; i < 4; i++)
                if (year[i] < 48 || year[i] > 57)
                    return 0;

            if(int.Parse(year) < nYear)
            {
                return 0;
            }
            else if(int.Parse(year) == nYear)
            {
                if (int.Parse(month) < nMonth)
                    return 0;
                else if(int.Parse(month) == nMonth)
                {
                    if (int.Parse(day) < nDay)
                        return 0;
                    else if (int.Parse(day) == nDay)
                        return 2;
                }
            }
            else
            {
                if (int.Parse(month) < 1 || int.Parse(month) > 12)
                    return 0;
                else
                {
                    int _year = int.Parse(year);
                    int _month = int.Parse(month);
                    int _day = int.Parse(day);

                    if (_day < 1)
                        return 0;

                    if ((_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12) && _day > 31)
                        return 0;
                    else if ((_month == 4 || _month == 6 || _month == 9 || _month == 11) && _day > 30)
                        return 0;
                    else if ((_year % 4 == 0 && _day > 29) || (_year % 4 != 0 && _day > 28))
                        return 0;
                }
            }
            return 1;
        }

        public static bool TimeControl(string hour, string min)
        {
            if (hour.Length < 1 || hour.Length > 2)
                return false;
            for (int i = 0; i < hour.Length; i++)
                if (hour[i] < 48 || hour[i] > 57)
                    return false;

            if (min.Length < 1 || min.Length > 2)
                return false;
            for (int i = 0; i < min.Length; i++)
                if (min[i] < 48 || min[i] > 57)
                    return false;

            int tHour = int.Parse(hour);
            int tMin = int.Parse(min);
            DateTime dTime = DateTime.Now;
            int nHour = dTime.Hour;
            int nMin = dTime.Minute;

            if (tHour < nHour)
                return false;
            else if(tHour == nHour)
                if (tMin <= nMin)
                    return false;
            if (tHour < 0 || tHour > 23)
                return false;
            if (tMin < 0 || tMin > 59)
                return false;

            return true;
        }
    }
}
