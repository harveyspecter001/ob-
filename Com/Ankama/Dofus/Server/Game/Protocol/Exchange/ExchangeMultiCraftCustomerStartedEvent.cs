using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200079D RID: 1949
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMultiCraftCustomerStartedEvent : IMessage<ExchangeMultiCraftCustomerStartedEvent>, IMessage, IEquatable<ExchangeMultiCraftCustomerStartedEvent>, IDeepCloneable<ExchangeMultiCraftCustomerStartedEvent>, IBufferMessage
	{
		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06005F88 RID: 24456 RVA: 0x0021EA1C File Offset: 0x0021CC1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeMultiCraftCustomerStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06005F89 RID: 24457 RVA: 0x0021EA2C File Offset: 0x0021CC2C
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

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06005F8A RID: 24458 RVA: 0x0021EA3C File Offset: 0x0021CC3C
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

		// Token: 0x06005F8B RID: 24459 RVA: 0x0021EA4C File Offset: 0x0021CC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCustomerStartedEvent()
		{
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x0021EA5C File Offset: 0x0021CC5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCustomerStartedEvent(ExchangeMultiCraftCustomerStartedEvent other)
		{
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x0021EA6C File Offset: 0x0021CC6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftCustomerStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06005F8E RID: 24462 RVA: 0x0021EA7C File Offset: 0x0021CC7C
		// (set) Token: 0x06005F8F RID: 24463 RVA: 0x0021EA8C File Offset: 0x0021CC8C
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

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x0021EA9C File Offset: 0x0021CC9C
		// (set) Token: 0x06005F91 RID: 24465 RVA: 0x0021EAAC File Offset: 0x0021CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06005F92 RID: 24466 RVA: 0x0021EABC File Offset: 0x0021CCBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x0021EACC File Offset: 0x0021CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMultiCraftCustomerStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x0021EADC File Offset: 0x0021CCDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x0021EAEC File Offset: 0x0021CCEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x0021EAFC File Offset: 0x0021CCFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x0021EB0C File Offset: 0x0021CD0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x0021EB1C File Offset: 0x0021CD1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x0021EB2C File Offset: 0x0021CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMultiCraftCustomerStartedEvent other)
		{
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x0021EB3C File Offset: 0x0021CD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x0021EB4C File Offset: 0x0021CD4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x0021EB5C File Offset: 0x0021CD5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMultiCraftCustomerStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
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
					ExchangeMultiCraftCustomerStartedEvent._parser = new MessageParser<ExchangeMultiCraftCustomerStartedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x0021EC28 File Offset: 0x0021CE28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool t49yYUOqkm6AxTYWQ1MI()
		{
			return true;
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x0021EC30 File Offset: 0x0021CE30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMultiCraftCustomerStartedEvent MTL6LVOqlp0j8qUkMsjO()
		{
			return null;
		}

		// Token: 0x04002198 RID: 8600
		private static readonly MessageParser<ExchangeMultiCraftCustomerStartedEvent> _parser;

		// Token: 0x04002199 RID: 8601
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400219A RID: 8602
		public const int SkillIdFieldNumber = 1;

		// Token: 0x0400219B RID: 8603
		private int skillId_;

		// Token: 0x0400219C RID: 8604
		public const int CrafterJobLevelFieldNumber = 2;

		// Token: 0x0400219D RID: 8605
		private int crafterJobLevel_;

		// Token: 0x0400219E RID: 8606
		internal static ExchangeMultiCraftCustomerStartedEvent XMyo3VOqIhsodCvthQdQ;
	}
}
