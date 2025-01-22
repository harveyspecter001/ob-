using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008CE RID: 2254
	public enum Channel
	{
		// Token: 0x04002630 RID: 9776
		[OriginalName("GLOBAL")]
		Global,
		// Token: 0x04002631 RID: 9777
		[OriginalName("TEAM")]
		Team,
		// Token: 0x04002632 RID: 9778
		[OriginalName("GUILD")]
		Guild,
		// Token: 0x04002633 RID: 9779
		[OriginalName("ALLIANCE")]
		Alliance,
		// Token: 0x04002634 RID: 9780
		[OriginalName("PARTY")]
		Party,
		// Token: 0x04002635 RID: 9781
		[OriginalName("SALES")]
		Sales,
		// Token: 0x04002636 RID: 9782
		[OriginalName("SEEK")]
		Seek,
		// Token: 0x04002637 RID: 9783
		[OriginalName("NOOB")]
		Noob,
		// Token: 0x04002638 RID: 9784
		[OriginalName("ADMIN")]
		Admin,
		// Token: 0x04002639 RID: 9785
		[OriginalName("ARENA")]
		Arena,
		// Token: 0x0400263A RID: 9786
		[OriginalName("PRIVATE")]
		Private,
		// Token: 0x0400263B RID: 9787
		[OriginalName("INFO")]
		Info = 12,
		// Token: 0x0400263C RID: 9788
		[OriginalName("FIGHT_LOG")]
		FightLog,
		// Token: 0x0400263D RID: 9789
		[OriginalName("ADS")]
		Ads,
		// Token: 0x0400263E RID: 9790
		[OriginalName("EVENT")]
		Event,
		// Token: 0x0400263F RID: 9791
		[OriginalName("EXCHANGE")]
		Exchange
	}
}
