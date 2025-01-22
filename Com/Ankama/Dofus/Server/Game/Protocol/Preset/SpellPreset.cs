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
	// Token: 0x020001F9 RID: 505
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellPreset : IMessage<SpellPreset>, IMessage, IEquatable<SpellPreset>, IDeepCloneable<SpellPreset>, IBufferMessage
	{
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x001ADC94 File Offset: 0x001ABE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpellPreset> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x001ADCA4 File Offset: 0x001ABEA4
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x001ADCB4 File Offset: 0x001ABEB4
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

		// Token: 0x060017B5 RID: 6069 RVA: 0x001ADCC4 File Offset: 0x001ABEC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellPreset()
		{
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x001ADCD4 File Offset: 0x001ABED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellPreset(SpellPreset other)
		{
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x001ADCE4 File Offset: 0x001ABEE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellPreset Clone()
		{
			return null;
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x001ADCF4 File Offset: 0x001ABEF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SpellPreset.Types.SpellPositionsByIdEntry> SpellPositionsById
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x001ADD04 File Offset: 0x001ABF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x001ADD14 File Offset: 0x001ABF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellPreset other)
		{
			return true;
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x001ADD24 File Offset: 0x001ABF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x001ADD34 File Offset: 0x001ABF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x001ADD44 File Offset: 0x001ABF44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x001ADD54 File Offset: 0x001ABF54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x001ADD64 File Offset: 0x001ABF64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x001ADD74 File Offset: 0x001ABF74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellPreset other)
		{
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x001ADD84 File Offset: 0x001ABF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x001ADD94 File Offset: 0x001ABF94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x001ADDA4 File Offset: 0x001ABFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellPreset()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					SpellPreset._parser = new MessageParser<SpellPreset>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					SpellPreset._repeated_spellPositionsById_codec = FieldCodec.ForMessage<SpellPreset.Types.SpellPositionsByIdEntry>(10U, khNknR8YlsAdsibIOoe.XVInXhlssT(khNknR8YlsAdsibIOoe.Xdx8buduhb));
					num2 = 5;
					continue;
				case 5:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x001ADEAC File Offset: 0x001AC0AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bEmv6COamOJJdTqOSHmf()
		{
			return true;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x001ADEB4 File Offset: 0x001AC0B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellPreset h2DAAeOaAZxkvsnKIadI()
		{
			return null;
		}

		// Token: 0x04000876 RID: 2166
		private static readonly MessageParser<SpellPreset> _parser;

		// Token: 0x04000877 RID: 2167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000878 RID: 2168
		public const int SpellPositionsByIdFieldNumber = 1;

		// Token: 0x04000879 RID: 2169
		private static readonly FieldCodec<SpellPreset.Types.SpellPositionsByIdEntry> _repeated_spellPositionsById_codec;

		// Token: 0x0400087A RID: 2170
		private readonly RepeatedField<SpellPreset.Types.SpellPositionsByIdEntry> spellPositionsById_;

		// Token: 0x0400087B RID: 2171
		private static SpellPreset J1Q4GvOan0tTC3Lo0MDK;

		// Token: 0x020001FA RID: 506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060017C6 RID: 6086 RVA: 0x002B0AAC File Offset: 0x002AECAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001FB RID: 507
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SpellPositionsByIdEntry : IMessage<SpellPreset.Types.SpellPositionsByIdEntry>, IMessage, IEquatable<SpellPreset.Types.SpellPositionsByIdEntry>, IDeepCloneable<SpellPreset.Types.SpellPositionsByIdEntry>, IBufferMessage
			{
				// Token: 0x1700043E RID: 1086
				// (get) Token: 0x060017C7 RID: 6087 RVA: 0x002F8B1C File Offset: 0x002F6D1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<SpellPreset.Types.SpellPositionsByIdEntry> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700043F RID: 1087
				// (get) Token: 0x060017C8 RID: 6088 RVA: 0x002F8B2C File Offset: 0x002F6D2C
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

				// Token: 0x17000440 RID: 1088
				// (get) Token: 0x060017C9 RID: 6089 RVA: 0x002F8B3C File Offset: 0x002F6D3C
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

				// Token: 0x060017CA RID: 6090 RVA: 0x002F8B4C File Offset: 0x002F6D4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellPositionsByIdEntry()
				{
				}

				// Token: 0x060017CB RID: 6091 RVA: 0x002F8B5C File Offset: 0x002F6D5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellPositionsByIdEntry(SpellPreset.Types.SpellPositionsByIdEntry other)
				{
				}

				// Token: 0x060017CC RID: 6092 RVA: 0x002F8B6C File Offset: 0x002F6D6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellPreset.Types.SpellPositionsByIdEntry Clone()
				{
					return null;
				}

				// Token: 0x17000441 RID: 1089
				// (get) Token: 0x060017CD RID: 6093 RVA: 0x002F8B7C File Offset: 0x002F6D7C
				// (set) Token: 0x060017CE RID: 6094 RVA: 0x002F8B8C File Offset: 0x002F6D8C
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

				// Token: 0x17000442 RID: 1090
				// (get) Token: 0x060017CF RID: 6095 RVA: 0x002F8B9C File Offset: 0x002F6D9C
				// (set) Token: 0x060017D0 RID: 6096 RVA: 0x002F8BAC File Offset: 0x002F6DAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SpellPositions Value
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

				// Token: 0x060017D1 RID: 6097 RVA: 0x002F8BBC File Offset: 0x002F6DBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060017D2 RID: 6098 RVA: 0x002F8BCC File Offset: 0x002F6DCC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(SpellPreset.Types.SpellPositionsByIdEntry other)
				{
					return true;
				}

				// Token: 0x060017D3 RID: 6099 RVA: 0x002F8BDC File Offset: 0x002F6DDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060017D4 RID: 6100 RVA: 0x002F8BEC File Offset: 0x002F6DEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060017D5 RID: 6101 RVA: 0x002F8BFC File Offset: 0x002F6DFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060017D6 RID: 6102 RVA: 0x002F8C0C File Offset: 0x002F6E0C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060017D7 RID: 6103 RVA: 0x002F8C1C File Offset: 0x002F6E1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060017D8 RID: 6104 RVA: 0x002F8C2C File Offset: 0x002F6E2C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(SpellPreset.Types.SpellPositionsByIdEntry other)
				{
				}

				// Token: 0x060017D9 RID: 6105 RVA: 0x002F8C3C File Offset: 0x002F6E3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060017DA RID: 6106 RVA: 0x002F8C4C File Offset: 0x002F6E4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060017DB RID: 6107 RVA: 0x002F8C5C File Offset: 0x002F6E5C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SpellPositionsByIdEntry()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					for (;;)
					{
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 3:
								goto IL_C0;
							case 4:
								SpellPreset.Types.SpellPositionsByIdEntry._parser = new MessageParser<SpellPreset.Types.SpellPositionsByIdEntry>(() => null);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
							{
								num2 = 1;
							}
						}
						IL_C0:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num = 2;
					}
				}

				// Token: 0x060017DC RID: 6108 RVA: 0x002F8D44 File Offset: 0x002F6F44
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool C7Lu6NGpwsyofSt30YdU()
				{
					return true;
				}

				// Token: 0x060017DD RID: 6109 RVA: 0x002F8D4C File Offset: 0x002F6F4C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static SpellPreset.Types.SpellPositionsByIdEntry OWQqPBGpQlWRLHcOCI8L()
				{
					return null;
				}

				// Token: 0x0400087C RID: 2172
				private static readonly MessageParser<SpellPreset.Types.SpellPositionsByIdEntry> _parser;

				// Token: 0x0400087D RID: 2173
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400087E RID: 2174
				public const int KeyFieldNumber = 1;

				// Token: 0x0400087F RID: 2175
				private int key_;

				// Token: 0x04000880 RID: 2176
				public const int ValueFieldNumber = 2;

				// Token: 0x04000881 RID: 2177
				private SpellPositions value_;

				// Token: 0x04000882 RID: 2178
				private static SpellPreset.Types.SpellPositionsByIdEntry l8DqPVGptlyYBhsUkyqB;
			}
		}
	}
}
