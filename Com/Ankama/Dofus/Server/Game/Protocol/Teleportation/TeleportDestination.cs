using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x020000A1 RID: 161
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportDestination : IMessage<TeleportDestination>, IMessage, IEquatable<TeleportDestination>, IDeepCloneable<TeleportDestination>, IBufferMessage
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0018D790 File Offset: 0x0018B990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportDestination> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0018D7A0 File Offset: 0x0018B9A0
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0018D7B0 File Offset: 0x0018B9B0
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

		// Token: 0x060006EB RID: 1771 RVA: 0x0018D7C0 File Offset: 0x0018B9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportDestination()
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0018D7D0 File Offset: 0x0018B9D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportDestination(TeleportDestination other)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0018D7E0 File Offset: 0x0018B9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportDestination Clone()
		{
			return null;
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0018D7F0 File Offset: 0x0018B9F0
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0018D804 File Offset: 0x0018BA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Teleporter Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Teleporter)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0018D814 File Offset: 0x0018BA14
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0018D824 File Offset: 0x0018BA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0018D834 File Offset: 0x0018BA34
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0018D844 File Offset: 0x0018BA44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SubareaId
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0018D854 File Offset: 0x0018BA54
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0018D864 File Offset: 0x0018BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0018D874 File Offset: 0x0018BA74
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0018D884 File Offset: 0x0018BA84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Cost
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0018D894 File Offset: 0x0018BA94
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0018D8A4 File Offset: 0x0018BAA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TeleportDestination.Types.Anomaly Anomaly
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

		// Token: 0x060006FA RID: 1786 RVA: 0x0018D8B4 File Offset: 0x0018BAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0018D8C4 File Offset: 0x0018BAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportDestination other)
		{
			return true;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0018D8D4 File Offset: 0x0018BAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0018D8E4 File Offset: 0x0018BAE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0018D8F4 File Offset: 0x0018BAF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0018D904 File Offset: 0x0018BB04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0018D914 File Offset: 0x0018BB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0018D924 File Offset: 0x0018BB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportDestination other)
		{
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0018D934 File Offset: 0x0018BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0018D944 File Offset: 0x0018BB44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0018D954 File Offset: 0x0018BB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportDestination()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					TeleportDestination._parser = new MessageParser<TeleportDestination>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0018DA20 File Offset: 0x0018BC20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool N1tuSgOI1dISNXZDW2NF()
		{
			return true;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0018DA28 File Offset: 0x0018BC28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportDestination aAyEISOIaVqxSMn3RS6K()
		{
			return null;
		}

		// Token: 0x04000297 RID: 663
		private static readonly MessageParser<TeleportDestination> _parser;

		// Token: 0x04000298 RID: 664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000299 RID: 665
		public const int TypeFieldNumber = 1;

		// Token: 0x0400029A RID: 666
		private Teleporter type_;

		// Token: 0x0400029B RID: 667
		public const int MapIdFieldNumber = 2;

		// Token: 0x0400029C RID: 668
		private long mapId_;

		// Token: 0x0400029D RID: 669
		public const int SubareaIdFieldNumber = 3;

		// Token: 0x0400029E RID: 670
		private int subareaId_;

		// Token: 0x0400029F RID: 671
		public const int LevelFieldNumber = 4;

		// Token: 0x040002A0 RID: 672
		private int level_;

		// Token: 0x040002A1 RID: 673
		public const int CostFieldNumber = 5;

		// Token: 0x040002A2 RID: 674
		private int cost_;

		// Token: 0x040002A3 RID: 675
		public const int AnomalyFieldNumber = 6;

		// Token: 0x040002A4 RID: 676
		private TeleportDestination.Types.Anomaly anomaly_;

		// Token: 0x040002A5 RID: 677
		private static TeleportDestination hTwAUaOIoVp6ELdATAv0;

		// Token: 0x020000A2 RID: 162
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06000707 RID: 1799 RVA: 0x002A82D8 File Offset: 0x002A64D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020000A3 RID: 163
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Anomaly : IMessage<TeleportDestination.Types.Anomaly>, IMessage, IEquatable<TeleportDestination.Types.Anomaly>, IDeepCloneable<TeleportDestination.Types.Anomaly>, IBufferMessage
			{
				// Token: 0x17000132 RID: 306
				// (get) Token: 0x06000708 RID: 1800 RVA: 0x002F7198 File Offset: 0x002F5398
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<TeleportDestination.Types.Anomaly> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000133 RID: 307
				// (get) Token: 0x06000709 RID: 1801 RVA: 0x002F71A8 File Offset: 0x002F53A8
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

				// Token: 0x17000134 RID: 308
				// (get) Token: 0x0600070A RID: 1802 RVA: 0x002F71B8 File Offset: 0x002F53B8
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

				// Token: 0x0600070B RID: 1803 RVA: 0x002F71C8 File Offset: 0x002F53C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Anomaly()
				{
				}

				// Token: 0x0600070C RID: 1804 RVA: 0x002F71D8 File Offset: 0x002F53D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Anomaly(TeleportDestination.Types.Anomaly other)
				{
				}

				// Token: 0x0600070D RID: 1805 RVA: 0x002F71E8 File Offset: 0x002F53E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TeleportDestination.Types.Anomaly Clone()
				{
					return null;
				}

				// Token: 0x17000135 RID: 309
				// (get) Token: 0x0600070E RID: 1806 RVA: 0x002F71F8 File Offset: 0x002F53F8
				// (set) Token: 0x0600070F RID: 1807 RVA: 0x002F7208 File Offset: 0x002F5408
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int BonusPourcentage
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

				// Token: 0x17000136 RID: 310
				// (get) Token: 0x06000710 RID: 1808 RVA: 0x002F7218 File Offset: 0x002F5418
				// (set) Token: 0x06000711 RID: 1809 RVA: 0x002F7228 File Offset: 0x002F5428
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long RemainingTime
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

				// Token: 0x06000712 RID: 1810 RVA: 0x002F7238 File Offset: 0x002F5438
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06000713 RID: 1811 RVA: 0x002F7248 File Offset: 0x002F5448
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(TeleportDestination.Types.Anomaly other)
				{
					return true;
				}

				// Token: 0x06000714 RID: 1812 RVA: 0x002F7258 File Offset: 0x002F5458
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06000715 RID: 1813 RVA: 0x002F7268 File Offset: 0x002F5468
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06000716 RID: 1814 RVA: 0x002F7278 File Offset: 0x002F5478
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06000717 RID: 1815 RVA: 0x002F7288 File Offset: 0x002F5488
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06000718 RID: 1816 RVA: 0x002F7298 File Offset: 0x002F5498
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06000719 RID: 1817 RVA: 0x002F72A8 File Offset: 0x002F54A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(TeleportDestination.Types.Anomaly other)
				{
				}

				// Token: 0x0600071A RID: 1818 RVA: 0x002F72B8 File Offset: 0x002F54B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600071B RID: 1819 RVA: 0x002F72C8 File Offset: 0x002F54C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600071C RID: 1820 RVA: 0x002F72D8 File Offset: 0x002F54D8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Anomaly()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_5E;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								return;
							}
							TeleportDestination.Types.Anomaly._parser = new MessageParser<TeleportDestination.Types.Anomaly>(() => null);
							num2 = 4;
						}
						IL_5E:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num = 3;
					}
				}

				// Token: 0x0600071D RID: 1821 RVA: 0x002F73A8 File Offset: 0x002F55A8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool mj54yYGTH8ABWSWI2Mvl()
				{
					return true;
				}

				// Token: 0x0600071E RID: 1822 RVA: 0x002F73B0 File Offset: 0x002F55B0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static TeleportDestination.Types.Anomaly VrJn4pGTY6ZnND9Y0L2g()
				{
					return null;
				}

				// Token: 0x040002A6 RID: 678
				private static readonly MessageParser<TeleportDestination.Types.Anomaly> _parser;

				// Token: 0x040002A7 RID: 679
				private UnknownFieldSet _unknownFields;

				// Token: 0x040002A8 RID: 680
				public const int BonusPourcentageFieldNumber = 1;

				// Token: 0x040002A9 RID: 681
				private int bonusPourcentage_;

				// Token: 0x040002AA RID: 682
				public const int RemainingTimeFieldNumber = 2;

				// Token: 0x040002AB RID: 683
				private long remainingTime_;

				// Token: 0x040002AC RID: 684
				private static TeleportDestination.Types.Anomaly PKgW0UGTpNQbAo4Yfk3y;
			}
		}
	}
}
