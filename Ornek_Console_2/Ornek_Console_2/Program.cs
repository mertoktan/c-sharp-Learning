using System;

namespace Ornek_Console_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("İki adet sayı giriniz...");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            islem isl = new islem();
           

            isl.topla(a,b);

            Console.WriteLine("\n\n\n\n");

            isl.kare(b);
            Console.Read();
        }
    }
}
