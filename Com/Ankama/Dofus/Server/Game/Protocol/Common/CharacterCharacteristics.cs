using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A6F RID: 2671
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristics : IMessage<CharacterCharacteristics>, IMessage, IEquatable<CharacterCharacteristics>, IDeepCloneable<CharacterCharacteristics>, IBufferMessage
	{
		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06007F68 RID: 32616 RVA: 0x0025EE44 File Offset: 0x0025D044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterCharacteristics> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06007F69 RID: 32617 RVA: 0x0025EE54 File Offset: 0x0025D054
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

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06007F6A RID: 32618 RVA: 0x0025EE64 File Offset: 0x0025D064
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

		// Token: 0x06007F6B RID: 32619 RVA: 0x0025EE74 File Offset: 0x0025D074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristics()
		{
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x0025EE84 File Offset: 0x0025D084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristics(CharacterCharacteristics other)
		{
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x0025EE94 File Offset: 0x0025D094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristics Clone()
		{
			return null;
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06007F6E RID: 32622 RVA: 0x0025EEA4 File Offset: 0x0025D0A4
		// (set) Token: 0x06007F6F RID: 32623 RVA: 0x0025EEB4 File Offset: 0x0025D0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Experience
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

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06007F70 RID: 32624 RVA: 0x0025EEC4 File Offset: 0x0025D0C4
		// (set) Token: 0x06007F71 RID: 32625 RVA: 0x0025EED4 File Offset: 0x0025D0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExperienceLevelFloor
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

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06007F72 RID: 32626 RVA: 0x0025EEE4 File Offset: 0x0025D0E4
		// (set) Token: 0x06007F73 RID: 32627 RVA: 0x0025EEF4 File Offset: 0x0025D0F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ExperienceNextLevelFloor
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

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06007F74 RID: 32628 RVA: 0x0025EF04 File Offset: 0x0025D104
		// (set) Token: 0x06007F75 RID: 32629 RVA: 0x0025EF14 File Offset: 0x0025D114
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ExperienceBonusLimit
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

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06007F76 RID: 32630 RVA: 0x0025EF24 File Offset: 0x0025D124
		// (set) Token: 0x06007F77 RID: 32631 RVA: 0x0025EF34 File Offset: 0x0025D134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Kamas
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

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06007F78 RID: 32632 RVA: 0x0025EF44 File Offset: 0x0025D144
		// (set) Token: 0x06007F79 RID: 32633 RVA: 0x0025EF54 File Offset: 0x0025D154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AlignmentInformation AlignmentInformation
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

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06007F7A RID: 32634 RVA: 0x0025EF64 File Offset: 0x0025D164
		// (set) Token: 0x06007F7B RID: 32635 RVA: 0x0025EF74 File Offset: 0x0025D174
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CriticalHitWeapon
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

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06007F7C RID: 32636 RVA: 0x0025EF84 File Offset: 0x0025D184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CharacterCharacteristic> Characteristics
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06007F7D RID: 32637 RVA: 0x0025EF94 File Offset: 0x0025D194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SpellModifier> SpellModifiers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06007F7E RID: 32638 RVA: 0x0025EFA4 File Offset: 0x0025D1A4
		// (set) Token: 0x06007F7F RID: 32639 RVA: 0x0025EFB4 File Offset: 0x0025D1B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ProbationTime
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

		// Token: 0x06007F80 RID: 32640 RVA: 0x0025EFC4 File Offset: 0x0025D1C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x0025EFD4 File Offset: 0x0025D1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristics other)
		{
			return true;
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x0025EFE4 File Offset: 0x0025D1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x0025EFF4 File Offset: 0x0025D1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x0025F004 File Offset: 0x0025D204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x0025F014 File Offset: 0x0025D214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x0025F024 File Offset: 0x0025D224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x0025F034 File Offset: 0x0025D234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristics other)
		{
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x0025F044 File Offset: 0x0025D244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x0025F054 File Offset: 0x0025D254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x0025F064 File Offset: 0x0025D264
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristics()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CharacterCharacteristics._repeated_characteristics_codec = FieldCodec.ForMessage<CharacterCharacteristic>(66U, oxaX2nvpkXxDqWMAo4I.XVInXhlssT(oxaX2nvpkXxDqWMAo4I.YgtvHEdYuN));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					CharacterCharacteristics._repeated_spellModifiers_codec = FieldCodec.ForMessage<SpellModifier>(74U, QPfB9fBlZqV9gdgbYRTO.XVInXhlssT(QPfB9fBlZqV9gdgbYRTO.vsbBlq6O4Sn));
					num2 = 4;
					continue;
				case 3:
					CharacterCharacteristics._parser = new MessageParser<CharacterCharacteristics>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x0025F190 File Offset: 0x0025D390
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uJ4UJsJGzwDrvI4VBbPl()
		{
			return true;
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x0025F198 File Offset: 0x0025D398
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristics yBxZppJgfTP4CcNBqDiA()
		{
			return null;
		}

		// Token: 0x04002E1A RID: 11802
		private static readonly MessageParser<CharacterCharacteristics> _parser;

		// Token: 0x04002E1B RID: 11803
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E1C RID: 11804
		public const int ExperienceFieldNumber = 1;

		// Token: 0x04002E1D RID: 11805
		private long experience_;

		// Token: 0x04002E1E RID: 11806
		public const int ExperienceLevelFloorFieldNumber = 2;

		// Token: 0x04002E1F RID: 11807
		private long experienceLevelFloor_;

		// Token: 0x04002E20 RID: 11808
		public const int ExperienceNextLevelFloorFieldNumber = 3;

		// Token: 0x04002E21 RID: 11809
		private long experienceNextLevelFloor_;

		// Token: 0x04002E22 RID: 11810
		public const int ExperienceBonusLimitFieldNumber = 4;

		// Token: 0x04002E23 RID: 11811
		private long experienceBonusLimit_;

		// Token: 0x04002E24 RID: 11812
		public const int KamasFieldNumber = 5;

		// Token: 0x04002E25 RID: 11813
		private long kamas_;

		// Token: 0x04002E26 RID: 11814
		public const int AlignmentInformationFieldNumber = 6;

		// Token: 0x04002E27 RID: 11815
		private AlignmentInformation alignmentInformation_;

		// Token: 0x04002E28 RID: 11816
		public const int CriticalHitWeaponFieldNumber = 7;

		// Token: 0x04002E29 RID: 11817
		private int criticalHitWeapon_;

		// Token: 0x04002E2A RID: 11818
		public const int CharacteristicsFieldNumber = 8;

		// Token: 0x04002E2B RID: 11819
		private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

		// Token: 0x04002E2C RID: 11820
		private readonly RepeatedField<CharacterCharacteristic> characteristics_;

		// Token: 0x04002E2D RID: 11821
		public const int SpellModifiersFieldNumber = 9;

		// Token: 0x04002E2E RID: 11822
		private static readonly FieldCodec<SpellModifier> _repeated_spellModifiers_codec;

		// Token: 0x04002E2F RID: 11823
		private readonly RepeatedField<SpellModifier> spellModifiers_;

		// Token: 0x04002E30 RID: 11824
		public const int ProbationTimeFieldNumber = 10;

		// Token: 0x04002E31 RID: 11825
		private long probationTime_;

		// Token: 0x04002E32 RID: 11826
		internal static CharacterCharacteristics QfYn0vJGFQHj3wFZWpNC;
	}
}
