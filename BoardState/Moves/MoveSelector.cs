using System;
using System.Collections;

namespace OthelloBoard
{
	public interface IMoveSelector
	{
		short BestMovePosition(Colors color, BitArray possibleMoves);
	}
}
