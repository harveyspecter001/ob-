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
	// Token: 0x02000886 RID: 2182
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendInformation : IMessage<FriendInformation>, IMessage, IEquatable<FriendInformation>, IDeepCloneable<FriendInformation>, IBufferMessage
	{
		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x0022F144 File Offset: 0x0022D344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x060069E0 RID: 27104 RVA: 0x0022F154 File Offset: 0x0022D354
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

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x0022F164 File Offset: 0x0022D364
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

		// Token: 0x060069E2 RID: 27106 RVA: 0x0022F174 File Offset: 0x0022D374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendInformation()
		{
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x0022F184 File Offset: 0x0022D384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendInformation(FriendInformation other)
		{
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x0022F194 File Offset: 0x0022D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendInformation Clone()
		{
			return null;
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x0022F1A4 File Offset: 0x0022D3A4
		// (set) Token: 0x060069E6 RID: 27110 RVA: 0x0022F1B4 File Offset: 0x0022D3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x0022F1C4 File Offset: 0x0022D3C4
		// (set) Token: 0x060069E8 RID: 27112 RVA: 0x0022F1D4 File Offset: 0x0022D3D4
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

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x0022F1E4 File Offset: 0x0022D3E4
		// (set) Token: 0x060069EA RID: 27114 RVA: 0x0022F1F8 File Offset: 0x0022D3F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x0022F208 File Offset: 0x0022D408
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x0022F218 File Offset: 0x0022D418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long DurationSinceLastConnectionHours
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

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x0022F228 File Offset: 0x0022D428
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x0022F238 File Offset: 0x0022D438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeagueId
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

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x060069EF RID: 27119 RVA: 0x0022F248 File Offset: 0x0022D448
		// (set) Token: 0x060069F0 RID: 27120 RVA: 0x0022F258 File Offset: 0x0022D458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInformation.Types.FriendOnlineInformation OnlineInformation
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

		// Token: 0x060069F1 RID: 27121 RVA: 0x0022F268 File Offset: 0x0022D468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x0022F278 File Offset: 0x0022D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendInformation other)
		{
			return true;
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x0022F288 File Offset: 0x0022D488
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x0022F298 File Offset: 0x0022D498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x0022F2A8 File Offset: 0x0022D4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x0022F2B8 File Offset: 0x0022D4B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x0022F2C8 File Offset: 0x0022D4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x0022F2D8 File Offset: 0x0022D4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendInformation other)
		{
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0022F2E8 File Offset: 0x0022D4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0022F2F8 File Offset: 0x0022D4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x0022F308 File Offset: 0x0022D508
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FriendInformation._parser = new MessageParser<FriendInformation>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x0022F3EC File Offset: 0x0022D5EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JwhLrCJnZ1o3M1Owp3fI()
		{
			return true;
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x0022F3F4 File Offset: 0x0022D5F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendInformation zcKXjUJnqAHahMSJsX8E()
		{
			return null;
		}

		// Token: 0x040024FB RID: 9467
		private static readonly MessageParser<FriendInformation> _parser;

		// Token: 0x040024FC RID: 9468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024FD RID: 9469
		public const int AccountIdFieldNumber = 1;

		// Token: 0x040024FE RID: 9470
		private long accountId_;

		// Token: 0x040024FF RID: 9471
		public const int AccountTagFieldNumber = 2;

		// Token: 0x04002500 RID: 9472
		private AccountTag accountTag_;

		// Token: 0x04002501 RID: 9473
		public const int StateFieldNumber = 3;

		// Token: 0x04002502 RID: 9474
		private CharacterState state_;

		// Token: 0x04002503 RID: 9475
		public const int DurationSinceLastConnectionHoursFieldNumber = 4;

		// Token: 0x04002504 RID: 9476
		private long durationSinceLastConnectionHours_;

		// Token: 0x04002505 RID: 9477
		public const int LeagueIdFieldNumber = 5;

		// Token: 0x04002506 RID: 9478
		private int leagueId_;

		// Token: 0x04002507 RID: 9479
		public const int OnlineInformationFieldNumber = 6;

		// Token: 0x04002508 RID: 9480
		private FriendInformation.Types.FriendOnlineInformation onlineInformation_;

		// Token: 0x04002509 RID: 9481
		internal static FriendInformation kwranKJn8Txc0ysujcqr;

		// Token: 0x02000887 RID: 2183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060069FE RID: 27134 RVA: 0x002D771C File Offset: 0x002D591C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000888 RID: 2184
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class FriendOnlineInformation : IMessage<FriendInformation.Types.FriendOnlineInformation>, IMessage, IEquatable<FriendInformation.Types.FriendOnlineInformation>, IDeepCloneable<FriendInformation.Types.FriendOnlineInformation>, IBufferMessage
			{
				// Token: 0x17001318 RID: 4888
				// (get) Token: 0x060069FF RID: 27135 RVA: 0x00306488 File Offset: 0x00304688
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FriendInformation.Types.FriendOnlineInformation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001319 RID: 4889
				// (get) Token: 0x06006A00 RID: 27136 RVA: 0x00306498 File Offset: 0x00304698
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

				// Token: 0x1700131A RID: 4890
				// (get) Token: 0x06006A01 RID: 27137 RVA: 0x003064A8 File Offset: 0x003046A8
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

				// Token: 0x06006A02 RID: 27138 RVA: 0x003064B8 File Offset: 0x003046B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FriendOnlineInformation()
				{
				}

				// Token: 0x06006A03 RID: 27139 RVA: 0x003064C8 File Offset: 0x003046C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FriendOnlineInformation(FriendInformation.Types.FriendOnlineInformation other)
				{
				}

				// Token: 0x06006A04 RID: 27140 RVA: 0x003064D8 File Offset: 0x003046D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FriendInformation.Types.FriendOnlineInformation Clone()
				{
					return null;
				}

				// Token: 0x1700131B RID: 4891
				// (get) Token: 0x06006A05 RID: 27141 RVA: 0x003064E8 File Offset: 0x003046E8
				// (set) Token: 0x06006A06 RID: 27142 RVA: 0x003064F8 File Offset: 0x003046F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x1700131C RID: 4892
				// (get) Token: 0x06006A07 RID: 27143 RVA: 0x00306508 File Offset: 0x00304708
				// (set) Token: 0x06006A08 RID: 27144 RVA: 0x00306518 File Offset: 0x00304718
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

				// Token: 0x1700131D RID: 4893
				// (get) Token: 0x06006A09 RID: 27145 RVA: 0x00306528 File Offset: 0x00304728
				// (set) Token: 0x06006A0A RID: 27146 RVA: 0x00306538 File Offset: 0x00304738
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CharacterLevel
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

				// Token: 0x1700131E RID: 4894
				// (get) Token: 0x06006A0B RID: 27147 RVA: 0x00306548 File Offset: 0x00304748
				// (set) Token: 0x06006A0C RID: 27148 RVA: 0x0030655C File Offset: 0x0030475C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public Alignment Alignment
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (Alignment)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x1700131F RID: 4895
				// (get) Token: 0x06006A0D RID: 27149 RVA: 0x0030656C File Offset: 0x0030476C
				// (set) Token: 0x06006A0E RID: 27150 RVA: 0x0030657C File Offset: 0x0030477C
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

				// Token: 0x17001320 RID: 4896
				// (get) Token: 0x06006A0F RID: 27151 RVA: 0x0030658C File Offset: 0x0030478C
				// (set) Token: 0x06006A10 RID: 27152 RVA: 0x003065A0 File Offset: 0x003047A0
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

				// Token: 0x17001321 RID: 4897
				// (get) Token: 0x06006A11 RID: 27153 RVA: 0x003065B0 File Offset: 0x003047B0
				// (set) Token: 0x06006A12 RID: 27154 RVA: 0x003065C0 File Offset: 0x003047C0
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

				// Token: 0x17001322 RID: 4898
				// (get) Token: 0x06006A13 RID: 27155 RVA: 0x003065D0 File Offset: 0x003047D0
				// (set) Token: 0x06006A14 RID: 27156 RVA: 0x003065E0 File Offset: 0x003047E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HavenBagShared
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

				// Token: 0x17001323 RID: 4899
				// (get) Token: 0x06006A15 RID: 27157 RVA: 0x003065F0 File Offset: 0x003047F0
				// (set) Token: 0x06006A16 RID: 27158 RVA: 0x00306600 File Offset: 0x00304800
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
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

				// Token: 0x17001324 RID: 4900
				// (get) Token: 0x06006A17 RID: 27159 RVA: 0x00306610 File Offset: 0x00304810
				// (set) Token: 0x06006A18 RID: 27160 RVA: 0x00306620 File Offset: 0x00304820
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GuildInformation Guild
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

				// Token: 0x17001325 RID: 4901
				// (get) Token: 0x06006A19 RID: 27161 RVA: 0x00306630 File Offset: 0x00304830
				// (set) Token: 0x06006A1A RID: 27162 RVA: 0x00306640 File Offset: 0x00304840
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public AllianceInformation Alliance
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

				// Token: 0x17001326 RID: 4902
				// (get) Token: 0x06006A1B RID: 27163 RVA: 0x00306650 File Offset: 0x00304850
				// (set) Token: 0x06006A1C RID: 27164 RVA: 0x00306660 File Offset: 0x00304860
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int AchievementPoints
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

				// Token: 0x17001327 RID: 4903
				// (get) Token: 0x06006A1D RID: 27165 RVA: 0x00306670 File Offset: 0x00304870
				// (set) Token: 0x06006A1E RID: 27166 RVA: 0x00306680 File Offset: 0x00304880
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int LadderPosition
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

				// Token: 0x06006A1F RID: 27167 RVA: 0x00306690 File Offset: 0x00304890
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06006A20 RID: 27168 RVA: 0x003066A0 File Offset: 0x003048A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FriendInformation.Types.FriendOnlineInformation other)
				{
					return true;
				}

				// Token: 0x06006A21 RID: 27169 RVA: 0x003066B0 File Offset: 0x003048B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06006A22 RID: 27170 RVA: 0x003066C0 File Offset: 0x003048C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06006A23 RID: 27171 RVA: 0x003066D0 File Offset: 0x003048D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06006A24 RID: 27172 RVA: 0x003066E0 File Offset: 0x003048E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06006A25 RID: 27173 RVA: 0x003066F0 File Offset: 0x003048F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06006A26 RID: 27174 RVA: 0x00306700 File Offset: 0x00304900
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FriendInformation.Types.FriendOnlineInformation other)
				{
				}

				// Token: 0x06006A27 RID: 27175 RVA: 0x00306710 File Offset: 0x00304910
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06006A28 RID: 27176 RVA: 0x00306720 File Offset: 0x00304920
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06006A29 RID: 27177 RVA: 0x00306730 File Offset: 0x00304930
				[MethodImpl(MethodImplOptions.NoInlining)]
				static FriendOnlineInformation()
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
							FriendInformation.Types.FriendOnlineInformation._parser = new MessageParser<FriendInformation.Types.FriendOnlineInformation>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06006A2A RID: 27178 RVA: 0x00306828 File Offset: 0x00304A28
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool U7gA0aGMJTybEisUmA7C()
				{
					return true;
				}

				// Token: 0x06006A2B RID: 27179 RVA: 0x00306830 File Offset: 0x00304A30
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FriendInformation.Types.FriendOnlineInformation GYGDVAGMGoBg0usldPqp()
				{
					return null;
				}

				// Token: 0x0400250A RID: 9482
				private static readonly MessageParser<FriendInformation.Types.FriendOnlineInformation> _parser;

				// Token: 0x0400250B RID: 9483
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400250C RID: 9484
				public const int CharacterIdFieldNumber = 1;

				// Token: 0x0400250D RID: 9485
				private long characterId_;

				// Token: 0x0400250E RID: 9486
				public const int CharacterNameFieldNumber = 2;

				// Token: 0x0400250F RID: 9487
				private string characterName_;

				// Token: 0x04002510 RID: 9488
				public const int CharacterLevelFieldNumber = 3;

				// Token: 0x04002511 RID: 9489
				private int characterLevel_;

				// Token: 0x04002512 RID: 9490
				public const int AlignmentFieldNumber = 4;

				// Token: 0x04002513 RID: 9491
				private Alignment alignment_;

				// Token: 0x04002514 RID: 9492
				public const int BreedIdFieldNumber = 5;

				// Token: 0x04002515 RID: 9493
				private int breedId_;

				// Token: 0x04002516 RID: 9494
				public const int GenderFieldNumber = 6;

				// Token: 0x04002517 RID: 9495
				private Gender gender_;

				// Token: 0x04002518 RID: 9496
				public const int MoodSmileyIdFieldNumber = 7;

				// Token: 0x04002519 RID: 9497
				private int moodSmileyId_;

				// Token: 0x0400251A RID: 9498
				public const int HavenBagSharedFieldNumber = 8;

				// Token: 0x0400251B RID: 9499
				private bool havenBagShared_;

				// Token: 0x0400251C RID: 9500
				public const int StatusFieldNumber = 9;

				// Token: 0x0400251D RID: 9501
				private CharacterStatus status_;

				// Token: 0x0400251E RID: 9502
				public const int GuildFieldNumber = 10;

				// Token: 0x0400251F RID: 9503
				private GuildInformation guild_;

				// Token: 0x04002520 RID: 9504
				public const int AllianceFieldNumber = 11;

				// Token: 0x04002521 RID: 9505
				private AllianceInformation alliance_;

				// Token: 0x04002522 RID: 9506
				public const int AchievementPointsFieldNumber = 12;

				// Token: 0x04002523 RID: 9507
				private int achievementPoints_;

				// Token: 0x04002524 RID: 9508
				public const int LadderPositionFieldNumber = 13;

				// Token: 0x04002525 RID: 9509
				private int ladderPosition_;

				// Token: 0x04002526 RID: 9510
				private static FriendInformation.Types.FriendOnlineInformation t1nKIvGMOD7hDuWeEvBu;
			}
		}
	}
}
