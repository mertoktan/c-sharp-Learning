using System;
using System.Collections.Generic;
using System.Text;

namespace Yapıcı_Method_2
{
    class kimlik
    {
        string ad;
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }

        }
        public string MEM
        {
            get { return memleket; }
            set { memleket = value.ToLower(); }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
            
        }
        public char CİNS
        {
            get { return cinsiyet; }
            set { cinsiyet = value;}
        }
        public kimlik()
        {
            ad = "";
            soyad = "";
            yas=18 ;
            memleket = "";
            cinsiyet = 'K';
        }
    }
}
