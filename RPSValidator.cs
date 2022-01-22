using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class RPSValidator
    {
        UserInput userInput = new UserInput();
        internal bool GetInputValidation(string userInput, out RPS userRPS)
        {
            while (true)
            {
                switch (userInput)
                {
                    case "rock":
                        {
                            userRPS = RPS.rock;
                          return true;
                        }
                    case "paper":
                        {
                            userRPS = RPS.paper;
                          return true;
                        }
                    case "scissors":
                        {
                            userRPS = RPS.scissors;
                          return true;
                        }
                    default:
                        userRPS = RPS.rock;
                          return false;
                }
            }
        }
    }
}
