using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009A8 RID: 2472
	public enum Hierarchy
	{
		// Token: 0x0400299D RID: 10653
		[OriginalName("ROLE_UNAVAILABLE")]
		RoleUnavailable,
		// Token: 0x0400299E RID: 10654
		[OriginalName("ROLE_PLAYER")]
		RolePlayer,
		// Token: 0x0400299F RID: 10655
		[OriginalName("ROLE_MODERATOR")]
		RoleModerator,
		// Token: 0x040029A0 RID: 10656
		[OriginalName("ROLE_GAME_MASTER_PADAWAN")]
		RoleGameMasterPadawan,
		// Token: 0x040029A1 RID: 10657
		[OriginalName("ROLE_GAME_MASTER")]
		RoleGameMaster,
		// Token: 0x040029A2 RID: 10658
		[OriginalName("ROLE_ADMIN")]
		RoleAdmin,
		// Token: 0x040029A3 RID: 10659
		[OriginalName("ROLE_UNKNOWN_SPECIAL_USER")]
		RoleUnknownSpecialUser
	}
}
