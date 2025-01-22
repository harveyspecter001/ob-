using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009AC RID: 2476
	public enum ExchangeType
	{
		// Token: 0x040029D2 RID: 10706
		[OriginalName("NPC_SHOP")]
		NpcShop,
		// Token: 0x040029D3 RID: 10707
		[OriginalName("PLAYER_TRADE")]
		PlayerTrade,
		// Token: 0x040029D4 RID: 10708
		[OriginalName("NPC_TRADE")]
		NpcTrade,
		// Token: 0x040029D5 RID: 10709
		[OriginalName("CRAFT")]
		Craft,
		// Token: 0x040029D6 RID: 10710
		[OriginalName("STORAGE")]
		Storage,
		// Token: 0x040029D7 RID: 10711
		[OriginalName("SHOP_STOCK")]
		ShopStock,
		// Token: 0x040029D8 RID: 10712
		[OriginalName("TAX_COLLECTOR")]
		TaxCollector,
		// Token: 0x040029D9 RID: 10713
		[OriginalName("NPC_MODIFY_TRADE")]
		NpcModifyTrade,
		// Token: 0x040029DA RID: 10714
		[OriginalName("BIDHOUSE_SELL")]
		BidhouseSell,
		// Token: 0x040029DB RID: 10715
		[OriginalName("BIDHOUSE_BUY")]
		BidhouseBuy,
		// Token: 0x040029DC RID: 10716
		[OriginalName("MULTICRAFT_CRAFTER")]
		MulticraftCrafter,
		// Token: 0x040029DD RID: 10717
		[OriginalName("MULTICRAFT_CUSTOMER")]
		MulticraftCustomer,
		// Token: 0x040029DE RID: 10718
		[OriginalName("JOB_INDEX")]
		JobIndex,
		// Token: 0x040029DF RID: 10719
		[OriginalName("MOUNT")]
		Mount,
		// Token: 0x040029E0 RID: 10720
		[OriginalName("MOUNT_STABLE")]
		MountStable,
		// Token: 0x040029E1 RID: 10721
		[OriginalName("NPC_RESURECT_PET")]
		NpcResurectPet,
		// Token: 0x040029E2 RID: 10722
		[OriginalName("NPC_TRADE_DRAGOTURKEY")]
		NpcTradeDragoturkey,
		// Token: 0x040029E3 RID: 10723
		[OriginalName("REALESTATE_HOUSE")]
		RealestateHouse,
		// Token: 0x040029E4 RID: 10724
		[OriginalName("REALESTATE_FARM")]
		RealestateFarm,
		// Token: 0x040029E5 RID: 10725
		[OriginalName("RUNES_TRADE")]
		RunesTrade,
		// Token: 0x040029E6 RID: 10726
		[OriginalName("RECYCLE_TRADE")]
		RecycleTrade,
		// Token: 0x040029E7 RID: 10727
		[OriginalName("BANK")]
		Bank,
		// Token: 0x040029E8 RID: 10728
		[OriginalName("TRASHBIN")]
		Trashbin,
		// Token: 0x040029E9 RID: 10729
		[OriginalName("ALLIANCE_PRISM")]
		AlliancePrism,
		// Token: 0x040029EA RID: 10730
		[OriginalName("HAVENBAG")]
		Havenbag,
		// Token: 0x040029EB RID: 10731
		[OriginalName("NPC_TRADE_SEEMYOOL")]
		NpcTradeSeemyool,
		// Token: 0x040029EC RID: 10732
		[OriginalName("NPC_TRADE_RHINEETLE")]
		NpcTradeRhineetle,
		// Token: 0x040029ED RID: 10733
		[OriginalName("EVOLUTIVE_OBJECT_ELEMENTARY_RECYCLE")]
		EvolutiveObjectElementaryRecycle,
		// Token: 0x040029EE RID: 10734
		[OriginalName("NPC_RIDE_CAPABILITY_TRADE")]
		NpcRideCapabilityTrade,
		// Token: 0x040029EF RID: 10735
		[OriginalName("GUILD_CHEST")]
		GuildChest
	}
}
