using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006AD RID: 1709
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightPlacementSwapPositionsOfferEvent : IMessage<FightPlacementSwapPositionsOfferEvent>, IMessage, IEquatable<FightPlacementSwapPositionsOfferEvent>, IDeepCloneable<FightPlacementSwapPositionsOfferEvent>, IBufferMessage
	{
		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x00209B8C File Offset: 0x00207D8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightPlacementSwapPositionsOfferEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x00209B9C File Offset: 0x00207D9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x00209BAC File Offset: 0x00207DAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00209BBC File Offset: 0x00207DBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsOfferEvent()
		{
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x00209BCC File Offset: 0x00207DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsOfferEvent(FightPlacementSwapPositionsOfferEvent other)
		{
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00209BDC File Offset: 0x00207DDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightPlacementSwapPositionsOfferEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x00209BEC File Offset: 0x00207DEC
		// (set) Token: 0x06005377 RID: 21367 RVA: 0x00209BFC File Offset: 0x00207DFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RequestId
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

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x00209C0C File Offset: 0x00207E0C
		// (set) Token: 0x06005379 RID: 21369 RVA: 0x00209C1C File Offset: 0x00207E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RequesterId
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

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x00209C2C File Offset: 0x00207E2C
		// (set) Token: 0x0600537B RID: 21371 RVA: 0x00209C3C File Offset: 0x00207E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RequesterCellId
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

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x00209C4C File Offset: 0x00207E4C
		// (set) Token: 0x0600537D RID: 21373 RVA: 0x00209C5C File Offset: 0x00207E5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TargetId
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

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x00209C6C File Offset: 0x00207E6C
		// (set) Token: 0x0600537F RID: 21375 RVA: 0x00209C7C File Offset: 0x00207E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetCellId
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

		// Token: 0x06005380 RID: 21376 RVA: 0x00209C8C File Offset: 0x00207E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00209C9C File Offset: 0x00207E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightPlacementSwapPositionsOfferEvent other)
		{
			return true;
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00209CAC File Offset: 0x00207EAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x00209CBC File Offset: 0x00207EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00209CCC File Offset: 0x00207ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00209CDC File Offset: 0x00207EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00209CEC File Offset: 0x00207EEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00209CFC File Offset: 0x00207EFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightPlacementSwapPositionsOfferEvent other)
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00209D0C File Offset: 0x00207F0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00209D1C File Offset: 0x00207F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x00209D2C File Offset: 0x00207F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightPlacementSwapPositionsOfferEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FightPlacementSwapPositionsOfferEvent._parser = new MessageParser<FightPlacementSwapPositionsOfferEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00209E10 File Offset: 0x00208010
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KmbsUaOSGhmLEQ7ok1TH()
		{
			return true;
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00209E18 File Offset: 0x00208018
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightPlacementSwapPositionsOfferEvent LLloeZOSg06CNJEfRfAd()
		{
			return null;
		}

		// Token: 0x04001D66 RID: 7526
		private static readonly MessageParser<FightPlacementSwapPositionsOfferEvent> _parser;

		// Token: 0x04001D67 RID: 7527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D68 RID: 7528
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04001D69 RID: 7529
		private int requestId_;

		// Token: 0x04001D6A RID: 7530
		public const int RequesterIdFieldNumber = 2;

		// Token: 0x04001D6B RID: 7531
		private long requesterId_;

		// Token: 0x04001D6C RID: 7532
		public const int RequesterCellIdFieldNumber = 3;

		// Token: 0x04001D6D RID: 7533
		private int requesterCellId_;

		// Token: 0x04001D6E RID: 7534
		public const int TargetIdFieldNumber = 4;

		// Token: 0x04001D6F RID: 7535
		private long targetId_;

		// Token: 0x04001D70 RID: 7536
		public const int TargetCellIdFieldNumber = 5;

		// Token: 0x04001D71 RID: 7537
		private int targetCellId_;

		// Token: 0x04001D72 RID: 7538
		private static FightPlacementSwapPositionsOfferEvent zPSLxWOSJbo9XUywPrUL;
	}
}
