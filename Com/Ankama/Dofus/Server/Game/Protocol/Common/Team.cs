using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009B2 RID: 2482
	public enum Team
	{
		// Token: 0x04002A13 RID: 10771
		[OriginalName("TEAM_CHALLENGER")]
		Challenger,
		// Token: 0x04002A14 RID: 10772
		[OriginalName("TEAM_DEFENDER")]
		Defender,
		// Token: 0x04002A15 RID: 10773
		[OriginalName("TEAM_SPECTATOR")]
		Spectator,
		// Token: 0x04002A16 RID: 10774
		[OriginalName("TEAM_NEUTRAL")]
		Neutral
	}
}
