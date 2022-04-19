using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace NesneProje.Users
{
    public class PhotoManager
    {
        string sourcePath = "userPhotos.csv";
        FileReadWrite fileRW = new FileReadWrite();
        public PhotoManager()
        {

        }
        public Image GetPhoto(string userID)
        {
            Image userPhoto;

            string[] allPhotos = fileRW.CsvFileRead(sourcePath);

            int i;
            //find user
            for (i = 0; i < allPhotos.Length; i += 2)
            {
                if (allPhotos[i] == userID)
                    break;
            }

            string base64;
            if (allPhotos.Length <= i)
                base64 = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mOUqwcAAMEAnwarUJAAAAAASUVORK5CYII=";

            else
                base64 = allPhotos[i + 1];



            byte[] bytes = Convert.FromBase64String(base64);

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                userPhoto = Image.FromStream(ms);
            }

            return userPhoto;
        }
        public void SavePhoto(string userID, Image userPhoto)
        {
            string[] allPhotos = fileRW.CsvFileRead(sourcePath);

            int i;
            //find user
            for (i = 0; i < allPhotos.Length; i += 2)
            {
                if (allPhotos[i] == userID)
                    break;
            }

            string base64;
            using (MemoryStream ms = new MemoryStream())
            {
                userPhoto.Save(ms, ImageFormat.Png);
                byte[] bytes = ms.ToArray();
                base64 = Convert.ToBase64String(bytes);
            }

            if (i < allPhotos.Length)
            {
                allPhotos[i + 1] = base64;
                fileRW.CsvFileWrite(sourcePath, allPhotos);
                return;
            }

            List<string> allPhotoList = new List<string>(allPhotos);
            allPhotoList.Add(userID);
            allPhotoList.Add(base64);
            fileRW.CsvFileWrite(sourcePath, allPhotoList);
            return;
        }

    }
}
