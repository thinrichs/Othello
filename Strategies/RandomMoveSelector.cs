using System.Collections;
using System.Collections.Generic;
using Othello.Board;
using System;

namespace Othello.Strategies
{
	public class RandomMoveSelector : IMoveSelector
	{
		#region IMoveSelector implementation
		public short BestMoveForColor (System.Collections.BitArray possibleMoves, Colors color, Board.Board board)
		{
			List<int> boardMoveLocations = new List<int>();
			
			for (int i=0; i<possibleMoves.Count; i++)
			{
				if (possibleMoves[i]) { boardMoveLocations.Add(i); }				
			}
			Random r = new Random();
			int randomIndex = r.Next() % (boardMoveLocations.Count - 1);
			return (short)boardMoveLocations[randomIndex];			
		}
		#endregion
    }
}