using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("For ciklus");
            for (int i = 0;i< 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();


            for (int i = 0; i < 10 && i != 4; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i <10 ; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("While ciklus");

            int j = 0;
            while ( j< 10)
            {
                Console.WriteLine("i értéke: {0}", j);
                ++j;
            }

            j = 0;
            do
            {
                Console.WriteLine("i értéke {0}", j);
                ++j;
            } while (j < 10);

            Console.WriteLine("foreach ciklus");

            string str = "asdfdfjkhvmnyxfouztjas";
            foreach ( char ch in str)
            {
                Console.WriteLine(ch);
            }
            Console.ReadKey();
        }
    }
}
