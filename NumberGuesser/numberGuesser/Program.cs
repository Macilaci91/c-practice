using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            Random random = new Random();
            while (game)
            {
                Console.WriteLine("Do you want to guess or computer guess? (Me/Comp or end)");
                string whoIsPlay = Console.ReadLine();
                int tryguess = 1;

                if (whoIsPlay == "Me")
                {
                    int randNum = random.Next(1, 101);

                    while(tryguess < 6)
                    {
                        string playerNum = Console.ReadLine();
                        if (randNum > Convert.ToInt32(playerNum))
                        {
                            Console.WriteLine("The number is bigger!");
                            Console.WriteLine("You have {0} try left!",5-tryguess);
                            tryguess++;
                        } else if (randNum < Convert.ToInt32(playerNum))
                        {
                            Console.WriteLine("The number is smaller!");
                            Console.WriteLine("You have {0} try left!", 5 - tryguess);
                            tryguess++;
                        } else
                        {
                            Console.WriteLine("Congratulations! You guessed the number!");
                            break;
                        }
                    }
                    if (tryguess == 6)
                    {
                        Console.WriteLine("You lose!");
                        Console.WriteLine("The number was {0}", randNum);
                    }

                } else if (whoIsPlay == "Comp")
                {
                    string guessNum = Console.ReadLine();
                    int startPoint = 50;
                    int result = 50;
                    while (tryguess < 6)
                    {
                        if (Convert.ToInt32(guessNum) > startPoint)
                        {
                            Console.WriteLine(startPoint);
                            startPoint += result / 2;
                            Console.WriteLine("The number is bigger");
                            tryguess++;
                            result = result / 2;
                        } else if (Convert.ToInt32(guessNum) < startPoint)
                        {
                            Console.WriteLine(startPoint);
                            startPoint -= result / 2;
                            Console.WriteLine("The number is smaller");
                            tryguess++;
                            result = result / 2;
                        } else
                        {
                            Console.WriteLine(startPoint);
                            Console.WriteLine("Congratulations! Comp Win!");
                            break;
                        }
                    }
                    if (tryguess == 6)
                    {
                        Console.WriteLine("You lose!");
                        Console.WriteLine("The number was {0}", guessNum);
                    }
                } else if (whoIsPlay == "end")
                {
                    game = false;
                }
                
            }
            Console.ReadKey();
            
        }
    }
}
