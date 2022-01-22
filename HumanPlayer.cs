using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class HumanPlayer : Player
    {
        UserInput input = new UserInput();
        public HumanPlayer(string name)
        {
            Name = name;
        }
        public override RPS GenerateRPS()
        {
            RPSValidator inputValidator = new RPSValidator();
            while (true)
            {
                //Console.WriteLine("Select rock, paper, or scissors.");
                if (inputValidator.GetInputValidation(input.UserInputChoice("Select rock, paper, or scissors"), out RPS rps))
                {
                    return rps;
                }
                Console.WriteLine("Come on man, select one of only three options.");
            }
        }
    }
}
