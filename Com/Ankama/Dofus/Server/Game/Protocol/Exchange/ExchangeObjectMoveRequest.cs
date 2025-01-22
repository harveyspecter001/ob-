using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006C2 RID: 1730
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectMoveRequest : IMessage<ExchangeObjectMoveRequest>, IMessage, IEquatable<ExchangeObjectMoveRequest>, IDeepCloneable<ExchangeObjectMoveRequest>, IBufferMessage
	{
		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x0600548B RID: 21643 RVA: 0x00211448 File Offset: 0x0020F648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeObjectMoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x00211458 File Offset: 0x0020F658
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

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x00211468 File Offset: 0x0020F668
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

		// Token: 0x0600548E RID: 21646 RVA: 0x00211478 File Offset: 0x0020F678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMoveRequest()
		{
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00211488 File Offset: 0x0020F688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMoveRequest(ExchangeObjectMoveRequest other)
		{
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x00211498 File Offset: 0x0020F698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMoveRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06005491 RID: 21649 RVA: 0x002114A8 File Offset: 0x0020F6A8
		// (set) Token: 0x06005492 RID: 21650 RVA: 0x002114B8 File Offset: 0x0020F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06005493 RID: 21651 RVA: 0x002114C8 File Offset: 0x0020F6C8
		// (set) Token: 0x06005494 RID: 21652 RVA: 0x002114D8 File Offset: 0x0020F6D8
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

		// Token: 0x06005495 RID: 21653 RVA: 0x002114E8 File Offset: 0x0020F6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x002114F8 File Offset: 0x0020F6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectMoveRequest other)
		{
			return true;
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x00211508 File Offset: 0x0020F708
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x00211518 File Offset: 0x0020F718
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x00211528 File Offset: 0x0020F728
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x00211538 File Offset: 0x0020F738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x00211548 File Offset: 0x0020F748
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00211558 File Offset: 0x0020F758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectMoveRequest other)
		{
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00211568 File Offset: 0x0020F768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00211578 File Offset: 0x0020F778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x00211588 File Offset: 0x0020F788
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectMoveRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					ExchangeObjectMoveRequest._parser = new MessageParser<ExchangeObjectMoveRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x00211680 File Offset: 0x0020F880
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KMHlYSOStEy83x02e5DZ()
		{
			return true;
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x00211688 File Offset: 0x0020F888
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectMoveRequest HXFnPpOSwImpqAd6B4ZQ()
		{
			return null;
		}

		// Token: 0x04001DC3 RID: 7619
		private static readonly MessageParser<ExchangeObjectMoveRequest> _parser;

		// Token: 0x04001DC4 RID: 7620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DC5 RID: 7621
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001DC6 RID: 7622
		private int objectUid_;

		// Token: 0x04001DC7 RID: 7623
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001DC8 RID: 7624
		private int quantity_;

		// Token: 0x04001DC9 RID: 7625
		private static ExchangeObjectMoveRequest p7xfXUOSDi4AgHyLku61;
	}
}
