using System;

namespace Yapıcı_Method_2
{
    class Program
    {
        static void Main(string[] args)
        {
            kimlik kml = new kimlik();
            string a = Console.ReadLine();
            kml.AD = a;
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.MEM);
            Console.WriteLine(kml.CİNS);
            
        }
    }
}
