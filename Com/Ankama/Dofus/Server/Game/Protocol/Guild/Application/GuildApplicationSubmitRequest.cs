using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000552 RID: 1362
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationSubmitRequest : IMessage<GuildApplicationSubmitRequest>, IMessage, IEquatable<GuildApplicationSubmitRequest>, IDeepCloneable<GuildApplicationSubmitRequest>, IBufferMessage
	{
		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x001F09FC File Offset: 0x001EEBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildApplicationSubmitRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x001F0A0C File Offset: 0x001EEC0C
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

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x001F0A1C File Offset: 0x001EEC1C
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

		// Token: 0x06004165 RID: 16741 RVA: 0x001F0A2C File Offset: 0x001EEC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationSubmitRequest()
		{
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x001F0A3C File Offset: 0x001EEC3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationSubmitRequest(GuildApplicationSubmitRequest other)
		{
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x001F0A4C File Offset: 0x001EEC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationSubmitRequest Clone()
		{
			return null;
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x001F0A5C File Offset: 0x001EEC5C
		// (set) Token: 0x06004169 RID: 16745 RVA: 0x001F0A6C File Offset: 0x001EEC6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string ApplyText
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

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x001F0A7C File Offset: 0x001EEC7C
		// (set) Token: 0x0600416B RID: 16747 RVA: 0x001F0A8C File Offset: 0x001EEC8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int GuildId
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

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x001F0A9C File Offset: 0x001EEC9C
		// (set) Token: 0x0600416D RID: 16749 RVA: 0x001F0AAC File Offset: 0x001EECAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeSpent
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

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x001F0ABC File Offset: 0x001EECBC
		// (set) Token: 0x0600416F RID: 16751 RVA: 0x001F0ACC File Offset: 0x001EECCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string LanguageFilter
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x001F0ADC File Offset: 0x001EECDC
		// (set) Token: 0x06004171 RID: 16753 RVA: 0x001F0AEC File Offset: 0x001EECEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AmbianceFilter
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x001F0AFC File Offset: 0x001EECFC
		// (set) Token: 0x06004173 RID: 16755 RVA: 0x001F0B0C File Offset: 0x001EED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayTimeFilter
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

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06004174 RID: 16756 RVA: 0x001F0B1C File Offset: 0x001EED1C
		// (set) Token: 0x06004175 RID: 16757 RVA: 0x001F0B2C File Offset: 0x001EED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string InterestFilter
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06004176 RID: 16758 RVA: 0x001F0B3C File Offset: 0x001EED3C
		// (set) Token: 0x06004177 RID: 16759 RVA: 0x001F0B4C File Offset: 0x001EED4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string MinMaxGuildLevelFilter
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x001F0B5C File Offset: 0x001EED5C
		// (set) Token: 0x06004179 RID: 16761 RVA: 0x001F0B6C File Offset: 0x001EED6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RecruitmentTypeFilter
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600417A RID: 16762 RVA: 0x001F0B7C File Offset: 0x001EED7C
		// (set) Token: 0x0600417B RID: 16763 RVA: 0x001F0B8C File Offset: 0x001EED8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MinMaxCharacterLevelFilter
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x001F0B9C File Offset: 0x001EED9C
		// (set) Token: 0x0600417D RID: 16765 RVA: 0x001F0BAC File Offset: 0x001EEDAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string MinMaxAchievementFilter
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600417E RID: 16766 RVA: 0x001F0BBC File Offset: 0x001EEDBC
		// (set) Token: 0x0600417F RID: 16767 RVA: 0x001F0BCC File Offset: 0x001EEDCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string SearchNameFilter
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

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x001F0BDC File Offset: 0x001EEDDC
		// (set) Token: 0x06004181 RID: 16769 RVA: 0x001F0BEC File Offset: 0x001EEDEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string LastSortFilter
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

		// Token: 0x06004182 RID: 16770 RVA: 0x001F0BFC File Offset: 0x001EEDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x001F0C0C File Offset: 0x001EEE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationSubmitRequest other)
		{
			return true;
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x001F0C1C File Offset: 0x001EEE1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x001F0C2C File Offset: 0x001EEE2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x001F0C3C File Offset: 0x001EEE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x001F0C4C File Offset: 0x001EEE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x001F0C5C File Offset: 0x001EEE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x001F0C6C File Offset: 0x001EEE6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationSubmitRequest other)
		{
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x001F0C7C File Offset: 0x001EEE7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x001F0C8C File Offset: 0x001EEE8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x001F0C9C File Offset: 0x001EEE9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationSubmitRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					GuildApplicationSubmitRequest._parser = new MessageParser<GuildApplicationSubmitRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x001F0D94 File Offset: 0x001EEF94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jxXLynOHmR1K5BRT0AMT()
		{
			return true;
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x001F0D9C File Offset: 0x001EEF9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationSubmitRequest bhJjYOOHAV8JrDpehyuY()
		{
			return null;
		}

		// Token: 0x0400168E RID: 5774
		private static readonly MessageParser<GuildApplicationSubmitRequest> _parser;

		// Token: 0x0400168F RID: 5775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001690 RID: 5776
		public const int ApplyTextFieldNumber = 1;

		// Token: 0x04001691 RID: 5777
		private string applyText_;

		// Token: 0x04001692 RID: 5778
		public const int GuildIdFieldNumber = 2;

		// Token: 0x04001693 RID: 5779
		private int guildId_;

		// Token: 0x04001694 RID: 5780
		public const int TimeSpentFieldNumber = 3;

		// Token: 0x04001695 RID: 5781
		private int timeSpent_;

		// Token: 0x04001696 RID: 5782
		public const int LanguageFilterFieldNumber = 4;

		// Token: 0x04001697 RID: 5783
		private string languageFilter_;

		// Token: 0x04001698 RID: 5784
		public const int AmbianceFilterFieldNumber = 5;

		// Token: 0x04001699 RID: 5785
		private string ambianceFilter_;

		// Token: 0x0400169A RID: 5786
		public const int PlayTimeFilterFieldNumber = 6;

		// Token: 0x0400169B RID: 5787
		private string playTimeFilter_;

		// Token: 0x0400169C RID: 5788
		public const int InterestFilterFieldNumber = 7;

		// Token: 0x0400169D RID: 5789
		private string interestFilter_;

		// Token: 0x0400169E RID: 5790
		public const int MinMaxGuildLevelFilterFieldNumber = 8;

		// Token: 0x0400169F RID: 5791
		private string minMaxGuildLevelFilter_;

		// Token: 0x040016A0 RID: 5792
		public const int RecruitmentTypeFilterFieldNumber = 9;

		// Token: 0x040016A1 RID: 5793
		private string recruitmentTypeFilter_;

		// Token: 0x040016A2 RID: 5794
		public const int MinMaxCharacterLevelFilterFieldNumber = 10;

		// Token: 0x040016A3 RID: 5795
		private string minMaxCharacterLevelFilter_;

		// Token: 0x040016A4 RID: 5796
		public const int MinMaxAchievementFilterFieldNumber = 11;

		// Token: 0x040016A5 RID: 5797
		private string minMaxAchievementFilter_;

		// Token: 0x040016A6 RID: 5798
		public const int SearchNameFilterFieldNumber = 12;

		// Token: 0x040016A7 RID: 5799
		private string searchNameFilter_;

		// Token: 0x040016A8 RID: 5800
		public const int LastSortFilterFieldNumber = 13;

		// Token: 0x040016A9 RID: 5801
		private string lastSortFilter_;

		// Token: 0x040016AA RID: 5802
		private static GuildApplicationSubmitRequest uJot1gOHn3wRgRQHo89c;
	}
}
