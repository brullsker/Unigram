// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.search
	/// </summary>
	public partial class TLMessagesSearch : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			None = 0
		}

		public Flag Flags { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public String Q { get; set; }
		public TLMessagesFilterBase Filter { get; set; }
		public Int32 MinDate { get; set; }
		public Int32 MaxDate { get; set; }
		public Int32 Offset { get; set; }
		public Int32 MaxId { get; set; }
		public Int32 Limit { get; set; }

		public TLMessagesSearch() { }
		public TLMessagesSearch(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesSearch; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from, cache);
			Q = from.ReadString();
			Filter = TLFactory.Read<TLMessagesFilterBase>(from, cache);
			MinDate = from.ReadInt32();
			MaxDate = from.ReadInt32();
			Offset = from.ReadInt32();
			MaxId = from.ReadInt32();
			Limit = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xD4569248);
			to.Write((Int32)Flags);
			to.WriteObject(Peer, cache);
			to.Write(Q);
			to.WriteObject(Filter, cache);
			to.Write(MinDate);
			to.Write(MaxDate);
			to.Write(Offset);
			to.Write(MaxId);
			to.Write(Limit);
			if (cache) WriteToCache(to);
		}
	}
}