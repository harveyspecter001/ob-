using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004E4 RID: 1252
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildSummaryRequest : IMessage<GuildSummaryRequest>, IMessage, IEquatable<GuildSummaryRequest>, IDeepCloneable<GuildSummaryRequest>, IBufferMessage
	{
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x001E7F84 File Offset: 0x001E6184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildSummaryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x001E7F94 File Offset: 0x001E6194
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x001E7FA4 File Offset: 0x001E61A4
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

		// Token: 0x06003BE0 RID: 15328 RVA: 0x001E7FB4 File Offset: 0x001E61B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildSummaryRequest()
		{
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x001E7FC4 File Offset: 0x001E61C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildSummaryRequest(GuildSummaryRequest other)
		{
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x001E7FD4 File Offset: 0x001E61D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildSummaryRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x001E7FE4 File Offset: 0x001E61E4
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x001E7FF4 File Offset: 0x001E61F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x001E8004 File Offset: 0x001E6204
		// (set) Token: 0x06003BE6 RID: 15334 RVA: 0x001E8014 File Offset: 0x001E6214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Count
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

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x001E8024 File Offset: 0x001E6224
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x001E8034 File Offset: 0x001E6234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string NameFilter
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

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x001E8044 File Offset: 0x001E6244
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x001E8054 File Offset: 0x001E6254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x001E8064 File Offset: 0x001E6264
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x001E8074 File Offset: 0x001E6274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool FollowingGuildCriteria
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

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x001E8084 File Offset: 0x001E6284
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

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x001E8094 File Offset: 0x001E6294
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> LanguagesFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x001E80A4 File Offset: 0x001E62A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SocialRecruitmentType> RecruitmentTypeFilters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x001E80B4 File Offset: 0x001E62B4
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x001E80C4 File Offset: 0x001E62C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MinLevelFilter
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

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x001E80D4 File Offset: 0x001E62D4
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x001E80E4 File Offset: 0x001E62E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLevelFilter
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

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x001E80F4 File Offset: 0x001E62F4
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x001E8104 File Offset: 0x001E6304
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x001E8114 File Offset: 0x001E6314
		// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x001E8124 File Offset: 0x001E6324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x001E8134 File Offset: 0x001E6334
		// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x001E8144 File Offset: 0x001E6344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinSuccessFilter
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

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06003BFA RID: 15354 RVA: 0x001E8154 File Offset: 0x001E6354
		// (set) Token: 0x06003BFB RID: 15355 RVA: 0x001E8164 File Offset: 0x001E6364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSuccessFilter
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

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x001E8174 File Offset: 0x001E6374
		// (set) Token: 0x06003BFD RID: 15357 RVA: 0x001E8188 File Offset: 0x001E6388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildSummaryRequest.Types.SummarySort SortType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (GuildSummaryRequest.Types.SummarySort)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06003BFE RID: 15358 RVA: 0x001E8198 File Offset: 0x001E6398
		// (set) Token: 0x06003BFF RID: 15359 RVA: 0x001E81A8 File Offset: 0x001E63A8
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

		// Token: 0x06003C00 RID: 15360 RVA: 0x001E81B8 File Offset: 0x001E63B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x001E81C8 File Offset: 0x001E63C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildSummaryRequest other)
		{
			return true;
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x001E81D8 File Offset: 0x001E63D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x001E81E8 File Offset: 0x001E63E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x001E81F8 File Offset: 0x001E63F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x001E8208 File Offset: 0x001E6408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x001E8218 File Offset: 0x001E6418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x001E8228 File Offset: 0x001E6428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildSummaryRequest other)
		{
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x001E8238 File Offset: 0x001E6438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x001E8248 File Offset: 0x001E6448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x001E8258 File Offset: 0x001E6458
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildSummaryRequest()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						goto IL_147;
					case 4:
						GuildSummaryRequest._repeated_criterionFilter_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(50U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						GuildSummaryRequest._repeated_recruitmentTypeFilters_codec = FieldCodec.ForEnum<SocialRecruitmentType>(66U, (SocialRecruitmentType x) => 0, (int x) => (SocialRecruitmentType)null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 6:
						GuildSummaryRequest._parser = new MessageParser<GuildSummaryRequest>(() => null);
						num2 = 4;
						continue;
					case 7:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 7;
				}
				IL_147:
				GuildSummaryRequest._repeated_languagesFilter_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(58U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num = 5;
			}
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x001E83CC File Offset: 0x001E65CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r4PLDOO7ogw6AhK1Z5rA()
		{
			return true;
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x001E83D4 File Offset: 0x001E65D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildSummaryRequest KaIisQO7172D4Fpw0Iqo()
		{
			return null;
		}

		// Token: 0x040014B8 RID: 5304
		private static readonly MessageParser<GuildSummaryRequest> _parser;

		// Token: 0x040014B9 RID: 5305
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014BA RID: 5306
		public const int OffsetFieldNumber = 1;

		// Token: 0x040014BB RID: 5307
		private long offset_;

		// Token: 0x040014BC RID: 5308
		public const int CountFieldNumber = 2;

		// Token: 0x040014BD RID: 5309
		private int count_;

		// Token: 0x040014BE RID: 5310
		public const int NameFilterFieldNumber = 3;

		// Token: 0x040014BF RID: 5311
		private string nameFilter_;

		// Token: 0x040014C0 RID: 5312
		public const int HideFullFilterFieldNumber = 4;

		// Token: 0x040014C1 RID: 5313
		private bool hideFullFilter_;

		// Token: 0x040014C2 RID: 5314
		public const int FollowingGuildCriteriaFieldNumber = 5;

		// Token: 0x040014C3 RID: 5315
		private bool followingGuildCriteria_;

		// Token: 0x040014C4 RID: 5316
		public const int CriterionFilterFieldNumber = 6;

		// Token: 0x040014C5 RID: 5317
		private static readonly FieldCodec<int> _repeated_criterionFilter_codec;

		// Token: 0x040014C6 RID: 5318
		private readonly RepeatedField<int> criterionFilter_;

		// Token: 0x040014C7 RID: 5319
		public const int LanguagesFilterFieldNumber = 7;

		// Token: 0x040014C8 RID: 5320
		private static readonly FieldCodec<int> _repeated_languagesFilter_codec;

		// Token: 0x040014C9 RID: 5321
		private readonly RepeatedField<int> languagesFilter_;

		// Token: 0x040014CA RID: 5322
		public const int RecruitmentTypeFiltersFieldNumber = 8;

		// Token: 0x040014CB RID: 5323
		private static readonly FieldCodec<SocialRecruitmentType> _repeated_recruitmentTypeFilters_codec;

		// Token: 0x040014CC RID: 5324
		private readonly RepeatedField<SocialRecruitmentType> recruitmentTypeFilters_;

		// Token: 0x040014CD RID: 5325
		public const int MinLevelFilterFieldNumber = 9;

		// Token: 0x040014CE RID: 5326
		private int minLevelFilter_;

		// Token: 0x040014CF RID: 5327
		public const int MaxLevelFilterFieldNumber = 10;

		// Token: 0x040014D0 RID: 5328
		private int maxLevelFilter_;

		// Token: 0x040014D1 RID: 5329
		public const int MinPlayerLevelFilterFieldNumber = 11;

		// Token: 0x040014D2 RID: 5330
		private int minPlayerLevelFilter_;

		// Token: 0x040014D3 RID: 5331
		public const int MaxPlayerLevelFilterFieldNumber = 12;

		// Token: 0x040014D4 RID: 5332
		private int maxPlayerLevelFilter_;

		// Token: 0x040014D5 RID: 5333
		public const int MinSuccessFilterFieldNumber = 13;

		// Token: 0x040014D6 RID: 5334
		private int minSuccessFilter_;

		// Token: 0x040014D7 RID: 5335
		public const int MaxSuccessFilterFieldNumber = 14;

		// Token: 0x040014D8 RID: 5336
		private int maxSuccessFilter_;

		// Token: 0x040014D9 RID: 5337
		public const int SortTypeFieldNumber = 15;

		// Token: 0x040014DA RID: 5338
		private GuildSummaryRequest.Types.SummarySort sortType_;

		// Token: 0x040014DB RID: 5339
		public const int SortDescendingFieldNumber = 16;

		// Token: 0x040014DC RID: 5340
		private bool sortDescending_;

		// Token: 0x040014DD RID: 5341
		private static GuildSummaryRequest WRoft6O7v6DNpogsdujT;

		// Token: 0x020004E5 RID: 1253
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06003C0D RID: 15373 RVA: 0x002C2B34 File Offset: 0x002C0D34
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020004E6 RID: 1254
			public enum SummarySort
			{
				// Token: 0x040014DF RID: 5343
				[OriginalName("SORT_BY_NAME")]
				SortByName,
				// Token: 0x040014E0 RID: 5344
				[OriginalName("SORT_BY_LEVEL")]
				SortByLevel,
				// Token: 0x040014E1 RID: 5345
				[OriginalName("SORT_BY_NB_MEMBERS")]
				SortByNbMembers,
				// Token: 0x040014E2 RID: 5346
				[OriginalName("SORT_BY_LAST_ACTIVITY")]
				SortByLastActivity
			}
		}
	}
}
