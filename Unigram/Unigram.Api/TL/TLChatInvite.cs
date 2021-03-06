// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChatInvite : TLChatInviteBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Channel = (1 << 0),
			Broadcast = (1 << 1),
			Public = (1 << 2),
			Megagroup = (1 << 3),
			Participants = (1 << 4),
		}

		public bool IsChannel { get { return Flags.HasFlag(Flag.Channel); } set { Flags = value ? (Flags | Flag.Channel) : (Flags & ~Flag.Channel); } }
		public bool IsBroadcast { get { return Flags.HasFlag(Flag.Broadcast); } set { Flags = value ? (Flags | Flag.Broadcast) : (Flags & ~Flag.Broadcast); } }
		public bool IsPublic { get { return Flags.HasFlag(Flag.Public); } set { Flags = value ? (Flags | Flag.Public) : (Flags & ~Flag.Public); } }
		public bool IsMegagroup { get { return Flags.HasFlag(Flag.Megagroup); } set { Flags = value ? (Flags | Flag.Megagroup) : (Flags & ~Flag.Megagroup); } }
		public bool HasParticipants { get { return Flags.HasFlag(Flag.Participants); } set { Flags = value ? (Flags | Flag.Participants) : (Flags & ~Flag.Participants); } }

		public Flag Flags { get; set; }
		public String Title { get; set; }
		public TLChatPhotoBase Photo { get; set; }
		public Int32 ParticipantsCount { get; set; }
		public TLVector<TLUserBase> Participants { get; set; }

		public TLChatInvite() { }
		public TLChatInvite(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ChatInvite; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			Title = from.ReadString();
			Photo = TLFactory.Read<TLChatPhotoBase>(from, cache);
			ParticipantsCount = from.ReadInt32();
			if (HasParticipants) Participants = TLFactory.Read<TLVector<TLUserBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			UpdateFlags();

			to.Write(0xDB74F558);
			to.Write((Int32)Flags);
			to.Write(Title);
			to.WriteObject(Photo, cache);
			to.Write(ParticipantsCount);
			if (HasParticipants) to.WriteObject(Participants, cache);
			if (cache) WriteToCache(to);
		}

		private void UpdateFlags()
		{
			HasParticipants = Participants != null;
		}
	}
}