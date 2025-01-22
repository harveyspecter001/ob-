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
	// Token: 0x02000A48 RID: 2632
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterRemodelingInformation : IMessage<CharacterRemodelingInformation>, IMessage, IEquatable<CharacterRemodelingInformation>, IDeepCloneable<CharacterRemodelingInformation>, IBufferMessage
	{
		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06007D6D RID: 32109 RVA: 0x0025CFBC File Offset: 0x0025B1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterRemodelingInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x0025CFCC File Offset: 0x0025B1CC
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

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06007D6F RID: 32111 RVA: 0x0025CFDC File Offset: 0x0025B1DC
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

		// Token: 0x06007D70 RID: 32112 RVA: 0x0025CFEC File Offset: 0x0025B1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRemodelingInformation()
		{
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x0025CFFC File Offset: 0x0025B1FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRemodelingInformation(CharacterRemodelingInformation other)
		{
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x0025D00C File Offset: 0x0025B20C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterRemodelingInformation Clone()
		{
			return null;
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06007D73 RID: 32115 RVA: 0x0025D01C File Offset: 0x0025B21C
		// (set) Token: 0x06007D74 RID: 32116 RVA: 0x0025D02C File Offset: 0x0025B22C
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

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06007D75 RID: 32117 RVA: 0x0025D03C File Offset: 0x0025B23C
		// (set) Token: 0x06007D76 RID: 32118 RVA: 0x0025D04C File Offset: 0x0025B24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BreedId
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

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06007D77 RID: 32119 RVA: 0x0025D05C File Offset: 0x0025B25C
		// (set) Token: 0x06007D78 RID: 32120 RVA: 0x0025D070 File Offset: 0x0025B270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x0025D080 File Offset: 0x0025B280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Colors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06007D7A RID: 32122 RVA: 0x0025D090 File Offset: 0x0025B290
		// (set) Token: 0x06007D7B RID: 32123 RVA: 0x0025D0A0 File Offset: 0x0025B2A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CosmeticId
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

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06007D7C RID: 32124 RVA: 0x0025D0B0 File Offset: 0x0025B2B0
		// (set) Token: 0x06007D7D RID: 32125 RVA: 0x0025D0C0 File Offset: 0x0025B2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterRemodelingInformation.Types.CharacterToRemodelInformation CharacterToRemodelInformation
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

		// Token: 0x06007D7E RID: 32126 RVA: 0x0025D0D0 File Offset: 0x0025B2D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x0025D0E0 File Offset: 0x0025B2E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterRemodelingInformation other)
		{
			return true;
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x0025D0F0 File Offset: 0x0025B2F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007D81 RID: 32129 RVA: 0x0025D100 File Offset: 0x0025B300
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x0025D110 File Offset: 0x0025B310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x0025D120 File Offset: 0x0025B320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007D84 RID: 32132 RVA: 0x0025D130 File Offset: 0x0025B330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007D85 RID: 32133 RVA: 0x0025D140 File Offset: 0x0025B340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterRemodelingInformation other)
		{
		}

		// Token: 0x06007D86 RID: 32134 RVA: 0x0025D150 File Offset: 0x0025B350
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007D87 RID: 32135 RVA: 0x0025D160 File Offset: 0x0025B360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007D88 RID: 32136 RVA: 0x0025D170 File Offset: 0x0025B370
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterRemodelingInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						CharacterRemodelingInformation._parser = new MessageParser<CharacterRemodelingInformation>(() => null);
						num2 = 3;
						continue;
					case 2:
						return;
					case 3:
						goto IL_B0;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 1;
					}
				}
				IL_B0:
				CharacterRemodelingInformation._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(34U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num = 2;
			}
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x0025D274 File Offset: 0x0025B474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tTmmUGJGlF1Zk6YmRcVx()
		{
			return true;
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x0025D27C File Offset: 0x0025B47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterRemodelingInformation CCRwSRJGc4owdxpSVnx3()
		{
			return null;
		}

		// Token: 0x04002D46 RID: 11590
		private static readonly MessageParser<CharacterRemodelingInformation> _parser;

		// Token: 0x04002D47 RID: 11591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D48 RID: 11592
		public const int NameFieldNumber = 1;

		// Token: 0x04002D49 RID: 11593
		private string name_;

		// Token: 0x04002D4A RID: 11594
		public const int BreedIdFieldNumber = 2;

		// Token: 0x04002D4B RID: 11595
		private int breedId_;

		// Token: 0x04002D4C RID: 11596
		public const int GenderFieldNumber = 3;

		// Token: 0x04002D4D RID: 11597
		private Gender gender_;

		// Token: 0x04002D4E RID: 11598
		public const int ColorsFieldNumber = 4;

		// Token: 0x04002D4F RID: 11599
		private static readonly FieldCodec<int> _repeated_colors_codec;

		// Token: 0x04002D50 RID: 11600
		private readonly RepeatedField<int> colors_;

		// Token: 0x04002D51 RID: 11601
		public const int CosmeticIdFieldNumber = 5;

		// Token: 0x04002D52 RID: 11602
		private int cosmeticId_;

		// Token: 0x04002D53 RID: 11603
		public const int CharacterToRemodelInformationFieldNumber = 6;

		// Token: 0x04002D54 RID: 11604
		private CharacterRemodelingInformation.Types.CharacterToRemodelInformation characterToRemodelInformation_;

		// Token: 0x04002D55 RID: 11605
		internal static CharacterRemodelingInformation aYHFM4JGkqQoF1dLC11U;

		// Token: 0x02000A49 RID: 2633
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06007D8B RID: 32139 RVA: 0x002DF4D8 File Offset: 0x002DD6D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A4A RID: 2634
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class CharacterToRemodelInformation : IMessage<CharacterRemodelingInformation.Types.CharacterToRemodelInformation>, IMessage, IEquatable<CharacterRemodelingInformation.Types.CharacterToRemodelInformation>, IDeepCloneable<CharacterRemodelingInformation.Types.CharacterToRemodelInformation>, IBufferMessage
			{
				// Token: 0x170016C5 RID: 5829
				// (get) Token: 0x06007D8C RID: 32140 RVA: 0x003079A0 File Offset: 0x00305BA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<CharacterRemodelingInformation.Types.CharacterToRemodelInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170016C6 RID: 5830
				// (get) Token: 0x06007D8D RID: 32141 RVA: 0x003079B0 File Offset: 0x00305BB0
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

				// Token: 0x170016C7 RID: 5831
				// (get) Token: 0x06007D8E RID: 32142 RVA: 0x003079C0 File Offset: 0x00305BC0
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

				// Token: 0x06007D8F RID: 32143 RVA: 0x003079D0 File Offset: 0x00305BD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterToRemodelInformation()
				{
				}

				// Token: 0x06007D90 RID: 32144 RVA: 0x003079E0 File Offset: 0x00305BE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterToRemodelInformation(CharacterRemodelingInformation.Types.CharacterToRemodelInformation other)
				{
				}

				// Token: 0x06007D91 RID: 32145 RVA: 0x003079F0 File Offset: 0x00305BF0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterRemodelingInformation.Types.CharacterToRemodelInformation Clone()
				{
					return null;
				}

				// Token: 0x170016C8 RID: 5832
				// (get) Token: 0x06007D92 RID: 32146 RVA: 0x00307A00 File Offset: 0x00305C00
				// (set) Token: 0x06007D93 RID: 32147 RVA: 0x00307A10 File Offset: 0x00305C10
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int PossibleChangeMask
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

				// Token: 0x170016C9 RID: 5833
				// (get) Token: 0x06007D94 RID: 32148 RVA: 0x00307A20 File Offset: 0x00305C20
				// (set) Token: 0x06007D95 RID: 32149 RVA: 0x00307A30 File Offset: 0x00305C30
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MandatoryChangeMask
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

				// Token: 0x06007D96 RID: 32150 RVA: 0x00307A40 File Offset: 0x00305C40
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007D97 RID: 32151 RVA: 0x00307A50 File Offset: 0x00305C50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterRemodelingInformation.Types.CharacterToRemodelInformation other)
				{
					return true;
				}

				// Token: 0x06007D98 RID: 32152 RVA: 0x00307A60 File Offset: 0x00305C60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007D99 RID: 32153 RVA: 0x00307A70 File Offset: 0x00305C70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007D9A RID: 32154 RVA: 0x00307A80 File Offset: 0x00305C80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007D9B RID: 32155 RVA: 0x00307A90 File Offset: 0x00305C90
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007D9C RID: 32156 RVA: 0x00307AA0 File Offset: 0x00305CA0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007D9D RID: 32157 RVA: 0x00307AB0 File Offset: 0x00305CB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterRemodelingInformation.Types.CharacterToRemodelInformation other)
				{
				}

				// Token: 0x06007D9E RID: 32158 RVA: 0x00307AC0 File Offset: 0x00305CC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007D9F RID: 32159 RVA: 0x00307AD0 File Offset: 0x00305CD0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007DA0 RID: 32160 RVA: 0x00307AE0 File Offset: 0x00305CE0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static CharacterToRemodelInformation()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						}
						CharacterRemodelingInformation.Types.CharacterToRemodelInformation._parser = new MessageParser<CharacterRemodelingInformation.Types.CharacterToRemodelInformation>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
						{
							num2 = 4;
						}
					}
				}

				// Token: 0x06007DA1 RID: 32161 RVA: 0x00307BC4 File Offset: 0x00305DC4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool c2oWeYGuB8a3CXf8Usks()
				{
					return true;
				}

				// Token: 0x06007DA2 RID: 32162 RVA: 0x00307BCC File Offset: 0x00305DCC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterRemodelingInformation.Types.CharacterToRemodelInformation LnLICLGueSatK73S97wo()
				{
					return null;
				}

				// Token: 0x04002D56 RID: 11606
				private static readonly MessageParser<CharacterRemodelingInformation.Types.CharacterToRemodelInformation> _parser;

				// Token: 0x04002D57 RID: 11607
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002D58 RID: 11608
				public const int PossibleChangeMaskFieldNumber = 1;

				// Token: 0x04002D59 RID: 11609
				private int possibleChangeMask_;

				// Token: 0x04002D5A RID: 11610
				public const int MandatoryChangeMaskFieldNumber = 2;

				// Token: 0x04002D5B RID: 11611
				private int mandatoryChangeMask_;

				// Token: 0x04002D5C RID: 11612
				internal static CharacterRemodelingInformation.Types.CharacterToRemodelInformation hVQXg7GuAYbgdjI52pik;
			}
		}
	}
}
