using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class OpponentValidator
    {
        
        UserInput userInput = new UserInput();

       internal bool Opponent(string opponent, out Player enemy)
        {
        // string opponent = userInput.UserInputChoice(userOpponent);
            switch (opponent)
            {
                case "rockplayer":
                    {
                        enemy = new RockPlayer();
                        return true;
                    }
                case "randomplayer":
                    {
                        enemy = new RandomPlayer();
                        return true;
                    }
                default:
                    enemy = null;
                    return false;
            }
        }        
    }
}
