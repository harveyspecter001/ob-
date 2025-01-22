using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account
{
	// Token: 0x02000DE0 RID: 3552
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AccountInformationUpdateEvent : IMessage<AccountInformationUpdateEvent>, IMessage, IEquatable<AccountInformationUpdateEvent>, IDeepCloneable<AccountInformationUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x0600AB20 RID: 43808 RVA: 0x0029A008 File Offset: 0x00298208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AccountInformationUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x0600AB21 RID: 43809 RVA: 0x0029A018 File Offset: 0x00298218
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

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x0600AB22 RID: 43810 RVA: 0x0029A028 File Offset: 0x00298228
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

		// Token: 0x0600AB23 RID: 43811 RVA: 0x0029A038 File Offset: 0x00298238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountInformationUpdateEvent()
		{
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x0029A048 File Offset: 0x00298248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountInformationUpdateEvent(AccountInformationUpdateEvent other)
		{
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x0029A058 File Offset: 0x00298258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountInformationUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x0600AB26 RID: 43814 RVA: 0x0029A068 File Offset: 0x00298268
		// (set) Token: 0x0600AB27 RID: 43815 RVA: 0x0029A078 File Offset: 0x00298278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SubscriptionEndDate
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

		// Token: 0x0600AB28 RID: 43816 RVA: 0x0029A088 File Offset: 0x00298288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x0029A098 File Offset: 0x00298298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AccountInformationUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x0029A0A8 File Offset: 0x002982A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x0029A0B8 File Offset: 0x002982B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x0029A0C8 File Offset: 0x002982C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AB2D RID: 43821 RVA: 0x0029A0D8 File Offset: 0x002982D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x0029A0E8 File Offset: 0x002982E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x0029A0F8 File Offset: 0x002982F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AccountInformationUpdateEvent other)
		{
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x0029A108 File Offset: 0x00298308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x0029A118 File Offset: 0x00298318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x0029A128 File Offset: 0x00298328
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AccountInformationUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					AccountInformationUpdateEvent._parser = new MessageParser<AccountInformationUpdateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600AB33 RID: 43827 RVA: 0x0029A1F4 File Offset: 0x002983F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JgXEK9JcusxoRHvQByen()
		{
			return true;
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x0029A1FC File Offset: 0x002983FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AccountInformationUpdateEvent CjZwqgJc86mgpTSuqsGk()
		{
			return null;
		}

		// Token: 0x04003ED1 RID: 16081
		private static readonly MessageParser<AccountInformationUpdateEvent> _parser;

		// Token: 0x04003ED2 RID: 16082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ED3 RID: 16083
		public const int SubscriptionEndDateFieldNumber = 1;

		// Token: 0x04003ED4 RID: 16084
		private long subscriptionEndDate_;

		// Token: 0x04003ED5 RID: 16085
		internal static AccountInformationUpdateEvent g0WsQ0JcMaYdDNmLfUv2;
	}
}
