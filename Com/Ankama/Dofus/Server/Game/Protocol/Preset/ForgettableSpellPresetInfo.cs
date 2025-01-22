using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001E3 RID: 483
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetInfo : IMessage<ForgettableSpellPresetInfo>, IMessage, IEquatable<ForgettableSpellPresetInfo>, IDeepCloneable<ForgettableSpellPresetInfo>, IBufferMessage
	{
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x001ACBF8 File Offset: 0x001AADF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ForgettableSpellPresetInfo> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x001ACC08 File Offset: 0x001AAE08
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x001ACC18 File Offset: 0x001AAE18
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

		// Token: 0x06001689 RID: 5769 RVA: 0x001ACC28 File Offset: 0x001AAE28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfo()
		{
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x001ACC38 File Offset: 0x001AAE38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfo(ForgettableSpellPresetInfo other)
		{
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x001ACC48 File Offset: 0x001AAE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetInfo Clone()
		{
			return null;
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x001ACC58 File Offset: 0x001AAE58
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x001ACC68 File Offset: 0x001AAE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Uuid
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x001ACC78 File Offset: 0x001AAE78
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x001ACC88 File Offset: 0x001AAE88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x001ACC98 File Offset: 0x001AAE98
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x001ACCA8 File Offset: 0x001AAEA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SymbolId
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x001ACCB8 File Offset: 0x001AAEB8
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x001ACCC8 File Offset: 0x001AAEC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsFavorite
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x001ACCD8 File Offset: 0x001AAED8
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x001ACCE8 File Offset: 0x001AAEE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string LastModificationDate
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

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x001ACCF8 File Offset: 0x001AAEF8
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x001ACD08 File Offset: 0x001AAF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpellPreset SpellPreset
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x001ACD18 File Offset: 0x001AAF18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry> ForgettableSpellInfoById
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x001ACD28 File Offset: 0x001AAF28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x001ACD38 File Offset: 0x001AAF38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetInfo other)
		{
			return true;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x001ACD48 File Offset: 0x001AAF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x001ACD58 File Offset: 0x001AAF58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x001ACD68 File Offset: 0x001AAF68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x001ACD78 File Offset: 0x001AAF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x001ACD88 File Offset: 0x001AAF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x001ACD98 File Offset: 0x001AAF98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetInfo other)
		{
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x001ACDA8 File Offset: 0x001AAFA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x001ACDB8 File Offset: 0x001AAFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x001ACDC8 File Offset: 0x001AAFC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetInfo()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					ForgettableSpellPresetInfo._parser = new MessageParser<ForgettableSpellPresetInfo>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					ForgettableSpellPresetInfo._repeated_forgettableSpellInfoById_codec = FieldCodec.ForMessage<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry>(58U, en9bcr81iesFEtR0YRT.XVInXhlssT(en9bcr81iesFEtR0YRT.Y1a8aVmfA1));
					num2 = 4;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x001ACED0 File Offset: 0x001AB0D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jkswXKO1thUyamkYXNii()
		{
			return true;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x001ACED8 File Offset: 0x001AB0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetInfo twxEuxO1wtAyJB7VqdQA()
		{
			return null;
		}

		// Token: 0x04000802 RID: 2050
		private static readonly MessageParser<ForgettableSpellPresetInfo> _parser;

		// Token: 0x04000803 RID: 2051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000804 RID: 2052
		public const int UuidFieldNumber = 1;

		// Token: 0x04000805 RID: 2053
		private string uuid_;

		// Token: 0x04000806 RID: 2054
		public const int NameFieldNumber = 2;

		// Token: 0x04000807 RID: 2055
		private string name_;

		// Token: 0x04000808 RID: 2056
		public const int SymbolIdFieldNumber = 3;

		// Token: 0x04000809 RID: 2057
		private int symbolId_;

		// Token: 0x0400080A RID: 2058
		public const int IsFavoriteFieldNumber = 4;

		// Token: 0x0400080B RID: 2059
		private bool isFavorite_;

		// Token: 0x0400080C RID: 2060
		public const int LastModificationDateFieldNumber = 5;

		// Token: 0x0400080D RID: 2061
		private string lastModificationDate_;

		// Token: 0x0400080E RID: 2062
		public const int SpellPresetFieldNumber = 6;

		// Token: 0x0400080F RID: 2063
		private SpellPreset spellPreset_;

		// Token: 0x04000810 RID: 2064
		public const int ForgettableSpellInfoByIdFieldNumber = 7;

		// Token: 0x04000811 RID: 2065
		private static readonly FieldCodec<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry> _repeated_forgettableSpellInfoById_codec;

		// Token: 0x04000812 RID: 2066
		private readonly RepeatedField<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry> forgettableSpellInfoById_;

		// Token: 0x04000813 RID: 2067
		private static ForgettableSpellPresetInfo matXJuO1D3JMZ14CxouN;

		// Token: 0x020001E4 RID: 484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060016A6 RID: 5798 RVA: 0x002B03E4 File Offset: 0x002AE5E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001E5 RID: 485
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ForgettableSpellInfoByIdEntry : IMessage<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry>, IMessage, IEquatable<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry>, IDeepCloneable<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry>, IBufferMessage
			{
				// Token: 0x17000407 RID: 1031
				// (get) Token: 0x060016A7 RID: 5799 RVA: 0x002F83E4 File Offset: 0x002F65E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000408 RID: 1032
				// (get) Token: 0x060016A8 RID: 5800 RVA: 0x002F83F4 File Offset: 0x002F65F4
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

				// Token: 0x17000409 RID: 1033
				// (get) Token: 0x060016A9 RID: 5801 RVA: 0x002F8404 File Offset: 0x002F6604
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

				// Token: 0x060016AA RID: 5802 RVA: 0x002F8414 File Offset: 0x002F6614
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ForgettableSpellInfoByIdEntry()
				{
				}

				// Token: 0x060016AB RID: 5803 RVA: 0x002F8424 File Offset: 0x002F6624
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ForgettableSpellInfoByIdEntry(ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry other)
				{
				}

				// Token: 0x060016AC RID: 5804 RVA: 0x002F8434 File Offset: 0x002F6634
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry Clone()
				{
					return null;
				}

				// Token: 0x1700040A RID: 1034
				// (get) Token: 0x060016AD RID: 5805 RVA: 0x002F8444 File Offset: 0x002F6644
				// (set) Token: 0x060016AE RID: 5806 RVA: 0x002F8454 File Offset: 0x002F6654
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Key
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

				// Token: 0x1700040B RID: 1035
				// (get) Token: 0x060016AF RID: 5807 RVA: 0x002F8464 File Offset: 0x002F6664
				// (set) Token: 0x060016B0 RID: 5808 RVA: 0x002F8474 File Offset: 0x002F6674
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ForgettableSpellInfo Value
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

				// Token: 0x060016B1 RID: 5809 RVA: 0x002F8484 File Offset: 0x002F6684
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060016B2 RID: 5810 RVA: 0x002F8494 File Offset: 0x002F6694
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry other)
				{
					return true;
				}

				// Token: 0x060016B3 RID: 5811 RVA: 0x002F84A4 File Offset: 0x002F66A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060016B4 RID: 5812 RVA: 0x002F84B4 File Offset: 0x002F66B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060016B5 RID: 5813 RVA: 0x002F84C4 File Offset: 0x002F66C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060016B6 RID: 5814 RVA: 0x002F84D4 File Offset: 0x002F66D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060016B7 RID: 5815 RVA: 0x002F84E4 File Offset: 0x002F66E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060016B8 RID: 5816 RVA: 0x002F84F4 File Offset: 0x002F66F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry other)
				{
				}

				// Token: 0x060016B9 RID: 5817 RVA: 0x002F8504 File Offset: 0x002F6704
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060016BA RID: 5818 RVA: 0x002F8514 File Offset: 0x002F6714
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060016BB RID: 5819 RVA: 0x002F8524 File Offset: 0x002F6724
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ForgettableSpellInfoByIdEntry()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry._parser = new MessageParser<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry>(() => null);
							num2 = 3;
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x060016BC RID: 5820 RVA: 0x002F8608 File Offset: 0x002F6808
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool I5BZh9GpLH714j2MSkDb()
				{
					return true;
				}

				// Token: 0x060016BD RID: 5821 RVA: 0x002F8610 File Offset: 0x002F6810
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry PwfpgKGpWRF6DqAj9Gl4()
				{
					return null;
				}

				// Token: 0x04000814 RID: 2068
				private static readonly MessageParser<ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry> _parser;

				// Token: 0x04000815 RID: 2069
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000816 RID: 2070
				public const int KeyFieldNumber = 1;

				// Token: 0x04000817 RID: 2071
				private int key_;

				// Token: 0x04000818 RID: 2072
				public const int ValueFieldNumber = 2;

				// Token: 0x04000819 RID: 2073
				private ForgettableSpellInfo value_;

				// Token: 0x0400081A RID: 2074
				internal static ForgettableSpellPresetInfo.Types.ForgettableSpellInfoByIdEntry bedtQVGp6L0c5U5YClOK;
			}
		}
	}
}
