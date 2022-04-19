using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.PhoneBook
{
    public class PhoneBook
    {
        List<Record> recs;
        string userID;
        int recordCount;
        string recordPath = "phonebook.csv";
        FileReadWrite fileRW;

        public List<Record> Recs { get => recs;}

        public PhoneBook(string _userID)
        {
            recs = new List<Record>();
            userID = _userID;
            recordCount = 0;
            fileRW = new FileReadWrite();
        }
        public void LoadUserRecords()
        {
            string[] allRecords = fileRW.CsvFileRead(recordPath);


            //find which part is belong to this user
            int i = 0;
            int count;
            while (i < allRecords.Length) //search all records, records systematic is => userID, record count, {record1}, {record2}
            {
                if (allRecords[i] == userID)
                    break;

                count = int.Parse(allRecords[i + 1]);
                i += 2 + count * 6; //record size is 6 string
            }

            if(allRecords.Length <= i) // if can't find
            {
                return;
            }

            Record rec;
            count = int.Parse(allRecords[i + 1]);
            recordCount = count;
            i = i + 2;
            for(int j = 1; j <= count; j++)
            {
                rec = new Record(allRecords[i], allRecords[i + 1], allRecords[i + 2], allRecords[i + 3], allRecords[i + 4], allRecords[i + 5]);
                recs.Add(rec);
                i += 6;
            }
        }
        public void SaveUserRecords()
        {
            string[] allRecords = fileRW.CsvFileRead(recordPath);

            //find which part is belong to this user
            int i = 0;
            int count;
            while (i < allRecords.Length) //search all records, records systematic is => userID, record count, {record1}, {record2}
            {
                if (allRecords[i] == userID)
                    break;

                count = int.Parse(allRecords[i + 1]);
                i += 2 + count * 6; //record size is 6 string
            }
            List<string> allRecsList = new List<string>(allRecords.Length);
            for(int j = 0; j < allRecords.Length; j++)
            {
                allRecsList.Add(allRecords[j]);
            }

            if (allRecords.Length <= i) // if can't find
            {
                allRecsList.Add(userID);
                allRecsList.Add(recs.Count.ToString());

                for(int j = 0; j < recordCount; j++)
                {
                    allRecsList.Add(recs[j].Name);
                    allRecsList.Add(recs[j].Surname);
                    allRecsList.Add(recs[j].Phone);
                    allRecsList.Add(recs[j].Address);
                    allRecsList.Add(recs[j].Description);
                    allRecsList.Add(recs[j].Mail);
                }
            }
            else //if find, first remove previous items then add new items
            {
                count = int.Parse(allRecords[i + 1]);
                allRecsList.RemoveRange(i + 2, count * 6);
                i += 2;
                for(int j = 0; j < recs.Count; j++)
                {
                    allRecsList.Insert(i + j * 6 + 0, recs[j].Name);
                    allRecsList.Insert(i + j * 6 + 1, recs[j].Surname);
                    allRecsList.Insert(i + j * 6 + 2, recs[j].Phone);
                    allRecsList.Insert(i + j * 6 + 3, recs[j].Address);
                    allRecsList.Insert(i + j * 6 + 4, recs[j].Description);
                    allRecsList.Insert(i + j * 6 + 5, recs[j].Mail);
                }
            }
            fileRW.CsvFileWrite(recordPath, allRecsList);
        }

        public void AddRecord(Record rec)
        {
            recs.Add(rec);
            recordCount++;
        }
        public void RemoveRecord(Record rec)
        {
            recs.Remove(rec);
            recordCount--;
        }
        public void ChangeRecord(Record oldRec, Record newRec)
        {
            int index = recs.IndexOf(oldRec);
            recs[index].ChangeRecord(newRec.GetInfo());
        }

        public List<string> FormControl(string[] recInfo)
        {
            List<string> result = new List<string>();

            if (!InputControl.Name(recInfo[0]))
                result.Add("Geçerli bir ad giriniz.");
            if (!InputControl.Name(recInfo[1]))
                result.Add("Geçerli bir soyad giriniz.");
            if (!InputControl.Phone(recInfo[2]))
                result.Add("Geçerli bir telefon numarası giriniz.");
            if (!InputControl.Mail(recInfo[5]))
                result.Add("Geçerli bir e-posta adresi giriniz.");

            return result;
        }
    }
}
