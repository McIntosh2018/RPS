using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Continue
    {
        internal static bool UserContinue()
        {

        Console.WriteLine("Do you want to play again? (y/n)");
            
        var userResponse = Console.ReadLine();
                
        if (userResponse == "n")
        {
            return false;
        }
        else
            return true;
        }
    }   
}
