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
	// Token: 0x0200076C RID: 1900
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidSellerStartedEvent : IMessage<ExchangeBidSellerStartedEvent>, IMessage, IEquatable<ExchangeBidSellerStartedEvent>, IDeepCloneable<ExchangeBidSellerStartedEvent>, IBufferMessage
	{
		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x0021BF48 File Offset: 0x0021A148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidSellerStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06005D21 RID: 23841 RVA: 0x0021BF58 File Offset: 0x0021A158
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

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06005D22 RID: 23842 RVA: 0x0021BF68 File Offset: 0x0021A168
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

		// Token: 0x06005D23 RID: 23843 RVA: 0x0021BF78 File Offset: 0x0021A178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidSellerStartedEvent()
		{
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x0021BF88 File Offset: 0x0021A188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidSellerStartedEvent(ExchangeBidSellerStartedEvent other)
		{
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x0021BF98 File Offset: 0x0021A198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidSellerStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06005D26 RID: 23846 RVA: 0x0021BFA8 File Offset: 0x0021A1A8
		// (set) Token: 0x06005D27 RID: 23847 RVA: 0x0021BFB8 File Offset: 0x0021A1B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SellingConditions SellingConditions
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

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06005D28 RID: 23848 RVA: 0x0021BFC8 File Offset: 0x0021A1C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid> Items
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x0021BFD8 File Offset: 0x0021A1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x0021BFE8 File Offset: 0x0021A1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidSellerStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x0021BFF8 File Offset: 0x0021A1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x0021C008 File Offset: 0x0021A208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x0021C018 File Offset: 0x0021A218
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x0021C028 File Offset: 0x0021A228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x0021C038 File Offset: 0x0021A238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x0021C048 File Offset: 0x0021A248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidSellerStartedEvent other)
		{
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x0021C058 File Offset: 0x0021A258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x0021C068 File Offset: 0x0021A268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x0021C078 File Offset: 0x0021A278
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidSellerStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					ExchangeBidSellerStartedEvent._parser = new MessageParser<ExchangeBidSellerStartedEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					ExchangeBidSellerStartedEvent._repeated_items_codec = FieldCodec.ForMessage<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid>(18U, QBu0A3Ad7tsLSnahbaRq.XVInXhlssT(QBu0A3Ad7tsLSnahbaRq.sFuAdTZOUJT));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x0021C1A8 File Offset: 0x0021A3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iMW6yYOZog0LL57VKNqc()
		{
			return true;
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x0021C1B0 File Offset: 0x0021A3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidSellerStartedEvent IuNeHsOZ16k9lMJ5BAFm()
		{
			return null;
		}

		// Token: 0x040020B5 RID: 8373
		private static readonly MessageParser<ExchangeBidSellerStartedEvent> _parser;

		// Token: 0x040020B6 RID: 8374
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020B7 RID: 8375
		public const int SellingConditionsFieldNumber = 1;

		// Token: 0x040020B8 RID: 8376
		private SellingConditions sellingConditions_;

		// Token: 0x040020B9 RID: 8377
		public const int ItemsFieldNumber = 2;

		// Token: 0x040020BA RID: 8378
		private static readonly FieldCodec<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid> _repeated_items_codec;

		// Token: 0x040020BB RID: 8379
		private readonly RepeatedField<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid> items_;

		// Token: 0x040020BC RID: 8380
		private static ExchangeBidSellerStartedEvent MUhb32OZvR2gc8sduc5w;

		// Token: 0x0200076D RID: 1901
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06005D36 RID: 23862 RVA: 0x002D11E4 File Offset: 0x002CF3E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200076E RID: 1902
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ItemToSellInBid : IMessage<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid>, IMessage, IEquatable<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid>, IDeepCloneable<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid>, IBufferMessage
			{
				// Token: 0x170010E5 RID: 4325
				// (get) Token: 0x06005D37 RID: 23863 RVA: 0x00304638 File Offset: 0x00302838
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170010E6 RID: 4326
				// (get) Token: 0x06005D38 RID: 23864 RVA: 0x00304648 File Offset: 0x00302848
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

				// Token: 0x170010E7 RID: 4327
				// (get) Token: 0x06005D39 RID: 23865 RVA: 0x00304658 File Offset: 0x00302858
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

				// Token: 0x06005D3A RID: 23866 RVA: 0x00304668 File Offset: 0x00302868
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ItemToSellInBid()
				{
				}

				// Token: 0x06005D3B RID: 23867 RVA: 0x00304678 File Offset: 0x00302878
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ItemToSellInBid(ExchangeBidSellerStartedEvent.Types.ItemToSellInBid other)
				{
				}

				// Token: 0x06005D3C RID: 23868 RVA: 0x00304688 File Offset: 0x00302888
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangeBidSellerStartedEvent.Types.ItemToSellInBid Clone()
				{
					return null;
				}

				// Token: 0x170010E8 RID: 4328
				// (get) Token: 0x06005D3D RID: 23869 RVA: 0x00304698 File Offset: 0x00302898
				// (set) Token: 0x06005D3E RID: 23870 RVA: 0x003046A8 File Offset: 0x003028A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public BidItem Item
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

				// Token: 0x170010E9 RID: 4329
				// (get) Token: 0x06005D3F RID: 23871 RVA: 0x003046B8 File Offset: 0x003028B8
				// (set) Token: 0x06005D40 RID: 23872 RVA: 0x003046C8 File Offset: 0x003028C8
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

				// Token: 0x170010EA RID: 4330
				// (get) Token: 0x06005D41 RID: 23873 RVA: 0x003046D8 File Offset: 0x003028D8
				// (set) Token: 0x06005D42 RID: 23874 RVA: 0x003046E8 File Offset: 0x003028E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int UnsoldDelay
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

				// Token: 0x06005D43 RID: 23875 RVA: 0x003046F8 File Offset: 0x003028F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06005D44 RID: 23876 RVA: 0x00304708 File Offset: 0x00302908
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ExchangeBidSellerStartedEvent.Types.ItemToSellInBid other)
				{
					return true;
				}

				// Token: 0x06005D45 RID: 23877 RVA: 0x00304718 File Offset: 0x00302918
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06005D46 RID: 23878 RVA: 0x00304728 File Offset: 0x00302928
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06005D47 RID: 23879 RVA: 0x00304738 File Offset: 0x00302938
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06005D48 RID: 23880 RVA: 0x00304748 File Offset: 0x00302948
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06005D49 RID: 23881 RVA: 0x00304758 File Offset: 0x00302958
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06005D4A RID: 23882 RVA: 0x00304768 File Offset: 0x00302968
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ExchangeBidSellerStartedEvent.Types.ItemToSellInBid other)
				{
				}

				// Token: 0x06005D4B RID: 23883 RVA: 0x00304778 File Offset: 0x00302978
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06005D4C RID: 23884 RVA: 0x00304788 File Offset: 0x00302988
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06005D4D RID: 23885 RVA: 0x00304798 File Offset: 0x00302998
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ItemToSellInBid()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							ExchangeBidSellerStartedEvent.Types.ItemToSellInBid._parser = new MessageParser<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid>(() => null);
							num2 = 4;
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06005D4E RID: 23886 RVA: 0x00304864 File Offset: 0x00302A64
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool gwEG3KGPzTNNtpksYxbU()
				{
					return true;
				}

				// Token: 0x06005D4F RID: 23887 RVA: 0x0030486C File Offset: 0x00302A6C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ExchangeBidSellerStartedEvent.Types.ItemToSellInBid yip5VWGSfkk2WvseW2qb()
				{
					return null;
				}

				// Token: 0x040020BD RID: 8381
				private static readonly MessageParser<ExchangeBidSellerStartedEvent.Types.ItemToSellInBid> _parser;

				// Token: 0x040020BE RID: 8382
				private UnknownFieldSet _unknownFields;

				// Token: 0x040020BF RID: 8383
				public const int ItemFieldNumber = 1;

				// Token: 0x040020C0 RID: 8384
				private BidItem item_;

				// Token: 0x040020C1 RID: 8385
				public const int PriceFieldNumber = 2;

				// Token: 0x040020C2 RID: 8386
				private long price_;

				// Token: 0x040020C3 RID: 8387
				public const int UnsoldDelayFieldNumber = 3;

				// Token: 0x040020C4 RID: 8388
				private int unsoldDelay_;

				// Token: 0x040020C5 RID: 8389
				private static ExchangeBidSellerStartedEvent.Types.ItemToSellInBid WvMlYWGPFOGTHlCHuiu8;
			}
		}
	}
}
