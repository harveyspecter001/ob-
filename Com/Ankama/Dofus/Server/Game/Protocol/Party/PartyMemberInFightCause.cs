using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000284 RID: 644
	public enum PartyMemberInFightCause
	{
		// Token: 0x04000A9F RID: 2719
		[OriginalName("UNKNOWN")]
		Unknown,
		// Token: 0x04000AA0 RID: 2720
		[OriginalName("MONSTER_ATTACK")]
		MonsterAttack,
		// Token: 0x04000AA1 RID: 2721
		[OriginalName("PLAYER_ATTACK")]
		PlayerAttack,
		// Token: 0x04000AA2 RID: 2722
		[OriginalName("MEMBER_ATTACKED_PLAYERS")]
		MemberAttackedPlayers,
		// Token: 0x04000AA3 RID: 2723
		[OriginalName("MEMBER_CHALLENGE")]
		MemberChallenge
	}
}
