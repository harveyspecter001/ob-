using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009BE RID: 2494
	public enum TaxCollectorState
	{
		// Token: 0x04002A5B RID: 10843
		[OriginalName("STATE_COLLECTING")]
		StateCollecting,
		// Token: 0x04002A5C RID: 10844
		[OriginalName("STATE_WAITING_FOR_HELP")]
		StateWaitingForHelp,
		// Token: 0x04002A5D RID: 10845
		[OriginalName("STATE_FIGHTING")]
		StateFighting
	}
}
