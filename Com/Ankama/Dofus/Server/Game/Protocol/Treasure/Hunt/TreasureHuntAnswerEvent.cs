using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000044 RID: 68
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntAnswerEvent : IMessage<TreasureHuntAnswerEvent>, IMessage, IEquatable<TreasureHuntAnswerEvent>, IDeepCloneable<TreasureHuntAnswerEvent>, IBufferMessage
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00187830 File Offset: 0x00185A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureHuntAnswerEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00187840 File Offset: 0x00185A40
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00187850 File Offset: 0x00185A50
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

		// Token: 0x060002A0 RID: 672 RVA: 0x00187860 File Offset: 0x00185A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntAnswerEvent()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00187870 File Offset: 0x00185A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntAnswerEvent(TreasureHuntAnswerEvent other)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00187880 File Offset: 0x00185A80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntAnswerEvent Clone()
		{
			return null;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00187890 File Offset: 0x00185A90
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x001878A4 File Offset: 0x00185AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureHuntType QuestType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x001878B4 File Offset: 0x00185AB4
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x001878C8 File Offset: 0x00185AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureHuntAnswerEvent.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TreasureHuntAnswerEvent.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x001878D8 File Offset: 0x00185AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x001878E8 File Offset: 0x00185AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntAnswerEvent other)
		{
			return true;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x001878F8 File Offset: 0x00185AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00187908 File Offset: 0x00185B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00187918 File Offset: 0x00185B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00187928 File Offset: 0x00185B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00187938 File Offset: 0x00185B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00187948 File Offset: 0x00185B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntAnswerEvent other)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00187958 File Offset: 0x00185B58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00187968 File Offset: 0x00185B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00187978 File Offset: 0x00185B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntAnswerEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
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
					return;
				}
				TreasureHuntAnswerEvent._parser = new MessageParser<TreasureHuntAnswerEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00187A44 File Offset: 0x00185C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EDVqAMOj7TyFgyOfeW4X()
		{
			return true;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00187A4C File Offset: 0x00185C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntAnswerEvent WAZIGLOjTo9G5T0aA9mv()
		{
			return null;
		}

		// Token: 0x04000106 RID: 262
		private static readonly MessageParser<TreasureHuntAnswerEvent> _parser;

		// Token: 0x04000107 RID: 263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000108 RID: 264
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x04000109 RID: 265
		private TreasureHuntType questType_;

		// Token: 0x0400010A RID: 266
		public const int ResultFieldNumber = 2;

		// Token: 0x0400010B RID: 267
		private TreasureHuntAnswerEvent.Types.Result result_;

		// Token: 0x0400010C RID: 268
		private static TreasureHuntAnswerEvent vPS7SyOjQiqIwgiycjih;

		// Token: 0x02000045 RID: 69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060002B4 RID: 692 RVA: 0x002A6428 File Offset: 0x002A4628
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000046 RID: 70
			public enum Result
			{
				// Token: 0x0400010E RID: 270
				[OriginalName("ERROR_UNDEFINED")]
				ErrorUndefined,
				// Token: 0x0400010F RID: 271
				[OriginalName("ERROR_NO_QUEST_FOUND")]
				ErrorNoQuestFound,
				// Token: 0x04000110 RID: 272
				[OriginalName("ERROR_ALREADY_HAVE_QUEST")]
				ErrorAlreadyHaveQuest,
				// Token: 0x04000111 RID: 273
				[OriginalName("ERROR_NOT_AVAILABLE")]
				ErrorNotAvailable,
				// Token: 0x04000112 RID: 274
				[OriginalName("ERROR_DAILY_LIMIT_EXCEEDED")]
				ErrorDailyLimitExceeded,
				// Token: 0x04000113 RID: 275
				[OriginalName("OK")]
				Ok
			}
		}
	}
}
