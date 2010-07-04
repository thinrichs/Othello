using System;
using System.Collections;
using Othello.Board;

namespace Othello.Strategies
{
	public interface IMoveSelector
	{
		short BestMoveForColor(BitArray possibleMoves, Colors color, Board.Board board);
	}
}