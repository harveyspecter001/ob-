using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x0200009D RID: 157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupTeleportPlayerOfferEvent : IMessage<GroupTeleportPlayerOfferEvent>, IMessage, IEquatable<GroupTeleportPlayerOfferEvent>, IDeepCloneable<GroupTeleportPlayerOfferEvent>, IBufferMessage
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0018D280 File Offset: 0x0018B480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupTeleportPlayerOfferEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0018D290 File Offset: 0x0018B490
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0018D2A0 File Offset: 0x0018B4A0
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

		// Token: 0x060006AB RID: 1707 RVA: 0x0018D2B0 File Offset: 0x0018B4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerOfferEvent()
		{
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0018D2C0 File Offset: 0x0018B4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerOfferEvent(GroupTeleportPlayerOfferEvent other)
		{
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0018D2D0 File Offset: 0x0018B4D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerOfferEvent Clone()
		{
			return null;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0018D2E0 File Offset: 0x0018B4E0
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x0018D2F0 File Offset: 0x0018B4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0018D300 File Offset: 0x0018B500
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x0018D310 File Offset: 0x0018B510
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int WorldX
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0018D320 File Offset: 0x0018B520
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x0018D330 File Offset: 0x0018B530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldY
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0018D340 File Offset: 0x0018B540
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0018D350 File Offset: 0x0018B550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeLeft
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0018D360 File Offset: 0x0018B560
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x0018D370 File Offset: 0x0018B570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0018D380 File Offset: 0x0018B580
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0018D390 File Offset: 0x0018B590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RequesterName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0018D3A0 File Offset: 0x0018B5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0018D3B0 File Offset: 0x0018B5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GroupTeleportPlayerOfferEvent other)
		{
			return true;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0018D3C0 File Offset: 0x0018B5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0018D3D0 File Offset: 0x0018B5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0018D3E0 File Offset: 0x0018B5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0018D3F0 File Offset: 0x0018B5F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0018D400 File Offset: 0x0018B600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0018D410 File Offset: 0x0018B610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GroupTeleportPlayerOfferEvent other)
		{
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0018D420 File Offset: 0x0018B620
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0018D430 File Offset: 0x0018B630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0018D440 File Offset: 0x0018B640
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GroupTeleportPlayerOfferEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GroupTeleportPlayerOfferEvent._parser = new MessageParser<GroupTeleportPlayerOfferEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0018D538 File Offset: 0x0018B738
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool DAxGWAOIksX0HisP3HTZ()
		{
			return true;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0018D540 File Offset: 0x0018B740
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GroupTeleportPlayerOfferEvent St5gmjOIljkY7q33tp9C()
		{
			return null;
		}

		// Token: 0x0400027D RID: 637
		private static readonly MessageParser<GroupTeleportPlayerOfferEvent> _parser;

		// Token: 0x0400027E RID: 638
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400027F RID: 639
		public const int MapIdFieldNumber = 1;

		// Token: 0x04000280 RID: 640
		private long mapId_;

		// Token: 0x04000281 RID: 641
		public const int WorldXFieldNumber = 2;

		// Token: 0x04000282 RID: 642
		private int worldX_;

		// Token: 0x04000283 RID: 643
		public const int WorldYFieldNumber = 3;

		// Token: 0x04000284 RID: 644
		private int worldY_;

		// Token: 0x04000285 RID: 645
		public const int TimeLeftFieldNumber = 4;

		// Token: 0x04000286 RID: 646
		private int timeLeft_;

		// Token: 0x04000287 RID: 647
		public const int RequesterIdFieldNumber = 5;

		// Token: 0x04000288 RID: 648
		private long requesterId_;

		// Token: 0x04000289 RID: 649
		public const int RequesterNameFieldNumber = 6;

		// Token: 0x0400028A RID: 650
		private string requesterName_;

		// Token: 0x0400028B RID: 651
		internal static GroupTeleportPlayerOfferEvent KZWlCQOII1BlkOBhgotU;
	}
}
