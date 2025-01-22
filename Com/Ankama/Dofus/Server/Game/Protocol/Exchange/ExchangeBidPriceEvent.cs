using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000775 RID: 1909
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidPriceEvent : IMessage<ExchangeBidPriceEvent>, IMessage, IEquatable<ExchangeBidPriceEvent>, IDeepCloneable<ExchangeBidPriceEvent>, IBufferMessage
	{
		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06005D93 RID: 23955 RVA: 0x0021C654 File Offset: 0x0021A854
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidPriceEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06005D94 RID: 23956 RVA: 0x0021C664 File Offset: 0x0021A864
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

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06005D95 RID: 23957 RVA: 0x0021C674 File Offset: 0x0021A874
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

		// Token: 0x06005D96 RID: 23958 RVA: 0x0021C684 File Offset: 0x0021A884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidPriceEvent()
		{
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x0021C694 File Offset: 0x0021A894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidPriceEvent(ExchangeBidPriceEvent other)
		{
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x0021C6A4 File Offset: 0x0021A8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidPriceEvent Clone()
		{
			return null;
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06005D99 RID: 23961 RVA: 0x0021C6B4 File Offset: 0x0021A8B4
		// (set) Token: 0x06005D9A RID: 23962 RVA: 0x0021C6C4 File Offset: 0x0021A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06005D9B RID: 23963 RVA: 0x0021C6D4 File Offset: 0x0021A8D4
		// (set) Token: 0x06005D9C RID: 23964 RVA: 0x0021C6E4 File Offset: 0x0021A8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AveragePrice
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

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06005D9D RID: 23965 RVA: 0x0021C6F4 File Offset: 0x0021A8F4
		// (set) Token: 0x06005D9E RID: 23966 RVA: 0x0021C704 File Offset: 0x0021A904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeBidPriceEvent.Types.BidPriceForSeller BidPriceForSeller
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

		// Token: 0x06005D9F RID: 23967 RVA: 0x0021C714 File Offset: 0x0021A914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x0021C724 File Offset: 0x0021A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidPriceEvent other)
		{
			return true;
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x0021C734 File Offset: 0x0021A934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x0021C744 File Offset: 0x0021A944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x0021C754 File Offset: 0x0021A954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x0021C764 File Offset: 0x0021A964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x0021C774 File Offset: 0x0021A974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x0021C784 File Offset: 0x0021A984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidPriceEvent other)
		{
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x0021C794 File Offset: 0x0021A994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x0021C7A4 File Offset: 0x0021A9A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x0021C7B4 File Offset: 0x0021A9B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidPriceEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					ExchangeBidPriceEvent._parser = new MessageParser<ExchangeBidPriceEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x0021C898 File Offset: 0x0021AA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VDpQe6OZrOjuWTHwRL1W()
		{
			return true;
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x0021C8A0 File Offset: 0x0021AAA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidPriceEvent usqv9mOZVaF5oluZd8Co()
		{
			return null;
		}

		// Token: 0x040020DF RID: 8415
		private static readonly MessageParser<ExchangeBidPriceEvent> _parser;

		// Token: 0x040020E0 RID: 8416
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020E1 RID: 8417
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x040020E2 RID: 8418
		private int objectGid_;

		// Token: 0x040020E3 RID: 8419
		public const int AveragePriceFieldNumber = 2;

		// Token: 0x040020E4 RID: 8420
		private long averagePrice_;

		// Token: 0x040020E5 RID: 8421
		public const int BidPriceForSellerFieldNumber = 3;

		// Token: 0x040020E6 RID: 8422
		private ExchangeBidPriceEvent.Types.BidPriceForSeller bidPriceForSeller_;

		// Token: 0x040020E7 RID: 8423
		internal static ExchangeBidPriceEvent JwMySOOZhi4Cj0dKgX73;

		// Token: 0x02000776 RID: 1910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06005DAC RID: 23980 RVA: 0x002D1500 File Offset: 0x002CF700
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000777 RID: 1911
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class BidPriceForSeller : IMessage<ExchangeBidPriceEvent.Types.BidPriceForSeller>, IMessage, IEquatable<ExchangeBidPriceEvent.Types.BidPriceForSeller>, IDeepCloneable<ExchangeBidPriceEvent.Types.BidPriceForSeller>, IBufferMessage
			{
				// Token: 0x170010FC RID: 4348
				// (get) Token: 0x06005DAD RID: 23981 RVA: 0x00304874 File Offset: 0x00302A74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ExchangeBidPriceEvent.Types.BidPriceForSeller> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170010FD RID: 4349
				// (get) Token: 0x06005DAE RID: 23982 RVA: 0x00304884 File Offset: 0x00302A84
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

				// Token: 0x170010FE RID: 4350
				// (get) Token: 0x06005DAF RID: 23983 RVA: 0x00304894 File Offset: 0x00302A94
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

				// Token: 0x06005DB0 RID: 23984 RVA: 0x003048A4 File Offset: 0x00302AA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BidPriceForSeller()
				{
				}

				// Token: 0x06005DB1 RID: 23985 RVA: 0x003048B4 File Offset: 0x00302AB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BidPriceForSeller(ExchangeBidPriceEvent.Types.BidPriceForSeller other)
				{
				}

				// Token: 0x06005DB2 RID: 23986 RVA: 0x003048C4 File Offset: 0x00302AC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeBidPriceEvent.Types.BidPriceForSeller Clone()
				{
					return null;
				}

				// Token: 0x170010FF RID: 4351
				// (get) Token: 0x06005DB3 RID: 23987 RVA: 0x003048D4 File Offset: 0x00302AD4
				// (set) Token: 0x06005DB4 RID: 23988 RVA: 0x003048E4 File Offset: 0x00302AE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool AllIdentical
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17001100 RID: 4352
				// (get) Token: 0x06005DB5 RID: 23989 RVA: 0x003048F4 File Offset: 0x00302AF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<long> MinimalPrices
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x06005DB6 RID: 23990 RVA: 0x00304904 File Offset: 0x00302B04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06005DB7 RID: 23991 RVA: 0x00304914 File Offset: 0x00302B14
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ExchangeBidPriceEvent.Types.BidPriceForSeller other)
				{
					return true;
				}

				// Token: 0x06005DB8 RID: 23992 RVA: 0x00304924 File Offset: 0x00302B24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06005DB9 RID: 23993 RVA: 0x00304934 File Offset: 0x00302B34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06005DBA RID: 23994 RVA: 0x00304944 File Offset: 0x00302B44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06005DBB RID: 23995 RVA: 0x00304954 File Offset: 0x00302B54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06005DBC RID: 23996 RVA: 0x00304964 File Offset: 0x00302B64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06005DBD RID: 23997 RVA: 0x00304974 File Offset: 0x00302B74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ExchangeBidPriceEvent.Types.BidPriceForSeller other)
				{
				}

				// Token: 0x06005DBE RID: 23998 RVA: 0x00304984 File Offset: 0x00302B84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06005DBF RID: 23999 RVA: 0x00304994 File Offset: 0x00302B94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06005DC0 RID: 24000 RVA: 0x003049A4 File Offset: 0x00302BA4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static BidPriceForSeller()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 5;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							ExchangeBidPriceEvent.Types.BidPriceForSeller._parser = new MessageParser<ExchangeBidPriceEvent.Types.BidPriceForSeller>(() => null);
							num2 = 3;
							continue;
						case 2:
							return;
						case 3:
							ExchangeBidPriceEvent.Types.BidPriceForSeller._repeated_minimalPrices_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(18U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
							num2 = 2;
							continue;
						case 4:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 5:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 4;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06005DC1 RID: 24001 RVA: 0x00304A90 File Offset: 0x00302C90
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool I1Sst6GSmQpf31rrLH8o()
				{
					return true;
				}

				// Token: 0x06005DC2 RID: 24002 RVA: 0x00304A98 File Offset: 0x00302C98
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ExchangeBidPriceEvent.Types.BidPriceForSeller LywkIdGSARsgYlTamnZg()
				{
					return null;
				}

				// Token: 0x040020E8 RID: 8424
				private static readonly MessageParser<ExchangeBidPriceEvent.Types.BidPriceForSeller> _parser;

				// Token: 0x040020E9 RID: 8425
				private UnknownFieldSet _unknownFields;

				// Token: 0x040020EA RID: 8426
				public const int AllIdenticalFieldNumber = 1;

				// Token: 0x040020EB RID: 8427
				private bool allIdentical_;

				// Token: 0x040020EC RID: 8428
				public const int MinimalPricesFieldNumber = 2;

				// Token: 0x040020ED RID: 8429
				private static readonly FieldCodec<long> _repeated_minimalPrices_codec;

				// Token: 0x040020EE RID: 8430
				private readonly RepeatedField<long> minimalPrices_;

				// Token: 0x040020EF RID: 8431
				private static ExchangeBidPriceEvent.Types.BidPriceForSeller AQrfyjGSnYxQDJYJRGlq;
			}
		}
	}
}
