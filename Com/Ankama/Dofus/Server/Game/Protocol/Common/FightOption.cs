using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009AF RID: 2479
	public enum FightOption
	{
		// Token: 0x04002A04 RID: 10756
		[OriginalName("FIGHT_OPTION_SET_SECRET")]
		SetSecret,
		// Token: 0x04002A05 RID: 10757
		[OriginalName("FIGHT_OPTION_SET_TO_PARTY_ONLY")]
		SetToPartyOnly,
		// Token: 0x04002A06 RID: 10758
		[OriginalName("FIGHT_OPTION_SET_CLOSED")]
		SetClosed,
		// Token: 0x04002A07 RID: 10759
		[OriginalName("FIGHT_OPTION_ASK_FOR_HELP")]
		AskForHelp
	}
}
