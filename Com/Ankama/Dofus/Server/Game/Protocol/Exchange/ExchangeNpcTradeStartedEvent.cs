using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000755 RID: 1877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeNpcTradeStartedEvent : IMessage<ExchangeNpcTradeStartedEvent>, IMessage, IEquatable<ExchangeNpcTradeStartedEvent>, IDeepCloneable<ExchangeNpcTradeStartedEvent>, IBufferMessage
	{
		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06005C1D RID: 23581 RVA: 0x0021ACE8 File Offset: 0x00218EE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeNpcTradeStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x0021ACF8 File Offset: 0x00218EF8
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

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06005C1F RID: 23583 RVA: 0x0021AD08 File Offset: 0x00218F08
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

		// Token: 0x06005C20 RID: 23584 RVA: 0x0021AD18 File Offset: 0x00218F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeNpcTradeStartedEvent()
		{
		}

		// Token: 0x06005C21 RID: 23585 RVA: 0x0021AD28 File Offset: 0x00218F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeNpcTradeStartedEvent(ExchangeNpcTradeStartedEvent other)
		{
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x0021AD38 File Offset: 0x00218F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeNpcTradeStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x0021AD48 File Offset: 0x00218F48
		// (set) Token: 0x06005C24 RID: 23588 RVA: 0x0021AD58 File Offset: 0x00218F58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long NpcId
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

		// Token: 0x06005C25 RID: 23589 RVA: 0x0021AD68 File Offset: 0x00218F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x0021AD78 File Offset: 0x00218F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeNpcTradeStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x0021AD88 File Offset: 0x00218F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x0021AD98 File Offset: 0x00218F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x0021ADA8 File Offset: 0x00218FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x0021ADB8 File Offset: 0x00218FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x0021ADC8 File Offset: 0x00218FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x0021ADD8 File Offset: 0x00218FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeNpcTradeStartedEvent other)
		{
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x0021ADE8 File Offset: 0x00218FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x0021ADF8 File Offset: 0x00218FF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x0021AE08 File Offset: 0x00219008
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeNpcTradeStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				ExchangeNpcTradeStartedEvent._parser = new MessageParser<ExchangeNpcTradeStartedEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x0021AF00 File Offset: 0x00219100
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool a4ktFLOZeRrcKAIqCq7Q()
		{
			return true;
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x0021AF08 File Offset: 0x00219108
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeNpcTradeStartedEvent A8cDw3OZ3Z2mb6r44FMF()
		{
			return null;
		}

		// Token: 0x0400204B RID: 8267
		private static readonly MessageParser<ExchangeNpcTradeStartedEvent> _parser;

		// Token: 0x0400204C RID: 8268
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400204D RID: 8269
		public const int NpcIdFieldNumber = 1;

		// Token: 0x0400204E RID: 8270
		private long npcId_;

		// Token: 0x0400204F RID: 8271
		private static ExchangeNpcTradeStartedEvent gIHB9KOZBLxApHVu2Q6i;
	}
}
