using System;
using System.Collections.Generic;
using System.Linq;

using System.Collections; 

namespace OthelloBoard
{
    public class MoveHandler
    {
		public Board Board { get; set; }
		public Colors PlayerColor { get; set;}
		public IMoveSelector MoveSelector { get; set; }		
		
		public BitArray MovesForPlayer()
        {
			if (Board == null)
			{
				throw new ArgumentNullException("Can't find moves for player with no board");
			}
			
			MoveFinder mf = new MoveFinder(Board, PlayerColor);			
            return mf.ValidMoves();
        }  
	}
}