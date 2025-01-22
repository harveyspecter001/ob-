using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005B6 RID: 1462
	public enum SequenceType
	{
		// Token: 0x0400186A RID: 6250
		[OriginalName("SPELL")]
		Spell,
		// Token: 0x0400186B RID: 6251
		[OriginalName("WEAPON")]
		Weapon,
		// Token: 0x0400186C RID: 6252
		[OriginalName("GLYPH_TRAP")]
		GlyphTrap,
		// Token: 0x0400186D RID: 6253
		[OriginalName("TRIGGERED")]
		Triggered,
		// Token: 0x0400186E RID: 6254
		[OriginalName("MOVE")]
		Move,
		// Token: 0x0400186F RID: 6255
		[OriginalName("CHARACTER_DEATH")]
		CharacterDeath,
		// Token: 0x04001870 RID: 6256
		[OriginalName("TURN_START")]
		TurnStart,
		// Token: 0x04001871 RID: 6257
		[OriginalName("TURN_END")]
		TurnEnd,
		// Token: 0x04001872 RID: 6258
		[OriginalName("FIGHT_START")]
		FightStart
	}
}
