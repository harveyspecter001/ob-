using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002FA RID: 762
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyMemberInFightEvent : IMessage<PartyMemberInFightEvent>, IMessage, IEquatable<PartyMemberInFightEvent>, IDeepCloneable<PartyMemberInFightEvent>, IBufferMessage
	{
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x001BDF28 File Offset: 0x001BC128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyMemberInFightEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x001BDF38 File Offset: 0x001BC138
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

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x001BDF48 File Offset: 0x001BC148
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

		// Token: 0x0600239E RID: 9118 RVA: 0x001BDF58 File Offset: 0x001BC158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberInFightEvent()
		{
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x001BDF68 File Offset: 0x001BC168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberInFightEvent(PartyMemberInFightEvent other)
		{
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x001BDF78 File Offset: 0x001BC178
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberInFightEvent Clone()
		{
			return null;
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x001BDF88 File Offset: 0x001BC188
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x001BDF98 File Offset: 0x001BC198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PartyId
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

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x001BDFA8 File Offset: 0x001BC1A8
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x001BDFBC File Offset: 0x001BC1BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PartyMemberInFightCause Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PartyMemberInFightCause)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x001BDFCC File Offset: 0x001BC1CC
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x001BDFDC File Offset: 0x001BC1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MemberId
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

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x001BDFEC File Offset: 0x001BC1EC
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x001BDFFC File Offset: 0x001BC1FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MemberAccountId
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

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x001BE00C File Offset: 0x001BC20C
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x001BE01C File Offset: 0x001BC21C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string MemberName
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

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x001BE02C File Offset: 0x001BC22C
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x001BE03C File Offset: 0x001BC23C
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x001BE04C File Offset: 0x001BC24C
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x001BE05C File Offset: 0x001BC25C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TimeBeforeFightStart
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

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x001BE06C File Offset: 0x001BC26C
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x001BE07C File Offset: 0x001BC27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapExtendedCoordinates StandardFightMap
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

		// Token: 0x060023B1 RID: 9137 RVA: 0x001BE08C File Offset: 0x001BC28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x001BE09C File Offset: 0x001BC29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyMemberInFightEvent other)
		{
			return true;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x001BE0AC File Offset: 0x001BC2AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x001BE0BC File Offset: 0x001BC2BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x001BE0CC File Offset: 0x001BC2CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x001BE0DC File Offset: 0x001BC2DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x001BE0EC File Offset: 0x001BC2EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x001BE0FC File Offset: 0x001BC2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyMemberInFightEvent other)
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x001BE10C File Offset: 0x001BC30C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x001BE11C File Offset: 0x001BC31C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x001BE12C File Offset: 0x001BC32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyMemberInFightEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					PartyMemberInFightEvent._parser = new MessageParser<PartyMemberInFightEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x001BE1F8 File Offset: 0x001BC3F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MD5eoROLDoG7hmCE6T3M()
		{
			return true;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x001BE200 File Offset: 0x001BC400
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyMemberInFightEvent yUD7qeOLtZaMGO2rJNfC()
		{
			return null;
		}

		// Token: 0x04000C91 RID: 3217
		private static readonly MessageParser<PartyMemberInFightEvent> _parser;

		// Token: 0x04000C92 RID: 3218
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C93 RID: 3219
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C94 RID: 3220
		private int partyId_;

		// Token: 0x04000C95 RID: 3221
		public const int ReasonFieldNumber = 2;

		// Token: 0x04000C96 RID: 3222
		private PartyMemberInFightCause reason_;

		// Token: 0x04000C97 RID: 3223
		public const int MemberIdFieldNumber = 3;

		// Token: 0x04000C98 RID: 3224
		private long memberId_;

		// Token: 0x04000C99 RID: 3225
		public const int MemberAccountIdFieldNumber = 4;

		// Token: 0x04000C9A RID: 3226
		private long memberAccountId_;

		// Token: 0x04000C9B RID: 3227
		public const int MemberNameFieldNumber = 5;

		// Token: 0x04000C9C RID: 3228
		private string memberName_;

		// Token: 0x04000C9D RID: 3229
		public const int FightIdFieldNumber = 6;

		// Token: 0x04000C9E RID: 3230
		private int fightId_;

		// Token: 0x04000C9F RID: 3231
		public const int TimeBeforeFightStartFieldNumber = 7;

		// Token: 0x04000CA0 RID: 3232
		private int timeBeforeFightStart_;

		// Token: 0x04000CA1 RID: 3233
		public const int StandardFightMapFieldNumber = 8;

		// Token: 0x04000CA2 RID: 3234
		private MapExtendedCoordinates standardFightMap_;

		// Token: 0x04000CA3 RID: 3235
		internal static PartyMemberInFightEvent XnSyjLOLC1Q8yNI8QrMO;
	}
}
