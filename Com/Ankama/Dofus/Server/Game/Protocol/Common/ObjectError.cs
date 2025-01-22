using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009B6 RID: 2486
	public enum ObjectError
	{
		// Token: 0x04002A27 RID: 10791
		[OriginalName("INVENTORY_FULL")]
		InventoryFull,
		// Token: 0x04002A28 RID: 10792
		[OriginalName("CANNOT_EQUIP_TWICE")]
		CannotEquipTwice,
		// Token: 0x04002A29 RID: 10793
		[OriginalName("NOT_TRADABLE")]
		NotTradable,
		// Token: 0x04002A2A RID: 10794
		[OriginalName("CANNOT_DROP")]
		CannotDrop,
		// Token: 0x04002A2B RID: 10795
		[OriginalName("CANNOT_DROP_NO_PLACE")]
		CannotDropNoPlace,
		// Token: 0x04002A2C RID: 10796
		[OriginalName("CANNOT_DESTROY")]
		CannotDestroy,
		// Token: 0x04002A2D RID: 10797
		[OriginalName("LEVEL_TOO_LOW")]
		LevelTooLow,
		// Token: 0x04002A2E RID: 10798
		[OriginalName("CANNOT_UNEQUIP")]
		CannotUnequip,
		// Token: 0x04002A2F RID: 10799
		[OriginalName("CANNOT_EQUIP_HERE")]
		CannotEquipHere,
		// Token: 0x04002A30 RID: 10800
		[OriginalName("CRITERIONS")]
		Criterions,
		// Token: 0x04002A31 RID: 10801
		[OriginalName("SYMBIOTIC_OBJECT_ERROR")]
		SymbioticObjectError,
		// Token: 0x04002A32 RID: 10802
		[OriginalName("EVOLUTIVE_OBJECT_REFUSED_FOOD")]
		EvolutiveObjectRefusedFood
	}
}
