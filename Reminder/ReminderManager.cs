using NesneProje.NoteBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.Reminder
{
    public class ReminderManager
    {
        List<Remind> remList;
        string userID;
        string remindersPath;
        FileReadWrite fileRW;

        public ReminderManager(string _userID)
        {
            fileRW = new FileReadWrite();
            remindersPath = "reminders.csv";
            userID = _userID;
            remList = new List<Remind>();
            LoadReminders();
        }

        public List<Remind> RemList { get => remList; set => remList = value; }

        void LoadReminders()
        {
            string[] allReminders = fileRW.CsvFileRead(remindersPath);

            int i = 0;
            int count;
            while (i < allReminders.Length)
            {
                if (allReminders[i] == userID)
                    break;

                count = int.Parse(allReminders[i + 1]);
                i += 2 + count * 9;
            }

            if (allReminders.Length <= i)
                return;

            Remind rem;
            count = int.Parse(allReminders[i + 1]);
            i = i + 2;
            for(int j = 0; j<count; j++)
            {
                rem = new Remind(int.Parse(allReminders[i + 1]), int.Parse(allReminders[i + 2]), int.Parse(allReminders[i + 3]),
                                 int.Parse(allReminders[i + 4]), int.Parse(allReminders[i + 5]), allReminders[i + 6],
                                  allReminders[i + 7]);
                rem.Done = int.Parse(allReminders[i]);
                rem.Milis = double.Parse(allReminders[i + 8]);
                remList.Add(rem);
                i += 9;
            }
        }

        public void SaveReminders()
        {
            string[] allReminders = fileRW.CsvFileRead(remindersPath);

            int i = 0;
            int count;
            while (i < allReminders.Length)
            {
                if (allReminders[i] == userID)
                    break;

                count = int.Parse(allReminders[i + 1]);
                i += 2 + count * 9;
            }

            List<string> allRemList = new List<string>();
            for (int j = 0; j < allReminders.Length; j++)
                allRemList.Add(allReminders[j]);

            if(i < allReminders.Length)
            {
                count = int.Parse(allReminders[i + 1]);
                allRemList.RemoveRange(i, 2 + 9 * count);
            }
            allRemList.Add(userID);
            allRemList.Add(remList.Count.ToString());

            for (int j = 0; j < remList.Count; j++)
            {
                allRemList.Add(remList[j].Done.ToString());
                allRemList.Add(remList[j].Year.ToString());
                allRemList.Add(remList[j].Month.ToString());
                allRemList.Add(remList[j].Day.ToString());
                allRemList.Add(remList[j].Hour.ToString());
                allRemList.Add(remList[j].Min.ToString());
                allRemList.Add(remList[j].Title.ToString());
                allRemList.Add(remList[j].Desc.ToString());
                allRemList.Add(remList[j].Milis.ToString());
            }

            fileRW.CsvFileWrite(remindersPath, allRemList);
        }
        public void AddRem(string[] rem)
        {
            Remind nRem = new Remind(int.Parse(rem[1]), int.Parse(rem[2]), int.Parse(rem[3]),
                                    int.Parse(rem[4]), int.Parse(rem[5]), rem[6], rem[7]);
            nRem.Done = int.Parse(rem[0]);

            remList.Add(nRem);
        }
        public void RemoveRem(int index)
        {
            if (index >= remList.Count || index < 0)
                return;
            remList.RemoveAt(index);
        }
        public void ChangeRem(int index, string[] rem)
        {
            Remind nRem = new Remind(int.Parse(rem[1]), int.Parse(rem[2]), int.Parse(rem[3]),
                        int.Parse(rem[4]), int.Parse(rem[5]), rem[6], rem[7]);
            nRem.Done = int.Parse(rem[0]);

            remList[index] = nRem;
        }
        public List<string> FormControl(string[] remInfo)
        {
            List<string> result = new List<string>();

            if (InputControl.DateControl(remInfo[3], remInfo[2], remInfo[1]) == 0)
                result.Add("Geçerli bir tarih giriniz.");
            else if (InputControl.DateControl(remInfo[3], remInfo[2], remInfo[1]) == 2)
                if (!InputControl.TimeControl(remInfo[4], remInfo[5]))
                    result.Add("Geçerli bir saat giriniz.");
            if (remInfo[6].Length < 1)
                result.Add("Başlık boş olamaz");
            return result;
        }

    }
}
