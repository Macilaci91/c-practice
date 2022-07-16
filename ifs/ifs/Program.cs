using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace helloWorld
{
    class Program
    {
        enum Animal {TIGER,WOLF,CAT,DOG };
        static void Main(string[] args)
        {
            int x = 13;

            if (x == 10)
            {
                Console.WriteLine("x értéke 10");
            } else if (x == 12)
            {
                Console.WriteLine("x értéke 12");
            } else
            {
                Console.WriteLine("x értéke nem 10 vagy 10");
            }

            Console.WriteLine("Switch:");
            x = 11;

            switch (x)
            {
                case 10:
                    Console.WriteLine("x értéke 10");
                    break;
                case 11:
                    Console.WriteLine("x értéke 11");
                    break;
            }
            Console.WriteLine("Switch defaulttal");

            Animal animal = Animal.DOG;

            switch(animal)
            {
                case Animal.TIGER:
                    goto default;
                case Animal.DOG:
                    goto default;
                default:
                    Console.WriteLine("Ez egy állat");
                    break;
            }
            Console.ReadKey();

        }
    }
}


