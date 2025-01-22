using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009AE RID: 2478
	public enum TeamType
	{
		// Token: 0x040029FD RID: 10749
		[OriginalName("TEAM_TYPE_PLAYER")]
		Player,
		// Token: 0x040029FE RID: 10750
		[OriginalName("TEAM_TYPE_MONSTER")]
		Monster,
		// Token: 0x040029FF RID: 10751
		[OriginalName("TEAM_TYPE_MUTANT")]
		Mutant,
		// Token: 0x04002A00 RID: 10752
		[OriginalName("TEAM_TYPE_TAX_COLLECTOR")]
		TaxCollector,
		// Token: 0x04002A01 RID: 10753
		[OriginalName("TEAM_TYPE_BAD_PLAYER")]
		BadPlayer,
		// Token: 0x04002A02 RID: 10754
		[OriginalName("TEAM_TYPE_PRISM")]
		Prism
	}
}
