using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C77 RID: 3191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterFillSlotColorsResponse : IMessage<CharacterFillSlotColorsResponse>, IMessage, IEquatable<CharacterFillSlotColorsResponse>, IDeepCloneable<CharacterFillSlotColorsResponse>, IBufferMessage
	{
		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06009940 RID: 39232 RVA: 0x0027BB8C File Offset: 0x00279D8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterFillSlotColorsResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06009941 RID: 39233 RVA: 0x0027BB9C File Offset: 0x00279D9C
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

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06009942 RID: 39234 RVA: 0x0027BBAC File Offset: 0x00279DAC
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

		// Token: 0x06009943 RID: 39235 RVA: 0x0027BBBC File Offset: 0x00279DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotColorsResponse()
		{
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x0027BBCC File Offset: 0x00279DCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotColorsResponse(CharacterFillSlotColorsResponse other)
		{
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x0027BBDC File Offset: 0x00279DDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotColorsResponse Clone()
		{
			return null;
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06009946 RID: 39238 RVA: 0x0027BBEC File Offset: 0x00279DEC
		// (set) Token: 0x06009947 RID: 39239 RVA: 0x0027BBFC File Offset: 0x00279DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterFillSlotColorsResponse.Types.Success Success
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

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06009948 RID: 39240 RVA: 0x0027BC0C File Offset: 0x00279E0C
		// (set) Token: 0x06009949 RID: 39241 RVA: 0x0027BC1C File Offset: 0x00279E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterFillSlotColorsResponse.Types.Error Error
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

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x0027BC2C File Offset: 0x00279E2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterFillSlotColorsResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterFillSlotColorsResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x0027BC40 File Offset: 0x00279E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x0027BC50 File Offset: 0x00279E50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x0027BC60 File Offset: 0x00279E60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterFillSlotColorsResponse other)
		{
			return true;
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x0027BC70 File Offset: 0x00279E70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x0027BC80 File Offset: 0x00279E80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009950 RID: 39248 RVA: 0x0027BC90 File Offset: 0x00279E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009951 RID: 39249 RVA: 0x0027BCA0 File Offset: 0x00279EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009952 RID: 39250 RVA: 0x0027BCB0 File Offset: 0x00279EB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x0027BCC0 File Offset: 0x00279EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterFillSlotColorsResponse other)
		{
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x0027BCD0 File Offset: 0x00279ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009955 RID: 39253 RVA: 0x0027BCE0 File Offset: 0x00279EE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x0027BCF0 File Offset: 0x00279EF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterFillSlotColorsResponse()
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
					CharacterFillSlotColorsResponse._parser = new MessageParser<CharacterFillSlotColorsResponse>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x0027BDD4 File Offset: 0x00279FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q9MHZ1JNbOOr2arGNlgL()
		{
			return true;
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x0027BDDC File Offset: 0x00279FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterFillSlotColorsResponse VCbhfdJNi8IjF3319Fhd()
		{
			return null;
		}

		// Token: 0x040038D6 RID: 14550
		private static readonly MessageParser<CharacterFillSlotColorsResponse> _parser;

		// Token: 0x040038D7 RID: 14551
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038D8 RID: 14552
		public const int SuccessFieldNumber = 1;

		// Token: 0x040038D9 RID: 14553
		public const int ErrorFieldNumber = 2;

		// Token: 0x040038DA RID: 14554
		private object result_;

		// Token: 0x040038DB RID: 14555
		private CharacterFillSlotColorsResponse.ResultOneofCase resultCase_;

		// Token: 0x040038DC RID: 14556
		internal static CharacterFillSlotColorsResponse kKxYxnJNYglrJMoLEL8t;

		// Token: 0x02000C78 RID: 3192
		public enum ResultOneofCase
		{
			// Token: 0x040038DE RID: 14558
			None,
			// Token: 0x040038DF RID: 14559
			Success,
			// Token: 0x040038E0 RID: 14560
			Error
		}

		// Token: 0x02000C79 RID: 3193
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06009959 RID: 39257 RVA: 0x002E964C File Offset: 0x002E784C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000C7A RID: 3194
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<CharacterFillSlotColorsResponse.Types.Success>, IMessage, IEquatable<CharacterFillSlotColorsResponse.Types.Success>, IDeepCloneable<CharacterFillSlotColorsResponse.Types.Success>, IBufferMessage
			{
				// Token: 0x17001C97 RID: 7319
				// (get) Token: 0x0600995A RID: 39258 RVA: 0x0030E1B4 File Offset: 0x0030C3B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<CharacterFillSlotColorsResponse.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001C98 RID: 7320
				// (get) Token: 0x0600995B RID: 39259 RVA: 0x0030E1C4 File Offset: 0x0030C3C4
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

				// Token: 0x17001C99 RID: 7321
				// (get) Token: 0x0600995C RID: 39260 RVA: 0x0030E1D4 File Offset: 0x0030C3D4
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

				// Token: 0x0600995D RID: 39261 RVA: 0x0030E1E4 File Offset: 0x0030C3E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x0600995E RID: 39262 RVA: 0x0030E1F4 File Offset: 0x0030C3F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(CharacterFillSlotColorsResponse.Types.Success other)
				{
				}

				// Token: 0x0600995F RID: 39263 RVA: 0x0030E204 File Offset: 0x0030C404
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterFillSlotColorsResponse.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x17001C9A RID: 7322
				// (get) Token: 0x06009960 RID: 39264 RVA: 0x0030E214 File Offset: 0x0030C414
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public RepeatedField<int> Colors
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001C9B RID: 7323
				// (get) Token: 0x06009961 RID: 39265 RVA: 0x0030E224 File Offset: 0x0030C424
				// (set) Token: 0x06009962 RID: 39266 RVA: 0x0030E234 File Offset: 0x0030C434
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Position
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

				// Token: 0x06009963 RID: 39267 RVA: 0x0030E244 File Offset: 0x0030C444
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06009964 RID: 39268 RVA: 0x0030E254 File Offset: 0x0030C454
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterFillSlotColorsResponse.Types.Success other)
				{
					return true;
				}

				// Token: 0x06009965 RID: 39269 RVA: 0x0030E264 File Offset: 0x0030C464
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06009966 RID: 39270 RVA: 0x0030E274 File Offset: 0x0030C474
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06009967 RID: 39271 RVA: 0x0030E284 File Offset: 0x0030C484
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009968 RID: 39272 RVA: 0x0030E294 File Offset: 0x0030C494
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009969 RID: 39273 RVA: 0x0030E2A4 File Offset: 0x0030C4A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600996A RID: 39274 RVA: 0x0030E2B4 File Offset: 0x0030C4B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterFillSlotColorsResponse.Types.Success other)
				{
				}

				// Token: 0x0600996B RID: 39275 RVA: 0x0030E2C4 File Offset: 0x0030C4C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600996C RID: 39276 RVA: 0x0030E2D4 File Offset: 0x0030C4D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600996D RID: 39277 RVA: 0x0030E2E4 File Offset: 0x0030C4E4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
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
							default:
								CharacterFillSlotColorsResponse.Types.Success._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
								num2 = 4;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
								{
									num2 = 0;
								}
								break;
							case 1:
								CharacterFillSlotColorsResponse.Types.Success._parser = new MessageParser<CharacterFillSlotColorsResponse.Types.Success>(() => null);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 5;
								break;
							case 3:
								goto IL_69;
							case 4:
								return;
							case 5:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
								{
									num2 = 1;
								}
								break;
							}
						}
						IL_69:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num = 2;
					}
				}

				// Token: 0x0600996E RID: 39278 RVA: 0x0030E3E8 File Offset: 0x0030C5E8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool zAkCJrGZbHpnuUc0YgdG()
				{
					return true;
				}

				// Token: 0x0600996F RID: 39279 RVA: 0x0030E3F0 File Offset: 0x0030C5F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterFillSlotColorsResponse.Types.Success BBljtHGZiQYvVwcwQ4OR()
				{
					return null;
				}

				// Token: 0x040038E1 RID: 14561
				private static readonly MessageParser<CharacterFillSlotColorsResponse.Types.Success> _parser;

				// Token: 0x040038E2 RID: 14562
				private UnknownFieldSet _unknownFields;

				// Token: 0x040038E3 RID: 14563
				public const int ColorsFieldNumber = 1;

				// Token: 0x040038E4 RID: 14564
				private static readonly FieldCodec<int> _repeated_colors_codec;

				// Token: 0x040038E5 RID: 14565
				private readonly RepeatedField<int> colors_;

				// Token: 0x040038E6 RID: 14566
				public const int PositionFieldNumber = 2;

				// Token: 0x040038E7 RID: 14567
				private int position_;

				// Token: 0x040038E8 RID: 14568
				internal static CharacterFillSlotColorsResponse.Types.Success b1sShUGZY2OvlObrBMob;
			}

			// Token: 0x02000C7C RID: 3196
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<CharacterFillSlotColorsResponse.Types.Error>, IMessage, IEquatable<CharacterFillSlotColorsResponse.Types.Error>, IDeepCloneable<CharacterFillSlotColorsResponse.Types.Error>, IBufferMessage
			{
				// Token: 0x17001C9C RID: 7324
				// (get) Token: 0x06009975 RID: 39285 RVA: 0x0030E3F8 File Offset: 0x0030C5F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<CharacterFillSlotColorsResponse.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001C9D RID: 7325
				// (get) Token: 0x06009976 RID: 39286 RVA: 0x0030E408 File Offset: 0x0030C608
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

				// Token: 0x17001C9E RID: 7326
				// (get) Token: 0x06009977 RID: 39287 RVA: 0x0030E418 File Offset: 0x0030C618
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

				// Token: 0x06009978 RID: 39288 RVA: 0x0030E428 File Offset: 0x0030C628
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x06009979 RID: 39289 RVA: 0x0030E438 File Offset: 0x0030C638
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(CharacterFillSlotColorsResponse.Types.Error other)
				{
				}

				// Token: 0x0600997A RID: 39290 RVA: 0x0030E448 File Offset: 0x0030C648
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterFillSlotColorsResponse.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x0600997B RID: 39291 RVA: 0x0030E458 File Offset: 0x0030C658
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600997C RID: 39292 RVA: 0x0030E468 File Offset: 0x0030C668
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterFillSlotColorsResponse.Types.Error other)
				{
					return true;
				}

				// Token: 0x0600997D RID: 39293 RVA: 0x0030E478 File Offset: 0x0030C678
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600997E RID: 39294 RVA: 0x0030E488 File Offset: 0x0030C688
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600997F RID: 39295 RVA: 0x0030E498 File Offset: 0x0030C698
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009980 RID: 39296 RVA: 0x0030E4A8 File Offset: 0x0030C6A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009981 RID: 39297 RVA: 0x0030E4B8 File Offset: 0x0030C6B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06009982 RID: 39298 RVA: 0x0030E4C8 File Offset: 0x0030C6C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterFillSlotColorsResponse.Types.Error other)
				{
				}

				// Token: 0x06009983 RID: 39299 RVA: 0x0030E4D8 File Offset: 0x0030C6D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009984 RID: 39300 RVA: 0x0030E4E8 File Offset: 0x0030C6E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06009985 RID: 39301 RVA: 0x0030E4F8 File Offset: 0x0030C6F8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
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
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						CharacterFillSlotColorsResponse.Types.Error._parser = new MessageParser<CharacterFillSlotColorsResponse.Types.Error>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06009986 RID: 39302 RVA: 0x0030E5F0 File Offset: 0x0030C7F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool K4yV8TGZShCRiX2sr1t5()
				{
					return true;
				}

				// Token: 0x06009987 RID: 39303 RVA: 0x0030E5F8 File Offset: 0x0030C7F8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterFillSlotColorsResponse.Types.Error KlYiniGZMfZf5BSFxrsJ()
				{
					return null;
				}

				// Token: 0x040038EB RID: 14571
				private static readonly MessageParser<CharacterFillSlotColorsResponse.Types.Error> _parser;

				// Token: 0x040038EC RID: 14572
				private UnknownFieldSet _unknownFields;

				// Token: 0x040038ED RID: 14573
				internal static CharacterFillSlotColorsResponse.Types.Error GkJb2VGZPSE7ntK1EMM7;
			}
		}
	}
}
