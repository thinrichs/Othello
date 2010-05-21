using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using System.IO;
using OthelloBoard;

namespace TestBoardStateStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();

            Console.WriteLine("~ Initial BoardState ~");
            Console.WriteLine(String.Format("White Pieces  = 0x{0,16:X00000000000000000}", board.State.WhitePieces));
            Console.WriteLine(String.Format("Black Pieces  = 0x{0,16:X00000000000000000}", board.State.BlackPieces));
            Console.WriteLine();
            Console.WriteLine(board);
            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine("Enter new board states by setting FirstHalf then SecondHalf of board");
            //string input = string.Empty;

            //while (input.ToLower() != "exit") 
            //{
            //    input = Console.ReadLine();
            //    boardState.FirstHalf = ulong.Parse(input);
            //    if (input.ToLower() != "exit")
            //    {
            //        input = Console.ReadLine();
            //        if (input.ToLower() != "exit")
            //        {
            //            boardState.SecondHalf = ulong.Parse(input);
            //            Console.WriteLine(boardState);
            //        }
            //    }
            //}
            
          
            //using (var file = File.OpenRead("board.bin"))
            //{
            //    boardState = Serializer.Deserialize<BoardState>(file);
            //}
            //Console.WriteLine(boardState);
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
