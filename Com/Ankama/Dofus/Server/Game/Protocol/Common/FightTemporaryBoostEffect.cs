using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000AC3 RID: 2755
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightTemporaryBoostEffect : IMessage<FightTemporaryBoostEffect>, IMessage, IEquatable<FightTemporaryBoostEffect>, IDeepCloneable<FightTemporaryBoostEffect>, IBufferMessage
	{
		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x060083B7 RID: 33719 RVA: 0x00263B98 File Offset: 0x00261D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightTemporaryBoostEffect> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x060083B8 RID: 33720 RVA: 0x00263BA8 File Offset: 0x00261DA8
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

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x060083B9 RID: 33721 RVA: 0x00263BB8 File Offset: 0x00261DB8
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

		// Token: 0x060083BA RID: 33722 RVA: 0x00263BC8 File Offset: 0x00261DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTemporaryBoostEffect()
		{
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x00263BD8 File Offset: 0x00261DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTemporaryBoostEffect(FightTemporaryBoostEffect other)
		{
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x00263BE8 File Offset: 0x00261DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightTemporaryBoostEffect Clone()
		{
			return null;
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x060083BD RID: 33725 RVA: 0x00263BF8 File Offset: 0x00261DF8
		// (set) Token: 0x060083BE RID: 33726 RVA: 0x00263C08 File Offset: 0x00261E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delta
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

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x060083BF RID: 33727 RVA: 0x00263C18 File Offset: 0x00261E18
		// (set) Token: 0x060083C0 RID: 33728 RVA: 0x00263C28 File Offset: 0x00261E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int BoostedSpellId
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

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x060083C1 RID: 33729 RVA: 0x00263C38 File Offset: 0x00261E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBoostedSpellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x00263C48 File Offset: 0x00261E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearBoostedSpellId()
		{
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x060083C3 RID: 33731 RVA: 0x00263C58 File Offset: 0x00261E58
		// (set) Token: 0x060083C4 RID: 33732 RVA: 0x00263C68 File Offset: 0x00261E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int WeaponTypeId
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

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x060083C5 RID: 33733 RVA: 0x00263C78 File Offset: 0x00261E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasWeaponTypeId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x00263C88 File Offset: 0x00261E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearWeaponTypeId()
		{
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x060083C7 RID: 33735 RVA: 0x00263C98 File Offset: 0x00261E98
		// (set) Token: 0x060083C8 RID: 33736 RVA: 0x00263CA8 File Offset: 0x00261EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateId
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

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x060083C9 RID: 33737 RVA: 0x00263CB8 File Offset: 0x00261EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStateId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x00263CC8 File Offset: 0x00261EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearStateId()
		{
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x060083CB RID: 33739 RVA: 0x00263CD8 File Offset: 0x00261ED8
		// (set) Token: 0x060083CC RID: 33740 RVA: 0x00263CE8 File Offset: 0x00261EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightTemporaryBoostEffect.Types.Details Details
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

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x060083CD RID: 33741 RVA: 0x00263CF8 File Offset: 0x00261EF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTemporaryBoostEffect.ComplementOneofCase ComplementCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightTemporaryBoostEffect.ComplementOneofCase)null;
			}
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x00263D0C File Offset: 0x00261F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearComplement()
		{
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x00263D1C File Offset: 0x00261F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x00263D2C File Offset: 0x00261F2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightTemporaryBoostEffect other)
		{
			return true;
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x00263D3C File Offset: 0x00261F3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x00263D4C File Offset: 0x00261F4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x00263D5C File Offset: 0x00261F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x00263D6C File Offset: 0x00261F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x00263D7C File Offset: 0x00261F7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x00263D8C File Offset: 0x00261F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightTemporaryBoostEffect other)
		{
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x00263D9C File Offset: 0x00261F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x00263DAC File Offset: 0x00261FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x00263DBC File Offset: 0x00261FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightTemporaryBoostEffect()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					FightTemporaryBoostEffect._parser = new MessageParser<FightTemporaryBoostEffect>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x00263E88 File Offset: 0x00262088
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E2XlgXJsUXA2pb3ltXuD()
		{
			return true;
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x00263E90 File Offset: 0x00262090
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightTemporaryBoostEffect L9Yy4bJsvv9QXLf1iZ6o()
		{
			return null;
		}

		// Token: 0x04003017 RID: 12311
		private static readonly MessageParser<FightTemporaryBoostEffect> _parser;

		// Token: 0x04003018 RID: 12312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003019 RID: 12313
		public const int DeltaFieldNumber = 1;

		// Token: 0x0400301A RID: 12314
		private int delta_;

		// Token: 0x0400301B RID: 12315
		public const int BoostedSpellIdFieldNumber = 2;

		// Token: 0x0400301C RID: 12316
		public const int WeaponTypeIdFieldNumber = 3;

		// Token: 0x0400301D RID: 12317
		public const int StateIdFieldNumber = 4;

		// Token: 0x0400301E RID: 12318
		public const int DetailsFieldNumber = 5;

		// Token: 0x0400301F RID: 12319
		private object complement_;

		// Token: 0x04003020 RID: 12320
		private FightTemporaryBoostEffect.ComplementOneofCase complementCase_;

		// Token: 0x04003021 RID: 12321
		private static FightTemporaryBoostEffect Y9MPPOJscuL2uN707AjO;

		// Token: 0x02000AC4 RID: 2756
		public enum ComplementOneofCase
		{
			// Token: 0x04003023 RID: 12323
			None,
			// Token: 0x04003024 RID: 12324
			BoostedSpellId = 2,
			// Token: 0x04003025 RID: 12325
			WeaponTypeId,
			// Token: 0x04003026 RID: 12326
			StateId,
			// Token: 0x04003027 RID: 12327
			Details
		}

		// Token: 0x02000AC5 RID: 2757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060083DC RID: 33756 RVA: 0x002E1E98 File Offset: 0x002E0098
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000AC6 RID: 2758
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Details : IMessage<FightTemporaryBoostEffect.Types.Details>, IMessage, IEquatable<FightTemporaryBoostEffect.Types.Details>, IDeepCloneable<FightTemporaryBoostEffect.Types.Details>, IBufferMessage
			{
				// Token: 0x1700182E RID: 6190
				// (get) Token: 0x060083DD RID: 33757 RVA: 0x00308B90 File Offset: 0x00306D90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<FightTemporaryBoostEffect.Types.Details> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x1700182F RID: 6191
				// (get) Token: 0x060083DE RID: 33758 RVA: 0x00308BA0 File Offset: 0x00306DA0
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

				// Token: 0x17001830 RID: 6192
				// (get) Token: 0x060083DF RID: 33759 RVA: 0x00308BB0 File Offset: 0x00306DB0
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

				// Token: 0x060083E0 RID: 33760 RVA: 0x00308BC0 File Offset: 0x00306DC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Details()
				{
				}

				// Token: 0x060083E1 RID: 33761 RVA: 0x00308BD0 File Offset: 0x00306DD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Details(FightTemporaryBoostEffect.Types.Details other)
				{
				}

				// Token: 0x060083E2 RID: 33762 RVA: 0x00308BE0 File Offset: 0x00306DE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public FightTemporaryBoostEffect.Types.Details Clone()
				{
					return null;
				}

				// Token: 0x17001831 RID: 6193
				// (get) Token: 0x060083E3 RID: 33763 RVA: 0x00308BF0 File Offset: 0x00306DF0
				// (set) Token: 0x060083E4 RID: 33764 RVA: 0x00308C00 File Offset: 0x00306E00
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int FirstParam
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

				// Token: 0x17001832 RID: 6194
				// (get) Token: 0x060083E5 RID: 33765 RVA: 0x00308C10 File Offset: 0x00306E10
				// (set) Token: 0x060083E6 RID: 33766 RVA: 0x00308C20 File Offset: 0x00306E20
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int SecondParam
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

				// Token: 0x17001833 RID: 6195
				// (get) Token: 0x060083E7 RID: 33767 RVA: 0x00308C30 File Offset: 0x00306E30
				// (set) Token: 0x060083E8 RID: 33768 RVA: 0x00308C40 File Offset: 0x00306E40
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ThirdParam
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

				// Token: 0x060083E9 RID: 33769 RVA: 0x00308C50 File Offset: 0x00306E50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060083EA RID: 33770 RVA: 0x00308C60 File Offset: 0x00306E60
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(FightTemporaryBoostEffect.Types.Details other)
				{
					return true;
				}

				// Token: 0x060083EB RID: 33771 RVA: 0x00308C70 File Offset: 0x00306E70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060083EC RID: 33772 RVA: 0x00308C80 File Offset: 0x00306E80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060083ED RID: 33773 RVA: 0x00308C90 File Offset: 0x00306E90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060083EE RID: 33774 RVA: 0x00308CA0 File Offset: 0x00306EA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060083EF RID: 33775 RVA: 0x00308CB0 File Offset: 0x00306EB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060083F0 RID: 33776 RVA: 0x00308CC0 File Offset: 0x00306EC0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(FightTemporaryBoostEffect.Types.Details other)
				{
				}

				// Token: 0x060083F1 RID: 33777 RVA: 0x00308CD0 File Offset: 0x00306ED0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060083F2 RID: 33778 RVA: 0x00308CE0 File Offset: 0x00306EE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060083F3 RID: 33779 RVA: 0x00308CF0 File Offset: 0x00306EF0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Details()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							FightTemporaryBoostEffect.Types.Details._parser = new MessageParser<FightTemporaryBoostEffect.Types.Details>(() => null);
							num2 = 4;
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
							{
								num2 = 0;
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
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x060083F4 RID: 33780 RVA: 0x00308DBC File Offset: 0x00306FBC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool IFxNNPGutTNLeKWKGbVt()
				{
					return true;
				}

				// Token: 0x060083F5 RID: 33781 RVA: 0x00308DC4 File Offset: 0x00306FC4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static FightTemporaryBoostEffect.Types.Details o69pS1GuwoQWFGthpooq()
				{
					return null;
				}

				// Token: 0x04003028 RID: 12328
				private static readonly MessageParser<FightTemporaryBoostEffect.Types.Details> _parser;

				// Token: 0x04003029 RID: 12329
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400302A RID: 12330
				public const int FirstParamFieldNumber = 1;

				// Token: 0x0400302B RID: 12331
				private int firstParam_;

				// Token: 0x0400302C RID: 12332
				public const int SecondParamFieldNumber = 2;

				// Token: 0x0400302D RID: 12333
				private int secondParam_;

				// Token: 0x0400302E RID: 12334
				public const int ThirdParamFieldNumber = 3;

				// Token: 0x0400302F RID: 12335
				private int thirdParam_;

				// Token: 0x04003030 RID: 12336
				private static FightTemporaryBoostEffect.Types.Details Y4XVtAGuDt3p3pGMArZR;
			}
		}
	}
}
