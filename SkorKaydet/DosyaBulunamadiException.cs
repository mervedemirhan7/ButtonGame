using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaIslemleriLib
{
    public class DosyaBulunamadiException:Exception
    {
        public DosyaBulunamadiException()
        {
         
        }
        public DosyaBulunamadiException(string path,string errmsg) //kendi exceptionumuzu yaratmak için
        {
            this.Path=path;
            this.Errmsg = errmsg;
        }

        public string Path { get; private set; }

        public string Errmsg { get; set; }
    }
}
