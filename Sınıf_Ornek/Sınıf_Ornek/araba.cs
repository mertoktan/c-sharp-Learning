using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Ornek
{
    class araba: arabadetay
    {
        public string renk;
        public int hız;
        public double motor;
        public char durum;
        public int fiyat;
        private int yıl;
        private string Marka;

        public int YIL
        {
            get { return yıl; }
            set { yıl = Math.Abs(value); }//negatif ise pzitife döndürdü

        }
        public string MARKASI
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }//her harfi büyükyazdırdı.

        }
    }
}
