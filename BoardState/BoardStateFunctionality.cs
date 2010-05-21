using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using OthelloBoard.Extensions;

namespace OthelloBoard
{
    // Board States have postions defined in two ulongs, one ulong for white, one for black.
    public partial class BoardState : IEquatable<BoardState>
    {
        public BoardState(ulong black, ulong white)
        {
            BlackPieces = black;
            WhitePieces = white;          
        }   

        #region IEquatable<BoardState> Members

        public bool Equals(BoardState other)
        {
            return (other.BlackPieces == BlackPieces) && (other.WhitePieces == WhitePieces);
        }

        #endregion      
    }
}