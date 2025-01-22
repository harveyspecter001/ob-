using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DDD RID: 3549
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AchievedAchievement : IMessage<AchievedAchievement>, IMessage, IEquatable<AchievedAchievement>, IDeepCloneable<AchievedAchievement>, IBufferMessage
	{
		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x0600AAFA RID: 43770 RVA: 0x00299534 File Offset: 0x00297734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AchievedAchievement> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x0600AAFB RID: 43771 RVA: 0x00299544 File Offset: 0x00297744
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

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x0600AAFC RID: 43772 RVA: 0x00299554 File Offset: 0x00297754
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

		// Token: 0x0600AAFD RID: 43773 RVA: 0x00299564 File Offset: 0x00297764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievedAchievement()
		{
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x00299574 File Offset: 0x00297774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievedAchievement(AchievedAchievement other)
		{
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x00299584 File Offset: 0x00297784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AchievedAchievement Clone()
		{
			return null;
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x0600AB00 RID: 43776 RVA: 0x00299594 File Offset: 0x00297794
		// (set) Token: 0x0600AB01 RID: 43777 RVA: 0x002995A4 File Offset: 0x002977A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AchievementId
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

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x002995B4 File Offset: 0x002977B4
		// (set) Token: 0x0600AB03 RID: 43779 RVA: 0x002995C4 File Offset: 0x002977C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AchievedBy
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

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x002995D4 File Offset: 0x002977D4
		// (set) Token: 0x0600AB05 RID: 43781 RVA: 0x002995E4 File Offset: 0x002977E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PioneerRank
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

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x0600AB06 RID: 43782 RVA: 0x002995F4 File Offset: 0x002977F4
		// (set) Token: 0x0600AB07 RID: 43783 RVA: 0x00299604 File Offset: 0x00297804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FinishedLevel
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

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x0600AB08 RID: 43784 RVA: 0x00299614 File Offset: 0x00297814
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasFinishedLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600AB09 RID: 43785 RVA: 0x00299624 File Offset: 0x00297824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearFinishedLevel()
		{
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x00299634 File Offset: 0x00297834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x00299644 File Offset: 0x00297844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AchievedAchievement other)
		{
			return true;
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x00299654 File Offset: 0x00297854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x00299664 File Offset: 0x00297864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x00299674 File Offset: 0x00297874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AB0F RID: 43791 RVA: 0x00299684 File Offset: 0x00297884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AB10 RID: 43792 RVA: 0x00299694 File Offset: 0x00297894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x002996A4 File Offset: 0x002978A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AchievedAchievement other)
		{
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x002996B4 File Offset: 0x002978B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x002996C4 File Offset: 0x002978C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x002996D4 File Offset: 0x002978D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AchievedAchievement()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					AchievedAchievement._parser = new MessageParser<AchievedAchievement>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				}
				AchievedAchievement.FinishedLevelDefaultValue = 0;
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x002997CC File Offset: 0x002979CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool svmHnJJcYISyvHKj0Ud8()
		{
			return true;
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x002997D4 File Offset: 0x002979D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AchievedAchievement yYLwqrJcb4INeF0TNhil()
		{
			return null;
		}

		// Token: 0x04003EC0 RID: 16064
		private static readonly MessageParser<AchievedAchievement> _parser;

		// Token: 0x04003EC1 RID: 16065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EC2 RID: 16066
		private int _hasBits0;

		// Token: 0x04003EC3 RID: 16067
		public const int AchievementIdFieldNumber = 1;

		// Token: 0x04003EC4 RID: 16068
		private int achievementId_;

		// Token: 0x04003EC5 RID: 16069
		public const int AchievedByFieldNumber = 2;

		// Token: 0x04003EC6 RID: 16070
		private long achievedBy_;

		// Token: 0x04003EC7 RID: 16071
		public const int PioneerRankFieldNumber = 4;

		// Token: 0x04003EC8 RID: 16072
		private int pioneerRank_;

		// Token: 0x04003EC9 RID: 16073
		public const int FinishedLevelFieldNumber = 3;

		// Token: 0x04003ECA RID: 16074
		private static readonly int FinishedLevelDefaultValue;

		// Token: 0x04003ECB RID: 16075
		private int finishedLevel_;

		// Token: 0x04003ECC RID: 16076
		internal static AchievedAchievement R0aBQhJcHlmBTE1CdVIT;
	}
}
