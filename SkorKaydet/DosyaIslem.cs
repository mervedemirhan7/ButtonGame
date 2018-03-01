
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaIslemleriLib
{
    public class DosyaIslem
    {
        public void DosyaKaydet(string path,string msg) //projeden projeye değişen şeyler için dışardan parametre alacak
        {            
            FileStream fs = new FileStream(path, DosyaKontrol(path)); 
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(msg);
            fs.Flush(); //filestreamin içindekileri temizliyor
            sw.Close();
            fs.Close();

        }
        public string DosyaOku(string path)
        {
            if (!File.Exists(path)) //Dosya yoksa
            {
                throw new DosyaBulunamadiException(path,"Dosya bulunamadı");   //hata fırlatsın
            }
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string msg= sr.ReadToEnd();
            fs.Flush();
            fs.Close();
            sr.Close();     //hafıza yönetimi için
            return msg;
        }
         FileMode DosyaKontrol(string path)
        {
            FileMode mod;
            if (File.Exists(path) == true)
            {
                mod = FileMode.Append;  //FileMode.CreateNew olursa sürekli yeni bir dosya oluşturuyor Append üstüne ekler
            }
            else
            {
                mod = FileMode.Create;
            }

            return mod;
        }




    }
}
