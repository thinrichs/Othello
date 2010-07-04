using OthelloBoard;
using NUnit.Framework;
using System.Collections;
using OthelloBoard.Extensions;
using System;

namespace BoardTests
{ 
    /// <summary>
    ///This is a test class for BoardStateTest and is intended
    ///to contain all BoardStateTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BoardStateTest
    {
        [Test]
        public void SimpleBoardAsString()
        {
            Board b = new Board();
            Console.WriteLine(b.ToString());
            Assert.IsNotNull(b.ToString());
        }
        [Test]
        public void SimpleWhiteBoardAsBitArray()
        {
            BitArray b = new BitArray(64, false)
                .SetFrom(Board.InitialState.WhitePieces);
            Console.Write(b.ToBoardString());
            Assert.IsNotNull(b);
        }
    }
}
