using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.Models
{
    public static class MoveHelpers
    {
        public static bool GreaterThan(this Move move, Move otherMove)
        {
            if(move == 0 && ((int)otherMove == (Enum.GetNames(typeof(Move)).Length - 1))){
                return true;
            }
            return move > otherMove;
        }
    }
}
