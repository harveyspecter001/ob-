using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200020A RID: 522
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterPresetCreateResponse : IMessage<CharacterPresetCreateResponse>, IMessage, IEquatable<CharacterPresetCreateResponse>, IDeepCloneable<CharacterPresetCreateResponse>, IBufferMessage
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x001AE370 File Offset: 0x001AC570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterPresetCreateResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x001AE380 File Offset: 0x001AC580
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x001AE390 File Offset: 0x001AC590
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

		// Token: 0x06001874 RID: 6260 RVA: 0x001AE3A0 File Offset: 0x001AC5A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCreateResponse()
		{
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x001AE3B0 File Offset: 0x001AC5B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCreateResponse(CharacterPresetCreateResponse other)
		{
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x001AE3C0 File Offset: 0x001AC5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterPresetCreateResponse Clone()
		{
			return null;
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x001AE3D0 File Offset: 0x001AC5D0
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x001AE3E0 File Offset: 0x001AC5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterPresetCreateResponse.Types.Success Success
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

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x001AE3F0 File Offset: 0x001AC5F0
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x001AE404 File Offset: 0x001AC604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterPresetCreateResponse.Types.Error Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterPresetCreateResponse.Types.Error)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x001AE414 File Offset: 0x001AC614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasError
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x001AE424 File Offset: 0x001AC624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearError()
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x001AE434 File Offset: 0x001AC634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterPresetCreateResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterPresetCreateResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x001AE448 File Offset: 0x001AC648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x001AE458 File Offset: 0x001AC658
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x001AE468 File Offset: 0x001AC668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterPresetCreateResponse other)
		{
			return true;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x001AE478 File Offset: 0x001AC678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x001AE488 File Offset: 0x001AC688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x001AE498 File Offset: 0x001AC698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x001AE4A8 File Offset: 0x001AC6A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x001AE4B8 File Offset: 0x001AC6B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x001AE4C8 File Offset: 0x001AC6C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterPresetCreateResponse other)
		{
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x001AE4D8 File Offset: 0x001AC6D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x001AE4E8 File Offset: 0x001AC6E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x001AE4F8 File Offset: 0x001AC6F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterPresetCreateResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					CharacterPresetCreateResponse._parser = new MessageParser<CharacterPresetCreateResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x001AE5C4 File Offset: 0x001AC7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nqIVU4OagffqAKFcyj3J()
		{
			return true;
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x001AE5CC File Offset: 0x001AC7CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterPresetCreateResponse CY7GVaOasK6dBArDHRi0()
		{
			return null;
		}

		// Token: 0x040008B2 RID: 2226
		private static readonly MessageParser<CharacterPresetCreateResponse> _parser;

		// Token: 0x040008B3 RID: 2227
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008B4 RID: 2228
		public const int SuccessFieldNumber = 1;

		// Token: 0x040008B5 RID: 2229
		public const int ErrorFieldNumber = 2;

		// Token: 0x040008B6 RID: 2230
		private object result_;

		// Token: 0x040008B7 RID: 2231
		private CharacterPresetCreateResponse.ResultOneofCase resultCase_;

		// Token: 0x040008B8 RID: 2232
		private static CharacterPresetCreateResponse xEduxKOaGlfvYRCwqafV;

		// Token: 0x0200020B RID: 523
		public enum ResultOneofCase
		{
			// Token: 0x040008BA RID: 2234
			None,
			// Token: 0x040008BB RID: 2235
			Success,
			// Token: 0x040008BC RID: 2236
			Error
		}

		// Token: 0x0200020C RID: 524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600188C RID: 6284 RVA: 0x002B0D98 File Offset: 0x002AEF98
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200020D RID: 525
			public enum Error
			{
				// Token: 0x040008BE RID: 2238
				[OriginalName("MAX_QUANTITY")]
				MaxQuantity,
				// Token: 0x040008BF RID: 2239
				[OriginalName("INVALID_NAME_SIZE")]
				InvalidNameSize,
				// Token: 0x040008C0 RID: 2240
				[OriginalName("PRESET_NOT_FOUND")]
				PresetNotFound,
				// Token: 0x040008C1 RID: 2241
				[OriginalName("UNKNOWN")]
				Unknown
			}

			// Token: 0x0200020E RID: 526
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<CharacterPresetCreateResponse.Types.Success>, IMessage, IEquatable<CharacterPresetCreateResponse.Types.Success>, IDeepCloneable<CharacterPresetCreateResponse.Types.Success>, IBufferMessage
			{
				// Token: 0x17000461 RID: 1121
				// (get) Token: 0x0600188D RID: 6285 RVA: 0x002F9364 File Offset: 0x002F7564
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<CharacterPresetCreateResponse.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000462 RID: 1122
				// (get) Token: 0x0600188E RID: 6286 RVA: 0x002F9374 File Offset: 0x002F7574
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

				// Token: 0x17000463 RID: 1123
				// (get) Token: 0x0600188F RID: 6287 RVA: 0x002F9384 File Offset: 0x002F7584
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

				// Token: 0x06001890 RID: 6288 RVA: 0x002F9394 File Offset: 0x002F7594
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x06001891 RID: 6289 RVA: 0x002F93A4 File Offset: 0x002F75A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(CharacterPresetCreateResponse.Types.Success other)
				{
				}

				// Token: 0x06001892 RID: 6290 RVA: 0x002F93B4 File Offset: 0x002F75B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterPresetCreateResponse.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x17000464 RID: 1124
				// (get) Token: 0x06001893 RID: 6291 RVA: 0x002F93C4 File Offset: 0x002F75C4
				// (set) Token: 0x06001894 RID: 6292 RVA: 0x002F93D4 File Offset: 0x002F75D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public CharacterPresetInfo PresetInfo
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

				// Token: 0x06001895 RID: 6293 RVA: 0x002F93E4 File Offset: 0x002F75E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001896 RID: 6294 RVA: 0x002F93F4 File Offset: 0x002F75F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterPresetCreateResponse.Types.Success other)
				{
					return true;
				}

				// Token: 0x06001897 RID: 6295 RVA: 0x002F9404 File Offset: 0x002F7604
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001898 RID: 6296 RVA: 0x002F9414 File Offset: 0x002F7614
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001899 RID: 6297 RVA: 0x002F9424 File Offset: 0x002F7624
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600189A RID: 6298 RVA: 0x002F9434 File Offset: 0x002F7634
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600189B RID: 6299 RVA: 0x002F9444 File Offset: 0x002F7644
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600189C RID: 6300 RVA: 0x002F9454 File Offset: 0x002F7654
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterPresetCreateResponse.Types.Success other)
				{
				}

				// Token: 0x0600189D RID: 6301 RVA: 0x002F9464 File Offset: 0x002F7664
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600189E RID: 6302 RVA: 0x002F9474 File Offset: 0x002F7674
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600189F RID: 6303 RVA: 0x002F9484 File Offset: 0x002F7684
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
							{
								num2 = 2;
							}
							break;
						case 1:
							return;
						case 2:
							CharacterPresetCreateResponse.Types.Success._parser = new MessageParser<CharacterPresetCreateResponse.Types.Success>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							break;
						}
					}
				}

				// Token: 0x060018A0 RID: 6304 RVA: 0x002F9568 File Offset: 0x002F7768
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool i3fFZGGpqsJvZ4vtKX2S()
				{
					return true;
				}

				// Token: 0x060018A1 RID: 6305 RVA: 0x002F9570 File Offset: 0x002F7770
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterPresetCreateResponse.Types.Success vnjdP0GpFXO3Z8Qkjjjw()
				{
					return null;
				}

				// Token: 0x040008C2 RID: 2242
				private static readonly MessageParser<CharacterPresetCreateResponse.Types.Success> _parser;

				// Token: 0x040008C3 RID: 2243
				private UnknownFieldSet _unknownFields;

				// Token: 0x040008C4 RID: 2244
				public const int PresetInfoFieldNumber = 1;

				// Token: 0x040008C5 RID: 2245
				private CharacterPresetInfo presetInfo_;

				// Token: 0x040008C6 RID: 2246
				internal static CharacterPresetCreateResponse.Types.Success qjxpoqGpZefLkwXjKwZd;
			}
		}
	}
}
