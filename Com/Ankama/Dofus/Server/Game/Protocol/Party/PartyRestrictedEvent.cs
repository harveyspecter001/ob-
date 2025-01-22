using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002F4 RID: 756
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyRestrictedEvent : IMessage<PartyRestrictedEvent>, IMessage, IEquatable<PartyRestrictedEvent>, IDeepCloneable<PartyRestrictedEvent>, IBufferMessage
	{
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x001BD8C0 File Offset: 0x001BBAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyRestrictedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x001BD8D0 File Offset: 0x001BBAD0
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x001BD8E0 File Offset: 0x001BBAE0
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

		// Token: 0x0600234C RID: 9036 RVA: 0x001BD8F0 File Offset: 0x001BBAF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyRestrictedEvent()
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x001BD900 File Offset: 0x001BBB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyRestrictedEvent(PartyRestrictedEvent other)
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x001BD910 File Offset: 0x001BBB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyRestrictedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x001BD920 File Offset: 0x001BBB20
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x001BD930 File Offset: 0x001BBB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x001BD940 File Offset: 0x001BBB40
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x001BD950 File Offset: 0x001BBB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Restricted
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

		// Token: 0x06002353 RID: 9043 RVA: 0x001BD960 File Offset: 0x001BBB60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x001BD970 File Offset: 0x001BBB70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyRestrictedEvent other)
		{
			return true;
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x001BD980 File Offset: 0x001BBB80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x001BD990 File Offset: 0x001BBB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x001BD9A0 File Offset: 0x001BBBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x001BD9B0 File Offset: 0x001BBBB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x001BD9C0 File Offset: 0x001BBBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x001BD9D0 File Offset: 0x001BBBD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyRestrictedEvent other)
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x001BD9E0 File Offset: 0x001BBBE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x001BD9F0 File Offset: 0x001BBBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x001BDA00 File Offset: 0x001BBC00
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyRestrictedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					PartyRestrictedEvent._parser = new MessageParser<PartyRestrictedEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x001BDAE4 File Offset: 0x001BBCE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool de5KY3OLyvmWe24gGsyq()
		{
			return true;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x001BDAEC File Offset: 0x001BBCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyRestrictedEvent rDcYQAOL64gy1vZZQVum()
		{
			return null;
		}

		// Token: 0x04000C78 RID: 3192
		private static readonly MessageParser<PartyRestrictedEvent> _parser;

		// Token: 0x04000C79 RID: 3193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C7A RID: 3194
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C7B RID: 3195
		private int partyId_;

		// Token: 0x04000C7C RID: 3196
		public const int RestrictedFieldNumber = 2;

		// Token: 0x04000C7D RID: 3197
		private bool restricted_;

		// Token: 0x04000C7E RID: 3198
		internal static PartyRestrictedEvent YTpa5tOL5yMWg5wgyfD3;
	}
}
