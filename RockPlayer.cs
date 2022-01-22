using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class RockPlayer : Player
    {
        public override RPS GenerateRPS()
        {
            TheThrow = RPS.rock;
            return RPS.rock;
        }
        private RPS _rock;
        public RPS TheThrow { get; set; }
    }
}
