using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009BC RID: 2492
	public enum SocialNoticeError
	{
		// Token: 0x04002A52 RID: 10834
		[OriginalName("SOCIAL_NOTICE_UNKNOWN_ERROR")]
		SocialNoticeUnknownError,
		// Token: 0x04002A53 RID: 10835
		[OriginalName("SOCIAL_NOTICE_INVALID_RIGHTS")]
		SocialNoticeInvalidRights,
		// Token: 0x04002A54 RID: 10836
		[OriginalName("SOCIAL_NOTICE_COOLDOWN")]
		SocialNoticeCooldown
	}
}
