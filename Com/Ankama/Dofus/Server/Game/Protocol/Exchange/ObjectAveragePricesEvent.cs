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
	// Token: 0x020007A9 RID: 1961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectAveragePricesEvent : IMessage<ObjectAveragePricesEvent>, IMessage, IEquatable<ObjectAveragePricesEvent>, IDeepCloneable<ObjectAveragePricesEvent>, IBufferMessage
	{
		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x0600602F RID: 24623 RVA: 0x0021F784 File Offset: 0x0021D984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectAveragePricesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x0021F794 File Offset: 0x0021D994
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

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x0021F7A4 File Offset: 0x0021D9A4
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

		// Token: 0x06006032 RID: 24626 RVA: 0x0021F7B4 File Offset: 0x0021D9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesEvent()
		{
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x0021F7C4 File Offset: 0x0021D9C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesEvent(ObjectAveragePricesEvent other)
		{
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x0021F7D4 File Offset: 0x0021D9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectAveragePricesEvent Clone()
		{
			return null;
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x0021F7E4 File Offset: 0x0021D9E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectAveragePricesEvent.Types.ObjectAveragePrice> ObjectsAveragePrices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x0021F7F4 File Offset: 0x0021D9F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x0021F804 File Offset: 0x0021DA04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectAveragePricesEvent other)
		{
			return true;
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0021F814 File Offset: 0x0021DA14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x0021F824 File Offset: 0x0021DA24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x0021F834 File Offset: 0x0021DA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x0021F844 File Offset: 0x0021DA44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x0021F854 File Offset: 0x0021DA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x0021F864 File Offset: 0x0021DA64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectAveragePricesEvent other)
		{
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x0021F874 File Offset: 0x0021DA74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x0021F884 File Offset: 0x0021DA84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006040 RID: 24640 RVA: 0x0021F894 File Offset: 0x0021DA94
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectAveragePricesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ObjectAveragePricesEvent._repeated_objectsAveragePrices_codec = FieldCodec.ForMessage<ObjectAveragePricesEvent.Types.ObjectAveragePrice>(10U, QgHKC7A90at4vqmb0NRA.XVInXhlssT(QgHKC7A90at4vqmb0NRA.aNxA9C572fU));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ObjectAveragePricesEvent._parser = new MessageParser<ObjectAveragePricesEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				}
				break;
			}
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x0021F99C File Offset: 0x0021DB9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hpPGmIOqDvHabkX2i8Fi()
		{
			return true;
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x0021F9A4 File Offset: 0x0021DBA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectAveragePricesEvent GZc3YUOqtv9S0gijDHT0()
		{
			return null;
		}

		// Token: 0x040021D3 RID: 8659
		private static readonly MessageParser<ObjectAveragePricesEvent> _parser;

		// Token: 0x040021D4 RID: 8660
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021D5 RID: 8661
		public const int ObjectsAveragePricesFieldNumber = 1;

		// Token: 0x040021D6 RID: 8662
		private static readonly FieldCodec<ObjectAveragePricesEvent.Types.ObjectAveragePrice> _repeated_objectsAveragePrices_codec;

		// Token: 0x040021D7 RID: 8663
		private readonly RepeatedField<ObjectAveragePricesEvent.Types.ObjectAveragePrice> objectsAveragePrices_;

		// Token: 0x040021D8 RID: 8664
		private static ObjectAveragePricesEvent fwkx7XOqCOEb8DLBQRgL;

		// Token: 0x020007AA RID: 1962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06006043 RID: 24643 RVA: 0x002D29C4 File Offset: 0x002D0BC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007AB RID: 1963
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ObjectAveragePrice : IMessage<ObjectAveragePricesEvent.Types.ObjectAveragePrice>, IMessage, IEquatable<ObjectAveragePricesEvent.Types.ObjectAveragePrice>, IDeepCloneable<ObjectAveragePricesEvent.Types.ObjectAveragePrice>, IBufferMessage
			{
				// Token: 0x17001176 RID: 4470
				// (get) Token: 0x06006044 RID: 24644 RVA: 0x00304D58 File Offset: 0x00302F58
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<ObjectAveragePricesEvent.Types.ObjectAveragePrice> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001177 RID: 4471
				// (get) Token: 0x06006045 RID: 24645 RVA: 0x00304D68 File Offset: 0x00302F68
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

				// Token: 0x17001178 RID: 4472
				// (get) Token: 0x06006046 RID: 24646 RVA: 0x00304D78 File Offset: 0x00302F78
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

				// Token: 0x06006047 RID: 24647 RVA: 0x00304D88 File Offset: 0x00302F88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectAveragePrice()
				{
				}

				// Token: 0x06006048 RID: 24648 RVA: 0x00304D98 File Offset: 0x00302F98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectAveragePrice(ObjectAveragePricesEvent.Types.ObjectAveragePrice other)
				{
				}

				// Token: 0x06006049 RID: 24649 RVA: 0x00304DA8 File Offset: 0x00302FA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ObjectAveragePricesEvent.Types.ObjectAveragePrice Clone()
				{
					return null;
				}

				// Token: 0x17001179 RID: 4473
				// (get) Token: 0x0600604A RID: 24650 RVA: 0x00304DB8 File Offset: 0x00302FB8
				// (set) Token: 0x0600604B RID: 24651 RVA: 0x00304DC8 File Offset: 0x00302FC8
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

				// Token: 0x1700117A RID: 4474
				// (get) Token: 0x0600604C RID: 24652 RVA: 0x00304DD8 File Offset: 0x00302FD8
				// (set) Token: 0x0600604D RID: 24653 RVA: 0x00304DE8 File Offset: 0x00302FE8
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

				// Token: 0x0600604E RID: 24654 RVA: 0x00304DF8 File Offset: 0x00302FF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600604F RID: 24655 RVA: 0x00304E08 File Offset: 0x00303008
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ObjectAveragePricesEvent.Types.ObjectAveragePrice other)
				{
					return true;
				}

				// Token: 0x06006050 RID: 24656 RVA: 0x00304E18 File Offset: 0x00303018
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006051 RID: 24657 RVA: 0x00304E28 File Offset: 0x00303028
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06006052 RID: 24658 RVA: 0x00304E38 File Offset: 0x00303038
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06006053 RID: 24659 RVA: 0x00304E48 File Offset: 0x00303048
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06006054 RID: 24660 RVA: 0x00304E58 File Offset: 0x00303058
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06006055 RID: 24661 RVA: 0x00304E68 File Offset: 0x00303068
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ObjectAveragePricesEvent.Types.ObjectAveragePrice other)
				{
				}

				// Token: 0x06006056 RID: 24662 RVA: 0x00304E78 File Offset: 0x00303078
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06006057 RID: 24663 RVA: 0x00304E88 File Offset: 0x00303088
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06006058 RID: 24664 RVA: 0x00304E98 File Offset: 0x00303098
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ObjectAveragePrice()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							ObjectAveragePricesEvent.Types.ObjectAveragePrice._parser = new MessageParser<ObjectAveragePricesEvent.Types.ObjectAveragePrice>(() => null);
							num2 = 2;
							break;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							break;
						}
					}
				}

				// Token: 0x06006059 RID: 24665 RVA: 0x00304F64 File Offset: 0x00303164
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool oMV6gMGSgSusF4H6ZXl6()
				{
					return true;
				}

				// Token: 0x0600605A RID: 24666 RVA: 0x00304F6C File Offset: 0x0030316C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ObjectAveragePricesEvent.Types.ObjectAveragePrice a3ediHGSsEQpMwed53uV()
				{
					return null;
				}

				// Token: 0x040021D9 RID: 8665
				private static readonly MessageParser<ObjectAveragePricesEvent.Types.ObjectAveragePrice> _parser;

				// Token: 0x040021DA RID: 8666
				private UnknownFieldSet _unknownFields;

				// Token: 0x040021DB RID: 8667
				public const int ObjectGidFieldNumber = 1;

				// Token: 0x040021DC RID: 8668
				private int objectGid_;

				// Token: 0x040021DD RID: 8669
				public const int AveragePriceFieldNumber = 2;

				// Token: 0x040021DE RID: 8670
				private long averagePrice_;

				// Token: 0x040021DF RID: 8671
				private static ObjectAveragePricesEvent.Types.ObjectAveragePrice UINDmxGSGC3ONeorwLKp;
			}
		}
	}
}
