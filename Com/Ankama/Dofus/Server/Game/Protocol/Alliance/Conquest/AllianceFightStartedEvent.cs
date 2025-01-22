using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D8B RID: 3467
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightStartedEvent : IMessage<AllianceFightStartedEvent>, IMessage, IEquatable<AllianceFightStartedEvent>, IDeepCloneable<AllianceFightStartedEvent>, IBufferMessage
	{
		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600A720 RID: 42784 RVA: 0x00293F58 File Offset: 0x00292158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceFightStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600A721 RID: 42785 RVA: 0x00293F68 File Offset: 0x00292168
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

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x0600A722 RID: 42786 RVA: 0x00293F78 File Offset: 0x00292178
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

		// Token: 0x0600A723 RID: 42787 RVA: 0x00293F88 File Offset: 0x00292188
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightStartedEvent()
		{
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x00293F98 File Offset: 0x00292198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightStartedEvent(AllianceFightStartedEvent other)
		{
		}

		// Token: 0x0600A725 RID: 42789 RVA: 0x00293FA8 File Offset: 0x002921A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x0600A726 RID: 42790 RVA: 0x00293FB8 File Offset: 0x002921B8
		// (set) Token: 0x0600A727 RID: 42791 RVA: 0x00293FC8 File Offset: 0x002921C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialFightInformation FightInformation
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

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x0600A728 RID: 42792 RVA: 0x00293FD8 File Offset: 0x002921D8
		// (set) Token: 0x0600A729 RID: 42793 RVA: 0x00293FE8 File Offset: 0x002921E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightPhaseInfo Phase
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

		// Token: 0x0600A72A RID: 42794 RVA: 0x00293FF8 File Offset: 0x002921F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x00294008 File Offset: 0x00292208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightStartedEvent other)
		{
			return true;
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x00294018 File Offset: 0x00292218
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x00294028 File Offset: 0x00292228
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x00294038 File Offset: 0x00292238
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x00294048 File Offset: 0x00292248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x00294058 File Offset: 0x00292258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x00294068 File Offset: 0x00292268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightStartedEvent other)
		{
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x00294078 File Offset: 0x00292278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x00294088 File Offset: 0x00292288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x00294098 File Offset: 0x00292298
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				case 2:
					AllianceFightStartedEvent._parser = new MessageParser<AllianceFightStartedEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x0029417C File Offset: 0x0029237C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tKpMHKJldjRjUfnAJYBf()
		{
			return true;
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x00294184 File Offset: 0x00292384
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightStartedEvent k1L6rQJl9nAJGBSaan1h()
		{
			return null;
		}

		// Token: 0x04003D80 RID: 15744
		private static readonly MessageParser<AllianceFightStartedEvent> _parser;

		// Token: 0x04003D81 RID: 15745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D82 RID: 15746
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003D83 RID: 15747
		private SocialFightInformation fightInformation_;

		// Token: 0x04003D84 RID: 15748
		public const int PhaseFieldNumber = 2;

		// Token: 0x04003D85 RID: 15749
		private FightPhaseInfo phase_;

		// Token: 0x04003D86 RID: 15750
		private static AllianceFightStartedEvent TyGrC0JlsvxpuJke6UqQ;
	}
}
