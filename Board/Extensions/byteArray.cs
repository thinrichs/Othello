using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Othello.Board.Extensions
{
    public static class ByteArrayExtensions
    {    // please see http://stackoverflow.com/questions/627728/why-do-i-get-the-following-output-when-inverting-bits-in-a-byte
        public static byte[] ReverseBits(this byte[] data)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                int b = data[i];
                int r = 0;
                for (int j = 0; j < 8; j++)
                {
                    r <<= 1;
                    r |= b & 1;
                    b >>= 1;
                }
                result[i] = (byte)r;
            }
            return result;
        }
    }
}