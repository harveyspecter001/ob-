using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Atlas
{
	// Token: 0x02000BFD RID: 3069
	public enum CompassType
	{
		// Token: 0x040036F0 RID: 14064
		[OriginalName("SIMPLE")]
		Simple,
		// Token: 0x040036F1 RID: 14065
		[OriginalName("SPOUSE")]
		Spouse,
		// Token: 0x040036F2 RID: 14066
		[OriginalName("PARTY")]
		Party,
		// Token: 0x040036F3 RID: 14067
		[OriginalName("PVP_SEEK")]
		PvpSeek,
		// Token: 0x040036F4 RID: 14068
		[OriginalName("QUEST")]
		Quest
	}
}
