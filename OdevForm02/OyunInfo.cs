using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevForm02
{
    public enum Seviyeler
    {
        Kolay,
        Orta,
        Zor
    }
    public class OyunInfo
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Seviyeler Seviye { get; set; }

        public int Süre { get; set; }

        public int Puan { get; set; }

    }
}
