using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200059A RID: 1434
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapRunningFightDetailsExtendedEvent : IMessage<MapRunningFightDetailsExtendedEvent>, IMessage, IEquatable<MapRunningFightDetailsExtendedEvent>, IDeepCloneable<MapRunningFightDetailsExtendedEvent>, IBufferMessage
	{
		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x0600452B RID: 17707 RVA: 0x001F7488 File Offset: 0x001F5688
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapRunningFightDetailsExtendedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x001F7498 File Offset: 0x001F5698
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

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x001F74A8 File Offset: 0x001F56A8
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

		// Token: 0x0600452E RID: 17710 RVA: 0x001F74B8 File Offset: 0x001F56B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsExtendedEvent()
		{
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x001F74C8 File Offset: 0x001F56C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsExtendedEvent(MapRunningFightDetailsExtendedEvent other)
		{
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x001F74D8 File Offset: 0x001F56D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsExtendedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x001F74E8 File Offset: 0x001F56E8
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x001F74F8 File Offset: 0x001F56F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FightId
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

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x001F7508 File Offset: 0x001F5708
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FighterLightInformation> Attackers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06004534 RID: 17716 RVA: 0x001F7518 File Offset: 0x001F5718
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<FighterLightInformation> Defenders
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x001F7528 File Offset: 0x001F5728
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<NamedPartyTeam> NamedPartyTeams
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x001F7538 File Offset: 0x001F5738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x001F7548 File Offset: 0x001F5748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapRunningFightDetailsExtendedEvent other)
		{
			return true;
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x001F7558 File Offset: 0x001F5758
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x001F7568 File Offset: 0x001F5768
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x001F7578 File Offset: 0x001F5778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x001F7588 File Offset: 0x001F5788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x001F7598 File Offset: 0x001F5798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x001F75A8 File Offset: 0x001F57A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapRunningFightDetailsExtendedEvent other)
		{
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x001F75B8 File Offset: 0x001F57B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x001F75C8 File Offset: 0x001F57C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x001F75D8 File Offset: 0x001F57D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapRunningFightDetailsExtendedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 7;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 3:
					MapRunningFightDetailsExtendedEvent._repeated_attackers_codec = FieldCodec.ForMessage<FighterLightInformation>(18U, zLDwDtmCOEV8JwgAeDVJ.XVInXhlssT(zLDwDtmCOEV8JwgAeDVJ.eFZmCJQoIFh));
					num2 = 4;
					continue;
				case 4:
					MapRunningFightDetailsExtendedEvent._repeated_defenders_codec = FieldCodec.ForMessage<FighterLightInformation>(26U, zLDwDtmCOEV8JwgAeDVJ.XVInXhlssT(zLDwDtmCOEV8JwgAeDVJ.eFZmCJQoIFh));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					MapRunningFightDetailsExtendedEvent._parser = new MessageParser<MapRunningFightDetailsExtendedEvent>(() => null);
					num2 = 3;
					continue;
				case 6:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 6;
					continue;
				}
				MapRunningFightDetailsExtendedEvent._repeated_namedPartyTeams_codec = FieldCodec.ForMessage<NamedPartyTeam>(34U, u3vkFWmC4nUWSpIJbYN6.XVInXhlssT(u3vkFWmC4nUWSpIJbYN6.bNcmCj2H9e3));
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x001F7728 File Offset: 0x001F5928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool feVTqrOYQa4QqdSLATAJ()
		{
			return true;
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x001F7730 File Offset: 0x001F5930
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapRunningFightDetailsExtendedEvent L5O4SLOY72g0JQUbxWIe()
		{
			return null;
		}

		// Token: 0x040017C7 RID: 6087
		private static readonly MessageParser<MapRunningFightDetailsExtendedEvent> _parser;

		// Token: 0x040017C8 RID: 6088
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017C9 RID: 6089
		public const int FightIdFieldNumber = 1;

		// Token: 0x040017CA RID: 6090
		private int fightId_;

		// Token: 0x040017CB RID: 6091
		public const int AttackersFieldNumber = 2;

		// Token: 0x040017CC RID: 6092
		private static readonly FieldCodec<FighterLightInformation> _repeated_attackers_codec;

		// Token: 0x040017CD RID: 6093
		private readonly RepeatedField<FighterLightInformation> attackers_;

		// Token: 0x040017CE RID: 6094
		public const int DefendersFieldNumber = 3;

		// Token: 0x040017CF RID: 6095
		private static readonly FieldCodec<FighterLightInformation> _repeated_defenders_codec;

		// Token: 0x040017D0 RID: 6096
		private readonly RepeatedField<FighterLightInformation> defenders_;

		// Token: 0x040017D1 RID: 6097
		public const int NamedPartyTeamsFieldNumber = 4;

		// Token: 0x040017D2 RID: 6098
		private static readonly FieldCodec<NamedPartyTeam> _repeated_namedPartyTeams_codec;

		// Token: 0x040017D3 RID: 6099
		private readonly RepeatedField<NamedPartyTeam> namedPartyTeams_;

		// Token: 0x040017D4 RID: 6100
		internal static MapRunningFightDetailsExtendedEvent WY9v7TOYwmR9Nefo5vYV;
	}
}
