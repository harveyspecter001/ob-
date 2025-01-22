using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000795 RID: 1941
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeItemAutoCraftStoppedEvent : IMessage<ExchangeItemAutoCraftStoppedEvent>, IMessage, IEquatable<ExchangeItemAutoCraftStoppedEvent>, IDeepCloneable<ExchangeItemAutoCraftStoppedEvent>, IBufferMessage
	{
		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06005F37 RID: 24375 RVA: 0x0021E3C4 File Offset: 0x0021C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeItemAutoCraftStoppedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06005F38 RID: 24376 RVA: 0x0021E3D4 File Offset: 0x0021C5D4
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

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06005F39 RID: 24377 RVA: 0x0021E3E4 File Offset: 0x0021C5E4
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

		// Token: 0x06005F3A RID: 24378 RVA: 0x0021E3F4 File Offset: 0x0021C5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeItemAutoCraftStoppedEvent()
		{
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x0021E404 File Offset: 0x0021C604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeItemAutoCraftStoppedEvent(ExchangeItemAutoCraftStoppedEvent other)
		{
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x0021E414 File Offset: 0x0021C614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeItemAutoCraftStoppedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06005F3D RID: 24381 RVA: 0x0021E424 File Offset: 0x0021C624
		// (set) Token: 0x06005F3E RID: 24382 RVA: 0x0021E438 File Offset: 0x0021C638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeItemAutoCraftStoppedEvent.Types.ExchangeReplayStopReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeItemAutoCraftStoppedEvent.Types.ExchangeReplayStopReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x0021E448 File Offset: 0x0021C648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x0021E458 File Offset: 0x0021C658
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeItemAutoCraftStoppedEvent other)
		{
			return true;
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x0021E468 File Offset: 0x0021C668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x0021E478 File Offset: 0x0021C678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x0021E488 File Offset: 0x0021C688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x0021E498 File Offset: 0x0021C698
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x0021E4A8 File Offset: 0x0021C6A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x0021E4B8 File Offset: 0x0021C6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeItemAutoCraftStoppedEvent other)
		{
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x0021E4C8 File Offset: 0x0021C6C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x0021E4D8 File Offset: 0x0021C6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x0021E4E8 File Offset: 0x0021C6E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeItemAutoCraftStoppedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					ExchangeItemAutoCraftStoppedEvent._parser = new MessageParser<ExchangeItemAutoCraftStoppedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x0021E5B4 File Offset: 0x0021C7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nXFijPOq2Wg9wwS3JmR2()
		{
			return true;
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x0021E5BC File Offset: 0x0021C7BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeItemAutoCraftStoppedEvent zwKwj8OqET912MIvPnRY()
		{
			return null;
		}

		// Token: 0x0400217C RID: 8572
		private static readonly MessageParser<ExchangeItemAutoCraftStoppedEvent> _parser;

		// Token: 0x0400217D RID: 8573
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400217E RID: 8574
		public const int ReasonFieldNumber = 1;

		// Token: 0x0400217F RID: 8575
		private ExchangeItemAutoCraftStoppedEvent.Types.ExchangeReplayStopReason reason_;

		// Token: 0x04002180 RID: 8576
		internal static ExchangeItemAutoCraftStoppedEvent jmllEBOq9jOPPurw1oby;

		// Token: 0x02000796 RID: 1942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06005F4C RID: 24396 RVA: 0x002D2120 File Offset: 0x002D0320
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000797 RID: 1943
			public enum ExchangeReplayStopReason
			{
				// Token: 0x04002182 RID: 8578
				[OriginalName("OK")]
				Ok,
				// Token: 0x04002183 RID: 8579
				[OriginalName("USER")]
				User,
				// Token: 0x04002184 RID: 8580
				[OriginalName("MISSING_RESSOURCE")]
				MissingRessource,
				// Token: 0x04002185 RID: 8581
				[OriginalName("IMPOSSIBLE_MODIFICATION")]
				ImpossibleModification
			}
		}
	}
}
