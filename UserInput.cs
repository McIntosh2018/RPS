using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class UserInput
    {
        public string UserInputChoice(string message)
        {
            Console.WriteLine(message);
            string whatUserTyped = Console.ReadLine().ToLower();
            return whatUserTyped;
        }
    }
}
