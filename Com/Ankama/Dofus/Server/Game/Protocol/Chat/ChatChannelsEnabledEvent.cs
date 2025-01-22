using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008E0 RID: 2272
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChatChannelsEnabledEvent : IMessage<ChatChannelsEnabledEvent>, IMessage, IEquatable<ChatChannelsEnabledEvent>, IDeepCloneable<ChatChannelsEnabledEvent>, IBufferMessage
	{
		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06006E68 RID: 28264 RVA: 0x00236794 File Offset: 0x00234994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChatChannelsEnabledEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06006E69 RID: 28265 RVA: 0x002367A4 File Offset: 0x002349A4
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

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06006E6A RID: 28266 RVA: 0x002367B4 File Offset: 0x002349B4
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

		// Token: 0x06006E6B RID: 28267 RVA: 0x002367C4 File Offset: 0x002349C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelsEnabledEvent()
		{
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x002367D4 File Offset: 0x002349D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelsEnabledEvent(ChatChannelsEnabledEvent other)
		{
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x002367E4 File Offset: 0x002349E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatChannelsEnabledEvent Clone()
		{
			return null;
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x002367F4 File Offset: 0x002349F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Channel> ActiveChannels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x00236804 File Offset: 0x00234A04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Channel> DisabledChannels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x00236814 File Offset: 0x00234A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x00236824 File Offset: 0x00234A24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChatChannelsEnabledEvent other)
		{
			return true;
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x00236834 File Offset: 0x00234A34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x00236844 File Offset: 0x00234A44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x00236854 File Offset: 0x00234A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x00236864 File Offset: 0x00234A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x00236874 File Offset: 0x00234A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x00236884 File Offset: 0x00234A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChatChannelsEnabledEvent other)
		{
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x00236894 File Offset: 0x00234A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x002368A4 File Offset: 0x00234AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x002368B4 File Offset: 0x00234AB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatChannelsEnabledEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						continue;
					case 2:
						ChatChannelsEnabledEvent._parser = new MessageParser<ChatChannelsEnabledEvent>(() => null);
						num2 = 4;
						continue;
					case 3:
						return;
					case 4:
						ChatChannelsEnabledEvent._repeated_activeChannels_codec = FieldCodec.ForEnum<Channel>(10U, (Channel x) => 0, (int x) => (Channel)null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 6:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 5;
						continue;
					}
					break;
				}
				IL_EA:
				ChatChannelsEnabledEvent._repeated_disabledChannels_codec = FieldCodec.ForEnum<Channel>(18U, (Channel x) => 0, (int x) => (Channel)null);
				num = 3;
				continue;
				goto IL_EA;
			}
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x002369F8 File Offset: 0x00234BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bnEag8JBnFwOgSGuPEgv()
		{
			return true;
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x00236A00 File Offset: 0x00234C00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChatChannelsEnabledEvent rMmxbjJBm1v49dTbwPlw()
		{
			return null;
		}

		// Token: 0x040026B1 RID: 9905
		private static readonly MessageParser<ChatChannelsEnabledEvent> _parser;

		// Token: 0x040026B2 RID: 9906
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026B3 RID: 9907
		public const int ActiveChannelsFieldNumber = 1;

		// Token: 0x040026B4 RID: 9908
		private static readonly FieldCodec<Channel> _repeated_activeChannels_codec;

		// Token: 0x040026B5 RID: 9909
		private readonly RepeatedField<Channel> activeChannels_;

		// Token: 0x040026B6 RID: 9910
		public const int DisabledChannelsFieldNumber = 2;

		// Token: 0x040026B7 RID: 9911
		private static readonly FieldCodec<Channel> _repeated_disabledChannels_codec;

		// Token: 0x040026B8 RID: 9912
		private readonly RepeatedField<Channel> disabledChannels_;

		// Token: 0x040026B9 RID: 9913
		internal static ChatChannelsEnabledEvent kjbrRwJBfGQxHp5ATMpH;
	}
}
