using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005B5 RID: 1461
	public enum FightSpellCastCritical
	{
		// Token: 0x04001866 RID: 6246
		[OriginalName("NORMAL")]
		Normal,
		// Token: 0x04001867 RID: 6247
		[OriginalName("CRITICAL_HIT")]
		CriticalHit,
		// Token: 0x04001868 RID: 6248
		[OriginalName("CRITICAL_FAIL")]
		CriticalFail
	}
}
