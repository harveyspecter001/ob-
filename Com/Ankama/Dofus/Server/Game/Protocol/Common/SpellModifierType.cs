using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009C1 RID: 2497
	public enum SpellModifierType
	{
		// Token: 0x04002A6E RID: 10862
		[OriginalName("INVALID_MODIFICATION")]
		InvalidModification,
		// Token: 0x04002A6F RID: 10863
		[OriginalName("RANGE")]
		Range,
		// Token: 0x04002A70 RID: 10864
		[OriginalName("DAMAGE")]
		Damage,
		// Token: 0x04002A71 RID: 10865
		[OriginalName("BASE_DAMAGE")]
		BaseDamage,
		// Token: 0x04002A72 RID: 10866
		[OriginalName("HEAL_BONUS")]
		HealBonus,
		// Token: 0x04002A73 RID: 10867
		[OriginalName("AP_COST")]
		ApCost,
		// Token: 0x04002A74 RID: 10868
		[OriginalName("CAST_INTERVAL")]
		CastInterval,
		// Token: 0x04002A75 RID: 10869
		[OriginalName("CRITICAL_HIT_BONUS")]
		CriticalHitBonus,
		// Token: 0x04002A76 RID: 10870
		[OriginalName("CAST_LINE")]
		CastLine,
		// Token: 0x04002A77 RID: 10871
		[OriginalName("LOS")]
		Los,
		// Token: 0x04002A78 RID: 10872
		[OriginalName("MAX_CAST_PER_TURN")]
		MaxCastPerTurn,
		// Token: 0x04002A79 RID: 10873
		[OriginalName("MAX_CAST_PER_TARGET")]
		MaxCastPerTarget,
		// Token: 0x04002A7A RID: 10874
		[OriginalName("RANGE_MAX")]
		RangeMax,
		// Token: 0x04002A7B RID: 10875
		[OriginalName("RANGE_MIN")]
		RangeMin,
		// Token: 0x04002A7C RID: 10876
		[OriginalName("OCCUPIED_CELL")]
		OccupiedCell,
		// Token: 0x04002A7D RID: 10877
		[OriginalName("FREE_CELL")]
		FreeCell,
		// Token: 0x04002A7E RID: 10878
		[OriginalName("VISIBLE_TARGET")]
		VisibleTarget,
		// Token: 0x04002A7F RID: 10879
		[OriginalName("PORTAL_FREE_CELL")]
		PortalFreeCell,
		// Token: 0x04002A80 RID: 10880
		[OriginalName("PORTAL_PROJECTION")]
		PortalProjection
	}
}
