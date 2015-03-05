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
            Assert.True(Move.Rock.GreaterThan(Move.Scissors).Value);
        }
        [Test]
        public void PaperBeatsRock()
        {
            Assert.True(Move.Paper.GreaterThan(Move.Rock).Value);
        }
        [Test]
        public void ScissorsBeatsPaper()
        {
            Assert.True(Move.Scissors.GreaterThan(Move.Paper).Value);
        }
        [Test]
        public void RockDoesNotBeatRock()
        {
            Assert.False(Move.Rock.GreaterThan(Move.Rock).Value);
        }
    }
}       
