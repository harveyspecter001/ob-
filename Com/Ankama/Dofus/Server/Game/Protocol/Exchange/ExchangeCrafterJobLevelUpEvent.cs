using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200079F RID: 1951
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeCrafterJobLevelUpEvent : IMessage<ExchangeCrafterJobLevelUpEvent>, IMessage, IEquatable<ExchangeCrafterJobLevelUpEvent>, IDeepCloneable<ExchangeCrafterJobLevelUpEvent>, IBufferMessage
	{
		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06005FA4 RID: 24484 RVA: 0x0021EC38 File Offset: 0x0021CE38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeCrafterJobLevelUpEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06005FA5 RID: 24485 RVA: 0x0021EC48 File Offset: 0x0021CE48
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

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06005FA6 RID: 24486 RVA: 0x0021EC58 File Offset: 0x0021CE58
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

		// Token: 0x06005FA7 RID: 24487 RVA: 0x0021EC68 File Offset: 0x0021CE68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCrafterJobLevelUpEvent()
		{
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x0021EC78 File Offset: 0x0021CE78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCrafterJobLevelUpEvent(ExchangeCrafterJobLevelUpEvent other)
		{
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x0021EC88 File Offset: 0x0021CE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCrafterJobLevelUpEvent Clone()
		{
			return null;
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06005FAA RID: 24490 RVA: 0x0021EC98 File Offset: 0x0021CE98
		// (set) Token: 0x06005FAB RID: 24491 RVA: 0x0021ECA8 File Offset: 0x0021CEA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CrafterJobLevel
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

		// Token: 0x06005FAC RID: 24492 RVA: 0x0021ECB8 File Offset: 0x0021CEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x0021ECC8 File Offset: 0x0021CEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeCrafterJobLevelUpEvent other)
		{
			return true;
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x0021ECD8 File Offset: 0x0021CED8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x0021ECE8 File Offset: 0x0021CEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x0021ECF8 File Offset: 0x0021CEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x0021ED08 File Offset: 0x0021CF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x0021ED18 File Offset: 0x0021CF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x0021ED28 File Offset: 0x0021CF28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeCrafterJobLevelUpEvent other)
		{
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x0021ED38 File Offset: 0x0021CF38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x0021ED48 File Offset: 0x0021CF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x0021ED58 File Offset: 0x0021CF58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeCrafterJobLevelUpEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ExchangeCrafterJobLevelUpEvent._parser = new MessageParser<ExchangeCrafterJobLevelUpEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x0021EE3C File Offset: 0x0021D03C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool COoeb6OqUdsBRXhrs8n4()
		{
			return true;
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x0021EE44 File Offset: 0x0021D044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeCrafterJobLevelUpEvent lTxSPOOqvUVGE1DhjLHw()
		{
			return null;
		}

		// Token: 0x040021A1 RID: 8609
		private static readonly MessageParser<ExchangeCrafterJobLevelUpEvent> _parser;

		// Token: 0x040021A2 RID: 8610
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021A3 RID: 8611
		public const int CrafterJobLevelFieldNumber = 1;

		// Token: 0x040021A4 RID: 8612
		private int crafterJobLevel_;

		// Token: 0x040021A5 RID: 8613
		private static ExchangeCrafterJobLevelUpEvent VAN39WOqcCvEEs8s8FyI;
	}
}
