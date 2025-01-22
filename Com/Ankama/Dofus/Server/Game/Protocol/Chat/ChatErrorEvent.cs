using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat
{
	// Token: 0x020008D8 RID: 2264
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChatErrorEvent : IMessage<ChatErrorEvent>, IMessage, IEquatable<ChatErrorEvent>, IDeepCloneable<ChatErrorEvent>, IBufferMessage
	{
		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06006E13 RID: 28179 RVA: 0x002360C0 File Offset: 0x002342C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChatErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06006E14 RID: 28180 RVA: 0x002360D0 File Offset: 0x002342D0
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

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06006E15 RID: 28181 RVA: 0x002360E0 File Offset: 0x002342E0
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

		// Token: 0x06006E16 RID: 28182 RVA: 0x002360F0 File Offset: 0x002342F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatErrorEvent()
		{
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x00236100 File Offset: 0x00234300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatErrorEvent(ChatErrorEvent other)
		{
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x00236110 File Offset: 0x00234310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06006E19 RID: 28185 RVA: 0x00236120 File Offset: 0x00234320
		// (set) Token: 0x06006E1A RID: 28186 RVA: 0x00236134 File Offset: 0x00234334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ChatErrorEvent.Types.Error Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ChatErrorEvent.Types.Error)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x00236144 File Offset: 0x00234344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x00236154 File Offset: 0x00234354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChatErrorEvent other)
		{
			return true;
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x00236164 File Offset: 0x00234364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x00236174 File Offset: 0x00234374
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x00236184 File Offset: 0x00234384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x00236194 File Offset: 0x00234394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x002361A4 File Offset: 0x002343A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x002361B4 File Offset: 0x002343B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChatErrorEvent other)
		{
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x002361C4 File Offset: 0x002343C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x002361D4 File Offset: 0x002343D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x002361E4 File Offset: 0x002343E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChatErrorEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					ChatErrorEvent._parser = new MessageParser<ChatErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x002362DC File Offset: 0x002344DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NoqSlwJASRCjqlFktEVa()
		{
			return true;
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x002362E4 File Offset: 0x002344E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChatErrorEvent AwNREgJAM0I1SYKT1e2U()
		{
			return null;
		}

		// Token: 0x0400268A RID: 9866
		private static readonly MessageParser<ChatErrorEvent> _parser;

		// Token: 0x0400268B RID: 9867
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400268C RID: 9868
		public const int ErrorFieldNumber = 1;

		// Token: 0x0400268D RID: 9869
		private ChatErrorEvent.Types.Error error_;

		// Token: 0x0400268E RID: 9870
		internal static ChatErrorEvent LOMBoTJAPmsmOXDREhjw;

		// Token: 0x020008D9 RID: 2265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06006E28 RID: 28200 RVA: 0x002D98CC File Offset: 0x002D7ACC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020008DA RID: 2266
			public enum Error
			{
				// Token: 0x04002690 RID: 9872
				[OriginalName("UNKNOWN")]
				Unknown,
				// Token: 0x04002691 RID: 9873
				[OriginalName("RECEIVER_NOT_FOUND")]
				ReceiverNotFound,
				// Token: 0x04002692 RID: 9874
				[OriginalName("INTERIOR_MONOLOGUE")]
				InteriorMonologue,
				// Token: 0x04002693 RID: 9875
				[OriginalName("NO_GUILD")]
				NoGuild,
				// Token: 0x04002694 RID: 9876
				[OriginalName("NO_PARTY")]
				NoParty,
				// Token: 0x04002695 RID: 9877
				[OriginalName("ALLIANCE")]
				Alliance,
				// Token: 0x04002696 RID: 9878
				[OriginalName("INVALID_MAP")]
				InvalidMap,
				// Token: 0x04002697 RID: 9879
				[OriginalName("NO_PARTY_ARENA")]
				NoPartyArena,
				// Token: 0x04002698 RID: 9880
				[OriginalName("NO_TEAM")]
				NoTeam,
				// Token: 0x04002699 RID: 9881
				[OriginalName("MALFORMED_CONTENT")]
				MalformedContent,
				// Token: 0x0400269A RID: 9882
				[OriginalName("NO_EXCHANGE")]
				NoExchange
			}
		}
	}
}
