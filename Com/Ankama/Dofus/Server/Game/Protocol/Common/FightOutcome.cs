using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009B0 RID: 2480
	public enum FightOutcome
	{
		// Token: 0x04002A09 RID: 10761
		[OriginalName("RESULT_LOST")]
		ResultLost,
		// Token: 0x04002A0A RID: 10762
		[OriginalName("RESULT_DRAW")]
		ResultDraw,
		// Token: 0x04002A0B RID: 10763
		[OriginalName("RESULT_VICTORY")]
		ResultVictory,
		// Token: 0x04002A0C RID: 10764
		[OriginalName("RESULT_TAX")]
		ResultTax,
		// Token: 0x04002A0D RID: 10765
		[OriginalName("RESULT_DEFENDER_GROUP")]
		ResultDefenderGroup
	}
}
