using System;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x020009B5 RID: 2485
	public enum Direction
	{
		// Token: 0x04002A1E RID: 10782
		[OriginalName("DIRECTION_EAST")]
		East,
		// Token: 0x04002A1F RID: 10783
		[OriginalName("DIRECTION_SOUTH_EAST")]
		SouthEast,
		// Token: 0x04002A20 RID: 10784
		[OriginalName("DIRECTION_SOUTH")]
		South,
		// Token: 0x04002A21 RID: 10785
		[OriginalName("DIRECTION_SOUTH_WEST")]
		SouthWest,
		// Token: 0x04002A22 RID: 10786
		[OriginalName("DIRECTION_WEST")]
		West,
		// Token: 0x04002A23 RID: 10787
		[OriginalName("DIRECTION_NORTH_WEST")]
		NorthWest,
		// Token: 0x04002A24 RID: 10788
		[OriginalName("DIRECTION_NORTH")]
		North,
		// Token: 0x04002A25 RID: 10789
		[OriginalName("DIRECTION_NORTH_EAST")]
		NorthEast
	}
}
