using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200079B RID: 1947
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMultiCraftCrafterStartedEvent : IMessage<ExchangeMultiCraftCrafterStartedEvent>, IMessage, IEquatable<ExchangeMultiCraftCrafterStartedEvent>, IDeepCloneable<ExchangeMultiCraftCrafterStartedEvent>, IBufferMessage
	{
		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x0021E820 File Offset: 0x0021CA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMultiCraftCrafterStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06005F6F RID: 24431 RVA: 0x0021E830 File Offset: 0x0021CA30
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

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x0021E840 File Offset: 0x0021CA40
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

		// Token: 0x06005F71 RID: 24433 RVA: 0x0021E850 File Offset: 0x0021CA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCrafterStartedEvent()
		{
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x0021E860 File Offset: 0x0021CA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCrafterStartedEvent(ExchangeMultiCraftCrafterStartedEvent other)
		{
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x0021E870 File Offset: 0x0021CA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCrafterStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06005F74 RID: 24436 RVA: 0x0021E880 File Offset: 0x0021CA80
		// (set) Token: 0x06005F75 RID: 24437 RVA: 0x0021E890 File Offset: 0x0021CA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
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

		// Token: 0x06005F76 RID: 24438 RVA: 0x0021E8A0 File Offset: 0x0021CAA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x0021E8B0 File Offset: 0x0021CAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMultiCraftCrafterStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x0021E8C0 File Offset: 0x0021CAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x0021E8D0 File Offset: 0x0021CAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x0021E8E0 File Offset: 0x0021CAE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x0021E8F0 File Offset: 0x0021CAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x0021E900 File Offset: 0x0021CB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x0021E910 File Offset: 0x0021CB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMultiCraftCrafterStartedEvent other)
		{
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x0021E920 File Offset: 0x0021CB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x0021E930 File Offset: 0x0021CB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x0021E940 File Offset: 0x0021CB40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMultiCraftCrafterStartedEvent()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ExchangeMultiCraftCrafterStartedEvent._parser = new MessageParser<ExchangeMultiCraftCrafterStartedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x0021EA0C File Offset: 0x0021CC0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UWBYlEOqjnMFRgDwxkDD()
		{
			return true;
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x0021EA14 File Offset: 0x0021CC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMultiCraftCrafterStartedEvent JtcmxrOqKq9SBSf7c3Ko()
		{
			return null;
		}

		// Token: 0x04002191 RID: 8593
		private static readonly MessageParser<ExchangeMultiCraftCrafterStartedEvent> _parser;

		// Token: 0x04002192 RID: 8594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002193 RID: 8595
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04002194 RID: 8596
		private int skillId_;

		// Token: 0x04002195 RID: 8597
		private static ExchangeMultiCraftCrafterStartedEvent xRVwYBOq40CH05gORiNF;
	}
}
