using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001FE RID: 510
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetOrigin : IMessage<PresetOrigin>, IMessage, IEquatable<PresetOrigin>, IDeepCloneable<PresetOrigin>, IBufferMessage
	{
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x001ADEBC File Offset: 0x001AC0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetOrigin> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x001ADECC File Offset: 0x001AC0CC
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x001ADEDC File Offset: 0x001AC0DC
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

		// Token: 0x060017EB RID: 6123 RVA: 0x001ADEEC File Offset: 0x001AC0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOrigin()
		{
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x001ADEFC File Offset: 0x001AC0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOrigin(PresetOrigin other)
		{
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x001ADF0C File Offset: 0x001AC10C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetOrigin Clone()
		{
			return null;
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x001ADF1C File Offset: 0x001AC11C
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x001ADF2C File Offset: 0x001AC12C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetOrigin.Types.EmptyPreset Empty
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

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x001ADF3C File Offset: 0x001AC13C
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x001ADF4C File Offset: 0x001AC14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PresetOrigin.Types.PlayerCopy Player
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

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x001ADF5C File Offset: 0x001AC15C
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x001ADF6C File Offset: 0x001AC16C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetOrigin.Types.PresetClone Clone_
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x001ADF7C File Offset: 0x001AC17C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetOrigin.OriginOneofCase OriginCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetOrigin.OriginOneofCase)null;
			}
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x001ADF90 File Offset: 0x001AC190
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearOrigin()
		{
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x001ADFA0 File Offset: 0x001AC1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x001ADFB0 File Offset: 0x001AC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetOrigin other)
		{
			return true;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x001ADFC0 File Offset: 0x001AC1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x001ADFD0 File Offset: 0x001AC1D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x001ADFE0 File Offset: 0x001AC1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x001ADFF0 File Offset: 0x001AC1F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x001AE000 File Offset: 0x001AC200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x001AE010 File Offset: 0x001AC210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetOrigin other)
		{
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x001AE020 File Offset: 0x001AC220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x001AE030 File Offset: 0x001AC230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x001AE040 File Offset: 0x001AC240
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetOrigin()
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
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PresetOrigin._parser = new MessageParser<PresetOrigin>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x001AE10C File Offset: 0x001AC30C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TP7a2lOaeLqLxiOyqhlc()
		{
			return true;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x001AE114 File Offset: 0x001AC314
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetOrigin Swq3wgOa36qpGvBNWSkN()
		{
			return null;
		}

		// Token: 0x04000887 RID: 2183
		private static readonly MessageParser<PresetOrigin> _parser;

		// Token: 0x04000888 RID: 2184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000889 RID: 2185
		public const int EmptyFieldNumber = 1;

		// Token: 0x0400088A RID: 2186
		public const int PlayerFieldNumber = 2;

		// Token: 0x0400088B RID: 2187
		public const int Clone_FieldNumber = 3;

		// Token: 0x0400088C RID: 2188
		private object origin_;

		// Token: 0x0400088D RID: 2189
		private PresetOrigin.OriginOneofCase originCase_;

		// Token: 0x0400088E RID: 2190
		private static PresetOrigin vaJ3ByOaBhleC50wms0J;

		// Token: 0x020001FF RID: 511
		public enum OriginOneofCase
		{
			// Token: 0x04000890 RID: 2192
			None,
			// Token: 0x04000891 RID: 2193
			Empty,
			// Token: 0x04000892 RID: 2194
			Player,
			// Token: 0x04000893 RID: 2195
			Clone_
		}

		// Token: 0x02000200 RID: 512
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06001803 RID: 6147 RVA: 0x002B0BA4 File Offset: 0x002AEDA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000201 RID: 513
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class EmptyPreset : IMessage<PresetOrigin.Types.EmptyPreset>, IMessage, IEquatable<PresetOrigin.Types.EmptyPreset>, IDeepCloneable<PresetOrigin.Types.EmptyPreset>, IBufferMessage
			{
				// Token: 0x1700044A RID: 1098
				// (get) Token: 0x06001804 RID: 6148 RVA: 0x002F8D54 File Offset: 0x002F6F54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetOrigin.Types.EmptyPreset> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700044B RID: 1099
				// (get) Token: 0x06001805 RID: 6149 RVA: 0x002F8D64 File Offset: 0x002F6F64
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

				// Token: 0x1700044C RID: 1100
				// (get) Token: 0x06001806 RID: 6150 RVA: 0x002F8D74 File Offset: 0x002F6F74
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

				// Token: 0x06001807 RID: 6151 RVA: 0x002F8D84 File Offset: 0x002F6F84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EmptyPreset()
				{
				}

				// Token: 0x06001808 RID: 6152 RVA: 0x002F8D94 File Offset: 0x002F6F94
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public EmptyPreset(PresetOrigin.Types.EmptyPreset other)
				{
				}

				// Token: 0x06001809 RID: 6153 RVA: 0x002F8DA4 File Offset: 0x002F6FA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetOrigin.Types.EmptyPreset Clone()
				{
					return null;
				}

				// Token: 0x0600180A RID: 6154 RVA: 0x002F8DB4 File Offset: 0x002F6FB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600180B RID: 6155 RVA: 0x002F8DC4 File Offset: 0x002F6FC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetOrigin.Types.EmptyPreset other)
				{
					return true;
				}

				// Token: 0x0600180C RID: 6156 RVA: 0x002F8DD4 File Offset: 0x002F6FD4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600180D RID: 6157 RVA: 0x002F8DE4 File Offset: 0x002F6FE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600180E RID: 6158 RVA: 0x002F8DF4 File Offset: 0x002F6FF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600180F RID: 6159 RVA: 0x002F8E04 File Offset: 0x002F7004
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001810 RID: 6160 RVA: 0x002F8E14 File Offset: 0x002F7014
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001811 RID: 6161 RVA: 0x002F8E24 File Offset: 0x002F7024
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetOrigin.Types.EmptyPreset other)
				{
				}

				// Token: 0x06001812 RID: 6162 RVA: 0x002F8E34 File Offset: 0x002F7034
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001813 RID: 6163 RVA: 0x002F8E44 File Offset: 0x002F7044
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001814 RID: 6164 RVA: 0x002F8E54 File Offset: 0x002F7054
				[MethodImpl(MethodImplOptions.NoInlining)]
				static EmptyPreset()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						}
						PresetOrigin.Types.EmptyPreset._parser = new MessageParser<PresetOrigin.Types.EmptyPreset>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06001815 RID: 6165 RVA: 0x002F8F4C File Offset: 0x002F714C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool fURuAvGpTsbJPITXBiJh()
				{
					return true;
				}

				// Token: 0x06001816 RID: 6166 RVA: 0x002F8F54 File Offset: 0x002F7154
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetOrigin.Types.EmptyPreset Q4TWvtGppKIbpVnY2lXq()
				{
					return null;
				}

				// Token: 0x04000894 RID: 2196
				private static readonly MessageParser<PresetOrigin.Types.EmptyPreset> _parser;

				// Token: 0x04000895 RID: 2197
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000896 RID: 2198
				internal static PresetOrigin.Types.EmptyPreset y0mT1DGp7i8i0JO9sOXT;
			}

			// Token: 0x02000203 RID: 515
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PlayerCopy : IMessage<PresetOrigin.Types.PlayerCopy>, IMessage, IEquatable<PresetOrigin.Types.PlayerCopy>, IDeepCloneable<PresetOrigin.Types.PlayerCopy>, IBufferMessage
			{
				// Token: 0x1700044D RID: 1101
				// (get) Token: 0x0600181C RID: 6172 RVA: 0x002F8F5C File Offset: 0x002F715C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<PresetOrigin.Types.PlayerCopy> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700044E RID: 1102
				// (get) Token: 0x0600181D RID: 6173 RVA: 0x002F8F6C File Offset: 0x002F716C
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

				// Token: 0x1700044F RID: 1103
				// (get) Token: 0x0600181E RID: 6174 RVA: 0x002F8F7C File Offset: 0x002F717C
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

				// Token: 0x0600181F RID: 6175 RVA: 0x002F8F8C File Offset: 0x002F718C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerCopy()
				{
				}

				// Token: 0x06001820 RID: 6176 RVA: 0x002F8F9C File Offset: 0x002F719C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PlayerCopy(PresetOrigin.Types.PlayerCopy other)
				{
				}

				// Token: 0x06001821 RID: 6177 RVA: 0x002F8FAC File Offset: 0x002F71AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetOrigin.Types.PlayerCopy Clone()
				{
					return null;
				}

				// Token: 0x06001822 RID: 6178 RVA: 0x002F8FBC File Offset: 0x002F71BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001823 RID: 6179 RVA: 0x002F8FCC File Offset: 0x002F71CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetOrigin.Types.PlayerCopy other)
				{
					return true;
				}

				// Token: 0x06001824 RID: 6180 RVA: 0x002F8FDC File Offset: 0x002F71DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001825 RID: 6181 RVA: 0x002F8FEC File Offset: 0x002F71EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001826 RID: 6182 RVA: 0x002F8FFC File Offset: 0x002F71FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001827 RID: 6183 RVA: 0x002F900C File Offset: 0x002F720C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001828 RID: 6184 RVA: 0x002F901C File Offset: 0x002F721C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001829 RID: 6185 RVA: 0x002F902C File Offset: 0x002F722C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetOrigin.Types.PlayerCopy other)
				{
				}

				// Token: 0x0600182A RID: 6186 RVA: 0x002F903C File Offset: 0x002F723C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600182B RID: 6187 RVA: 0x002F904C File Offset: 0x002F724C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600182C RID: 6188 RVA: 0x002F905C File Offset: 0x002F725C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PlayerCopy()
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
							num2 = 4;
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						PresetOrigin.Types.PlayerCopy._parser = new MessageParser<PresetOrigin.Types.PlayerCopy>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
						{
							num2 = 3;
						}
					}
				}

				// Token: 0x0600182D RID: 6189 RVA: 0x002F9140 File Offset: 0x002F7340
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool bM1KZ0GpYavt4F4pnyeX()
				{
					return true;
				}

				// Token: 0x0600182E RID: 6190 RVA: 0x002F9148 File Offset: 0x002F7348
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetOrigin.Types.PlayerCopy v7gRjfGpbFwb5Vo2yDcY()
				{
					return null;
				}

				// Token: 0x04000899 RID: 2201
				private static readonly MessageParser<PresetOrigin.Types.PlayerCopy> _parser;

				// Token: 0x0400089A RID: 2202
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400089B RID: 2203
				private static PresetOrigin.Types.PlayerCopy DJ6g3ZGpHmBRnB80a8le;
			}

			// Token: 0x02000205 RID: 517
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PresetClone : IMessage<PresetOrigin.Types.PresetClone>, IMessage, IEquatable<PresetOrigin.Types.PresetClone>, IDeepCloneable<PresetOrigin.Types.PresetClone>, IBufferMessage
			{
				// Token: 0x17000450 RID: 1104
				// (get) Token: 0x06001834 RID: 6196 RVA: 0x002F9150 File Offset: 0x002F7350
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<PresetOrigin.Types.PresetClone> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000451 RID: 1105
				// (get) Token: 0x06001835 RID: 6197 RVA: 0x002F9160 File Offset: 0x002F7360
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

				// Token: 0x17000452 RID: 1106
				// (get) Token: 0x06001836 RID: 6198 RVA: 0x002F9170 File Offset: 0x002F7370
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

				// Token: 0x06001837 RID: 6199 RVA: 0x002F9180 File Offset: 0x002F7380
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetClone()
				{
				}

				// Token: 0x06001838 RID: 6200 RVA: 0x002F9190 File Offset: 0x002F7390
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetClone(PresetOrigin.Types.PresetClone other)
				{
				}

				// Token: 0x06001839 RID: 6201 RVA: 0x002F91A0 File Offset: 0x002F73A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PresetOrigin.Types.PresetClone Clone()
				{
					return null;
				}

				// Token: 0x17000453 RID: 1107
				// (get) Token: 0x0600183A RID: 6202 RVA: 0x002F91B0 File Offset: 0x002F73B0
				// (set) Token: 0x0600183B RID: 6203 RVA: 0x002F91C0 File Offset: 0x002F73C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string PresetUuidToClone
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

				// Token: 0x0600183C RID: 6204 RVA: 0x002F91D0 File Offset: 0x002F73D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600183D RID: 6205 RVA: 0x002F91E0 File Offset: 0x002F73E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(PresetOrigin.Types.PresetClone other)
				{
					return true;
				}

				// Token: 0x0600183E RID: 6206 RVA: 0x002F91F0 File Offset: 0x002F73F0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600183F RID: 6207 RVA: 0x002F9200 File Offset: 0x002F7400
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001840 RID: 6208 RVA: 0x002F9210 File Offset: 0x002F7410
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001841 RID: 6209 RVA: 0x002F9220 File Offset: 0x002F7420
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06001842 RID: 6210 RVA: 0x002F9230 File Offset: 0x002F7430
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06001843 RID: 6211 RVA: 0x002F9240 File Offset: 0x002F7440
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(PresetOrigin.Types.PresetClone other)
				{
				}

				// Token: 0x06001844 RID: 6212 RVA: 0x002F9250 File Offset: 0x002F7450
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001845 RID: 6213 RVA: 0x002F9260 File Offset: 0x002F7460
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001846 RID: 6214 RVA: 0x002F9270 File Offset: 0x002F7470
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PresetClone()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							break;
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							return;
						case 3:
							PresetOrigin.Types.PresetClone._parser = new MessageParser<PresetOrigin.Types.PresetClone>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
							{
								num2 = 1;
							}
							break;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
							{
								num2 = 3;
							}
							break;
						}
					}
				}

				// Token: 0x06001847 RID: 6215 RVA: 0x002F9354 File Offset: 0x002F7554
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool eK0cb9GpP2vHvkgPlTWA()
				{
					return true;
				}

				// Token: 0x06001848 RID: 6216 RVA: 0x002F935C File Offset: 0x002F755C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static PresetOrigin.Types.PresetClone xHpNW0GpS1vlxsdypxYy()
				{
					return null;
				}

				// Token: 0x0400089E RID: 2206
				private static readonly MessageParser<PresetOrigin.Types.PresetClone> _parser;

				// Token: 0x0400089F RID: 2207
				private UnknownFieldSet _unknownFields;

				// Token: 0x040008A0 RID: 2208
				public const int PresetUuidToCloneFieldNumber = 1;

				// Token: 0x040008A1 RID: 2209
				private string presetUuidToClone_;

				// Token: 0x040008A2 RID: 2210
				internal static PresetOrigin.Types.PresetClone VguaMuGpindJlP4EJ48P;
			}
		}
	}
}
