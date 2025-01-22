using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C09 RID: 3081
	public enum ArenaType
	{
		// Token: 0x04003722 RID: 14114
		[OriginalName("ONE_VS_ONE")]
		OneVsOne,
		// Token: 0x04003723 RID: 14115
		[OriginalName("TWO_VS_TWO")]
		TwoVsTwo,
		// Token: 0x04003724 RID: 14116
		[OriginalName("THREE_VS_THREE")]
		ThreeVsThree
	}
}
