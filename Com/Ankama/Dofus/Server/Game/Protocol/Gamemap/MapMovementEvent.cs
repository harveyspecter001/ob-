using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200058A RID: 1418
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapMovementEvent : IMessage<MapMovementEvent>, IMessage, IEquatable<MapMovementEvent>, IDeepCloneable<MapMovementEvent>, IBufferMessage
	{
		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x001F6240 File Offset: 0x001F4440
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapMovementEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x001F6250 File Offset: 0x001F4450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x001F6260 File Offset: 0x001F4460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x001F6270 File Offset: 0x001F4470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementEvent()
		{
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x001F6280 File Offset: 0x001F4480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementEvent(MapMovementEvent other)
		{
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x001F6290 File Offset: 0x001F4490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x001F62A0 File Offset: 0x001F44A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Cells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x001F62B0 File Offset: 0x001F44B0
		// (set) Token: 0x06004455 RID: 17493 RVA: 0x001F62C0 File Offset: 0x001F44C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06004456 RID: 17494 RVA: 0x001F62D0 File Offset: 0x001F44D0
		// (set) Token: 0x06004457 RID: 17495 RVA: 0x001F62E0 File Offset: 0x001F44E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Cautious
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x001F62F0 File Offset: 0x001F44F0
		// (set) Token: 0x06004459 RID: 17497 RVA: 0x001F6300 File Offset: 0x001F4500
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Direction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x001F6310 File Offset: 0x001F4510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x001F6320 File Offset: 0x001F4520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearDirection()
		{
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x001F6330 File Offset: 0x001F4530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x001F6340 File Offset: 0x001F4540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapMovementEvent other)
		{
			return true;
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x001F6350 File Offset: 0x001F4550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x001F6360 File Offset: 0x001F4560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x001F6370 File Offset: 0x001F4570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x001F6380 File Offset: 0x001F4580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x001F6390 File Offset: 0x001F4590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x001F63A0 File Offset: 0x001F45A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapMovementEvent other)
		{
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x001F63B0 File Offset: 0x001F45B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x001F63C0 File Offset: 0x001F45C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x001F63D0 File Offset: 0x001F45D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapMovementEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					MapMovementEvent.DirectionDefaultValue = 0;
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 6:
					MapMovementEvent._repeated_cells_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 5;
					continue;
				}
				MapMovementEvent._parser = new MessageParser<MapMovementEvent>(() => null);
				num2 = 6;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
				{
					num2 = 6;
				}
			}
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x001F64E4 File Offset: 0x001F46E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool J9OW8xOYjN73vJC5EX8P()
		{
			return true;
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x001F64EC File Offset: 0x001F46EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapMovementEvent Tbv3EUOYKWMw6n7Gax9K()
		{
			return null;
		}

		// Token: 0x04001779 RID: 6009
		private static readonly MessageParser<MapMovementEvent> _parser;

		// Token: 0x0400177A RID: 6010
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400177B RID: 6011
		private int _hasBits0;

		// Token: 0x0400177C RID: 6012
		public const int CellsFieldNumber = 1;

		// Token: 0x0400177D RID: 6013
		private static readonly FieldCodec<int> _repeated_cells_codec;

		// Token: 0x0400177E RID: 6014
		private readonly RepeatedField<int> cells_;

		// Token: 0x0400177F RID: 6015
		public const int CharacterIdFieldNumber = 3;

		// Token: 0x04001780 RID: 6016
		private long characterId_;

		// Token: 0x04001781 RID: 6017
		public const int CautiousFieldNumber = 4;

		// Token: 0x04001782 RID: 6018
		private bool cautious_;

		// Token: 0x04001783 RID: 6019
		public const int DirectionFieldNumber = 2;

		// Token: 0x04001784 RID: 6020
		private static readonly int DirectionDefaultValue;

		// Token: 0x04001785 RID: 6021
		private int direction_;

		// Token: 0x04001786 RID: 6022
		private static MapMovementEvent QREjVlOY43TFJkbeCtXh;
	}
}
