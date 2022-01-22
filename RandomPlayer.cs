using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class RandomPlayer : Player
    {
        public override RPS GenerateRPS()
        {
           RPS randomThrow = (RPS)new Random().Next(3);
            TheThrow = randomThrow;
           return randomThrow;
        }
        private RPS _rbs;
        public RPS TheThrow { get; set; }
    }
}
