using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NesneProje
{
    class FileReadWrite
    {


        ////Functions////
        public string FileRead(string sourcePath)
        {
            if (!File.Exists(sourcePath))
            {
                return "";
            }
            string fileContent = File.ReadAllText(sourcePath);

            return fileContent;
        }
        public void FileWrite(string destPath, string content)
        {
            File.WriteAllText(destPath, content);

            return;
        }
        public string[] CsvFileRead(string sourcePath)
        {
            string fileContent = FileRead(sourcePath);

            if(fileContent == "")
                return new string[0];

            return fileContent.Split(',');
        }
        public void CsvFileWrite(string destPath, string[] content)
        {
            string fileContent = "";
            fileContent += content[0];
            for (int i = 1; i < content.Length; i++)
            {
                fileContent += "," + content[i];
            }
            FileWrite(destPath, fileContent);

            return;
        }
        public void CsvFileWrite(string destPath, List<string> content)
        {
            string fileContent = "";
            fileContent += content[0];
            for (int i = 1; i < content.Count; i++)
            {
                fileContent += "," + content[i];
            }
            FileWrite(destPath, fileContent);

            return;
        }

        /////////////
    }
}
