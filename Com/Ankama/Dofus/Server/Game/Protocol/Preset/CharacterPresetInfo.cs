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
	// Token: 0x020001DE RID: 478
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetInfo : IMessage<CharacterPresetInfo>, IMessage, IEquatable<CharacterPresetInfo>, IDeepCloneable<CharacterPresetInfo>, IBufferMessage
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x001AC858 File Offset: 0x001AAA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetInfo> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x001AC868 File Offset: 0x001AAA68
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

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x001AC878 File Offset: 0x001AAA78
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

		// Token: 0x0600163D RID: 5693 RVA: 0x001AC888 File Offset: 0x001AAA88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfo()
		{
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x001AC898 File Offset: 0x001AAA98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfo(CharacterPresetInfo other)
		{
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x001AC8A8 File Offset: 0x001AAAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetInfo Clone()
		{
			return null;
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x001AC8B8 File Offset: 0x001AAAB8
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x001AC8C8 File Offset: 0x001AAAC8
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x001AC8D8 File Offset: 0x001AAAD8
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x001AC8E8 File Offset: 0x001AAAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x001AC8F8 File Offset: 0x001AAAF8
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x001AC908 File Offset: 0x001AAB08
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

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x001AC918 File Offset: 0x001AAB18
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x001AC928 File Offset: 0x001AAB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x001AC938 File Offset: 0x001AAB38
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x001AC948 File Offset: 0x001AAB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x001AC958 File Offset: 0x001AAB58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CharacterPresetInfo.Types.EquipmentByPositionEntry> EquipmentByPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x001AC968 File Offset: 0x001AAB68
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x001AC978 File Offset: 0x001AAB78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x001AC988 File Offset: 0x001AAB88
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x001AC998 File Offset: 0x001AAB98
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x001AC9A8 File Offset: 0x001AABA8
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x001AC9B8 File Offset: 0x001AABB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x001AC9C8 File Offset: 0x001AABC8
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x001AC9D8 File Offset: 0x001AABD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Ride Ride
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x001AC9E8 File Offset: 0x001AABE8
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x001AC9F8 File Offset: 0x001AABF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string OutfitUuid
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x001ACA08 File Offset: 0x001AAC08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasOutfitUuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x001ACA18 File Offset: 0x001AAC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearOutfitUuid()
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x001ACA28 File Offset: 0x001AAC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x001ACA38 File Offset: 0x001AAC38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetInfo other)
		{
			return true;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x001ACA48 File Offset: 0x001AAC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x001ACA58 File Offset: 0x001AAC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x001ACA68 File Offset: 0x001AAC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x001ACA78 File Offset: 0x001AAC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x001ACA88 File Offset: 0x001AAC88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x001ACA98 File Offset: 0x001AAC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetInfo other)
		{
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x001ACAA8 File Offset: 0x001AACA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x001ACAB8 File Offset: 0x001AACB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x001ACAC8 File Offset: 0x001AACC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetInfo()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CharacterPresetInfo._parser = new MessageParser<CharacterPresetInfo>(() => null);
					num2 = 3;
					continue;
				case 3:
					CharacterPresetInfo._repeated_equipmentByPosition_codec = FieldCodec.ForMessage<CharacterPresetInfo.Types.EquipmentByPositionEntry>(50U, No6Ni08cU1C7F3wDvxj.XVInXhlssT(No6Ni08cU1C7F3wDvxj.WOv8U7FkxU));
					num2 = 4;
					continue;
				case 4:
					CharacterPresetInfo.OutfitUuidDefaultValue = "";
					num2 = 5;
					continue;
				case 5:
					return;
				case 6:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 6;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x001ACBE8 File Offset: 0x001AADE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hJD6nGO108vlgDGgdT7H()
		{
			return true;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x001ACBF0 File Offset: 0x001AADF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetInfo rANT9sO1CFcuk1h44vM3()
		{
			return null;
		}

		// Token: 0x040007DC RID: 2012
		private static readonly MessageParser<CharacterPresetInfo> _parser;

		// Token: 0x040007DD RID: 2013
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007DE RID: 2014
		public const int UuidFieldNumber = 1;

		// Token: 0x040007DF RID: 2015
		private string uuid_;

		// Token: 0x040007E0 RID: 2016
		public const int NameFieldNumber = 2;

		// Token: 0x040007E1 RID: 2017
		private string name_;

		// Token: 0x040007E2 RID: 2018
		public const int SymbolIdFieldNumber = 3;

		// Token: 0x040007E3 RID: 2019
		private int symbolId_;

		// Token: 0x040007E4 RID: 2020
		public const int IsFavoriteFieldNumber = 4;

		// Token: 0x040007E5 RID: 2021
		private bool isFavorite_;

		// Token: 0x040007E6 RID: 2022
		public const int LastModificationDateFieldNumber = 5;

		// Token: 0x040007E7 RID: 2023
		private string lastModificationDate_;

		// Token: 0x040007E8 RID: 2024
		public const int EquipmentByPositionFieldNumber = 6;

		// Token: 0x040007E9 RID: 2025
		private static readonly FieldCodec<CharacterPresetInfo.Types.EquipmentByPositionEntry> _repeated_equipmentByPosition_codec;

		// Token: 0x040007EA RID: 2026
		private readonly RepeatedField<CharacterPresetInfo.Types.EquipmentByPositionEntry> equipmentByPosition_;

		// Token: 0x040007EB RID: 2027
		public const int SpellPresetFieldNumber = 7;

		// Token: 0x040007EC RID: 2028
		private SpellPreset spellPreset_;

		// Token: 0x040007ED RID: 2029
		public const int CharacteristicsInfoFieldNumber = 8;

		// Token: 0x040007EE RID: 2030
		private CharacteristicsInfo characteristicsInfo_;

		// Token: 0x040007EF RID: 2031
		public const int PresetLookFieldNumber = 9;

		// Token: 0x040007F0 RID: 2032
		private PresetLook presetLook_;

		// Token: 0x040007F1 RID: 2033
		public const int RideFieldNumber = 10;

		// Token: 0x040007F2 RID: 2034
		private Ride ride_;

		// Token: 0x040007F3 RID: 2035
		public const int OutfitUuidFieldNumber = 11;

		// Token: 0x040007F4 RID: 2036
		private static readonly string OutfitUuidDefaultValue;

		// Token: 0x040007F5 RID: 2037
		private string outfitUuid_;

		// Token: 0x040007F6 RID: 2038
		private static CharacterPresetInfo hMKNdUO1V3DkLBpZAZRc;

		// Token: 0x020001DF RID: 479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001664 RID: 5732 RVA: 0x002B02C0 File Offset: 0x002AE4C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001E0 RID: 480
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class EquipmentByPositionEntry : IMessage<CharacterPresetInfo.Types.EquipmentByPositionEntry>, IMessage, IEquatable<CharacterPresetInfo.Types.EquipmentByPositionEntry>, IDeepCloneable<CharacterPresetInfo.Types.EquipmentByPositionEntry>, IBufferMessage
			{
				// Token: 0x170003F8 RID: 1016
				// (get) Token: 0x06001665 RID: 5733 RVA: 0x002F81B0 File Offset: 0x002F63B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<CharacterPresetInfo.Types.EquipmentByPositionEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170003F9 RID: 1017
				// (get) Token: 0x06001666 RID: 5734 RVA: 0x002F81C0 File Offset: 0x002F63C0
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

				// Token: 0x170003FA RID: 1018
				// (get) Token: 0x06001667 RID: 5735 RVA: 0x002F81D0 File Offset: 0x002F63D0
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

				// Token: 0x06001668 RID: 5736 RVA: 0x002F81E0 File Offset: 0x002F63E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EquipmentByPositionEntry()
				{
				}

				// Token: 0x06001669 RID: 5737 RVA: 0x002F81F0 File Offset: 0x002F63F0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EquipmentByPositionEntry(CharacterPresetInfo.Types.EquipmentByPositionEntry other)
				{
				}

				// Token: 0x0600166A RID: 5738 RVA: 0x002F8200 File Offset: 0x002F6400
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterPresetInfo.Types.EquipmentByPositionEntry Clone()
				{
					return null;
				}

				// Token: 0x170003FB RID: 1019
				// (get) Token: 0x0600166B RID: 5739 RVA: 0x002F8210 File Offset: 0x002F6410
				// (set) Token: 0x0600166C RID: 5740 RVA: 0x002F8220 File Offset: 0x002F6420
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x170003FC RID: 1020
				// (get) Token: 0x0600166D RID: 5741 RVA: 0x002F8230 File Offset: 0x002F6430
				// (set) Token: 0x0600166E RID: 5742 RVA: 0x002F8240 File Offset: 0x002F6440
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public Equipment Value
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

				// Token: 0x0600166F RID: 5743 RVA: 0x002F8250 File Offset: 0x002F6450
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001670 RID: 5744 RVA: 0x002F8260 File Offset: 0x002F6460
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterPresetInfo.Types.EquipmentByPositionEntry other)
				{
					return true;
				}

				// Token: 0x06001671 RID: 5745 RVA: 0x002F8270 File Offset: 0x002F6470
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001672 RID: 5746 RVA: 0x002F8280 File Offset: 0x002F6480
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001673 RID: 5747 RVA: 0x002F8290 File Offset: 0x002F6490
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001674 RID: 5748 RVA: 0x002F82A0 File Offset: 0x002F64A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001675 RID: 5749 RVA: 0x002F82B0 File Offset: 0x002F64B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001676 RID: 5750 RVA: 0x002F82C0 File Offset: 0x002F64C0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterPresetInfo.Types.EquipmentByPositionEntry other)
				{
				}

				// Token: 0x06001677 RID: 5751 RVA: 0x002F82D0 File Offset: 0x002F64D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001678 RID: 5752 RVA: 0x002F82E0 File Offset: 0x002F64E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001679 RID: 5753 RVA: 0x002F82F0 File Offset: 0x002F64F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static EquipmentByPositionEntry()
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
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						CharacterPresetInfo.Types.EquipmentByPositionEntry._parser = new MessageParser<CharacterPresetInfo.Types.EquipmentByPositionEntry>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x0600167A RID: 5754 RVA: 0x002F83D4 File Offset: 0x002F65D4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool JnLWi0Gp5WaKJVux2IMa()
				{
					return true;
				}

				// Token: 0x0600167B RID: 5755 RVA: 0x002F83DC File Offset: 0x002F65DC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterPresetInfo.Types.EquipmentByPositionEntry aa3SCeGpy0qtSd8hogfv()
				{
					return null;
				}

				// Token: 0x040007F7 RID: 2039
				private static readonly MessageParser<CharacterPresetInfo.Types.EquipmentByPositionEntry> _parser;

				// Token: 0x040007F8 RID: 2040
				private UnknownFieldSet _unknownFields;

				// Token: 0x040007F9 RID: 2041
				public const int KeyFieldNumber = 1;

				// Token: 0x040007FA RID: 2042
				private int key_;

				// Token: 0x040007FB RID: 2043
				public const int ValueFieldNumber = 2;

				// Token: 0x040007FC RID: 2044
				private Equipment value_;

				// Token: 0x040007FD RID: 2045
				internal static CharacterPresetInfo.Types.EquipmentByPositionEntry oXmwqWGpaN3MwEgGn6xg;
			}
		}
	}
}
