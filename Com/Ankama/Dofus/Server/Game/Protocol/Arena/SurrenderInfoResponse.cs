using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C32 RID: 3122
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SurrenderInfoResponse : IMessage<SurrenderInfoResponse>, IMessage, IEquatable<SurrenderInfoResponse>, IDeepCloneable<SurrenderInfoResponse>, IBufferMessage
	{
		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06009613 RID: 38419 RVA: 0x00277F04 File Offset: 0x00276104
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SurrenderInfoResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06009614 RID: 38420 RVA: 0x00277F14 File Offset: 0x00276114
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

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06009615 RID: 38421 RVA: 0x00277F24 File Offset: 0x00276124
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

		// Token: 0x06009616 RID: 38422 RVA: 0x00277F34 File Offset: 0x00276134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderInfoResponse()
		{
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x00277F44 File Offset: 0x00276144
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderInfoResponse(SurrenderInfoResponse other)
		{
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x00277F54 File Offset: 0x00276154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderInfoResponse Clone()
		{
			return null;
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06009619 RID: 38425 RVA: 0x00277F64 File Offset: 0x00276164
		// (set) Token: 0x0600961A RID: 38426 RVA: 0x00277F74 File Offset: 0x00276174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurrenderInfoResponse.Types.SurrenderResponse SurrenderResponse
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

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x00277F84 File Offset: 0x00276184
		// (set) Token: 0x0600961C RID: 38428 RVA: 0x00277F94 File Offset: 0x00276194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SurrenderInfoResponse.Types.SurrenderVoteResponse SurrenderVoteResponse
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

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x0600961D RID: 38429 RVA: 0x00277FA4 File Offset: 0x002761A4
		// (set) Token: 0x0600961E RID: 38430 RVA: 0x00277FB4 File Offset: 0x002761B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSanction
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

		// Token: 0x0600961F RID: 38431 RVA: 0x00277FC4 File Offset: 0x002761C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009620 RID: 38432 RVA: 0x00277FD4 File Offset: 0x002761D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SurrenderInfoResponse other)
		{
			return true;
		}

		// Token: 0x06009621 RID: 38433 RVA: 0x00277FE4 File Offset: 0x002761E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009622 RID: 38434 RVA: 0x00277FF4 File Offset: 0x002761F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x00278004 File Offset: 0x00276204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x00278014 File Offset: 0x00276214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x00278024 File Offset: 0x00276224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x00278034 File Offset: 0x00276234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SurrenderInfoResponse other)
		{
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x00278044 File Offset: 0x00276244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009628 RID: 38440 RVA: 0x00278054 File Offset: 0x00276254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009629 RID: 38441 RVA: 0x00278064 File Offset: 0x00276264
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SurrenderInfoResponse()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					SurrenderInfoResponse._parser = new MessageParser<SurrenderInfoResponse>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x00278148 File Offset: 0x00276348
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Kva1YcJXuLWqt1YbirOP()
		{
			return true;
		}

		// Token: 0x0600962B RID: 38443 RVA: 0x00278150 File Offset: 0x00276350
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SurrenderInfoResponse g09tdFJX8eiSZayZKgtN()
		{
			return null;
		}

		// Token: 0x040037DB RID: 14299
		private static readonly MessageParser<SurrenderInfoResponse> _parser;

		// Token: 0x040037DC RID: 14300
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037DD RID: 14301
		public const int SurrenderResponseFieldNumber = 1;

		// Token: 0x040037DE RID: 14302
		private SurrenderInfoResponse.Types.SurrenderResponse surrenderResponse_;

		// Token: 0x040037DF RID: 14303
		public const int SurrenderVoteResponseFieldNumber = 2;

		// Token: 0x040037E0 RID: 14304
		private SurrenderInfoResponse.Types.SurrenderVoteResponse surrenderVoteResponse_;

		// Token: 0x040037E1 RID: 14305
		public const int HasSanctionFieldNumber = 3;

		// Token: 0x040037E2 RID: 14306
		private bool hasSanction_;

		// Token: 0x040037E3 RID: 14307
		internal static SurrenderInfoResponse apF2hqJXMetDrfOi6fdb;

		// Token: 0x02000C33 RID: 3123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600962C RID: 38444 RVA: 0x002E8584 File Offset: 0x002E6784
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000C34 RID: 3124
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SurrenderResponse : IMessage<SurrenderInfoResponse.Types.SurrenderResponse>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderResponse>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderResponse>, IBufferMessage
			{
				// Token: 0x17001C10 RID: 7184
				// (get) Token: 0x0600962D RID: 38445 RVA: 0x0030D868 File Offset: 0x0030BA68
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<SurrenderInfoResponse.Types.SurrenderResponse> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001C11 RID: 7185
				// (get) Token: 0x0600962E RID: 38446 RVA: 0x0030D878 File Offset: 0x0030BA78
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

				// Token: 0x17001C12 RID: 7186
				// (get) Token: 0x0600962F RID: 38447 RVA: 0x0030D888 File Offset: 0x0030BA88
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

				// Token: 0x06009630 RID: 38448 RVA: 0x0030D898 File Offset: 0x0030BA98
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SurrenderResponse()
				{
				}

				// Token: 0x06009631 RID: 38449 RVA: 0x0030D8A8 File Offset: 0x0030BAA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SurrenderResponse(SurrenderInfoResponse.Types.SurrenderResponse other)
				{
				}

				// Token: 0x06009632 RID: 38450 RVA: 0x0030D8B8 File Offset: 0x0030BAB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SurrenderInfoResponse.Types.SurrenderResponse Clone()
				{
					return null;
				}

				// Token: 0x17001C13 RID: 7187
				// (get) Token: 0x06009633 RID: 38451 RVA: 0x0030D8C8 File Offset: 0x0030BAC8
				// (set) Token: 0x06009634 RID: 38452 RVA: 0x0030D8D8 File Offset: 0x0030BAD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted Accepted
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

				// Token: 0x17001C14 RID: 7188
				// (get) Token: 0x06009635 RID: 38453 RVA: 0x0030D8E8 File Offset: 0x0030BAE8
				// (set) Token: 0x06009636 RID: 38454 RVA: 0x0030D8F8 File Offset: 0x0030BAF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused Refused
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

				// Token: 0x17001C15 RID: 7189
				// (get) Token: 0x06009637 RID: 38455 RVA: 0x0030D908 File Offset: 0x0030BB08
				// (set) Token: 0x06009638 RID: 38456 RVA: 0x0030D918 File Offset: 0x0030BB18
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn BeforeTurn
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

				// Token: 0x17001C16 RID: 7190
				// (get) Token: 0x06009639 RID: 38457 RVA: 0x0030D928 File Offset: 0x0030BB28
				// (set) Token: 0x0600963A RID: 38458 RVA: 0x0030D938 File Offset: 0x0030BB38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote BeforeVote
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

				// Token: 0x17001C17 RID: 7191
				// (get) Token: 0x0600963B RID: 38459 RVA: 0x0030D948 File Offset: 0x0030BB48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SurrenderInfoResponse.Types.SurrenderResponse.ResponseOneofCase ResponseCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (SurrenderInfoResponse.Types.SurrenderResponse.ResponseOneofCase)null;
					}
				}

				// Token: 0x0600963C RID: 38460 RVA: 0x0030D95C File Offset: 0x0030BB5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearResponse()
				{
				}

				// Token: 0x0600963D RID: 38461 RVA: 0x0030D96C File Offset: 0x0030BB6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600963E RID: 38462 RVA: 0x0030D97C File Offset: 0x0030BB7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(SurrenderInfoResponse.Types.SurrenderResponse other)
				{
					return true;
				}

				// Token: 0x0600963F RID: 38463 RVA: 0x0030D98C File Offset: 0x0030BB8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06009640 RID: 38464 RVA: 0x0030D99C File Offset: 0x0030BB9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06009641 RID: 38465 RVA: 0x0030D9AC File Offset: 0x0030BBAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009642 RID: 38466 RVA: 0x0030D9BC File Offset: 0x0030BBBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009643 RID: 38467 RVA: 0x0030D9CC File Offset: 0x0030BBCC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06009644 RID: 38468 RVA: 0x0030D9DC File Offset: 0x0030BBDC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(SurrenderInfoResponse.Types.SurrenderResponse other)
				{
				}

				// Token: 0x06009645 RID: 38469 RVA: 0x0030D9EC File Offset: 0x0030BBEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06009646 RID: 38470 RVA: 0x0030D9FC File Offset: 0x0030BBFC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06009647 RID: 38471 RVA: 0x0030DA0C File Offset: 0x0030BC0C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SurrenderResponse()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
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
								SurrenderInfoResponse.Types.SurrenderResponse._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderResponse>(() => null);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 3;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
								{
									num2 = 3;
									continue;
								}
								continue;
							}
							break;
						}
						IL_6F:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num = 2;
						continue;
						goto IL_6F;
					}
				}

				// Token: 0x06009648 RID: 38472 RVA: 0x0030DAF4 File Offset: 0x0030BCF4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool wYTAAoGZVIVGB7eGSwic()
				{
					return true;
				}

				// Token: 0x06009649 RID: 38473 RVA: 0x0030DAFC File Offset: 0x0030BCFC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static SurrenderInfoResponse.Types.SurrenderResponse SdbfEHGZ0UtidFuJqlTr()
				{
					return null;
				}

				// Token: 0x040037E4 RID: 14308
				private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderResponse> _parser;

				// Token: 0x040037E5 RID: 14309
				private UnknownFieldSet _unknownFields;

				// Token: 0x040037E6 RID: 14310
				public const int AcceptedFieldNumber = 1;

				// Token: 0x040037E7 RID: 14311
				public const int RefusedFieldNumber = 2;

				// Token: 0x040037E8 RID: 14312
				public const int BeforeTurnFieldNumber = 3;

				// Token: 0x040037E9 RID: 14313
				public const int BeforeVoteFieldNumber = 4;

				// Token: 0x040037EA RID: 14314
				private object response_;

				// Token: 0x040037EB RID: 14315
				private SurrenderInfoResponse.Types.SurrenderResponse.ResponseOneofCase responseCase_;

				// Token: 0x040037EC RID: 14316
				internal static SurrenderInfoResponse.Types.SurrenderResponse x3f7c9GZrO6oqNO8uo1b;

				// Token: 0x02000C35 RID: 3125
				public enum ResponseOneofCase
				{
					// Token: 0x040037EE RID: 14318
					None,
					// Token: 0x040037EF RID: 14319
					Accepted,
					// Token: 0x040037F0 RID: 14320
					Refused,
					// Token: 0x040037F1 RID: 14321
					BeforeTurn,
					// Token: 0x040037F2 RID: 14322
					BeforeVote
				}

				// Token: 0x02000C36 RID: 3126
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600964A RID: 38474 RVA: 0x00319E54 File Offset: 0x00318054
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000C37 RID: 3127
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderAccepted : IMessage<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted>, IBufferMessage
					{
						// Token: 0x17001C18 RID: 7192
						// (get) Token: 0x0600964B RID: 38475 RVA: 0x0031EE0C File Offset: 0x0031D00C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C19 RID: 7193
						// (get) Token: 0x0600964C RID: 38476 RVA: 0x0031EE1C File Offset: 0x0031D01C
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

						// Token: 0x17001C1A RID: 7194
						// (get) Token: 0x0600964D RID: 38477 RVA: 0x0031EE2C File Offset: 0x0031D02C
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

						// Token: 0x0600964E RID: 38478 RVA: 0x0031EE3C File Offset: 0x0031D03C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderAccepted()
						{
						}

						// Token: 0x0600964F RID: 38479 RVA: 0x0031EE4C File Offset: 0x0031D04C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderAccepted(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted other)
						{
						}

						// Token: 0x06009650 RID: 38480 RVA: 0x0031EE5C File Offset: 0x0031D05C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted Clone()
						{
							return null;
						}

						// Token: 0x06009651 RID: 38481 RVA: 0x0031EE6C File Offset: 0x0031D06C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06009652 RID: 38482 RVA: 0x0031EE7C File Offset: 0x0031D07C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted other)
						{
							return true;
						}

						// Token: 0x06009653 RID: 38483 RVA: 0x0031EE8C File Offset: 0x0031D08C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06009654 RID: 38484 RVA: 0x0031EE9C File Offset: 0x0031D09C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06009655 RID: 38485 RVA: 0x0031EEAC File Offset: 0x0031D0AC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06009656 RID: 38486 RVA: 0x0031EEBC File Offset: 0x0031D0BC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06009657 RID: 38487 RVA: 0x0031EECC File Offset: 0x0031D0CC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06009658 RID: 38488 RVA: 0x0031EEDC File Offset: 0x0031D0DC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted other)
						{
						}

						// Token: 0x06009659 RID: 38489 RVA: 0x0031EEEC File Offset: 0x0031D0EC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600965A RID: 38490 RVA: 0x0031EEFC File Offset: 0x0031D0FC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600965B RID: 38491 RVA: 0x0031EF0C File Offset: 0x0031D10C
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderAccepted()
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
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
									{
										num2 = 0;
									}
									break;
								case 1:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
									{
										num2 = 0;
									}
									break;
								case 2:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
									{
										num2 = 4;
									}
									break;
								case 3:
									return;
								case 4:
									SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted>(() => null);
									num2 = 3;
									break;
								}
							}
						}

						// Token: 0x0600965C RID: 38492 RVA: 0x0031EFF0 File Offset: 0x0031D1F0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool sofLx4gGXlX8MrU63fBp()
						{
							return true;
						}

						// Token: 0x0600965D RID: 38493 RVA: 0x0031EFF8 File Offset: 0x0031D1F8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted RdTpqrgGNLtIk8v000wU()
						{
							return null;
						}

						// Token: 0x040037F3 RID: 14323
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted> _parser;

						// Token: 0x040037F4 RID: 14324
						private UnknownFieldSet _unknownFields;

						// Token: 0x040037F5 RID: 14325
						internal static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderAccepted stJLB3gGEKtr4IsaxGh6;
					}

					// Token: 0x02000C39 RID: 3129
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderRefused : IMessage<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused>, IBufferMessage
					{
						// Token: 0x17001C1B RID: 7195
						// (get) Token: 0x06009663 RID: 38499 RVA: 0x0031F000 File Offset: 0x0031D200
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C1C RID: 7196
						// (get) Token: 0x06009664 RID: 38500 RVA: 0x0031F010 File Offset: 0x0031D210
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

						// Token: 0x17001C1D RID: 7197
						// (get) Token: 0x06009665 RID: 38501 RVA: 0x0031F020 File Offset: 0x0031D220
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

						// Token: 0x06009666 RID: 38502 RVA: 0x0031F030 File Offset: 0x0031D230
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderRefused()
						{
						}

						// Token: 0x06009667 RID: 38503 RVA: 0x0031F040 File Offset: 0x0031D240
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderRefused(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused other)
						{
						}

						// Token: 0x06009668 RID: 38504 RVA: 0x0031F050 File Offset: 0x0031D250
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused Clone()
						{
							return null;
						}

						// Token: 0x06009669 RID: 38505 RVA: 0x0031F060 File Offset: 0x0031D260
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600966A RID: 38506 RVA: 0x0031F070 File Offset: 0x0031D270
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused other)
						{
							return true;
						}

						// Token: 0x0600966B RID: 38507 RVA: 0x0031F080 File Offset: 0x0031D280
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600966C RID: 38508 RVA: 0x0031F090 File Offset: 0x0031D290
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600966D RID: 38509 RVA: 0x0031F0A0 File Offset: 0x0031D2A0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600966E RID: 38510 RVA: 0x0031F0B0 File Offset: 0x0031D2B0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600966F RID: 38511 RVA: 0x0031F0C0 File Offset: 0x0031D2C0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06009670 RID: 38512 RVA: 0x0031F0D0 File Offset: 0x0031D2D0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused other)
						{
						}

						// Token: 0x06009671 RID: 38513 RVA: 0x0031F0E0 File Offset: 0x0031D2E0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06009672 RID: 38514 RVA: 0x0031F0F0 File Offset: 0x0031D2F0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06009673 RID: 38515 RVA: 0x0031F100 File Offset: 0x0031D300
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderRefused()
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
									SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 3;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
									{
										num2 = 2;
										continue;
									}
									continue;
								}
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
								{
									num2 = 2;
								}
							}
						}

						// Token: 0x06009674 RID: 38516 RVA: 0x0031F1F8 File Offset: 0x0031D3F8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool m5Q5migG4DgoSYqLjNsq()
						{
							return true;
						}

						// Token: 0x06009675 RID: 38517 RVA: 0x0031F200 File Offset: 0x0031D400
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused gAGtwRgGjEU9LO1TlTnU()
						{
							return null;
						}

						// Token: 0x040037F8 RID: 14328
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused> _parser;

						// Token: 0x040037F9 RID: 14329
						private UnknownFieldSet _unknownFields;

						// Token: 0x040037FA RID: 14330
						private static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderRefused wCVegUgGxJY4coTZqXyt;
					}

					// Token: 0x02000C3B RID: 3131
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderBeforeTurn : IMessage<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn>, IBufferMessage
					{
						// Token: 0x17001C1E RID: 7198
						// (get) Token: 0x0600967B RID: 38523 RVA: 0x0031F208 File Offset: 0x0031D408
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C1F RID: 7199
						// (get) Token: 0x0600967C RID: 38524 RVA: 0x0031F218 File Offset: 0x0031D418
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

						// Token: 0x17001C20 RID: 7200
						// (get) Token: 0x0600967D RID: 38525 RVA: 0x0031F228 File Offset: 0x0031D428
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

						// Token: 0x0600967E RID: 38526 RVA: 0x0031F238 File Offset: 0x0031D438
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderBeforeTurn()
						{
						}

						// Token: 0x0600967F RID: 38527 RVA: 0x0031F248 File Offset: 0x0031D448
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderBeforeTurn(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn other)
						{
						}

						// Token: 0x06009680 RID: 38528 RVA: 0x0031F258 File Offset: 0x0031D458
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn Clone()
						{
							return null;
						}

						// Token: 0x17001C21 RID: 7201
						// (get) Token: 0x06009681 RID: 38529 RVA: 0x0031F268 File Offset: 0x0031D468
						// (set) Token: 0x06009682 RID: 38530 RVA: 0x0031F278 File Offset: 0x0031D478
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int MinTurnForSurrender
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

						// Token: 0x06009683 RID: 38531 RVA: 0x0031F288 File Offset: 0x0031D488
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06009684 RID: 38532 RVA: 0x0031F298 File Offset: 0x0031D498
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn other)
						{
							return true;
						}

						// Token: 0x06009685 RID: 38533 RVA: 0x0031F2A8 File Offset: 0x0031D4A8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06009686 RID: 38534 RVA: 0x0031F2B8 File Offset: 0x0031D4B8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06009687 RID: 38535 RVA: 0x0031F2C8 File Offset: 0x0031D4C8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06009688 RID: 38536 RVA: 0x0031F2D8 File Offset: 0x0031D4D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06009689 RID: 38537 RVA: 0x0031F2E8 File Offset: 0x0031D4E8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600968A RID: 38538 RVA: 0x0031F2F8 File Offset: 0x0031D4F8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn other)
						{
						}

						// Token: 0x0600968B RID: 38539 RVA: 0x0031F308 File Offset: 0x0031D508
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600968C RID: 38540 RVA: 0x0031F318 File Offset: 0x0031D518
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600968D RID: 38541 RVA: 0x0031F328 File Offset: 0x0031D528
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderBeforeTurn()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							for (;;)
							{
								int num2 = num;
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_35;
									case 2:
										return;
									case 3:
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 4:
										goto IL_B0;
									}
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
									{
										num2 = 1;
									}
								}
								IL_35:
								SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn>(() => null);
								num = 2;
								continue;
								IL_B0:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num = 3;
							}
						}

						// Token: 0x0600968E RID: 38542 RVA: 0x0031F3FC File Offset: 0x0031D5FC
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool kyRHLagGIWJ3LpFCqIeP()
						{
							return true;
						}

						// Token: 0x0600968F RID: 38543 RVA: 0x0031F404 File Offset: 0x0031D604
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn yvGeWvgGkBRJ5l6U5Xjv()
						{
							return null;
						}

						// Token: 0x040037FD RID: 14333
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn> _parser;

						// Token: 0x040037FE RID: 14334
						private UnknownFieldSet _unknownFields;

						// Token: 0x040037FF RID: 14335
						public const int MinTurnForSurrenderFieldNumber = 1;

						// Token: 0x04003800 RID: 14336
						private int minTurnForSurrender_;

						// Token: 0x04003801 RID: 14337
						private static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeTurn ChhMCigGK8xOHw8dCC3q;
					}

					// Token: 0x02000C3D RID: 3133
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderBeforeVote : IMessage<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote>, IBufferMessage
					{
						// Token: 0x17001C22 RID: 7202
						// (get) Token: 0x06009695 RID: 38549 RVA: 0x0031F40C File Offset: 0x0031D60C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C23 RID: 7203
						// (get) Token: 0x06009696 RID: 38550 RVA: 0x0031F41C File Offset: 0x0031D61C
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

						// Token: 0x17001C24 RID: 7204
						// (get) Token: 0x06009697 RID: 38551 RVA: 0x0031F42C File Offset: 0x0031D62C
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

						// Token: 0x06009698 RID: 38552 RVA: 0x0031F43C File Offset: 0x0031D63C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderBeforeVote()
						{
						}

						// Token: 0x06009699 RID: 38553 RVA: 0x0031F44C File Offset: 0x0031D64C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderBeforeVote(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote other)
						{
						}

						// Token: 0x0600969A RID: 38554 RVA: 0x0031F45C File Offset: 0x0031D65C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote Clone()
						{
							return null;
						}

						// Token: 0x0600969B RID: 38555 RVA: 0x0031F46C File Offset: 0x0031D66C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600969C RID: 38556 RVA: 0x0031F47C File Offset: 0x0031D67C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote other)
						{
							return true;
						}

						// Token: 0x0600969D RID: 38557 RVA: 0x0031F48C File Offset: 0x0031D68C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600969E RID: 38558 RVA: 0x0031F49C File Offset: 0x0031D69C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600969F RID: 38559 RVA: 0x0031F4AC File Offset: 0x0031D6AC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060096A0 RID: 38560 RVA: 0x0031F4BC File Offset: 0x0031D6BC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060096A1 RID: 38561 RVA: 0x0031F4CC File Offset: 0x0031D6CC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060096A2 RID: 38562 RVA: 0x0031F4DC File Offset: 0x0031D6DC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote other)
						{
						}

						// Token: 0x060096A3 RID: 38563 RVA: 0x0031F4EC File Offset: 0x0031D6EC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060096A4 RID: 38564 RVA: 0x0031F4FC File Offset: 0x0031D6FC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060096A5 RID: 38565 RVA: 0x0031F50C File Offset: 0x0031D70C
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderBeforeVote()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 2;
									continue;
								case 2:
									SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 3;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
									{
										num2 = 3;
										continue;
									}
									continue;
								}
								break;
							}
						}

						// Token: 0x060096A6 RID: 38566 RVA: 0x0031F5F0 File Offset: 0x0031D7F0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool o9knlegGcI9dvxEs1M4g()
						{
							return true;
						}

						// Token: 0x060096A7 RID: 38567 RVA: 0x0031F5F8 File Offset: 0x0031D7F8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote bhi4DvgGUIE77I0TQyPg()
						{
							return null;
						}

						// Token: 0x04003804 RID: 14340
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote> _parser;

						// Token: 0x04003805 RID: 14341
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003806 RID: 14342
						internal static SurrenderInfoResponse.Types.SurrenderResponse.Types.SurrenderBeforeVote GTnaargGlCWX0lKxuD4t;
					}
				}
			}

			// Token: 0x02000C40 RID: 3136
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SurrenderVoteResponse : IMessage<SurrenderInfoResponse.Types.SurrenderVoteResponse>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderVoteResponse>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderVoteResponse>, IBufferMessage
			{
				// Token: 0x17001C25 RID: 7205
				// (get) Token: 0x060096B2 RID: 38578 RVA: 0x0030DB04 File Offset: 0x0030BD04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001C26 RID: 7206
				// (get) Token: 0x060096B3 RID: 38579 RVA: 0x0030DB14 File Offset: 0x0030BD14
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

				// Token: 0x17001C27 RID: 7207
				// (get) Token: 0x060096B4 RID: 38580 RVA: 0x0030DB24 File Offset: 0x0030BD24
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

				// Token: 0x060096B5 RID: 38581 RVA: 0x0030DB34 File Offset: 0x0030BD34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SurrenderVoteResponse()
				{
				}

				// Token: 0x060096B6 RID: 38582 RVA: 0x0030DB44 File Offset: 0x0030BD44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SurrenderVoteResponse(SurrenderInfoResponse.Types.SurrenderVoteResponse other)
				{
				}

				// Token: 0x060096B7 RID: 38583 RVA: 0x0030DB54 File Offset: 0x0030BD54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SurrenderInfoResponse.Types.SurrenderVoteResponse Clone()
				{
					return null;
				}

				// Token: 0x17001C28 RID: 7208
				// (get) Token: 0x060096B8 RID: 38584 RVA: 0x0030DB64 File Offset: 0x0030BD64
				// (set) Token: 0x060096B9 RID: 38585 RVA: 0x0030DB74 File Offset: 0x0030BD74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted Accepted
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

				// Token: 0x17001C29 RID: 7209
				// (get) Token: 0x060096BA RID: 38586 RVA: 0x0030DB84 File Offset: 0x0030BD84
				// (set) Token: 0x060096BB RID: 38587 RVA: 0x0030DB94 File Offset: 0x0030BD94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused Refused
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

				// Token: 0x17001C2A RID: 7210
				// (get) Token: 0x060096BC RID: 38588 RVA: 0x0030DBA4 File Offset: 0x0030BDA4
				// (set) Token: 0x060096BD RID: 38589 RVA: 0x0030DBB4 File Offset: 0x0030BDB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn BeforeTurn
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

				// Token: 0x17001C2B RID: 7211
				// (get) Token: 0x060096BE RID: 38590 RVA: 0x0030DBC4 File Offset: 0x0030BDC4
				// (set) Token: 0x060096BF RID: 38591 RVA: 0x0030DBD4 File Offset: 0x0030BDD4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked AlreadyAsked
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

				// Token: 0x17001C2C RID: 7212
				// (get) Token: 0x060096C0 RID: 38592 RVA: 0x0030DBE4 File Offset: 0x0030BDE4
				// (set) Token: 0x060096C1 RID: 38593 RVA: 0x0030DBF4 File Offset: 0x0030BDF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting Waiting
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

				// Token: 0x17001C2D RID: 7213
				// (get) Token: 0x060096C2 RID: 38594 RVA: 0x0030DC04 File Offset: 0x0030BE04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public SurrenderInfoResponse.Types.SurrenderVoteResponse.ResponseOneofCase ResponseCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (SurrenderInfoResponse.Types.SurrenderVoteResponse.ResponseOneofCase)null;
					}
				}

				// Token: 0x060096C3 RID: 38595 RVA: 0x0030DC18 File Offset: 0x0030BE18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearResponse()
				{
				}

				// Token: 0x060096C4 RID: 38596 RVA: 0x0030DC28 File Offset: 0x0030BE28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060096C5 RID: 38597 RVA: 0x0030DC38 File Offset: 0x0030BE38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(SurrenderInfoResponse.Types.SurrenderVoteResponse other)
				{
					return true;
				}

				// Token: 0x060096C6 RID: 38598 RVA: 0x0030DC48 File Offset: 0x0030BE48
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060096C7 RID: 38599 RVA: 0x0030DC58 File Offset: 0x0030BE58
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060096C8 RID: 38600 RVA: 0x0030DC68 File Offset: 0x0030BE68
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060096C9 RID: 38601 RVA: 0x0030DC78 File Offset: 0x0030BE78
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060096CA RID: 38602 RVA: 0x0030DC88 File Offset: 0x0030BE88
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060096CB RID: 38603 RVA: 0x0030DC98 File Offset: 0x0030BE98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(SurrenderInfoResponse.Types.SurrenderVoteResponse other)
				{
				}

				// Token: 0x060096CC RID: 38604 RVA: 0x0030DCA8 File Offset: 0x0030BEA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060096CD RID: 38605 RVA: 0x0030DCB8 File Offset: 0x0030BEB8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060096CE RID: 38606 RVA: 0x0030DCC8 File Offset: 0x0030BEC8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SurrenderVoteResponse()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							break;
						case 1:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							return;
						case 4:
							SurrenderInfoResponse.Types.SurrenderVoteResponse._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse>(() => null);
							num2 = 3;
							break;
						}
					}
				}

				// Token: 0x060096CF RID: 38607 RVA: 0x0030DD94 File Offset: 0x0030BF94
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool MpbR8QGZDuZPhsHF6Ta5()
				{
					return true;
				}

				// Token: 0x060096D0 RID: 38608 RVA: 0x0030DD9C File Offset: 0x0030BF9C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static SurrenderInfoResponse.Types.SurrenderVoteResponse hHxGwsGZtankZblur9r2()
				{
					return null;
				}

				// Token: 0x0400380B RID: 14347
				private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse> _parser;

				// Token: 0x0400380C RID: 14348
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400380D RID: 14349
				public const int AcceptedFieldNumber = 1;

				// Token: 0x0400380E RID: 14350
				public const int RefusedFieldNumber = 2;

				// Token: 0x0400380F RID: 14351
				public const int BeforeTurnFieldNumber = 3;

				// Token: 0x04003810 RID: 14352
				public const int AlreadyAskedFieldNumber = 4;

				// Token: 0x04003811 RID: 14353
				public const int WaitingFieldNumber = 5;

				// Token: 0x04003812 RID: 14354
				private object response_;

				// Token: 0x04003813 RID: 14355
				private SurrenderInfoResponse.Types.SurrenderVoteResponse.ResponseOneofCase responseCase_;

				// Token: 0x04003814 RID: 14356
				private static SurrenderInfoResponse.Types.SurrenderVoteResponse zdVmSAGZCUV4MglPPHMt;

				// Token: 0x02000C41 RID: 3137
				public enum ResponseOneofCase
				{
					// Token: 0x04003816 RID: 14358
					None,
					// Token: 0x04003817 RID: 14359
					Accepted,
					// Token: 0x04003818 RID: 14360
					Refused,
					// Token: 0x04003819 RID: 14361
					BeforeTurn,
					// Token: 0x0400381A RID: 14362
					AlreadyAsked,
					// Token: 0x0400381B RID: 14363
					Waiting
				}

				// Token: 0x02000C42 RID: 3138
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x060096D1 RID: 38609 RVA: 0x00319F50 File Offset: 0x00318150
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000C43 RID: 3139
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderVoteAccepted : IMessage<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted>, IBufferMessage
					{
						// Token: 0x17001C2E RID: 7214
						// (get) Token: 0x060096D2 RID: 38610 RVA: 0x0031F600 File Offset: 0x0031D800
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C2F RID: 7215
						// (get) Token: 0x060096D3 RID: 38611 RVA: 0x0031F610 File Offset: 0x0031D810
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

						// Token: 0x17001C30 RID: 7216
						// (get) Token: 0x060096D4 RID: 38612 RVA: 0x0031F620 File Offset: 0x0031D820
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

						// Token: 0x060096D5 RID: 38613 RVA: 0x0031F630 File Offset: 0x0031D830
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteAccepted()
						{
						}

						// Token: 0x060096D6 RID: 38614 RVA: 0x0031F640 File Offset: 0x0031D840
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteAccepted(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted other)
						{
						}

						// Token: 0x060096D7 RID: 38615 RVA: 0x0031F650 File Offset: 0x0031D850
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted Clone()
						{
							return null;
						}

						// Token: 0x060096D8 RID: 38616 RVA: 0x0031F660 File Offset: 0x0031D860
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060096D9 RID: 38617 RVA: 0x0031F670 File Offset: 0x0031D870
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted other)
						{
							return true;
						}

						// Token: 0x060096DA RID: 38618 RVA: 0x0031F680 File Offset: 0x0031D880
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060096DB RID: 38619 RVA: 0x0031F690 File Offset: 0x0031D890
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060096DC RID: 38620 RVA: 0x0031F6A0 File Offset: 0x0031D8A0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060096DD RID: 38621 RVA: 0x0031F6B0 File Offset: 0x0031D8B0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060096DE RID: 38622 RVA: 0x0031F6C0 File Offset: 0x0031D8C0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060096DF RID: 38623 RVA: 0x0031F6D0 File Offset: 0x0031D8D0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted other)
						{
						}

						// Token: 0x060096E0 RID: 38624 RVA: 0x0031F6E0 File Offset: 0x0031D8E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060096E1 RID: 38625 RVA: 0x0031F6F0 File Offset: 0x0031D8F0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060096E2 RID: 38626 RVA: 0x0031F700 File Offset: 0x0031D900
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderVoteAccepted()
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
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 != 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 2:
										return;
									case 3:
										SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted>(() => null);
										num2 = 2;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 4:
										goto IL_AC;
									}
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 4;
								}
								IL_AC:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num = 3;
							}
						}

						// Token: 0x060096E3 RID: 38627 RVA: 0x0031F7D0 File Offset: 0x0031D9D0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool tyHMTNgGovi4SGpidWAw()
						{
							return true;
						}

						// Token: 0x060096E4 RID: 38628 RVA: 0x0031F7D8 File Offset: 0x0031D9D8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted yLxefPgG19UXYm8HKGUt()
						{
							return null;
						}

						// Token: 0x0400381C RID: 14364
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted> _parser;

						// Token: 0x0400381D RID: 14365
						private UnknownFieldSet _unknownFields;

						// Token: 0x0400381E RID: 14366
						private static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAccepted iksrR9gGv1bL1hT3mjhU;
					}

					// Token: 0x02000C45 RID: 3141
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderVoteRefused : IMessage<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused>, IBufferMessage
					{
						// Token: 0x17001C31 RID: 7217
						// (get) Token: 0x060096EA RID: 38634 RVA: 0x0031F7E0 File Offset: 0x0031D9E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C32 RID: 7218
						// (get) Token: 0x060096EB RID: 38635 RVA: 0x0031F7F0 File Offset: 0x0031D9F0
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

						// Token: 0x17001C33 RID: 7219
						// (get) Token: 0x060096EC RID: 38636 RVA: 0x0031F800 File Offset: 0x0031DA00
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

						// Token: 0x060096ED RID: 38637 RVA: 0x0031F810 File Offset: 0x0031DA10
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteRefused()
						{
						}

						// Token: 0x060096EE RID: 38638 RVA: 0x0031F820 File Offset: 0x0031DA20
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteRefused(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused other)
						{
						}

						// Token: 0x060096EF RID: 38639 RVA: 0x0031F830 File Offset: 0x0031DA30
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused Clone()
						{
							return null;
						}

						// Token: 0x060096F0 RID: 38640 RVA: 0x0031F840 File Offset: 0x0031DA40
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060096F1 RID: 38641 RVA: 0x0031F850 File Offset: 0x0031DA50
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused other)
						{
							return true;
						}

						// Token: 0x060096F2 RID: 38642 RVA: 0x0031F860 File Offset: 0x0031DA60
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060096F3 RID: 38643 RVA: 0x0031F870 File Offset: 0x0031DA70
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060096F4 RID: 38644 RVA: 0x0031F880 File Offset: 0x0031DA80
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060096F5 RID: 38645 RVA: 0x0031F890 File Offset: 0x0031DA90
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060096F6 RID: 38646 RVA: 0x0031F8A0 File Offset: 0x0031DAA0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060096F7 RID: 38647 RVA: 0x0031F8B0 File Offset: 0x0031DAB0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused other)
						{
						}

						// Token: 0x060096F8 RID: 38648 RVA: 0x0031F8C0 File Offset: 0x0031DAC0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060096F9 RID: 38649 RVA: 0x0031F8D0 File Offset: 0x0031DAD0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060096FA RID: 38650 RVA: 0x0031F8E0 File Offset: 0x0031DAE0
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderVoteRefused()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 3;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused>(() => null);
									num2 = 4;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
									{
										num2 = 4;
										continue;
									}
									continue;
								case 2:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 3:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
									{
										num2 = 2;
										continue;
									}
									continue;
								case 4:
									return;
								}
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
								{
									num2 = 1;
								}
							}
						}

						// Token: 0x060096FB RID: 38651 RVA: 0x0031F9D8 File Offset: 0x0031DBD8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool m7eE2rgG5L4vBexgZ4Bb()
						{
							return true;
						}

						// Token: 0x060096FC RID: 38652 RVA: 0x0031F9E0 File Offset: 0x0031DBE0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused qD2qSPgGyKpfaZMtU38b()
						{
							return null;
						}

						// Token: 0x04003821 RID: 14369
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused> _parser;

						// Token: 0x04003822 RID: 14370
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003823 RID: 14371
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteRefused buNdTTgGa037eVPpFELp;
					}

					// Token: 0x02000C47 RID: 3143
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderVoteBeforeTurn : IMessage<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn>, IBufferMessage
					{
						// Token: 0x17001C34 RID: 7220
						// (get) Token: 0x06009702 RID: 38658 RVA: 0x0031F9E8 File Offset: 0x0031DBE8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C35 RID: 7221
						// (get) Token: 0x06009703 RID: 38659 RVA: 0x0031F9F8 File Offset: 0x0031DBF8
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

						// Token: 0x17001C36 RID: 7222
						// (get) Token: 0x06009704 RID: 38660 RVA: 0x0031FA08 File Offset: 0x0031DC08
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

						// Token: 0x06009705 RID: 38661 RVA: 0x0031FA18 File Offset: 0x0031DC18
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteBeforeTurn()
						{
						}

						// Token: 0x06009706 RID: 38662 RVA: 0x0031FA28 File Offset: 0x0031DC28
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteBeforeTurn(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn other)
						{
						}

						// Token: 0x06009707 RID: 38663 RVA: 0x0031FA38 File Offset: 0x0031DC38
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn Clone()
						{
							return null;
						}

						// Token: 0x17001C37 RID: 7223
						// (get) Token: 0x06009708 RID: 38664 RVA: 0x0031FA48 File Offset: 0x0031DC48
						// (set) Token: 0x06009709 RID: 38665 RVA: 0x0031FA58 File Offset: 0x0031DC58
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int MinTurnForSurrenderVote
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

						// Token: 0x0600970A RID: 38666 RVA: 0x0031FA68 File Offset: 0x0031DC68
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600970B RID: 38667 RVA: 0x0031FA78 File Offset: 0x0031DC78
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn other)
						{
							return true;
						}

						// Token: 0x0600970C RID: 38668 RVA: 0x0031FA88 File Offset: 0x0031DC88
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600970D RID: 38669 RVA: 0x0031FA98 File Offset: 0x0031DC98
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600970E RID: 38670 RVA: 0x0031FAA8 File Offset: 0x0031DCA8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600970F RID: 38671 RVA: 0x0031FAB8 File Offset: 0x0031DCB8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06009710 RID: 38672 RVA: 0x0031FAC8 File Offset: 0x0031DCC8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06009711 RID: 38673 RVA: 0x0031FAD8 File Offset: 0x0031DCD8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn other)
						{
						}

						// Token: 0x06009712 RID: 38674 RVA: 0x0031FAE8 File Offset: 0x0031DCE8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06009713 RID: 38675 RVA: 0x0031FAF8 File Offset: 0x0031DCF8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06009714 RID: 38676 RVA: 0x0031FB08 File Offset: 0x0031DD08
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderVoteBeforeTurn()
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 2:
									SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn>(() => null);
									num2 = 3;
									continue;
								case 3:
									return;
								case 4:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
									{
										num2 = 2;
										continue;
									}
									continue;
								}
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 4;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
								{
									num2 = 4;
								}
							}
						}

						// Token: 0x06009715 RID: 38677 RVA: 0x0031FBEC File Offset: 0x0031DDEC
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool n9NblDgGLH34EP9qYFJK()
						{
							return true;
						}

						// Token: 0x06009716 RID: 38678 RVA: 0x0031FBF4 File Offset: 0x0031DDF4
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn qbKihQgGWTkp05Hr4k2k()
						{
							return null;
						}

						// Token: 0x04003826 RID: 14374
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn> _parser;

						// Token: 0x04003827 RID: 14375
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003828 RID: 14376
						public const int MinTurnForSurrenderVoteFieldNumber = 1;

						// Token: 0x04003829 RID: 14377
						private int minTurnForSurrenderVote_;

						// Token: 0x0400382A RID: 14378
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteBeforeTurn YhRSSngG6rvuuB02wm6M;
					}

					// Token: 0x02000C49 RID: 3145
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderVoteAlreadyAsked : IMessage<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked>, IBufferMessage
					{
						// Token: 0x17001C38 RID: 7224
						// (get) Token: 0x0600971C RID: 38684 RVA: 0x0031FBFC File Offset: 0x0031DDFC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C39 RID: 7225
						// (get) Token: 0x0600971D RID: 38685 RVA: 0x0031FC0C File Offset: 0x0031DE0C
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

						// Token: 0x17001C3A RID: 7226
						// (get) Token: 0x0600971E RID: 38686 RVA: 0x0031FC1C File Offset: 0x0031DE1C
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

						// Token: 0x0600971F RID: 38687 RVA: 0x0031FC2C File Offset: 0x0031DE2C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteAlreadyAsked()
						{
						}

						// Token: 0x06009720 RID: 38688 RVA: 0x0031FC3C File Offset: 0x0031DE3C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteAlreadyAsked(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked other)
						{
						}

						// Token: 0x06009721 RID: 38689 RVA: 0x0031FC4C File Offset: 0x0031DE4C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked Clone()
						{
							return null;
						}

						// Token: 0x06009722 RID: 38690 RVA: 0x0031FC5C File Offset: 0x0031DE5C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06009723 RID: 38691 RVA: 0x0031FC6C File Offset: 0x0031DE6C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked other)
						{
							return true;
						}

						// Token: 0x06009724 RID: 38692 RVA: 0x0031FC7C File Offset: 0x0031DE7C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06009725 RID: 38693 RVA: 0x0031FC8C File Offset: 0x0031DE8C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06009726 RID: 38694 RVA: 0x0031FC9C File Offset: 0x0031DE9C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06009727 RID: 38695 RVA: 0x0031FCAC File Offset: 0x0031DEAC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06009728 RID: 38696 RVA: 0x0031FCBC File Offset: 0x0031DEBC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06009729 RID: 38697 RVA: 0x0031FCCC File Offset: 0x0031DECC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked other)
						{
						}

						// Token: 0x0600972A RID: 38698 RVA: 0x0031FCDC File Offset: 0x0031DEDC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600972B RID: 38699 RVA: 0x0031FCEC File Offset: 0x0031DEEC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600972C RID: 38700 RVA: 0x0031FCFC File Offset: 0x0031DEFC
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderVoteAlreadyAsked()
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
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
									SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked>(() => null);
									num2 = 4;
									continue;
								case 4:
									return;
								}
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 != 0)
								{
									num2 = 0;
								}
							}
						}

						// Token: 0x0600972D RID: 38701 RVA: 0x0031FDC8 File Offset: 0x0031DFC8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool FVR22IgGr3dfQv3dTPe0()
						{
							return true;
						}

						// Token: 0x0600972E RID: 38702 RVA: 0x0031FDD0 File Offset: 0x0031DFD0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked y5l2m9gGV1nDwVWUmpa7()
						{
							return null;
						}

						// Token: 0x0400382D RID: 14381
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked> _parser;

						// Token: 0x0400382E RID: 14382
						private UnknownFieldSet _unknownFields;

						// Token: 0x0400382F RID: 14383
						private static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteAlreadyAsked kWIhyFgGhk9nihgyRnhv;
					}

					// Token: 0x02000C4B RID: 3147
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SurrenderVoteWaiting : IMessage<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting>, IMessage, IEquatable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting>, IDeepCloneable<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting>, IBufferMessage
					{
						// Token: 0x17001C3B RID: 7227
						// (get) Token: 0x06009734 RID: 38708 RVA: 0x0031FDD8 File Offset: 0x0031DFD8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001C3C RID: 7228
						// (get) Token: 0x06009735 RID: 38709 RVA: 0x0031FDE8 File Offset: 0x0031DFE8
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

						// Token: 0x17001C3D RID: 7229
						// (get) Token: 0x06009736 RID: 38710 RVA: 0x0031FDF8 File Offset: 0x0031DFF8
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

						// Token: 0x06009737 RID: 38711 RVA: 0x0031FE08 File Offset: 0x0031E008
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteWaiting()
						{
						}

						// Token: 0x06009738 RID: 38712 RVA: 0x0031FE18 File Offset: 0x0031E018
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderVoteWaiting(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting other)
						{
						}

						// Token: 0x06009739 RID: 38713 RVA: 0x0031FE28 File Offset: 0x0031E028
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting Clone()
						{
							return null;
						}

						// Token: 0x17001C3E RID: 7230
						// (get) Token: 0x0600973A RID: 38714 RVA: 0x0031FE38 File Offset: 0x0031E038
						// (set) Token: 0x0600973B RID: 38715 RVA: 0x0031FE48 File Offset: 0x0031E048
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public string VoteUnlockTimeStamp
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

						// Token: 0x0600973C RID: 38716 RVA: 0x0031FE58 File Offset: 0x0031E058
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600973D RID: 38717 RVA: 0x0031FE68 File Offset: 0x0031E068
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting other)
						{
							return true;
						}

						// Token: 0x0600973E RID: 38718 RVA: 0x0031FE78 File Offset: 0x0031E078
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600973F RID: 38719 RVA: 0x0031FE88 File Offset: 0x0031E088
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06009740 RID: 38720 RVA: 0x0031FE98 File Offset: 0x0031E098
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06009741 RID: 38721 RVA: 0x0031FEA8 File Offset: 0x0031E0A8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06009742 RID: 38722 RVA: 0x0031FEB8 File Offset: 0x0031E0B8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06009743 RID: 38723 RVA: 0x0031FEC8 File Offset: 0x0031E0C8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting other)
						{
						}

						// Token: 0x06009744 RID: 38724 RVA: 0x0031FED8 File Offset: 0x0031E0D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06009745 RID: 38725 RVA: 0x0031FEE8 File Offset: 0x0031E0E8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06009746 RID: 38726 RVA: 0x0031FEF8 File Offset: 0x0031E0F8
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SurrenderVoteWaiting()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								case 1:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 2:
									SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting._parser = new MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
									{
										num2 = 3;
										continue;
									}
									continue;
								}
								break;
							}
						}

						// Token: 0x06009747 RID: 38727 RVA: 0x0031FFF0 File Offset: 0x0031E1F0
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool A9djMwgGChPX5TF3Vqa6()
						{
							return true;
						}

						// Token: 0x06009748 RID: 38728 RVA: 0x0031FFF8 File Offset: 0x0031E1F8
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting mxXNMNgGDGbLO4FW0fvT()
						{
							return null;
						}

						// Token: 0x04003832 RID: 14386
						private static readonly MessageParser<SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting> _parser;

						// Token: 0x04003833 RID: 14387
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003834 RID: 14388
						public const int VoteUnlockTimeStampFieldNumber = 1;

						// Token: 0x04003835 RID: 14389
						private string voteUnlockTimeStamp_;

						// Token: 0x04003836 RID: 14390
						internal static SurrenderInfoResponse.Types.SurrenderVoteResponse.Types.SurrenderVoteWaiting Tdf1krgG0RgFCJrQVfcf;
					}
				}
			}
		}
	}
}
