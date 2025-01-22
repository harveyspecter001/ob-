using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000735 RID: 1845
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseBuyResultEvent : IMessage<ExchangeBidHouseBuyResultEvent>, IMessage, IEquatable<ExchangeBidHouseBuyResultEvent>, IDeepCloneable<ExchangeBidHouseBuyResultEvent>, IBufferMessage
	{
		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06005A7E RID: 23166 RVA: 0x00218B84 File Offset: 0x00216D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseBuyResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06005A7F RID: 23167 RVA: 0x00218B94 File Offset: 0x00216D94
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

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x00218BA4 File Offset: 0x00216DA4
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

		// Token: 0x06005A81 RID: 23169 RVA: 0x00218BB4 File Offset: 0x00216DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseBuyResultEvent()
		{
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x00218BC4 File Offset: 0x00216DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseBuyResultEvent(ExchangeBidHouseBuyResultEvent other)
		{
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x00218BD4 File Offset: 0x00216DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseBuyResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x00218BE4 File Offset: 0x00216DE4
		// (set) Token: 0x06005A85 RID: 23173 RVA: 0x00218BF4 File Offset: 0x00216DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BidItemUid
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

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x00218C04 File Offset: 0x00216E04
		// (set) Token: 0x06005A87 RID: 23175 RVA: 0x00218C14 File Offset: 0x00216E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Bought
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

		// Token: 0x06005A88 RID: 23176 RVA: 0x00218C24 File Offset: 0x00216E24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x00218C34 File Offset: 0x00216E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseBuyResultEvent other)
		{
			return true;
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00218C44 File Offset: 0x00216E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x00218C54 File Offset: 0x00216E54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00218C64 File Offset: 0x00216E64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00218C74 File Offset: 0x00216E74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00218C84 File Offset: 0x00216E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00218C94 File Offset: 0x00216E94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseBuyResultEvent other)
		{
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00218CA4 File Offset: 0x00216EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00218CB4 File Offset: 0x00216EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00218CC4 File Offset: 0x00216EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseBuyResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ExchangeBidHouseBuyResultEvent._parser = new MessageParser<ExchangeBidHouseBuyResultEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00218DBC File Offset: 0x00216FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool s2brm5O8KtauOdX6slUC()
		{
			return true;
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00218DC4 File Offset: 0x00216FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseBuyResultEvent rhXRFQO8IeYH8bP1ytn7()
		{
			return null;
		}

		// Token: 0x04001FB2 RID: 8114
		private static readonly MessageParser<ExchangeBidHouseBuyResultEvent> _parser;

		// Token: 0x04001FB3 RID: 8115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB4 RID: 8116
		public const int BidItemUidFieldNumber = 1;

		// Token: 0x04001FB5 RID: 8117
		private int bidItemUid_;

		// Token: 0x04001FB6 RID: 8118
		public const int BoughtFieldNumber = 2;

		// Token: 0x04001FB7 RID: 8119
		private bool bought_;

		// Token: 0x04001FB8 RID: 8120
		private static ExchangeBidHouseBuyResultEvent tkeyASO8jV6qACVsjxYE;
	}
}
