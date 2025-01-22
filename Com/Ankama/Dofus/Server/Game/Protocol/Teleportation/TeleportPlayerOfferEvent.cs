using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000099 RID: 153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportPlayerOfferEvent : IMessage<TeleportPlayerOfferEvent>, IMessage, IEquatable<TeleportPlayerOfferEvent>, IDeepCloneable<TeleportPlayerOfferEvent>, IBufferMessage
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0018CDD4 File Offset: 0x0018AFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportPlayerOfferEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0018CDE4 File Offset: 0x0018AFE4
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0018CDF4 File Offset: 0x0018AFF4
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

		// Token: 0x0600066F RID: 1647 RVA: 0x0018CE04 File Offset: 0x0018B004
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerOfferEvent()
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0018CE14 File Offset: 0x0018B014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerOfferEvent(TeleportPlayerOfferEvent other)
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0018CE24 File Offset: 0x0018B024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportPlayerOfferEvent Clone()
		{
			return null;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0018CE34 File Offset: 0x0018B034
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x0018CE44 File Offset: 0x0018B044
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0018CE54 File Offset: 0x0018B054
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x0018CE64 File Offset: 0x0018B064
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Message
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0018CE74 File Offset: 0x0018B074
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0018CE84 File Offset: 0x0018B084
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x0018CE94 File Offset: 0x0018B094
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x0018CEA4 File Offset: 0x0018B0A4
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

		// Token: 0x0600067A RID: 1658 RVA: 0x0018CEB4 File Offset: 0x0018B0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0018CEC4 File Offset: 0x0018B0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportPlayerOfferEvent other)
		{
			return true;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0018CED4 File Offset: 0x0018B0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0018CEE4 File Offset: 0x0018B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0018CEF4 File Offset: 0x0018B0F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0018CF04 File Offset: 0x0018B104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0018CF14 File Offset: 0x0018B114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0018CF24 File Offset: 0x0018B124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportPlayerOfferEvent other)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0018CF34 File Offset: 0x0018B134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0018CF44 File Offset: 0x0018B144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0018CF54 File Offset: 0x0018B154
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportPlayerOfferEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					TeleportPlayerOfferEvent._parser = new MessageParser<TeleportPlayerOfferEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0018D038 File Offset: 0x0018B238
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cqebIJOIN6t4558Ube1M()
		{
			return true;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0018D040 File Offset: 0x0018B240
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportPlayerOfferEvent YwJiG2OIxRBJ07MNB6f6()
		{
			return null;
		}

		// Token: 0x04000267 RID: 615
		private static readonly MessageParser<TeleportPlayerOfferEvent> _parser;

		// Token: 0x04000268 RID: 616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000269 RID: 617
		public const int MapIdFieldNumber = 1;

		// Token: 0x0400026A RID: 618
		private long mapId_;

		// Token: 0x0400026B RID: 619
		public const int MessageFieldNumber = 2;

		// Token: 0x0400026C RID: 620
		private string message_;

		// Token: 0x0400026D RID: 621
		public const int TimeLeftFieldNumber = 3;

		// Token: 0x0400026E RID: 622
		private int timeLeft_;

		// Token: 0x0400026F RID: 623
		public const int RequesterIdFieldNumber = 4;

		// Token: 0x04000270 RID: 624
		private long requesterId_;

		// Token: 0x04000271 RID: 625
		private static TeleportPlayerOfferEvent VwDftOOIXVCJshRxMHxm;
	}
}
