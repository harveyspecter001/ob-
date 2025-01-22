using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008D6 RID: 2262
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChatChannelMessageEvent : IMessage<ChatChannelMessageEvent>, IMessage, IEquatable<ChatChannelMessageEvent>, IDeepCloneable<ChatChannelMessageEvent>, IBufferMessage
	{
		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06006DE6 RID: 28134 RVA: 0x00235D58 File Offset: 0x00233F58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChatChannelMessageEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06006DE7 RID: 28135 RVA: 0x00235D68 File Offset: 0x00233F68
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

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06006DE8 RID: 28136 RVA: 0x00235D78 File Offset: 0x00233F78
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

		// Token: 0x06006DE9 RID: 28137 RVA: 0x00235D88 File Offset: 0x00233F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelMessageEvent()
		{
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00235D98 File Offset: 0x00233F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelMessageEvent(ChatChannelMessageEvent other)
		{
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00235DA8 File Offset: 0x00233FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelMessageEvent Clone()
		{
			return null;
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06006DEC RID: 28140 RVA: 0x00235DB8 File Offset: 0x00233FB8
		// (set) Token: 0x06006DED RID: 28141 RVA: 0x00235DC8 File Offset: 0x00233FC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Content
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

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06006DEE RID: 28142 RVA: 0x00235DD8 File Offset: 0x00233FD8
		// (set) Token: 0x06006DEF RID: 28143 RVA: 0x00235DEC File Offset: 0x00233FEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Channel Channel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Channel)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06006DF0 RID: 28144 RVA: 0x00235DFC File Offset: 0x00233FFC
		// (set) Token: 0x06006DF1 RID: 28145 RVA: 0x00235E0C File Offset: 0x0023400C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Date
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

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06006DF2 RID: 28146 RVA: 0x00235E1C File Offset: 0x0023401C
		// (set) Token: 0x06006DF3 RID: 28147 RVA: 0x00235E2C File Offset: 0x0023402C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SenderCharacterId
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

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x00235E3C File Offset: 0x0023403C
		// (set) Token: 0x06006DF5 RID: 28149 RVA: 0x00235E4C File Offset: 0x0023404C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SenderAccountId
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

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06006DF6 RID: 28150 RVA: 0x00235E5C File Offset: 0x0023405C
		// (set) Token: 0x06006DF7 RID: 28151 RVA: 0x00235E6C File Offset: 0x0023406C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderPrefix
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

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06006DF8 RID: 28152 RVA: 0x00235E7C File Offset: 0x0023407C
		// (set) Token: 0x06006DF9 RID: 28153 RVA: 0x00235E8C File Offset: 0x0023408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SenderName
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

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06006DFA RID: 28154 RVA: 0x00235E9C File Offset: 0x0023409C
		// (set) Token: 0x06006DFB RID: 28155 RVA: 0x00235EAC File Offset: 0x002340AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool FromAdmin
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

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06006DFC RID: 28156 RVA: 0x00235EBC File Offset: 0x002340BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Object
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06006DFD RID: 28157 RVA: 0x00235ECC File Offset: 0x002340CC
		// (set) Token: 0x06006DFE RID: 28158 RVA: 0x00235EDC File Offset: 0x002340DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OriginServerId
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

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x00235EEC File Offset: 0x002340EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasOriginServerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x00235EFC File Offset: 0x002340FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearOriginServerId()
		{
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x00235F0C File Offset: 0x0023410C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x00235F1C File Offset: 0x0023411C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChatChannelMessageEvent other)
		{
			return true;
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x00235F2C File Offset: 0x0023412C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x00235F3C File Offset: 0x0023413C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x00235F4C File Offset: 0x0023414C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x00235F5C File Offset: 0x0023415C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x00235F6C File Offset: 0x0023416C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x00235F7C File Offset: 0x0023417C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChatChannelMessageEvent other)
		{
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x00235F8C File Offset: 0x0023418C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x00235F9C File Offset: 0x0023419C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x00235FAC File Offset: 0x002341AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatChannelMessageEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ChatChannelMessageEvent._parser = new MessageParser<ChatChannelMessageEvent>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 6;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					ChatChannelMessageEvent._repeated_object_codec = FieldCodec.ForMessage<ObjectItemInventory>(74U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
					num2 = 5;
					continue;
				case 5:
					ChatChannelMessageEvent.OriginServerIdDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x002360B0 File Offset: 0x002342B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aLcqJdJAbInEkpyNFHkK()
		{
			return true;
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x002360B8 File Offset: 0x002342B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChatChannelMessageEvent inScsSJAiEG7N1ogDWnB()
		{
			return null;
		}

		// Token: 0x0400266E RID: 9838
		private static readonly MessageParser<ChatChannelMessageEvent> _parser;

		// Token: 0x0400266F RID: 9839
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002670 RID: 9840
		private int _hasBits0;

		// Token: 0x04002671 RID: 9841
		public const int ContentFieldNumber = 1;

		// Token: 0x04002672 RID: 9842
		private string content_;

		// Token: 0x04002673 RID: 9843
		public const int ChannelFieldNumber = 2;

		// Token: 0x04002674 RID: 9844
		private Channel channel_;

		// Token: 0x04002675 RID: 9845
		public const int DateFieldNumber = 3;

		// Token: 0x04002676 RID: 9846
		private string date_;

		// Token: 0x04002677 RID: 9847
		public const int SenderCharacterIdFieldNumber = 4;

		// Token: 0x04002678 RID: 9848
		private long senderCharacterId_;

		// Token: 0x04002679 RID: 9849
		public const int SenderAccountIdFieldNumber = 5;

		// Token: 0x0400267A RID: 9850
		private long senderAccountId_;

		// Token: 0x0400267B RID: 9851
		public const int SenderPrefixFieldNumber = 6;

		// Token: 0x0400267C RID: 9852
		private string senderPrefix_;

		// Token: 0x0400267D RID: 9853
		public const int SenderNameFieldNumber = 7;

		// Token: 0x0400267E RID: 9854
		private string senderName_;

		// Token: 0x0400267F RID: 9855
		public const int FromAdminFieldNumber = 8;

		// Token: 0x04002680 RID: 9856
		private bool fromAdmin_;

		// Token: 0x04002681 RID: 9857
		public const int ObjectFieldNumber = 9;

		// Token: 0x04002682 RID: 9858
		private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

		// Token: 0x04002683 RID: 9859
		private readonly RepeatedField<ObjectItemInventory> object_;

		// Token: 0x04002684 RID: 9860
		public const int OriginServerIdFieldNumber = 10;

		// Token: 0x04002685 RID: 9861
		private static readonly int OriginServerIdDefaultValue;

		// Token: 0x04002686 RID: 9862
		private int originServerId_;

		// Token: 0x04002687 RID: 9863
		private static ChatChannelMessageEvent wWK5skJAYCVJg1ooMc87;
	}
}
