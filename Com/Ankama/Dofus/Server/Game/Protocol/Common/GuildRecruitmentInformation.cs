using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B02 RID: 2818
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRecruitmentInformation : IMessage<GuildRecruitmentInformation>, IMessage, IEquatable<GuildRecruitmentInformation>, IDeepCloneable<GuildRecruitmentInformation>, IBufferMessage
	{
		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x060086C0 RID: 34496 RVA: 0x0026570C File Offset: 0x0026390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildRecruitmentInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x060086C1 RID: 34497 RVA: 0x0026571C File Offset: 0x0026391C
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

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x060086C2 RID: 34498 RVA: 0x0026572C File Offset: 0x0026392C
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

		// Token: 0x060086C3 RID: 34499 RVA: 0x0026573C File Offset: 0x0026393C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentInformation()
		{
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x0026574C File Offset: 0x0026394C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentInformation(GuildRecruitmentInformation other)
		{
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x0026575C File Offset: 0x0026395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentInformation Clone()
		{
			return null;
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x060086C6 RID: 34502 RVA: 0x0026576C File Offset: 0x0026396C
		// (set) Token: 0x060086C7 RID: 34503 RVA: 0x0026577C File Offset: 0x0026397C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SocialId
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

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x060086C8 RID: 34504 RVA: 0x0026578C File Offset: 0x0026398C
		// (set) Token: 0x060086C9 RID: 34505 RVA: 0x002657A0 File Offset: 0x002639A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialRecruitmentType RecruitmentType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialRecruitmentType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x060086CA RID: 34506 RVA: 0x002657B0 File Offset: 0x002639B0
		// (set) Token: 0x060086CB RID: 34507 RVA: 0x002657C0 File Offset: 0x002639C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Title
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

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x060086CC RID: 34508 RVA: 0x002657D0 File Offset: 0x002639D0
		// (set) Token: 0x060086CD RID: 34509 RVA: 0x002657E0 File Offset: 0x002639E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Text
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

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060086CE RID: 34510 RVA: 0x002657F0 File Offset: 0x002639F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> SelectedLanguages
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060086CF RID: 34511 RVA: 0x00265800 File Offset: 0x00263A00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> SelectedCriterion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x060086D0 RID: 34512 RVA: 0x00265810 File Offset: 0x00263A10
		// (set) Token: 0x060086D1 RID: 34513 RVA: 0x00265820 File Offset: 0x00263A20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MinLevel
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

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x060086D2 RID: 34514 RVA: 0x00265830 File Offset: 0x00263A30
		// (set) Token: 0x060086D3 RID: 34515 RVA: 0x00265840 File Offset: 0x00263A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MinLevelFacultative
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

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060086D4 RID: 34516 RVA: 0x00265850 File Offset: 0x00263A50
		// (set) Token: 0x060086D5 RID: 34517 RVA: 0x00265860 File Offset: 0x00263A60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool InvalidatedByModeration
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

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x060086D6 RID: 34518 RVA: 0x00265870 File Offset: 0x00263A70
		// (set) Token: 0x060086D7 RID: 34519 RVA: 0x00265880 File Offset: 0x00263A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string LastEditPlayerName
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

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x060086D8 RID: 34520 RVA: 0x00265890 File Offset: 0x00263A90
		// (set) Token: 0x060086D9 RID: 34521 RVA: 0x002658A0 File Offset: 0x00263AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastEditDate
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

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x060086DA RID: 34522 RVA: 0x002658B0 File Offset: 0x00263AB0
		// (set) Token: 0x060086DB RID: 34523 RVA: 0x002658C0 File Offset: 0x00263AC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool AutoLocked
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

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x060086DC RID: 34524 RVA: 0x002658D0 File Offset: 0x00263AD0
		// (set) Token: 0x060086DD RID: 34525 RVA: 0x002658E0 File Offset: 0x00263AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinSuccess
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

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x060086DE RID: 34526 RVA: 0x002658F0 File Offset: 0x00263AF0
		// (set) Token: 0x060086DF RID: 34527 RVA: 0x00265900 File Offset: 0x00263B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MinSuccessFacultative
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

		// Token: 0x060086E0 RID: 34528 RVA: 0x00265910 File Offset: 0x00263B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x00265920 File Offset: 0x00263B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRecruitmentInformation other)
		{
			return true;
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x00265930 File Offset: 0x00263B30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060086E3 RID: 34531 RVA: 0x00265940 File Offset: 0x00263B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060086E4 RID: 34532 RVA: 0x00265950 File Offset: 0x00263B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x00265960 File Offset: 0x00263B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x00265970 File Offset: 0x00263B70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x00265980 File Offset: 0x00263B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRecruitmentInformation other)
		{
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x00265990 File Offset: 0x00263B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x002659A0 File Offset: 0x00263BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x002659B0 File Offset: 0x00263BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRecruitmentInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildRecruitmentInformation._parser = new MessageParser<GuildRecruitmentInformation>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					GuildRecruitmentInformation._repeated_selectedCriterion_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(50U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				GuildRecruitmentInformation._repeated_selectedLanguages_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(42U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 6;
			}
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x00265AFC File Offset: 0x00263CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AQaKTfJsFKGoO0M4p52V()
		{
			return true;
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x00265B04 File Offset: 0x00263D04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRecruitmentInformation CuG9JUJszHKauKrsjUSE()
		{
			return null;
		}

		// Token: 0x04003161 RID: 12641
		private static readonly MessageParser<GuildRecruitmentInformation> _parser;

		// Token: 0x04003162 RID: 12642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003163 RID: 12643
		public const int SocialIdFieldNumber = 1;

		// Token: 0x04003164 RID: 12644
		private int socialId_;

		// Token: 0x04003165 RID: 12645
		public const int RecruitmentTypeFieldNumber = 2;

		// Token: 0x04003166 RID: 12646
		private SocialRecruitmentType recruitmentType_;

		// Token: 0x04003167 RID: 12647
		public const int TitleFieldNumber = 3;

		// Token: 0x04003168 RID: 12648
		private string title_;

		// Token: 0x04003169 RID: 12649
		public const int TextFieldNumber = 4;

		// Token: 0x0400316A RID: 12650
		private string text_;

		// Token: 0x0400316B RID: 12651
		public const int SelectedLanguagesFieldNumber = 5;

		// Token: 0x0400316C RID: 12652
		private static readonly FieldCodec<int> _repeated_selectedLanguages_codec;

		// Token: 0x0400316D RID: 12653
		private readonly RepeatedField<int> selectedLanguages_;

		// Token: 0x0400316E RID: 12654
		public const int SelectedCriterionFieldNumber = 6;

		// Token: 0x0400316F RID: 12655
		private static readonly FieldCodec<int> _repeated_selectedCriterion_codec;

		// Token: 0x04003170 RID: 12656
		private readonly RepeatedField<int> selectedCriterion_;

		// Token: 0x04003171 RID: 12657
		public const int MinLevelFieldNumber = 7;

		// Token: 0x04003172 RID: 12658
		private int minLevel_;

		// Token: 0x04003173 RID: 12659
		public const int MinLevelFacultativeFieldNumber = 8;

		// Token: 0x04003174 RID: 12660
		private bool minLevelFacultative_;

		// Token: 0x04003175 RID: 12661
		public const int InvalidatedByModerationFieldNumber = 9;

		// Token: 0x04003176 RID: 12662
		private bool invalidatedByModeration_;

		// Token: 0x04003177 RID: 12663
		public const int LastEditPlayerNameFieldNumber = 10;

		// Token: 0x04003178 RID: 12664
		private string lastEditPlayerName_;

		// Token: 0x04003179 RID: 12665
		public const int LastEditDateFieldNumber = 11;

		// Token: 0x0400317A RID: 12666
		private long lastEditDate_;

		// Token: 0x0400317B RID: 12667
		public const int AutoLockedFieldNumber = 12;

		// Token: 0x0400317C RID: 12668
		private bool autoLocked_;

		// Token: 0x0400317D RID: 12669
		public const int MinSuccessFieldNumber = 13;

		// Token: 0x0400317E RID: 12670
		private int minSuccess_;

		// Token: 0x0400317F RID: 12671
		public const int MinSuccessFacultativeFieldNumber = 14;

		// Token: 0x04003180 RID: 12672
		private bool minSuccessFacultative_;

		// Token: 0x04003181 RID: 12673
		internal static GuildRecruitmentInformation i5WaDxJsqEiOrmsKmq9G;
	}
}
