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
	// Token: 0x020007B0 RID: 1968
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DecraftResultEvent : IMessage<DecraftResultEvent>, IMessage, IEquatable<DecraftResultEvent>, IDeepCloneable<DecraftResultEvent>, IBufferMessage
	{
		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x0021FBC8 File Offset: 0x0021DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DecraftResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06006082 RID: 24706 RVA: 0x0021FBD8 File Offset: 0x0021DDD8
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

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x0021FBE8 File Offset: 0x0021DDE8
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

		// Token: 0x06006084 RID: 24708 RVA: 0x0021FBF8 File Offset: 0x0021DDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecraftResultEvent()
		{
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x0021FC08 File Offset: 0x0021DE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecraftResultEvent(DecraftResultEvent other)
		{
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x0021FC18 File Offset: 0x0021DE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DecraftResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06006087 RID: 24711 RVA: 0x0021FC28 File Offset: 0x0021DE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecraftResultEvent.Types.DecraftedItem> Results
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x0021FC38 File Offset: 0x0021DE38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x0021FC48 File Offset: 0x0021DE48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DecraftResultEvent other)
		{
			return true;
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x0021FC58 File Offset: 0x0021DE58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x0021FC68 File Offset: 0x0021DE68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x0021FC78 File Offset: 0x0021DE78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x0021FC88 File Offset: 0x0021DE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x0021FC98 File Offset: 0x0021DE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x0021FCA8 File Offset: 0x0021DEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DecraftResultEvent other)
		{
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x0021FCB8 File Offset: 0x0021DEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x0021FCC8 File Offset: 0x0021DEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x0021FCD8 File Offset: 0x0021DED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DecraftResultEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					DecraftResultEvent._repeated_results_codec = FieldCodec.ForMessage<DecraftResultEvent.Types.DecraftedItem>(10U, YEW4vYA970P6wj1k3RSi.XVInXhlssT(YEW4vYA970P6wj1k3RSi.p7iA9ThPc3m));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					DecraftResultEvent._parser = new MessageParser<DecraftResultEvent>(() => null);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x0021FDE0 File Offset: 0x0021DFE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rQrtf8OqpVVBTLkBnihS()
		{
			return true;
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0021FDE8 File Offset: 0x0021DFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DecraftResultEvent Irg8KmOqHJx4xHLYvaDX()
		{
			return null;
		}

		// Token: 0x040021ED RID: 8685
		private static readonly MessageParser<DecraftResultEvent> _parser;

		// Token: 0x040021EE RID: 8686
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021EF RID: 8687
		public const int ResultsFieldNumber = 1;

		// Token: 0x040021F0 RID: 8688
		private static readonly FieldCodec<DecraftResultEvent.Types.DecraftedItem> _repeated_results_codec;

		// Token: 0x040021F1 RID: 8689
		private readonly RepeatedField<DecraftResultEvent.Types.DecraftedItem> results_;

		// Token: 0x040021F2 RID: 8690
		private static DecraftResultEvent AoeQw4OqT2d0eIZf7jFK;

		// Token: 0x020007B1 RID: 1969
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06006095 RID: 24725 RVA: 0x002D2BBC File Offset: 0x002D0DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007B2 RID: 1970
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DecraftedItem : IMessage<DecraftResultEvent.Types.DecraftedItem>, IMessage, IEquatable<DecraftResultEvent.Types.DecraftedItem>, IDeepCloneable<DecraftResultEvent.Types.DecraftedItem>, IBufferMessage
			{
				// Token: 0x17001184 RID: 4484
				// (get) Token: 0x06006096 RID: 24726 RVA: 0x00304F74 File Offset: 0x00303174
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<DecraftResultEvent.Types.DecraftedItem> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001185 RID: 4485
				// (get) Token: 0x06006097 RID: 24727 RVA: 0x00304F84 File Offset: 0x00303184
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

				// Token: 0x17001186 RID: 4486
				// (get) Token: 0x06006098 RID: 24728 RVA: 0x00304F94 File Offset: 0x00303194
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

				// Token: 0x06006099 RID: 24729 RVA: 0x00304FA4 File Offset: 0x003031A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DecraftedItem()
				{
				}

				// Token: 0x0600609A RID: 24730 RVA: 0x00304FB4 File Offset: 0x003031B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DecraftedItem(DecraftResultEvent.Types.DecraftedItem other)
				{
				}

				// Token: 0x0600609B RID: 24731 RVA: 0x00304FC4 File Offset: 0x003031C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DecraftResultEvent.Types.DecraftedItem Clone()
				{
					return null;
				}

				// Token: 0x17001187 RID: 4487
				// (get) Token: 0x0600609C RID: 24732 RVA: 0x00304FD4 File Offset: 0x003031D4
				// (set) Token: 0x0600609D RID: 24733 RVA: 0x00304FE4 File Offset: 0x003031E4
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

				// Token: 0x17001188 RID: 4488
				// (get) Token: 0x0600609E RID: 24734 RVA: 0x00304FF4 File Offset: 0x003031F4
				// (set) Token: 0x0600609F RID: 24735 RVA: 0x00305004 File Offset: 0x00303204
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public float BonusMin
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17001189 RID: 4489
				// (get) Token: 0x060060A0 RID: 24736 RVA: 0x00305014 File Offset: 0x00303214
				// (set) Token: 0x060060A1 RID: 24737 RVA: 0x00305024 File Offset: 0x00303224
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public float BonusMax
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (float)0;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x1700118A RID: 4490
				// (get) Token: 0x060060A2 RID: 24738 RVA: 0x00305034 File Offset: 0x00303234
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<DecraftResultEvent.Types.DecraftedItem.Types.Rune> Runes
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x060060A3 RID: 24739 RVA: 0x00305044 File Offset: 0x00303244
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060060A4 RID: 24740 RVA: 0x00305054 File Offset: 0x00303254
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(DecraftResultEvent.Types.DecraftedItem other)
				{
					return true;
				}

				// Token: 0x060060A5 RID: 24741 RVA: 0x00305064 File Offset: 0x00303264
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060060A6 RID: 24742 RVA: 0x00305074 File Offset: 0x00303274
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060060A7 RID: 24743 RVA: 0x00305084 File Offset: 0x00303284
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060060A8 RID: 24744 RVA: 0x00305094 File Offset: 0x00303294
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060060A9 RID: 24745 RVA: 0x003050A4 File Offset: 0x003032A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060060AA RID: 24746 RVA: 0x003050B4 File Offset: 0x003032B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(DecraftResultEvent.Types.DecraftedItem other)
				{
				}

				// Token: 0x060060AB RID: 24747 RVA: 0x003050C4 File Offset: 0x003032C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060060AC RID: 24748 RVA: 0x003050D4 File Offset: 0x003032D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060060AD RID: 24749 RVA: 0x003050E4 File Offset: 0x003032E4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DecraftedItem()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							DecraftResultEvent.Types.DecraftedItem._parser = new MessageParser<DecraftResultEvent.Types.DecraftedItem>(() => null);
							num2 = 5;
							continue;
						case 5:
							DecraftResultEvent.Types.DecraftedItem._repeated_runes_codec = FieldCodec.ForMessage<DecraftResultEvent.Types.DecraftedItem.Types.Rune>(34U, LxnQKoA9p7netvLYC2tT.XVInXhlssT(LxnQKoA9p7netvLYC2tT.GuqA9HDNOre));
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
					}
				}

				// Token: 0x060060AE RID: 24750 RVA: 0x003051EC File Offset: 0x003033EC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool CuOvT7GS9ggO2dYlRgf7()
				{
					return true;
				}

				// Token: 0x060060AF RID: 24751 RVA: 0x003051F4 File Offset: 0x003033F4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static DecraftResultEvent.Types.DecraftedItem tml8SfGS2TntF6IRYJDu()
				{
					return null;
				}

				// Token: 0x040021F3 RID: 8691
				private static readonly MessageParser<DecraftResultEvent.Types.DecraftedItem> _parser;

				// Token: 0x040021F4 RID: 8692
				private UnknownFieldSet _unknownFields;

				// Token: 0x040021F5 RID: 8693
				public const int ObjectUidFieldNumber = 1;

				// Token: 0x040021F6 RID: 8694
				private int objectUid_;

				// Token: 0x040021F7 RID: 8695
				public const int BonusMinFieldNumber = 2;

				// Token: 0x040021F8 RID: 8696
				private float bonusMin_;

				// Token: 0x040021F9 RID: 8697
				public const int BonusMaxFieldNumber = 3;

				// Token: 0x040021FA RID: 8698
				private float bonusMax_;

				// Token: 0x040021FB RID: 8699
				public const int RunesFieldNumber = 4;

				// Token: 0x040021FC RID: 8700
				private static readonly FieldCodec<DecraftResultEvent.Types.DecraftedItem.Types.Rune> _repeated_runes_codec;

				// Token: 0x040021FD RID: 8701
				private readonly RepeatedField<DecraftResultEvent.Types.DecraftedItem.Types.Rune> runes_;

				// Token: 0x040021FE RID: 8702
				internal static DecraftResultEvent.Types.DecraftedItem F4OIGiGSdfSNQftorahk;

				// Token: 0x020007B3 RID: 1971
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x060060B0 RID: 24752 RVA: 0x00316584 File Offset: 0x00314784
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x020007B4 RID: 1972
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Rune : IMessage<DecraftResultEvent.Types.DecraftedItem.Types.Rune>, IMessage, IEquatable<DecraftResultEvent.Types.DecraftedItem.Types.Rune>, IDeepCloneable<DecraftResultEvent.Types.DecraftedItem.Types.Rune>, IBufferMessage
					{
						// Token: 0x1700118B RID: 4491
						// (get) Token: 0x060060B1 RID: 24753 RVA: 0x0031CD48 File Offset: 0x0031AF48
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<DecraftResultEvent.Types.DecraftedItem.Types.Rune> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x1700118C RID: 4492
						// (get) Token: 0x060060B2 RID: 24754 RVA: 0x0031CD58 File Offset: 0x0031AF58
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

						// Token: 0x1700118D RID: 4493
						// (get) Token: 0x060060B3 RID: 24755 RVA: 0x0031CD68 File Offset: 0x0031AF68
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

						// Token: 0x060060B4 RID: 24756 RVA: 0x0031CD78 File Offset: 0x0031AF78
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Rune()
						{
						}

						// Token: 0x060060B5 RID: 24757 RVA: 0x0031CD88 File Offset: 0x0031AF88
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Rune(DecraftResultEvent.Types.DecraftedItem.Types.Rune other)
						{
						}

						// Token: 0x060060B6 RID: 24758 RVA: 0x0031CD98 File Offset: 0x0031AF98
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public DecraftResultEvent.Types.DecraftedItem.Types.Rune Clone()
						{
							return null;
						}

						// Token: 0x1700118E RID: 4494
						// (get) Token: 0x060060B7 RID: 24759 RVA: 0x0031CDA8 File Offset: 0x0031AFA8
						// (set) Token: 0x060060B8 RID: 24760 RVA: 0x0031CDB8 File Offset: 0x0031AFB8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int RuneId
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

						// Token: 0x1700118F RID: 4495
						// (get) Token: 0x060060B9 RID: 24761 RVA: 0x0031CDC8 File Offset: 0x0031AFC8
						// (set) Token: 0x060060BA RID: 24762 RVA: 0x0031CDD8 File Offset: 0x0031AFD8
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

						// Token: 0x060060BB RID: 24763 RVA: 0x0031CDE8 File Offset: 0x0031AFE8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060060BC RID: 24764 RVA: 0x0031CDF8 File Offset: 0x0031AFF8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(DecraftResultEvent.Types.DecraftedItem.Types.Rune other)
						{
							return true;
						}

						// Token: 0x060060BD RID: 24765 RVA: 0x0031CE08 File Offset: 0x0031B008
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060060BE RID: 24766 RVA: 0x0031CE18 File Offset: 0x0031B018
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060060BF RID: 24767 RVA: 0x0031CE28 File Offset: 0x0031B028
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060060C0 RID: 24768 RVA: 0x0031CE38 File Offset: 0x0031B038
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060060C1 RID: 24769 RVA: 0x0031CE48 File Offset: 0x0031B048
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060060C2 RID: 24770 RVA: 0x0031CE58 File Offset: 0x0031B058
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(DecraftResultEvent.Types.DecraftedItem.Types.Rune other)
						{
						}

						// Token: 0x060060C3 RID: 24771 RVA: 0x0031CE68 File Offset: 0x0031B068
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060060C4 RID: 24772 RVA: 0x0031CE78 File Offset: 0x0031B078
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060060C5 RID: 24773 RVA: 0x0031CE88 File Offset: 0x0031B088
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Rune()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									return;
								case 2:
									DecraftResultEvent.Types.DecraftedItem.Types.Rune._parser = new MessageParser<DecraftResultEvent.Types.DecraftedItem.Types.Rune>(() => null);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 3;
									continue;
								}
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 2;
							}
						}

						// Token: 0x060060C6 RID: 24774 RVA: 0x0031CF54 File Offset: 0x0031B154
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool cfCnZ0gJlFH2pZQUPhJA()
						{
							return true;
						}

						// Token: 0x060060C7 RID: 24775 RVA: 0x0031CF5C File Offset: 0x0031B15C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static DecraftResultEvent.Types.DecraftedItem.Types.Rune Kce7CrgJcb3A1GpmCrf9()
						{
							return null;
						}

						// Token: 0x040021FF RID: 8703
						private static readonly MessageParser<DecraftResultEvent.Types.DecraftedItem.Types.Rune> _parser;

						// Token: 0x04002200 RID: 8704
						private UnknownFieldSet _unknownFields;

						// Token: 0x04002201 RID: 8705
						public const int RuneIdFieldNumber = 1;

						// Token: 0x04002202 RID: 8706
						private int runeId_;

						// Token: 0x04002203 RID: 8707
						public const int QuantityFieldNumber = 2;

						// Token: 0x04002204 RID: 8708
						private int quantity_;

						// Token: 0x04002205 RID: 8709
						internal static DecraftResultEvent.Types.DecraftedItem.Types.Rune noXpregJkmvfO2qcbHyO;
					}
				}
			}
		}
	}
}
