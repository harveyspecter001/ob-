using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation
{
	// Token: 0x020006A7 RID: 1703
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightSpectatorJoinEvent : IMessage<FightSpectatorJoinEvent>, IMessage, IEquatable<FightSpectatorJoinEvent>, IDeepCloneable<FightSpectatorJoinEvent>, IBufferMessage
	{
		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06005321 RID: 21281 RVA: 0x00209514 File Offset: 0x00207714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightSpectatorJoinEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x00209524 File Offset: 0x00207724
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

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06005323 RID: 21283 RVA: 0x00209534 File Offset: 0x00207734
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

		// Token: 0x06005324 RID: 21284 RVA: 0x00209544 File Offset: 0x00207744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpectatorJoinEvent()
		{
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x00209554 File Offset: 0x00207754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpectatorJoinEvent(FightSpectatorJoinEvent other)
		{
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x00209564 File Offset: 0x00207764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSpectatorJoinEvent Clone()
		{
			return null;
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06005327 RID: 21287 RVA: 0x00209574 File Offset: 0x00207774
		// (set) Token: 0x06005328 RID: 21288 RVA: 0x00209584 File Offset: 0x00207784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightJoinEvent FightJoinEvent
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

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06005329 RID: 21289 RVA: 0x00209594 File Offset: 0x00207794
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

		// Token: 0x0600532A RID: 21290 RVA: 0x002095A4 File Offset: 0x002077A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x002095B4 File Offset: 0x002077B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightSpectatorJoinEvent other)
		{
			return true;
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x002095C4 File Offset: 0x002077C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x002095D4 File Offset: 0x002077D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x002095E4 File Offset: 0x002077E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x002095F4 File Offset: 0x002077F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00209604 File Offset: 0x00207804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00209614 File Offset: 0x00207814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightSpectatorJoinEvent other)
		{
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00209624 File Offset: 0x00207824
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00209634 File Offset: 0x00207834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x00209644 File Offset: 0x00207844
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightSpectatorJoinEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						FightSpectatorJoinEvent._parser = new MessageParser<FightSpectatorJoinEvent>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 4:
						goto IL_D9;
					case 5:
						return;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
				}
				IL_D9:
				FightSpectatorJoinEvent._repeated_namedPartyTeams_codec = FieldCodec.ForMessage<NamedPartyTeam>(18U, u3vkFWmC4nUWSpIJbYN6.XVInXhlssT(u3vkFWmC4nUWSpIJbYN6.bNcmCj2H9e3));
				num = 5;
			}
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00209750 File Offset: 0x00207950
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hxAVGOOSnG5f3YC4rdJy()
		{
			return true;
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x00209758 File Offset: 0x00207958
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightSpectatorJoinEvent vOoOJiOSmqiLlo9NKMcQ()
		{
			return null;
		}

		// Token: 0x04001D4E RID: 7502
		private static readonly MessageParser<FightSpectatorJoinEvent> _parser;

		// Token: 0x04001D4F RID: 7503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D50 RID: 7504
		public const int FightJoinEventFieldNumber = 1;

		// Token: 0x04001D51 RID: 7505
		private FightJoinEvent fightJoinEvent_;

		// Token: 0x04001D52 RID: 7506
		public const int NamedPartyTeamsFieldNumber = 2;

		// Token: 0x04001D53 RID: 7507
		private static readonly FieldCodec<NamedPartyTeam> _repeated_namedPartyTeams_codec;

		// Token: 0x04001D54 RID: 7508
		private readonly RepeatedField<NamedPartyTeam> namedPartyTeams_;

		// Token: 0x04001D55 RID: 7509
		internal static FightSpectatorJoinEvent rVBijNOSfAc8II0drAZE;
	}
}
