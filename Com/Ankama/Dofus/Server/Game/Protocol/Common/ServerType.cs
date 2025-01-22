using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009BA RID: 2490
	public enum ServerType
	{
		// Token: 0x04002A3F RID: 10815
		[OriginalName("UNDEFINED")]
		Undefined,
		// Token: 0x04002A40 RID: 10816
		[OriginalName("CLASSICAL")]
		Classical,
		// Token: 0x04002A41 RID: 10817
		[OriginalName("KOLIZEUM")]
		Kolizeum,
		// Token: 0x04002A42 RID: 10818
		[OriginalName("TOURNAMENT")]
		Tournament,
		// Token: 0x04002A43 RID: 10819
		[OriginalName("EPIC")]
		Epic,
		// Token: 0x04002A44 RID: 10820
		[OriginalName("TEMPORIS")]
		Temporis
	}
}
