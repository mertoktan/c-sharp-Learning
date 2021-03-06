using System;
using System.Collections.Generic;
using System.Text;

namespace Ornek_Console_2
{
    class islem
    {

        public int topla(int s1,int s2)

        {
            int s3 = s1 + s2;
            Console.Write("Sonuç : "+ s3);
            return s3;
        }
        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine(sonuc);
            return sonuc;
        }
    }
}
