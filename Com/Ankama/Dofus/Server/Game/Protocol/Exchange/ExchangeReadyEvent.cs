using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000749 RID: 1865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeReadyEvent : IMessage<ExchangeReadyEvent>, IMessage, IEquatable<ExchangeReadyEvent>, IDeepCloneable<ExchangeReadyEvent>, IBufferMessage
	{
		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x0021A240 File Offset: 0x00218440
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeReadyEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x0021A250 File Offset: 0x00218450
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

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x0021A260 File Offset: 0x00218460
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

		// Token: 0x06005B99 RID: 23449 RVA: 0x0021A270 File Offset: 0x00218470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReadyEvent()
		{
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x0021A280 File Offset: 0x00218480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReadyEvent(ExchangeReadyEvent other)
		{
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x0021A290 File Offset: 0x00218490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReadyEvent Clone()
		{
			return null;
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06005B9C RID: 23452 RVA: 0x0021A2A0 File Offset: 0x002184A0
		// (set) Token: 0x06005B9D RID: 23453 RVA: 0x0021A2B0 File Offset: 0x002184B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CharacterId
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

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x0021A2C0 File Offset: 0x002184C0
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x0021A2D0 File Offset: 0x002184D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ready
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

		// Token: 0x06005BA0 RID: 23456 RVA: 0x0021A2E0 File Offset: 0x002184E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x0021A2F0 File Offset: 0x002184F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeReadyEvent other)
		{
			return true;
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x0021A300 File Offset: 0x00218500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x0021A310 File Offset: 0x00218510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x0021A320 File Offset: 0x00218520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x0021A330 File Offset: 0x00218530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x0021A340 File Offset: 0x00218540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x0021A350 File Offset: 0x00218550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeReadyEvent other)
		{
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x0021A360 File Offset: 0x00218560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x0021A370 File Offset: 0x00218570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x0021A380 File Offset: 0x00218580
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeReadyEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					ExchangeReadyEvent._parser = new MessageParser<ExchangeReadyEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x0021A478 File Offset: 0x00218678
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UcBSViO8ijaotHcxXCpd()
		{
			return true;
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x0021A480 File Offset: 0x00218680
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeReadyEvent gx3DXaO8P3RgoB4qJt4f()
		{
			return null;
		}

		// Token: 0x04002018 RID: 8216
		private static readonly MessageParser<ExchangeReadyEvent> _parser;

		// Token: 0x04002019 RID: 8217
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400201A RID: 8218
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x0400201B RID: 8219
		private long characterId_;

		// Token: 0x0400201C RID: 8220
		public const int ReadyFieldNumber = 2;

		// Token: 0x0400201D RID: 8221
		private bool ready_;

		// Token: 0x0400201E RID: 8222
		internal static ExchangeReadyEvent Em6YVxO8bQHBk1iGuMqV;
	}
}
