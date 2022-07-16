using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Random random = new Random();

            string fromUser = Console.ReadLine();

            if (fromUser != "")
            {
                number = Convert.ToInt32(fromUser);
            } else
            {
                number = random.Next(100);
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",number,i,number * i);
            }
            Console.ReadKey();
        }
    }
}
