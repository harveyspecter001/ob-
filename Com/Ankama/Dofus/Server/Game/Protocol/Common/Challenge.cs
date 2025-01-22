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
	// Token: 0x02000A22 RID: 2594
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Challenge : IMessage<Challenge>, IMessage, IEquatable<Challenge>, IDeepCloneable<Challenge>, IBufferMessage
	{
		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06007BC7 RID: 31687 RVA: 0x0025C830 File Offset: 0x0025AA30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Challenge> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x0025C840 File Offset: 0x0025AA40
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

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06007BC9 RID: 31689 RVA: 0x0025C850 File Offset: 0x0025AA50
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

		// Token: 0x06007BCA RID: 31690 RVA: 0x0025C860 File Offset: 0x0025AA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Challenge()
		{
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x0025C870 File Offset: 0x0025AA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Challenge(Challenge other)
		{
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x0025C880 File Offset: 0x0025AA80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Challenge Clone()
		{
			return null;
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06007BCD RID: 31693 RVA: 0x0025C890 File Offset: 0x0025AA90
		// (set) Token: 0x06007BCE RID: 31694 RVA: 0x0025C8A0 File Offset: 0x0025AAA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ChallengeId
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

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06007BCF RID: 31695 RVA: 0x0025C8B0 File Offset: 0x0025AAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChallengeTarget> Targets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06007BD0 RID: 31696 RVA: 0x0025C8C0 File Offset: 0x0025AAC0
		// (set) Token: 0x06007BD1 RID: 31697 RVA: 0x0025C8D0 File Offset: 0x0025AAD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int DropBonus
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

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06007BD2 RID: 31698 RVA: 0x0025C8E0 File Offset: 0x0025AAE0
		// (set) Token: 0x06007BD3 RID: 31699 RVA: 0x0025C8F0 File Offset: 0x0025AAF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int XpBonus
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

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06007BD4 RID: 31700 RVA: 0x0025C900 File Offset: 0x0025AB00
		// (set) Token: 0x06007BD5 RID: 31701 RVA: 0x0025C914 File Offset: 0x0025AB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Challenge.Types.ChallengeState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Challenge.Types.ChallengeState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x0025C924 File Offset: 0x0025AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x0025C934 File Offset: 0x0025AB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Challenge other)
		{
			return true;
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x0025C944 File Offset: 0x0025AB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x0025C954 File Offset: 0x0025AB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x0025C964 File Offset: 0x0025AB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x0025C974 File Offset: 0x0025AB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x0025C984 File Offset: 0x0025AB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x0025C994 File Offset: 0x0025AB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Challenge other)
		{
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x0025C9A4 File Offset: 0x0025ABA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x0025C9B4 File Offset: 0x0025ABB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x0025C9C4 File Offset: 0x0025ABC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Challenge()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						Challenge._parser = new MessageParser<Challenge>(() => null);
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						goto IL_39;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 2;
					}
				}
				IL_39:
				Challenge._repeated_targets_codec = FieldCodec.ForMessage<ChallengeTarget>(18U, NxS2uJBK3OTeB1PrKbbg.XVInXhlssT(NxS2uJBK3OTeB1PrKbbg.dMcBKRN4bqg));
				num = 3;
			}
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x0025CAE4 File Offset: 0x0025ACE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xIagvuJGEkmYrGj3y434()
		{
			return true;
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x0025CAEC File Offset: 0x0025ACEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Challenge pppqRPJGXdGIi2FcnfpF()
		{
			return null;
		}

		// Token: 0x04002C76 RID: 11382
		private static readonly MessageParser<Challenge> _parser;

		// Token: 0x04002C77 RID: 11383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C78 RID: 11384
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04002C79 RID: 11385
		private int challengeId_;

		// Token: 0x04002C7A RID: 11386
		public const int TargetsFieldNumber = 2;

		// Token: 0x04002C7B RID: 11387
		private static readonly FieldCodec<ChallengeTarget> _repeated_targets_codec;

		// Token: 0x04002C7C RID: 11388
		private readonly RepeatedField<ChallengeTarget> targets_;

		// Token: 0x04002C7D RID: 11389
		public const int DropBonusFieldNumber = 3;

		// Token: 0x04002C7E RID: 11390
		private int dropBonus_;

		// Token: 0x04002C7F RID: 11391
		public const int XpBonusFieldNumber = 4;

		// Token: 0x04002C80 RID: 11392
		private int xpBonus_;

		// Token: 0x04002C81 RID: 11393
		public const int StateFieldNumber = 5;

		// Token: 0x04002C82 RID: 11394
		private Challenge.Types.ChallengeState state_;

		// Token: 0x04002C83 RID: 11395
		internal static Challenge fWmAqVJG2Xpmg05nJ61b;

		// Token: 0x02000A23 RID: 2595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06007BE3 RID: 31715 RVA: 0x002DF1EC File Offset: 0x002DD3EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A24 RID: 2596
			public enum ChallengeState
			{
				// Token: 0x04002C85 RID: 11397
				[OriginalName("CHALLENGE_COMPLETED")]
				ChallengeCompleted,
				// Token: 0x04002C86 RID: 11398
				[OriginalName("CHALLENGE_FAILED")]
				ChallengeFailed,
				// Token: 0x04002C87 RID: 11399
				[OriginalName("CHALLENGE_RUNNING")]
				ChallengeRunning
			}
		}
	}
}
