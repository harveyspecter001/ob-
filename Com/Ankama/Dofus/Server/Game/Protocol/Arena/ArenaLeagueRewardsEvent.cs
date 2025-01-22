using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C24 RID: 3108
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArenaLeagueRewardsEvent : IMessage<ArenaLeagueRewardsEvent>, IMessage, IEquatable<ArenaLeagueRewardsEvent>, IDeepCloneable<ArenaLeagueRewardsEvent>, IBufferMessage
	{
		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x00276F84 File Offset: 0x00275184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArenaLeagueRewardsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06009556 RID: 38230 RVA: 0x00276F94 File Offset: 0x00275194
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

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06009557 RID: 38231 RVA: 0x00276FA4 File Offset: 0x002751A4
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

		// Token: 0x06009558 RID: 38232 RVA: 0x00276FB4 File Offset: 0x002751B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaLeagueRewardsEvent()
		{
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x00276FC4 File Offset: 0x002751C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaLeagueRewardsEvent(ArenaLeagueRewardsEvent other)
		{
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00276FD4 File Offset: 0x002751D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArenaLeagueRewardsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x0600955B RID: 38235 RVA: 0x00276FE4 File Offset: 0x002751E4
		// (set) Token: 0x0600955C RID: 38236 RVA: 0x00276FF4 File Offset: 0x002751F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
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

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x00277004 File Offset: 0x00275204
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x00277014 File Offset: 0x00275214
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

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x00277024 File Offset: 0x00275224
		// (set) Token: 0x06009560 RID: 38240 RVA: 0x00277034 File Offset: 0x00275234
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

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06009561 RID: 38241 RVA: 0x00277044 File Offset: 0x00275244
		// (set) Token: 0x06009562 RID: 38242 RVA: 0x00277054 File Offset: 0x00275254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EndSeasonReward
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

		// Token: 0x06009563 RID: 38243 RVA: 0x00277064 File Offset: 0x00275264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x00277074 File Offset: 0x00275274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ArenaLeagueRewardsEvent other)
		{
			return true;
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x00277084 File Offset: 0x00275284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009566 RID: 38246 RVA: 0x00277094 File Offset: 0x00275294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x002770A4 File Offset: 0x002752A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x002770B4 File Offset: 0x002752B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x002770C4 File Offset: 0x002752C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x002770D4 File Offset: 0x002752D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ArenaLeagueRewardsEvent other)
		{
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x002770E4 File Offset: 0x002752E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x002770F4 File Offset: 0x002752F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x00277104 File Offset: 0x00275304
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ArenaLeagueRewardsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ArenaLeagueRewardsEvent._parser = new MessageParser<ArenaLeagueRewardsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x002771E8 File Offset: 0x002753E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wTCWsXJXLchT8UK7D3CV()
		{
			return true;
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x002771F0 File Offset: 0x002753F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ArenaLeagueRewardsEvent ra9ZnaJXW7pEtrLErOpc()
		{
			return null;
		}

		// Token: 0x0400379E RID: 14238
		private static readonly MessageParser<ArenaLeagueRewardsEvent> _parser;

		// Token: 0x0400379F RID: 14239
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037A0 RID: 14240
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x040037A1 RID: 14241
		private int seasonId_;

		// Token: 0x040037A2 RID: 14242
		public const int LeagueIdFieldNumber = 2;

		// Token: 0x040037A3 RID: 14243
		private int leagueId_;

		// Token: 0x040037A4 RID: 14244
		public const int LadderPositionFieldNumber = 3;

		// Token: 0x040037A5 RID: 14245
		private int ladderPosition_;

		// Token: 0x040037A6 RID: 14246
		public const int EndSeasonRewardFieldNumber = 4;

		// Token: 0x040037A7 RID: 14247
		private bool endSeasonReward_;

		// Token: 0x040037A8 RID: 14248
		internal static ArenaLeagueRewardsEvent exeSjBJX6kpAZB5irZ0X;
	}
}
