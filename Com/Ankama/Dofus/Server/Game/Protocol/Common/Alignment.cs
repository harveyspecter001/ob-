using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009A6 RID: 2470
	public enum Alignment
	{
		// Token: 0x04002994 RID: 10644
		[OriginalName("UNKNOWN")]
		Unknown,
		// Token: 0x04002995 RID: 10645
		[OriginalName("WITHOUT")]
		Without,
		// Token: 0x04002996 RID: 10646
		[OriginalName("NEUTRAL")]
		Neutral,
		// Token: 0x04002997 RID: 10647
		[OriginalName("ANGEL")]
		Angel,
		// Token: 0x04002998 RID: 10648
		[OriginalName("EVIL")]
		Evil
	}
}
