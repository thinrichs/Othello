using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProtoBuf;

namespace Othello.Board
{
    public class BoardStateSet : List<BoardState>
    {
        public MemoryStream AsStream()
        {
            MemoryStream result = new MemoryStream();
            ForEach(x => { Serializer.Serialize(result, x); });
            return result;
        }

        public BoardState Find(uint stateID)
        {
            return this.Where(x => (x.StateID == stateID))
                .FirstOrDefault();
        }
    }
}