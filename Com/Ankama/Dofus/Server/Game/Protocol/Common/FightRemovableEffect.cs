using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000ABE RID: 2750
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightRemovableEffect : IMessage<FightRemovableEffect>, IMessage, IEquatable<FightRemovableEffect>, IDeepCloneable<FightRemovableEffect>, IBufferMessage
	{
		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06008388 RID: 33672 RVA: 0x00263854 File Offset: 0x00261A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightRemovableEffect> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06008389 RID: 33673 RVA: 0x00263864 File Offset: 0x00261A64
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

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x0600838A RID: 33674 RVA: 0x00263874 File Offset: 0x00261A74
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

		// Token: 0x0600838B RID: 33675 RVA: 0x00263884 File Offset: 0x00261A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRemovableEffect()
		{
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x00263894 File Offset: 0x00261A94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRemovableEffect(FightRemovableEffect other)
		{
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x002638A4 File Offset: 0x00261AA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightRemovableEffect Clone()
		{
			return null;
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600838E RID: 33678 RVA: 0x002638B4 File Offset: 0x00261AB4
		// (set) Token: 0x0600838F RID: 33679 RVA: 0x002638C4 File Offset: 0x00261AC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Uid
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

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06008390 RID: 33680 RVA: 0x002638D4 File Offset: 0x00261AD4
		// (set) Token: 0x06008391 RID: 33681 RVA: 0x002638E4 File Offset: 0x00261AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
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

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06008392 RID: 33682 RVA: 0x002638F4 File Offset: 0x00261AF4
		// (set) Token: 0x06008393 RID: 33683 RVA: 0x00263904 File Offset: 0x00261B04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TurnDuration
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

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06008394 RID: 33684 RVA: 0x00263914 File Offset: 0x00261B14
		// (set) Token: 0x06008395 RID: 33685 RVA: 0x00263928 File Offset: 0x00261B28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightRemovableEffect.Types.EffectDissipationState DissipationState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightRemovableEffect.Types.EffectDissipationState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06008396 RID: 33686 RVA: 0x00263938 File Offset: 0x00261B38
		// (set) Token: 0x06008397 RID: 33687 RVA: 0x00263948 File Offset: 0x00261B48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellId
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

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06008398 RID: 33688 RVA: 0x00263958 File Offset: 0x00261B58
		// (set) Token: 0x06008399 RID: 33689 RVA: 0x00263968 File Offset: 0x00261B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int EffectId
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

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600839A RID: 33690 RVA: 0x00263978 File Offset: 0x00261B78
		// (set) Token: 0x0600839B RID: 33691 RVA: 0x00263988 File Offset: 0x00261B88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ParentBoostId
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

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x0600839C RID: 33692 RVA: 0x00263998 File Offset: 0x00261B98
		// (set) Token: 0x0600839D RID: 33693 RVA: 0x002639A8 File Offset: 0x00261BA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTemporaryBoostEffect TemporaryBoostEffect
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

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x0600839E RID: 33694 RVA: 0x002639B8 File Offset: 0x00261BB8
		// (set) Token: 0x0600839F RID: 33695 RVA: 0x002639C8 File Offset: 0x00261BC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTemporarySpellImmunityEffect TemporarySpellImmunityEffect
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

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x060083A0 RID: 33696 RVA: 0x002639D8 File Offset: 0x00261BD8
		// (set) Token: 0x060083A1 RID: 33697 RVA: 0x002639E8 File Offset: 0x00261BE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightTriggeredEffect TriggeredEffect
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

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x060083A2 RID: 33698 RVA: 0x002639F8 File Offset: 0x00261BF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightRemovableEffect.EffectOneofCase EffectCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightRemovableEffect.EffectOneofCase)null;
			}
		}

		// Token: 0x060083A3 RID: 33699 RVA: 0x00263A0C File Offset: 0x00261C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEffect()
		{
		}

		// Token: 0x060083A4 RID: 33700 RVA: 0x00263A1C File Offset: 0x00261C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060083A5 RID: 33701 RVA: 0x00263A2C File Offset: 0x00261C2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightRemovableEffect other)
		{
			return true;
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x00263A3C File Offset: 0x00261C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x00263A4C File Offset: 0x00261C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x00263A5C File Offset: 0x00261C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x00263A6C File Offset: 0x00261C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x00263A7C File Offset: 0x00261C7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060083AB RID: 33707 RVA: 0x00263A8C File Offset: 0x00261C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightRemovableEffect other)
		{
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x00263A9C File Offset: 0x00261C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060083AD RID: 33709 RVA: 0x00263AAC File Offset: 0x00261CAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x00263ABC File Offset: 0x00261CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightRemovableEffect()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					FightRemovableEffect._parser = new MessageParser<FightRemovableEffect>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x060083AF RID: 33711 RVA: 0x00263B88 File Offset: 0x00261D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AFLhUNJskgpP63hqKvZw()
		{
			return true;
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x00263B90 File Offset: 0x00261D90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightRemovableEffect fVuw1OJsl6Vspb6mEtSI()
		{
			return null;
		}

		// Token: 0x04002FF5 RID: 12277
		private static readonly MessageParser<FightRemovableEffect> _parser;

		// Token: 0x04002FF6 RID: 12278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF7 RID: 12279
		public const int UidFieldNumber = 1;

		// Token: 0x04002FF8 RID: 12280
		private int uid_;

		// Token: 0x04002FF9 RID: 12281
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002FFA RID: 12282
		private long targetId_;

		// Token: 0x04002FFB RID: 12283
		public const int TurnDurationFieldNumber = 3;

		// Token: 0x04002FFC RID: 12284
		private int turnDuration_;

		// Token: 0x04002FFD RID: 12285
		public const int DissipationStateFieldNumber = 4;

		// Token: 0x04002FFE RID: 12286
		private FightRemovableEffect.Types.EffectDissipationState dissipationState_;

		// Token: 0x04002FFF RID: 12287
		public const int SpellIdFieldNumber = 5;

		// Token: 0x04003000 RID: 12288
		private int spellId_;

		// Token: 0x04003001 RID: 12289
		public const int EffectIdFieldNumber = 6;

		// Token: 0x04003002 RID: 12290
		private int effectId_;

		// Token: 0x04003003 RID: 12291
		public const int ParentBoostIdFieldNumber = 7;

		// Token: 0x04003004 RID: 12292
		private int parentBoostId_;

		// Token: 0x04003005 RID: 12293
		public const int TemporaryBoostEffectFieldNumber = 8;

		// Token: 0x04003006 RID: 12294
		public const int TemporarySpellImmunityEffectFieldNumber = 9;

		// Token: 0x04003007 RID: 12295
		public const int TriggeredEffectFieldNumber = 10;

		// Token: 0x04003008 RID: 12296
		private object effect_;

		// Token: 0x04003009 RID: 12297
		private FightRemovableEffect.EffectOneofCase effectCase_;

		// Token: 0x0400300A RID: 12298
		private static FightRemovableEffect fuwedkJsIXIhKooVmiDI;

		// Token: 0x02000ABF RID: 2751
		public enum EffectOneofCase
		{
			// Token: 0x0400300C RID: 12300
			None,
			// Token: 0x0400300D RID: 12301
			TemporaryBoostEffect = 8,
			// Token: 0x0400300E RID: 12302
			TemporarySpellImmunityEffect,
			// Token: 0x0400300F RID: 12303
			TriggeredEffect
		}

		// Token: 0x02000AC0 RID: 2752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060083B1 RID: 33713 RVA: 0x002E1D88 File Offset: 0x002DFF88
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000AC1 RID: 2753
			public enum EffectDissipationState
			{
				// Token: 0x04003011 RID: 12305
				[OriginalName("DISSIPATED")]
				Dissipated,
				// Token: 0x04003012 RID: 12306
				[OriginalName("DISSIPATED_BY_DEATH")]
				DissipatedByDeath,
				// Token: 0x04003013 RID: 12307
				[OriginalName("DISSIPATED_BY_STRONG_DISPEL")]
				DissipatedByStrongDispel,
				// Token: 0x04003014 RID: 12308
				[OriginalName("REALLY_NOT_DISSIPATED")]
				ReallyNotDissipated
			}
		}
	}
}
