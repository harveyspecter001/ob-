using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000799 RID: 1945
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeCraftStartedEvent : IMessage<ExchangeCraftStartedEvent>, IMessage, IEquatable<ExchangeCraftStartedEvent>, IDeepCloneable<ExchangeCraftStartedEvent>, IBufferMessage
	{
		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06005F52 RID: 24402 RVA: 0x0021E5C4 File Offset: 0x0021C7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeCraftStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06005F53 RID: 24403 RVA: 0x0021E5D4 File Offset: 0x0021C7D4
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

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x0021E5E4 File Offset: 0x0021C7E4
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

		// Token: 0x06005F55 RID: 24405 RVA: 0x0021E5F4 File Offset: 0x0021C7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftStartedEvent()
		{
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x0021E604 File Offset: 0x0021C804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftStartedEvent(ExchangeCraftStartedEvent other)
		{
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x0021E614 File Offset: 0x0021C814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06005F58 RID: 24408 RVA: 0x0021E624 File Offset: 0x0021C824
		// (set) Token: 0x06005F59 RID: 24409 RVA: 0x0021E634 File Offset: 0x0021C834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06005F5A RID: 24410 RVA: 0x0021E644 File Offset: 0x0021C844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSkillId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x0021E654 File Offset: 0x0021C854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSkillId()
		{
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x0021E664 File Offset: 0x0021C864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x0021E674 File Offset: 0x0021C874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeCraftStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x0021E684 File Offset: 0x0021C884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x0021E694 File Offset: 0x0021C894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x0021E6A4 File Offset: 0x0021C8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x0021E6B4 File Offset: 0x0021C8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x0021E6C4 File Offset: 0x0021C8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005F63 RID: 24419 RVA: 0x0021E6D4 File Offset: 0x0021C8D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeCraftStartedEvent other)
		{
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x0021E6E4 File Offset: 0x0021C8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x0021E6F4 File Offset: 0x0021C8F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x0021E704 File Offset: 0x0021C904
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeCraftStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 2:
					ExchangeCraftStartedEvent.SkillIdDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				case 5:
					ExchangeCraftStartedEvent._parser = new MessageParser<ExchangeCraftStartedEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x0021E810 File Offset: 0x0021CA10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kOXONIOqNfb3saP4hVtc()
		{
			return true;
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x0021E818 File Offset: 0x0021CA18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeCraftStartedEvent cjZp4aOqxoGeiAxmMcj6()
		{
			return null;
		}

		// Token: 0x04002188 RID: 8584
		private static readonly MessageParser<ExchangeCraftStartedEvent> _parser;

		// Token: 0x04002189 RID: 8585
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400218A RID: 8586
		private int _hasBits0;

		// Token: 0x0400218B RID: 8587
		public const int SkillIdFieldNumber = 1;

		// Token: 0x0400218C RID: 8588
		private static readonly int SkillIdDefaultValue;

		// Token: 0x0400218D RID: 8589
		private int skillId_;

		// Token: 0x0400218E RID: 8590
		internal static ExchangeCraftStartedEvent KsmQ74OqXn7j1RNsSqrt;
	}
}
