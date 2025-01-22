using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C6D RID: 3181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterFillSlotFaceResponse : IMessage<CharacterFillSlotFaceResponse>, IMessage, IEquatable<CharacterFillSlotFaceResponse>, IDeepCloneable<CharacterFillSlotFaceResponse>, IBufferMessage
	{
		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x060098D4 RID: 39124 RVA: 0x0027B728 File Offset: 0x00279928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterFillSlotFaceResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x060098D5 RID: 39125 RVA: 0x0027B738 File Offset: 0x00279938
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

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x060098D6 RID: 39126 RVA: 0x0027B748 File Offset: 0x00279948
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

		// Token: 0x060098D7 RID: 39127 RVA: 0x0027B758 File Offset: 0x00279958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotFaceResponse()
		{
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x0027B768 File Offset: 0x00279968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotFaceResponse(CharacterFillSlotFaceResponse other)
		{
		}

		// Token: 0x060098D9 RID: 39129 RVA: 0x0027B778 File Offset: 0x00279978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotFaceResponse Clone()
		{
			return null;
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x060098DA RID: 39130 RVA: 0x0027B788 File Offset: 0x00279988
		// (set) Token: 0x060098DB RID: 39131 RVA: 0x0027B798 File Offset: 0x00279998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterFillSlotFaceResponse.Types.Success Success
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

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x060098DC RID: 39132 RVA: 0x0027B7A8 File Offset: 0x002799A8
		// (set) Token: 0x060098DD RID: 39133 RVA: 0x0027B7B8 File Offset: 0x002799B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterFillSlotFaceResponse.Types.Error Error
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

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x060098DE RID: 39134 RVA: 0x0027B7C8 File Offset: 0x002799C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterFillSlotFaceResponse.ResultOneofCase ResultCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterFillSlotFaceResponse.ResultOneofCase)null;
			}
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x0027B7DC File Offset: 0x002799DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearResult()
		{
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x0027B7EC File Offset: 0x002799EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x0027B7FC File Offset: 0x002799FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterFillSlotFaceResponse other)
		{
			return true;
		}

		// Token: 0x060098E2 RID: 39138 RVA: 0x0027B80C File Offset: 0x00279A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x0027B81C File Offset: 0x00279A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x0027B82C File Offset: 0x00279A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x0027B83C File Offset: 0x00279A3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x0027B84C File Offset: 0x00279A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x0027B85C File Offset: 0x00279A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterFillSlotFaceResponse other)
		{
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x0027B86C File Offset: 0x00279A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x0027B87C File Offset: 0x00279A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x0027B88C File Offset: 0x00279A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterFillSlotFaceResponse()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					CharacterFillSlotFaceResponse._parser = new MessageParser<CharacterFillSlotFaceResponse>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x0027B970 File Offset: 0x00279B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool j3ML2KJNQLuXjxjgLcBH()
		{
			return true;
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x0027B978 File Offset: 0x00279B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterFillSlotFaceResponse Q0DdDBJN7kP9jiRisTOE()
		{
			return null;
		}

		// Token: 0x040038B3 RID: 14515
		private static readonly MessageParser<CharacterFillSlotFaceResponse> _parser;

		// Token: 0x040038B4 RID: 14516
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038B5 RID: 14517
		public const int SuccessFieldNumber = 1;

		// Token: 0x040038B6 RID: 14518
		public const int ErrorFieldNumber = 2;

		// Token: 0x040038B7 RID: 14519
		private object result_;

		// Token: 0x040038B8 RID: 14520
		private CharacterFillSlotFaceResponse.ResultOneofCase resultCase_;

		// Token: 0x040038B9 RID: 14521
		private static CharacterFillSlotFaceResponse gTl7IuJNwGofOMJ4iX5e;

		// Token: 0x02000C6E RID: 3182
		public enum ResultOneofCase
		{
			// Token: 0x040038BB RID: 14523
			None,
			// Token: 0x040038BC RID: 14524
			Success,
			// Token: 0x040038BD RID: 14525
			Error
		}

		// Token: 0x02000C6F RID: 3183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060098ED RID: 39149 RVA: 0x002E942C File Offset: 0x002E762C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000C70 RID: 3184
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Success : IMessage<CharacterFillSlotFaceResponse.Types.Success>, IMessage, IEquatable<CharacterFillSlotFaceResponse.Types.Success>, IDeepCloneable<CharacterFillSlotFaceResponse.Types.Success>, IBufferMessage
			{
				// Token: 0x17001C85 RID: 7301
				// (get) Token: 0x060098EE RID: 39150 RVA: 0x0030DDA4 File Offset: 0x0030BFA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<CharacterFillSlotFaceResponse.Types.Success> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001C86 RID: 7302
				// (get) Token: 0x060098EF RID: 39151 RVA: 0x0030DDB4 File Offset: 0x0030BFB4
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

				// Token: 0x17001C87 RID: 7303
				// (get) Token: 0x060098F0 RID: 39152 RVA: 0x0030DDC4 File Offset: 0x0030BFC4
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

				// Token: 0x060098F1 RID: 39153 RVA: 0x0030DDD4 File Offset: 0x0030BFD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success()
				{
				}

				// Token: 0x060098F2 RID: 39154 RVA: 0x0030DDE4 File Offset: 0x0030BFE4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Success(CharacterFillSlotFaceResponse.Types.Success other)
				{
				}

				// Token: 0x060098F3 RID: 39155 RVA: 0x0030DDF4 File Offset: 0x0030BFF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterFillSlotFaceResponse.Types.Success Clone()
				{
					return null;
				}

				// Token: 0x17001C88 RID: 7304
				// (get) Token: 0x060098F4 RID: 39156 RVA: 0x0030DE04 File Offset: 0x0030C004
				// (set) Token: 0x060098F5 RID: 39157 RVA: 0x0030DE14 File Offset: 0x0030C014
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int FaceId
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

				// Token: 0x17001C89 RID: 7305
				// (get) Token: 0x060098F6 RID: 39158 RVA: 0x0030DE24 File Offset: 0x0030C024
				// (set) Token: 0x060098F7 RID: 39159 RVA: 0x0030DE34 File Offset: 0x0030C034
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x060098F8 RID: 39160 RVA: 0x0030DE44 File Offset: 0x0030C044
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060098F9 RID: 39161 RVA: 0x0030DE54 File Offset: 0x0030C054
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterFillSlotFaceResponse.Types.Success other)
				{
					return true;
				}

				// Token: 0x060098FA RID: 39162 RVA: 0x0030DE64 File Offset: 0x0030C064
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060098FB RID: 39163 RVA: 0x0030DE74 File Offset: 0x0030C074
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060098FC RID: 39164 RVA: 0x0030DE84 File Offset: 0x0030C084
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060098FD RID: 39165 RVA: 0x0030DE94 File Offset: 0x0030C094
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060098FE RID: 39166 RVA: 0x0030DEA4 File Offset: 0x0030C0A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060098FF RID: 39167 RVA: 0x0030DEB4 File Offset: 0x0030C0B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterFillSlotFaceResponse.Types.Success other)
				{
				}

				// Token: 0x06009900 RID: 39168 RVA: 0x0030DEC4 File Offset: 0x0030C0C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009901 RID: 39169 RVA: 0x0030DED4 File Offset: 0x0030C0D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06009902 RID: 39170 RVA: 0x0030DEE4 File Offset: 0x0030C0E4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Success()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							CharacterFillSlotFaceResponse.Types.Success._parser = new MessageParser<CharacterFillSlotFaceResponse.Types.Success>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							continue;
						}
						break;
					}
				}

				// Token: 0x06009903 RID: 39171 RVA: 0x0030DFB0 File Offset: 0x0030C1B0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool a4HROjGZQXvyU5mn9Z0L()
				{
					return true;
				}

				// Token: 0x06009904 RID: 39172 RVA: 0x0030DFB8 File Offset: 0x0030C1B8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterFillSlotFaceResponse.Types.Success WtfRA0GZ7K0BJJlnY7Ss()
				{
					return null;
				}

				// Token: 0x040038BE RID: 14526
				private static readonly MessageParser<CharacterFillSlotFaceResponse.Types.Success> _parser;

				// Token: 0x040038BF RID: 14527
				private UnknownFieldSet _unknownFields;

				// Token: 0x040038C0 RID: 14528
				public const int FaceIdFieldNumber = 1;

				// Token: 0x040038C1 RID: 14529
				private int faceId_;

				// Token: 0x040038C2 RID: 14530
				public const int PositionFieldNumber = 2;

				// Token: 0x040038C3 RID: 14531
				private int position_;

				// Token: 0x040038C4 RID: 14532
				private static CharacterFillSlotFaceResponse.Types.Success L3FaAyGZwAgEUlJ342gR;
			}

			// Token: 0x02000C72 RID: 3186
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Error : IMessage<CharacterFillSlotFaceResponse.Types.Error>, IMessage, IEquatable<CharacterFillSlotFaceResponse.Types.Error>, IDeepCloneable<CharacterFillSlotFaceResponse.Types.Error>, IBufferMessage
			{
				// Token: 0x17001C8A RID: 7306
				// (get) Token: 0x0600990A RID: 39178 RVA: 0x0030DFC0 File Offset: 0x0030C1C0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<CharacterFillSlotFaceResponse.Types.Error> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001C8B RID: 7307
				// (get) Token: 0x0600990B RID: 39179 RVA: 0x0030DFD0 File Offset: 0x0030C1D0
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

				// Token: 0x17001C8C RID: 7308
				// (get) Token: 0x0600990C RID: 39180 RVA: 0x0030DFE0 File Offset: 0x0030C1E0
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

				// Token: 0x0600990D RID: 39181 RVA: 0x0030DFF0 File Offset: 0x0030C1F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error()
				{
				}

				// Token: 0x0600990E RID: 39182 RVA: 0x0030E000 File Offset: 0x0030C200
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Error(CharacterFillSlotFaceResponse.Types.Error other)
				{
				}

				// Token: 0x0600990F RID: 39183 RVA: 0x0030E010 File Offset: 0x0030C210
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CharacterFillSlotFaceResponse.Types.Error Clone()
				{
					return null;
				}

				// Token: 0x06009910 RID: 39184 RVA: 0x0030E020 File Offset: 0x0030C220
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06009911 RID: 39185 RVA: 0x0030E030 File Offset: 0x0030C230
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(CharacterFillSlotFaceResponse.Types.Error other)
				{
					return true;
				}

				// Token: 0x06009912 RID: 39186 RVA: 0x0030E040 File Offset: 0x0030C240
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06009913 RID: 39187 RVA: 0x0030E050 File Offset: 0x0030C250
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06009914 RID: 39188 RVA: 0x0030E060 File Offset: 0x0030C260
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009915 RID: 39189 RVA: 0x0030E070 File Offset: 0x0030C270
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009916 RID: 39190 RVA: 0x0030E080 File Offset: 0x0030C280
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06009917 RID: 39191 RVA: 0x0030E090 File Offset: 0x0030C290
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CharacterFillSlotFaceResponse.Types.Error other)
				{
				}

				// Token: 0x06009918 RID: 39192 RVA: 0x0030E0A0 File Offset: 0x0030C2A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009919 RID: 39193 RVA: 0x0030E0B0 File Offset: 0x0030C2B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600991A RID: 39194 RVA: 0x0030E0C0 File Offset: 0x0030C2C0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Error()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 4:
							CharacterFillSlotFaceResponse.Types.Error._parser = new MessageParser<CharacterFillSlotFaceResponse.Types.Error>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x0600991B RID: 39195 RVA: 0x0030E1A4 File Offset: 0x0030C3A4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool YnZV03GZpXf0LZVvY35s()
				{
					return true;
				}

				// Token: 0x0600991C RID: 39196 RVA: 0x0030E1AC File Offset: 0x0030C3AC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static CharacterFillSlotFaceResponse.Types.Error XT7QATGZHWQtnWMWm5Pp()
				{
					return null;
				}

				// Token: 0x040038C7 RID: 14535
				private static readonly MessageParser<CharacterFillSlotFaceResponse.Types.Error> _parser;

				// Token: 0x040038C8 RID: 14536
				private UnknownFieldSet _unknownFields;

				// Token: 0x040038C9 RID: 14537
				private static CharacterFillSlotFaceResponse.Types.Error KDGIiJGZToM5j357Wd6S;
			}
		}
	}
}
