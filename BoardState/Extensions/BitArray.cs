using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OthelloBoard.Extensions
{
    public static class BitArrayExtensions
    {
        public static bool ValuesEqual(this BitArray extended, BitArray value)
        {

            if (extended == value)
            {
                return true;
            }
            else if ((extended == null) || (value == null))
            {
                return false;
            }
            else
            {
                bool result = (extended.Length == value.Length);
                int bitIndex = 0;
                while (result && (bitIndex < extended.Length))
                {
                    result &= (extended[bitIndex] == value[bitIndex]);
                    bitIndex++;
                }
                return result;
            }
        }

        public static BitArray SetFrom(this BitArray extended, ulong value)
        {
            ulong mask;
            for (int bitPosition = 63; bitPosition >= 0; bitPosition--)
            {
                mask = (ulong)Math.Pow(2, bitPosition);
                extended[bitPosition] = ((value & mask) == mask);
            }
            return extended;
        }
        public static string ToBoardString(this BitArray extended)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 63; i >= 0; i--)
            {
                sb.Append(extended[i] + "\t");
                if ((i % 8) == 0)
                {
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }
    }
}
