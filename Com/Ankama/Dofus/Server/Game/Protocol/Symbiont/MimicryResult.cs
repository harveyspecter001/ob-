using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont
{
	// Token: 0x020000FF RID: 255
	public enum MimicryResult
	{
		// Token: 0x04000438 RID: 1080
		[OriginalName("ERROR")]
		Error,
		// Token: 0x04000439 RID: 1081
		[OriginalName("PLAYER_BUSY")]
		PlayerBusy,
		// Token: 0x0400043A RID: 1082
		[OriginalName("HOST_NOT_MIMICKABLE")]
		HostNotMimickable,
		// Token: 0x0400043B RID: 1083
		[OriginalName("HOST_WRAPPED")]
		HostWrapped,
		// Token: 0x0400043C RID: 1084
		[OriginalName("DUPLICATE")]
		Duplicate,
		// Token: 0x0400043D RID: 1085
		[OriginalName("SUCCESS")]
		Success
	}
}
