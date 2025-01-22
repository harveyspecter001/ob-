using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009BB RID: 2491
	public enum SocialGroupOperationResult
	{
		// Token: 0x04002A46 RID: 10822
		[OriginalName("SOCIAL_GROUP_OPERATION_OK")]
		SocialGroupOperationOk,
		// Token: 0x04002A47 RID: 10823
		[OriginalName("SOCIAL_GROUP_ERROR_NAME_INVALID")]
		SocialGroupErrorNameInvalid,
		// Token: 0x04002A48 RID: 10824
		[OriginalName("SOCIAL_GROUP_ERROR_ALREADY_IN_GROUP")]
		SocialGroupErrorAlreadyInGroup,
		// Token: 0x04002A49 RID: 10825
		[OriginalName("SOCIAL_GROUP_ERROR_NAME_ALREADY_EXISTS")]
		SocialGroupErrorNameAlreadyExists,
		// Token: 0x04002A4A RID: 10826
		[OriginalName("SOCIAL_GROUP_ERROR_LEAVE")]
		SocialGroupErrorLeave,
		// Token: 0x04002A4B RID: 10827
		[OriginalName("SOCIAL_GROUP_ERROR_CANCEL")]
		SocialGroupErrorCancel,
		// Token: 0x04002A4C RID: 10828
		[OriginalName("SOCIAL_GROUP_ERROR_REQUIREMENT_UNMET")]
		SocialGroupErrorRequirementUnmet,
		// Token: 0x04002A4D RID: 10829
		[OriginalName("SOCIAL_GROUP_ERROR_EMBLEM_INVALID")]
		SocialGroupErrorEmblemInvalid,
		// Token: 0x04002A4E RID: 10830
		[OriginalName("SOCIAL_GROUP_ERROR_TAG_INVALID")]
		SocialGroupErrorTagInvalid,
		// Token: 0x04002A4F RID: 10831
		[OriginalName("SOCIAL_GROUP_ERROR_TAG_ALREADY_EXISTS")]
		SocialGroupErrorTagAlreadyExists,
		// Token: 0x04002A50 RID: 10832
		[OriginalName("SOCIAL_GROUP_ERROR_UNKNOWN")]
		SocialGroupErrorUnknown
	}
}
