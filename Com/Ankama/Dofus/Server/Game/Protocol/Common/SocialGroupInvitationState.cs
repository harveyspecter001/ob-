using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009BD RID: 2493
	public enum SocialGroupInvitationState
	{
		// Token: 0x04002A56 RID: 10838
		[OriginalName("SOCIAL_GROUP_INVITATION_FAILED")]
		SocialGroupInvitationFailed,
		// Token: 0x04002A57 RID: 10839
		[OriginalName("SOCIAL_GROUP_INVITATION_SENT")]
		SocialGroupInvitationSent,
		// Token: 0x04002A58 RID: 10840
		[OriginalName("SOCIAL_GROUP_INVITATION_CANCELED")]
		SocialGroupInvitationCanceled,
		// Token: 0x04002A59 RID: 10841
		[OriginalName("SOCIAL_GROUP_INVITATION_OK")]
		SocialGroupInvitationOk
	}
}
