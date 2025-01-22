using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A14 RID: 2580
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInformation : IMessage<AllianceInformation>, IMessage, IEquatable<AllianceInformation>, IDeepCloneable<AllianceInformation>, IBufferMessage
	{
		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x0025BF78 File Offset: 0x0025A178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06007B15 RID: 31509 RVA: 0x0025BF88 File Offset: 0x0025A188
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

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06007B16 RID: 31510 RVA: 0x0025BF98 File Offset: 0x0025A198
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

		// Token: 0x06007B17 RID: 31511 RVA: 0x0025BFA8 File Offset: 0x0025A1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInformation()
		{
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x0025BFB8 File Offset: 0x0025A1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInformation(AllianceInformation other)
		{
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x0025BFC8 File Offset: 0x0025A1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInformation Clone()
		{
			return null;
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06007B1A RID: 31514 RVA: 0x0025BFD8 File Offset: 0x0025A1D8
		// (set) Token: 0x06007B1B RID: 31515 RVA: 0x0025BFE8 File Offset: 0x0025A1E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Uid
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

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x0025BFF8 File Offset: 0x0025A1F8
		// (set) Token: 0x06007B1D RID: 31517 RVA: 0x0025C008 File Offset: 0x0025A208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Tag
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

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x0025C018 File Offset: 0x0025A218
		// (set) Token: 0x06007B1F RID: 31519 RVA: 0x0025C028 File Offset: 0x0025A228
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

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x0025C038 File Offset: 0x0025A238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x0025C048 File Offset: 0x0025A248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearName()
		{
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x0025C058 File Offset: 0x0025A258
		// (set) Token: 0x06007B23 RID: 31523 RVA: 0x0025C068 File Offset: 0x0025A268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialEmblem Emblem
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

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x0025C078 File Offset: 0x0025A278
		// (set) Token: 0x06007B25 RID: 31525 RVA: 0x0025C088 File Offset: 0x0025A288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceInformation.Types.AllianceCardInformation CardInformation
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

		// Token: 0x06007B26 RID: 31526 RVA: 0x0025C098 File Offset: 0x0025A298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x0025C0A8 File Offset: 0x0025A2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInformation other)
		{
			return true;
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x0025C0B8 File Offset: 0x0025A2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x0025C0C8 File Offset: 0x0025A2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x0025C0D8 File Offset: 0x0025A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x0025C0E8 File Offset: 0x0025A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x0025C0F8 File Offset: 0x0025A2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x0025C108 File Offset: 0x0025A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInformation other)
		{
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x0025C118 File Offset: 0x0025A318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x0025C128 File Offset: 0x0025A328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x0025C138 File Offset: 0x0025A338
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInformation()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AllianceInformation.NameDefaultValue = "";
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					AllianceInformation._parser = new MessageParser<AllianceInformation>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x0025C234 File Offset: 0x0025A434
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vU4KRMJGRnZADjjd63Lv()
		{
			return true;
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x0025C23C File Offset: 0x0025A43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInformation s98yjCJGOXOgkyC03uud()
		{
			return null;
		}

		// Token: 0x04002C19 RID: 11289
		private static readonly MessageParser<AllianceInformation> _parser;

		// Token: 0x04002C1A RID: 11290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C1B RID: 11291
		public const int UidFieldNumber = 1;

		// Token: 0x04002C1C RID: 11292
		private string uid_;

		// Token: 0x04002C1D RID: 11293
		public const int TagFieldNumber = 2;

		// Token: 0x04002C1E RID: 11294
		private string tag_;

		// Token: 0x04002C1F RID: 11295
		public const int NameFieldNumber = 3;

		// Token: 0x04002C20 RID: 11296
		private static readonly string NameDefaultValue;

		// Token: 0x04002C21 RID: 11297
		private string name_;

		// Token: 0x04002C22 RID: 11298
		public const int EmblemFieldNumber = 4;

		// Token: 0x04002C23 RID: 11299
		private SocialEmblem emblem_;

		// Token: 0x04002C24 RID: 11300
		public const int CardInformationFieldNumber = 5;

		// Token: 0x04002C25 RID: 11301
		private AllianceInformation.Types.AllianceCardInformation cardInformation_;

		// Token: 0x04002C26 RID: 11302
		private static AllianceInformation AqO6a3JG33RwWLGSoIE6;

		// Token: 0x02000A15 RID: 2581
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06007B33 RID: 31539 RVA: 0x002DEED4 File Offset: 0x002DD0D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A16 RID: 2582
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class AllianceCardInformation : IMessage<AllianceInformation.Types.AllianceCardInformation>, IMessage, IEquatable<AllianceInformation.Types.AllianceCardInformation>, IDeepCloneable<AllianceInformation.Types.AllianceCardInformation>, IBufferMessage
			{
				// Token: 0x17001634 RID: 5684
				// (get) Token: 0x06007B34 RID: 31540 RVA: 0x0030713C File Offset: 0x0030533C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<AllianceInformation.Types.AllianceCardInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001635 RID: 5685
				// (get) Token: 0x06007B35 RID: 31541 RVA: 0x0030714C File Offset: 0x0030534C
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

				// Token: 0x17001636 RID: 5686
				// (get) Token: 0x06007B36 RID: 31542 RVA: 0x0030715C File Offset: 0x0030535C
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

				// Token: 0x06007B37 RID: 31543 RVA: 0x0030716C File Offset: 0x0030536C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AllianceCardInformation()
				{
				}

				// Token: 0x06007B38 RID: 31544 RVA: 0x0030717C File Offset: 0x0030537C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AllianceCardInformation(AllianceInformation.Types.AllianceCardInformation other)
				{
				}

				// Token: 0x06007B39 RID: 31545 RVA: 0x0030718C File Offset: 0x0030538C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AllianceInformation.Types.AllianceCardInformation Clone()
				{
					return null;
				}

				// Token: 0x17001637 RID: 5687
				// (get) Token: 0x06007B3A RID: 31546 RVA: 0x0030719C File Offset: 0x0030539C
				// (set) Token: 0x06007B3B RID: 31547 RVA: 0x003071AC File Offset: 0x003053AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long CreationDate
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

				// Token: 0x17001638 RID: 5688
				// (get) Token: 0x06007B3C RID: 31548 RVA: 0x003071BC File Offset: 0x003053BC
				// (set) Token: 0x06007B3D RID: 31549 RVA: 0x003071CC File Offset: 0x003053CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int MembersNumber
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

				// Token: 0x17001639 RID: 5689
				// (get) Token: 0x06007B3E RID: 31550 RVA: 0x003071DC File Offset: 0x003053DC
				// (set) Token: 0x06007B3F RID: 31551 RVA: 0x003071EC File Offset: 0x003053EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int SubareaNumber
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

				// Token: 0x1700163A RID: 5690
				// (get) Token: 0x06007B40 RID: 31552 RVA: 0x003071FC File Offset: 0x003053FC
				// (set) Token: 0x06007B41 RID: 31553 RVA: 0x0030720C File Offset: 0x0030540C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int TaxCollectorNumber
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

				// Token: 0x1700163B RID: 5691
				// (get) Token: 0x06007B42 RID: 31554 RVA: 0x0030721C File Offset: 0x0030541C
				// (set) Token: 0x06007B43 RID: 31555 RVA: 0x0030722C File Offset: 0x0030542C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public AllianceRecruitmentInformation Recruitment
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

				// Token: 0x06007B44 RID: 31556 RVA: 0x0030723C File Offset: 0x0030543C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007B45 RID: 31557 RVA: 0x0030724C File Offset: 0x0030544C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(AllianceInformation.Types.AllianceCardInformation other)
				{
					return true;
				}

				// Token: 0x06007B46 RID: 31558 RVA: 0x0030725C File Offset: 0x0030545C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007B47 RID: 31559 RVA: 0x0030726C File Offset: 0x0030546C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007B48 RID: 31560 RVA: 0x0030727C File Offset: 0x0030547C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007B49 RID: 31561 RVA: 0x0030728C File Offset: 0x0030548C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007B4A RID: 31562 RVA: 0x0030729C File Offset: 0x0030549C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007B4B RID: 31563 RVA: 0x003072AC File Offset: 0x003054AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(AllianceInformation.Types.AllianceCardInformation other)
				{
				}

				// Token: 0x06007B4C RID: 31564 RVA: 0x003072BC File Offset: 0x003054BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007B4D RID: 31565 RVA: 0x003072CC File Offset: 0x003054CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007B4E RID: 31566 RVA: 0x003072DC File Offset: 0x003054DC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static AllianceCardInformation()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							break;
						case 4:
							AllianceInformation.Types.AllianceCardInformation._parser = new MessageParser<AllianceInformation.Types.AllianceCardInformation>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}

				// Token: 0x06007B4F RID: 31567 RVA: 0x003073A8 File Offset: 0x003055A8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Yn5OQGGMbZNTN6Ls4ib8()
				{
					return true;
				}

				// Token: 0x06007B50 RID: 31568 RVA: 0x003073B0 File Offset: 0x003055B0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static AllianceInformation.Types.AllianceCardInformation zfKpcUGMi1EumB1VqCcZ()
				{
					return null;
				}

				// Token: 0x04002C27 RID: 11303
				private static readonly MessageParser<AllianceInformation.Types.AllianceCardInformation> _parser;

				// Token: 0x04002C28 RID: 11304
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002C29 RID: 11305
				public const int CreationDateFieldNumber = 1;

				// Token: 0x04002C2A RID: 11306
				private long creationDate_;

				// Token: 0x04002C2B RID: 11307
				public const int MembersNumberFieldNumber = 2;

				// Token: 0x04002C2C RID: 11308
				private int membersNumber_;

				// Token: 0x04002C2D RID: 11309
				public const int SubareaNumberFieldNumber = 3;

				// Token: 0x04002C2E RID: 11310
				private int subareaNumber_;

				// Token: 0x04002C2F RID: 11311
				public const int TaxCollectorNumberFieldNumber = 4;

				// Token: 0x04002C30 RID: 11312
				private int taxCollectorNumber_;

				// Token: 0x04002C31 RID: 11313
				public const int RecruitmentFieldNumber = 5;

				// Token: 0x04002C32 RID: 11314
				private AllianceRecruitmentInformation recruitment_;

				// Token: 0x04002C33 RID: 11315
				private static AllianceInformation.Types.AllianceCardInformation uxdFZMGMYmjlVQe2Dupr;
			}
		}
	}
}
