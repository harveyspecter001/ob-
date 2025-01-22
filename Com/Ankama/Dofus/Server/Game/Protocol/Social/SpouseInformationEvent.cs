using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000141 RID: 321
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpouseInformationEvent : IMessage<SpouseInformationEvent>, IMessage, IEquatable<SpouseInformationEvent>, IDeepCloneable<SpouseInformationEvent>, IBufferMessage
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0019BF74 File Offset: 0x0019A174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpouseInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0019BF84 File Offset: 0x0019A184
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0019BF94 File Offset: 0x0019A194
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

		// Token: 0x06000E98 RID: 3736 RVA: 0x0019BFA4 File Offset: 0x0019A1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseInformationEvent()
		{
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0019BFB4 File Offset: 0x0019A1B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseInformationEvent(SpouseInformationEvent other)
		{
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0019BFC4 File Offset: 0x0019A1C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x0019BFD4 File Offset: 0x0019A1D4
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x0019BFE4 File Offset: 0x0019A1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccountId
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0019BFF4 File Offset: 0x0019A1F4
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x0019C004 File Offset: 0x0019A204
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0019C014 File Offset: 0x0019A214
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x0019C024 File Offset: 0x0019A224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string CharacterName
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

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0019C034 File Offset: 0x0019A234
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x0019C044 File Offset: 0x0019A244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CharacterLevel
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

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0019C054 File Offset: 0x0019A254
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x0019C064 File Offset: 0x0019A264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BreedId
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

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0019C074 File Offset: 0x0019A274
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x0019C088 File Offset: 0x0019A288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Gender Gender
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Gender)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0019C098 File Offset: 0x0019A298
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0019C0A8 File Offset: 0x0019A2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GuildInformation Guild
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

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0019C0B8 File Offset: 0x0019A2B8
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x0019C0C8 File Offset: 0x0019A2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation Alliance
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

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0019C0D8 File Offset: 0x0019A2D8
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x0019C0EC File Offset: 0x0019A2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Alignment Alignment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Alignment)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0019C0FC File Offset: 0x0019A2FC
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x0019C10C File Offset: 0x0019A30C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public EntityLook EntityLook
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

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0019C11C File Offset: 0x0019A31C
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x0019C12C File Offset: 0x0019A32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpouseInformationEvent.Types.Online Online
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

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0019C13C File Offset: 0x0019A33C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0019C14C File Offset: 0x0019A34C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpouseInformationEvent other)
		{
			return true;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0019C15C File Offset: 0x0019A35C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0019C16C File Offset: 0x0019A36C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0019C17C File Offset: 0x0019A37C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0019C18C File Offset: 0x0019A38C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0019C19C File Offset: 0x0019A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0019C1AC File Offset: 0x0019A3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpouseInformationEvent other)
		{
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0019C1BC File Offset: 0x0019A3BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0019C1CC File Offset: 0x0019A3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0019C1DC File Offset: 0x0019A3DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpouseInformationEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				SpouseInformationEvent._parser = new MessageParser<SpouseInformationEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0019C2A8 File Offset: 0x0019A4A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fq3rWZOUGHaydoOb0s7G()
		{
			return true;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0019C2B0 File Offset: 0x0019A4B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpouseInformationEvent kdCJIkOUg2g2T7jWTF2f()
		{
			return null;
		}

		// Token: 0x0400054E RID: 1358
		private static readonly MessageParser<SpouseInformationEvent> _parser;

		// Token: 0x0400054F RID: 1359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000550 RID: 1360
		public const int AccountIdFieldNumber = 1;

		// Token: 0x04000551 RID: 1361
		private long accountId_;

		// Token: 0x04000552 RID: 1362
		public const int CharacterIdFieldNumber = 2;

		// Token: 0x04000553 RID: 1363
		private long characterId_;

		// Token: 0x04000554 RID: 1364
		public const int CharacterNameFieldNumber = 3;

		// Token: 0x04000555 RID: 1365
		private string characterName_;

		// Token: 0x04000556 RID: 1366
		public const int CharacterLevelFieldNumber = 4;

		// Token: 0x04000557 RID: 1367
		private int characterLevel_;

		// Token: 0x04000558 RID: 1368
		public const int BreedIdFieldNumber = 5;

		// Token: 0x04000559 RID: 1369
		private int breedId_;

		// Token: 0x0400055A RID: 1370
		public const int GenderFieldNumber = 6;

		// Token: 0x0400055B RID: 1371
		private Gender gender_;

		// Token: 0x0400055C RID: 1372
		public const int GuildFieldNumber = 7;

		// Token: 0x0400055D RID: 1373
		private GuildInformation guild_;

		// Token: 0x0400055E RID: 1374
		public const int AllianceFieldNumber = 8;

		// Token: 0x0400055F RID: 1375
		private AllianceInformation alliance_;

		// Token: 0x04000560 RID: 1376
		public const int AlignmentFieldNumber = 9;

		// Token: 0x04000561 RID: 1377
		private Alignment alignment_;

		// Token: 0x04000562 RID: 1378
		public const int EntityLookFieldNumber = 10;

		// Token: 0x04000563 RID: 1379
		private EntityLook entityLook_;

		// Token: 0x04000564 RID: 1380
		public const int OnlineFieldNumber = 11;

		// Token: 0x04000565 RID: 1381
		private SpouseInformationEvent.Types.Online online_;

		// Token: 0x04000566 RID: 1382
		internal static SpouseInformationEvent Copy5yOUJtLIPaOk8cSu;

		// Token: 0x02000142 RID: 322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06000EBE RID: 3774 RVA: 0x002AC5D8 File Offset: 0x002AA7D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000143 RID: 323
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Online : IMessage<SpouseInformationEvent.Types.Online>, IMessage, IEquatable<SpouseInformationEvent.Types.Online>, IDeepCloneable<SpouseInformationEvent.Types.Online>, IBufferMessage
			{
				// Token: 0x17000298 RID: 664
				// (get) Token: 0x06000EBF RID: 3775 RVA: 0x002F73B8 File Offset: 0x002F55B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<SpouseInformationEvent.Types.Online> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000299 RID: 665
				// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x002F73C8 File Offset: 0x002F55C8
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

				// Token: 0x1700029A RID: 666
				// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x002F73D8 File Offset: 0x002F55D8
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

				// Token: 0x06000EC2 RID: 3778 RVA: 0x002F73E8 File Offset: 0x002F55E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Online()
				{
				}

				// Token: 0x06000EC3 RID: 3779 RVA: 0x002F73F8 File Offset: 0x002F55F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Online(SpouseInformationEvent.Types.Online other)
				{
				}

				// Token: 0x06000EC4 RID: 3780 RVA: 0x002F7408 File Offset: 0x002F5608
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpouseInformationEvent.Types.Online Clone()
				{
					return null;
				}

				// Token: 0x1700029B RID: 667
				// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x002F7418 File Offset: 0x002F5618
				// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x002F7428 File Offset: 0x002F5628
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

				// Token: 0x1700029C RID: 668
				// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x002F7438 File Offset: 0x002F5638
				// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x002F7448 File Offset: 0x002F5648
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int SubAreaId
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

				// Token: 0x1700029D RID: 669
				// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x002F7458 File Offset: 0x002F5658
				// (set) Token: 0x06000ECA RID: 3786 RVA: 0x002F7468 File Offset: 0x002F5668
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int AreaId
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

				// Token: 0x1700029E RID: 670
				// (get) Token: 0x06000ECB RID: 3787 RVA: 0x002F7478 File Offset: 0x002F5678
				// (set) Token: 0x06000ECC RID: 3788 RVA: 0x002F7488 File Offset: 0x002F5688
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool InFight
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

				// Token: 0x1700029F RID: 671
				// (get) Token: 0x06000ECD RID: 3789 RVA: 0x002F7498 File Offset: 0x002F5698
				// (set) Token: 0x06000ECE RID: 3790 RVA: 0x002F74A8 File Offset: 0x002F56A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool Following
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

				// Token: 0x06000ECF RID: 3791 RVA: 0x002F74B8 File Offset: 0x002F56B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06000ED0 RID: 3792 RVA: 0x002F74C8 File Offset: 0x002F56C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(SpouseInformationEvent.Types.Online other)
				{
					return true;
				}

				// Token: 0x06000ED1 RID: 3793 RVA: 0x002F74D8 File Offset: 0x002F56D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06000ED2 RID: 3794 RVA: 0x002F74E8 File Offset: 0x002F56E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06000ED3 RID: 3795 RVA: 0x002F74F8 File Offset: 0x002F56F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06000ED4 RID: 3796 RVA: 0x002F7508 File Offset: 0x002F5708
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06000ED5 RID: 3797 RVA: 0x002F7518 File Offset: 0x002F5718
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06000ED6 RID: 3798 RVA: 0x002F7528 File Offset: 0x002F5728
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(SpouseInformationEvent.Types.Online other)
				{
				}

				// Token: 0x06000ED7 RID: 3799 RVA: 0x002F7538 File Offset: 0x002F5738
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06000ED8 RID: 3800 RVA: 0x002F7548 File Offset: 0x002F5748
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06000ED9 RID: 3801 RVA: 0x002F7558 File Offset: 0x002F5758
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Online()
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
							num2 = 3;
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						}
						SpouseInformationEvent.Types.Online._parser = new MessageParser<SpouseInformationEvent.Types.Online>(() => null);
						num2 = 4;
					}
				}

				// Token: 0x06000EDA RID: 3802 RVA: 0x002F7624 File Offset: 0x002F5824
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool ucyVPfGpOfSfret4qp2v()
				{
					return true;
				}

				// Token: 0x06000EDB RID: 3803 RVA: 0x002F762C File Offset: 0x002F582C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static SpouseInformationEvent.Types.Online Gqqf1pGpJvjswR2yrNbO()
				{
					return null;
				}

				// Token: 0x04000567 RID: 1383
				private static readonly MessageParser<SpouseInformationEvent.Types.Online> _parser;

				// Token: 0x04000568 RID: 1384
				private UnknownFieldSet _unknownFields;

				// Token: 0x04000569 RID: 1385
				public const int MapIdFieldNumber = 1;

				// Token: 0x0400056A RID: 1386
				private long mapId_;

				// Token: 0x0400056B RID: 1387
				public const int SubAreaIdFieldNumber = 2;

				// Token: 0x0400056C RID: 1388
				private int subAreaId_;

				// Token: 0x0400056D RID: 1389
				public const int AreaIdFieldNumber = 3;

				// Token: 0x0400056E RID: 1390
				private int areaId_;

				// Token: 0x0400056F RID: 1391
				public const int InFightFieldNumber = 4;

				// Token: 0x04000570 RID: 1392
				private bool inFight_;

				// Token: 0x04000571 RID: 1393
				public const int FollowingFieldNumber = 5;

				// Token: 0x04000572 RID: 1394
				private bool following_;

				// Token: 0x04000573 RID: 1395
				internal static SpouseInformationEvent.Types.Online JoZyTqGpRqc8Y0HUsG6a;
			}
		}
	}
}
