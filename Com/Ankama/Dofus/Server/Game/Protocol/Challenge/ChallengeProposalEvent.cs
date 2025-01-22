using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Challenge
{
	// Token: 0x0200095E RID: 2398
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeProposalEvent : IMessage<ChallengeProposalEvent>, IMessage, IEquatable<ChallengeProposalEvent>, IDeepCloneable<ChallengeProposalEvent>, IBufferMessage
	{
		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06007418 RID: 29720 RVA: 0x00240514 File Offset: 0x0023E714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeProposalEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06007419 RID: 29721 RVA: 0x00240524 File Offset: 0x0023E724
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

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x00240534 File Offset: 0x0023E734
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

		// Token: 0x0600741B RID: 29723 RVA: 0x00240544 File Offset: 0x0023E744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeProposalEvent()
		{
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x00240554 File Offset: 0x0023E754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeProposalEvent(ChallengeProposalEvent other)
		{
		}

		// Token: 0x0600741D RID: 29725 RVA: 0x00240564 File Offset: 0x0023E764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChallengeProposalEvent Clone()
		{
			return null;
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x00240574 File Offset: 0x0023E774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Challenge> ChallengeProposals
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600741F RID: 29727 RVA: 0x00240584 File Offset: 0x0023E784
		// (set) Token: 0x06007420 RID: 29728 RVA: 0x00240594 File Offset: 0x0023E794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Timer
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

		// Token: 0x06007421 RID: 29729 RVA: 0x002405A4 File Offset: 0x0023E7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x002405B4 File Offset: 0x0023E7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChallengeProposalEvent other)
		{
			return true;
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x002405C4 File Offset: 0x0023E7C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x002405D4 File Offset: 0x0023E7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x002405E4 File Offset: 0x0023E7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x002405F4 File Offset: 0x0023E7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x00240604 File Offset: 0x0023E804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00240614 File Offset: 0x0023E814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChallengeProposalEvent other)
		{
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00240624 File Offset: 0x0023E824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00240634 File Offset: 0x0023E834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x00240644 File Offset: 0x0023E844
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChallengeProposalEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ChallengeProposalEvent._repeated_challengeProposals_codec = FieldCodec.ForMessage<Challenge>(10U, bCS24jB91TBQOe86HREN.XVInXhlssT(bCS24jB91TBQOe86HREN.ItHB9ayeO7V));
					num2 = 5;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					ChallengeProposalEvent._parser = new MessageParser<ChallengeProposalEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					return;
				}
			}
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x0024074C File Offset: 0x0023E94C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool D4KFxaJ3Qdm40e9SnpLv()
		{
			return true;
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x00240754 File Offset: 0x0023E954
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChallengeProposalEvent lWhl2KJ37B5M9hbhPSdo()
		{
			return null;
		}

		// Token: 0x04002887 RID: 10375
		private static readonly MessageParser<ChallengeProposalEvent> _parser;

		// Token: 0x04002888 RID: 10376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002889 RID: 10377
		public const int ChallengeProposalsFieldNumber = 1;

		// Token: 0x0400288A RID: 10378
		private static readonly FieldCodec<Challenge> _repeated_challengeProposals_codec;

		// Token: 0x0400288B RID: 10379
		private readonly RepeatedField<Challenge> challengeProposals_;

		// Token: 0x0400288C RID: 10380
		public const int TimerFieldNumber = 2;

		// Token: 0x0400288D RID: 10381
		private long timer_;

		// Token: 0x0400288E RID: 10382
		private static ChallengeProposalEvent xhqHApJ3wD9sY9NOyqtR;
	}
}
