using System;
using NUnit.Framework;
using RPS.Models;

namespace Tests
{
    [TestFixture]
    public class MoveTests
    {

        [Test]
        public void RockBeatsScissors()
        {
            Assert.True(Move.Rock < Move.Paper);
        }
        [Test]
        public void PaperBeatsRock()
        {
            Assert.True(Move.Paper > Move.Rock);
        }
    }
}       
