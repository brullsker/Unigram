// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method initConnection
	/// </summary>
	public partial class TLInitConnection : TLObject
	{
		public Int32 ApiId { get; set; }
		public String DeviceModel { get; set; }
		public String SystemVersion { get; set; }
		public String AppVersion { get; set; }
		public String LangCode { get; set; }
		public TLObject Query { get; set; }

		public TLInitConnection() { }
		public TLInitConnection(TLBinaryReader from, TLType type = TLType.InitConnection)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InitConnection; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InitConnection)
		{
			ApiId = from.ReadInt32();
			DeviceModel = from.ReadString();
			SystemVersion = from.ReadString();
			AppVersion = from.ReadString();
			LangCode = from.ReadString();
			Query = TLFactory.Read<TLObject>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x69796DE9);
			to.Write(ApiId);
			to.Write(DeviceModel);
			to.Write(SystemVersion);
			to.Write(AppVersion);
			to.Write(LangCode);
			to.WriteObject(Query);
		}
	}
}