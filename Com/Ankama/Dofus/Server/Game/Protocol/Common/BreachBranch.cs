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
	// Token: 0x02000A19 RID: 2585
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachBranch : IMessage<BreachBranch>, IMessage, IEquatable<BreachBranch>, IDeepCloneable<BreachBranch>, IBufferMessage
	{
		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x0025C244 File Offset: 0x0025A444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachBranch> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06007B5C RID: 31580 RVA: 0x0025C254 File Offset: 0x0025A454
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

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x0025C264 File Offset: 0x0025A464
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

		// Token: 0x06007B5E RID: 31582 RVA: 0x0025C274 File Offset: 0x0025A474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBranch()
		{
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x0025C284 File Offset: 0x0025A484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBranch(BreachBranch other)
		{
		}

		// Token: 0x06007B60 RID: 31584 RVA: 0x0025C294 File Offset: 0x0025A494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachBranch Clone()
		{
			return null;
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06007B61 RID: 31585 RVA: 0x0025C2A4 File Offset: 0x0025A4A4
		// (set) Token: 0x06007B62 RID: 31586 RVA: 0x0025C2B4 File Offset: 0x0025A4B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Room
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

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x0025C2C4 File Offset: 0x0025A4C4
		// (set) Token: 0x06007B64 RID: 31588 RVA: 0x0025C2D4 File Offset: 0x0025A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Element
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

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06007B65 RID: 31589 RVA: 0x0025C2E4 File Offset: 0x0025A4E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<MonsterInGroupInformation> Bosses
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06007B66 RID: 31590 RVA: 0x0025C2F4 File Offset: 0x0025A4F4
		// (set) Token: 0x06007B67 RID: 31591 RVA: 0x0025C304 File Offset: 0x0025A504
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06007B68 RID: 31592 RVA: 0x0025C314 File Offset: 0x0025A514
		// (set) Token: 0x06007B69 RID: 31593 RVA: 0x0025C324 File Offset: 0x0025A524
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Score
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

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06007B6A RID: 31594 RVA: 0x0025C334 File Offset: 0x0025A534
		// (set) Token: 0x06007B6B RID: 31595 RVA: 0x0025C344 File Offset: 0x0025A544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RelativeScore
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

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06007B6C RID: 31596 RVA: 0x0025C354 File Offset: 0x0025A554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterInGroupInformation> Monsters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06007B6D RID: 31597 RVA: 0x0025C364 File Offset: 0x0025A564
		// (set) Token: 0x06007B6E RID: 31598 RVA: 0x0025C374 File Offset: 0x0025A574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BreachBranch.Types.ExtendedBreachBranch ExtendedInformation
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

		// Token: 0x06007B6F RID: 31599 RVA: 0x0025C384 File Offset: 0x0025A584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x0025C394 File Offset: 0x0025A594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachBranch other)
		{
			return true;
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x0025C3A4 File Offset: 0x0025A5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x0025C3B4 File Offset: 0x0025A5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x0025C3C4 File Offset: 0x0025A5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x0025C3D4 File Offset: 0x0025A5D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x0025C3E4 File Offset: 0x0025A5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x0025C3F4 File Offset: 0x0025A5F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachBranch other)
		{
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x0025C404 File Offset: 0x0025A604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x0025C414 File Offset: 0x0025A614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x0025C424 File Offset: 0x0025A624
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachBranch()
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
					num2 = 5;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					BreachBranch._repeated_monsters_codec = FieldCodec.ForMessage<MonsterInGroupInformation>(58U, IYZkmgBkFrHCMb0SZnvF.XVInXhlssT(IYZkmgBkFrHCMb0SZnvF.XOCBkzfLnx5));
					num2 = 6;
					continue;
				case 4:
					BreachBranch._parser = new MessageParser<BreachBranch>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 6:
					return;
				}
				BreachBranch._repeated_bosses_codec = FieldCodec.ForMessage<MonsterInGroupInformation>(26U, IYZkmgBkFrHCMb0SZnvF.XVInXhlssT(IYZkmgBkFrHCMb0SZnvF.XOCBkzfLnx5));
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x0025C550 File Offset: 0x0025A750
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool txKYc1JGGvAFdpBJarUw()
		{
			return true;
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x0025C558 File Offset: 0x0025A758
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachBranch HEur2xJGgUUVPpisjA15()
		{
			return null;
		}

		// Token: 0x04002C38 RID: 11320
		private static readonly MessageParser<BreachBranch> _parser;

		// Token: 0x04002C39 RID: 11321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C3A RID: 11322
		public const int RoomFieldNumber = 1;

		// Token: 0x04002C3B RID: 11323
		private int room_;

		// Token: 0x04002C3C RID: 11324
		public const int ElementFieldNumber = 2;

		// Token: 0x04002C3D RID: 11325
		private int element_;

		// Token: 0x04002C3E RID: 11326
		public const int BossesFieldNumber = 3;

		// Token: 0x04002C3F RID: 11327
		private static readonly FieldCodec<MonsterInGroupInformation> _repeated_bosses_codec;

		// Token: 0x04002C40 RID: 11328
		private readonly RepeatedField<MonsterInGroupInformation> bosses_;

		// Token: 0x04002C41 RID: 11329
		public const int MapIdFieldNumber = 4;

		// Token: 0x04002C42 RID: 11330
		private long mapId_;

		// Token: 0x04002C43 RID: 11331
		public const int ScoreFieldNumber = 5;

		// Token: 0x04002C44 RID: 11332
		private int score_;

		// Token: 0x04002C45 RID: 11333
		public const int RelativeScoreFieldNumber = 6;

		// Token: 0x04002C46 RID: 11334
		private int relativeScore_;

		// Token: 0x04002C47 RID: 11335
		public const int MonstersFieldNumber = 7;

		// Token: 0x04002C48 RID: 11336
		private static readonly FieldCodec<MonsterInGroupInformation> _repeated_monsters_codec;

		// Token: 0x04002C49 RID: 11337
		private readonly RepeatedField<MonsterInGroupInformation> monsters_;

		// Token: 0x04002C4A RID: 11338
		public const int ExtendedInformationFieldNumber = 8;

		// Token: 0x04002C4B RID: 11339
		private BreachBranch.Types.ExtendedBreachBranch extendedInformation_;

		// Token: 0x04002C4C RID: 11340
		private static BreachBranch CMnOltJGJwl8nouT6PDi;

		// Token: 0x02000A1A RID: 2586
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06007B7C RID: 31612 RVA: 0x002DEFD0 File Offset: 0x002DD1D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A1B RID: 2587
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ExtendedBreachBranch : IMessage<BreachBranch.Types.ExtendedBreachBranch>, IMessage, IEquatable<BreachBranch.Types.ExtendedBreachBranch>, IDeepCloneable<BreachBranch.Types.ExtendedBreachBranch>, IBufferMessage
			{
				// Token: 0x17001647 RID: 5703
				// (get) Token: 0x06007B7D RID: 31613 RVA: 0x003073B8 File Offset: 0x003055B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<BreachBranch.Types.ExtendedBreachBranch> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001648 RID: 5704
				// (get) Token: 0x06007B7E RID: 31614 RVA: 0x003073C8 File Offset: 0x003055C8
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

				// Token: 0x17001649 RID: 5705
				// (get) Token: 0x06007B7F RID: 31615 RVA: 0x003073D8 File Offset: 0x003055D8
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

				// Token: 0x06007B80 RID: 31616 RVA: 0x003073E8 File Offset: 0x003055E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExtendedBreachBranch()
				{
				}

				// Token: 0x06007B81 RID: 31617 RVA: 0x003073F8 File Offset: 0x003055F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExtendedBreachBranch(BreachBranch.Types.ExtendedBreachBranch other)
				{
				}

				// Token: 0x06007B82 RID: 31618 RVA: 0x00307408 File Offset: 0x00305608
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public BreachBranch.Types.ExtendedBreachBranch Clone()
				{
					return null;
				}

				// Token: 0x1700164A RID: 5706
				// (get) Token: 0x06007B83 RID: 31619 RVA: 0x00307418 File Offset: 0x00305618
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<BreachReward> Rewards
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700164B RID: 5707
				// (get) Token: 0x06007B84 RID: 31620 RVA: 0x00307428 File Offset: 0x00305628
				// (set) Token: 0x06007B85 RID: 31621 RVA: 0x00307438 File Offset: 0x00305638
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Modifier
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

				// Token: 0x1700164C RID: 5708
				// (get) Token: 0x06007B86 RID: 31622 RVA: 0x00307448 File Offset: 0x00305648
				// (set) Token: 0x06007B87 RID: 31623 RVA: 0x00307458 File Offset: 0x00305658
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Price
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

				// Token: 0x1700164D RID: 5709
				// (get) Token: 0x06007B88 RID: 31624 RVA: 0x00307468 File Offset: 0x00305668
				// (set) Token: 0x06007B89 RID: 31625 RVA: 0x00307478 File Offset: 0x00305678
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int UnlockPrice
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

				// Token: 0x1700164E RID: 5710
				// (get) Token: 0x06007B8A RID: 31626 RVA: 0x00307488 File Offset: 0x00305688
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasUnlockPrice
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06007B8B RID: 31627 RVA: 0x00307498 File Offset: 0x00305698
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearUnlockPrice()
				{
				}

				// Token: 0x06007B8C RID: 31628 RVA: 0x003074A8 File Offset: 0x003056A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06007B8D RID: 31629 RVA: 0x003074B8 File Offset: 0x003056B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(BreachBranch.Types.ExtendedBreachBranch other)
				{
					return true;
				}

				// Token: 0x06007B8E RID: 31630 RVA: 0x003074C8 File Offset: 0x003056C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06007B8F RID: 31631 RVA: 0x003074D8 File Offset: 0x003056D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06007B90 RID: 31632 RVA: 0x003074E8 File Offset: 0x003056E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06007B91 RID: 31633 RVA: 0x003074F8 File Offset: 0x003056F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06007B92 RID: 31634 RVA: 0x00307508 File Offset: 0x00305708
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06007B93 RID: 31635 RVA: 0x00307518 File Offset: 0x00305718
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(BreachBranch.Types.ExtendedBreachBranch other)
				{
				}

				// Token: 0x06007B94 RID: 31636 RVA: 0x00307528 File Offset: 0x00305728
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06007B95 RID: 31637 RVA: 0x00307538 File Offset: 0x00305738
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06007B96 RID: 31638 RVA: 0x00307548 File Offset: 0x00305748
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExtendedBreachBranch()
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 5;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								BreachBranch.Types.ExtendedBreachBranch.UnlockPriceDefaultValue = 0;
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
								{
									num2 = 6;
									continue;
								}
								continue;
							case 4:
								BreachBranch.Types.ExtendedBreachBranch._repeated_rewards_codec = FieldCodec.ForMessage<BreachReward>(10U, k4yIxYBxvfeIy0gDC3VK.XVInXhlssT(k4yIxYBxvfeIy0gDC3VK.jsQBxomWHLb));
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
								{
									num2 = 3;
									continue;
								}
								continue;
							case 5:
								goto IL_C5;
							case 6:
								return;
							}
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
							{
								num2 = 2;
							}
						}
						IL_C5:
						BreachBranch.Types.ExtendedBreachBranch._parser = new MessageParser<BreachBranch.Types.ExtendedBreachBranch>(() => null);
						num = 4;
					}
				}

				// Token: 0x06007B97 RID: 31639 RVA: 0x00307690 File Offset: 0x00305890
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool qHHaR5GMS4VnGvHJK7Or()
				{
					return true;
				}

				// Token: 0x06007B98 RID: 31640 RVA: 0x00307698 File Offset: 0x00305898
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static BreachBranch.Types.ExtendedBreachBranch qqONk1GMMQ0InEU2HiOZ()
				{
					return null;
				}

				// Token: 0x04002C4D RID: 11341
				private static readonly MessageParser<BreachBranch.Types.ExtendedBreachBranch> _parser;

				// Token: 0x04002C4E RID: 11342
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002C4F RID: 11343
				private int _hasBits0;

				// Token: 0x04002C50 RID: 11344
				public const int RewardsFieldNumber = 1;

				// Token: 0x04002C51 RID: 11345
				private static readonly FieldCodec<BreachReward> _repeated_rewards_codec;

				// Token: 0x04002C52 RID: 11346
				private readonly RepeatedField<BreachReward> rewards_;

				// Token: 0x04002C53 RID: 11347
				public const int ModifierFieldNumber = 2;

				// Token: 0x04002C54 RID: 11348
				private int modifier_;

				// Token: 0x04002C55 RID: 11349
				public const int PriceFieldNumber = 3;

				// Token: 0x04002C56 RID: 11350
				private int price_;

				// Token: 0x04002C57 RID: 11351
				public const int UnlockPriceFieldNumber = 4;

				// Token: 0x04002C58 RID: 11352
				private static readonly int UnlockPriceDefaultValue;

				// Token: 0x04002C59 RID: 11353
				private int unlockPrice_;

				// Token: 0x04002C5A RID: 11354
				private static BreachBranch.Types.ExtendedBreachBranch QwgIKyGMPlYygLdqK8Ci;
			}
		}
	}
}
