using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C1A RID: 3098
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaUpdatePlayerInformationEvent : IMessage<ArenaUpdatePlayerInformationEvent>, IMessage, IEquatable<ArenaUpdatePlayerInformationEvent>, IDeepCloneable<ArenaUpdatePlayerInformationEvent>, IBufferMessage
	{
		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x060094D3 RID: 38099 RVA: 0x00276AC8 File Offset: 0x00274CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaUpdatePlayerInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x060094D4 RID: 38100 RVA: 0x00276AD8 File Offset: 0x00274CD8
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

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060094D5 RID: 38101 RVA: 0x00276AE8 File Offset: 0x00274CE8
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

		// Token: 0x060094D6 RID: 38102 RVA: 0x00276AF8 File Offset: 0x00274CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaUpdatePlayerInformationEvent()
		{
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x00276B08 File Offset: 0x00274D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaUpdatePlayerInformationEvent(ArenaUpdatePlayerInformationEvent other)
		{
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x00276B18 File Offset: 0x00274D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaUpdatePlayerInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x060094D9 RID: 38105 RVA: 0x00276B28 File Offset: 0x00274D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ArenaUpdatePlayerInformationEvent.Types.ArenaRank> ArenaRanks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x060094DA RID: 38106 RVA: 0x00276B38 File Offset: 0x00274D38
		// (set) Token: 0x060094DB RID: 38107 RVA: 0x00276B48 File Offset: 0x00274D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string BanEndDate
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

		// Token: 0x060094DC RID: 38108 RVA: 0x00276B58 File Offset: 0x00274D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x00276B68 File Offset: 0x00274D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaUpdatePlayerInformationEvent other)
		{
			return true;
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x00276B78 File Offset: 0x00274D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x00276B88 File Offset: 0x00274D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x00276B98 File Offset: 0x00274D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x00276BA8 File Offset: 0x00274DA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x00276BB8 File Offset: 0x00274DB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x00276BC8 File Offset: 0x00274DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaUpdatePlayerInformationEvent other)
		{
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x00276BD8 File Offset: 0x00274DD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x00276BE8 File Offset: 0x00274DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x00276BF8 File Offset: 0x00274DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaUpdatePlayerInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ArenaUpdatePlayerInformationEvent._repeated_arenaRanks_codec = FieldCodec.ForMessage<ArenaUpdatePlayerInformationEvent.Types.ArenaRank>(10U, Ea47gHe1rv6JFM7SY4Oa.XVInXhlssT(Ea47gHe1rv6JFM7SY4Oa.e2xe1VrB7Yd));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ArenaUpdatePlayerInformationEvent._parser = new MessageParser<ArenaUpdatePlayerInformationEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x00276D14 File Offset: 0x00274F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HlOOUbJXork1b1K8UHmX()
		{
			return true;
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x00276D1C File Offset: 0x00274F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaUpdatePlayerInformationEvent GScat5JX1CgsQOHpv8bY()
		{
			return null;
		}

		// Token: 0x04003766 RID: 14182
		private static readonly MessageParser<ArenaUpdatePlayerInformationEvent> _parser;

		// Token: 0x04003767 RID: 14183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003768 RID: 14184
		public const int ArenaRanksFieldNumber = 1;

		// Token: 0x04003769 RID: 14185
		private static readonly FieldCodec<ArenaUpdatePlayerInformationEvent.Types.ArenaRank> _repeated_arenaRanks_codec;

		// Token: 0x0400376A RID: 14186
		private readonly RepeatedField<ArenaUpdatePlayerInformationEvent.Types.ArenaRank> arenaRanks_;

		// Token: 0x0400376B RID: 14187
		public const int BanEndDateFieldNumber = 2;

		// Token: 0x0400376C RID: 14188
		private string banEndDate_;

		// Token: 0x0400376D RID: 14189
		internal static ArenaUpdatePlayerInformationEvent MXPNKIJXvxytU4tTomPY;

		// Token: 0x02000C1B RID: 3099
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060094E9 RID: 38121 RVA: 0x002E7D08 File Offset: 0x002E5F08
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000C1C RID: 3100
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ArenaRank : IMessage<ArenaUpdatePlayerInformationEvent.Types.ArenaRank>, IMessage, IEquatable<ArenaUpdatePlayerInformationEvent.Types.ArenaRank>, IDeepCloneable<ArenaUpdatePlayerInformationEvent.Types.ArenaRank>, IBufferMessage
			{
				// Token: 0x17001BD1 RID: 7121
				// (get) Token: 0x060094EA RID: 38122 RVA: 0x0030D550 File Offset: 0x0030B750
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<ArenaUpdatePlayerInformationEvent.Types.ArenaRank> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001BD2 RID: 7122
				// (get) Token: 0x060094EB RID: 38123 RVA: 0x0030D560 File Offset: 0x0030B760
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

				// Token: 0x17001BD3 RID: 7123
				// (get) Token: 0x060094EC RID: 38124 RVA: 0x0030D570 File Offset: 0x0030B770
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

				// Token: 0x060094ED RID: 38125 RVA: 0x0030D580 File Offset: 0x0030B780
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ArenaRank()
				{
				}

				// Token: 0x060094EE RID: 38126 RVA: 0x0030D590 File Offset: 0x0030B790
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ArenaRank(ArenaUpdatePlayerInformationEvent.Types.ArenaRank other)
				{
				}

				// Token: 0x060094EF RID: 38127 RVA: 0x0030D5A0 File Offset: 0x0030B7A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ArenaUpdatePlayerInformationEvent.Types.ArenaRank Clone()
				{
					return null;
				}

				// Token: 0x17001BD4 RID: 7124
				// (get) Token: 0x060094F0 RID: 38128 RVA: 0x0030D5B0 File Offset: 0x0030B7B0
				// (set) Token: 0x060094F1 RID: 38129 RVA: 0x0030D5C4 File Offset: 0x0030B7C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public ArenaType ArenaType
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (ArenaType)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17001BD5 RID: 7125
				// (get) Token: 0x060094F2 RID: 38130 RVA: 0x0030D5D4 File Offset: 0x0030B7D4
				// (set) Token: 0x060094F3 RID: 38131 RVA: 0x0030D5E4 File Offset: 0x0030B7E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking LeagueRanking
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

				// Token: 0x17001BD6 RID: 7126
				// (get) Token: 0x060094F4 RID: 38132 RVA: 0x0030D5F4 File Offset: 0x0030B7F4
				// (set) Token: 0x060094F5 RID: 38133 RVA: 0x0030D604 File Offset: 0x0030B804
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int BestLeagueId
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

				// Token: 0x17001BD7 RID: 7127
				// (get) Token: 0x060094F6 RID: 38134 RVA: 0x0030D614 File Offset: 0x0030B814
				// (set) Token: 0x060094F7 RID: 38135 RVA: 0x0030D624 File Offset: 0x0030B824
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int BestRating
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

				// Token: 0x17001BD8 RID: 7128
				// (get) Token: 0x060094F8 RID: 38136 RVA: 0x0030D634 File Offset: 0x0030B834
				// (set) Token: 0x060094F9 RID: 38137 RVA: 0x0030D644 File Offset: 0x0030B844
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int DailyVictoryCount
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

				// Token: 0x17001BD9 RID: 7129
				// (get) Token: 0x060094FA RID: 38138 RVA: 0x0030D654 File Offset: 0x0030B854
				// (set) Token: 0x060094FB RID: 38139 RVA: 0x0030D664 File Offset: 0x0030B864
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int SeasonVictoryCount
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

				// Token: 0x17001BDA RID: 7130
				// (get) Token: 0x060094FC RID: 38140 RVA: 0x0030D674 File Offset: 0x0030B874
				// (set) Token: 0x060094FD RID: 38141 RVA: 0x0030D684 File Offset: 0x0030B884
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int DailyFightCount
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

				// Token: 0x17001BDB RID: 7131
				// (get) Token: 0x060094FE RID: 38142 RVA: 0x0030D694 File Offset: 0x0030B894
				// (set) Token: 0x060094FF RID: 38143 RVA: 0x0030D6A4 File Offset: 0x0030B8A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int SeasonFightCount
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

				// Token: 0x17001BDC RID: 7132
				// (get) Token: 0x06009500 RID: 38144 RVA: 0x0030D6B4 File Offset: 0x0030B8B4
				// (set) Token: 0x06009501 RID: 38145 RVA: 0x0030D6C4 File Offset: 0x0030B8C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int FightNeededForLadder
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

				// Token: 0x06009502 RID: 38146 RVA: 0x0030D6D4 File Offset: 0x0030B8D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06009503 RID: 38147 RVA: 0x0030D6E4 File Offset: 0x0030B8E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(ArenaUpdatePlayerInformationEvent.Types.ArenaRank other)
				{
					return true;
				}

				// Token: 0x06009504 RID: 38148 RVA: 0x0030D6F4 File Offset: 0x0030B8F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06009505 RID: 38149 RVA: 0x0030D704 File Offset: 0x0030B904
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06009506 RID: 38150 RVA: 0x0030D714 File Offset: 0x0030B914
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06009507 RID: 38151 RVA: 0x0030D724 File Offset: 0x0030B924
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06009508 RID: 38152 RVA: 0x0030D734 File Offset: 0x0030B934
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06009509 RID: 38153 RVA: 0x0030D744 File Offset: 0x0030B944
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(ArenaUpdatePlayerInformationEvent.Types.ArenaRank other)
				{
				}

				// Token: 0x0600950A RID: 38154 RVA: 0x0030D754 File Offset: 0x0030B954
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600950B RID: 38155 RVA: 0x0030D764 File Offset: 0x0030B964
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600950C RID: 38156 RVA: 0x0030D774 File Offset: 0x0030B974
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ArenaRank()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							ArenaUpdatePlayerInformationEvent.Types.ArenaRank._parser = new MessageParser<ArenaUpdatePlayerInformationEvent.Types.ArenaRank>(() => null);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x0600950D RID: 38157 RVA: 0x0030D858 File Offset: 0x0030BA58
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool e1wWrdGZW0xScGJv0tXh()
				{
					return true;
				}

				// Token: 0x0600950E RID: 38158 RVA: 0x0030D860 File Offset: 0x0030BA60
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ArenaUpdatePlayerInformationEvent.Types.ArenaRank Kd7gcRGZhDyywJXwVJH7()
				{
					return null;
				}

				// Token: 0x0400376E RID: 14190
				private static readonly MessageParser<ArenaUpdatePlayerInformationEvent.Types.ArenaRank> _parser;

				// Token: 0x0400376F RID: 14191
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003770 RID: 14192
				public const int ArenaTypeFieldNumber = 1;

				// Token: 0x04003771 RID: 14193
				private ArenaType arenaType_;

				// Token: 0x04003772 RID: 14194
				public const int LeagueRankingFieldNumber = 2;

				// Token: 0x04003773 RID: 14195
				private ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking leagueRanking_;

				// Token: 0x04003774 RID: 14196
				public const int BestLeagueIdFieldNumber = 3;

				// Token: 0x04003775 RID: 14197
				private int bestLeagueId_;

				// Token: 0x04003776 RID: 14198
				public const int BestRatingFieldNumber = 4;

				// Token: 0x04003777 RID: 14199
				private int bestRating_;

				// Token: 0x04003778 RID: 14200
				public const int DailyVictoryCountFieldNumber = 5;

				// Token: 0x04003779 RID: 14201
				private int dailyVictoryCount_;

				// Token: 0x0400377A RID: 14202
				public const int SeasonVictoryCountFieldNumber = 6;

				// Token: 0x0400377B RID: 14203
				private int seasonVictoryCount_;

				// Token: 0x0400377C RID: 14204
				public const int DailyFightCountFieldNumber = 7;

				// Token: 0x0400377D RID: 14205
				private int dailyFightCount_;

				// Token: 0x0400377E RID: 14206
				public const int SeasonFightCountFieldNumber = 8;

				// Token: 0x0400377F RID: 14207
				private int seasonFightCount_;

				// Token: 0x04003780 RID: 14208
				public const int FightNeededForLadderFieldNumber = 9;

				// Token: 0x04003781 RID: 14209
				private int fightNeededForLadder_;

				// Token: 0x04003782 RID: 14210
				private static ArenaUpdatePlayerInformationEvent.Types.ArenaRank RVm6WRGZLSUTlphb58Ag;

				// Token: 0x02000C1D RID: 3101
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600950F RID: 38159 RVA: 0x00319D44 File Offset: 0x00317F44
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000C1E RID: 3102
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class LeagueRanking : IMessage<ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking>, IMessage, IEquatable<ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking>, IDeepCloneable<ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking>, IBufferMessage
					{
						// Token: 0x17001BDD RID: 7133
						// (get) Token: 0x06009510 RID: 38160 RVA: 0x0031EBD0 File Offset: 0x0031CDD0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17001BDE RID: 7134
						// (get) Token: 0x06009511 RID: 38161 RVA: 0x0031EBE0 File Offset: 0x0031CDE0
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

						// Token: 0x17001BDF RID: 7135
						// (get) Token: 0x06009512 RID: 38162 RVA: 0x0031EBF0 File Offset: 0x0031CDF0
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

						// Token: 0x06009513 RID: 38163 RVA: 0x0031EC00 File Offset: 0x0031CE00
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public LeagueRanking()
						{
						}

						// Token: 0x06009514 RID: 38164 RVA: 0x0031EC10 File Offset: 0x0031CE10
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public LeagueRanking(ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking other)
						{
						}

						// Token: 0x06009515 RID: 38165 RVA: 0x0031EC20 File Offset: 0x0031CE20
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking Clone()
						{
							return null;
						}

						// Token: 0x17001BE0 RID: 7136
						// (get) Token: 0x06009516 RID: 38166 RVA: 0x0031EC30 File Offset: 0x0031CE30
						// (set) Token: 0x06009517 RID: 38167 RVA: 0x0031EC40 File Offset: 0x0031CE40
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int Rating
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

						// Token: 0x17001BE1 RID: 7137
						// (get) Token: 0x06009518 RID: 38168 RVA: 0x0031EC50 File Offset: 0x0031CE50
						// (set) Token: 0x06009519 RID: 38169 RVA: 0x0031EC60 File Offset: 0x0031CE60
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
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

						// Token: 0x17001BE2 RID: 7138
						// (get) Token: 0x0600951A RID: 38170 RVA: 0x0031EC70 File Offset: 0x0031CE70
						// (set) Token: 0x0600951B RID: 38171 RVA: 0x0031EC80 File Offset: 0x0031CE80
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
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

						// Token: 0x0600951C RID: 38172 RVA: 0x0031EC90 File Offset: 0x0031CE90
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600951D RID: 38173 RVA: 0x0031ECA0 File Offset: 0x0031CEA0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking other)
						{
							return true;
						}

						// Token: 0x0600951E RID: 38174 RVA: 0x0031ECB0 File Offset: 0x0031CEB0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x0600951F RID: 38175 RVA: 0x0031ECC0 File Offset: 0x0031CEC0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06009520 RID: 38176 RVA: 0x0031ECD0 File Offset: 0x0031CED0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06009521 RID: 38177 RVA: 0x0031ECE0 File Offset: 0x0031CEE0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06009522 RID: 38178 RVA: 0x0031ECF0 File Offset: 0x0031CEF0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06009523 RID: 38179 RVA: 0x0031ED00 File Offset: 0x0031CF00
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking other)
						{
						}

						// Token: 0x06009524 RID: 38180 RVA: 0x0031ED10 File Offset: 0x0031CF10
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06009525 RID: 38181 RVA: 0x0031ED20 File Offset: 0x0031CF20
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06009526 RID: 38182 RVA: 0x0031ED30 File Offset: 0x0031CF30
						[MethodImpl(MethodImplOptions.NoInlining)]
						static LeagueRanking()
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
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 3:
									return;
								case 4:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								}
								ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking._parser = new MessageParser<ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking>(() => null);
								num2 = 3;
							}
						}

						// Token: 0x06009527 RID: 38183 RVA: 0x0031EDFC File Offset: 0x0031CFFC
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool M9OqFLgG9I6NUXS81fgG()
						{
							return true;
						}

						// Token: 0x06009528 RID: 38184 RVA: 0x0031EE04 File Offset: 0x0031D004
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking rn9nWZgG2jsChkgjm2UU()
						{
							return null;
						}

						// Token: 0x04003783 RID: 14211
						private static readonly MessageParser<ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking> _parser;

						// Token: 0x04003784 RID: 14212
						private UnknownFieldSet _unknownFields;

						// Token: 0x04003785 RID: 14213
						public const int RatingFieldNumber = 1;

						// Token: 0x04003786 RID: 14214
						private int rating_;

						// Token: 0x04003787 RID: 14215
						public const int LeagueIdFieldNumber = 2;

						// Token: 0x04003788 RID: 14216
						private int leagueId_;

						// Token: 0x04003789 RID: 14217
						public const int LadderPositionFieldNumber = 3;

						// Token: 0x0400378A RID: 14218
						private int ladderPosition_;

						// Token: 0x0400378B RID: 14219
						private static ArenaUpdatePlayerInformationEvent.Types.ArenaRank.Types.LeagueRanking v5HjahgGdes3gAh1JdBT;
					}
				}
			}
		}
	}
}
