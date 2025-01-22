using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009A2 RID: 2466
	public enum AllianceRelation
	{
		// Token: 0x04002981 RID: 10625
		[OriginalName("ALLIANCE_RELATION_NONE")]
		None,
		// Token: 0x04002982 RID: 10626
		[OriginalName("ALLIANCE_RELATION_MINE")]
		Mine,
		// Token: 0x04002983 RID: 10627
		[OriginalName("ALLIANCE_RELATION_DEF")]
		Def,
		// Token: 0x04002984 RID: 10628
		[OriginalName("ALLIANCE_RELATION_ATT")]
		Att,
		// Token: 0x04002985 RID: 10629
		[OriginalName("ALLIANCE_RELATION_NEUTRAL")]
		Neutral,
		// Token: 0x04002986 RID: 10630
		[OriginalName("ALLIANCE_RELATION_ALLY")]
		Ally,
		// Token: 0x04002987 RID: 10631
		[OriginalName("ALLIANCE_RELATION_ENEMY")]
		Enemy
	}
}
