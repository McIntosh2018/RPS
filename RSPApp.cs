using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class RSPApp
    {
        public static void Run()
        {
            EnemySelector badGuy = new EnemySelector();
            int userWins = 0;
            int pcWins = 0;

            Console.WriteLine("Welcome to the Rock, Paper, Scissors game!");
            Console.WriteLine("Please enter your name");
            HumanPlayer userPlayer = new HumanPlayer(Console.ReadLine());

            Console.WriteLine("");

            while (true)
            {
            Console.WriteLine($"Welcome, {userPlayer.Name}. Select your throw:");

            var throwing = userPlayer.GenerateRPS(); //get user throw
            var badGuyThrow = badGuy.SelectEnemy().GenerateRPS(); //returns enemy's throw

                if (throwing == RPS.rock && badGuyThrow == RPS.rock)
                {
                    Console.WriteLine("You tied! You both threw rock.");
                    //Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.rock && badGuyThrow == RPS.paper)
                {
                    Console.WriteLine("The computer beat you! Paper covers rock.");
                    pcWins++;
                   // Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.rock && badGuyThrow == RPS.scissors)
                {
                    Console.WriteLine("You won! Rock crushes scissors.");
                    userWins++;
                   // Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.paper && badGuyThrow == RPS.rock)
                {
                    Console.WriteLine("You won! Paper covers rock.");
                    userWins++;
                   // Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.paper && badGuyThrow == RPS.scissors)
                {
                    Console.WriteLine("The computer beat you! Scissors cuts paper.");
                    pcWins++;
                   // Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.paper && badGuyThrow == RPS.paper)
                {
                    Console.WriteLine("You tied. You both threw paper.");
                  //  Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.scissors && badGuyThrow == RPS.scissors)
                {
                    Console.WriteLine("You tied. You both threw scissors");
                   // Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.scissors && badGuyThrow == RPS.rock)
                {
                    Console.WriteLine("The computer beat you. Rock crushes scissors");
                    pcWins++;
                  //  Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                }
                else if (throwing == RPS.scissors && badGuyThrow == RPS.paper)
                {
                    Console.WriteLine("You won!Scissors cuts paper.");
                    userWins++;                   
                }
                Console.WriteLine($"The score is {userPlayer.Name} {userWins} - computer {pcWins}");
                Console.WriteLine("");

                bool stillPlaying = Continue.UserContinue();
            }
            Console.WriteLine($"Thank you for playing. The final score was you {userWins} and the computer {pcWins}");
        }
    }
}

