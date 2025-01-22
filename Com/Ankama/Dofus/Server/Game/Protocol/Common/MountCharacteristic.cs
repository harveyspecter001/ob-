using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009BF RID: 2495
	public enum MountCharacteristic
	{
		// Token: 0x04002A5F RID: 10847
		[OriginalName("ENERGY")]
		Energy,
		// Token: 0x04002A60 RID: 10848
		[OriginalName("SERENITY")]
		Serenity,
		// Token: 0x04002A61 RID: 10849
		[OriginalName("STAMINA")]
		Stamina,
		// Token: 0x04002A62 RID: 10850
		[OriginalName("LOVE")]
		Love,
		// Token: 0x04002A63 RID: 10851
		[OriginalName("MATURITY")]
		Maturity,
		// Token: 0x04002A64 RID: 10852
		[OriginalName("TIREDNESS")]
		Tiredness,
		// Token: 0x04002A65 RID: 10853
		[OriginalName("CARRIER")]
		Carrier,
		// Token: 0x04002A66 RID: 10854
		[OriginalName("FERTILE")]
		Fertile,
		// Token: 0x04002A67 RID: 10855
		[OriginalName("PREGNANT")]
		Pregnant
	}
}
