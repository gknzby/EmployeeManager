using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Reminder
{
    public class Remind
    {
        int done;
        int year;
        int month;
        int day;
        int hour;
        int min;
        string title;
        string desc;
        double milis;


        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }
        public int Hour { get => hour; set => hour = value; }
        public int Min { get => min; set => min = value; }
        public string Title { get => title; set => title = value; }
        public string Desc { get => desc; set => desc = value; }
        public double Milis { get => milis; set => milis = value; }
        public int Done { get => done; set => done = value; }

        public Remind(int _year, int _month, int _day, int _hour, int _min, string _title, string _desc)
        {
            done = 0;
            year = _year;
            month = _month;
            day = _day;
            hour = _hour;
            min = _min;
            title = _title;
            desc = _desc;

            CalMilis();
        }

        void CalMilis()
        {
            DateTime dt1970 = new DateTime(1970, 1, 1, 0,0,0);
            DateTime reminderTime = new DateTime(year, month, day, hour, min, 0);
            TimeSpan tSpan = reminderTime - dt1970;
            milis = tSpan.TotalMilliseconds;
        }

        void DefineRemind(int _year, int _month, int _day, int _hour, int _min, string _title, string _desc)
        {
            done = 0;
            year = _year;
            month = _month;
            day = _day;
            hour = _hour;
            min = _min;
            title = _title;
            desc = _desc;

            CalMilis();
        }

        public string[] GetInfo()
        {
            string[] infos = { done.ToString(), year.ToString(), month.ToString(), day.ToString(), hour.ToString(), min.ToString(), title.ToString(), desc.ToString() };
            return infos;
        }


    }
}
