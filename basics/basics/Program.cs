using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 6;
            int z = x + y;
            Console.WriteLine(z);
             z = x - y;
            Console.WriteLine(z);
            z = x * y;
            Console.WriteLine(z);
            z = x / y;
            Console.WriteLine(z);
            z = x % y;
            Console.WriteLine(z);

            bool l = false;
            bool k = true;

            if(l == true && k == true)
            {
                Console.WriteLine("Igaz");
            }

            if(l == true || k== true)
            {
                Console.WriteLine("Igaz");
            }

            if(x != 11)
            {
                Console.WriteLine("x nem egyenlő 11-gyel");
            }

            x = 10;
            y = 10;
            Console.WriteLine((x == y)? "Egyenlő":"Nem egyenlő");
            Console.ReadKey();
        }
    }
}
