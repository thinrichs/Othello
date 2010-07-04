using System;
using OthelloBoard;
using System.Collections;
using System.Text;

namespace OthelloBoard
{
	public class MoveFinder
	{
		private string validBlackMove = "nwb";  // null white black
        private string validWhiteMove = "nbw";  // null black white
        
		private Board board;
		private Colors color;
		
		public MoveFinder (Board board, Colors playerColor)
		{
			this.board = board;
			this.color = playerColor;			
		}
		
		public BitArray ValidMoves()
        {
            BitArray result = new BitArray(board.SquareCount, true);// check each direction for each position to be inverse of color, then blank - without going over the edges of the board, or wrapping
			for (int i =0; i< board.SquareCount; i++)
			{
				result[i] = MoveValidFromAnyDirection(i);			
			}
            return result;
        }

		bool MoveValidFromDirection(int boardPosition, int direction)
		{
			int testPosition = boardPosition;
			StringBuilder rowRepresentation = new StringBuilder();
			char lastSquare = '\0';
			char thisSquare = '\0';
			
			// only three characters are interesting
			// initial (must be n, null)
			// character representing series of same colored pieces
			// character representing other colored piece
		    while (((testPosition >= 0) && (testPosition < board.SquareCount)) &&
			       (rowRepresentation.ToString().Length < 3))
			{
				thisSquare = board.SquareAsChar(testPosition);
				if ((lastSquare != thisSquare) || (thisSquare == 'n'))
				{ 
					rowRepresentation.Append(thisSquare);
				}
				testPosition += direction;
				lastSquare = thisSquare;
			}
			return RowIsValid(rowRepresentation.ToString());
		}

		public bool RowIsValid (string rowRepresentation)
		{
			return (color.Equals(Colors.White)) ?			
			       rowRepresentation == validWhiteMove :
				   rowRepresentation == validBlackMove;
		}

		bool MoveValidFromAnyDirection (int boardPosition)
		{
			return  MoveValidFromDirection(boardPosition, BoardDirections.East)      ||
				    MoveValidFromDirection(boardPosition, BoardDirections.North)     ||
					MoveValidFromDirection(boardPosition, BoardDirections.NorthEast) ||
					MoveValidFromDirection(boardPosition, BoardDirections.NorthWest) ||
					MoveValidFromDirection(boardPosition, BoardDirections.South)     ||
					MoveValidFromDirection(boardPosition, BoardDirections.SouthEast) ||
					MoveValidFromDirection(boardPosition, BoardDirections.SouthWest) ||
					MoveValidFromDirection(boardPosition, BoardDirections.West);					
		}
	}
}