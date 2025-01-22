using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009A5 RID: 2469
	public enum CharacterState
	{
		// Token: 0x0400298F RID: 10639
		[OriginalName("NOT_CONNECTED")]
		NotConnected,
		// Token: 0x04002990 RID: 10640
		[OriginalName("IN_ROLE_PLAY")]
		InRolePlay,
		// Token: 0x04002991 RID: 10641
		[OriginalName("IN_FIGHT")]
		InFight,
		// Token: 0x04002992 RID: 10642
		[OriginalName("UNKNOWN_STATE")]
		UnknownState
	}
}
