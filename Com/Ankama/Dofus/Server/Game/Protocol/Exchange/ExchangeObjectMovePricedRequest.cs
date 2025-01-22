using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006CA RID: 1738
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectMovePricedRequest : IMessage<ExchangeObjectMovePricedRequest>, IMessage, IEquatable<ExchangeObjectMovePricedRequest>, IDeepCloneable<ExchangeObjectMovePricedRequest>, IBufferMessage
	{
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x00211D40 File Offset: 0x0020FF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectMovePricedRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x00211D50 File Offset: 0x0020FF50
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

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x060054FD RID: 21757 RVA: 0x00211D60 File Offset: 0x0020FF60
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

		// Token: 0x060054FE RID: 21758 RVA: 0x00211D70 File Offset: 0x0020FF70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMovePricedRequest()
		{
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00211D80 File Offset: 0x0020FF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMovePricedRequest(ExchangeObjectMovePricedRequest other)
		{
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x00211D90 File Offset: 0x0020FF90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMovePricedRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x00211DA0 File Offset: 0x0020FFA0
		// (set) Token: 0x06005502 RID: 21762 RVA: 0x00211DB0 File Offset: 0x0020FFB0
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

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06005503 RID: 21763 RVA: 0x00211DC0 File Offset: 0x0020FFC0
		// (set) Token: 0x06005504 RID: 21764 RVA: 0x00211DD0 File Offset: 0x0020FFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x00211DE0 File Offset: 0x0020FFE0
		// (set) Token: 0x06005506 RID: 21766 RVA: 0x00211DF0 File Offset: 0x0020FFF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06005507 RID: 21767 RVA: 0x00211E00 File Offset: 0x00210000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x00211E10 File Offset: 0x00210010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectMovePricedRequest other)
		{
			return true;
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00211E20 File Offset: 0x00210020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x00211E30 File Offset: 0x00210030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x00211E40 File Offset: 0x00210040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x00211E50 File Offset: 0x00210050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00211E60 File Offset: 0x00210060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x00211E70 File Offset: 0x00210070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectMovePricedRequest other)
		{
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00211E80 File Offset: 0x00210080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00211E90 File Offset: 0x00210090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00211EA0 File Offset: 0x002100A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectMovePricedRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ExchangeObjectMovePricedRequest._parser = new MessageParser<ExchangeObjectMovePricedRequest>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00211F98 File Offset: 0x00210198
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YUKmtJOSMGgJMNRGBphP()
		{
			return true;
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00211FA0 File Offset: 0x002101A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectMovePricedRequest o5INyCOSuuoZ1CbTi3Oc()
		{
			return null;
		}

		// Token: 0x04001DE7 RID: 7655
		private static readonly MessageParser<ExchangeObjectMovePricedRequest> _parser;

		// Token: 0x04001DE8 RID: 7656
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DE9 RID: 7657
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001DEA RID: 7658
		private int objectUid_;

		// Token: 0x04001DEB RID: 7659
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001DEC RID: 7660
		private int quantity_;

		// Token: 0x04001DED RID: 7661
		public const int PriceFieldNumber = 3;

		// Token: 0x04001DEE RID: 7662
		private long price_;

		// Token: 0x04001DEF RID: 7663
		private static ExchangeObjectMovePricedRequest juNsjUOSSlwAyDy1i9tR;
	}
}
