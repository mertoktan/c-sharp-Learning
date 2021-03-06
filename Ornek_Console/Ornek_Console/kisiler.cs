using System;
using System.Collections.Generic;
using System.Text;

namespace Ornek_Console
{
    class kisiler
    {
        public void kisiliste(string ad)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+".Kişi " + ad);
            }
           
        }
    }
}
