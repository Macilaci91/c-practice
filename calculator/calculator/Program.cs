using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Give me two number and an operator");

            Console.WriteLine("Please type your first number");
            string first = Console.ReadLine();

            Console.WriteLine("Please type your second number");
            string second = Console.ReadLine();

            Console.WriteLine("What would you want to do? (+,-,*,/");
            string op = Console.ReadLine();

            switch (op) {
                case "+":
                    result = Convert.ToInt32(first) + Convert.ToInt32(second);
                    break;
                case "-":
                    result = Convert.ToInt32(first) - Convert.ToInt32(second);
                    break;
                case "*":
                    result = Convert.ToInt32(first) * Convert.ToInt32(second);
                    break;
                case "/":
                    result = Convert.ToInt32(first) / Convert.ToInt32(second);
                    break;

            }
               


            Console.WriteLine("{0} {1} {2} = {3}",first,op,second,result);
            Console.ReadKey();

        }
    }
}
