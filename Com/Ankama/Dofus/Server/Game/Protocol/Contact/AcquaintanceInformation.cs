using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200088B RID: 2187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcquaintanceInformation : IMessage<AcquaintanceInformation>, IMessage, IEquatable<AcquaintanceInformation>, IDeepCloneable<AcquaintanceInformation>, IBufferMessage
	{
		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06006A36 RID: 27190 RVA: 0x0022F3FC File Offset: 0x0022D5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcquaintanceInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06006A37 RID: 27191 RVA: 0x0022F40C File Offset: 0x0022D60C
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

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x0022F41C File Offset: 0x0022D61C
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

		// Token: 0x06006A39 RID: 27193 RVA: 0x0022F42C File Offset: 0x0022D62C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceInformation()
		{
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x0022F43C File Offset: 0x0022D63C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceInformation(AcquaintanceInformation other)
		{
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x0022F44C File Offset: 0x0022D64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceInformation Clone()
		{
			return null;
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06006A3C RID: 27196 RVA: 0x0022F45C File Offset: 0x0022D65C
		// (set) Token: 0x06006A3D RID: 27197 RVA: 0x0022F46C File Offset: 0x0022D66C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long AccountId
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

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06006A3E RID: 27198 RVA: 0x0022F47C File Offset: 0x0022D67C
		// (set) Token: 0x06006A3F RID: 27199 RVA: 0x0022F48C File Offset: 0x0022D68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccountTag AccountTag
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

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06006A40 RID: 27200 RVA: 0x0022F49C File Offset: 0x0022D69C
		// (set) Token: 0x06006A41 RID: 27201 RVA: 0x0022F4B0 File Offset: 0x0022D6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (CharacterState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06006A42 RID: 27202 RVA: 0x0022F4C0 File Offset: 0x0022D6C0
		// (set) Token: 0x06006A43 RID: 27203 RVA: 0x0022F4D0 File Offset: 0x0022D6D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AcquaintanceInformation.Types.OnlineInformation Online
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

		// Token: 0x06006A44 RID: 27204 RVA: 0x0022F4E0 File Offset: 0x0022D6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x0022F4F0 File Offset: 0x0022D6F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AcquaintanceInformation other)
		{
			return true;
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x0022F500 File Offset: 0x0022D700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x0022F510 File Offset: 0x0022D710
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x0022F520 File Offset: 0x0022D720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x0022F530 File Offset: 0x0022D730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x0022F540 File Offset: 0x0022D740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x0022F550 File Offset: 0x0022D750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AcquaintanceInformation other)
		{
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x0022F560 File Offset: 0x0022D760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x0022F570 File Offset: 0x0022D770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x0022F580 File Offset: 0x0022D780
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AcquaintanceInformation()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					AcquaintanceInformation._parser = new MessageParser<AcquaintanceInformation>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x0022F664 File Offset: 0x0022D864
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EwD9rbJnz9ufMfWtyrUP()
		{
			return true;
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x0022F66C File Offset: 0x0022D86C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AcquaintanceInformation nxGFAyJmfg1AoWR6RThv()
		{
			return null;
		}

		// Token: 0x0400252B RID: 9515
		private static readonly MessageParser<AcquaintanceInformation> _parser;

		// Token: 0x0400252C RID: 9516
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400252D RID: 9517
		public const int AccountIdFieldNumber = 1;

		// Token: 0x0400252E RID: 9518
		private long accountId_;

		// Token: 0x0400252F RID: 9519
		public const int AccountTagFieldNumber = 2;

		// Token: 0x04002530 RID: 9520
		private AccountTag accountTag_;

		// Token: 0x04002531 RID: 9521
		public const int StateFieldNumber = 3;

		// Token: 0x04002532 RID: 9522
		private CharacterState state_;

		// Token: 0x04002533 RID: 9523
		public const int OnlineFieldNumber = 4;

		// Token: 0x04002534 RID: 9524
		private AcquaintanceInformation.Types.OnlineInformation online_;

		// Token: 0x04002535 RID: 9525
		internal static AcquaintanceInformation Fx9wZgJnFnmRsYv5oIdd;

		// Token: 0x0200088C RID: 2188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06006A51 RID: 27217 RVA: 0x002D782C File Offset: 0x002D5A2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200088D RID: 2189
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class OnlineInformation : IMessage<AcquaintanceInformation.Types.OnlineInformation>, IMessage, IEquatable<AcquaintanceInformation.Types.OnlineInformation>, IDeepCloneable<AcquaintanceInformation.Types.OnlineInformation>, IBufferMessage
			{
				// Token: 0x1700132F RID: 4911
				// (get) Token: 0x06006A52 RID: 27218 RVA: 0x00306838 File Offset: 0x00304A38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<AcquaintanceInformation.Types.OnlineInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001330 RID: 4912
				// (get) Token: 0x06006A53 RID: 27219 RVA: 0x00306848 File Offset: 0x00304A48
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

				// Token: 0x17001331 RID: 4913
				// (get) Token: 0x06006A54 RID: 27220 RVA: 0x00306858 File Offset: 0x00304A58
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

				// Token: 0x06006A55 RID: 27221 RVA: 0x00306868 File Offset: 0x00304A68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public OnlineInformation()
				{
				}

				// Token: 0x06006A56 RID: 27222 RVA: 0x00306878 File Offset: 0x00304A78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public OnlineInformation(AcquaintanceInformation.Types.OnlineInformation other)
				{
				}

				// Token: 0x06006A57 RID: 27223 RVA: 0x00306888 File Offset: 0x00304A88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AcquaintanceInformation.Types.OnlineInformation Clone()
				{
					return null;
				}

				// Token: 0x17001332 RID: 4914
				// (get) Token: 0x06006A58 RID: 27224 RVA: 0x00306898 File Offset: 0x00304A98
				// (set) Token: 0x06006A59 RID: 27225 RVA: 0x003068A8 File Offset: 0x00304AA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long CharacterId
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

				// Token: 0x17001333 RID: 4915
				// (get) Token: 0x06006A5A RID: 27226 RVA: 0x003068B8 File Offset: 0x00304AB8
				// (set) Token: 0x06006A5B RID: 27227 RVA: 0x003068C8 File Offset: 0x00304AC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public string CharacterName
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

				// Token: 0x17001334 RID: 4916
				// (get) Token: 0x06006A5C RID: 27228 RVA: 0x003068D8 File Offset: 0x00304AD8
				// (set) Token: 0x06006A5D RID: 27229 RVA: 0x003068E8 File Offset: 0x00304AE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MoodSmileyId
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

				// Token: 0x17001335 RID: 4917
				// (get) Token: 0x06006A5E RID: 27230 RVA: 0x003068F8 File Offset: 0x00304AF8
				// (set) Token: 0x06006A5F RID: 27231 RVA: 0x00306908 File Offset: 0x00304B08
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public CharacterStatus Status
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

				// Token: 0x06006A60 RID: 27232 RVA: 0x00306918 File Offset: 0x00304B18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06006A61 RID: 27233 RVA: 0x00306928 File Offset: 0x00304B28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(AcquaintanceInformation.Types.OnlineInformation other)
				{
					return true;
				}

				// Token: 0x06006A62 RID: 27234 RVA: 0x00306938 File Offset: 0x00304B38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006A63 RID: 27235 RVA: 0x00306948 File Offset: 0x00304B48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06006A64 RID: 27236 RVA: 0x00306958 File Offset: 0x00304B58
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06006A65 RID: 27237 RVA: 0x00306968 File Offset: 0x00304B68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06006A66 RID: 27238 RVA: 0x00306978 File Offset: 0x00304B78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06006A67 RID: 27239 RVA: 0x00306988 File Offset: 0x00304B88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(AcquaintanceInformation.Types.OnlineInformation other)
				{
				}

				// Token: 0x06006A68 RID: 27240 RVA: 0x00306998 File Offset: 0x00304B98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06006A69 RID: 27241 RVA: 0x003069A8 File Offset: 0x00304BA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06006A6A RID: 27242 RVA: 0x003069B8 File Offset: 0x00304BB8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static OnlineInformation()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							AcquaintanceInformation.Types.OnlineInformation._parser = new MessageParser<AcquaintanceInformation.Types.OnlineInformation>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							continue;
						case 4:
							return;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06006A6B RID: 27243 RVA: 0x00306A9C File Offset: 0x00304C9C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool WQH1NGGMsVlOTxvQgHXT()
				{
					return true;
				}

				// Token: 0x06006A6C RID: 27244 RVA: 0x00306AA4 File Offset: 0x00304CA4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static AcquaintanceInformation.Types.OnlineInformation ztmwDNGMdiTaOx4AonGp()
				{
					return null;
				}

				// Token: 0x04002536 RID: 9526
				private static readonly MessageParser<AcquaintanceInformation.Types.OnlineInformation> _parser;

				// Token: 0x04002537 RID: 9527
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002538 RID: 9528
				public const int CharacterIdFieldNumber = 1;

				// Token: 0x04002539 RID: 9529
				private long characterId_;

				// Token: 0x0400253A RID: 9530
				public const int CharacterNameFieldNumber = 2;

				// Token: 0x0400253B RID: 9531
				private string characterName_;

				// Token: 0x0400253C RID: 9532
				public const int MoodSmileyIdFieldNumber = 3;

				// Token: 0x0400253D RID: 9533
				private int moodSmileyId_;

				// Token: 0x0400253E RID: 9534
				public const int StatusFieldNumber = 4;

				// Token: 0x0400253F RID: 9535
				private CharacterStatus status_;

				// Token: 0x04002540 RID: 9536
				private static AcquaintanceInformation.Types.OnlineInformation ryC0UYGMg6RaeDYQgbwv;
			}
		}
	}
}
