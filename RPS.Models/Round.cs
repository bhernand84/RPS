using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS.Models
{
    public class Round
    {
        public Move PlayerOneMove
        { get; set; }

        public Move PlayerTwoMove
        { get; set; }

        public bool HasPlayerVoted(PlayerEnum player)
        {
           return player == PlayerEnum.PlayerOne ? PlayerOneMove != Move.None : PlayerTwoMove != Move.None;
        }

    }
}
