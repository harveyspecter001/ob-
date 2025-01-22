using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006CC RID: 1740
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectModifyPricedRequest : IMessage<ExchangeObjectModifyPricedRequest>, IMessage, IEquatable<ExchangeObjectModifyPricedRequest>, IDeepCloneable<ExchangeObjectModifyPricedRequest>, IBufferMessage
	{
		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06005519 RID: 21785 RVA: 0x00211FA8 File Offset: 0x002101A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectModifyPricedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x0600551A RID: 21786 RVA: 0x00211FB8 File Offset: 0x002101B8
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

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x0600551B RID: 21787 RVA: 0x00211FC8 File Offset: 0x002101C8
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

		// Token: 0x0600551C RID: 21788 RVA: 0x00211FD8 File Offset: 0x002101D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectModifyPricedRequest()
		{
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x00211FE8 File Offset: 0x002101E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectModifyPricedRequest(ExchangeObjectModifyPricedRequest other)
		{
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x00211FF8 File Offset: 0x002101F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectModifyPricedRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x00212008 File Offset: 0x00210208
		// (set) Token: 0x06005520 RID: 21792 RVA: 0x00212018 File Offset: 0x00210218
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectUid
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06005521 RID: 21793 RVA: 0x00212028 File Offset: 0x00210228
		// (set) Token: 0x06005522 RID: 21794 RVA: 0x00212038 File Offset: 0x00210238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Quantity
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

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06005523 RID: 21795 RVA: 0x00212048 File Offset: 0x00210248
		// (set) Token: 0x06005524 RID: 21796 RVA: 0x00212058 File Offset: 0x00210258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Price
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

		// Token: 0x06005525 RID: 21797 RVA: 0x00212068 File Offset: 0x00210268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x00212078 File Offset: 0x00210278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectModifyPricedRequest other)
		{
			return true;
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00212088 File Offset: 0x00210288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x00212098 File Offset: 0x00210298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x002120A8 File Offset: 0x002102A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x002120B8 File Offset: 0x002102B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x002120C8 File Offset: 0x002102C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x002120D8 File Offset: 0x002102D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectModifyPricedRequest other)
		{
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x002120E8 File Offset: 0x002102E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x002120F8 File Offset: 0x002102F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x00212108 File Offset: 0x00210308
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectModifyPricedRequest()
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
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ExchangeObjectModifyPricedRequest._parser = new MessageParser<ExchangeObjectModifyPricedRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x002121D4 File Offset: 0x002103D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eMgMZhOSZauLX9YYbUSJ()
		{
			return true;
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x002121DC File Offset: 0x002103DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectModifyPricedRequest SgQP4vOSqq6x6nQ1DoCr()
		{
			return null;
		}

		// Token: 0x04001DF2 RID: 7666
		private static readonly MessageParser<ExchangeObjectModifyPricedRequest> _parser;

		// Token: 0x04001DF3 RID: 7667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DF4 RID: 7668
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001DF5 RID: 7669
		private int objectUid_;

		// Token: 0x04001DF6 RID: 7670
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001DF7 RID: 7671
		private int quantity_;

		// Token: 0x04001DF8 RID: 7672
		public const int PriceFieldNumber = 3;

		// Token: 0x04001DF9 RID: 7673
		private long price_;

		// Token: 0x04001DFA RID: 7674
		internal static ExchangeObjectModifyPricedRequest ECkCY4OS84O7YIjJ3MJj;
	}
}
