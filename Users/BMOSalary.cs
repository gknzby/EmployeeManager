using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.Users
{
    class BMOSalary
    {
        string defaultLocation = "bmoInfos.csv";
        FileReadWrite fileRW = new FileReadWrite();

        List<string> lanKnowledge = new List<string>();
        string enKnowledge;
        string experience;
        string homeCity;
        string workCity;
        string education;
        string position;
        string married;
        string[] childs = new string[2];

        string userID;

        float defSalary = 4500f;
        struct Cities
        {
            public string city;
            public float factor;
            public Cities(string ct, float ft)
            {
                city = ct;
                factor = ft;
            }
        }

        Cities[] cityFactors = 
            { new Cities("İSTANBUL", 0.15f), new Cities("ANKARA", 0.10f), new Cities("İZMİR", 0.10f)
            , new Cities("KOCAELİ", 0.05f), new Cities("SAKARYA", 0.05f), new Cities("DÜZCE", 0.05f)
            , new Cities("BOLU", 0.05f), new Cities("YALOVA", 0.05f), new Cities("EDİRNE", 0.05f)
            , new Cities("KIRKLARELİ", 0.05f), new Cities("TEKİRDAĞ", 0.05f), new Cities("TRABZON", 0.03f)
            , new Cities("ORDU", 0.03f), new Cities("GİRESUN", 0.03f), new Cities("RİZE", 0.03f)
            , new Cities("ARTVİN", 0.03f), new Cities("GÜMÜŞHANE", 0.03f), new Cities("BURSA", 0.03f)
            , new Cities("AYDIN", 0.03f), new Cities("BİLECİK", 0.03f), new Cities("ESKİŞEHİR", 0.03f)
            , new Cities("DENİZLİ", 0.03f), new Cities("MUĞLA", 0.03f), new Cities("ADANA", 0.03f)
            , new Cities("ISPARTA", 0.03f), new Cities("ÇANAKKALE", 0.03f), new Cities("MERSİN", 0.03f)
            , new Cities("BURDUR", 0.03f), new Cities("ANTALYA", 0.03f), new Cities("BALIKESİR", 0.03f)
            };

        public List<string> LanKnowledge { get => lanKnowledge; set => lanKnowledge = value; }
        public string EnKnowledge { get => enKnowledge; set => enKnowledge = value; }
        public string Experience { get => experience; set => experience = value; }
        public string HomeCity { get => homeCity; set => homeCity = value; }
        public string WorkCity { get => workCity; set => workCity = value; }
        public string Education { get => education; set => education = value; }
        public string Position { get => position; set => position = value; }
        public string Married { get => married; set => married = value; }
        public string[] Childs { get => childs; set => childs = value; }

        public BMOSalary(string _userID)
        {
            userID = _userID;
            LoadBMOInfo();
        }

        public void DefineBMOInfo(List<string> _lanKn, string _enKn, string _exp, string _hCity, string _wCity, string _educ, string _pos, string _married, string[] _childs)
        {
            lanKnowledge = _lanKn;
            enKnowledge = _enKn;
            experience = _exp;
            homeCity = _hCity;
            workCity = _wCity;
            education = _educ;
            position = _pos;
            married = _married;
            childs[0] = _childs[0];
            childs[1] = _childs[1];
        }

        void SetDefault()
        {
            enKnowledge = "0";
            experience = "0";
            homeCity = "ADANA";
            workCity = "ADANA";
            education = "5";
            position = "6";
            married = "-1";
            childs[0] = "3";
            childs[1] = "3";
        }

        void LoadBMOInfo()
        {
            string[] bmoList = fileRW.CsvFileRead(defaultLocation);

            if (bmoList.Length < 1)
            {
                SetDefault();
                return;
            }

            int i = 0;
            int lanCount = int.Parse(bmoList[i + 1]);
            while (i < bmoList.Length) //find user
            {
                if (bmoList[i] == userID)
                    break;
                i = i + lanCount + 11;
            }

            if(bmoList.Length <= i) //can't find
            {
                SetDefault();
                return;
            }

            i = i + 2;
            for (int k = 0; k < lanCount; k++)
                lanKnowledge.Add(bmoList[i++]);

            enKnowledge = bmoList[i];
            experience = bmoList[i + 1];
            homeCity = bmoList[i + 2];
            workCity = bmoList[i + 3];
            education = bmoList[i + 4];
            position = bmoList[i + 5];
            married = bmoList[i + 6];
            childs[0] = bmoList[i + 7];
            childs[1] = bmoList[i + 8];
        }

        public void SaveBMOInfo()
        {
            string[] bmoList = fileRW.CsvFileRead(defaultLocation);

            int i = 0;

            if(bmoList.Length>0)
            {
                int lanCount = int.Parse(bmoList[i + 1]);
                while (i < bmoList.Length) //find user
                {
                    if (bmoList[i] == userID)
                        break;
                    i = i + lanCount + 11;
                }
            }
            List<string> allBMOInfo = new List<string>();
            for (int j = 0; j < bmoList.Length; j++)
            {
                allBMOInfo.Add(bmoList[j]);
            }

            if (bmoList.Length > i) //found
            {
                int lanCount = int.Parse(allBMOInfo.ElementAt(i+1));
                for (int j = 0; j < lanCount + 11; j++)
                    allBMOInfo.RemoveAt(i);
            }

            allBMOInfo.Add(userID);

            allBMOInfo.Add(lanKnowledge.Count.ToString());
            for (int j = 0; j < lanKnowledge.Count; j++)
                allBMOInfo.Add(lanKnowledge[j]);

            allBMOInfo.Add(enKnowledge);
            allBMOInfo.Add(experience);
            allBMOInfo.Add(homeCity);
            allBMOInfo.Add(workCity);
            allBMOInfo.Add(education);
            allBMOInfo.Add(position);
            allBMOInfo.Add(married);
            allBMOInfo.Add(childs[0]);
            allBMOInfo.Add(childs[1]);

            fileRW.CsvFileWrite(defaultLocation, allBMOInfo);
        }

        public float CalculateBMOSalary()
        {
            float totalSalary;
            float totalFactor;

            totalFactor = 1.00f + ExperienceCal() + CityCal() + EducationCal() + LanguageCal() + PositionCal() + FamilyCal();
            totalSalary = defSalary * totalFactor;

            return totalSalary;
        }

        float ExperienceCal()
        {
            if(int.Parse(experience) < 2)
            {
                return 0.00f;
            }
            else if(int.Parse(experience) < 5)
            {
                return 0.60f;
            }
            else if (int.Parse(experience) < 10)
            {
                return 1.00f;
            }
            else if (int.Parse(experience) < 15)
            {
                return 1.20f;
            }
            else if (int.Parse(experience) <= 20)
            {
                return 1.35f;
            }
            else
            {
                return 1.50f;
            }
        }

        float CityCal()
        {
            for(int i = 0; i < cityFactors.Length; i++)
            {
                if (workCity == cityFactors[i].city || homeCity == cityFactors[i].city)
                    return cityFactors[i].factor;
            }
            return 0.0f;
        }

        float EducationCal()
        {
            if (education == "-1")
            {
                return 0.0f;
            }
            else if (education == "0")
            {
                return 0.10f;
            }
            else if (education == "1")
            {
                return 0.30f;
            }
            else if (education == "2")
            {
                return 0.35f;
            }
            else if (education == "3")
            {
                return 0.05f;
            }
            else if (education == "4")
            {
                return 0.15f;
            }
            else
            {
                return 0.0f;
            }
        }

        float LanguageCal()
        {
            float total = 0.0f;
            if (enKnowledge == "0")
            {
                total += 0.0f;
            }
            else if (enKnowledge == "1")
            {
                total += 0.20f;
            }
            else if (enKnowledge == "2")
            {
                total += 0.20f;
            }

            total += 0.5f * (lanKnowledge.Count);

            return total;
        }

        float PositionCal()
        {
            if(position == "0")
            {
                return 0.50f;
            }
            else if (position == "1")
            {
                return 0.75f;
            }
            else if (position == "2")
            {
                return 0.85f;
            }
            else if (position == "3")
            {
                return 1.00f;
            }
            else if (position == "4")
            {
                return 0.40f;
            }
            else if (position == "5")
            {
                return 0.60f;
            }
            else
            {
                return 0.00f;
            }
        }

        float FamilyCal()
        {
            float total = 0.0f;

            if(married == "1")
            {
                total += 0.20f;
            }

            for(int i = 0; i < 2; i++)
            {
                if (childs[i] == "0")
                {
                    total += 0.20f;
                }
                else if (childs[i] == "1")
                {
                    total += 0.30f;
                }
                else if (childs[i] == "2")
                {
                    total += 0.40f;
                }
            }

            return total;
        }
    }
}
