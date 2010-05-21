using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OthelloBoard
{
    public class MoveHandler
    {
        public BitArray MovesFor(Colors color)
        {
            return (color == Colors.White) ? MovesForWhite() : MovesForBlack();
        }
        private ulong MovesForPosition(ulong position, Colors color)
        {
            return 0;
        }
        private BitArray MovesForWhite()
        {
            BitArray result = new BitArray(64, true);// check each direction for each position to be inverse of color, then blank - without going over the edges of the board, or wrapping
            return result;
        }

        private BitArray MovesForBlack()
        {
            BitArray result = new BitArray(64, true);// check each direction for each position to be inverse of color, then blank - without going over the edges of the board, or wrapping
            return result;
        }
    }
}
