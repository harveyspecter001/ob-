using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000323 RID: 803
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddocksToSellEvent : IMessage<PaddocksToSellEvent>, IMessage, IEquatable<PaddocksToSellEvent>, IDeepCloneable<PaddocksToSellEvent>, IBufferMessage
	{
		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x001C16C4 File Offset: 0x001BF8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PaddocksToSellEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x001C16D4 File Offset: 0x001BF8D4
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

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x001C16E4 File Offset: 0x001BF8E4
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

		// Token: 0x060025B9 RID: 9657 RVA: 0x001C16F4 File Offset: 0x001BF8F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellEvent()
		{
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x001C1704 File Offset: 0x001BF904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellEvent(PaddocksToSellEvent other)
		{
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x001C1714 File Offset: 0x001BF914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddocksToSellEvent Clone()
		{
			return null;
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x001C1724 File Offset: 0x001BF924
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x001C1734 File Offset: 0x001BF934
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PageIndex
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

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x001C1744 File Offset: 0x001BF944
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x001C1754 File Offset: 0x001BF954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PageTotal
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

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x001C1764 File Offset: 0x001BF964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<PaddocksToSellEvent.Types.PaddockForSale> Paddocks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x001C1774 File Offset: 0x001BF974
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x001C1784 File Offset: 0x001BF984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddocksToSellEvent other)
		{
			return true;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x001C1794 File Offset: 0x001BF994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x001C17A4 File Offset: 0x001BF9A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x001C17B4 File Offset: 0x001BF9B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x001C17C4 File Offset: 0x001BF9C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x001C17D4 File Offset: 0x001BF9D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x001C17E4 File Offset: 0x001BF9E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddocksToSellEvent other)
		{
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x001C17F4 File Offset: 0x001BF9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x001C1804 File Offset: 0x001BFA04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x001C1814 File Offset: 0x001BFA14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddocksToSellEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PaddocksToSellEvent._repeated_paddocks_codec = FieldCodec.ForMessage<PaddocksToSellEvent.Types.PaddockForSale>(26U, eVAUTwn17HOTCLJe4Ek6.XVInXhlssT(eVAUTwn17HOTCLJe4Ek6.JJgn1T1VTC8));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					PaddocksToSellEvent._parser = new MessageParser<PaddocksToSellEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x001C1930 File Offset: 0x001BFB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I97MH6OWhmp2ZfoScLGi()
		{
			return true;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x001C1938 File Offset: 0x001BFB38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddocksToSellEvent NEW1vkOWrD6uArFnk6ej()
		{
			return null;
		}

		// Token: 0x04000D61 RID: 3425
		private static readonly MessageParser<PaddocksToSellEvent> _parser;

		// Token: 0x04000D62 RID: 3426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D63 RID: 3427
		public const int PageIndexFieldNumber = 1;

		// Token: 0x04000D64 RID: 3428
		private int pageIndex_;

		// Token: 0x04000D65 RID: 3429
		public const int PageTotalFieldNumber = 2;

		// Token: 0x04000D66 RID: 3430
		private int pageTotal_;

		// Token: 0x04000D67 RID: 3431
		public const int PaddocksFieldNumber = 3;

		// Token: 0x04000D68 RID: 3432
		private static readonly FieldCodec<PaddocksToSellEvent.Types.PaddockForSale> _repeated_paddocks_codec;

		// Token: 0x04000D69 RID: 3433
		private readonly RepeatedField<PaddocksToSellEvent.Types.PaddockForSale> paddocks_;

		// Token: 0x04000D6A RID: 3434
		private static PaddocksToSellEvent cwAwxyOWWaoRAZFhXhIf;

		// Token: 0x02000324 RID: 804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060025CE RID: 9678 RVA: 0x002B760C File Offset: 0x002B580C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000325 RID: 805
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PaddockForSale : IMessage<PaddocksToSellEvent.Types.PaddockForSale>, IMessage, IEquatable<PaddocksToSellEvent.Types.PaddockForSale>, IDeepCloneable<PaddocksToSellEvent.Types.PaddockForSale>, IBufferMessage
			{
				// Token: 0x170006C5 RID: 1733
				// (get) Token: 0x060025CF RID: 9679 RVA: 0x002FACF4 File Offset: 0x002F8EF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PaddocksToSellEvent.Types.PaddockForSale> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170006C6 RID: 1734
				// (get) Token: 0x060025D0 RID: 9680 RVA: 0x002FAD04 File Offset: 0x002F8F04
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

				// Token: 0x170006C7 RID: 1735
				// (get) Token: 0x060025D1 RID: 9681 RVA: 0x002FAD14 File Offset: 0x002F8F14
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

				// Token: 0x060025D2 RID: 9682 RVA: 0x002FAD24 File Offset: 0x002F8F24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockForSale()
				{
				}

				// Token: 0x060025D3 RID: 9683 RVA: 0x002FAD34 File Offset: 0x002F8F34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddockForSale(PaddocksToSellEvent.Types.PaddockForSale other)
				{
				}

				// Token: 0x060025D4 RID: 9684 RVA: 0x002FAD44 File Offset: 0x002F8F44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PaddocksToSellEvent.Types.PaddockForSale Clone()
				{
					return null;
				}

				// Token: 0x170006C8 RID: 1736
				// (get) Token: 0x060025D5 RID: 9685 RVA: 0x002FAD54 File Offset: 0x002F8F54
				// (set) Token: 0x060025D6 RID: 9686 RVA: 0x002FAD64 File Offset: 0x002F8F64
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public string GuildOwner
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

				// Token: 0x170006C9 RID: 1737
				// (get) Token: 0x060025D7 RID: 9687 RVA: 0x002FAD74 File Offset: 0x002F8F74
				// (set) Token: 0x060025D8 RID: 9688 RVA: 0x002FAD84 File Offset: 0x002F8F84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public MapCoordinates Coordinates
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

				// Token: 0x170006CA RID: 1738
				// (get) Token: 0x060025D9 RID: 9689 RVA: 0x002FAD94 File Offset: 0x002F8F94
				// (set) Token: 0x060025DA RID: 9690 RVA: 0x002FADA4 File Offset: 0x002F8FA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int SubAreaId
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

				// Token: 0x170006CB RID: 1739
				// (get) Token: 0x060025DB RID: 9691 RVA: 0x002FADB4 File Offset: 0x002F8FB4
				// (set) Token: 0x060025DC RID: 9692 RVA: 0x002FADC4 File Offset: 0x002F8FC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MountNumber
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

				// Token: 0x170006CC RID: 1740
				// (get) Token: 0x060025DD RID: 9693 RVA: 0x002FADD4 File Offset: 0x002F8FD4
				// (set) Token: 0x060025DE RID: 9694 RVA: 0x002FADE4 File Offset: 0x002F8FE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ObjectNumber
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

				// Token: 0x170006CD RID: 1741
				// (get) Token: 0x060025DF RID: 9695 RVA: 0x002FADF4 File Offset: 0x002F8FF4
				// (set) Token: 0x060025E0 RID: 9696 RVA: 0x002FAE04 File Offset: 0x002F9004
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

				// Token: 0x060025E1 RID: 9697 RVA: 0x002FAE14 File Offset: 0x002F9014
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060025E2 RID: 9698 RVA: 0x002FAE24 File Offset: 0x002F9024
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PaddocksToSellEvent.Types.PaddockForSale other)
				{
					return true;
				}

				// Token: 0x060025E3 RID: 9699 RVA: 0x002FAE34 File Offset: 0x002F9034
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060025E4 RID: 9700 RVA: 0x002FAE44 File Offset: 0x002F9044
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060025E5 RID: 9701 RVA: 0x002FAE54 File Offset: 0x002F9054
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060025E6 RID: 9702 RVA: 0x002FAE64 File Offset: 0x002F9064
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060025E7 RID: 9703 RVA: 0x002FAE74 File Offset: 0x002F9074
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060025E8 RID: 9704 RVA: 0x002FAE84 File Offset: 0x002F9084
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PaddocksToSellEvent.Types.PaddockForSale other)
				{
				}

				// Token: 0x060025E9 RID: 9705 RVA: 0x002FAE94 File Offset: 0x002F9094
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060025EA RID: 9706 RVA: 0x002FAEA4 File Offset: 0x002F90A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060025EB RID: 9707 RVA: 0x002FAEB4 File Offset: 0x002F90B4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PaddockForSale()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							PaddocksToSellEvent.Types.PaddockForSale._parser = new MessageParser<PaddocksToSellEvent.Types.PaddockForSale>(() => null);
							num2 = 3;
							continue;
						case 3:
							return;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
					}
				}

				// Token: 0x060025EC RID: 9708 RVA: 0x002FAF80 File Offset: 0x002F9180
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool e5sZh0GYGeyUmG8K9SnU()
				{
					return true;
				}

				// Token: 0x060025ED RID: 9709 RVA: 0x002FAF88 File Offset: 0x002F9188
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PaddocksToSellEvent.Types.PaddockForSale XFS8hTGYgpsWNZwaWDG5()
				{
					return null;
				}

				// Token: 0x04000D6B RID: 3435
				private static readonly MessageParser<PaddocksToSellEvent.Types.PaddockForSale> _parser;

				// Token: 0x04000D6C RID: 3436
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000D6D RID: 3437
				public const int GuildOwnerFieldNumber = 1;

				// Token: 0x04000D6E RID: 3438
				private string guildOwner_;

				// Token: 0x04000D6F RID: 3439
				public const int CoordinatesFieldNumber = 2;

				// Token: 0x04000D70 RID: 3440
				private MapCoordinates coordinates_;

				// Token: 0x04000D71 RID: 3441
				public const int SubAreaIdFieldNumber = 3;

				// Token: 0x04000D72 RID: 3442
				private int subAreaId_;

				// Token: 0x04000D73 RID: 3443
				public const int MountNumberFieldNumber = 4;

				// Token: 0x04000D74 RID: 3444
				private int mountNumber_;

				// Token: 0x04000D75 RID: 3445
				public const int ObjectNumberFieldNumber = 5;

				// Token: 0x04000D76 RID: 3446
				private int objectNumber_;

				// Token: 0x04000D77 RID: 3447
				public const int PriceFieldNumber = 6;

				// Token: 0x04000D78 RID: 3448
				private long price_;

				// Token: 0x04000D79 RID: 3449
				internal static PaddocksToSellEvent.Types.PaddockForSale piWHMnGYJ30RwQmWoNiN;
			}
		}
	}
}
