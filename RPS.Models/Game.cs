using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.Models
{
    public class Game
    {
        public Player PlayerOne
        { get; private set; }
        public Player PlayerTwo
        { get; private set; }
        public List<Round> Rounds
        { get; set; }

        public Round CurrentRound
        { get { return Rounds.Last(); } }

        public int Player1Score
        { get; set; }
        public int Player2Score
        { get; set; }

        public Player Join(Player player)
        {
            if (HasSpace())
            {
                if (PlayerOne == null)
                {
                    PlayerOne = player;
                    StartRound();
                    return PlayerOne;
                }
                if (PlayerTwo == null)
                {
                    PlayerOne = player;
                    StartRound();
                    return PlayerTwo;
                }

            }
            throw new InvalidOperationException("Game Full");

        }

        public bool HasSpace()
        {
            return PlayerOne == null || PlayerTwo == null;
        }

        public void SendMove(Player playerOne, Move move)
        {

        }
        public void StartRound()
        {
             Rounds.Add(new Round());
        }

        public Game() {
            Rounds = new List<Round>();
        }
    }
}
