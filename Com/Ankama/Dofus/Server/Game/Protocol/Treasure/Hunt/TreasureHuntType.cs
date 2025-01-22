using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000035 RID: 53
	public enum TreasureHuntType
	{
		// Token: 0x040000CD RID: 205
		[OriginalName("CLASSIC")]
		Classic,
		// Token: 0x040000CE RID: 206
		[OriginalName("PORTAL")]
		Portal,
		// Token: 0x040000CF RID: 207
		[OriginalName("LEGENDARY")]
		Legendary
	}
}
