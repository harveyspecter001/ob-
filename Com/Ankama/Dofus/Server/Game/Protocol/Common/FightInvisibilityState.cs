using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009B1 RID: 2481
	public enum FightInvisibilityState
	{
		// Token: 0x04002A0F RID: 10767
		[OriginalName("INVISIBLE")]
		Invisible,
		// Token: 0x04002A10 RID: 10768
		[OriginalName("DETECTED")]
		Detected,
		// Token: 0x04002A11 RID: 10769
		[OriginalName("VISIBLE")]
		Visible
	}
}
