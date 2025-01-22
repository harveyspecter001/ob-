using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x0200007E RID: 126
	public enum Teleporter
	{
		// Token: 0x040001F2 RID: 498
		[OriginalName("TELEPORTER_ZAAP")]
		Zaap,
		// Token: 0x040001F3 RID: 499
		[OriginalName("TELEPORTER_SUBWAY")]
		Subway,
		// Token: 0x040001F4 RID: 500
		[OriginalName("TELEPORTER_PRISM")]
		Prism,
		// Token: 0x040001F5 RID: 501
		[OriginalName("TELEPORTER_HAVEN_BAG")]
		HavenBag,
		// Token: 0x040001F6 RID: 502
		[OriginalName("TELEPORTER_ANOMALY")]
		Anomaly
	}
}
