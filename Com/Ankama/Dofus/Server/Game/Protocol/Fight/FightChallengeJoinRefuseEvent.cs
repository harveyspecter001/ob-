using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200068C RID: 1676
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightChallengeJoinRefuseEvent : IMessage<FightChallengeJoinRefuseEvent>, IMessage, IEquatable<FightChallengeJoinRefuseEvent>, IDeepCloneable<FightChallengeJoinRefuseEvent>, IBufferMessage
	{
		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x00206630 File Offset: 0x00204830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightChallengeJoinRefuseEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x00206640 File Offset: 0x00204840
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x00206650 File Offset: 0x00204850
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

		// Token: 0x060051C6 RID: 20934 RVA: 0x00206660 File Offset: 0x00204860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightChallengeJoinRefuseEvent()
		{
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x00206670 File Offset: 0x00204870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightChallengeJoinRefuseEvent(FightChallengeJoinRefuseEvent other)
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x00206680 File Offset: 0x00204880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightChallengeJoinRefuseEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x00206690 File Offset: 0x00204890
		// (set) Token: 0x060051CA RID: 20938 RVA: 0x002066A0 File Offset: 0x002048A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x060051CB RID: 20939 RVA: 0x002066B0 File Offset: 0x002048B0
		// (set) Token: 0x060051CC RID: 20940 RVA: 0x002066C4 File Offset: 0x002048C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightChallengeJoinRefuseEvent.Types.FighterRefusedReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightChallengeJoinRefuseEvent.Types.FighterRefusedReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x002066D4 File Offset: 0x002048D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x002066E4 File Offset: 0x002048E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightChallengeJoinRefuseEvent other)
		{
			return true;
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x002066F4 File Offset: 0x002048F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x00206704 File Offset: 0x00204904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00206714 File Offset: 0x00204914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00206724 File Offset: 0x00204924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00206734 File Offset: 0x00204934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x00206744 File Offset: 0x00204944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightChallengeJoinRefuseEvent other)
		{
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00206754 File Offset: 0x00204954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00206764 File Offset: 0x00204964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00206774 File Offset: 0x00204974
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightChallengeJoinRefuseEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FightChallengeJoinRefuseEvent._parser = new MessageParser<FightChallengeJoinRefuseEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x0020686C File Offset: 0x00204A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q7ImB4OPk0VM54OJTAqG()
		{
			return true;
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x00206874 File Offset: 0x00204A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightChallengeJoinRefuseEvent JuT6L3OPl84EoRAMy2sQ()
		{
			return null;
		}

		// Token: 0x04001CB8 RID: 7352
		private static readonly MessageParser<FightChallengeJoinRefuseEvent> _parser;

		// Token: 0x04001CB9 RID: 7353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CBA RID: 7354
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001CBB RID: 7355
		private long playerId_;

		// Token: 0x04001CBC RID: 7356
		public const int ReasonFieldNumber = 2;

		// Token: 0x04001CBD RID: 7357
		private FightChallengeJoinRefuseEvent.Types.FighterRefusedReason reason_;

		// Token: 0x04001CBE RID: 7358
		private static FightChallengeJoinRefuseEvent LrK1TKOPIGaIeGJYlm5L;

		// Token: 0x0200068D RID: 1677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060051DA RID: 20954 RVA: 0x002CAD1C File Offset: 0x002C8F1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200068E RID: 1678
			public enum FighterRefusedReason
			{
				// Token: 0x04001CC0 RID: 7360
				[OriginalName("FIGHTER_REFUSED")]
				FighterRefused,
				// Token: 0x04001CC1 RID: 7361
				[OriginalName("FIGHTER_ACCEPTED")]
				FighterAccepted,
				// Token: 0x04001CC2 RID: 7362
				[OriginalName("CHALLENGE_FULL")]
				ChallengeFull,
				// Token: 0x04001CC3 RID: 7363
				[OriginalName("TEAM_FULL")]
				TeamFull,
				// Token: 0x04001CC4 RID: 7364
				[OriginalName("WRONG_ALIGNMENT")]
				WrongAlignment,
				// Token: 0x04001CC5 RID: 7365
				[OriginalName("WRONG_GUILD")]
				WrongGuild,
				// Token: 0x04001CC6 RID: 7366
				[OriginalName("TOO_LATE")]
				TooLate,
				// Token: 0x04001CC7 RID: 7367
				[OriginalName("MUTANT_REFUSED")]
				MutantRefused,
				// Token: 0x04001CC8 RID: 7368
				[OriginalName("WRONG_MAP")]
				WrongMap,
				// Token: 0x04001CC9 RID: 7369
				[OriginalName("JUST_RESPAWNED")]
				JustRespawned,
				// Token: 0x04001CCA RID: 7370
				[OriginalName("IM_OCCUPIED")]
				ImOccupied,
				// Token: 0x04001CCB RID: 7371
				[OriginalName("OPPONENT_OCCUPIED")]
				OpponentOccupied,
				// Token: 0x04001CCC RID: 7372
				[OriginalName("FIGHT_MYSELF")]
				FightMyself,
				// Token: 0x04001CCD RID: 7373
				[OriginalName("INSUFFICIENT_RIGHTS")]
				InsufficientRights,
				// Token: 0x04001CCE RID: 7374
				[OriginalName("MEMBER_ACCOUNT_NEEDED")]
				MemberAccountNeeded,
				// Token: 0x04001CCF RID: 7375
				[OriginalName("OPPONENT_NOT_MEMBER")]
				OpponentNotMember,
				// Token: 0x04001CD0 RID: 7376
				[OriginalName("TEAM_LIMITED_BY_MAIN_CHARACTER")]
				TeamLimitedByMainCharacter,
				// Token: 0x04001CD1 RID: 7377
				[OriginalName("MULTI_ACCOUNT_NOT_ALLOWED")]
				MultiAccountNotAllowed,
				// Token: 0x04001CD2 RID: 7378
				[OriginalName("GHOST_REFUSED")]
				GhostRefused,
				// Token: 0x04001CD3 RID: 7379
				[OriginalName("WRONG_ALLIANCE")]
				WrongAlliance,
				// Token: 0x04001CD4 RID: 7380
				[OriginalName("AVA_ZONE")]
				AvaZone,
				// Token: 0x04001CD5 RID: 7381
				[OriginalName("ENTITY_REFUSED")]
				EntityRefused,
				// Token: 0x04001CD6 RID: 7382
				[OriginalName("NOT_ENOUGH_ROOM")]
				NotEnoughRoom,
				// Token: 0x04001CD7 RID: 7383
				[OriginalName("GUEST_ACCOUNT")]
				GuestAccount
			}
		}
	}
}
