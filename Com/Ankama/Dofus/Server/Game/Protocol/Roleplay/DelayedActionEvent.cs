using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay
{
	// Token: 0x02000194 RID: 404
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DelayedActionEvent : IMessage<DelayedActionEvent>, IMessage, IEquatable<DelayedActionEvent>, IDeepCloneable<DelayedActionEvent>, IBufferMessage
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x001A2778 File Offset: 0x001A0978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<DelayedActionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x001A2788 File Offset: 0x001A0988
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x001A2798 File Offset: 0x001A0998
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

		// Token: 0x060012B7 RID: 4791 RVA: 0x001A27A8 File Offset: 0x001A09A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionEvent()
		{
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x001A27B8 File Offset: 0x001A09B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionEvent(DelayedActionEvent other)
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x001A27C8 File Offset: 0x001A09C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelayedActionEvent Clone()
		{
			return null;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x001A27D8 File Offset: 0x001A09D8
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x001A27E8 File Offset: 0x001A09E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CharacterId
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x001A27F8 File Offset: 0x001A09F8
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x001A280C File Offset: 0x001A0A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DelayedActionType DelayedActionType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DelayedActionType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x001A281C File Offset: 0x001A0A1C
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x001A282C File Offset: 0x001A0A2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long DelayedEndTime
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x001A283C File Offset: 0x001A0A3C
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x001A284C File Offset: 0x001A0A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x001A285C File Offset: 0x001A0A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasObjectGid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x001A286C File Offset: 0x001A0A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearObjectGid()
		{
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x001A287C File Offset: 0x001A0A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x001A288C File Offset: 0x001A0A8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DelayedActionEvent other)
		{
			return true;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x001A289C File Offset: 0x001A0A9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x001A28AC File Offset: 0x001A0AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x001A28BC File Offset: 0x001A0ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x001A28CC File Offset: 0x001A0ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x001A28DC File Offset: 0x001A0ADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x001A28EC File Offset: 0x001A0AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DelayedActionEvent other)
		{
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x001A28FC File Offset: 0x001A0AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x001A290C File Offset: 0x001A0B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x001A291C File Offset: 0x001A0B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DelayedActionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					DelayedActionEvent._parser = new MessageParser<DelayedActionEvent>(() => null);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					DelayedActionEvent.ObjectGidDefaultValue = 0;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x001A2A28 File Offset: 0x001A0C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool inDD82OoAOfmGhEf3fI1()
		{
			return true;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x001A2A30 File Offset: 0x001A0C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DelayedActionEvent f6fun3OoB99WAHtDeylY()
		{
			return null;
		}

		// Token: 0x040006C0 RID: 1728
		private static readonly MessageParser<DelayedActionEvent> _parser;

		// Token: 0x040006C1 RID: 1729
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006C2 RID: 1730
		private int _hasBits0;

		// Token: 0x040006C3 RID: 1731
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x040006C4 RID: 1732
		private long characterId_;

		// Token: 0x040006C5 RID: 1733
		public const int DelayedActionTypeFieldNumber = 2;

		// Token: 0x040006C6 RID: 1734
		private DelayedActionType delayedActionType_;

		// Token: 0x040006C7 RID: 1735
		public const int DelayedEndTimeFieldNumber = 3;

		// Token: 0x040006C8 RID: 1736
		private long delayedEndTime_;

		// Token: 0x040006C9 RID: 1737
		public const int ObjectGidFieldNumber = 4;

		// Token: 0x040006CA RID: 1738
		private static readonly int ObjectGidDefaultValue;

		// Token: 0x040006CB RID: 1739
		private int objectGid_;

		// Token: 0x040006CC RID: 1740
		internal static DelayedActionEvent yeo5qsOomhGAaXc4SJX6;
	}
}
