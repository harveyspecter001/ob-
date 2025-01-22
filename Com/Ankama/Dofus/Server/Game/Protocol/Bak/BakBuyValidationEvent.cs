using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BF2 RID: 3058
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakBuyValidationEvent : IMessage<BakBuyValidationEvent>, IMessage, IEquatable<BakBuyValidationEvent>, IDeepCloneable<BakBuyValidationEvent>, IBufferMessage
	{
		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06009314 RID: 37652 RVA: 0x0027287C File Offset: 0x00270A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakBuyValidationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x0027288C File Offset: 0x00270A8C
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

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06009316 RID: 37654 RVA: 0x0027289C File Offset: 0x00270A9C
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

		// Token: 0x06009317 RID: 37655 RVA: 0x002728AC File Offset: 0x00270AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBuyValidationEvent()
		{
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x002728BC File Offset: 0x00270ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBuyValidationEvent(BakBuyValidationEvent other)
		{
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x002728CC File Offset: 0x00270ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakBuyValidationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x0600931A RID: 37658 RVA: 0x002728DC File Offset: 0x00270ADC
		// (set) Token: 0x0600931B RID: 37659 RVA: 0x002728EC File Offset: 0x00270AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BakTransactionValidationEvent TransactionValidation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x0600931C RID: 37660 RVA: 0x002728FC File Offset: 0x00270AFC
		// (set) Token: 0x0600931D RID: 37661 RVA: 0x0027290C File Offset: 0x00270B0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Amount
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

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x0600931E RID: 37662 RVA: 0x0027291C File Offset: 0x00270B1C
		// (set) Token: 0x0600931F RID: 37663 RVA: 0x0027292C File Offset: 0x00270B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Email
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x0027293C File Offset: 0x00270B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x0027294C File Offset: 0x00270B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakBuyValidationEvent other)
		{
			return true;
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x0027295C File Offset: 0x00270B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009323 RID: 37667 RVA: 0x0027296C File Offset: 0x00270B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009324 RID: 37668 RVA: 0x0027297C File Offset: 0x00270B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x0027298C File Offset: 0x00270B8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009326 RID: 37670 RVA: 0x0027299C File Offset: 0x00270B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009327 RID: 37671 RVA: 0x002729AC File Offset: 0x00270BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakBuyValidationEvent other)
		{
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x002729BC File Offset: 0x00270BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009329 RID: 37673 RVA: 0x002729CC File Offset: 0x00270BCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600932A RID: 37674 RVA: 0x002729DC File Offset: 0x00270BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakBuyValidationEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					BakBuyValidationEvent._parser = new MessageParser<BakBuyValidationEvent>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x00272AA8 File Offset: 0x00270CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nyc3m0JEh7VmaUvw7mx0()
		{
			return true;
		}

		// Token: 0x0600932C RID: 37676 RVA: 0x00272AB0 File Offset: 0x00270CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakBuyValidationEvent AwYOlyJErpNT9dv0x2Dd()
		{
			return null;
		}

		// Token: 0x040036CA RID: 14026
		private static readonly MessageParser<BakBuyValidationEvent> _parser;

		// Token: 0x040036CB RID: 14027
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036CC RID: 14028
		public const int TransactionValidationFieldNumber = 1;

		// Token: 0x040036CD RID: 14029
		private BakTransactionValidationEvent transactionValidation_;

		// Token: 0x040036CE RID: 14030
		public const int AmountFieldNumber = 2;

		// Token: 0x040036CF RID: 14031
		private long amount_;

		// Token: 0x040036D0 RID: 14032
		public const int EmailFieldNumber = 3;

		// Token: 0x040036D1 RID: 14033
		private string email_;

		// Token: 0x040036D2 RID: 14034
		internal static BakBuyValidationEvent QAeXyuJEWPGJOakdLjUA;
	}
}
