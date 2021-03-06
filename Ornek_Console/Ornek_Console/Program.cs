using System;

namespace Ornek_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            kisiler ksl = new kisiler();
            //ksl.kisiliste("Mert");
            //Console.Read();
            string adsy;
            Console.WriteLine("İsim Giriniz...");
            adsy = Console.ReadLine();
            
            ksl.kisiliste(adsy);
            Console.Read();


        }
    }
}
