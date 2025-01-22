using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BDB RID: 3035
	public enum BidAction
	{
		// Token: 0x04003664 RID: 13924
		[OriginalName("BID_INVALID_ACTION")]
		BidInvalidAction,
		// Token: 0x04003665 RID: 13925
		[OriginalName("BID_CONSUME_BUFF")]
		BidConsumeBuff,
		// Token: 0x04003666 RID: 13926
		[OriginalName("BID_CANCEL")]
		BidCancel,
		// Token: 0x04003667 RID: 13927
		[OriginalName("BID_CREATE_KAMA")]
		BidCreateKama,
		// Token: 0x04003668 RID: 13928
		[OriginalName("BID_CREATE_OGRINE")]
		BidCreateOgrine,
		// Token: 0x04003669 RID: 13929
		[OriginalName("BID_BUY_KAMA")]
		BidBuyKama,
		// Token: 0x0400366A RID: 13930
		[OriginalName("BID_BUY_OGRINE")]
		BidBuyOgrine
	}
}
