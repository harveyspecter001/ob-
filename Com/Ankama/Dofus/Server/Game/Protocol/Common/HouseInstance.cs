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
	// Token: 0x02000B1E RID: 2846
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseInstance : IMessage<HouseInstance>, IMessage, IEquatable<HouseInstance>, IDeepCloneable<HouseInstance>, IBufferMessage
	{
		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060087F9 RID: 34809 RVA: 0x00265E48 File Offset: 0x00264048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HouseInstance> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x00265E58 File Offset: 0x00264058
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

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060087FB RID: 34811 RVA: 0x00265E68 File Offset: 0x00264068
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

		// Token: 0x060087FC RID: 34812 RVA: 0x00265E78 File Offset: 0x00264078
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInstance()
		{
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x00265E88 File Offset: 0x00264088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInstance(HouseInstance other)
		{
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x00265E98 File Offset: 0x00264098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseInstance Clone()
		{
			return null;
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060087FF RID: 34815 RVA: 0x00265EA8 File Offset: 0x002640A8
		// (set) Token: 0x06008800 RID: 34816 RVA: 0x00265EB8 File Offset: 0x002640B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstanceId
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

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06008801 RID: 34817 RVA: 0x00265EC8 File Offset: 0x002640C8
		// (set) Token: 0x06008802 RID: 34818 RVA: 0x00265ED8 File Offset: 0x002640D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SecondHand
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

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06008803 RID: 34819 RVA: 0x00265EE8 File Offset: 0x002640E8
		// (set) Token: 0x06008804 RID: 34820 RVA: 0x00265EF8 File Offset: 0x002640F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsLocked
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

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x06008805 RID: 34821 RVA: 0x00265F08 File Offset: 0x00264108
		// (set) Token: 0x06008806 RID: 34822 RVA: 0x00265F18 File Offset: 0x00264118
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

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x06008807 RID: 34823 RVA: 0x00265F28 File Offset: 0x00264128
		// (set) Token: 0x06008808 RID: 34824 RVA: 0x00265F38 File Offset: 0x00264138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasOwner
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

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06008809 RID: 34825 RVA: 0x00265F48 File Offset: 0x00264148
		// (set) Token: 0x0600880A RID: 34826 RVA: 0x00265F58 File Offset: 0x00264158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSaleLocked
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

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x0600880B RID: 34827 RVA: 0x00265F68 File Offset: 0x00264168
		// (set) Token: 0x0600880C RID: 34828 RVA: 0x00265F78 File Offset: 0x00264178
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsAdminLocked
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

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x00265F88 File Offset: 0x00264188
		// (set) Token: 0x0600880E RID: 34830 RVA: 0x00265F98 File Offset: 0x00264198
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RoomsCount
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

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x0600880F RID: 34831 RVA: 0x00265FA8 File Offset: 0x002641A8
		// (set) Token: 0x06008810 RID: 34832 RVA: 0x00265FB8 File Offset: 0x002641B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ChestsCount
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

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06008811 RID: 34833 RVA: 0x00265FC8 File Offset: 0x002641C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06008812 RID: 34834 RVA: 0x00265FD8 File Offset: 0x002641D8
		// (set) Token: 0x06008813 RID: 34835 RVA: 0x00265FE8 File Offset: 0x002641E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Price
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

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x00265FF8 File Offset: 0x002641F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPrice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008815 RID: 34837 RVA: 0x00266008 File Offset: 0x00264208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPrice()
		{
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06008816 RID: 34838 RVA: 0x00266018 File Offset: 0x00264218
		// (set) Token: 0x06008817 RID: 34839 RVA: 0x00266028 File Offset: 0x00264228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildInformation GuildInformation
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

		// Token: 0x06008818 RID: 34840 RVA: 0x00266038 File Offset: 0x00264238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x00266048 File Offset: 0x00264248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseInstance other)
		{
			return true;
		}

		// Token: 0x0600881A RID: 34842 RVA: 0x00266058 File Offset: 0x00264258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600881B RID: 34843 RVA: 0x00266068 File Offset: 0x00264268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x00266078 File Offset: 0x00264278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600881D RID: 34845 RVA: 0x00266088 File Offset: 0x00264288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600881E RID: 34846 RVA: 0x00266098 File Offset: 0x00264298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600881F RID: 34847 RVA: 0x002660A8 File Offset: 0x002642A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseInstance other)
		{
		}

		// Token: 0x06008820 RID: 34848 RVA: 0x002660B8 File Offset: 0x002642B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x002660C8 File Offset: 0x002642C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008822 RID: 34850 RVA: 0x002660D8 File Offset: 0x002642D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseInstance()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					HouseInstance.PriceDefaultValue = 0L;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					HouseInstance._parser = new MessageParser<HouseInstance>(() => null);
					num2 = 6;
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					break;
				case 6:
					HouseInstance._repeated_skillsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(98U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x002661D8 File Offset: 0x002643D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool NArsvUJdBAjXtRYDJkr5()
		{
			return true;
		}

		// Token: 0x06008824 RID: 34852 RVA: 0x002661E0 File Offset: 0x002643E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseInstance sKIlbMJde8SaYhlWpyRB()
		{
			return null;
		}

		// Token: 0x04003200 RID: 12800
		private static readonly MessageParser<HouseInstance> _parser;

		// Token: 0x04003201 RID: 12801
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003202 RID: 12802
		private int _hasBits0;

		// Token: 0x04003203 RID: 12803
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x04003204 RID: 12804
		private int instanceId_;

		// Token: 0x04003205 RID: 12805
		public const int SecondHandFieldNumber = 2;

		// Token: 0x04003206 RID: 12806
		private bool secondHand_;

		// Token: 0x04003207 RID: 12807
		public const int IsLockedFieldNumber = 3;

		// Token: 0x04003208 RID: 12808
		private bool isLocked_;

		// Token: 0x04003209 RID: 12809
		public const int AccountTagFieldNumber = 4;

		// Token: 0x0400320A RID: 12810
		private AccountTag accountTag_;

		// Token: 0x0400320B RID: 12811
		public const int HasOwnerFieldNumber = 5;

		// Token: 0x0400320C RID: 12812
		private bool hasOwner_;

		// Token: 0x0400320D RID: 12813
		public const int IsSaleLockedFieldNumber = 7;

		// Token: 0x0400320E RID: 12814
		private bool isSaleLocked_;

		// Token: 0x0400320F RID: 12815
		public const int IsAdminLockedFieldNumber = 8;

		// Token: 0x04003210 RID: 12816
		private bool isAdminLocked_;

		// Token: 0x04003211 RID: 12817
		public const int RoomsCountFieldNumber = 10;

		// Token: 0x04003212 RID: 12818
		private int roomsCount_;

		// Token: 0x04003213 RID: 12819
		public const int ChestsCountFieldNumber = 11;

		// Token: 0x04003214 RID: 12820
		private int chestsCount_;

		// Token: 0x04003215 RID: 12821
		public const int SkillsIdFieldNumber = 12;

		// Token: 0x04003216 RID: 12822
		private static readonly FieldCodec<int> _repeated_skillsId_codec;

		// Token: 0x04003217 RID: 12823
		private readonly RepeatedField<int> skillsId_;

		// Token: 0x04003218 RID: 12824
		public const int PriceFieldNumber = 6;

		// Token: 0x04003219 RID: 12825
		private static readonly long PriceDefaultValue;

		// Token: 0x0400321A RID: 12826
		private long price_;

		// Token: 0x0400321B RID: 12827
		public const int GuildInformationFieldNumber = 9;

		// Token: 0x0400321C RID: 12828
		private GuildInformation guildInformation_;

		// Token: 0x0400321D RID: 12829
		private static HouseInstance syODAcJdAXPYPiXLNNAF;
	}
}
