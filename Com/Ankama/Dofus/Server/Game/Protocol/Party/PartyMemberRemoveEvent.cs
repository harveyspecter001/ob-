using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002EA RID: 746
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyMemberRemoveEvent : IMessage<PartyMemberRemoveEvent>, IMessage, IEquatable<PartyMemberRemoveEvent>, IDeepCloneable<PartyMemberRemoveEvent>, IBufferMessage
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x001BCD60 File Offset: 0x001BAF60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyMemberRemoveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x001BCD70 File Offset: 0x001BAF70
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

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x001BCD80 File Offset: 0x001BAF80
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

		// Token: 0x060022BA RID: 8890 RVA: 0x001BCD90 File Offset: 0x001BAF90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberRemoveEvent()
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x001BCDA0 File Offset: 0x001BAFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberRemoveEvent(PartyMemberRemoveEvent other)
		{
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x001BCDB0 File Offset: 0x001BAFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberRemoveEvent Clone()
		{
			return null;
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x001BCDC0 File Offset: 0x001BAFC0
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x001BCDD0 File Offset: 0x001BAFD0
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

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x001BCDE0 File Offset: 0x001BAFE0
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x001BCDF0 File Offset: 0x001BAFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LeavingPlayerId
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

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x001BCE00 File Offset: 0x001BB000
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x001BCE10 File Offset: 0x001BB010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long KickerId
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

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x001BCE20 File Offset: 0x001BB020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasKickerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x001BCE30 File Offset: 0x001BB030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearKickerId()
		{
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x001BCE40 File Offset: 0x001BB040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x001BCE50 File Offset: 0x001BB050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyMemberRemoveEvent other)
		{
			return true;
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x001BCE60 File Offset: 0x001BB060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x001BCE70 File Offset: 0x001BB070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x001BCE80 File Offset: 0x001BB080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x001BCE90 File Offset: 0x001BB090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x001BCEA0 File Offset: 0x001BB0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x001BCEB0 File Offset: 0x001BB0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyMemberRemoveEvent other)
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x001BCEC0 File Offset: 0x001BB0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x001BCED0 File Offset: 0x001BB0D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x001BCEE0 File Offset: 0x001BB0E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyMemberRemoveEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					PartyMemberRemoveEvent._parser = new MessageParser<PartyMemberRemoveEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					PartyMemberRemoveEvent.KickerIdDefaultValue = 0L;
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x001BCFEC File Offset: 0x001BB1EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsB84COLNdsvy7kxEdiF()
		{
			return true;
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x001BCFF4 File Offset: 0x001BB1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyMemberRemoveEvent wPTb9wOLx1ZxZaIdPcqV()
		{
			return null;
		}

		// Token: 0x04000C45 RID: 3141
		private static readonly MessageParser<PartyMemberRemoveEvent> _parser;

		// Token: 0x04000C46 RID: 3142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C47 RID: 3143
		private int _hasBits0;

		// Token: 0x04000C48 RID: 3144
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C49 RID: 3145
		private int partyId_;

		// Token: 0x04000C4A RID: 3146
		public const int LeavingPlayerIdFieldNumber = 2;

		// Token: 0x04000C4B RID: 3147
		private long leavingPlayerId_;

		// Token: 0x04000C4C RID: 3148
		public const int KickerIdFieldNumber = 3;

		// Token: 0x04000C4D RID: 3149
		private static readonly long KickerIdDefaultValue;

		// Token: 0x04000C4E RID: 3150
		private long kickerId_;

		// Token: 0x04000C4F RID: 3151
		private static PartyMemberRemoveEvent Jq1vuDOLXhd3U6pUKpsd;
	}
}
