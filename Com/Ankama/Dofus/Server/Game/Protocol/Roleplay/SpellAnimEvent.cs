using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000192 RID: 402
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellAnimEvent : IMessage<SpellAnimEvent>, IMessage, IEquatable<SpellAnimEvent>, IDeepCloneable<SpellAnimEvent>, IBufferMessage
	{
		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x001A24F8 File Offset: 0x001A06F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpellAnimEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x001A2508 File Offset: 0x001A0708
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x001A2518 File Offset: 0x001A0718
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

		// Token: 0x06001295 RID: 4757 RVA: 0x001A2528 File Offset: 0x001A0728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellAnimEvent()
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x001A2538 File Offset: 0x001A0738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellAnimEvent(SpellAnimEvent other)
		{
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x001A2548 File Offset: 0x001A0748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellAnimEvent Clone()
		{
			return null;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x001A2558 File Offset: 0x001A0758
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x001A2568 File Offset: 0x001A0768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasterId
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x001A2578 File Offset: 0x001A0778
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x001A2588 File Offset: 0x001A0788
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x001A2598 File Offset: 0x001A0798
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x001A25A8 File Offset: 0x001A07A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellId
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x001A25B8 File Offset: 0x001A07B8
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x001A25C8 File Offset: 0x001A07C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpellLevel
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x001A25D8 File Offset: 0x001A07D8
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x001A25EC File Offset: 0x001A07EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Direction Direction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Direction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x001A25FC File Offset: 0x001A07FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x001A260C File Offset: 0x001A080C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellAnimEvent other)
		{
			return true;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x001A261C File Offset: 0x001A081C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x001A262C File Offset: 0x001A082C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x001A263C File Offset: 0x001A083C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x001A264C File Offset: 0x001A084C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x001A265C File Offset: 0x001A085C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x001A266C File Offset: 0x001A086C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellAnimEvent other)
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x001A267C File Offset: 0x001A087C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x001A268C File Offset: 0x001A088C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x001A269C File Offset: 0x001A089C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellAnimEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					SpellAnimEvent._parser = new MessageParser<SpellAnimEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x001A2768 File Offset: 0x001A0968
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BXtxaNOofMetImSTV4YE()
		{
			return true;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x001A2770 File Offset: 0x001A0970
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellAnimEvent H0HGQPOonq4oe3AtSwx3()
		{
			return null;
		}

		// Token: 0x040006B1 RID: 1713
		private static readonly MessageParser<SpellAnimEvent> _parser;

		// Token: 0x040006B2 RID: 1714
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006B3 RID: 1715
		public const int CasterIdFieldNumber = 1;

		// Token: 0x040006B4 RID: 1716
		private long casterId_;

		// Token: 0x040006B5 RID: 1717
		public const int TargetCellIdFieldNumber = 2;

		// Token: 0x040006B6 RID: 1718
		private int targetCellId_;

		// Token: 0x040006B7 RID: 1719
		public const int SpellIdFieldNumber = 3;

		// Token: 0x040006B8 RID: 1720
		private int spellId_;

		// Token: 0x040006B9 RID: 1721
		public const int SpellLevelFieldNumber = 4;

		// Token: 0x040006BA RID: 1722
		private int spellLevel_;

		// Token: 0x040006BB RID: 1723
		public const int DirectionFieldNumber = 5;

		// Token: 0x040006BC RID: 1724
		private Direction direction_;

		// Token: 0x040006BD RID: 1725
		internal static SpellAnimEvent gvDcLcOvz4O4nNwLJIsV;
	}
}
