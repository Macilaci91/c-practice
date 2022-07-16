using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            Random random = new Random();
            int playerPoints = 0;
            int aiPoints = 0;


            while (game) {

                Console.WriteLine("What would you choose? (Rock,Paper,Scissors or end)");
                string playerChoice = Console.ReadLine();

                if (playerChoice == "end")
                {
                    game = false;
                }
                int number = random.Next(1, 4);
                string aiChoice = "";
                switch (number) {
                    case (1):
                        aiChoice = "Rock";
                        break;
                    case (2):
                        aiChoice = "Paper";
                        break;
                    case (3):
                        aiChoice = "Scissors";
                        break;
                }
                Console.WriteLine(aiChoice);
                if ((playerChoice == "Rock" && aiChoice == "Scissors") || (playerChoice == "Paper" && aiChoice == "Rock") || (playerChoice == "Scissors" && aiChoice == "Paper"))
                {
                    Console.WriteLine("{0} beat {1} ! Player Win!",playerChoice,aiChoice);
                    playerPoints++;
                } else if ((aiChoice == "Rock" && playerChoice == "Scissors") || (aiChoice == "Paper" && playerChoice == "Rock") || (aiChoice == "Scissors" && playerChoice == "Paper"))
                {
                    Console.WriteLine("{0} beat {1} ! AI Win!", aiChoice, playerChoice);
                    aiPoints++;
                } else if (playerChoice == aiChoice)
                {
                    Console.WriteLine("It's a Tied!");
                    
                }

                Console.WriteLine("Player has {0} point(s)", playerPoints);
                Console.WriteLine("AI has {0} point(s)", aiPoints);
            }
            Console.ReadKey();

        }
    }
}
