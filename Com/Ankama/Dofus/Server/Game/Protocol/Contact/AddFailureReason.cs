using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000824 RID: 2084
	public enum AddFailureReason
	{
		// Token: 0x04002398 RID: 9112
		[OriginalName("UNKNOWN")]
		Unknown,
		// Token: 0x04002399 RID: 9113
		[OriginalName("OVER_QUOTA")]
		OverQuota,
		// Token: 0x0400239A RID: 9114
		[OriginalName("NOT_FOUND")]
		NotFound,
		// Token: 0x0400239B RID: 9115
		[OriginalName("EGOCENTRIC")]
		Egocentric,
		// Token: 0x0400239C RID: 9116
		[OriginalName("IS_DOUBLE")]
		IsDouble,
		// Token: 0x0400239D RID: 9117
		[OriginalName("IS_CONFLICTING_DOUBLE")]
		IsConflictingDouble
	}
}
