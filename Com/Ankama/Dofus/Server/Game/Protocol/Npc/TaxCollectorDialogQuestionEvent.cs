using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc
{
	// Token: 0x02000343 RID: 835
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorDialogQuestionEvent : IMessage<TaxCollectorDialogQuestionEvent>, IMessage, IEquatable<TaxCollectorDialogQuestionEvent>, IDeepCloneable<TaxCollectorDialogQuestionEvent>, IBufferMessage
	{
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x001C36D8 File Offset: 0x001C18D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorDialogQuestionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x001C36E8 File Offset: 0x001C18E8
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x001C36F8 File Offset: 0x001C18F8
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

		// Token: 0x06002719 RID: 10009 RVA: 0x001C3708 File Offset: 0x001C1908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorDialogQuestionEvent()
		{
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x001C3718 File Offset: 0x001C1918
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorDialogQuestionEvent(TaxCollectorDialogQuestionEvent other)
		{
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x001C3728 File Offset: 0x001C1928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorDialogQuestionEvent Clone()
		{
			return null;
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x001C3738 File Offset: 0x001C1938
		// (set) Token: 0x0600271D RID: 10013 RVA: 0x001C3748 File Offset: 0x001C1948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceInformation AllianceInformation
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

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x001C3758 File Offset: 0x001C1958
		// (set) Token: 0x0600271F RID: 10015 RVA: 0x001C3768 File Offset: 0x001C1968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxPods
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

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x001C3778 File Offset: 0x001C1978
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x001C3788 File Offset: 0x001C1988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Prospecting
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

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x001C3798 File Offset: 0x001C1998
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x001C37A8 File Offset: 0x001C19A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaxCollectorsCount
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

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x001C37B8 File Offset: 0x001C19B8
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x001C37C8 File Offset: 0x001C19C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LootedPods
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x001C37D8 File Offset: 0x001C19D8
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x001C37E8 File Offset: 0x001C19E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LootedItemsValue
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x001C37F8 File Offset: 0x001C19F8
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x001C3808 File Offset: 0x001C1A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PossibleAttack
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

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x001C3818 File Offset: 0x001C1A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasPossibleAttack
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x001C3828 File Offset: 0x001C1A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPossibleAttack()
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x001C3838 File Offset: 0x001C1A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x001C3848 File Offset: 0x001C1A48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorDialogQuestionEvent other)
		{
			return true;
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x001C3858 File Offset: 0x001C1A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x001C3868 File Offset: 0x001C1A68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x001C3878 File Offset: 0x001C1A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x001C3888 File Offset: 0x001C1A88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x001C3898 File Offset: 0x001C1A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x001C38A8 File Offset: 0x001C1AA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorDialogQuestionEvent other)
		{
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x001C38B8 File Offset: 0x001C1AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x001C38C8 File Offset: 0x001C1AC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x001C38D8 File Offset: 0x001C1AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorDialogQuestionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					TaxCollectorDialogQuestionEvent._parser = new MessageParser<TaxCollectorDialogQuestionEvent>(() => null);
					num2 = 5;
					continue;
				case 5:
					TaxCollectorDialogQuestionEvent.PossibleAttackDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x001C39E4 File Offset: 0x001C1BE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l0aJfJOWzACwDr8OnAip()
		{
			return true;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x001C39EC File Offset: 0x001C1BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorDialogQuestionEvent AwRYm1OhfKo5LWEfHNMB()
		{
			return null;
		}

		// Token: 0x04000DEB RID: 3563
		private static readonly MessageParser<TaxCollectorDialogQuestionEvent> _parser;

		// Token: 0x04000DEC RID: 3564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DED RID: 3565
		private int _hasBits0;

		// Token: 0x04000DEE RID: 3566
		public const int AllianceInformationFieldNumber = 1;

		// Token: 0x04000DEF RID: 3567
		private AllianceInformation allianceInformation_;

		// Token: 0x04000DF0 RID: 3568
		public const int MaxPodsFieldNumber = 2;

		// Token: 0x04000DF1 RID: 3569
		private int maxPods_;

		// Token: 0x04000DF2 RID: 3570
		public const int ProspectingFieldNumber = 3;

		// Token: 0x04000DF3 RID: 3571
		private int prospecting_;

		// Token: 0x04000DF4 RID: 3572
		public const int TaxCollectorsCountFieldNumber = 4;

		// Token: 0x04000DF5 RID: 3573
		private int taxCollectorsCount_;

		// Token: 0x04000DF6 RID: 3574
		public const int LootedPodsFieldNumber = 6;

		// Token: 0x04000DF7 RID: 3575
		private int lootedPods_;

		// Token: 0x04000DF8 RID: 3576
		public const int LootedItemsValueFieldNumber = 7;

		// Token: 0x04000DF9 RID: 3577
		private long lootedItemsValue_;

		// Token: 0x04000DFA RID: 3578
		public const int PossibleAttackFieldNumber = 5;

		// Token: 0x04000DFB RID: 3579
		private static readonly int PossibleAttackDefaultValue;

		// Token: 0x04000DFC RID: 3580
		private int possibleAttack_;

		// Token: 0x04000DFD RID: 3581
		private static TaxCollectorDialogQuestionEvent ewFGPFOWFpO4gekYAc5W;
	}
}
