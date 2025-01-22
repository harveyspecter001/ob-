using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001AB RID: 427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestsEvent : IMessage<QuestsEvent>, IMessage, IEquatable<QuestsEvent>, IDeepCloneable<QuestsEvent>, IBufferMessage
	{
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x001A5008 File Offset: 0x001A3208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x001A5018 File Offset: 0x001A3218
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

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x001A5028 File Offset: 0x001A3228
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

		// Token: 0x060013E2 RID: 5090 RVA: 0x001A5038 File Offset: 0x001A3238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsEvent()
		{
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x001A5048 File Offset: 0x001A3248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsEvent(QuestsEvent other)
		{
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x001A5058 File Offset: 0x001A3258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x001A5068 File Offset: 0x001A3268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<QuestsEvent.Types.QuestFinished> FinishedQuests
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x001A5078 File Offset: 0x001A3278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestActive> ActiveQuests
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x001A5088 File Offset: 0x001A3288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReinitializedDoneQuestsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x001A5098 File Offset: 0x001A3298
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x001A50A8 File Offset: 0x001A32A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x001A50B8 File Offset: 0x001A32B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x001A50C8 File Offset: 0x001A32C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPlayerId()
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x001A50D8 File Offset: 0x001A32D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x001A50E8 File Offset: 0x001A32E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestsEvent other)
		{
			return true;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x001A50F8 File Offset: 0x001A32F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x001A5108 File Offset: 0x001A3308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x001A5118 File Offset: 0x001A3318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x001A5128 File Offset: 0x001A3328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x001A5138 File Offset: 0x001A3338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x001A5148 File Offset: 0x001A3348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestsEvent other)
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x001A5158 File Offset: 0x001A3358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x001A5168 File Offset: 0x001A3368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x001A5178 File Offset: 0x001A3378
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 7;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					QuestsEvent._repeated_activeQuests_codec = FieldCodec.ForMessage<QuestActive>(18U, jv9ugBbiaJDSaW8ht86.XVInXhlssT(jv9ugBbiaJDSaW8ht86.A5IbPdxby2));
					num2 = 4;
					continue;
				case 2:
					QuestsEvent._repeated_finishedQuests_codec = FieldCodec.ForMessage<QuestsEvent.Types.QuestFinished>(10U, MajB7QbWxnXvQUXAw3S.XVInXhlssT(MajB7QbWxnXvQUXAw3S.CPCbhZOXh5));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					QuestsEvent.PlayerIdDefaultValue = 0L;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					QuestsEvent._repeated_reinitializedDoneQuestsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					QuestsEvent._parser = new MessageParser<QuestsEvent>(() => null);
					num2 = 2;
					continue;
				case 6:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 8;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
				case 7:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 6;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 8:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				}
				break;
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x001A5300 File Offset: 0x001A3500
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C8CmcuOoVNKAnZArYxoJ()
		{
			return true;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x001A5308 File Offset: 0x001A3508
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestsEvent dFxLVrOo0fr09nB4AvfL()
		{
			return null;
		}

		// Token: 0x0400071A RID: 1818
		private static readonly MessageParser<QuestsEvent> _parser;

		// Token: 0x0400071B RID: 1819
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400071C RID: 1820
		private int _hasBits0;

		// Token: 0x0400071D RID: 1821
		public const int FinishedQuestsFieldNumber = 1;

		// Token: 0x0400071E RID: 1822
		private static readonly FieldCodec<QuestsEvent.Types.QuestFinished> _repeated_finishedQuests_codec;

		// Token: 0x0400071F RID: 1823
		private readonly RepeatedField<QuestsEvent.Types.QuestFinished> finishedQuests_;

		// Token: 0x04000720 RID: 1824
		public const int ActiveQuestsFieldNumber = 2;

		// Token: 0x04000721 RID: 1825
		private static readonly FieldCodec<QuestActive> _repeated_activeQuests_codec;

		// Token: 0x04000722 RID: 1826
		private readonly RepeatedField<QuestActive> activeQuests_;

		// Token: 0x04000723 RID: 1827
		public const int ReinitializedDoneQuestsIdFieldNumber = 3;

		// Token: 0x04000724 RID: 1828
		private static readonly FieldCodec<int> _repeated_reinitializedDoneQuestsId_codec;

		// Token: 0x04000725 RID: 1829
		private readonly RepeatedField<int> reinitializedDoneQuestsId_;

		// Token: 0x04000726 RID: 1830
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04000727 RID: 1831
		private static readonly long PlayerIdDefaultValue;

		// Token: 0x04000728 RID: 1832
		private long playerId_;

		// Token: 0x04000729 RID: 1833
		private static QuestsEvent l701AGOorPfAIdHqp1Lq;

		// Token: 0x020001AC RID: 428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060013F9 RID: 5113 RVA: 0x002AF024 File Offset: 0x002AD224
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001AD RID: 429
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class QuestFinished : IMessage<QuestsEvent.Types.QuestFinished>, IMessage, IEquatable<QuestsEvent.Types.QuestFinished>, IDeepCloneable<QuestsEvent.Types.QuestFinished>, IBufferMessage
			{
				// Token: 0x1700038A RID: 906
				// (get) Token: 0x060013FA RID: 5114 RVA: 0x002F7B14 File Offset: 0x002F5D14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<QuestsEvent.Types.QuestFinished> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700038B RID: 907
				// (get) Token: 0x060013FB RID: 5115 RVA: 0x002F7B24 File Offset: 0x002F5D24
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

				// Token: 0x1700038C RID: 908
				// (get) Token: 0x060013FC RID: 5116 RVA: 0x002F7B34 File Offset: 0x002F5D34
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

				// Token: 0x060013FD RID: 5117 RVA: 0x002F7B44 File Offset: 0x002F5D44
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public QuestFinished()
				{
				}

				// Token: 0x060013FE RID: 5118 RVA: 0x002F7B54 File Offset: 0x002F5D54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public QuestFinished(QuestsEvent.Types.QuestFinished other)
				{
				}

				// Token: 0x060013FF RID: 5119 RVA: 0x002F7B64 File Offset: 0x002F5D64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public QuestsEvent.Types.QuestFinished Clone()
				{
					return null;
				}

				// Token: 0x1700038D RID: 909
				// (get) Token: 0x06001400 RID: 5120 RVA: 0x002F7B74 File Offset: 0x002F5D74
				// (set) Token: 0x06001401 RID: 5121 RVA: 0x002F7B84 File Offset: 0x002F5D84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int QuestId
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

				// Token: 0x1700038E RID: 910
				// (get) Token: 0x06001402 RID: 5122 RVA: 0x002F7B94 File Offset: 0x002F5D94
				// (set) Token: 0x06001403 RID: 5123 RVA: 0x002F7BA4 File Offset: 0x002F5DA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int FinishedCount
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

				// Token: 0x06001404 RID: 5124 RVA: 0x002F7BB4 File Offset: 0x002F5DB4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001405 RID: 5125 RVA: 0x002F7BC4 File Offset: 0x002F5DC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(QuestsEvent.Types.QuestFinished other)
				{
					return true;
				}

				// Token: 0x06001406 RID: 5126 RVA: 0x002F7BD4 File Offset: 0x002F5DD4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06001407 RID: 5127 RVA: 0x002F7BE4 File Offset: 0x002F5DE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06001408 RID: 5128 RVA: 0x002F7BF4 File Offset: 0x002F5DF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06001409 RID: 5129 RVA: 0x002F7C04 File Offset: 0x002F5E04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600140A RID: 5130 RVA: 0x002F7C14 File Offset: 0x002F5E14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600140B RID: 5131 RVA: 0x002F7C24 File Offset: 0x002F5E24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(QuestsEvent.Types.QuestFinished other)
				{
				}

				// Token: 0x0600140C RID: 5132 RVA: 0x002F7C34 File Offset: 0x002F5E34
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600140D RID: 5133 RVA: 0x002F7C44 File Offset: 0x002F5E44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600140E RID: 5134 RVA: 0x002F7C54 File Offset: 0x002F5E54
				[MethodImpl(MethodImplOptions.NoInlining)]
				static QuestFinished()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							QuestsEvent.Types.QuestFinished._parser = new MessageParser<QuestsEvent.Types.QuestFinished>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
							{
								num2 = 2;
							}
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							break;
						}
					}
				}

				// Token: 0x0600140F RID: 5135 RVA: 0x002F7D38 File Offset: 0x002F5F38
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool P2jV8UGp4vdxERMWnfsa()
				{
					return true;
				}

				// Token: 0x06001410 RID: 5136 RVA: 0x002F7D40 File Offset: 0x002F5F40
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static QuestsEvent.Types.QuestFinished KecgsbGpj2ShKPXWytXa()
				{
					return null;
				}

				// Token: 0x0400072A RID: 1834
				private static readonly MessageParser<QuestsEvent.Types.QuestFinished> _parser;

				// Token: 0x0400072B RID: 1835
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400072C RID: 1836
				public const int QuestIdFieldNumber = 1;

				// Token: 0x0400072D RID: 1837
				private int questId_;

				// Token: 0x0400072E RID: 1838
				public const int FinishedCountFieldNumber = 2;

				// Token: 0x0400072F RID: 1839
				private int finishedCount_;

				// Token: 0x04000730 RID: 1840
				internal static QuestsEvent.Types.QuestFinished mJsZ3NGpxZZhaKVtfepP;
			}
		}
	}
}
