using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000254 RID: 596
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetEquipmentUpdateResponse : IMessage<PresetEquipmentUpdateResponse>, IMessage, IEquatable<PresetEquipmentUpdateResponse>, IDeepCloneable<PresetEquipmentUpdateResponse>, IBufferMessage
	{
		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x001B14A8 File Offset: 0x001AF6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetEquipmentUpdateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x001B14B8 File Offset: 0x001AF6B8
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x001B14C8 File Offset: 0x001AF6C8
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

		// Token: 0x06001BC2 RID: 7106 RVA: 0x001B14D8 File Offset: 0x001AF6D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetEquipmentUpdateResponse()
		{
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x001B14E8 File Offset: 0x001AF6E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetEquipmentUpdateResponse(PresetEquipmentUpdateResponse other)
		{
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x001B14F8 File Offset: 0x001AF6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetEquipmentUpdateResponse Clone()
		{
			return null;
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x001B1508 File Offset: 0x001AF708
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x001B1518 File Offset: 0x001AF718
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsSuccess
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x001B1528 File Offset: 0x001AF728
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x001B1538 File Offset: 0x001AF738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetEquipmentUpdateResponse.Types.EquipmentRefresh EquipmentRefresh
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

		// Token: 0x06001BC9 RID: 7113 RVA: 0x001B1548 File Offset: 0x001AF748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x001B1558 File Offset: 0x001AF758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetEquipmentUpdateResponse other)
		{
			return true;
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x001B1568 File Offset: 0x001AF768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x001B1578 File Offset: 0x001AF778
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x001B1588 File Offset: 0x001AF788
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x001B1598 File Offset: 0x001AF798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x001B15A8 File Offset: 0x001AF7A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x001B15B8 File Offset: 0x001AF7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetEquipmentUpdateResponse other)
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x001B15C8 File Offset: 0x001AF7C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x001B15D8 File Offset: 0x001AF7D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x001B15E8 File Offset: 0x001AF7E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetEquipmentUpdateResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					PresetEquipmentUpdateResponse._parser = new MessageParser<PresetEquipmentUpdateResponse>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x001B16B4 File Offset: 0x001AF8B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool djdbieO52UGlIDLfpHDJ()
		{
			return true;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x001B16BC File Offset: 0x001AF8BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetEquipmentUpdateResponse r2wwRvO5E0v1RCjcKdxE()
		{
			return null;
		}

		// Token: 0x040009DD RID: 2525
		private static readonly MessageParser<PresetEquipmentUpdateResponse> _parser;

		// Token: 0x040009DE RID: 2526
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009DF RID: 2527
		public const int IsSuccessFieldNumber = 1;

		// Token: 0x040009E0 RID: 2528
		private bool isSuccess_;

		// Token: 0x040009E1 RID: 2529
		public const int EquipmentRefreshFieldNumber = 2;

		// Token: 0x040009E2 RID: 2530
		private PresetEquipmentUpdateResponse.Types.EquipmentRefresh equipmentRefresh_;

		// Token: 0x040009E3 RID: 2531
		private static PresetEquipmentUpdateResponse PmnmKvO59MOWZmqPboJQ;

		// Token: 0x02000255 RID: 597
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06001BD6 RID: 7126 RVA: 0x002B2330 File Offset: 0x002B0530
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000256 RID: 598
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class EquipmentRefresh : IMessage<PresetEquipmentUpdateResponse.Types.EquipmentRefresh>, IMessage, IEquatable<PresetEquipmentUpdateResponse.Types.EquipmentRefresh>, IDeepCloneable<PresetEquipmentUpdateResponse.Types.EquipmentRefresh>, IBufferMessage
			{
				// Token: 0x170004F6 RID: 1270
				// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x002FA434 File Offset: 0x002F8634
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetEquipmentUpdateResponse.Types.EquipmentRefresh> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170004F7 RID: 1271
				// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x002FA444 File Offset: 0x002F8644
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

				// Token: 0x170004F8 RID: 1272
				// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x002FA454 File Offset: 0x002F8654
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

				// Token: 0x06001BDA RID: 7130 RVA: 0x002FA464 File Offset: 0x002F8664
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EquipmentRefresh()
				{
				}

				// Token: 0x06001BDB RID: 7131 RVA: 0x002FA474 File Offset: 0x002F8674
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EquipmentRefresh(PresetEquipmentUpdateResponse.Types.EquipmentRefresh other)
				{
				}

				// Token: 0x06001BDC RID: 7132 RVA: 0x002FA484 File Offset: 0x002F8684
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetEquipmentUpdateResponse.Types.EquipmentRefresh Clone()
				{
					return null;
				}

				// Token: 0x170004F9 RID: 1273
				// (get) Token: 0x06001BDD RID: 7133 RVA: 0x002FA494 File Offset: 0x002F8694
				// (set) Token: 0x06001BDE RID: 7134 RVA: 0x002FA4A4 File Offset: 0x002F86A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public CharacteristicsInfo CharacteristicsInfo
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

				// Token: 0x170004FA RID: 1274
				// (get) Token: 0x06001BDF RID: 7135 RVA: 0x002FA4B4 File Offset: 0x002F86B4
				// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x002FA4C4 File Offset: 0x002F86C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public PresetLook PresetLook
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

				// Token: 0x06001BE1 RID: 7137 RVA: 0x002FA4D4 File Offset: 0x002F86D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001BE2 RID: 7138 RVA: 0x002FA4E4 File Offset: 0x002F86E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetEquipmentUpdateResponse.Types.EquipmentRefresh other)
				{
					return true;
				}

				// Token: 0x06001BE3 RID: 7139 RVA: 0x002FA4F4 File Offset: 0x002F86F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001BE4 RID: 7140 RVA: 0x002FA504 File Offset: 0x002F8704
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001BE5 RID: 7141 RVA: 0x002FA514 File Offset: 0x002F8714
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001BE6 RID: 7142 RVA: 0x002FA524 File Offset: 0x002F8724
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001BE7 RID: 7143 RVA: 0x002FA534 File Offset: 0x002F8734
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001BE8 RID: 7144 RVA: 0x002FA544 File Offset: 0x002F8744
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetEquipmentUpdateResponse.Types.EquipmentRefresh other)
				{
				}

				// Token: 0x06001BE9 RID: 7145 RVA: 0x002FA554 File Offset: 0x002F8754
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001BEA RID: 7146 RVA: 0x002FA564 File Offset: 0x002F8764
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001BEB RID: 7147 RVA: 0x002FA574 File Offset: 0x002F8774
				[MethodImpl(MethodImplOptions.NoInlining)]
				static EquipmentRefresh()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 3:
							return;
						case 4:
							PresetEquipmentUpdateResponse.Types.EquipmentRefresh._parser = new MessageParser<PresetEquipmentUpdateResponse.Types.EquipmentRefresh>(() => null);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06001BEC RID: 7148 RVA: 0x002FA640 File Offset: 0x002F8840
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool viJMiVGH1rmsDMQ1Aysg()
				{
					return true;
				}

				// Token: 0x06001BED RID: 7149 RVA: 0x002FA648 File Offset: 0x002F8848
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetEquipmentUpdateResponse.Types.EquipmentRefresh Cc1GynGHatgpmpNMusNA()
				{
					return null;
				}

				// Token: 0x040009E4 RID: 2532
				private static readonly MessageParser<PresetEquipmentUpdateResponse.Types.EquipmentRefresh> _parser;

				// Token: 0x040009E5 RID: 2533
				private UnknownFieldSet _unknownFields;

				// Token: 0x040009E6 RID: 2534
				public const int CharacteristicsInfoFieldNumber = 1;

				// Token: 0x040009E7 RID: 2535
				private CharacteristicsInfo characteristicsInfo_;

				// Token: 0x040009E8 RID: 2536
				public const int PresetLookFieldNumber = 2;

				// Token: 0x040009E9 RID: 2537
				private PresetLook presetLook_;

				// Token: 0x040009EA RID: 2538
				internal static PresetEquipmentUpdateResponse.Types.EquipmentRefresh hAXcDFGHoZi8OIQrrbwb;
			}
		}
	}
}
