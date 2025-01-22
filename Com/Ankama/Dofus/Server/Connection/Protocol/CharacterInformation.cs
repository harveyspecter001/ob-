using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Connection.Protocol
{
	// Token: 0x02000E3C RID: 3644
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterInformation : IMessage<CharacterInformation>, IMessage, IEquatable<CharacterInformation>, IDeepCloneable<CharacterInformation>, IBufferMessage
	{
		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x0600AF11 RID: 44817 RVA: 0x002A0E20 File Offset: 0x0029F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x002A0E30 File Offset: 0x0029F030
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

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600AF13 RID: 44819 RVA: 0x002A0E40 File Offset: 0x0029F040
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

		// Token: 0x0600AF14 RID: 44820 RVA: 0x002A0E50 File Offset: 0x0029F050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterInformation()
		{
		}

		// Token: 0x0600AF15 RID: 44821 RVA: 0x002A0E60 File Offset: 0x0029F060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterInformation(CharacterInformation other)
		{
		}

		// Token: 0x0600AF16 RID: 44822 RVA: 0x002A0E70 File Offset: 0x0029F070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterInformation Clone()
		{
			return null;
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600AF17 RID: 44823 RVA: 0x002A0E80 File Offset: 0x0029F080
		// (set) Token: 0x0600AF18 RID: 44824 RVA: 0x002A0E90 File Offset: 0x0029F090
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

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600AF19 RID: 44825 RVA: 0x002A0EA0 File Offset: 0x0029F0A0
		// (set) Token: 0x0600AF1A RID: 44826 RVA: 0x002A0EB4 File Offset: 0x0029F0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterInformation.Types.Breed Breed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterInformation.Types.Breed)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x0600AF1B RID: 44827 RVA: 0x002A0EC4 File Offset: 0x0029F0C4
		// (set) Token: 0x0600AF1C RID: 44828 RVA: 0x002A0ED8 File Offset: 0x0029F0D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterInformation.Types.Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterInformation.Types.Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x002A0EE8 File Offset: 0x0029F0E8
		// (set) Token: 0x0600AF1E RID: 44830 RVA: 0x002A0EF8 File Offset: 0x0029F0F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x0600AF1F RID: 44831 RVA: 0x002A0F08 File Offset: 0x0029F108
		// (set) Token: 0x0600AF20 RID: 44832 RVA: 0x002A0F18 File Offset: 0x0029F118
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string LastConnectionDate
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

		// Token: 0x0600AF21 RID: 44833 RVA: 0x002A0F28 File Offset: 0x0029F128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AF22 RID: 44834 RVA: 0x002A0F38 File Offset: 0x0029F138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterInformation other)
		{
			return true;
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x002A0F48 File Offset: 0x0029F148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x002A0F58 File Offset: 0x0029F158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x002A0F68 File Offset: 0x0029F168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AF26 RID: 44838 RVA: 0x002A0F78 File Offset: 0x0029F178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x002A0F88 File Offset: 0x0029F188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x002A0F98 File Offset: 0x0029F198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterInformation other)
		{
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x002A0FA8 File Offset: 0x0029F1A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AF2A RID: 44842 RVA: 0x002A0FB8 File Offset: 0x0029F1B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x002A0FC8 File Offset: 0x0029F1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						continue;
					case 3:
						goto IL_87;
					case 4:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 2;
					}
				}
				IL_87:
				CharacterInformation._parser = new MessageParser<CharacterInformation>(() => null);
				num = 4;
			}
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x002A1098 File Offset: 0x0029F298
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NMvmGEJvKTBgnUGF8h9D()
		{
			return true;
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x002A10A0 File Offset: 0x0029F2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterInformation jnI6JvJvIPJQKWHUZ16R()
		{
			return null;
		}

		// Token: 0x04004070 RID: 16496
		private static readonly MessageParser<CharacterInformation> _parser;

		// Token: 0x04004071 RID: 16497
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004072 RID: 16498
		public const int NameFieldNumber = 1;

		// Token: 0x04004073 RID: 16499
		private string name_;

		// Token: 0x04004074 RID: 16500
		public const int BreedFieldNumber = 2;

		// Token: 0x04004075 RID: 16501
		private CharacterInformation.Types.Breed breed_;

		// Token: 0x04004076 RID: 16502
		public const int GenderFieldNumber = 3;

		// Token: 0x04004077 RID: 16503
		private CharacterInformation.Types.Gender gender_;

		// Token: 0x04004078 RID: 16504
		public const int LevelFieldNumber = 4;

		// Token: 0x04004079 RID: 16505
		private int level_;

		// Token: 0x0400407A RID: 16506
		public const int LastConnectionDateFieldNumber = 5;

		// Token: 0x0400407B RID: 16507
		private string lastConnectionDate_;

		// Token: 0x0400407C RID: 16508
		internal static CharacterInformation iuESR4JvjiGqKblL4sXh;

		// Token: 0x02000E3D RID: 3645
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600AF2E RID: 44846 RVA: 0x002F4780 File Offset: 0x002F2980
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000E3E RID: 3646
			public enum Gender
			{
				// Token: 0x0400407E RID: 16510
				[OriginalName("MALE")]
				Male,
				// Token: 0x0400407F RID: 16511
				[OriginalName("FEMALE")]
				Female
			}

			// Token: 0x02000E3F RID: 3647
			public enum Breed
			{
				// Token: 0x04004081 RID: 16513
				[OriginalName("FECA")]
				Feca,
				// Token: 0x04004082 RID: 16514
				[OriginalName("OSAMODAS")]
				Osamodas,
				// Token: 0x04004083 RID: 16515
				[OriginalName("ENUTROF")]
				Enutrof,
				// Token: 0x04004084 RID: 16516
				[OriginalName("SRAM")]
				Sram,
				// Token: 0x04004085 RID: 16517
				[OriginalName("XELOR")]
				Xelor,
				// Token: 0x04004086 RID: 16518
				[OriginalName("ECAFLIP")]
				Ecaflip,
				// Token: 0x04004087 RID: 16519
				[OriginalName("ENIRIPSA")]
				Eniripsa,
				// Token: 0x04004088 RID: 16520
				[OriginalName("IOP")]
				Iop,
				// Token: 0x04004089 RID: 16521
				[OriginalName("CRA")]
				Cra,
				// Token: 0x0400408A RID: 16522
				[OriginalName("SADIDA")]
				Sadida,
				// Token: 0x0400408B RID: 16523
				[OriginalName("SACRIER")]
				Sacrier,
				// Token: 0x0400408C RID: 16524
				[OriginalName("PANDAWA")]
				Pandawa,
				// Token: 0x0400408D RID: 16525
				[OriginalName("ROGUE")]
				Rogue,
				// Token: 0x0400408E RID: 16526
				[OriginalName("MASQUERAIDER")]
				Masqueraider,
				// Token: 0x0400408F RID: 16527
				[OriginalName("FOGGERNAUTS")]
				Foggernauts,
				// Token: 0x04004090 RID: 16528
				[OriginalName("ELIOTROPE")]
				Eliotrope,
				// Token: 0x04004091 RID: 16529
				[OriginalName("HUPPERMAGE")]
				Huppermage,
				// Token: 0x04004092 RID: 16530
				[OriginalName("OUGINAK")]
				Ouginak,
				// Token: 0x04004093 RID: 16531
				[OriginalName("FORGELANCE")]
				Forgelance
			}
		}
	}
}
