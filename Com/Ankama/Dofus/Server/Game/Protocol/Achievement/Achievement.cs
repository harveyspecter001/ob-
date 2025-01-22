using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Achievement
{
	// Token: 0x02000DD8 RID: 3544
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Achievement : IMessage<Achievement>, IMessage, IEquatable<Achievement>, IDeepCloneable<Achievement>, IBufferMessage
	{
		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600AABE RID: 43710 RVA: 0x002992EC File Offset: 0x002974EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Achievement> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600AABF RID: 43711 RVA: 0x002992FC File Offset: 0x002974FC
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

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x0029930C File Offset: 0x0029750C
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

		// Token: 0x0600AAC1 RID: 43713 RVA: 0x0029931C File Offset: 0x0029751C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Achievement()
		{
		}

		// Token: 0x0600AAC2 RID: 43714 RVA: 0x0029932C File Offset: 0x0029752C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Achievement(Achievement other)
		{
		}

		// Token: 0x0600AAC3 RID: 43715 RVA: 0x0029933C File Offset: 0x0029753C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Achievement Clone()
		{
			return null;
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x0600AAC4 RID: 43716 RVA: 0x0029934C File Offset: 0x0029754C
		// (set) Token: 0x0600AAC5 RID: 43717 RVA: 0x0029935C File Offset: 0x0029755C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AchievementId
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

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x0600AAC6 RID: 43718 RVA: 0x0029936C File Offset: 0x0029756C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Achievement.Types.AchievementObjective> AchievementObjectives
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AAC7 RID: 43719 RVA: 0x0029937C File Offset: 0x0029757C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600AAC8 RID: 43720 RVA: 0x0029938C File Offset: 0x0029758C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Achievement other)
		{
			return true;
		}

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x0029939C File Offset: 0x0029759C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x002993AC File Offset: 0x002975AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x002993BC File Offset: 0x002975BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x002993CC File Offset: 0x002975CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x002993DC File Offset: 0x002975DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600AACE RID: 43726 RVA: 0x002993EC File Offset: 0x002975EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Achievement other)
		{
		}

		// Token: 0x0600AACF RID: 43727 RVA: 0x002993FC File Offset: 0x002975FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600AAD0 RID: 43728 RVA: 0x0029940C File Offset: 0x0029760C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x0029941C File Offset: 0x0029761C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Achievement()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					Achievement._parser = new MessageParser<Achievement>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					Achievement._repeated_achievementObjectives_codec = FieldCodec.ForMessage<Achievement.Types.AchievementObjective>(18U, wK25vB3sZV7T6X73cJGX.XVInXhlssT(wK25vB3sZV7T6X73cJGX.ik93sqf9E4B));
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x0600AAD2 RID: 43730 RVA: 0x00299524 File Offset: 0x00297724
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oBOT47JcTwXS3uQyeBOk()
		{
			return true;
		}

		// Token: 0x0600AAD3 RID: 43731 RVA: 0x0029952C File Offset: 0x0029772C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Achievement srwEQLJcpb4OdW4VOLM5()
		{
			return null;
		}

		// Token: 0x04003EA9 RID: 16041
		private static readonly MessageParser<Achievement> _parser;

		// Token: 0x04003EAA RID: 16042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EAB RID: 16043
		public const int AchievementIdFieldNumber = 1;

		// Token: 0x04003EAC RID: 16044
		private int achievementId_;

		// Token: 0x04003EAD RID: 16045
		public const int AchievementObjectivesFieldNumber = 2;

		// Token: 0x04003EAE RID: 16046
		private static readonly FieldCodec<Achievement.Types.AchievementObjective> _repeated_achievementObjectives_codec;

		// Token: 0x04003EAF RID: 16047
		private readonly RepeatedField<Achievement.Types.AchievementObjective> achievementObjectives_;

		// Token: 0x04003EB0 RID: 16048
		private static Achievement viBaPNJc7O2lL25kiqqP;

		// Token: 0x02000DD9 RID: 3545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600AAD4 RID: 43732 RVA: 0x002F29B0 File Offset: 0x002F0BB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000DDA RID: 3546
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class AchievementObjective : IMessage<Achievement.Types.AchievementObjective>, IMessage, IEquatable<Achievement.Types.AchievementObjective>, IDeepCloneable<Achievement.Types.AchievementObjective>, IBufferMessage
			{
				// Token: 0x17001FA4 RID: 8100
				// (get) Token: 0x0600AAD5 RID: 43733 RVA: 0x0030F1F8 File Offset: 0x0030D3F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<Achievement.Types.AchievementObjective> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001FA5 RID: 8101
				// (get) Token: 0x0600AAD6 RID: 43734 RVA: 0x0030F208 File Offset: 0x0030D408
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

				// Token: 0x17001FA6 RID: 8102
				// (get) Token: 0x0600AAD7 RID: 43735 RVA: 0x0030F218 File Offset: 0x0030D418
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

				// Token: 0x0600AAD8 RID: 43736 RVA: 0x0030F228 File Offset: 0x0030D428
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AchievementObjective()
				{
				}

				// Token: 0x0600AAD9 RID: 43737 RVA: 0x0030F238 File Offset: 0x0030D438
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public AchievementObjective(Achievement.Types.AchievementObjective other)
				{
				}

				// Token: 0x0600AADA RID: 43738 RVA: 0x0030F248 File Offset: 0x0030D448
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Achievement.Types.AchievementObjective Clone()
				{
					return null;
				}

				// Token: 0x17001FA7 RID: 8103
				// (get) Token: 0x0600AADB RID: 43739 RVA: 0x0030F258 File Offset: 0x0030D458
				// (set) Token: 0x0600AADC RID: 43740 RVA: 0x0030F268 File Offset: 0x0030D468
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

				// Token: 0x17001FA8 RID: 8104
				// (get) Token: 0x0600AADD RID: 43741 RVA: 0x0030F278 File Offset: 0x0030D478
				// (set) Token: 0x0600AADE RID: 43742 RVA: 0x0030F288 File Offset: 0x0030D488
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long MaxValue
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

				// Token: 0x17001FA9 RID: 8105
				// (get) Token: 0x0600AADF RID: 43743 RVA: 0x0030F298 File Offset: 0x0030D498
				// (set) Token: 0x0600AAE0 RID: 43744 RVA: 0x0030F2A8 File Offset: 0x0030D4A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long CurrentValue
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

				// Token: 0x17001FAA RID: 8106
				// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x0030F2B8 File Offset: 0x0030D4B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasCurrentValue
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x0600AAE2 RID: 43746 RVA: 0x0030F2C8 File Offset: 0x0030D4C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearCurrentValue()
				{
				}

				// Token: 0x0600AAE3 RID: 43747 RVA: 0x0030F2D8 File Offset: 0x0030D4D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600AAE4 RID: 43748 RVA: 0x0030F2E8 File Offset: 0x0030D4E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(Achievement.Types.AchievementObjective other)
				{
					return true;
				}

				// Token: 0x0600AAE5 RID: 43749 RVA: 0x0030F2F8 File Offset: 0x0030D4F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600AAE6 RID: 43750 RVA: 0x0030F308 File Offset: 0x0030D508
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600AAE7 RID: 43751 RVA: 0x0030F318 File Offset: 0x0030D518
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600AAE8 RID: 43752 RVA: 0x0030F328 File Offset: 0x0030D528
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600AAE9 RID: 43753 RVA: 0x0030F338 File Offset: 0x0030D538
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600AAEA RID: 43754 RVA: 0x0030F348 File Offset: 0x0030D548
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(Achievement.Types.AchievementObjective other)
				{
				}

				// Token: 0x0600AAEB RID: 43755 RVA: 0x0030F358 File Offset: 0x0030D558
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600AAEC RID: 43756 RVA: 0x0030F368 File Offset: 0x0030D568
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600AAED RID: 43757 RVA: 0x0030F378 File Offset: 0x0030D578
				[MethodImpl(MethodImplOptions.NoInlining)]
				static AchievementObjective()
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
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							Achievement.Types.AchievementObjective.CurrentValueDefaultValue = 0L;
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 4:
							return;
						case 5:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						Achievement.Types.AchievementObjective._parser = new MessageParser<Achievement.Types.AchievementObjective>(() => null);
						num2 = 3;
					}
				}

				// Token: 0x0600AAEE RID: 43758 RVA: 0x0030F470 File Offset: 0x0030D670
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool QCAfeSGqlImK6Nv5tvaL()
				{
					return true;
				}

				// Token: 0x0600AAEF RID: 43759 RVA: 0x0030F478 File Offset: 0x0030D678
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static Achievement.Types.AchievementObjective zfCC83Gqctdad10SQlVm()
				{
					return null;
				}

				// Token: 0x04003EB1 RID: 16049
				private static readonly MessageParser<Achievement.Types.AchievementObjective> _parser;

				// Token: 0x04003EB2 RID: 16050
				private UnknownFieldSet _unknownFields;

				// Token: 0x04003EB3 RID: 16051
				private int _hasBits0;

				// Token: 0x04003EB4 RID: 16052
				public const int ObjectiveIdFieldNumber = 1;

				// Token: 0x04003EB5 RID: 16053
				private int objectiveId_;

				// Token: 0x04003EB6 RID: 16054
				public const int MaxValueFieldNumber = 2;

				// Token: 0x04003EB7 RID: 16055
				private long maxValue_;

				// Token: 0x04003EB8 RID: 16056
				public const int CurrentValueFieldNumber = 3;

				// Token: 0x04003EB9 RID: 16057
				private static readonly long CurrentValueDefaultValue;

				// Token: 0x04003EBA RID: 16058
				private long currentValue_;

				// Token: 0x04003EBB RID: 16059
				internal static Achievement.Types.AchievementObjective PHPHy5GqkE5FvPEZGGEm;
			}
		}
	}
}
