using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009AA RID: 2474
	public enum Restriction
	{
		// Token: 0x040029AD RID: 10669
		[OriginalName("CANNOT_BE_ATTACKED")]
		CannotBeAttacked,
		// Token: 0x040029AE RID: 10670
		[OriginalName("CANNOT_BE_CHALLENGED")]
		CannotBeChallenged,
		// Token: 0x040029AF RID: 10671
		[OriginalName("CANNOT_TRADE")]
		CannotTrade,
		// Token: 0x040029B0 RID: 10672
		[OriginalName("CANNOT_BE_ATTACKED_BY_MUTANT")]
		CannotBeAttackedByMutant,
		// Token: 0x040029B1 RID: 10673
		[OriginalName("CANNOT_RUN")]
		CannotRun,
		// Token: 0x040029B2 RID: 10674
		[OriginalName("FORCE_SLOW_WALK")]
		ForceSlowWalk,
		// Token: 0x040029B3 RID: 10675
		[OriginalName("CANNOT_MINIMIZE")]
		CannotMinimize,
		// Token: 0x040029B4 RID: 10676
		[OriginalName("CANNOT_MOVE")]
		CannotMove,
		// Token: 0x040029B5 RID: 10677
		[OriginalName("CANNOT_ATTACK")]
		CannotAttack,
		// Token: 0x040029B6 RID: 10678
		[OriginalName("CANNOT_CHALLENGE")]
		CannotChallenge,
		// Token: 0x040029B7 RID: 10679
		[OriginalName("CANNOT_EXCHANGE")]
		CannotExchange,
		// Token: 0x040029B8 RID: 10680
		[OriginalName("CANNOT_ATTACK_AS_MUTANT")]
		CannotAttackAsMutant,
		// Token: 0x040029B9 RID: 10681
		[OriginalName("CANNOT_CHAT")]
		CannotChat,
		// Token: 0x040029BA RID: 10682
		[OriginalName("CANNOT_USE_OBJECT")]
		CannotUseObject,
		// Token: 0x040029BB RID: 10683
		[OriginalName("CANNOT_USE_TAX_COLLECTOR")]
		CannotUseTaxCollector,
		// Token: 0x040029BC RID: 10684
		[OriginalName("CANNOT_USE_INTERACTIVE")]
		CannotUseInteractive,
		// Token: 0x040029BD RID: 10685
		[OriginalName("CANNOT_SPEAK_TO_NPC")]
		CannotSpeakToNpc,
		// Token: 0x040029BE RID: 10686
		[OriginalName("CANNOT_CHANGE_ZONE")]
		CannotChangeZone,
		// Token: 0x040029BF RID: 10687
		[OriginalName("CANNOT_ATTACK_MONSTER")]
		CannotAttackMonster
	}
}
