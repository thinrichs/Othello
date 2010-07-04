using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Othello.Board.Extensions;

namespace Othello.Board
{
    public class Board: List<bool?> // null == empty, true == white , false == black
    {
        public static BoardState InitialState { get { return _startingState; } }
        public BoardState State { get; set; }
		public readonly int SquareCount = 64;

        // initial Othello / Reversi board setup.  Please see http://en.wikipedia.org/wiki/Reversi
        private static readonly BoardState _startingState = new BoardState
        {
            StateID = 0,
            BlackPieces = 0x0000000810000000,
            WhitePieces = 0x0000001008000000
        };
        public Board()
            : this(InitialState) { }

        public Board(BoardState state)
        {
            State = state;
            InitializeBoard();
			SetBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < SquareCount; i++)
            {
                this.Add((bool?)null);
            }
        }
       
        private void SetBoard()
        {
            byte[] black = BitConverter.GetBytes(State.BlackPieces).ReverseBits();
            byte[] white = BitConverter.GetBytes(State.WhitePieces).ReverseBits();
            byte w;
            byte b;
            int squarePosition = 0;
            for (int i = white.Length - 1; i >= 0; i--)
            {
                w = white[i];
                b = black[i];
                
               
                for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                {
                     squarePosition = ((((white.Length - i) - 1) * 8) + bitPosition);
                    if ((w % 2) == 1)
                    {
                        this[squarePosition] = true;
                    }
                    else if ((b % 2) == 1)
                    {
                        this[squarePosition] = false;
                    }
                    else
                    {
                        this[squarePosition] = null;
                    }
                    w >>= 1;
                    b >>= 1;
                }
            }                     
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            for(int squarePosition = 0; squarePosition < SquareCount; squarePosition++)
            {
                sb.Append(this.SquareAsChar(squarePosition).ToString().ToUpper());
                sb.Append("\t");                
                if (squarePosition % 8 == 0)
                {
                    sb.Append(Environment.NewLine);
                }
            }
            return sb.ToString();
        }
		
		public char SquareAsChar(int square)
		{
			char result = 'n';
			if (this[square] != null)
			{
				result = (this[square].Value) ? 'w' : 'b';				
			}
			return result;
		}
    }
}