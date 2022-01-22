using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal abstract class Player
    {
        public string Name { get; set; }
        public abstract RPS GenerateRPS();
    }
}
