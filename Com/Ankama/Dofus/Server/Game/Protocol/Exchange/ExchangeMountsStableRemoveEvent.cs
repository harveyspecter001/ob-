using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200078F RID: 1935
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountsStableRemoveEvent : IMessage<ExchangeMountsStableRemoveEvent>, IMessage, IEquatable<ExchangeMountsStableRemoveEvent>, IDeepCloneable<ExchangeMountsStableRemoveEvent>, IBufferMessage
	{
		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06005EE7 RID: 24295 RVA: 0x0021DD28 File Offset: 0x0021BF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMountsStableRemoveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x0021DD38 File Offset: 0x0021BF38
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

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x0021DD48 File Offset: 0x0021BF48
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

		// Token: 0x06005EEA RID: 24298 RVA: 0x0021DD58 File Offset: 0x0021BF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsStableRemoveEvent()
		{
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x0021DD68 File Offset: 0x0021BF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsStableRemoveEvent(ExchangeMountsStableRemoveEvent other)
		{
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x0021DD78 File Offset: 0x0021BF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountsStableRemoveEvent Clone()
		{
			return null;
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x0021DD88 File Offset: 0x0021BF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MountsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x0021DD98 File Offset: 0x0021BF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x0021DDA8 File Offset: 0x0021BFA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountsStableRemoveEvent other)
		{
			return true;
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x0021DDB8 File Offset: 0x0021BFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x0021DDC8 File Offset: 0x0021BFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x0021DDD8 File Offset: 0x0021BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x0021DDE8 File Offset: 0x0021BFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x0021DDF8 File Offset: 0x0021BFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x0021DE08 File Offset: 0x0021C008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountsStableRemoveEvent other)
		{
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x0021DE18 File Offset: 0x0021C018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x0021DE28 File Offset: 0x0021C028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x0021DE38 File Offset: 0x0021C038
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountsStableRemoveEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
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
					continue;
				case 4:
					ExchangeMountsStableRemoveEvent._parser = new MessageParser<ExchangeMountsStableRemoveEvent>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 5:
					ExchangeMountsStableRemoveEvent._repeated_mountsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x0021DF50 File Offset: 0x0021C150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D9DIJKOq3xyDBguIP0eg()
		{
			return true;
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x0021DF58 File Offset: 0x0021C158
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountsStableRemoveEvent r3jq4lOqRGZqTQv2WEBW()
		{
			return null;
		}

		// Token: 0x04002161 RID: 8545
		private static readonly MessageParser<ExchangeMountsStableRemoveEvent> _parser;

		// Token: 0x04002162 RID: 8546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002163 RID: 8547
		public const int MountsIdFieldNumber = 1;

		// Token: 0x04002164 RID: 8548
		private static readonly FieldCodec<int> _repeated_mountsId_codec;

		// Token: 0x04002165 RID: 8549
		private readonly RepeatedField<int> mountsId_;

		// Token: 0x04002166 RID: 8550
		internal static ExchangeMountsStableRemoveEvent px99A3OqeXtpQgBQv6HM;
	}
}
