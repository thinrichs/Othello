
//------------------------------------------------------------------------------
// 
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//------------------------------------------------------------------------------

// Generated from: BoardState.proto
namespace Othello.Board
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BoardState")]
    public partial class BoardState : global::ProtoBuf.IExtensible
    {
      public BoardState() {}
      
    private uint _stateID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stateID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint StateID
    {
      get { return _stateID; }
      set { _stateID = value; }
    }
    private ulong _BlackPieces;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BlackPieces", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong BlackPieces
    {
      get { return _BlackPieces; }
      set { _BlackPieces = value; }
    }
    private ulong _WhitePieces;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"WhitePieces", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong WhitePieces
    {
      get { return _WhitePieces; }
      set { _WhitePieces = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
}
