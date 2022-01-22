using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class EnemySelector
    {
        OpponentValidator opponent = new OpponentValidator();
        UserInput userInput = new UserInput();
        internal Player SelectEnemy()
        {
            while (true)
            {
                if (opponent.Opponent(userInput.UserInputChoice("Choose your enemy. RandomPlayer, or RockPlayer?"), out var badGuy))
                {
                    badGuy.GenerateRPS();
                    return badGuy;
                }
                Console.WriteLine("Dude, stop picking stupid stuff. Do you want the super easy RockPlayer, or the hard RandomPlayer?");
            }
        }
    }
}
