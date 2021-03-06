// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLNewSessionCreated : TLNewSessionBase 
	{
		public Int64 FirstMsgId { get; set; }
		public Int64 UniqueId { get; set; }
		public Int64 ServerSalt { get; set; }

		public TLNewSessionCreated() { }
		public TLNewSessionCreated(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.NewSessionCreated; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			FirstMsgId = from.ReadInt64();
			UniqueId = from.ReadInt64();
			ServerSalt = from.ReadInt64();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x9EC20908);
			to.Write(FirstMsgId);
			to.Write(UniqueId);
			to.Write(ServerSalt);
			if (cache) WriteToCache(to);
		}
	}
}