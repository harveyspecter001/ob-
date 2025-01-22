using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x02000643 RID: 1603
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightEndEvent : IMessage<FightEndEvent>, IMessage, IEquatable<FightEndEvent>, IDeepCloneable<FightEndEvent>, IBufferMessage
	{
		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x002036BC File Offset: 0x002018BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightEndEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06004DBB RID: 19899 RVA: 0x002036CC File Offset: 0x002018CC
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06004DBC RID: 19900 RVA: 0x002036DC File Offset: 0x002018DC
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

		// Token: 0x06004DBD RID: 19901 RVA: 0x002036EC File Offset: 0x002018EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightEndEvent()
		{
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x002036FC File Offset: 0x002018FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightEndEvent(FightEndEvent other)
		{
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x0020370C File Offset: 0x0020190C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightEndEvent Clone()
		{
			return null;
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x0020371C File Offset: 0x0020191C
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x0020372C File Offset: 0x0020192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
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

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x0020373C File Offset: 0x0020193C
		// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x0020374C File Offset: 0x0020194C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardRate
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

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x0020375C File Offset: 0x0020195C
		// (set) Token: 0x06004DC5 RID: 19909 RVA: 0x0020376C File Offset: 0x0020196C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int LootShareLimitMalus
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x0020377C File Offset: 0x0020197C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightResultListEntry> Results
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06004DC7 RID: 19911 RVA: 0x0020378C File Offset: 0x0020198C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<NamedPartyTeamWithOutcome> NamedPartyTeamsOutcomes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x0020379C File Offset: 0x0020199C
		// (set) Token: 0x06004DC9 RID: 19913 RVA: 0x002037AC File Offset: 0x002019AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Budget
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

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x002037BC File Offset: 0x002019BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasBudget
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x002037CC File Offset: 0x002019CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearBudget()
		{
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x002037DC File Offset: 0x002019DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x002037EC File Offset: 0x002019EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightEndEvent other)
		{
			return true;
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x002037FC File Offset: 0x002019FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x0020380C File Offset: 0x00201A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x0020381C File Offset: 0x00201A1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x0020382C File Offset: 0x00201A2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x0020383C File Offset: 0x00201A3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x0020384C File Offset: 0x00201A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightEndEvent other)
		{
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x0020385C File Offset: 0x00201A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x0020386C File Offset: 0x00201A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x0020387C File Offset: 0x00201A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightEndEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FightEndEvent._repeated_results_codec = FieldCodec.ForMessage<FightResultListEntry>(34U, ta42xRmZ7y0fo2JhQSm5.XVInXhlssT(ta42xRmZ7y0fo2JhQSm5.yqimZTxMBEN));
					num2 = 7;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					FightEndEvent._parser = new MessageParser<FightEndEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 6:
					FightEndEvent.BudgetDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					FightEndEvent._repeated_namedPartyTeamsOutcomes_codec = FieldCodec.ForMessage<NamedPartyTeamWithOutcome>(42U, Ap02rmmZp90r4y8ab2RT.XVInXhlssT(Ap02rmmZp90r4y8ab2RT.e1lmZH8S8ov));
					num2 = 6;
					continue;
				}
				break;
			}
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x002039BC File Offset: 0x00201BBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H2OhFbOicA4chZimElNg()
		{
			return true;
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x002039C4 File Offset: 0x00201BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightEndEvent mm2en0OiUfo4kPpUhlee()
		{
			return null;
		}

		// Token: 0x04001B25 RID: 6949
		private static readonly MessageParser<FightEndEvent> _parser;

		// Token: 0x04001B26 RID: 6950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B27 RID: 6951
		private int _hasBits0;

		// Token: 0x04001B28 RID: 6952
		public const int DurationFieldNumber = 1;

		// Token: 0x04001B29 RID: 6953
		private int duration_;

		// Token: 0x04001B2A RID: 6954
		public const int RewardRateFieldNumber = 2;

		// Token: 0x04001B2B RID: 6955
		private int rewardRate_;

		// Token: 0x04001B2C RID: 6956
		public const int LootShareLimitMalusFieldNumber = 3;

		// Token: 0x04001B2D RID: 6957
		private int lootShareLimitMalus_;

		// Token: 0x04001B2E RID: 6958
		public const int ResultsFieldNumber = 4;

		// Token: 0x04001B2F RID: 6959
		private static readonly FieldCodec<FightResultListEntry> _repeated_results_codec;

		// Token: 0x04001B30 RID: 6960
		private readonly RepeatedField<FightResultListEntry> results_;

		// Token: 0x04001B31 RID: 6961
		public const int NamedPartyTeamsOutcomesFieldNumber = 5;

		// Token: 0x04001B32 RID: 6962
		private static readonly FieldCodec<NamedPartyTeamWithOutcome> _repeated_namedPartyTeamsOutcomes_codec;

		// Token: 0x04001B33 RID: 6963
		private readonly RepeatedField<NamedPartyTeamWithOutcome> namedPartyTeamsOutcomes_;

		// Token: 0x04001B34 RID: 6964
		public const int BudgetFieldNumber = 6;

		// Token: 0x04001B35 RID: 6965
		private static readonly int BudgetDefaultValue;

		// Token: 0x04001B36 RID: 6966
		private int budget_;

		// Token: 0x04001B37 RID: 6967
		internal static FightEndEvent D5dTn8OilYWAa4FbrERK;
	}
}
