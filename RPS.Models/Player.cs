using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPS.Models
{
    public class Player
    {
        public string Name
        { get; set; }

        public Move ActiveMove
        { get; set; }

        #region Constructors

        public Player(){}
        
        public Player(string name)
        {
            Name = name;

        }
        #endregion
    }
}
