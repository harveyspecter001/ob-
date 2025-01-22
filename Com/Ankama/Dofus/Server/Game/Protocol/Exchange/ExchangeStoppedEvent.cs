using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200074B RID: 1867
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeStoppedEvent : IMessage<ExchangeStoppedEvent>, IMessage, IEquatable<ExchangeStoppedEvent>, IDeepCloneable<ExchangeStoppedEvent>, IBufferMessage
	{
		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x0021A488 File Offset: 0x00218688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeStoppedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06005BB3 RID: 23475 RVA: 0x0021A498 File Offset: 0x00218698
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

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x0021A4A8 File Offset: 0x002186A8
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

		// Token: 0x06005BB5 RID: 23477 RVA: 0x0021A4B8 File Offset: 0x002186B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStoppedEvent()
		{
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x0021A4C8 File Offset: 0x002186C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStoppedEvent(ExchangeStoppedEvent other)
		{
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x0021A4D8 File Offset: 0x002186D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStoppedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x0021A4E8 File Offset: 0x002186E8
		// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x0021A4F8 File Offset: 0x002186F8
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

		// Token: 0x06005BBA RID: 23482 RVA: 0x0021A508 File Offset: 0x00218708
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x0021A518 File Offset: 0x00218718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeStoppedEvent other)
		{
			return true;
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x0021A528 File Offset: 0x00218728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x0021A538 File Offset: 0x00218738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x0021A548 File Offset: 0x00218748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x0021A558 File Offset: 0x00218758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x0021A568 File Offset: 0x00218768
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x0021A578 File Offset: 0x00218778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeStoppedEvent other)
		{
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x0021A588 File Offset: 0x00218788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x0021A598 File Offset: 0x00218798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x0021A5A8 File Offset: 0x002187A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeStoppedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
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
					ExchangeStoppedEvent._parser = new MessageParser<ExchangeStoppedEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x0021A68C File Offset: 0x0021888C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Mr9PyKO8MtESGqbIGlDU()
		{
			return true;
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x0021A694 File Offset: 0x00218894
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeStoppedEvent SWCf1kO8uUW1ZltpTVDA()
		{
			return null;
		}

		// Token: 0x04002021 RID: 8225
		private static readonly MessageParser<ExchangeStoppedEvent> _parser;

		// Token: 0x04002022 RID: 8226
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002023 RID: 8227
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04002024 RID: 8228
		private long characterId_;

		// Token: 0x04002025 RID: 8229
		internal static ExchangeStoppedEvent xYGMWeO8S9ijRl6e97Yr;
	}
}
