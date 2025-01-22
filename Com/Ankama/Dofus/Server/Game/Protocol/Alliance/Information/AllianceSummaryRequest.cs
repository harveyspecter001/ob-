using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D63 RID: 3427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceSummaryRequest : IMessage<AllianceSummaryRequest>, IMessage, IEquatable<AllianceSummaryRequest>, IDeepCloneable<AllianceSummaryRequest>, IBufferMessage
	{
		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x0600A525 RID: 42277 RVA: 0x00290290 File Offset: 0x0028E490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceSummaryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600A526 RID: 42278 RVA: 0x002902A0 File Offset: 0x0028E4A0
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

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600A527 RID: 42279 RVA: 0x002902B0 File Offset: 0x0028E4B0
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

		// Token: 0x0600A528 RID: 42280 RVA: 0x002902C0 File Offset: 0x0028E4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceSummaryRequest()
		{
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x002902D0 File Offset: 0x0028E4D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceSummaryRequest(AllianceSummaryRequest other)
		{
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x002902E0 File Offset: 0x0028E4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceSummaryRequest Clone()
		{
			return null;
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x0600A52B RID: 42283 RVA: 0x002902F0 File Offset: 0x0028E4F0
		// (set) Token: 0x0600A52C RID: 42284 RVA: 0x00290300 File Offset: 0x0028E500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Offset
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

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600A52D RID: 42285 RVA: 0x00290310 File Offset: 0x0028E510
		// (set) Token: 0x0600A52E RID: 42286 RVA: 0x00290320 File Offset: 0x0028E520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Count
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

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x0600A52F RID: 42287 RVA: 0x00290330 File Offset: 0x0028E530
		// (set) Token: 0x0600A530 RID: 42288 RVA: 0x00290344 File Offset: 0x0028E544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceSummaryRequest.Types.DirectoryTextFilter FilterType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AllianceSummaryRequest.Types.DirectoryTextFilter)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x0600A531 RID: 42289 RVA: 0x00290354 File Offset: 0x0028E554
		// (set) Token: 0x0600A532 RID: 42290 RVA: 0x00290364 File Offset: 0x0028E564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TextFiler
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

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x0600A533 RID: 42291 RVA: 0x00290374 File Offset: 0x0028E574
		// (set) Token: 0x0600A534 RID: 42292 RVA: 0x00290384 File Offset: 0x0028E584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HideFullFilter
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

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x0600A535 RID: 42293 RVA: 0x00290394 File Offset: 0x0028E594
		// (set) Token: 0x0600A536 RID: 42294 RVA: 0x002903A4 File Offset: 0x0028E5A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool FollowingAllianceCriteria
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

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600A537 RID: 42295 RVA: 0x002903B4 File Offset: 0x0028E5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CriterionFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600A538 RID: 42296 RVA: 0x002903C4 File Offset: 0x0028E5C4
		// (set) Token: 0x0600A539 RID: 42297 RVA: 0x002903D8 File Offset: 0x0028E5D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceSummaryRequest.Types.AllianceSummarySort SortType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (AllianceSummaryRequest.Types.AllianceSummarySort)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600A53A RID: 42298 RVA: 0x002903E8 File Offset: 0x0028E5E8
		// (set) Token: 0x0600A53B RID: 42299 RVA: 0x002903F8 File Offset: 0x0028E5F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool SortDescending
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

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x0600A53C RID: 42300 RVA: 0x00290408 File Offset: 0x0028E608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LanguagesFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600A53D RID: 42301 RVA: 0x00290418 File Offset: 0x0028E618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SocialRecruitmentType> RecruitmentTypeFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600A53E RID: 42302 RVA: 0x00290428 File Offset: 0x0028E628
		// (set) Token: 0x0600A53F RID: 42303 RVA: 0x00290438 File Offset: 0x0028E638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinPlayerLevelFilter
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

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x0600A540 RID: 42304 RVA: 0x00290448 File Offset: 0x0028E648
		// (set) Token: 0x0600A541 RID: 42305 RVA: 0x00290458 File Offset: 0x0028E658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxPlayerLevelFilter
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

		// Token: 0x0600A542 RID: 42306 RVA: 0x00290468 File Offset: 0x0028E668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x00290478 File Offset: 0x0028E678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceSummaryRequest other)
		{
			return true;
		}

		// Token: 0x0600A544 RID: 42308 RVA: 0x00290488 File Offset: 0x0028E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A545 RID: 42309 RVA: 0x00290498 File Offset: 0x0028E698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x002904A8 File Offset: 0x0028E6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x002904B8 File Offset: 0x0028E6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x002904C8 File Offset: 0x0028E6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x002904D8 File Offset: 0x0028E6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceSummaryRequest other)
		{
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x002904E8 File Offset: 0x0028E6E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x002904F8 File Offset: 0x0028E6F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x00290508 File Offset: 0x0028E708
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceSummaryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AllianceSummaryRequest._repeated_languagesFilter_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(82U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 4;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 6;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					AllianceSummaryRequest._repeated_recruitmentTypeFilter_codec = FieldCodec.ForEnum<SocialRecruitmentType>(90U, (SocialRecruitmentType x) => 0, (int x) => (SocialRecruitmentType)null);
					num2 = 5;
					break;
				case 5:
					return;
				case 6:
					AllianceSummaryRequest._parser = new MessageParser<AllianceSummaryRequest>(() => null);
					num2 = 7;
					break;
				case 7:
					AllianceSummaryRequest._repeated_criterionFilter_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(58U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x0029064C File Offset: 0x0028E84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MHZ2ZWJkNjhwwSnB4JNN()
		{
			return true;
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x00290654 File Offset: 0x0028E854
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceSummaryRequest wG5j4FJkx9Q2odyU9xaK()
		{
			return null;
		}

		// Token: 0x04003CC3 RID: 15555
		private static readonly MessageParser<AllianceSummaryRequest> _parser;

		// Token: 0x04003CC4 RID: 15556
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CC5 RID: 15557
		public const int OffsetFieldNumber = 1;

		// Token: 0x04003CC6 RID: 15558
		private long offset_;

		// Token: 0x04003CC7 RID: 15559
		public const int CountFieldNumber = 2;

		// Token: 0x04003CC8 RID: 15560
		private long count_;

		// Token: 0x04003CC9 RID: 15561
		public const int FilterTypeFieldNumber = 3;

		// Token: 0x04003CCA RID: 15562
		private AllianceSummaryRequest.Types.DirectoryTextFilter filterType_;

		// Token: 0x04003CCB RID: 15563
		public const int TextFilerFieldNumber = 4;

		// Token: 0x04003CCC RID: 15564
		private string textFiler_;

		// Token: 0x04003CCD RID: 15565
		public const int HideFullFilterFieldNumber = 5;

		// Token: 0x04003CCE RID: 15566
		private bool hideFullFilter_;

		// Token: 0x04003CCF RID: 15567
		public const int FollowingAllianceCriteriaFieldNumber = 6;

		// Token: 0x04003CD0 RID: 15568
		private bool followingAllianceCriteria_;

		// Token: 0x04003CD1 RID: 15569
		public const int CriterionFilterFieldNumber = 7;

		// Token: 0x04003CD2 RID: 15570
		private static readonly FieldCodec<int> _repeated_criterionFilter_codec;

		// Token: 0x04003CD3 RID: 15571
		private readonly RepeatedField<int> criterionFilter_;

		// Token: 0x04003CD4 RID: 15572
		public const int SortTypeFieldNumber = 8;

		// Token: 0x04003CD5 RID: 15573
		private AllianceSummaryRequest.Types.AllianceSummarySort sortType_;

		// Token: 0x04003CD6 RID: 15574
		public const int SortDescendingFieldNumber = 9;

		// Token: 0x04003CD7 RID: 15575
		private bool sortDescending_;

		// Token: 0x04003CD8 RID: 15576
		public const int LanguagesFilterFieldNumber = 10;

		// Token: 0x04003CD9 RID: 15577
		private static readonly FieldCodec<int> _repeated_languagesFilter_codec;

		// Token: 0x04003CDA RID: 15578
		private readonly RepeatedField<int> languagesFilter_;

		// Token: 0x04003CDB RID: 15579
		public const int RecruitmentTypeFilterFieldNumber = 11;

		// Token: 0x04003CDC RID: 15580
		private static readonly FieldCodec<SocialRecruitmentType> _repeated_recruitmentTypeFilter_codec;

		// Token: 0x04003CDD RID: 15581
		private readonly RepeatedField<SocialRecruitmentType> recruitmentTypeFilter_;

		// Token: 0x04003CDE RID: 15582
		public const int MinPlayerLevelFilterFieldNumber = 12;

		// Token: 0x04003CDF RID: 15583
		private int minPlayerLevelFilter_;

		// Token: 0x04003CE0 RID: 15584
		public const int MaxPlayerLevelFilterFieldNumber = 13;

		// Token: 0x04003CE1 RID: 15585
		private int maxPlayerLevelFilter_;

		// Token: 0x04003CE2 RID: 15586
		internal static AllianceSummaryRequest WP7GGHJkXVlUIbS1xqkl;

		// Token: 0x02000D64 RID: 3428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600A54F RID: 42319 RVA: 0x002EFB60 File Offset: 0x002EDD60
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000D65 RID: 3429
			public enum DirectoryTextFilter
			{
				// Token: 0x04003CE4 RID: 15588
				[OriginalName("ALLIANCE_SEARCH_DEFAULT_FILTER")]
				AllianceSearchDefaultFilter,
				// Token: 0x04003CE5 RID: 15589
				[OriginalName("ALLIANCE_SEARCH_NAME_FILTER")]
				AllianceSearchNameFilter,
				// Token: 0x04003CE6 RID: 15590
				[OriginalName("ALLIANCE_SEARCH_TAG_FILTER")]
				AllianceSearchTagFilter
			}

			// Token: 0x02000D66 RID: 3430
			public enum AllianceSummarySort
			{
				// Token: 0x04003CE8 RID: 15592
				[OriginalName("SORT_BY_ALLIANCE_NAME")]
				SortByAllianceName,
				// Token: 0x04003CE9 RID: 15593
				[OriginalName("SORT_BY_ALLIANCE_TAG")]
				SortByAllianceTag,
				// Token: 0x04003CEA RID: 15594
				[OriginalName("SORT_BY_NB_TERRITORIES")]
				SortByNbTerritories,
				// Token: 0x04003CEB RID: 15595
				[OriginalName("SORT_BY_ALLIANCE_NB_MEMBERS")]
				SortByAllianceNbMembers
			}
		}
	}
}
