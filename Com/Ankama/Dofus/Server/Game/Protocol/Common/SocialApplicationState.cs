using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009B9 RID: 2489
	public enum SocialApplicationState
	{
		// Token: 0x04002A3B RID: 10811
		[OriginalName("APPLICATION_ADDED")]
		ApplicationAdded,
		// Token: 0x04002A3C RID: 10812
		[OriginalName("APPLICATION_DELETED")]
		ApplicationDeleted,
		// Token: 0x04002A3D RID: 10813
		[OriginalName("APPLICATION_UPDATED")]
		ApplicationUpdated
	}
}
