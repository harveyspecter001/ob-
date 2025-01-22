using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x02000966 RID: 2406
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBonusChoiceSelectedEvent : IMessage<ChallengeBonusChoiceSelectedEvent>, IMessage, IEquatable<ChallengeBonusChoiceSelectedEvent>, IDeepCloneable<ChallengeBonusChoiceSelectedEvent>, IBufferMessage
	{
		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06007481 RID: 29825 RVA: 0x00240D9C File Offset: 0x0023EF9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChallengeBonusChoiceSelectedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06007482 RID: 29826 RVA: 0x00240DAC File Offset: 0x0023EFAC
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

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06007483 RID: 29827 RVA: 0x00240DBC File Offset: 0x0023EFBC
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

		// Token: 0x06007484 RID: 29828 RVA: 0x00240DCC File Offset: 0x0023EFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeBonusChoiceSelectedEvent()
		{
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x00240DDC File Offset: 0x0023EFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeBonusChoiceSelectedEvent(ChallengeBonusChoiceSelectedEvent other)
		{
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x00240DEC File Offset: 0x0023EFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeBonusChoiceSelectedEvent Clone()
		{
			return null;
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06007487 RID: 29831 RVA: 0x00240DFC File Offset: 0x0023EFFC
		// (set) Token: 0x06007488 RID: 29832 RVA: 0x00240E10 File Offset: 0x0023F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBonus ChallengeBonus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ChallengeBonus)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x00240E20 File Offset: 0x0023F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x00240E30 File Offset: 0x0023F030
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeBonusChoiceSelectedEvent other)
		{
			return true;
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x00240E40 File Offset: 0x0023F040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x00240E50 File Offset: 0x0023F050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00240E60 File Offset: 0x0023F060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x00240E70 File Offset: 0x0023F070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x00240E80 File Offset: 0x0023F080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00240E90 File Offset: 0x0023F090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeBonusChoiceSelectedEvent other)
		{
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x00240EA0 File Offset: 0x0023F0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x00240EB0 File Offset: 0x0023F0B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x00240EC0 File Offset: 0x0023F0C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeBonusChoiceSelectedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ChallengeBonusChoiceSelectedEvent._parser = new MessageParser<ChallengeBonusChoiceSelectedEvent>(() => null);
					num2 = 4;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x00240FA4 File Offset: 0x0023F1A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JUNSWEJ38bhSx1gvsTAB()
		{
			return true;
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x00240FAC File Offset: 0x0023F1AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeBonusChoiceSelectedEvent wI4gl8J3ZkTMq1sDnnhQ()
		{
			return null;
		}

		// Token: 0x040028A6 RID: 10406
		private static readonly MessageParser<ChallengeBonusChoiceSelectedEvent> _parser;

		// Token: 0x040028A7 RID: 10407
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A8 RID: 10408
		public const int ChallengeBonusFieldNumber = 1;

		// Token: 0x040028A9 RID: 10409
		private ChallengeBonus challengeBonus_;

		// Token: 0x040028AA RID: 10410
		internal static ChallengeBonusChoiceSelectedEvent wR89vIJ3uJGhsGHxVbIq;
	}
}
