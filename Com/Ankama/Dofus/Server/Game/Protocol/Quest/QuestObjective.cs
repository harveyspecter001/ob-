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
	// Token: 0x020001C3 RID: 451
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestObjective : IMessage<QuestObjective>, IMessage, IEquatable<QuestObjective>, IDeepCloneable<QuestObjective>, IBufferMessage
	{
		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x001A6438 File Offset: 0x001A4638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<QuestObjective> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x001A6448 File Offset: 0x001A4648
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

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x001A6458 File Offset: 0x001A4658
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

		// Token: 0x06001515 RID: 5397 RVA: 0x001A6468 File Offset: 0x001A4668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjective()
		{
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x001A6478 File Offset: 0x001A4678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjective(QuestObjective other)
		{
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x001A6488 File Offset: 0x001A4688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjective Clone()
		{
			return null;
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x001A6498 File Offset: 0x001A4698
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x001A64A8 File Offset: 0x001A46A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectiveId
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x001A64B8 File Offset: 0x001A46B8
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x001A64C8 File Offset: 0x001A46C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ObjectiveReached
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x001A64D8 File Offset: 0x001A46D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> DialogParams
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x001A64E8 File Offset: 0x001A46E8
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x001A64F8 File Offset: 0x001A46F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public QuestObjective.Types.Completion Completion
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

		// Token: 0x0600151F RID: 5407 RVA: 0x001A6508 File Offset: 0x001A4708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x001A6518 File Offset: 0x001A4718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestObjective other)
		{
			return true;
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x001A6528 File Offset: 0x001A4728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x001A6538 File Offset: 0x001A4738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x001A6548 File Offset: 0x001A4748
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x001A6558 File Offset: 0x001A4758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x001A6568 File Offset: 0x001A4768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x001A6578 File Offset: 0x001A4778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestObjective other)
		{
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x001A6588 File Offset: 0x001A4788
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x001A6598 File Offset: 0x001A4798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x001A65A8 File Offset: 0x001A47A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestObjective()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_5D;
					case 3:
						return;
					case 4:
						QuestObjective._parser = new MessageParser<QuestObjective>(() => null);
						num2 = 5;
						continue;
					case 5:
						QuestObjective._repeated_dialogParams_codec = UhvKwdMSigIudSGM6ge.XVInXhlssT(26U, UhvKwdMSigIudSGM6ge.BvYMM58cmD);
						num2 = 3;
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 2;
					}
				}
				IL_5D:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x001A6698 File Offset: 0x001A4898
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m6UH6cO1BOS1BHm4La1W()
		{
			return true;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x001A66A0 File Offset: 0x001A48A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestObjective FuG5sFO1e9dyACkShkQg()
		{
			return null;
		}

		// Token: 0x04000784 RID: 1924
		private static readonly MessageParser<QuestObjective> _parser;

		// Token: 0x04000785 RID: 1925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000786 RID: 1926
		public const int ObjectiveIdFieldNumber = 1;

		// Token: 0x04000787 RID: 1927
		private int objectiveId_;

		// Token: 0x04000788 RID: 1928
		public const int ObjectiveReachedFieldNumber = 2;

		// Token: 0x04000789 RID: 1929
		private bool objectiveReached_;

		// Token: 0x0400078A RID: 1930
		public const int DialogParamsFieldNumber = 3;

		// Token: 0x0400078B RID: 1931
		private static readonly FieldCodec<string> _repeated_dialogParams_codec;

		// Token: 0x0400078C RID: 1932
		private readonly RepeatedField<string> dialogParams_;

		// Token: 0x0400078D RID: 1933
		public const int CompletionFieldNumber = 4;

		// Token: 0x0400078E RID: 1934
		private QuestObjective.Types.Completion completion_;

		// Token: 0x0400078F RID: 1935
		internal static QuestObjective dy6svtO1Ajr882ohxxIr;

		// Token: 0x020001C4 RID: 452
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600152C RID: 5420 RVA: 0x002AF8DC File Offset: 0x002ADADC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020001C5 RID: 453
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Completion : IMessage<QuestObjective.Types.Completion>, IMessage, IEquatable<QuestObjective.Types.Completion>, IDeepCloneable<QuestObjective.Types.Completion>, IBufferMessage
			{
				// Token: 0x170003C1 RID: 961
				// (get) Token: 0x0600152D RID: 5421 RVA: 0x002F7F7C File Offset: 0x002F617C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<QuestObjective.Types.Completion> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x170003C2 RID: 962
				// (get) Token: 0x0600152E RID: 5422 RVA: 0x002F7F8C File Offset: 0x002F618C
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

				// Token: 0x170003C3 RID: 963
				// (get) Token: 0x0600152F RID: 5423 RVA: 0x002F7F9C File Offset: 0x002F619C
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

				// Token: 0x06001530 RID: 5424 RVA: 0x002F7FAC File Offset: 0x002F61AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Completion()
				{
				}

				// Token: 0x06001531 RID: 5425 RVA: 0x002F7FBC File Offset: 0x002F61BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Completion(QuestObjective.Types.Completion other)
				{
				}

				// Token: 0x06001532 RID: 5426 RVA: 0x002F7FCC File Offset: 0x002F61CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public QuestObjective.Types.Completion Clone()
				{
					return null;
				}

				// Token: 0x170003C4 RID: 964
				// (get) Token: 0x06001533 RID: 5427 RVA: 0x002F7FDC File Offset: 0x002F61DC
				// (set) Token: 0x06001534 RID: 5428 RVA: 0x002F7FEC File Offset: 0x002F61EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CurrentCompletion
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

				// Token: 0x170003C5 RID: 965
				// (get) Token: 0x06001535 RID: 5429 RVA: 0x002F7FFC File Offset: 0x002F61FC
				// (set) Token: 0x06001536 RID: 5430 RVA: 0x002F800C File Offset: 0x002F620C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MaxCompletion
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

				// Token: 0x06001537 RID: 5431 RVA: 0x002F801C File Offset: 0x002F621C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06001538 RID: 5432 RVA: 0x002F802C File Offset: 0x002F622C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(QuestObjective.Types.Completion other)
				{
					return true;
				}

				// Token: 0x06001539 RID: 5433 RVA: 0x002F803C File Offset: 0x002F623C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600153A RID: 5434 RVA: 0x002F804C File Offset: 0x002F624C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600153B RID: 5435 RVA: 0x002F805C File Offset: 0x002F625C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600153C RID: 5436 RVA: 0x002F806C File Offset: 0x002F626C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600153D RID: 5437 RVA: 0x002F807C File Offset: 0x002F627C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600153E RID: 5438 RVA: 0x002F808C File Offset: 0x002F628C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(QuestObjective.Types.Completion other)
				{
				}

				// Token: 0x0600153F RID: 5439 RVA: 0x002F809C File Offset: 0x002F629C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06001540 RID: 5440 RVA: 0x002F80AC File Offset: 0x002F62AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06001541 RID: 5441 RVA: 0x002F80BC File Offset: 0x002F62BC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Completion()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							QuestObjective.Types.Completion._parser = new MessageParser<QuestObjective.Types.Completion>(() => null);
							num2 = 4;
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							return;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
						{
							num2 = 3;
						}
					}
				}

				// Token: 0x06001542 RID: 5442 RVA: 0x002F81A0 File Offset: 0x002F63A0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool N5voehGpcDryTh7Negft()
				{
					return true;
				}

				// Token: 0x06001543 RID: 5443 RVA: 0x002F81A8 File Offset: 0x002F63A8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static QuestObjective.Types.Completion J4Z8NRGpU4XTYDY896Jt()
				{
					return null;
				}

				// Token: 0x04000790 RID: 1936
				private static readonly MessageParser<QuestObjective.Types.Completion> _parser;

				// Token: 0x04000791 RID: 1937
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000792 RID: 1938
				public const int CurrentCompletionFieldNumber = 1;

				// Token: 0x04000793 RID: 1939
				private int currentCompletion_;

				// Token: 0x04000794 RID: 1940
				public const int MaxCompletionFieldNumber = 2;

				// Token: 0x04000795 RID: 1941
				private int maxCompletion_;

				// Token: 0x04000796 RID: 1942
				private static QuestObjective.Types.Completion EQp6xeGplOs5m7vrZXeh;
			}
		}
	}
}
