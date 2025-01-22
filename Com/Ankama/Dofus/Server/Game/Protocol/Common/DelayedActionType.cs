using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009A1 RID: 2465
	public enum DelayedActionType
	{
		// Token: 0x0400297C RID: 10620
		[OriginalName("DISCONNECT")]
		Disconnect,
		// Token: 0x0400297D RID: 10621
		[OriginalName("OBJECT_USE")]
		ObjectUse,
		// Token: 0x0400297E RID: 10622
		[OriginalName("JOIN_CHARACTER")]
		JoinCharacter,
		// Token: 0x0400297F RID: 10623
		[OriginalName("AGGRESSION_IMMUNE")]
		AggressionImmune
	}
}
