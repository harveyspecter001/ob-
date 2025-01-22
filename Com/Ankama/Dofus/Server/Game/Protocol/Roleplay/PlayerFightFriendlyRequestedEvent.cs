using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000186 RID: 390
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerFightFriendlyRequestedEvent : IMessage<PlayerFightFriendlyRequestedEvent>, IMessage, IEquatable<PlayerFightFriendlyRequestedEvent>, IDeepCloneable<PlayerFightFriendlyRequestedEvent>, IBufferMessage
	{
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x001A1778 File Offset: 0x0019F978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PlayerFightFriendlyRequestedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x001A1788 File Offset: 0x0019F988
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

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x001A1798 File Offset: 0x0019F998
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

		// Token: 0x060011E7 RID: 4583 RVA: 0x001A17A8 File Offset: 0x0019F9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyRequestedEvent()
		{
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x001A17B8 File Offset: 0x0019F9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyRequestedEvent(PlayerFightFriendlyRequestedEvent other)
		{
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x001A17C8 File Offset: 0x0019F9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerFightFriendlyRequestedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x001A17D8 File Offset: 0x0019F9D8
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x001A17E8 File Offset: 0x0019F9E8
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x001A17F8 File Offset: 0x0019F9F8
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x001A1808 File Offset: 0x0019FA08
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

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x001A1818 File Offset: 0x0019FA18
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x001A1828 File Offset: 0x0019FA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060011F0 RID: 4592 RVA: 0x001A1838 File Offset: 0x0019FA38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x001A1848 File Offset: 0x0019FA48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerFightFriendlyRequestedEvent other)
		{
			return true;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x001A1858 File Offset: 0x0019FA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x001A1868 File Offset: 0x0019FA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x001A1878 File Offset: 0x0019FA78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x001A1888 File Offset: 0x0019FA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x001A1898 File Offset: 0x0019FA98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x001A18A8 File Offset: 0x0019FAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerFightFriendlyRequestedEvent other)
		{
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x001A18B8 File Offset: 0x0019FAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x001A18C8 File Offset: 0x0019FAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x001A18D8 File Offset: 0x0019FAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerFightFriendlyRequestedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PlayerFightFriendlyRequestedEvent._parser = new MessageParser<PlayerFightFriendlyRequestedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x001A19D0 File Offset: 0x0019FBD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K63PnoOvwf7av99XVEN9()
		{
			return true;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x001A19D8 File Offset: 0x0019FBD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerFightFriendlyRequestedEvent L3GgAQOvQIGv2sZQwhbO()
		{
			return null;
		}

		// Token: 0x04000675 RID: 1653
		private static readonly MessageParser<PlayerFightFriendlyRequestedEvent> _parser;

		// Token: 0x04000676 RID: 1654
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000677 RID: 1655
		public const int FightIdFieldNumber = 1;

		// Token: 0x04000678 RID: 1656
		private int fightId_;

		// Token: 0x04000679 RID: 1657
		public const int SourceIdFieldNumber = 2;

		// Token: 0x0400067A RID: 1658
		private long sourceId_;

		// Token: 0x0400067B RID: 1659
		public const int TargetIdFieldNumber = 3;

		// Token: 0x0400067C RID: 1660
		private long targetId_;

		// Token: 0x0400067D RID: 1661
		internal static PlayerFightFriendlyRequestedEvent QefyLsOvtJxoZTBSKvXc;
	}
}
