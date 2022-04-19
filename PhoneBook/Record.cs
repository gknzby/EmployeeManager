using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.PhoneBook
{
    public class Record
    { 
        string name;
        string surname;
        string phone;
        string address;
        string description;
        string mail;

        public Record(string _name, string _surname, string _phone, string _address, string _description, string _mail)
        {
            name = _name;
            surname = _surname;
            phone = _phone;
            address = _address;
            description = _description;
            mail = _mail;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Description { get => description; set => description = value; }
        public string Mail { get => mail; set => mail = value; }

        public void ChangeRecord(string[] recordInfo)
        {
            name = recordInfo[0];
            surname = recordInfo[1];
            phone = recordInfo[2];
            address = recordInfo[3];
            description = recordInfo[4];
            mail = recordInfo[5];
        }
        public string[] GetInfo()
        {
            string[] recordInfo = new string[6];
            recordInfo[0] = name;
            recordInfo[1] = surname;
            recordInfo[2] = phone;
            recordInfo[3] = address;
            recordInfo[4] = description;
            recordInfo[5] = mail;

            return recordInfo;
        }
    }
}
