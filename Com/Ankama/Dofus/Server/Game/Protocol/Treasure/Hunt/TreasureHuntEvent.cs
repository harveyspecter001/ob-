using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Treasure.Hunt
{
	// Token: 0x02000048 RID: 72
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureHuntEvent : IMessage<TreasureHuntEvent>, IMessage, IEquatable<TreasureHuntEvent>, IDeepCloneable<TreasureHuntEvent>, IBufferMessage
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00187A54 File Offset: 0x00185C54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TreasureHuntEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00187A64 File Offset: 0x00185C64
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00187A74 File Offset: 0x00185C74
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

		// Token: 0x060002BD RID: 701 RVA: 0x00187A84 File Offset: 0x00185C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntEvent()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00187A94 File Offset: 0x00185C94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntEvent(TreasureHuntEvent other)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00187AA4 File Offset: 0x00185CA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TreasureHuntEvent Clone()
		{
			return null;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00187AB4 File Offset: 0x00185CB4
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00187AC8 File Offset: 0x00185CC8
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00187AD8 File Offset: 0x00185CD8
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00187AE8 File Offset: 0x00185CE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long StartMapId
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00187AF8 File Offset: 0x00185CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureHuntEvent.Types.TreasureHuntStep> KnownSteps
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00187B08 File Offset: 0x00185D08
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00187B18 File Offset: 0x00185D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalStepCount
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00187B28 File Offset: 0x00185D28
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00187B38 File Offset: 0x00185D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CurrentCheckPoint
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00187B48 File Offset: 0x00185D48
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00187B58 File Offset: 0x00185D58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TotalCheckPoint
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00187B68 File Offset: 0x00185D68
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00187B78 File Offset: 0x00185D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AvailableRetryCount
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00187B88 File Offset: 0x00185D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureHuntEvent.Types.TreasureHuntFlag> Flags
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00187B98 File Offset: 0x00185D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00187BA8 File Offset: 0x00185DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TreasureHuntEvent other)
		{
			return true;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00187BB8 File Offset: 0x00185DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00187BC8 File Offset: 0x00185DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00187BD8 File Offset: 0x00185DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00187BE8 File Offset: 0x00185DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00187BF8 File Offset: 0x00185DF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00187C08 File Offset: 0x00185E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TreasureHuntEvent other)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00187C18 File Offset: 0x00185E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00187C28 File Offset: 0x00185E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00187C38 File Offset: 0x00185E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TreasureHuntEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					TreasureHuntEvent._parser = new MessageParser<TreasureHuntEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					TreasureHuntEvent._repeated_knownSteps_codec = FieldCodec.ForMessage<TreasureHuntEvent.Types.TreasureHuntStep>(26U, C3IPBaGFrr8ZfY5xqTq.XVInXhlssT(C3IPBaGFrr8ZfY5xqTq.kAmGza35oN));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					TreasureHuntEvent._repeated_flags_codec = FieldCodec.ForMessage<TreasureHuntEvent.Types.TreasureHuntFlag>(66U, QDZkk7gGe6woZ0kUMil.XVInXhlssT(QDZkk7gGe6woZ0kUMil.A9tggWOgEs));
					num2 = 5;
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				case 5:
					return;
				case 6:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00187D78 File Offset: 0x00185F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F0jusKOjHA5EoQ69VNaV()
		{
			return true;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00187D80 File Offset: 0x00185F80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TreasureHuntEvent SVQaWMOjYIvdP6dbHkbr()
		{
			return null;
		}

		// Token: 0x04000116 RID: 278
		private static readonly MessageParser<TreasureHuntEvent> _parser;

		// Token: 0x04000117 RID: 279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000118 RID: 280
		public const int QuestTypeFieldNumber = 1;

		// Token: 0x04000119 RID: 281
		private TreasureHuntType questType_;

		// Token: 0x0400011A RID: 282
		public const int StartMapIdFieldNumber = 2;

		// Token: 0x0400011B RID: 283
		private long startMapId_;

		// Token: 0x0400011C RID: 284
		public const int KnownStepsFieldNumber = 3;

		// Token: 0x0400011D RID: 285
		private static readonly FieldCodec<TreasureHuntEvent.Types.TreasureHuntStep> _repeated_knownSteps_codec;

		// Token: 0x0400011E RID: 286
		private readonly RepeatedField<TreasureHuntEvent.Types.TreasureHuntStep> knownSteps_;

		// Token: 0x0400011F RID: 287
		public const int TotalStepCountFieldNumber = 4;

		// Token: 0x04000120 RID: 288
		private int totalStepCount_;

		// Token: 0x04000121 RID: 289
		public const int CurrentCheckPointFieldNumber = 5;

		// Token: 0x04000122 RID: 290
		private int currentCheckPoint_;

		// Token: 0x04000123 RID: 291
		public const int TotalCheckPointFieldNumber = 6;

		// Token: 0x04000124 RID: 292
		private int totalCheckPoint_;

		// Token: 0x04000125 RID: 293
		public const int AvailableRetryCountFieldNumber = 7;

		// Token: 0x04000126 RID: 294
		private int availableRetryCount_;

		// Token: 0x04000127 RID: 295
		public const int FlagsFieldNumber = 8;

		// Token: 0x04000128 RID: 296
		private static readonly FieldCodec<TreasureHuntEvent.Types.TreasureHuntFlag> _repeated_flags_codec;

		// Token: 0x04000129 RID: 297
		private readonly RepeatedField<TreasureHuntEvent.Types.TreasureHuntFlag> flags_;

		// Token: 0x0400012A RID: 298
		internal static TreasureHuntEvent ixlkwjOjpxXVJIfv6sW2;

		// Token: 0x02000049 RID: 73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060002DB RID: 731 RVA: 0x002A653C File Offset: 0x002A473C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200004A RID: 74
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class TreasureHuntStep : IMessage<TreasureHuntEvent.Types.TreasureHuntStep>, IMessage, IEquatable<TreasureHuntEvent.Types.TreasureHuntStep>, IDeepCloneable<TreasureHuntEvent.Types.TreasureHuntStep>, IBufferMessage
			{
				// Token: 0x17000074 RID: 116
				// (get) Token: 0x060002DC RID: 732 RVA: 0x002F6CBC File Offset: 0x002F4EBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<TreasureHuntEvent.Types.TreasureHuntStep> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000075 RID: 117
				// (get) Token: 0x060002DD RID: 733 RVA: 0x002F6CCC File Offset: 0x002F4ECC
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

				// Token: 0x17000076 RID: 118
				// (get) Token: 0x060002DE RID: 734 RVA: 0x002F6CDC File Offset: 0x002F4EDC
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

				// Token: 0x060002DF RID: 735 RVA: 0x002F6CEC File Offset: 0x002F4EEC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TreasureHuntStep()
				{
				}

				// Token: 0x060002E0 RID: 736 RVA: 0x002F6CFC File Offset: 0x002F4EFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TreasureHuntStep(TreasureHuntEvent.Types.TreasureHuntStep other)
				{
				}

				// Token: 0x060002E1 RID: 737 RVA: 0x002F6D0C File Offset: 0x002F4F0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TreasureHuntEvent.Types.TreasureHuntStep Clone()
				{
					return null;
				}

				// Token: 0x17000077 RID: 119
				// (get) Token: 0x060002E2 RID: 738 RVA: 0x002F6D1C File Offset: 0x002F4F1C
				// (set) Token: 0x060002E3 RID: 739 RVA: 0x002F6D2C File Offset: 0x002F4F2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI FollowDirectionToPoi
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

				// Token: 0x17000078 RID: 120
				// (get) Token: 0x060002E4 RID: 740 RVA: 0x002F6D3C File Offset: 0x002F4F3C
				// (set) Token: 0x060002E5 RID: 741 RVA: 0x002F6D4C File Offset: 0x002F4F4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint FollowDirectionToHint
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

				// Token: 0x17000079 RID: 121
				// (get) Token: 0x060002E6 RID: 742 RVA: 0x002F6D5C File Offset: 0x002F4F5C
				// (set) Token: 0x060002E7 RID: 743 RVA: 0x002F6D6C File Offset: 0x002F4F6C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection FollowDirection
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

				// Token: 0x1700007A RID: 122
				// (get) Token: 0x060002E8 RID: 744 RVA: 0x002F6D7C File Offset: 0x002F4F7C
				// (set) Token: 0x060002E9 RID: 745 RVA: 0x002F6D8C File Offset: 0x002F4F8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight Fight
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

				// Token: 0x1700007B RID: 123
				// (get) Token: 0x060002EA RID: 746 RVA: 0x002F6D9C File Offset: 0x002F4F9C
				// (set) Token: 0x060002EB RID: 747 RVA: 0x002F6DAC File Offset: 0x002F4FAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig Dig
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

				// Token: 0x1700007C RID: 124
				// (get) Token: 0x060002EC RID: 748 RVA: 0x002F6DBC File Offset: 0x002F4FBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public TreasureHuntEvent.Types.TreasureHuntStep.StepOneofCase StepCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (TreasureHuntEvent.Types.TreasureHuntStep.StepOneofCase)null;
					}
				}

				// Token: 0x060002ED RID: 749 RVA: 0x002F6DD0 File Offset: 0x002F4FD0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearStep()
				{
				}

				// Token: 0x060002EE RID: 750 RVA: 0x002F6DE0 File Offset: 0x002F4FE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060002EF RID: 751 RVA: 0x002F6DF0 File Offset: 0x002F4FF0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(TreasureHuntEvent.Types.TreasureHuntStep other)
				{
					return true;
				}

				// Token: 0x060002F0 RID: 752 RVA: 0x002F6E00 File Offset: 0x002F5000
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060002F1 RID: 753 RVA: 0x002F6E10 File Offset: 0x002F5010
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060002F2 RID: 754 RVA: 0x002F6E20 File Offset: 0x002F5020
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060002F3 RID: 755 RVA: 0x002F6E30 File Offset: 0x002F5030
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060002F4 RID: 756 RVA: 0x002F6E40 File Offset: 0x002F5040
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060002F5 RID: 757 RVA: 0x002F6E50 File Offset: 0x002F5050
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(TreasureHuntEvent.Types.TreasureHuntStep other)
				{
				}

				// Token: 0x060002F6 RID: 758 RVA: 0x002F6E60 File Offset: 0x002F5060
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060002F7 RID: 759 RVA: 0x002F6E70 File Offset: 0x002F5070
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060002F8 RID: 760 RVA: 0x002F6E80 File Offset: 0x002F5080
				[MethodImpl(MethodImplOptions.NoInlining)]
				static TreasureHuntStep()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					for (;;)
					{
						int num2 = num;
						for (;;)
						{
							switch (num2)
							{
							case 1:
								TreasureHuntEvent.Types.TreasureHuntStep._parser = new MessageParser<TreasureHuntEvent.Types.TreasureHuntStep>(() => null);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								goto IL_35;
							case 3:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
								{
									num2 = 2;
									continue;
								}
								continue;
							case 4:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							return;
						}
						IL_35:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num = 4;
					}
				}

				// Token: 0x060002F9 RID: 761 RVA: 0x002F6F68 File Offset: 0x002F5168
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool L0uua0GThZhygJ0fX93i()
				{
					return true;
				}

				// Token: 0x060002FA RID: 762 RVA: 0x002F6F70 File Offset: 0x002F5170
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static TreasureHuntEvent.Types.TreasureHuntStep tOxgL5GTrTDYQCeoNZQU()
				{
					return null;
				}

				// Token: 0x0400012B RID: 299
				private static readonly MessageParser<TreasureHuntEvent.Types.TreasureHuntStep> _parser;

				// Token: 0x0400012C RID: 300
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400012D RID: 301
				public const int FollowDirectionToPoiFieldNumber = 1;

				// Token: 0x0400012E RID: 302
				public const int FollowDirectionToHintFieldNumber = 2;

				// Token: 0x0400012F RID: 303
				public const int FollowDirectionFieldNumber = 3;

				// Token: 0x04000130 RID: 304
				public const int FightFieldNumber = 4;

				// Token: 0x04000131 RID: 305
				public const int DigFieldNumber = 5;

				// Token: 0x04000132 RID: 306
				private object step_;

				// Token: 0x04000133 RID: 307
				private TreasureHuntEvent.Types.TreasureHuntStep.StepOneofCase stepCase_;

				// Token: 0x04000134 RID: 308
				private static TreasureHuntEvent.Types.TreasureHuntStep vkhuR1GTWXKmbemAk5Q8;

				// Token: 0x0200004B RID: 75
				public enum StepOneofCase
				{
					// Token: 0x04000136 RID: 310
					None,
					// Token: 0x04000137 RID: 311
					FollowDirectionToPoi,
					// Token: 0x04000138 RID: 312
					FollowDirectionToHint,
					// Token: 0x04000139 RID: 313
					FollowDirection,
					// Token: 0x0400013A RID: 314
					Fight,
					// Token: 0x0400013B RID: 315
					Dig
				}

				// Token: 0x0200004C RID: 76
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x060002FB RID: 763 RVA: 0x003105A0 File Offset: 0x0030E7A0
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x0200004D RID: 77
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class FollowDirectionToPOI : IMessage<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI>, IMessage, IEquatable<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI>, IDeepCloneable<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI>, IBufferMessage
					{
						// Token: 0x1700007D RID: 125
						// (get) Token: 0x060002FC RID: 764 RVA: 0x0031B0F0 File Offset: 0x003192F0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x1700007E RID: 126
						// (get) Token: 0x060002FD RID: 765 RVA: 0x0031B100 File Offset: 0x00319300
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

						// Token: 0x1700007F RID: 127
						// (get) Token: 0x060002FE RID: 766 RVA: 0x0031B110 File Offset: 0x00319310
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

						// Token: 0x060002FF RID: 767 RVA: 0x0031B120 File Offset: 0x00319320
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FollowDirectionToPOI()
						{
						}

						// Token: 0x06000300 RID: 768 RVA: 0x0031B130 File Offset: 0x00319330
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FollowDirectionToPOI(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI other)
						{
						}

						// Token: 0x06000301 RID: 769 RVA: 0x0031B140 File Offset: 0x00319340
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI Clone()
						{
							return null;
						}

						// Token: 0x17000080 RID: 128
						// (get) Token: 0x06000302 RID: 770 RVA: 0x0031B150 File Offset: 0x00319350
						// (set) Token: 0x06000303 RID: 771 RVA: 0x0031B164 File Offset: 0x00319364
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public Direction Direction
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (Direction)null;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17000081 RID: 129
						// (get) Token: 0x06000304 RID: 772 RVA: 0x0031B174 File Offset: 0x00319374
						// (set) Token: 0x06000305 RID: 773 RVA: 0x0031B184 File Offset: 0x00319384
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int PoiLabelId
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

						// Token: 0x06000306 RID: 774 RVA: 0x0031B194 File Offset: 0x00319394
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06000307 RID: 775 RVA: 0x0031B1A4 File Offset: 0x003193A4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI other)
						{
							return true;
						}

						// Token: 0x06000308 RID: 776 RVA: 0x0031B1B4 File Offset: 0x003193B4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06000309 RID: 777 RVA: 0x0031B1C4 File Offset: 0x003193C4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600030A RID: 778 RVA: 0x0031B1D4 File Offset: 0x003193D4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600030B RID: 779 RVA: 0x0031B1E4 File Offset: 0x003193E4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600030C RID: 780 RVA: 0x0031B1F4 File Offset: 0x003193F4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600030D RID: 781 RVA: 0x0031B204 File Offset: 0x00319404
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI other)
						{
						}

						// Token: 0x0600030E RID: 782 RVA: 0x0031B214 File Offset: 0x00319414
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600030F RID: 783 RVA: 0x0031B224 File Offset: 0x00319424
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06000310 RID: 784 RVA: 0x0031B234 File Offset: 0x00319434
						[MethodImpl(MethodImplOptions.NoInlining)]
						static FollowDirectionToPOI()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 3;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								default:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 4;
									break;
								case 1:
									return;
								case 2:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
									{
										num2 = 0;
									}
									break;
								case 3:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
									{
										num2 = 1;
									}
									break;
								case 4:
									TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI._parser = new MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI>(() => null);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
									{
										num2 = 0;
									}
									break;
								}
							}
						}

						// Token: 0x06000311 RID: 785 RVA: 0x0031B318 File Offset: 0x00319518
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool emxBqkgOD2Oal1tSlr6A()
						{
							return true;
						}

						// Token: 0x06000312 RID: 786 RVA: 0x0031B320 File Offset: 0x00319520
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI sFsEVrgOtPMj0nEg5TMf()
						{
							return null;
						}

						// Token: 0x0400013C RID: 316
						private static readonly MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI> _parser;

						// Token: 0x0400013D RID: 317
						private UnknownFieldSet _unknownFields;

						// Token: 0x0400013E RID: 318
						public const int DirectionFieldNumber = 1;

						// Token: 0x0400013F RID: 319
						private Direction direction_;

						// Token: 0x04000140 RID: 320
						public const int PoiLabelIdFieldNumber = 2;

						// Token: 0x04000141 RID: 321
						private int poiLabelId_;

						// Token: 0x04000142 RID: 322
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToPOI kfmNg9gOCWalaoKgHm6p;
					}

					// Token: 0x0200004F RID: 79
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class FollowDirectionToHint : IMessage<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint>, IMessage, IEquatable<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint>, IDeepCloneable<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint>, IBufferMessage
					{
						// Token: 0x17000082 RID: 130
						// (get) Token: 0x06000318 RID: 792 RVA: 0x0031B328 File Offset: 0x00319528
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000083 RID: 131
						// (get) Token: 0x06000319 RID: 793 RVA: 0x0031B338 File Offset: 0x00319538
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

						// Token: 0x17000084 RID: 132
						// (get) Token: 0x0600031A RID: 794 RVA: 0x0031B348 File Offset: 0x00319548
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

						// Token: 0x0600031B RID: 795 RVA: 0x0031B358 File Offset: 0x00319558
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FollowDirectionToHint()
						{
						}

						// Token: 0x0600031C RID: 796 RVA: 0x0031B368 File Offset: 0x00319568
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FollowDirectionToHint(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint other)
						{
						}

						// Token: 0x0600031D RID: 797 RVA: 0x0031B378 File Offset: 0x00319578
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint Clone()
						{
							return null;
						}

						// Token: 0x17000085 RID: 133
						// (get) Token: 0x0600031E RID: 798 RVA: 0x0031B388 File Offset: 0x00319588
						// (set) Token: 0x0600031F RID: 799 RVA: 0x0031B39C File Offset: 0x0031959C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public Direction Direction
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (Direction)null;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x17000086 RID: 134
						// (get) Token: 0x06000320 RID: 800 RVA: 0x0031B3AC File Offset: 0x003195AC
						// (set) Token: 0x06000321 RID: 801 RVA: 0x0031B3BC File Offset: 0x003195BC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public int NpcId
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

						// Token: 0x06000322 RID: 802 RVA: 0x0031B3CC File Offset: 0x003195CC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06000323 RID: 803 RVA: 0x0031B3DC File Offset: 0x003195DC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint other)
						{
							return true;
						}

						// Token: 0x06000324 RID: 804 RVA: 0x0031B3EC File Offset: 0x003195EC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06000325 RID: 805 RVA: 0x0031B3FC File Offset: 0x003195FC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06000326 RID: 806 RVA: 0x0031B40C File Offset: 0x0031960C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06000327 RID: 807 RVA: 0x0031B41C File Offset: 0x0031961C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06000328 RID: 808 RVA: 0x0031B42C File Offset: 0x0031962C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06000329 RID: 809 RVA: 0x0031B43C File Offset: 0x0031963C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint other)
						{
						}

						// Token: 0x0600032A RID: 810 RVA: 0x0031B44C File Offset: 0x0031964C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600032B RID: 811 RVA: 0x0031B45C File Offset: 0x0031965C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x0600032C RID: 812 RVA: 0x0031B46C File Offset: 0x0031966C
						[MethodImpl(MethodImplOptions.NoInlining)]
						static FollowDirectionToHint()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							for (;;)
							{
								int num2 = num;
								for (;;)
								{
									switch (num2)
									{
									default:
										TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint._parser = new MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint>(() => null);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
										{
											num2 = 0;
										}
										break;
									case 1:
										return;
									case 2:
										UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
										{
											num2 = 0;
										}
										break;
									case 3:
										goto IL_82;
									case 4:
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
										num2 = 3;
										break;
									}
								}
								IL_82:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num = 2;
							}
						}

						// Token: 0x0600032D RID: 813 RVA: 0x0031B53C File Offset: 0x0031973C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool zNTo64gOQCHMY0lsovx5()
						{
							return true;
						}

						// Token: 0x0600032E RID: 814 RVA: 0x0031B544 File Offset: 0x00319744
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint ewbdQugO7K3jmlQQfk6l()
						{
							return null;
						}

						// Token: 0x04000145 RID: 325
						private static readonly MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint> _parser;

						// Token: 0x04000146 RID: 326
						private UnknownFieldSet _unknownFields;

						// Token: 0x04000147 RID: 327
						public const int DirectionFieldNumber = 1;

						// Token: 0x04000148 RID: 328
						private Direction direction_;

						// Token: 0x04000149 RID: 329
						public const int NpcIdFieldNumber = 2;

						// Token: 0x0400014A RID: 330
						private int npcId_;

						// Token: 0x0400014B RID: 331
						private static TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirectionToHint S7YH28gOwZ5e0dNvOWev;
					}

					// Token: 0x02000051 RID: 81
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class FollowDirection : IMessage<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection>, IMessage, IEquatable<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection>, IDeepCloneable<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection>, IBufferMessage
					{
						// Token: 0x17000087 RID: 135
						// (get) Token: 0x06000334 RID: 820 RVA: 0x0031B54C File Offset: 0x0031974C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000088 RID: 136
						// (get) Token: 0x06000335 RID: 821 RVA: 0x0031B55C File Offset: 0x0031975C
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

						// Token: 0x17000089 RID: 137
						// (get) Token: 0x06000336 RID: 822 RVA: 0x0031B56C File Offset: 0x0031976C
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

						// Token: 0x06000337 RID: 823 RVA: 0x0031B57C File Offset: 0x0031977C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FollowDirection()
						{
						}

						// Token: 0x06000338 RID: 824 RVA: 0x0031B58C File Offset: 0x0031978C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public FollowDirection(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection other)
						{
						}

						// Token: 0x06000339 RID: 825 RVA: 0x0031B59C File Offset: 0x0031979C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection Clone()
						{
							return null;
						}

						// Token: 0x1700008A RID: 138
						// (get) Token: 0x0600033A RID: 826 RVA: 0x0031B5AC File Offset: 0x003197AC
						// (set) Token: 0x0600033B RID: 827 RVA: 0x0031B5C0 File Offset: 0x003197C0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public Direction Direction
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return (Direction)null;
							}
							[MethodImpl(MethodImplOptions.NoInlining)]
							set
							{
							}
						}

						// Token: 0x1700008B RID: 139
						// (get) Token: 0x0600033C RID: 828 RVA: 0x0031B5D0 File Offset: 0x003197D0
						// (set) Token: 0x0600033D RID: 829 RVA: 0x0031B5E0 File Offset: 0x003197E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int MapCount
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

						// Token: 0x0600033E RID: 830 RVA: 0x0031B5F0 File Offset: 0x003197F0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600033F RID: 831 RVA: 0x0031B600 File Offset: 0x00319800
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection other)
						{
							return true;
						}

						// Token: 0x06000340 RID: 832 RVA: 0x0031B610 File Offset: 0x00319810
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06000341 RID: 833 RVA: 0x0031B620 File Offset: 0x00319820
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06000342 RID: 834 RVA: 0x0031B630 File Offset: 0x00319830
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06000343 RID: 835 RVA: 0x0031B640 File Offset: 0x00319840
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06000344 RID: 836 RVA: 0x0031B650 File Offset: 0x00319850
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06000345 RID: 837 RVA: 0x0031B660 File Offset: 0x00319860
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection other)
						{
						}

						// Token: 0x06000346 RID: 838 RVA: 0x0031B670 File Offset: 0x00319870
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06000347 RID: 839 RVA: 0x0031B680 File Offset: 0x00319880
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06000348 RID: 840 RVA: 0x0031B690 File Offset: 0x00319890
						[MethodImpl(MethodImplOptions.NoInlining)]
						static FollowDirection()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 3;
							for (;;)
							{
								int num2 = num;
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_5F;
									case 2:
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 3:
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
										num2 = 2;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
										{
											num2 = 2;
											continue;
										}
										continue;
									case 4:
										return;
									}
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
									{
										num2 = 0;
									}
								}
								IL_5F:
								TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection._parser = new MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection>(() => null);
								num = 4;
							}
						}

						// Token: 0x06000349 RID: 841 RVA: 0x0031B778 File Offset: 0x00319978
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool u4SwxRgOpJg6nCIUabng()
						{
							return true;
						}

						// Token: 0x0600034A RID: 842 RVA: 0x0031B780 File Offset: 0x00319980
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection U7F8tfgOH61VNCQeoVK4()
						{
							return null;
						}

						// Token: 0x0400014E RID: 334
						private static readonly MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection> _parser;

						// Token: 0x0400014F RID: 335
						private UnknownFieldSet _unknownFields;

						// Token: 0x04000150 RID: 336
						public const int DirectionFieldNumber = 1;

						// Token: 0x04000151 RID: 337
						private Direction direction_;

						// Token: 0x04000152 RID: 338
						public const int MapCountFieldNumber = 2;

						// Token: 0x04000153 RID: 339
						private int mapCount_;

						// Token: 0x04000154 RID: 340
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.FollowDirection xWfXo9gOTUic5d97NiI7;
					}

					// Token: 0x02000053 RID: 83
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Fight : IMessage<TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight>, IMessage, IEquatable<TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight>, IDeepCloneable<TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight>, IBufferMessage
					{
						// Token: 0x1700008C RID: 140
						// (get) Token: 0x06000350 RID: 848 RVA: 0x0031B788 File Offset: 0x00319988
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x1700008D RID: 141
						// (get) Token: 0x06000351 RID: 849 RVA: 0x0031B798 File Offset: 0x00319998
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

						// Token: 0x1700008E RID: 142
						// (get) Token: 0x06000352 RID: 850 RVA: 0x0031B7A8 File Offset: 0x003199A8
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

						// Token: 0x06000353 RID: 851 RVA: 0x0031B7B8 File Offset: 0x003199B8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Fight()
						{
						}

						// Token: 0x06000354 RID: 852 RVA: 0x0031B7C8 File Offset: 0x003199C8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Fight(TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight other)
						{
						}

						// Token: 0x06000355 RID: 853 RVA: 0x0031B7D8 File Offset: 0x003199D8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight Clone()
						{
							return null;
						}

						// Token: 0x06000356 RID: 854 RVA: 0x0031B7E8 File Offset: 0x003199E8
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06000357 RID: 855 RVA: 0x0031B7F8 File Offset: 0x003199F8
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight other)
						{
							return true;
						}

						// Token: 0x06000358 RID: 856 RVA: 0x0031B808 File Offset: 0x00319A08
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06000359 RID: 857 RVA: 0x0031B818 File Offset: 0x00319A18
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x0600035A RID: 858 RVA: 0x0031B828 File Offset: 0x00319A28
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x0600035B RID: 859 RVA: 0x0031B838 File Offset: 0x00319A38
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x0600035C RID: 860 RVA: 0x0031B848 File Offset: 0x00319A48
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x0600035D RID: 861 RVA: 0x0031B858 File Offset: 0x00319A58
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight other)
						{
						}

						// Token: 0x0600035E RID: 862 RVA: 0x0031B868 File Offset: 0x00319A68
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x0600035F RID: 863 RVA: 0x0031B878 File Offset: 0x00319A78
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06000360 RID: 864 RVA: 0x0031B888 File Offset: 0x00319A88
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Fight()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 2;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								default:
									return;
								case 1:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 3;
									break;
								case 2:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
									{
										num2 = 1;
									}
									break;
								case 3:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 4;
									break;
								case 4:
									TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight._parser = new MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight>(() => null);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
									{
										num2 = 0;
									}
									break;
								}
							}
						}

						// Token: 0x06000361 RID: 865 RVA: 0x0031B954 File Offset: 0x00319B54
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool nfv4L9gObel8EKUvrnUD()
						{
							return true;
						}

						// Token: 0x06000362 RID: 866 RVA: 0x0031B95C File Offset: 0x00319B5C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight oa0i5agOiy1L9ulTbWaw()
						{
							return null;
						}

						// Token: 0x04000157 RID: 343
						private static readonly MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight> _parser;

						// Token: 0x04000158 RID: 344
						private UnknownFieldSet _unknownFields;

						// Token: 0x04000159 RID: 345
						private static TreasureHuntEvent.Types.TreasureHuntStep.Types.Fight LJ8nWGgOYWUlJLXOXZJy;
					}

					// Token: 0x02000055 RID: 85
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class Dig : IMessage<TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig>, IMessage, IEquatable<TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig>, IDeepCloneable<TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig>, IBufferMessage
					{
						// Token: 0x1700008F RID: 143
						// (get) Token: 0x06000368 RID: 872 RVA: 0x0031B964 File Offset: 0x00319B64
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000090 RID: 144
						// (get) Token: 0x06000369 RID: 873 RVA: 0x0031B974 File Offset: 0x00319B74
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

						// Token: 0x17000091 RID: 145
						// (get) Token: 0x0600036A RID: 874 RVA: 0x0031B984 File Offset: 0x00319B84
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

						// Token: 0x0600036B RID: 875 RVA: 0x0031B994 File Offset: 0x00319B94
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Dig()
						{
						}

						// Token: 0x0600036C RID: 876 RVA: 0x0031B9A4 File Offset: 0x00319BA4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public Dig(TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig other)
						{
						}

						// Token: 0x0600036D RID: 877 RVA: 0x0031B9B4 File Offset: 0x00319BB4
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig Clone()
						{
							return null;
						}

						// Token: 0x0600036E RID: 878 RVA: 0x0031B9C4 File Offset: 0x00319BC4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x0600036F RID: 879 RVA: 0x0031B9D4 File Offset: 0x00319BD4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig other)
						{
							return true;
						}

						// Token: 0x06000370 RID: 880 RVA: 0x0031B9E4 File Offset: 0x00319BE4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06000371 RID: 881 RVA: 0x0031B9F4 File Offset: 0x00319BF4
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06000372 RID: 882 RVA: 0x0031BA04 File Offset: 0x00319C04
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06000373 RID: 883 RVA: 0x0031BA14 File Offset: 0x00319C14
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06000374 RID: 884 RVA: 0x0031BA24 File Offset: 0x00319C24
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06000375 RID: 885 RVA: 0x0031BA34 File Offset: 0x00319C34
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig other)
						{
						}

						// Token: 0x06000376 RID: 886 RVA: 0x0031BA44 File Offset: 0x00319C44
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06000377 RID: 887 RVA: 0x0031BA54 File Offset: 0x00319C54
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06000378 RID: 888 RVA: 0x0031BA64 File Offset: 0x00319C64
						[MethodImpl(MethodImplOptions.NoInlining)]
						static Dig()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 3;
							for (;;)
							{
								int num2 = num;
								for (;;)
								{
									switch (num2)
									{
									case 1:
										UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
										num2 = 4;
										continue;
									case 2:
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
										{
											num2 = 1;
											continue;
										}
										continue;
									case 3:
										goto IL_6F;
									case 4:
										TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig._parser = new MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig>(() => null);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									}
									return;
								}
								IL_6F:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num = 2;
							}
						}

						// Token: 0x06000379 RID: 889 RVA: 0x0031BB34 File Offset: 0x00319D34
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool jmhoA9gOSjrKatp0PrBm()
						{
							return true;
						}

						// Token: 0x0600037A RID: 890 RVA: 0x0031BB3C File Offset: 0x00319D3C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig u9jyJbgOMcXyZT7eAkjC()
						{
							return null;
						}

						// Token: 0x0400015C RID: 348
						private static readonly MessageParser<TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig> _parser;

						// Token: 0x0400015D RID: 349
						private UnknownFieldSet _unknownFields;

						// Token: 0x0400015E RID: 350
						internal static TreasureHuntEvent.Types.TreasureHuntStep.Types.Dig biSxIpgOPR47A1qobbUQ;
					}
				}
			}

			// Token: 0x02000058 RID: 88
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class TreasureHuntFlag : IMessage<TreasureHuntEvent.Types.TreasureHuntFlag>, IMessage, IEquatable<TreasureHuntEvent.Types.TreasureHuntFlag>, IDeepCloneable<TreasureHuntEvent.Types.TreasureHuntFlag>, IBufferMessage
			{
				// Token: 0x17000092 RID: 146
				// (get) Token: 0x06000385 RID: 901 RVA: 0x002F6F78 File Offset: 0x002F5178
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<TreasureHuntEvent.Types.TreasureHuntFlag> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000093 RID: 147
				// (get) Token: 0x06000386 RID: 902 RVA: 0x002F6F88 File Offset: 0x002F5188
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

				// Token: 0x17000094 RID: 148
				// (get) Token: 0x06000387 RID: 903 RVA: 0x002F6F98 File Offset: 0x002F5198
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

				// Token: 0x06000388 RID: 904 RVA: 0x002F6FA8 File Offset: 0x002F51A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TreasureHuntFlag()
				{
				}

				// Token: 0x06000389 RID: 905 RVA: 0x002F6FB8 File Offset: 0x002F51B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TreasureHuntFlag(TreasureHuntEvent.Types.TreasureHuntFlag other)
				{
				}

				// Token: 0x0600038A RID: 906 RVA: 0x002F6FC8 File Offset: 0x002F51C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TreasureHuntEvent.Types.TreasureHuntFlag Clone()
				{
					return null;
				}

				// Token: 0x17000095 RID: 149
				// (get) Token: 0x0600038B RID: 907 RVA: 0x002F6FD8 File Offset: 0x002F51D8
				// (set) Token: 0x0600038C RID: 908 RVA: 0x002F6FE8 File Offset: 0x002F51E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long MapId
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

				// Token: 0x17000096 RID: 150
				// (get) Token: 0x0600038D RID: 909 RVA: 0x002F6FF8 File Offset: 0x002F51F8
				// (set) Token: 0x0600038E RID: 910 RVA: 0x002F700C File Offset: 0x002F520C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public TreasureHuntEvent.Types.TreasureHuntFlag.Types.FlagState State
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (TreasureHuntEvent.Types.TreasureHuntFlag.Types.FlagState)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x0600038F RID: 911 RVA: 0x002F701C File Offset: 0x002F521C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06000390 RID: 912 RVA: 0x002F702C File Offset: 0x002F522C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(TreasureHuntEvent.Types.TreasureHuntFlag other)
				{
					return true;
				}

				// Token: 0x06000391 RID: 913 RVA: 0x002F703C File Offset: 0x002F523C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06000392 RID: 914 RVA: 0x002F704C File Offset: 0x002F524C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06000393 RID: 915 RVA: 0x002F705C File Offset: 0x002F525C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06000394 RID: 916 RVA: 0x002F706C File Offset: 0x002F526C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06000395 RID: 917 RVA: 0x002F707C File Offset: 0x002F527C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06000396 RID: 918 RVA: 0x002F708C File Offset: 0x002F528C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(TreasureHuntEvent.Types.TreasureHuntFlag other)
				{
				}

				// Token: 0x06000397 RID: 919 RVA: 0x002F709C File Offset: 0x002F529C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06000398 RID: 920 RVA: 0x002F70AC File Offset: 0x002F52AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06000399 RID: 921 RVA: 0x002F70BC File Offset: 0x002F52BC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static TreasureHuntFlag()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 3:
							return;
						case 4:
							TreasureHuntEvent.Types.TreasureHuntFlag._parser = new MessageParser<TreasureHuntEvent.Types.TreasureHuntFlag>(() => null);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x0600039A RID: 922 RVA: 0x002F7188 File Offset: 0x002F5388
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool gYmrEFGT0vfW2FAuA7U4()
				{
					return true;
				}

				// Token: 0x0600039B RID: 923 RVA: 0x002F7190 File Offset: 0x002F5390
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static TreasureHuntEvent.Types.TreasureHuntFlag hKdce9GTC88W69ywlhsv()
				{
					return null;
				}

				// Token: 0x04000163 RID: 355
				private static readonly MessageParser<TreasureHuntEvent.Types.TreasureHuntFlag> _parser;

				// Token: 0x04000164 RID: 356
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000165 RID: 357
				public const int MapIdFieldNumber = 1;

				// Token: 0x04000166 RID: 358
				private long mapId_;

				// Token: 0x04000167 RID: 359
				public const int StateFieldNumber = 2;

				// Token: 0x04000168 RID: 360
				private TreasureHuntEvent.Types.TreasureHuntFlag.Types.FlagState state_;

				// Token: 0x04000169 RID: 361
				internal static TreasureHuntEvent.Types.TreasureHuntFlag keyxsKGTViLn9sDW8KwR;

				// Token: 0x02000059 RID: 89
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x0600039C RID: 924 RVA: 0x0031069C File Offset: 0x0030E89C
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x0200005A RID: 90
					public enum FlagState
					{
						// Token: 0x0400016B RID: 363
						[OriginalName("UNKNOWN")]
						Unknown,
						// Token: 0x0400016C RID: 364
						[OriginalName("OK")]
						Ok,
						// Token: 0x0400016D RID: 365
						[OriginalName("WRONG")]
						Wrong
					}
				}
			}
		}
	}
}
