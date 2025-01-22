using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009AB RID: 2475
	public enum DialogType
	{
		// Token: 0x040029C1 RID: 10689
		[OriginalName("DIALOG_BOOK")]
		DialogBook,
		// Token: 0x040029C2 RID: 10690
		[OriginalName("DIALOG_DIALOG")]
		DialogDialog,
		// Token: 0x040029C3 RID: 10691
		[OriginalName("DIALOG_LOCKABLE")]
		DialogLockable,
		// Token: 0x040029C4 RID: 10692
		[OriginalName("DIALOG_PURCHASABLE")]
		DialogPurchasable,
		// Token: 0x040029C5 RID: 10693
		[OriginalName("DIALOG_GUILD_INVITATION")]
		DialogGuildInvitation,
		// Token: 0x040029C6 RID: 10694
		[OriginalName("DIALOG_GUILD_CREATE")]
		DialogGuildCreate,
		// Token: 0x040029C7 RID: 10695
		[OriginalName("DIALOG_GUILD_RENAME")]
		DialogGuildRename,
		// Token: 0x040029C8 RID: 10696
		[OriginalName("DIALOG_MARRIAGE")]
		DialogMarriage,
		// Token: 0x040029C9 RID: 10697
		[OriginalName("DIALOG_DUNGEON_MEETING")]
		DialogDungeonMeeting,
		// Token: 0x040029CA RID: 10698
		[OriginalName("DIALOG_SPELL_FORGET")]
		DialogSpellForget,
		// Token: 0x040029CB RID: 10699
		[OriginalName("DIALOG_TELEPORTER")]
		DialogTeleporter,
		// Token: 0x040029CC RID: 10700
		[OriginalName("DIALOG_EXCHANGE")]
		DialogExchange,
		// Token: 0x040029CD RID: 10701
		[OriginalName("DIALOG_ALLIANCE_INVITATION")]
		DialogAllianceInvitation,
		// Token: 0x040029CE RID: 10702
		[OriginalName("DIALOG_ALLIANCE_CREATE")]
		DialogAllianceCreate,
		// Token: 0x040029CF RID: 10703
		[OriginalName("DIALOG_ALLIANCE_RENAME")]
		DialogAllianceRename,
		// Token: 0x040029D0 RID: 10704
		[OriginalName("DIALOG_HAVENBAG_MEETING")]
		DialogHavenbagMeeting
	}
}
