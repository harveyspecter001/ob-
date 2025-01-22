using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009AD RID: 2477
	public enum FightType
	{
		// Token: 0x040029F1 RID: 10737
		[OriginalName("FIGHT_TYPE_CHALLENGE")]
		Challenge,
		// Token: 0x040029F2 RID: 10738
		[OriginalName("FIGHT_TYPE_AGGRESSION")]
		Aggression,
		// Token: 0x040029F3 RID: 10739
		[OriginalName("FIGHT_TYPE_PvMA")]
		PvMa,
		// Token: 0x040029F4 RID: 10740
		[OriginalName("FIGHT_TYPE_MXvM")]
		MxvM,
		// Token: 0x040029F5 RID: 10741
		[OriginalName("FIGHT_TYPE_PvM")]
		PvM,
		// Token: 0x040029F6 RID: 10742
		[OriginalName("FIGHT_TYPE_PvT")]
		PvT,
		// Token: 0x040029F7 RID: 10743
		[OriginalName("FIGHT_TYPE_PvMU")]
		PvMu,
		// Token: 0x040029F8 RID: 10744
		[OriginalName("FIGHT_TYPE_PVP_ARENA")]
		PvpArena,
		// Token: 0x040029F9 RID: 10745
		[OriginalName("FIGHT_TYPE_KOH")]
		Koh,
		// Token: 0x040029FA RID: 10746
		[OriginalName("FIGHT_TYPE_PvPr")]
		PvPr,
		// Token: 0x040029FB RID: 10747
		[OriginalName("FIGHT_TYPE_BREACH")]
		Breach
	}
}
