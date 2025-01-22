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
	// Token: 0x02000B80 RID: 2944
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRecruitmentInformation : IMessage<AllianceRecruitmentInformation>, IMessage, IEquatable<AllianceRecruitmentInformation>, IDeepCloneable<AllianceRecruitmentInformation>, IBufferMessage
	{
		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06008D1B RID: 36123 RVA: 0x0026A4BC File Offset: 0x002686BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceRecruitmentInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06008D1C RID: 36124 RVA: 0x0026A4CC File Offset: 0x002686CC
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

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06008D1D RID: 36125 RVA: 0x0026A4DC File Offset: 0x002686DC
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

		// Token: 0x06008D1E RID: 36126 RVA: 0x0026A4EC File Offset: 0x002686EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformation()
		{
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x0026A4FC File Offset: 0x002686FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformation(AllianceRecruitmentInformation other)
		{
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x0026A50C File Offset: 0x0026870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformation Clone()
		{
			return null;
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06008D21 RID: 36129 RVA: 0x0026A51C File Offset: 0x0026871C
		// (set) Token: 0x06008D22 RID: 36130 RVA: 0x0026A52C File Offset: 0x0026872C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SocialUid
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

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06008D23 RID: 36131 RVA: 0x0026A53C File Offset: 0x0026873C
		// (set) Token: 0x06008D24 RID: 36132 RVA: 0x0026A550 File Offset: 0x00268750
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

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06008D25 RID: 36133 RVA: 0x0026A560 File Offset: 0x00268760
		// (set) Token: 0x06008D26 RID: 36134 RVA: 0x0026A570 File Offset: 0x00268770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x06008D27 RID: 36135 RVA: 0x0026A580 File Offset: 0x00268780
		// (set) Token: 0x06008D28 RID: 36136 RVA: 0x0026A590 File Offset: 0x00268790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06008D29 RID: 36137 RVA: 0x0026A5A0 File Offset: 0x002687A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedLanguages
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06008D2A RID: 36138 RVA: 0x0026A5B0 File Offset: 0x002687B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedCriterion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06008D2B RID: 36139 RVA: 0x0026A5C0 File Offset: 0x002687C0
		// (set) Token: 0x06008D2C RID: 36140 RVA: 0x0026A5D0 File Offset: 0x002687D0
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

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06008D2D RID: 36141 RVA: 0x0026A5E0 File Offset: 0x002687E0
		// (set) Token: 0x06008D2E RID: 36142 RVA: 0x0026A5F0 File Offset: 0x002687F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06008D2F RID: 36143 RVA: 0x0026A600 File Offset: 0x00268800
		// (set) Token: 0x06008D30 RID: 36144 RVA: 0x0026A610 File Offset: 0x00268810
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

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06008D31 RID: 36145 RVA: 0x0026A620 File Offset: 0x00268820
		// (set) Token: 0x06008D32 RID: 36146 RVA: 0x0026A630 File Offset: 0x00268830
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06008D33 RID: 36147 RVA: 0x0026A640 File Offset: 0x00268840
		// (set) Token: 0x06008D34 RID: 36148 RVA: 0x0026A650 File Offset: 0x00268850
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

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06008D35 RID: 36149 RVA: 0x0026A660 File Offset: 0x00268860
		// (set) Token: 0x06008D36 RID: 36150 RVA: 0x0026A670 File Offset: 0x00268870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06008D37 RID: 36151 RVA: 0x0026A680 File Offset: 0x00268880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008D38 RID: 36152 RVA: 0x0026A690 File Offset: 0x00268890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRecruitmentInformation other)
		{
			return true;
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x0026A6A0 File Offset: 0x002688A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x0026A6B0 File Offset: 0x002688B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x0026A6C0 File Offset: 0x002688C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x0026A6D0 File Offset: 0x002688D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x0026A6E0 File Offset: 0x002688E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008D3E RID: 36158 RVA: 0x0026A6F0 File Offset: 0x002688F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRecruitmentInformation other)
		{
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x0026A700 File Offset: 0x00268900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x0026A710 File Offset: 0x00268910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x0026A720 File Offset: 0x00268920
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRecruitmentInformation()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AllianceRecruitmentInformation._repeated_selectedCriterion_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(50U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					AllianceRecruitmentInformation._repeated_selectedLanguages_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(42U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					continue;
				}
				AllianceRecruitmentInformation._parser = new MessageParser<AllianceRecruitmentInformation>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x0026A840 File Offset: 0x00268A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EKi50pJ9c1SeagjNlPpA()
		{
			return true;
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x0026A848 File Offset: 0x00268A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRecruitmentInformation T3plruJ9UOTft2RqDRxo()
		{
			return null;
		}

		// Token: 0x04003439 RID: 13369
		private static readonly MessageParser<AllianceRecruitmentInformation> _parser;

		// Token: 0x0400343A RID: 13370
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400343B RID: 13371
		public const int SocialUidFieldNumber = 1;

		// Token: 0x0400343C RID: 13372
		private string socialUid_;

		// Token: 0x0400343D RID: 13373
		public const int RecruitmentTypeFieldNumber = 2;

		// Token: 0x0400343E RID: 13374
		private SocialRecruitmentType recruitmentType_;

		// Token: 0x0400343F RID: 13375
		public const int TitleFieldNumber = 3;

		// Token: 0x04003440 RID: 13376
		private string title_;

		// Token: 0x04003441 RID: 13377
		public const int TextFieldNumber = 4;

		// Token: 0x04003442 RID: 13378
		private string text_;

		// Token: 0x04003443 RID: 13379
		public const int SelectedLanguagesFieldNumber = 5;

		// Token: 0x04003444 RID: 13380
		private static readonly FieldCodec<int> _repeated_selectedLanguages_codec;

		// Token: 0x04003445 RID: 13381
		private readonly RepeatedField<int> selectedLanguages_;

		// Token: 0x04003446 RID: 13382
		public const int SelectedCriterionFieldNumber = 6;

		// Token: 0x04003447 RID: 13383
		private static readonly FieldCodec<int> _repeated_selectedCriterion_codec;

		// Token: 0x04003448 RID: 13384
		private readonly RepeatedField<int> selectedCriterion_;

		// Token: 0x04003449 RID: 13385
		public const int MinLevelFieldNumber = 7;

		// Token: 0x0400344A RID: 13386
		private int minLevel_;

		// Token: 0x0400344B RID: 13387
		public const int MinLevelFacultativeFieldNumber = 8;

		// Token: 0x0400344C RID: 13388
		private bool minLevelFacultative_;

		// Token: 0x0400344D RID: 13389
		public const int InvalidatedByModerationFieldNumber = 9;

		// Token: 0x0400344E RID: 13390
		private bool invalidatedByModeration_;

		// Token: 0x0400344F RID: 13391
		public const int LastEditPlayerNameFieldNumber = 10;

		// Token: 0x04003450 RID: 13392
		private string lastEditPlayerName_;

		// Token: 0x04003451 RID: 13393
		public const int LastEditDateFieldNumber = 11;

		// Token: 0x04003452 RID: 13394
		private long lastEditDate_;

		// Token: 0x04003453 RID: 13395
		public const int AutoLockedFieldNumber = 12;

		// Token: 0x04003454 RID: 13396
		private bool autoLocked_;

		// Token: 0x04003455 RID: 13397
		private static AllianceRecruitmentInformation JkIw8PJ9l9P6PaWwJBRR;
	}
}
