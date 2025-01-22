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
	// Token: 0x02000D8F RID: 3471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFightPhaseUpdateEvent : IMessage<AllianceFightPhaseUpdateEvent>, IMessage, IEquatable<AllianceFightPhaseUpdateEvent>, IDeepCloneable<AllianceFightPhaseUpdateEvent>, IBufferMessage
	{
		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x0600A756 RID: 42838 RVA: 0x002943B4 File Offset: 0x002925B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceFightPhaseUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x0600A757 RID: 42839 RVA: 0x002943C4 File Offset: 0x002925C4
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

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x0600A758 RID: 42840 RVA: 0x002943D4 File Offset: 0x002925D4
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

		// Token: 0x0600A759 RID: 42841 RVA: 0x002943E4 File Offset: 0x002925E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightPhaseUpdateEvent()
		{
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x002943F4 File Offset: 0x002925F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightPhaseUpdateEvent(AllianceFightPhaseUpdateEvent other)
		{
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x00294404 File Offset: 0x00292604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFightPhaseUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600A75C RID: 42844 RVA: 0x00294414 File Offset: 0x00292614
		// (set) Token: 0x0600A75D RID: 42845 RVA: 0x00294424 File Offset: 0x00292624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x0600A75E RID: 42846 RVA: 0x00294434 File Offset: 0x00292634
		// (set) Token: 0x0600A75F RID: 42847 RVA: 0x00294444 File Offset: 0x00292644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x0600A760 RID: 42848 RVA: 0x00294454 File Offset: 0x00292654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x00294464 File Offset: 0x00292664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFightPhaseUpdateEvent other)
		{
			return true;
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x00294474 File Offset: 0x00292674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x00294484 File Offset: 0x00292684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A764 RID: 42852 RVA: 0x00294494 File Offset: 0x00292694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A765 RID: 42853 RVA: 0x002944A4 File Offset: 0x002926A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A766 RID: 42854 RVA: 0x002944B4 File Offset: 0x002926B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x002944C4 File Offset: 0x002926C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFightPhaseUpdateEvent other)
		{
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x002944D4 File Offset: 0x002926D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x002944E4 File Offset: 0x002926E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x002944F4 File Offset: 0x002926F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFightPhaseUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					AllianceFightPhaseUpdateEvent._parser = new MessageParser<AllianceFightPhaseUpdateEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x002945D8 File Offset: 0x002927D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IBdeOTJlxFnKpbY4OMgZ()
		{
			return true;
		}

		// Token: 0x0600A76C RID: 42860 RVA: 0x002945E0 File Offset: 0x002927E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFightPhaseUpdateEvent LNygLjJl4LD9E6T8vtbA()
		{
			return null;
		}

		// Token: 0x04003D90 RID: 15760
		private static readonly MessageParser<AllianceFightPhaseUpdateEvent> _parser;

		// Token: 0x04003D91 RID: 15761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D92 RID: 15762
		public const int FightInformationFieldNumber = 1;

		// Token: 0x04003D93 RID: 15763
		private SocialFightInformation fightInformation_;

		// Token: 0x04003D94 RID: 15764
		public const int PhaseFieldNumber = 2;

		// Token: 0x04003D95 RID: 15765
		private FightPhaseInfo phase_;

		// Token: 0x04003D96 RID: 15766
		internal static AllianceFightPhaseUpdateEvent yCkOKnJlNDpFyKMhUCqt;
	}
}
