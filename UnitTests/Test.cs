using OthelloBoard;
using NUnit.Framework;
using System.Collections;
using OthelloBoard.Extensions;
using System;
using System.Linq;
using System.Text;


namespace BoardTests
{ 
    /// <summary>
    ///This is a test class for BoardStateTest and is intended
    ///to contain all BoardStateTest Unit Tests
    ///</summary>
    [TestFixture]
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
		
		[Test]
		public void nbwCountsAsValidWhiteMove()
		{
			MoveFinder mf = new MoveFinder(new Board(Board.InitialState), Colors.White);			
			Assert.IsTrue(mf.RowIsValid("nbw"));
		}
		
		[Test]
		public void nwbCountsAsValidBlackMove()
		{
			MoveFinder mf =  new MoveFinder(new Board(Board.InitialState), Colors.Black);		
			Assert.IsTrue(mf.RowIsValid("nwb"));				
		}
		[Test]
		public void square19ValidBlackMoveFromInitialBoard()
		{
			MoveHandler mh = new MoveHandler();
			mh.Board = new Board(Board.InitialState);
			mh.PlayerColor = Colors.Black;
			Assert.IsTrue(mh.MovesForPlayer()[19]);
		}
		[Test]
		public void squares19_26_37_44ValidBlackMoveFromInitialBoard()
		{
			MoveHandler mh = new MoveHandler();
			mh.Board = new Board(Board.InitialState);
			mh.PlayerColor = Colors.Black;
			Assert.IsTrue(mh.MovesForPlayer()[19]);
			Assert.IsTrue(mh.MovesForPlayer()[26]);
			Assert.IsTrue(mh.MovesForPlayer()[37]);
			Assert.IsTrue(mh.MovesForPlayer()[44]);
		}
		[Test]
		public void squares20_29_34_43ValidWhiteMoveFromInitialBoard()
		{
			MoveHandler mh = new MoveHandler();
			mh.Board = new Board(Board.InitialState);
			mh.PlayerColor = Colors.White;
			Assert.IsTrue(mh.MovesForPlayer()[20]);
			Assert.IsTrue(mh.MovesForPlayer()[29]);
			Assert.IsTrue(mh.MovesForPlayer()[34]);
			Assert.IsTrue(mh.MovesForPlayer()[43]);
		}
    }
}