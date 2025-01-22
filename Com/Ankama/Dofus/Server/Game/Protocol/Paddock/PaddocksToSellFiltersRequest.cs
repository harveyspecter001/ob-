using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000311 RID: 785
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddocksToSellFiltersRequest : IMessage<PaddocksToSellFiltersRequest>, IMessage, IEquatable<PaddocksToSellFiltersRequest>, IDeepCloneable<PaddocksToSellFiltersRequest>, IBufferMessage
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x001C0540 File Offset: 0x001BE740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddocksToSellFiltersRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x001C0550 File Offset: 0x001BE750
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

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x001C0560 File Offset: 0x001BE760
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

		// Token: 0x060024DA RID: 9434 RVA: 0x001C0570 File Offset: 0x001BE770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellFiltersRequest()
		{
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x001C0580 File Offset: 0x001BE780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellFiltersRequest(PaddocksToSellFiltersRequest other)
		{
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x001C0590 File Offset: 0x001BE790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellFiltersRequest Clone()
		{
			return null;
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x001C05A0 File Offset: 0x001BE7A0
		// (set) Token: 0x060024DE RID: 9438 RVA: 0x001C05B0 File Offset: 0x001BE7B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AreaId
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x001C05C0 File Offset: 0x001BE7C0
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x001C05D0 File Offset: 0x001BE7D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AtLeastMountNumber
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

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x001C05E0 File Offset: 0x001BE7E0
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x001C05F0 File Offset: 0x001BE7F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AtLeastMachineNumber
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

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x001C0600 File Offset: 0x001BE800
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x001C0610 File Offset: 0x001BE810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PriceMax
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

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x001C0620 File Offset: 0x001BE820
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x001C0634 File Offset: 0x001BE834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealEstateOrder OrderBy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (RealEstateOrder)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x001C0644 File Offset: 0x001BE844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x001C0654 File Offset: 0x001BE854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddocksToSellFiltersRequest other)
		{
			return true;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x001C0664 File Offset: 0x001BE864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x001C0674 File Offset: 0x001BE874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x001C0684 File Offset: 0x001BE884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x001C0694 File Offset: 0x001BE894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x001C06A4 File Offset: 0x001BE8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x001C06B4 File Offset: 0x001BE8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddocksToSellFiltersRequest other)
		{
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x001C06C4 File Offset: 0x001BE8C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x001C06D4 File Offset: 0x001BE8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x001C06E4 File Offset: 0x001BE8E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddocksToSellFiltersRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					PaddocksToSellFiltersRequest._parser = new MessageParser<PaddocksToSellFiltersRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x001C07B0 File Offset: 0x001BE9B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ynf4KpOWdD4Ihlp6hbGG()
		{
			return true;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x001C07B8 File Offset: 0x001BE9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddocksToSellFiltersRequest iMuWgWOW9qCakt9xIoZE()
		{
			return null;
		}

		// Token: 0x04000D14 RID: 3348
		private static readonly MessageParser<PaddocksToSellFiltersRequest> _parser;

		// Token: 0x04000D15 RID: 3349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D16 RID: 3350
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04000D17 RID: 3351
		private int areaId_;

		// Token: 0x04000D18 RID: 3352
		public const int AtLeastMountNumberFieldNumber = 2;

		// Token: 0x04000D19 RID: 3353
		private int atLeastMountNumber_;

		// Token: 0x04000D1A RID: 3354
		public const int AtLeastMachineNumberFieldNumber = 3;

		// Token: 0x04000D1B RID: 3355
		private int atLeastMachineNumber_;

		// Token: 0x04000D1C RID: 3356
		public const int PriceMaxFieldNumber = 4;

		// Token: 0x04000D1D RID: 3357
		private long priceMax_;

		// Token: 0x04000D1E RID: 3358
		public const int OrderByFieldNumber = 5;

		// Token: 0x04000D1F RID: 3359
		private RealEstateOrder orderBy_;

		// Token: 0x04000D20 RID: 3360
		internal static PaddocksToSellFiltersRequest YfvpEWOWsMgQNqbh6xAS;
	}
}
