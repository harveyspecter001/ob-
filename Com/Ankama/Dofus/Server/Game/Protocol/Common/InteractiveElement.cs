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
	// Token: 0x02000A76 RID: 2678
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractiveElement : IMessage<InteractiveElement>, IMessage, IEquatable<InteractiveElement>, IDeepCloneable<InteractiveElement>, IBufferMessage
	{
		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x0025F440 File Offset: 0x0025D640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractiveElement> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06007FD8 RID: 32728 RVA: 0x0025F450 File Offset: 0x0025D650
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

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x0025F460 File Offset: 0x0025D660
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

		// Token: 0x06007FDA RID: 32730 RVA: 0x0025F470 File Offset: 0x0025D670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveElement()
		{
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x0025F480 File Offset: 0x0025D680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveElement(InteractiveElement other)
		{
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x0025F490 File Offset: 0x0025D690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractiveElement Clone()
		{
			return null;
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06007FDD RID: 32733 RVA: 0x0025F4A0 File Offset: 0x0025D6A0
		// (set) Token: 0x06007FDE RID: 32734 RVA: 0x0025F4B0 File Offset: 0x0025D6B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ElementId
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

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06007FDF RID: 32735 RVA: 0x0025F4C0 File Offset: 0x0025D6C0
		// (set) Token: 0x06007FE0 RID: 32736 RVA: 0x0025F4D0 File Offset: 0x0025D6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementTypeId
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

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06007FE1 RID: 32737 RVA: 0x0025F4E0 File Offset: 0x0025D6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InteractiveElement.Types.InteractiveElementSkill> EnabledSkills
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06007FE2 RID: 32738 RVA: 0x0025F4F0 File Offset: 0x0025D6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InteractiveElement.Types.InteractiveElementSkill> DisabledSkills
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x0025F500 File Offset: 0x0025D700
		// (set) Token: 0x06007FE4 RID: 32740 RVA: 0x0025F510 File Offset: 0x0025D710
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool OnCurrentMap
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

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x0025F520 File Offset: 0x0025D720
		// (set) Token: 0x06007FE6 RID: 32742 RVA: 0x0025F530 File Offset: 0x0025D730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int AgeBonus
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

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06007FE7 RID: 32743 RVA: 0x0025F540 File Offset: 0x0025D740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasAgeBonus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x0025F550 File Offset: 0x0025D750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAgeBonus()
		{
		}

		// Token: 0x06007FE9 RID: 32745 RVA: 0x0025F560 File Offset: 0x0025D760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x0025F570 File Offset: 0x0025D770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(InteractiveElement other)
		{
			return true;
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x0025F580 File Offset: 0x0025D780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x0025F590 File Offset: 0x0025D790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x0025F5A0 File Offset: 0x0025D7A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x0025F5B0 File Offset: 0x0025D7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x0025F5C0 File Offset: 0x0025D7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x0025F5D0 File Offset: 0x0025D7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(InteractiveElement other)
		{
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x0025F5E0 File Offset: 0x0025D7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x0025F5F0 File Offset: 0x0025D7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x0025F600 File Offset: 0x0025D800
		[MethodImpl(MethodImplOptions.NoInlining)]
		static InteractiveElement()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						InteractiveElement._repeated_disabledSkills_codec = FieldCodec.ForMessage<InteractiveElement.Types.InteractiveElementSkill>(34U, fwkQCXBKZtoQ3t2NJHmg.XVInXhlssT(fwkQCXBKZtoQ3t2NJHmg.Bx0BKqmSoXa));
						num2 = 2;
						break;
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
						{
							num2 = 3;
						}
						break;
					case 2:
						goto IL_AE;
					case 3:
						InteractiveElement._parser = new MessageParser<InteractiveElement>(() => null);
						num2 = 7;
						break;
					case 4:
						return;
					case 5:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
						{
							num2 = 1;
						}
						break;
					case 6:
						goto IL_96;
					case 7:
						InteractiveElement._repeated_enabledSkills_codec = FieldCodec.ForMessage<InteractiveElement.Types.InteractiveElementSkill>(26U, fwkQCXBKZtoQ3t2NJHmg.XVInXhlssT(fwkQCXBKZtoQ3t2NJHmg.Bx0BKqmSoXa));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_96:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 5;
				continue;
				IL_AE:
				InteractiveElement.AgeBonusDefaultValue = 0;
				num = 4;
			}
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x0025F748 File Offset: 0x0025D948
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fWMNHyJge9PALRH8JG9m()
		{
			return true;
		}

		// Token: 0x06007FF5 RID: 32757 RVA: 0x0025F750 File Offset: 0x0025D950
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InteractiveElement ecdIWgJg3KSYw2PV9GNN()
		{
			return null;
		}

		// Token: 0x04002E53 RID: 11859
		private static readonly MessageParser<InteractiveElement> _parser;

		// Token: 0x04002E54 RID: 11860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E55 RID: 11861
		private int _hasBits0;

		// Token: 0x04002E56 RID: 11862
		public const int ElementIdFieldNumber = 1;

		// Token: 0x04002E57 RID: 11863
		private int elementId_;

		// Token: 0x04002E58 RID: 11864
		public const int ElementTypeIdFieldNumber = 2;

		// Token: 0x04002E59 RID: 11865
		private int elementTypeId_;

		// Token: 0x04002E5A RID: 11866
		public const int EnabledSkillsFieldNumber = 3;

		// Token: 0x04002E5B RID: 11867
		private static readonly FieldCodec<InteractiveElement.Types.InteractiveElementSkill> _repeated_enabledSkills_codec;

		// Token: 0x04002E5C RID: 11868
		private readonly RepeatedField<InteractiveElement.Types.InteractiveElementSkill> enabledSkills_;

		// Token: 0x04002E5D RID: 11869
		public const int DisabledSkillsFieldNumber = 4;

		// Token: 0x04002E5E RID: 11870
		private static readonly FieldCodec<InteractiveElement.Types.InteractiveElementSkill> _repeated_disabledSkills_codec;

		// Token: 0x04002E5F RID: 11871
		private readonly RepeatedField<InteractiveElement.Types.InteractiveElementSkill> disabledSkills_;

		// Token: 0x04002E60 RID: 11872
		public const int OnCurrentMapFieldNumber = 5;

		// Token: 0x04002E61 RID: 11873
		private bool onCurrentMap_;

		// Token: 0x04002E62 RID: 11874
		public const int AgeBonusFieldNumber = 6;

		// Token: 0x04002E63 RID: 11875
		private static readonly int AgeBonusDefaultValue;

		// Token: 0x04002E64 RID: 11876
		private int ageBonus_;

		// Token: 0x04002E65 RID: 11877
		internal static InteractiveElement LPZ7UdJgBJXy7MwQ2l6n;

		// Token: 0x02000A77 RID: 2679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06007FF6 RID: 32758 RVA: 0x002E02DC File Offset: 0x002DE4DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000A78 RID: 2680
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class InteractiveElementSkill : IMessage<InteractiveElement.Types.InteractiveElementSkill>, IMessage, IEquatable<InteractiveElement.Types.InteractiveElementSkill>, IDeepCloneable<InteractiveElement.Types.InteractiveElementSkill>, IBufferMessage
			{
				// Token: 0x1700174F RID: 5967
				// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x0030849C File Offset: 0x0030669C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<InteractiveElement.Types.InteractiveElementSkill> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17001750 RID: 5968
				// (get) Token: 0x06007FF8 RID: 32760 RVA: 0x003084AC File Offset: 0x003066AC
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

				// Token: 0x17001751 RID: 5969
				// (get) Token: 0x06007FF9 RID: 32761 RVA: 0x003084BC File Offset: 0x003066BC
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

				// Token: 0x06007FFA RID: 32762 RVA: 0x003084CC File Offset: 0x003066CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public InteractiveElementSkill()
				{
				}

				// Token: 0x06007FFB RID: 32763 RVA: 0x003084DC File Offset: 0x003066DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public InteractiveElementSkill(InteractiveElement.Types.InteractiveElementSkill other)
				{
				}

				// Token: 0x06007FFC RID: 32764 RVA: 0x003084EC File Offset: 0x003066EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public InteractiveElement.Types.InteractiveElementSkill Clone()
				{
					return null;
				}

				// Token: 0x17001752 RID: 5970
				// (get) Token: 0x06007FFD RID: 32765 RVA: 0x003084FC File Offset: 0x003066FC
				// (set) Token: 0x06007FFE RID: 32766 RVA: 0x0030850C File Offset: 0x0030670C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int SkillId
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

				// Token: 0x17001753 RID: 5971
				// (get) Token: 0x06007FFF RID: 32767 RVA: 0x0030851C File Offset: 0x0030671C
				// (set) Token: 0x06008000 RID: 32768 RVA: 0x0030852C File Offset: 0x0030672C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int SkillInstanceUid
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

				// Token: 0x17001754 RID: 5972
				// (get) Token: 0x06008001 RID: 32769 RVA: 0x0030853C File Offset: 0x0030673C
				// (set) Token: 0x06008002 RID: 32770 RVA: 0x0030854C File Offset: 0x0030674C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int NameId
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

				// Token: 0x17001755 RID: 5973
				// (get) Token: 0x06008003 RID: 32771 RVA: 0x0030855C File Offset: 0x0030675C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasNameId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06008004 RID: 32772 RVA: 0x0030856C File Offset: 0x0030676C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearNameId()
				{
				}

				// Token: 0x06008005 RID: 32773 RVA: 0x0030857C File Offset: 0x0030677C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06008006 RID: 32774 RVA: 0x0030858C File Offset: 0x0030678C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(InteractiveElement.Types.InteractiveElementSkill other)
				{
					return true;
				}

				// Token: 0x06008007 RID: 32775 RVA: 0x0030859C File Offset: 0x0030679C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06008008 RID: 32776 RVA: 0x003085AC File Offset: 0x003067AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06008009 RID: 32777 RVA: 0x003085BC File Offset: 0x003067BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600800A RID: 32778 RVA: 0x003085CC File Offset: 0x003067CC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600800B RID: 32779 RVA: 0x003085DC File Offset: 0x003067DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600800C RID: 32780 RVA: 0x003085EC File Offset: 0x003067EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(InteractiveElement.Types.InteractiveElementSkill other)
				{
				}

				// Token: 0x0600800D RID: 32781 RVA: 0x003085FC File Offset: 0x003067FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600800E RID: 32782 RVA: 0x0030860C File Offset: 0x0030680C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600800F RID: 32783 RVA: 0x0030861C File Offset: 0x0030681C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static InteractiveElementSkill()
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
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								goto IL_39;
							case 4:
								return;
							case 5:
								InteractiveElement.Types.InteractiveElementSkill.NameIdDefaultValue = 0;
								num2 = 4;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							}
							InteractiveElement.Types.InteractiveElementSkill._parser = new MessageParser<InteractiveElement.Types.InteractiveElementSkill>(() => null);
							num2 = 5;
						}
						IL_39:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num = 2;
					}
				}

				// Token: 0x06008010 RID: 32784 RVA: 0x00308718 File Offset: 0x00306918
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool uKQDQpGuKm5inWqEjUk2()
				{
					return true;
				}

				// Token: 0x06008011 RID: 32785 RVA: 0x00308720 File Offset: 0x00306920
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static InteractiveElement.Types.InteractiveElementSkill kvI3J4GuI55gZF67i6eT()
				{
					return null;
				}

				// Token: 0x04002E66 RID: 11878
				private static readonly MessageParser<InteractiveElement.Types.InteractiveElementSkill> _parser;

				// Token: 0x04002E67 RID: 11879
				private UnknownFieldSet _unknownFields;

				// Token: 0x04002E68 RID: 11880
				private int _hasBits0;

				// Token: 0x04002E69 RID: 11881
				public const int SkillIdFieldNumber = 1;

				// Token: 0x04002E6A RID: 11882
				private int skillId_;

				// Token: 0x04002E6B RID: 11883
				public const int SkillInstanceUidFieldNumber = 2;

				// Token: 0x04002E6C RID: 11884
				private int skillInstanceUid_;

				// Token: 0x04002E6D RID: 11885
				public const int NameIdFieldNumber = 3;

				// Token: 0x04002E6E RID: 11886
				private static readonly int NameIdDefaultValue;

				// Token: 0x04002E6F RID: 11887
				private int nameId_;

				// Token: 0x04002E70 RID: 11888
				internal static InteractiveElement.Types.InteractiveElementSkill tkV2FKGujDH0cIloROsf;
			}
		}
	}
}
