using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OthelloBoard
{
    // bit position offsets
    class BoardDirections
    {
        public static readonly int West = 1;
        public static readonly int East = -1;
        public static readonly int North = 8;
        public static readonly int South = -8;

        public static readonly int NorthWest = 9;        
        public static readonly int NorthEast = 7;
        public static readonly int SouthWest = -7;
        public static readonly int SouthEast = -9;

    }
}
