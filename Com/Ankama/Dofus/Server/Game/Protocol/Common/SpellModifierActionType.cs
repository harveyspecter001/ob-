using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009C0 RID: 2496
	public enum SpellModifierActionType
	{
		// Token: 0x04002A69 RID: 10857
		[OriginalName("ACTION_INVALID")]
		ActionInvalid,
		// Token: 0x04002A6A RID: 10858
		[OriginalName("ACTION_BOOST")]
		ActionBoost,
		// Token: 0x04002A6B RID: 10859
		[OriginalName("ACTION_REMOVE_BOOST")]
		ActionRemoveBoost,
		// Token: 0x04002A6C RID: 10860
		[OriginalName("ACTION_SET")]
		ActionSet
	}
}
