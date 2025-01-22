using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000182 RID: 386
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightRequestCanceledEvent : IMessage<FightRequestCanceledEvent>, IMessage, IEquatable<FightRequestCanceledEvent>, IDeepCloneable<FightRequestCanceledEvent>, IBufferMessage
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x001A1304 File Offset: 0x0019F504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightRequestCanceledEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x001A1314 File Offset: 0x0019F514
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x001A1324 File Offset: 0x0019F524
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

		// Token: 0x060011AD RID: 4525 RVA: 0x001A1334 File Offset: 0x0019F534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRequestCanceledEvent()
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x001A1344 File Offset: 0x0019F544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRequestCanceledEvent(FightRequestCanceledEvent other)
		{
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x001A1354 File Offset: 0x0019F554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRequestCanceledEvent Clone()
		{
			return null;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x001A1364 File Offset: 0x0019F564
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x001A1374 File Offset: 0x0019F574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FightId
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x001A1384 File Offset: 0x0019F584
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x001A1394 File Offset: 0x0019F594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SourceId
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x001A13A4 File Offset: 0x0019F5A4
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x001A13B4 File Offset: 0x0019F5B4
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

		// Token: 0x060011B6 RID: 4534 RVA: 0x001A13C4 File Offset: 0x0019F5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x001A13D4 File Offset: 0x0019F5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightRequestCanceledEvent other)
		{
			return true;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x001A13E4 File Offset: 0x0019F5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x001A13F4 File Offset: 0x0019F5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x001A1404 File Offset: 0x0019F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x001A1414 File Offset: 0x0019F614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x001A1424 File Offset: 0x0019F624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x001A1434 File Offset: 0x0019F634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightRequestCanceledEvent other)
		{
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x001A1444 File Offset: 0x0019F644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x001A1454 File Offset: 0x0019F654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x001A1464 File Offset: 0x0019F664
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightRequestCanceledEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				FightRequestCanceledEvent._parser = new MessageParser<FightRequestCanceledEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x001A1530 File Offset: 0x0019F730
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XLYi2oOvr1Ktr6opcJXt()
		{
			return true;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x001A1538 File Offset: 0x0019F738
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightRequestCanceledEvent t8h4EDOvVQbJwqSM78sM()
		{
			return null;
		}

		// Token: 0x04000661 RID: 1633
		private static readonly MessageParser<FightRequestCanceledEvent> _parser;

		// Token: 0x04000662 RID: 1634
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000663 RID: 1635
		public const int FightIdFieldNumber = 1;

		// Token: 0x04000664 RID: 1636
		private int fightId_;

		// Token: 0x04000665 RID: 1637
		public const int SourceIdFieldNumber = 2;

		// Token: 0x04000666 RID: 1638
		private long sourceId_;

		// Token: 0x04000667 RID: 1639
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04000668 RID: 1640
		private long targetId_;

		// Token: 0x04000669 RID: 1641
		internal static FightRequestCanceledEvent m8nAK7OvhnM6mZJ8vaU8;
	}
}
