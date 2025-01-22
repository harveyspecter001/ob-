using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009A9 RID: 2473
	public enum AttackableStatus
	{
		// Token: 0x040029A5 RID: 10661
		[OriginalName("NON_ATTACKABLE")]
		NonAttackable,
		// Token: 0x040029A6 RID: 10662
		[OriginalName("PVP_ENABLED_ATTACKABLE")]
		PvpEnabledAttackable,
		// Token: 0x040029A7 RID: 10663
		[OriginalName("PVP_ENABLED_NON_ATTACKABLE")]
		PvpEnabledNonAttackable,
		// Token: 0x040029A8 RID: 10664
		[OriginalName("AVA_ENABLED_ATTACKABLE")]
		AvaEnabledAttackable,
		// Token: 0x040029A9 RID: 10665
		[OriginalName("AVA_ENABLED_NON_ATTACKABLE")]
		AvaEnabledNonAttackable,
		// Token: 0x040029AA RID: 10666
		[OriginalName("AVA_DISQUALIFIED")]
		AvaDisqualified,
		// Token: 0x040029AB RID: 10667
		[OriginalName("AVA_PREQUALIFIED_ATTACKABLE")]
		AvaPrequalifiedAttackable
	}
}
