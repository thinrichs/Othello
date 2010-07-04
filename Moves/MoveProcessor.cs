using System;
using Othello.Board;

namespace Othello.Moves
{
	public class MoveProcessor
	{
		private Board.Board board;
		public MoveProcessor (Board.Board initialBoard)
		{
			board = initialBoard;
		}
		
		public Board.Board ProcessMove(short moveHere)
		{
			Board.Board result = board;
			
			return result;
		}
		
	}
}

