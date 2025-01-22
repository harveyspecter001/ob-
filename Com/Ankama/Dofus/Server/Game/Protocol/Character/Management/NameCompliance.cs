using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200090A RID: 2314
	public enum NameCompliance
	{
		// Token: 0x04002758 RID: 10072
		[OriginalName("NAME_OK")]
		NameOk,
		// Token: 0x04002759 RID: 10073
		[OriginalName("NAME_ERROR_SERVICE_UNAVAILABLE")]
		NameErrorServiceUnavailable,
		// Token: 0x0400275A RID: 10074
		[OriginalName("NAME_ERROR_ALREADY_EXISTS")]
		NameErrorAlreadyExists,
		// Token: 0x0400275B RID: 10075
		[OriginalName("NAME_ERROR_BAD_ALPHABET")]
		NameErrorBadAlphabet,
		// Token: 0x0400275C RID: 10076
		[OriginalName("NAME_ERROR_BAD_LENGTH")]
		NameErrorBadLength,
		// Token: 0x0400275D RID: 10077
		[OriginalName("NAME_ERROR_BAD_CHAR")]
		NameErrorBadChar,
		// Token: 0x0400275E RID: 10078
		[OriginalName("NAME_ERROR_INVALID_DASH_POSITION")]
		NameErrorInvalidDashPosition,
		// Token: 0x0400275F RID: 10079
		[OriginalName("NAME_ERROR_NAME_WITH_BAD_CASE")]
		NameErrorNameWithBadCase,
		// Token: 0x04002760 RID: 10080
		[OriginalName("NAME_ERROR_TOO_MANY_CONSECUTIVE_IDENTICAL")]
		NameErrorTooManyConsecutiveIdentical,
		// Token: 0x04002761 RID: 10081
		[OriginalName("NAME_ERROR_TOO_MANY_SPECIAL")]
		NameErrorTooManySpecial,
		// Token: 0x04002762 RID: 10082
		[OriginalName("NAME_ERROR_FORBIDDEN")]
		NameErrorForbidden,
		// Token: 0x04002763 RID: 10083
		[OriginalName("NAME_ERROR_RESERVED")]
		NameErrorReserved
	}
}
