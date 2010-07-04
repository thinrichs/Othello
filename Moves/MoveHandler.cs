using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using Othello.Strategies;
using Othello.Board;

namespace Othello.Moves
{
    public class MoveHandler
    {
		public Board.Board Board { get; set; }	
		public Colors PlayerColor { get; set; }
		public IMoveSelector MoveSelector { get; set; }		
		
		public BitArray Moves
        {
			get
			{
			   	if (Board == null)
				{
					throw new ArgumentNullException("Can't find moves for player with no board");
				}
			
				MoveFinder mf = new MoveFinder(Board, PlayerColor);			
            	return mf.ValidMoves();
			}
        }
		
		public short? SelectedMove()
		{
			if (Board == null)
			{
				throw new ArgumentNullException("Can't find best move for player with no board");
			}
			// this is totally possible if the PlayerColor doesn't have any moves 
			if (Moves == null)
			{
				return null;
			}
			return MoveSelector.BestMoveForColor(Moves, PlayerColor, Board);	
		}
		
		public Board.Board ProcessSelectedMove()
		{
			short? move = SelectedMove();
			if (move != null)
			{
				MoveProcessor mp = new MoveProcessor(Board);
				return mp.ProcessMove(move.Value);
			}
			else  // if no permutation, then output is same as input				
			{
				return Board;
			}
		}
	}
}