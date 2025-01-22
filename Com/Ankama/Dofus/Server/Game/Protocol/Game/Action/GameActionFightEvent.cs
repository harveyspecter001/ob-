using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action
{
	// Token: 0x020005C7 RID: 1479
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameActionFightEvent : IMessage<GameActionFightEvent>, IMessage, IEquatable<GameActionFightEvent>, IDeepCloneable<GameActionFightEvent>, IBufferMessage
	{
		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x001FE480 File Offset: 0x001FC680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameActionFightEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x001FE490 File Offset: 0x001FC690
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

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x001FE4A0 File Offset: 0x001FC6A0
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

		// Token: 0x0600475B RID: 18267 RVA: 0x001FE4B0 File Offset: 0x001FC6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightEvent()
		{
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x001FE4C0 File Offset: 0x001FC6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightEvent(GameActionFightEvent other)
		{
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x001FE4D0 File Offset: 0x001FC6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameActionFightEvent Clone()
		{
			return null;
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x001FE4E0 File Offset: 0x001FC6E0
		// (set) Token: 0x0600475F RID: 18271 RVA: 0x001FE4F0 File Offset: 0x001FC6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
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

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x001FE500 File Offset: 0x001FC700
		// (set) Token: 0x06004761 RID: 18273 RVA: 0x001FE510 File Offset: 0x001FC710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SourceId
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x001FE520 File Offset: 0x001FC720
		// (set) Token: 0x06004763 RID: 18275 RVA: 0x001FE530 File Offset: 0x001FC730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.Slide Slide
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

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x001FE540 File Offset: 0x001FC740
		// (set) Token: 0x06004765 RID: 18277 RVA: 0x001FE550 File Offset: 0x001FC750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.DodgePointLoss DodgePointLoss
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

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x001FE560 File Offset: 0x001FC760
		// (set) Token: 0x06004767 RID: 18279 RVA: 0x001FE570 File Offset: 0x001FC770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.ReflectDamages ReflectDamages
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x001FE580 File Offset: 0x001FC780
		// (set) Token: 0x06004769 RID: 18281 RVA: 0x001FE590 File Offset: 0x001FC790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.ReduceDamages ReduceDamages
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x001FE5A0 File Offset: 0x001FC7A0
		// (set) Token: 0x0600476B RID: 18283 RVA: 0x001FE5B0 File Offset: 0x001FC7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.ReflectSpell ReflectSpell
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

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x001FE5C0 File Offset: 0x001FC7C0
		// (set) Token: 0x0600476D RID: 18285 RVA: 0x001FE5D0 File Offset: 0x001FC7D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.RemovableEffect RemovableEffect
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x001FE5E0 File Offset: 0x001FC7E0
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x001FE5F0 File Offset: 0x001FC7F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.LifePointsLost LifePointsLost
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

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x001FE600 File Offset: 0x001FC800
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x001FE610 File Offset: 0x001FC810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.LifePointsGain LifePointsGain
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

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x001FE620 File Offset: 0x001FC820
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x001FE630 File Offset: 0x001FC830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.SpellImmunity SpellImmunity
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

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x001FE640 File Offset: 0x001FC840
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x001FE650 File Offset: 0x001FC850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.SpellCoolDownVariation SpellCoolDownVariation
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

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x001FE660 File Offset: 0x001FC860
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x001FE670 File Offset: 0x001FC870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.Vanish Vanish
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

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x001FE680 File Offset: 0x001FC880
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x001FE690 File Offset: 0x001FC890
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.Kill Kill
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

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x001FE6A0 File Offset: 0x001FC8A0
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x001FE6B0 File Offset: 0x001FC8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.Death Death
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

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x001FE6C0 File Offset: 0x001FC8C0
		// (set) Token: 0x0600477D RID: 18301 RVA: 0x001FE6D0 File Offset: 0x001FC8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.TargetedAbility TargetedAbility
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

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x001FE6E0 File Offset: 0x001FC8E0
		// (set) Token: 0x0600477F RID: 18303 RVA: 0x001FE6F0 File Offset: 0x001FC8F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.Tackled Tackled
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

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x001FE700 File Offset: 0x001FC900
		// (set) Token: 0x06004781 RID: 18305 RVA: 0x001FE710 File Offset: 0x001FC910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.PointsVariation PointsVariation
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

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x001FE720 File Offset: 0x001FC920
		// (set) Token: 0x06004783 RID: 18307 RVA: 0x001FE730 File Offset: 0x001FC930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.InvisibleDetected InvisibleDetected
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

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x001FE740 File Offset: 0x001FC940
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x001FE750 File Offset: 0x001FC950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.TeleportOnSameMap TeleportOnSameMap
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

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x001FE760 File Offset: 0x001FC960
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x001FE770 File Offset: 0x001FC970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.ExchangePositions ExchangePositions
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

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x001FE780 File Offset: 0x001FC980
		// (set) Token: 0x06004789 RID: 18313 RVA: 0x001FE790 File Offset: 0x001FC990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.SpellRemove SpellRemove
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

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x001FE7A0 File Offset: 0x001FC9A0
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x001FE7B0 File Offset: 0x001FC9B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.ModifyEffectsDuration ModifyEffectsDuration
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

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x001FE7C0 File Offset: 0x001FC9C0
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x001FE7D0 File Offset: 0x001FC9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.StealKama StealKama
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

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x001FE7E0 File Offset: 0x001FC9E0
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x001FE7F0 File Offset: 0x001FC9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.ChangeLook ChangeLook
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

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x001FE800 File Offset: 0x001FCA00
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x001FE810 File Offset: 0x001FCA10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.Invisibility Invisibility
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

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x001FE820 File Offset: 0x001FCA20
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x001FE830 File Offset: 0x001FCA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.Summons Summons
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

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x001FE840 File Offset: 0x001FCA40
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x001FE850 File Offset: 0x001FCA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.MarkCells MarkCells
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

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x001FE860 File Offset: 0x001FCA60
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x001FE870 File Offset: 0x001FCA70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.UnmarkCells UnmarkCells
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

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x001FE880 File Offset: 0x001FCA80
		// (set) Token: 0x06004799 RID: 18329 RVA: 0x001FE890 File Offset: 0x001FCA90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.TriggerGlyphTrap TriggerGlyphTrap
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

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x001FE8A0 File Offset: 0x001FCAA0
		// (set) Token: 0x0600479B RID: 18331 RVA: 0x001FE8B0 File Offset: 0x001FCAB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public GameActionFightEvent.Types.ActivateGlyphTrap ActivateGlyphTrap
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

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x001FE8C0 File Offset: 0x001FCAC0
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x001FE8D0 File Offset: 0x001FCAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.CarryCharacter CarryCharacter
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

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600479E RID: 18334 RVA: 0x001FE8E0 File Offset: 0x001FCAE0
		// (set) Token: 0x0600479F RID: 18335 RVA: 0x001FE8F0 File Offset: 0x001FCAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.ThrowCharacter ThrowCharacter
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

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060047A0 RID: 18336 RVA: 0x001FE900 File Offset: 0x001FCB00
		// (set) Token: 0x060047A1 RID: 18337 RVA: 0x001FE910 File Offset: 0x001FCB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.DropCharacter DropCharacter
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

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060047A2 RID: 18338 RVA: 0x001FE920 File Offset: 0x001FCB20
		// (set) Token: 0x060047A3 RID: 18339 RVA: 0x001FE930 File Offset: 0x001FCB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.Types.ExecuteScript ExecuteScript
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

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x001FE940 File Offset: 0x001FCB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameActionFightEvent.ActionOneofCase ActionCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (GameActionFightEvent.ActionOneofCase)null;
			}
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x001FE954 File Offset: 0x001FCB54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAction()
		{
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x001FE964 File Offset: 0x001FCB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x001FE974 File Offset: 0x001FCB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GameActionFightEvent other)
		{
			return true;
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x001FE984 File Offset: 0x001FCB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x001FE994 File Offset: 0x001FCB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x001FE9A4 File Offset: 0x001FCBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x001FE9B4 File Offset: 0x001FCBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x001FE9C4 File Offset: 0x001FCBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x001FE9D4 File Offset: 0x001FCBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GameActionFightEvent other)
		{
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x001FE9E4 File Offset: 0x001FCBE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x001FE9F4 File Offset: 0x001FCBF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x001FEA04 File Offset: 0x001FCC04
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GameActionFightEvent()
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_87;
					case 4:
						GameActionFightEvent._parser = new MessageParser<GameActionFightEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_87:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 2;
			}
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x001FEAEC File Offset: 0x001FCCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C6F9JiObHVfsjMFVmHbD()
		{
			return true;
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x001FEAF4 File Offset: 0x001FCCF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GameActionFightEvent SiZrUeObY43UHiwqVr8U()
		{
			return null;
		}

		// Token: 0x040018B9 RID: 6329
		private static readonly MessageParser<GameActionFightEvent> _parser;

		// Token: 0x040018BA RID: 6330
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018BB RID: 6331
		public const int ActionIdFieldNumber = 1;

		// Token: 0x040018BC RID: 6332
		private int actionId_;

		// Token: 0x040018BD RID: 6333
		public const int SourceIdFieldNumber = 2;

		// Token: 0x040018BE RID: 6334
		private long sourceId_;

		// Token: 0x040018BF RID: 6335
		public const int SlideFieldNumber = 3;

		// Token: 0x040018C0 RID: 6336
		public const int DodgePointLossFieldNumber = 4;

		// Token: 0x040018C1 RID: 6337
		public const int ReflectDamagesFieldNumber = 5;

		// Token: 0x040018C2 RID: 6338
		public const int ReduceDamagesFieldNumber = 6;

		// Token: 0x040018C3 RID: 6339
		public const int ReflectSpellFieldNumber = 7;

		// Token: 0x040018C4 RID: 6340
		public const int RemovableEffectFieldNumber = 8;

		// Token: 0x040018C5 RID: 6341
		public const int LifePointsLostFieldNumber = 9;

		// Token: 0x040018C6 RID: 6342
		public const int LifePointsGainFieldNumber = 10;

		// Token: 0x040018C7 RID: 6343
		public const int SpellImmunityFieldNumber = 11;

		// Token: 0x040018C8 RID: 6344
		public const int SpellCoolDownVariationFieldNumber = 12;

		// Token: 0x040018C9 RID: 6345
		public const int VanishFieldNumber = 13;

		// Token: 0x040018CA RID: 6346
		public const int KillFieldNumber = 14;

		// Token: 0x040018CB RID: 6347
		public const int DeathFieldNumber = 15;

		// Token: 0x040018CC RID: 6348
		public const int TargetedAbilityFieldNumber = 16;

		// Token: 0x040018CD RID: 6349
		public const int TackledFieldNumber = 17;

		// Token: 0x040018CE RID: 6350
		public const int PointsVariationFieldNumber = 18;

		// Token: 0x040018CF RID: 6351
		public const int InvisibleDetectedFieldNumber = 19;

		// Token: 0x040018D0 RID: 6352
		public const int TeleportOnSameMapFieldNumber = 20;

		// Token: 0x040018D1 RID: 6353
		public const int ExchangePositionsFieldNumber = 21;

		// Token: 0x040018D2 RID: 6354
		public const int SpellRemoveFieldNumber = 22;

		// Token: 0x040018D3 RID: 6355
		public const int ModifyEffectsDurationFieldNumber = 23;

		// Token: 0x040018D4 RID: 6356
		public const int StealKamaFieldNumber = 24;

		// Token: 0x040018D5 RID: 6357
		public const int ChangeLookFieldNumber = 25;

		// Token: 0x040018D6 RID: 6358
		public const int InvisibilityFieldNumber = 26;

		// Token: 0x040018D7 RID: 6359
		public const int SummonsFieldNumber = 27;

		// Token: 0x040018D8 RID: 6360
		public const int MarkCellsFieldNumber = 28;

		// Token: 0x040018D9 RID: 6361
		public const int UnmarkCellsFieldNumber = 29;

		// Token: 0x040018DA RID: 6362
		public const int TriggerGlyphTrapFieldNumber = 30;

		// Token: 0x040018DB RID: 6363
		public const int ActivateGlyphTrapFieldNumber = 31;

		// Token: 0x040018DC RID: 6364
		public const int CarryCharacterFieldNumber = 32;

		// Token: 0x040018DD RID: 6365
		public const int ThrowCharacterFieldNumber = 33;

		// Token: 0x040018DE RID: 6366
		public const int DropCharacterFieldNumber = 34;

		// Token: 0x040018DF RID: 6367
		public const int ExecuteScriptFieldNumber = 35;

		// Token: 0x040018E0 RID: 6368
		private object action_;

		// Token: 0x040018E1 RID: 6369
		private GameActionFightEvent.ActionOneofCase actionCase_;

		// Token: 0x040018E2 RID: 6370
		internal static GameActionFightEvent C0HGscObpKCemZ7k487n;

		// Token: 0x020005C8 RID: 1480
		public enum ActionOneofCase
		{
			// Token: 0x040018E4 RID: 6372
			None,
			// Token: 0x040018E5 RID: 6373
			Slide = 3,
			// Token: 0x040018E6 RID: 6374
			DodgePointLoss,
			// Token: 0x040018E7 RID: 6375
			ReflectDamages,
			// Token: 0x040018E8 RID: 6376
			ReduceDamages,
			// Token: 0x040018E9 RID: 6377
			ReflectSpell,
			// Token: 0x040018EA RID: 6378
			RemovableEffect,
			// Token: 0x040018EB RID: 6379
			LifePointsLost,
			// Token: 0x040018EC RID: 6380
			LifePointsGain,
			// Token: 0x040018ED RID: 6381
			SpellImmunity,
			// Token: 0x040018EE RID: 6382
			SpellCoolDownVariation,
			// Token: 0x040018EF RID: 6383
			Vanish,
			// Token: 0x040018F0 RID: 6384
			Kill,
			// Token: 0x040018F1 RID: 6385
			Death,
			// Token: 0x040018F2 RID: 6386
			TargetedAbility,
			// Token: 0x040018F3 RID: 6387
			Tackled,
			// Token: 0x040018F4 RID: 6388
			PointsVariation,
			// Token: 0x040018F5 RID: 6389
			InvisibleDetected,
			// Token: 0x040018F6 RID: 6390
			TeleportOnSameMap,
			// Token: 0x040018F7 RID: 6391
			ExchangePositions,
			// Token: 0x040018F8 RID: 6392
			SpellRemove,
			// Token: 0x040018F9 RID: 6393
			ModifyEffectsDuration,
			// Token: 0x040018FA RID: 6394
			StealKama,
			// Token: 0x040018FB RID: 6395
			ChangeLook,
			// Token: 0x040018FC RID: 6396
			Invisibility,
			// Token: 0x040018FD RID: 6397
			Summons,
			// Token: 0x040018FE RID: 6398
			MarkCells,
			// Token: 0x040018FF RID: 6399
			UnmarkCells,
			// Token: 0x04001900 RID: 6400
			TriggerGlyphTrap,
			// Token: 0x04001901 RID: 6401
			ActivateGlyphTrap,
			// Token: 0x04001902 RID: 6402
			CarryCharacter,
			// Token: 0x04001903 RID: 6403
			ThrowCharacter,
			// Token: 0x04001904 RID: 6404
			DropCharacter,
			// Token: 0x04001905 RID: 6405
			ExecuteScript
		}

		// Token: 0x020005C9 RID: 1481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060047B3 RID: 18355 RVA: 0x002C8E88 File Offset: 0x002C7088
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020005CA RID: 1482
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class CarryCharacter : IMessage<GameActionFightEvent.Types.CarryCharacter>, IMessage, IEquatable<GameActionFightEvent.Types.CarryCharacter>, IDeepCloneable<GameActionFightEvent.Types.CarryCharacter>, IBufferMessage
			{
				// Token: 0x17000CE3 RID: 3299
				// (get) Token: 0x060047B4 RID: 18356 RVA: 0x002FCA20 File Offset: 0x002FAC20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.CarryCharacter> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CE4 RID: 3300
				// (get) Token: 0x060047B5 RID: 18357 RVA: 0x002FCA30 File Offset: 0x002FAC30
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

				// Token: 0x17000CE5 RID: 3301
				// (get) Token: 0x060047B6 RID: 18358 RVA: 0x002FCA40 File Offset: 0x002FAC40
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

				// Token: 0x060047B7 RID: 18359 RVA: 0x002FCA50 File Offset: 0x002FAC50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CarryCharacter()
				{
				}

				// Token: 0x060047B8 RID: 18360 RVA: 0x002FCA60 File Offset: 0x002FAC60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public CarryCharacter(GameActionFightEvent.Types.CarryCharacter other)
				{
				}

				// Token: 0x060047B9 RID: 18361 RVA: 0x002FCA70 File Offset: 0x002FAC70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.CarryCharacter Clone()
				{
					return null;
				}

				// Token: 0x17000CE6 RID: 3302
				// (get) Token: 0x060047BA RID: 18362 RVA: 0x002FCA80 File Offset: 0x002FAC80
				// (set) Token: 0x060047BB RID: 18363 RVA: 0x002FCA90 File Offset: 0x002FAC90
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000CE7 RID: 3303
				// (get) Token: 0x060047BC RID: 18364 RVA: 0x002FCAA0 File Offset: 0x002FACA0
				// (set) Token: 0x060047BD RID: 18365 RVA: 0x002FCAB0 File Offset: 0x002FACB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Cell
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

				// Token: 0x060047BE RID: 18366 RVA: 0x002FCAC0 File Offset: 0x002FACC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060047BF RID: 18367 RVA: 0x002FCAD0 File Offset: 0x002FACD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.CarryCharacter other)
				{
					return true;
				}

				// Token: 0x060047C0 RID: 18368 RVA: 0x002FCAE0 File Offset: 0x002FACE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060047C1 RID: 18369 RVA: 0x002FCAF0 File Offset: 0x002FACF0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060047C2 RID: 18370 RVA: 0x002FCB00 File Offset: 0x002FAD00
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060047C3 RID: 18371 RVA: 0x002FCB10 File Offset: 0x002FAD10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060047C4 RID: 18372 RVA: 0x002FCB20 File Offset: 0x002FAD20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060047C5 RID: 18373 RVA: 0x002FCB30 File Offset: 0x002FAD30
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.CarryCharacter other)
				{
				}

				// Token: 0x060047C6 RID: 18374 RVA: 0x002FCB40 File Offset: 0x002FAD40
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060047C7 RID: 18375 RVA: 0x002FCB50 File Offset: 0x002FAD50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060047C8 RID: 18376 RVA: 0x002FCB60 File Offset: 0x002FAD60
				[MethodImpl(MethodImplOptions.NoInlining)]
				static CarryCharacter()
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
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							GameActionFightEvent.Types.CarryCharacter._parser = new MessageParser<GameActionFightEvent.Types.CarryCharacter>(() => null);
							num2 = 4;
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
							{
								num2 = 2;
							}
							break;
						case 4:
							return;
						}
					}
				}

				// Token: 0x060047C9 RID: 18377 RVA: 0x002FCC44 File Offset: 0x002FAE44
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Y9tZLDGbgCURSyQ7I7D3()
				{
					return true;
				}

				// Token: 0x060047CA RID: 18378 RVA: 0x002FCC4C File Offset: 0x002FAE4C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.CarryCharacter BVvVJZGbsLxXAbeA5Kvg()
				{
					return null;
				}

				// Token: 0x04001906 RID: 6406
				private static readonly MessageParser<GameActionFightEvent.Types.CarryCharacter> _parser;

				// Token: 0x04001907 RID: 6407
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001908 RID: 6408
				public const int TargetIdFieldNumber = 3;

				// Token: 0x04001909 RID: 6409
				private long targetId_;

				// Token: 0x0400190A RID: 6410
				public const int CellFieldNumber = 4;

				// Token: 0x0400190B RID: 6411
				private int cell_;

				// Token: 0x0400190C RID: 6412
				internal static GameActionFightEvent.Types.CarryCharacter OZlkW3GbGvVgUV9vshpO;
			}

			// Token: 0x020005CC RID: 1484
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ThrowCharacter : IMessage<GameActionFightEvent.Types.ThrowCharacter>, IMessage, IEquatable<GameActionFightEvent.Types.ThrowCharacter>, IDeepCloneable<GameActionFightEvent.Types.ThrowCharacter>, IBufferMessage
			{
				// Token: 0x17000CE8 RID: 3304
				// (get) Token: 0x060047D0 RID: 18384 RVA: 0x002FCC54 File Offset: 0x002FAE54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.ThrowCharacter> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CE9 RID: 3305
				// (get) Token: 0x060047D1 RID: 18385 RVA: 0x002FCC64 File Offset: 0x002FAE64
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

				// Token: 0x17000CEA RID: 3306
				// (get) Token: 0x060047D2 RID: 18386 RVA: 0x002FCC74 File Offset: 0x002FAE74
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

				// Token: 0x060047D3 RID: 18387 RVA: 0x002FCC84 File Offset: 0x002FAE84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ThrowCharacter()
				{
				}

				// Token: 0x060047D4 RID: 18388 RVA: 0x002FCC94 File Offset: 0x002FAE94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ThrowCharacter(GameActionFightEvent.Types.ThrowCharacter other)
				{
				}

				// Token: 0x060047D5 RID: 18389 RVA: 0x002FCCA4 File Offset: 0x002FAEA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ThrowCharacter Clone()
				{
					return null;
				}

				// Token: 0x17000CEB RID: 3307
				// (get) Token: 0x060047D6 RID: 18390 RVA: 0x002FCCB4 File Offset: 0x002FAEB4
				// (set) Token: 0x060047D7 RID: 18391 RVA: 0x002FCCC4 File Offset: 0x002FAEC4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000CEC RID: 3308
				// (get) Token: 0x060047D8 RID: 18392 RVA: 0x002FCCD4 File Offset: 0x002FAED4
				// (set) Token: 0x060047D9 RID: 18393 RVA: 0x002FCCE4 File Offset: 0x002FAEE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Cell
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

				// Token: 0x060047DA RID: 18394 RVA: 0x002FCCF4 File Offset: 0x002FAEF4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060047DB RID: 18395 RVA: 0x002FCD04 File Offset: 0x002FAF04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ThrowCharacter other)
				{
					return true;
				}

				// Token: 0x060047DC RID: 18396 RVA: 0x002FCD14 File Offset: 0x002FAF14
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060047DD RID: 18397 RVA: 0x002FCD24 File Offset: 0x002FAF24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060047DE RID: 18398 RVA: 0x002FCD34 File Offset: 0x002FAF34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060047DF RID: 18399 RVA: 0x002FCD44 File Offset: 0x002FAF44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060047E0 RID: 18400 RVA: 0x002FCD54 File Offset: 0x002FAF54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060047E1 RID: 18401 RVA: 0x002FCD64 File Offset: 0x002FAF64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ThrowCharacter other)
				{
				}

				// Token: 0x060047E2 RID: 18402 RVA: 0x002FCD74 File Offset: 0x002FAF74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060047E3 RID: 18403 RVA: 0x002FCD84 File Offset: 0x002FAF84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060047E4 RID: 18404 RVA: 0x002FCD94 File Offset: 0x002FAF94
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ThrowCharacter()
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								GameActionFightEvent.Types.ThrowCharacter._parser = new MessageParser<GameActionFightEvent.Types.ThrowCharacter>(() => null);
								num2 = 4;
								continue;
							case 3:
								UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 4:
								return;
							}
							break;
						}
						IL_AC:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num = 3;
						continue;
						goto IL_AC;
					}
				}

				// Token: 0x060047E5 RID: 18405 RVA: 0x002FCE64 File Offset: 0x002FB064
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool XksYMsGb9mibCGaZBTSy()
				{
					return true;
				}

				// Token: 0x060047E6 RID: 18406 RVA: 0x002FCE6C File Offset: 0x002FB06C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ThrowCharacter Xc6JCrGb2VQ0le9JviDw()
				{
					return null;
				}

				// Token: 0x0400190F RID: 6415
				private static readonly MessageParser<GameActionFightEvent.Types.ThrowCharacter> _parser;

				// Token: 0x04001910 RID: 6416
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001911 RID: 6417
				public const int TargetIdFieldNumber = 3;

				// Token: 0x04001912 RID: 6418
				private long targetId_;

				// Token: 0x04001913 RID: 6419
				public const int CellFieldNumber = 4;

				// Token: 0x04001914 RID: 6420
				private int cell_;

				// Token: 0x04001915 RID: 6421
				internal static GameActionFightEvent.Types.ThrowCharacter XQP3pbGbd0KL1yZVGaH0;
			}

			// Token: 0x020005CE RID: 1486
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DropCharacter : IMessage<GameActionFightEvent.Types.DropCharacter>, IMessage, IEquatable<GameActionFightEvent.Types.DropCharacter>, IDeepCloneable<GameActionFightEvent.Types.DropCharacter>, IBufferMessage
			{
				// Token: 0x17000CED RID: 3309
				// (get) Token: 0x060047EC RID: 18412 RVA: 0x002FCE74 File Offset: 0x002FB074
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.DropCharacter> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CEE RID: 3310
				// (get) Token: 0x060047ED RID: 18413 RVA: 0x002FCE84 File Offset: 0x002FB084
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

				// Token: 0x17000CEF RID: 3311
				// (get) Token: 0x060047EE RID: 18414 RVA: 0x002FCE94 File Offset: 0x002FB094
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

				// Token: 0x060047EF RID: 18415 RVA: 0x002FCEA4 File Offset: 0x002FB0A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DropCharacter()
				{
				}

				// Token: 0x060047F0 RID: 18416 RVA: 0x002FCEB4 File Offset: 0x002FB0B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DropCharacter(GameActionFightEvent.Types.DropCharacter other)
				{
				}

				// Token: 0x060047F1 RID: 18417 RVA: 0x002FCEC4 File Offset: 0x002FB0C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.DropCharacter Clone()
				{
					return null;
				}

				// Token: 0x17000CF0 RID: 3312
				// (get) Token: 0x060047F2 RID: 18418 RVA: 0x002FCED4 File Offset: 0x002FB0D4
				// (set) Token: 0x060047F3 RID: 18419 RVA: 0x002FCEE4 File Offset: 0x002FB0E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000CF1 RID: 3313
				// (get) Token: 0x060047F4 RID: 18420 RVA: 0x002FCEF4 File Offset: 0x002FB0F4
				// (set) Token: 0x060047F5 RID: 18421 RVA: 0x002FCF04 File Offset: 0x002FB104
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Cell
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

				// Token: 0x060047F6 RID: 18422 RVA: 0x002FCF14 File Offset: 0x002FB114
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060047F7 RID: 18423 RVA: 0x002FCF24 File Offset: 0x002FB124
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.DropCharacter other)
				{
					return true;
				}

				// Token: 0x060047F8 RID: 18424 RVA: 0x002FCF34 File Offset: 0x002FB134
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060047F9 RID: 18425 RVA: 0x002FCF44 File Offset: 0x002FB144
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060047FA RID: 18426 RVA: 0x002FCF54 File Offset: 0x002FB154
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060047FB RID: 18427 RVA: 0x002FCF64 File Offset: 0x002FB164
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060047FC RID: 18428 RVA: 0x002FCF74 File Offset: 0x002FB174
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060047FD RID: 18429 RVA: 0x002FCF84 File Offset: 0x002FB184
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.DropCharacter other)
				{
				}

				// Token: 0x060047FE RID: 18430 RVA: 0x002FCF94 File Offset: 0x002FB194
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060047FF RID: 18431 RVA: 0x002FCFA4 File Offset: 0x002FB1A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004800 RID: 18432 RVA: 0x002FCFB4 File Offset: 0x002FB1B4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DropCharacter()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							GameActionFightEvent.Types.DropCharacter._parser = new MessageParser<GameActionFightEvent.Types.DropCharacter>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004801 RID: 18433 RVA: 0x002FD098 File Offset: 0x002FB298
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool tisrnrGbX95WIlDGO8AG()
				{
					return true;
				}

				// Token: 0x06004802 RID: 18434 RVA: 0x002FD0A0 File Offset: 0x002FB2A0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.DropCharacter qIEWV6GbNsa1jYwgqvxY()
				{
					return null;
				}

				// Token: 0x04001918 RID: 6424
				private static readonly MessageParser<GameActionFightEvent.Types.DropCharacter> _parser;

				// Token: 0x04001919 RID: 6425
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400191A RID: 6426
				public const int TargetIdFieldNumber = 3;

				// Token: 0x0400191B RID: 6427
				private long targetId_;

				// Token: 0x0400191C RID: 6428
				public const int CellFieldNumber = 4;

				// Token: 0x0400191D RID: 6429
				private int cell_;

				// Token: 0x0400191E RID: 6430
				private static GameActionFightEvent.Types.DropCharacter vr3wZfGbErMjpvyfS9aE;
			}

			// Token: 0x020005D0 RID: 1488
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ExecuteScript : IMessage<GameActionFightEvent.Types.ExecuteScript>, IMessage, IEquatable<GameActionFightEvent.Types.ExecuteScript>, IDeepCloneable<GameActionFightEvent.Types.ExecuteScript>, IBufferMessage
			{
				// Token: 0x17000CF2 RID: 3314
				// (get) Token: 0x06004808 RID: 18440 RVA: 0x002FD0A8 File Offset: 0x002FB2A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.ExecuteScript> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CF3 RID: 3315
				// (get) Token: 0x06004809 RID: 18441 RVA: 0x002FD0B8 File Offset: 0x002FB2B8
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

				// Token: 0x17000CF4 RID: 3316
				// (get) Token: 0x0600480A RID: 18442 RVA: 0x002FD0C8 File Offset: 0x002FB2C8
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

				// Token: 0x0600480B RID: 18443 RVA: 0x002FD0D8 File Offset: 0x002FB2D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExecuteScript()
				{
				}

				// Token: 0x0600480C RID: 18444 RVA: 0x002FD0E8 File Offset: 0x002FB2E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExecuteScript(GameActionFightEvent.Types.ExecuteScript other)
				{
				}

				// Token: 0x0600480D RID: 18445 RVA: 0x002FD0F8 File Offset: 0x002FB2F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ExecuteScript Clone()
				{
					return null;
				}

				// Token: 0x17000CF5 RID: 3317
				// (get) Token: 0x0600480E RID: 18446 RVA: 0x002FD108 File Offset: 0x002FB308
				// (set) Token: 0x0600480F RID: 18447 RVA: 0x002FD118 File Offset: 0x002FB318
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ScriptUsageId
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

				// Token: 0x17000CF6 RID: 3318
				// (get) Token: 0x06004810 RID: 18448 RVA: 0x002FD128 File Offset: 0x002FB328
				// (set) Token: 0x06004811 RID: 18449 RVA: 0x002FD138 File Offset: 0x002FB338
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool Critical
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

				// Token: 0x17000CF7 RID: 3319
				// (get) Token: 0x06004812 RID: 18450 RVA: 0x002FD148 File Offset: 0x002FB348
				// (set) Token: 0x06004813 RID: 18451 RVA: 0x002FD158 File Offset: 0x002FB358
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
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

				// Token: 0x17000CF8 RID: 3320
				// (get) Token: 0x06004814 RID: 18452 RVA: 0x002FD168 File Offset: 0x002FB368
				// (set) Token: 0x06004815 RID: 18453 RVA: 0x002FD178 File Offset: 0x002FB378
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int SpellRank
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

				// Token: 0x17000CF9 RID: 3321
				// (get) Token: 0x06004816 RID: 18454 RVA: 0x002FD188 File Offset: 0x002FB388
				// (set) Token: 0x06004817 RID: 18455 RVA: 0x002FD198 File Offset: 0x002FB398
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Cell
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

				// Token: 0x06004818 RID: 18456 RVA: 0x002FD1A8 File Offset: 0x002FB3A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004819 RID: 18457 RVA: 0x002FD1B8 File Offset: 0x002FB3B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ExecuteScript other)
				{
					return true;
				}

				// Token: 0x0600481A RID: 18458 RVA: 0x002FD1C8 File Offset: 0x002FB3C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600481B RID: 18459 RVA: 0x002FD1D8 File Offset: 0x002FB3D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600481C RID: 18460 RVA: 0x002FD1E8 File Offset: 0x002FB3E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600481D RID: 18461 RVA: 0x002FD1F8 File Offset: 0x002FB3F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600481E RID: 18462 RVA: 0x002FD208 File Offset: 0x002FB408
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600481F RID: 18463 RVA: 0x002FD218 File Offset: 0x002FB418
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ExecuteScript other)
				{
				}

				// Token: 0x06004820 RID: 18464 RVA: 0x002FD228 File Offset: 0x002FB428
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004821 RID: 18465 RVA: 0x002FD238 File Offset: 0x002FB438
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004822 RID: 18466 RVA: 0x002FD248 File Offset: 0x002FB448
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExecuteScript()
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
							GameActionFightEvent.Types.ExecuteScript._parser = new MessageParser<GameActionFightEvent.Types.ExecuteScript>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							break;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							break;
						}
					}
				}

				// Token: 0x06004823 RID: 18467 RVA: 0x002FD314 File Offset: 0x002FB514
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool VuwRsSGb4oEejvxKiSMs()
				{
					return true;
				}

				// Token: 0x06004824 RID: 18468 RVA: 0x002FD31C File Offset: 0x002FB51C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ExecuteScript RyYvGfGbjMpdGCEYaieo()
				{
					return null;
				}

				// Token: 0x04001921 RID: 6433
				private static readonly MessageParser<GameActionFightEvent.Types.ExecuteScript> _parser;

				// Token: 0x04001922 RID: 6434
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001923 RID: 6435
				public const int ScriptUsageIdFieldNumber = 1;

				// Token: 0x04001924 RID: 6436
				private int scriptUsageId_;

				// Token: 0x04001925 RID: 6437
				public const int CriticalFieldNumber = 2;

				// Token: 0x04001926 RID: 6438
				private bool critical_;

				// Token: 0x04001927 RID: 6439
				public const int SpellIdFieldNumber = 3;

				// Token: 0x04001928 RID: 6440
				private int spellId_;

				// Token: 0x04001929 RID: 6441
				public const int SpellRankFieldNumber = 4;

				// Token: 0x0400192A RID: 6442
				private int spellRank_;

				// Token: 0x0400192B RID: 6443
				public const int CellFieldNumber = 5;

				// Token: 0x0400192C RID: 6444
				private int cell_;

				// Token: 0x0400192D RID: 6445
				internal static GameActionFightEvent.Types.ExecuteScript yrjaJEGbx17w5QWycrcB;
			}

			// Token: 0x020005D2 RID: 1490
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class UnmarkCells : IMessage<GameActionFightEvent.Types.UnmarkCells>, IMessage, IEquatable<GameActionFightEvent.Types.UnmarkCells>, IDeepCloneable<GameActionFightEvent.Types.UnmarkCells>, IBufferMessage
			{
				// Token: 0x17000CFA RID: 3322
				// (get) Token: 0x0600482A RID: 18474 RVA: 0x002FD324 File Offset: 0x002FB524
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.UnmarkCells> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CFB RID: 3323
				// (get) Token: 0x0600482B RID: 18475 RVA: 0x002FD334 File Offset: 0x002FB534
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

				// Token: 0x17000CFC RID: 3324
				// (get) Token: 0x0600482C RID: 18476 RVA: 0x002FD344 File Offset: 0x002FB544
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

				// Token: 0x0600482D RID: 18477 RVA: 0x002FD354 File Offset: 0x002FB554
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnmarkCells()
				{
				}

				// Token: 0x0600482E RID: 18478 RVA: 0x002FD364 File Offset: 0x002FB564
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public UnmarkCells(GameActionFightEvent.Types.UnmarkCells other)
				{
				}

				// Token: 0x0600482F RID: 18479 RVA: 0x002FD374 File Offset: 0x002FB574
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.UnmarkCells Clone()
				{
					return null;
				}

				// Token: 0x17000CFD RID: 3325
				// (get) Token: 0x06004830 RID: 18480 RVA: 0x002FD384 File Offset: 0x002FB584
				// (set) Token: 0x06004831 RID: 18481 RVA: 0x002FD394 File Offset: 0x002FB594
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MarkId
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

				// Token: 0x06004832 RID: 18482 RVA: 0x002FD3A4 File Offset: 0x002FB5A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004833 RID: 18483 RVA: 0x002FD3B4 File Offset: 0x002FB5B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.UnmarkCells other)
				{
					return true;
				}

				// Token: 0x06004834 RID: 18484 RVA: 0x002FD3C4 File Offset: 0x002FB5C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004835 RID: 18485 RVA: 0x002FD3D4 File Offset: 0x002FB5D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004836 RID: 18486 RVA: 0x002FD3E4 File Offset: 0x002FB5E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004837 RID: 18487 RVA: 0x002FD3F4 File Offset: 0x002FB5F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004838 RID: 18488 RVA: 0x002FD404 File Offset: 0x002FB604
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004839 RID: 18489 RVA: 0x002FD414 File Offset: 0x002FB614
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.UnmarkCells other)
				{
				}

				// Token: 0x0600483A RID: 18490 RVA: 0x002FD424 File Offset: 0x002FB624
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600483B RID: 18491 RVA: 0x002FD434 File Offset: 0x002FB634
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600483C RID: 18492 RVA: 0x002FD444 File Offset: 0x002FB644
				[MethodImpl(MethodImplOptions.NoInlining)]
				static UnmarkCells()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							GameActionFightEvent.Types.UnmarkCells._parser = new MessageParser<GameActionFightEvent.Types.UnmarkCells>(() => null);
							num2 = 2;
							continue;
						case 2:
							return;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
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
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x0600483D RID: 18493 RVA: 0x002FD510 File Offset: 0x002FB710
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool sc5DsSGbInAk1uEUk30G()
				{
					return true;
				}

				// Token: 0x0600483E RID: 18494 RVA: 0x002FD518 File Offset: 0x002FB718
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.UnmarkCells Tc8WYoGbkicvhwIFJD1Q()
				{
					return null;
				}

				// Token: 0x04001930 RID: 6448
				private static readonly MessageParser<GameActionFightEvent.Types.UnmarkCells> _parser;

				// Token: 0x04001931 RID: 6449
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001932 RID: 6450
				public const int MarkIdFieldNumber = 1;

				// Token: 0x04001933 RID: 6451
				private int markId_;

				// Token: 0x04001934 RID: 6452
				internal static GameActionFightEvent.Types.UnmarkCells v89RI8GbKqhplmMuY0cd;
			}

			// Token: 0x020005D4 RID: 1492
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class TriggerGlyphTrap : IMessage<GameActionFightEvent.Types.TriggerGlyphTrap>, IMessage, IEquatable<GameActionFightEvent.Types.TriggerGlyphTrap>, IDeepCloneable<GameActionFightEvent.Types.TriggerGlyphTrap>, IBufferMessage
			{
				// Token: 0x17000CFE RID: 3326
				// (get) Token: 0x06004844 RID: 18500 RVA: 0x002FD520 File Offset: 0x002FB720
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.TriggerGlyphTrap> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CFF RID: 3327
				// (get) Token: 0x06004845 RID: 18501 RVA: 0x002FD530 File Offset: 0x002FB730
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

				// Token: 0x17000D00 RID: 3328
				// (get) Token: 0x06004846 RID: 18502 RVA: 0x002FD540 File Offset: 0x002FB740
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

				// Token: 0x06004847 RID: 18503 RVA: 0x002FD550 File Offset: 0x002FB750
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TriggerGlyphTrap()
				{
				}

				// Token: 0x06004848 RID: 18504 RVA: 0x002FD560 File Offset: 0x002FB760
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TriggerGlyphTrap(GameActionFightEvent.Types.TriggerGlyphTrap other)
				{
				}

				// Token: 0x06004849 RID: 18505 RVA: 0x002FD570 File Offset: 0x002FB770
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.TriggerGlyphTrap Clone()
				{
					return null;
				}

				// Token: 0x17000D01 RID: 3329
				// (get) Token: 0x0600484A RID: 18506 RVA: 0x002FD580 File Offset: 0x002FB780
				// (set) Token: 0x0600484B RID: 18507 RVA: 0x002FD590 File Offset: 0x002FB790
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int MarkId
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

				// Token: 0x17000D02 RID: 3330
				// (get) Token: 0x0600484C RID: 18508 RVA: 0x002FD5A0 File Offset: 0x002FB7A0
				// (set) Token: 0x0600484D RID: 18509 RVA: 0x002FD5B0 File Offset: 0x002FB7B0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int MarkImpactCell
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

				// Token: 0x17000D03 RID: 3331
				// (get) Token: 0x0600484E RID: 18510 RVA: 0x002FD5C0 File Offset: 0x002FB7C0
				// (set) Token: 0x0600484F RID: 18511 RVA: 0x002FD5D0 File Offset: 0x002FB7D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long TriggeringCharacterId
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

				// Token: 0x06004850 RID: 18512 RVA: 0x002FD5E0 File Offset: 0x002FB7E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004851 RID: 18513 RVA: 0x002FD5F0 File Offset: 0x002FB7F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.TriggerGlyphTrap other)
				{
					return true;
				}

				// Token: 0x06004852 RID: 18514 RVA: 0x002FD600 File Offset: 0x002FB800
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004853 RID: 18515 RVA: 0x002FD610 File Offset: 0x002FB810
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004854 RID: 18516 RVA: 0x002FD620 File Offset: 0x002FB820
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004855 RID: 18517 RVA: 0x002FD630 File Offset: 0x002FB830
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004856 RID: 18518 RVA: 0x002FD640 File Offset: 0x002FB840
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004857 RID: 18519 RVA: 0x002FD650 File Offset: 0x002FB850
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.TriggerGlyphTrap other)
				{
				}

				// Token: 0x06004858 RID: 18520 RVA: 0x002FD660 File Offset: 0x002FB860
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004859 RID: 18521 RVA: 0x002FD670 File Offset: 0x002FB870
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600485A RID: 18522 RVA: 0x002FD680 File Offset: 0x002FB880
				[MethodImpl(MethodImplOptions.NoInlining)]
				static TriggerGlyphTrap()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
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
							GameActionFightEvent.Types.TriggerGlyphTrap._parser = new MessageParser<GameActionFightEvent.Types.TriggerGlyphTrap>(() => null);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x0600485B RID: 18523 RVA: 0x002FD764 File Offset: 0x002FB964
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool R32ytmGbc140O8gNNZ9x()
				{
					return true;
				}

				// Token: 0x0600485C RID: 18524 RVA: 0x002FD76C File Offset: 0x002FB96C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.TriggerGlyphTrap Gkd7OVGbU2Z18RpA0ZXP()
				{
					return null;
				}

				// Token: 0x04001937 RID: 6455
				private static readonly MessageParser<GameActionFightEvent.Types.TriggerGlyphTrap> _parser;

				// Token: 0x04001938 RID: 6456
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001939 RID: 6457
				public const int MarkIdFieldNumber = 1;

				// Token: 0x0400193A RID: 6458
				private int markId_;

				// Token: 0x0400193B RID: 6459
				public const int MarkImpactCellFieldNumber = 2;

				// Token: 0x0400193C RID: 6460
				private int markImpactCell_;

				// Token: 0x0400193D RID: 6461
				public const int TriggeringCharacterIdFieldNumber = 3;

				// Token: 0x0400193E RID: 6462
				private long triggeringCharacterId_;

				// Token: 0x0400193F RID: 6463
				private static GameActionFightEvent.Types.TriggerGlyphTrap Tni6PSGblTVLhaA0eoiw;
			}

			// Token: 0x020005D6 RID: 1494
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ActivateGlyphTrap : IMessage<GameActionFightEvent.Types.ActivateGlyphTrap>, IMessage, IEquatable<GameActionFightEvent.Types.ActivateGlyphTrap>, IDeepCloneable<GameActionFightEvent.Types.ActivateGlyphTrap>, IBufferMessage
			{
				// Token: 0x17000D04 RID: 3332
				// (get) Token: 0x06004862 RID: 18530 RVA: 0x002FD774 File Offset: 0x002FB974
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.ActivateGlyphTrap> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D05 RID: 3333
				// (get) Token: 0x06004863 RID: 18531 RVA: 0x002FD784 File Offset: 0x002FB984
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

				// Token: 0x17000D06 RID: 3334
				// (get) Token: 0x06004864 RID: 18532 RVA: 0x002FD794 File Offset: 0x002FB994
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

				// Token: 0x06004865 RID: 18533 RVA: 0x002FD7A4 File Offset: 0x002FB9A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ActivateGlyphTrap()
				{
				}

				// Token: 0x06004866 RID: 18534 RVA: 0x002FD7B4 File Offset: 0x002FB9B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ActivateGlyphTrap(GameActionFightEvent.Types.ActivateGlyphTrap other)
				{
				}

				// Token: 0x06004867 RID: 18535 RVA: 0x002FD7C4 File Offset: 0x002FB9C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ActivateGlyphTrap Clone()
				{
					return null;
				}

				// Token: 0x17000D07 RID: 3335
				// (get) Token: 0x06004868 RID: 18536 RVA: 0x002FD7D4 File Offset: 0x002FB9D4
				// (set) Token: 0x06004869 RID: 18537 RVA: 0x002FD7E4 File Offset: 0x002FB9E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int MarkId
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

				// Token: 0x17000D08 RID: 3336
				// (get) Token: 0x0600486A RID: 18538 RVA: 0x002FD7F4 File Offset: 0x002FB9F4
				// (set) Token: 0x0600486B RID: 18539 RVA: 0x002FD804 File Offset: 0x002FBA04
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool Active
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

				// Token: 0x0600486C RID: 18540 RVA: 0x002FD814 File Offset: 0x002FBA14
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600486D RID: 18541 RVA: 0x002FD824 File Offset: 0x002FBA24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ActivateGlyphTrap other)
				{
					return true;
				}

				// Token: 0x0600486E RID: 18542 RVA: 0x002FD834 File Offset: 0x002FBA34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600486F RID: 18543 RVA: 0x002FD844 File Offset: 0x002FBA44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004870 RID: 18544 RVA: 0x002FD854 File Offset: 0x002FBA54
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004871 RID: 18545 RVA: 0x002FD864 File Offset: 0x002FBA64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004872 RID: 18546 RVA: 0x002FD874 File Offset: 0x002FBA74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004873 RID: 18547 RVA: 0x002FD884 File Offset: 0x002FBA84
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ActivateGlyphTrap other)
				{
				}

				// Token: 0x06004874 RID: 18548 RVA: 0x002FD894 File Offset: 0x002FBA94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004875 RID: 18549 RVA: 0x002FD8A4 File Offset: 0x002FBAA4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004876 RID: 18550 RVA: 0x002FD8B4 File Offset: 0x002FBAB4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ActivateGlyphTrap()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							GameActionFightEvent.Types.ActivateGlyphTrap._parser = new MessageParser<GameActionFightEvent.Types.ActivateGlyphTrap>(() => null);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x06004877 RID: 18551 RVA: 0x002FD998 File Offset: 0x002FBB98
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool X3mPITGboQNPGFx1uoMY()
				{
					return true;
				}

				// Token: 0x06004878 RID: 18552 RVA: 0x002FD9A0 File Offset: 0x002FBBA0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ActivateGlyphTrap JgvvPFGb1cOwynshLSQt()
				{
					return null;
				}

				// Token: 0x04001942 RID: 6466
				private static readonly MessageParser<GameActionFightEvent.Types.ActivateGlyphTrap> _parser;

				// Token: 0x04001943 RID: 6467
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001944 RID: 6468
				public const int MarkIdFieldNumber = 1;

				// Token: 0x04001945 RID: 6469
				private int markId_;

				// Token: 0x04001946 RID: 6470
				public const int ActiveFieldNumber = 2;

				// Token: 0x04001947 RID: 6471
				private bool active_;

				// Token: 0x04001948 RID: 6472
				internal static GameActionFightEvent.Types.ActivateGlyphTrap a4IPCkGbvMfZdUWfyMyr;
			}

			// Token: 0x020005D8 RID: 1496
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Invisibility : IMessage<GameActionFightEvent.Types.Invisibility>, IMessage, IEquatable<GameActionFightEvent.Types.Invisibility>, IDeepCloneable<GameActionFightEvent.Types.Invisibility>, IBufferMessage
			{
				// Token: 0x17000D09 RID: 3337
				// (get) Token: 0x0600487E RID: 18558 RVA: 0x002FD9A8 File Offset: 0x002FBBA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.Invisibility> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D0A RID: 3338
				// (get) Token: 0x0600487F RID: 18559 RVA: 0x002FD9B8 File Offset: 0x002FBBB8
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

				// Token: 0x17000D0B RID: 3339
				// (get) Token: 0x06004880 RID: 18560 RVA: 0x002FD9C8 File Offset: 0x002FBBC8
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

				// Token: 0x06004881 RID: 18561 RVA: 0x002FD9D8 File Offset: 0x002FBBD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Invisibility()
				{
				}

				// Token: 0x06004882 RID: 18562 RVA: 0x002FD9E8 File Offset: 0x002FBBE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Invisibility(GameActionFightEvent.Types.Invisibility other)
				{
				}

				// Token: 0x06004883 RID: 18563 RVA: 0x002FD9F8 File Offset: 0x002FBBF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.Invisibility Clone()
				{
					return null;
				}

				// Token: 0x17000D0C RID: 3340
				// (get) Token: 0x06004884 RID: 18564 RVA: 0x002FDA08 File Offset: 0x002FBC08
				// (set) Token: 0x06004885 RID: 18565 RVA: 0x002FDA18 File Offset: 0x002FBC18
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

				// Token: 0x17000D0D RID: 3341
				// (get) Token: 0x06004886 RID: 18566 RVA: 0x002FDA28 File Offset: 0x002FBC28
				// (set) Token: 0x06004887 RID: 18567 RVA: 0x002FDA3C File Offset: 0x002FBC3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public FightInvisibilityState InvisibilityState
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (FightInvisibilityState)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x06004888 RID: 18568 RVA: 0x002FDA4C File Offset: 0x002FBC4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004889 RID: 18569 RVA: 0x002FDA5C File Offset: 0x002FBC5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.Invisibility other)
				{
					return true;
				}

				// Token: 0x0600488A RID: 18570 RVA: 0x002FDA6C File Offset: 0x002FBC6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600488B RID: 18571 RVA: 0x002FDA7C File Offset: 0x002FBC7C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600488C RID: 18572 RVA: 0x002FDA8C File Offset: 0x002FBC8C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600488D RID: 18573 RVA: 0x002FDA9C File Offset: 0x002FBC9C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600488E RID: 18574 RVA: 0x002FDAAC File Offset: 0x002FBCAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600488F RID: 18575 RVA: 0x002FDABC File Offset: 0x002FBCBC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.Invisibility other)
				{
				}

				// Token: 0x06004890 RID: 18576 RVA: 0x002FDACC File Offset: 0x002FBCCC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004891 RID: 18577 RVA: 0x002FDADC File Offset: 0x002FBCDC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004892 RID: 18578 RVA: 0x002FDAEC File Offset: 0x002FBCEC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Invisibility()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							GameActionFightEvent.Types.Invisibility._parser = new MessageParser<GameActionFightEvent.Types.Invisibility>(() => null);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 != 0)
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
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06004893 RID: 18579 RVA: 0x002FDBE4 File Offset: 0x002FBDE4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool QaR3V7Gb5CmQov2OIKEU()
				{
					return true;
				}

				// Token: 0x06004894 RID: 18580 RVA: 0x002FDBEC File Offset: 0x002FBDEC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.Invisibility wW6d0RGby2HXdB7EHq87()
				{
					return null;
				}

				// Token: 0x0400194B RID: 6475
				private static readonly MessageParser<GameActionFightEvent.Types.Invisibility> _parser;

				// Token: 0x0400194C RID: 6476
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400194D RID: 6477
				public const int TargetIdFieldNumber = 1;

				// Token: 0x0400194E RID: 6478
				private long targetId_;

				// Token: 0x0400194F RID: 6479
				public const int InvisibilityStateFieldNumber = 2;

				// Token: 0x04001950 RID: 6480
				private FightInvisibilityState invisibilityState_;

				// Token: 0x04001951 RID: 6481
				internal static GameActionFightEvent.Types.Invisibility sfSWIkGba4s4T5BX7Exo;
			}

			// Token: 0x020005DA RID: 1498
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Summons : IMessage<GameActionFightEvent.Types.Summons>, IMessage, IEquatable<GameActionFightEvent.Types.Summons>, IDeepCloneable<GameActionFightEvent.Types.Summons>, IBufferMessage
			{
				// Token: 0x17000D0E RID: 3342
				// (get) Token: 0x0600489A RID: 18586 RVA: 0x002FDBF4 File Offset: 0x002FBDF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.Summons> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D0F RID: 3343
				// (get) Token: 0x0600489B RID: 18587 RVA: 0x002FDC04 File Offset: 0x002FBE04
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

				// Token: 0x17000D10 RID: 3344
				// (get) Token: 0x0600489C RID: 18588 RVA: 0x002FDC14 File Offset: 0x002FBE14
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

				// Token: 0x0600489D RID: 18589 RVA: 0x002FDC24 File Offset: 0x002FBE24
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Summons()
				{
				}

				// Token: 0x0600489E RID: 18590 RVA: 0x002FDC34 File Offset: 0x002FBE34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Summons(GameActionFightEvent.Types.Summons other)
				{
				}

				// Token: 0x0600489F RID: 18591 RVA: 0x002FDC44 File Offset: 0x002FBE44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.Summons Clone()
				{
					return null;
				}

				// Token: 0x17000D11 RID: 3345
				// (get) Token: 0x060048A0 RID: 18592 RVA: 0x002FDC54 File Offset: 0x002FBE54
				// (set) Token: 0x060048A1 RID: 18593 RVA: 0x002FDC64 File Offset: 0x002FBE64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public GameActionFightEvent.Types.Summons.Types.SummonsByActor SummonsByActor
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

				// Token: 0x17000D12 RID: 3346
				// (get) Token: 0x060048A2 RID: 18594 RVA: 0x002FDC74 File Offset: 0x002FBE74
				// (set) Token: 0x060048A3 RID: 18595 RVA: 0x002FDC84 File Offset: 0x002FBE84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation SummonsByContextInformation
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

				// Token: 0x17000D13 RID: 3347
				// (get) Token: 0x060048A4 RID: 18596 RVA: 0x002FDC94 File Offset: 0x002FBE94
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GameActionFightEvent.Types.Summons.SummonsOneofCase SummonsCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (GameActionFightEvent.Types.Summons.SummonsOneofCase)null;
					}
				}

				// Token: 0x060048A5 RID: 18597 RVA: 0x002FDCA8 File Offset: 0x002FBEA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearSummons()
				{
				}

				// Token: 0x060048A6 RID: 18598 RVA: 0x002FDCB8 File Offset: 0x002FBEB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060048A7 RID: 18599 RVA: 0x002FDCC8 File Offset: 0x002FBEC8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.Summons other)
				{
					return true;
				}

				// Token: 0x060048A8 RID: 18600 RVA: 0x002FDCD8 File Offset: 0x002FBED8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060048A9 RID: 18601 RVA: 0x002FDCE8 File Offset: 0x002FBEE8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060048AA RID: 18602 RVA: 0x002FDCF8 File Offset: 0x002FBEF8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060048AB RID: 18603 RVA: 0x002FDD08 File Offset: 0x002FBF08
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060048AC RID: 18604 RVA: 0x002FDD18 File Offset: 0x002FBF18
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060048AD RID: 18605 RVA: 0x002FDD28 File Offset: 0x002FBF28
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.Summons other)
				{
				}

				// Token: 0x060048AE RID: 18606 RVA: 0x002FDD38 File Offset: 0x002FBF38
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060048AF RID: 18607 RVA: 0x002FDD48 File Offset: 0x002FBF48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060048B0 RID: 18608 RVA: 0x002FDD58 File Offset: 0x002FBF58
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Summons()
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
							num2 = 4;
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						GameActionFightEvent.Types.Summons._parser = new MessageParser<GameActionFightEvent.Types.Summons>(() => null);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
						{
							num2 = 3;
						}
					}
				}

				// Token: 0x060048B1 RID: 18609 RVA: 0x002FDE3C File Offset: 0x002FC03C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool SwPKinGbLfWLPpZyybX8()
				{
					return true;
				}

				// Token: 0x060048B2 RID: 18610 RVA: 0x002FDE44 File Offset: 0x002FC044
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.Summons A5ioLlGbWtMDike6bri1()
				{
					return null;
				}

				// Token: 0x04001954 RID: 6484
				private static readonly MessageParser<GameActionFightEvent.Types.Summons> _parser;

				// Token: 0x04001955 RID: 6485
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001956 RID: 6486
				public const int SummonsByActorFieldNumber = 1;

				// Token: 0x04001957 RID: 6487
				public const int SummonsByContextInformationFieldNumber = 2;

				// Token: 0x04001958 RID: 6488
				private object summons_;

				// Token: 0x04001959 RID: 6489
				private GameActionFightEvent.Types.Summons.SummonsOneofCase summonsCase_;

				// Token: 0x0400195A RID: 6490
				internal static GameActionFightEvent.Types.Summons h4mFa8Gb6FyTvq6UN2Qa;

				// Token: 0x020005DB RID: 1499
				public enum SummonsOneofCase
				{
					// Token: 0x0400195C RID: 6492
					None,
					// Token: 0x0400195D RID: 6493
					SummonsByActor,
					// Token: 0x0400195E RID: 6494
					SummonsByContextInformation
				}

				// Token: 0x020005DC RID: 1500
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static class Types
				{
					// Token: 0x060048B3 RID: 18611 RVA: 0x003135B4 File Offset: 0x003117B4
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x020005DD RID: 1501
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SummonsByActor : IMessage<GameActionFightEvent.Types.Summons.Types.SummonsByActor>, IMessage, IEquatable<GameActionFightEvent.Types.Summons.Types.SummonsByActor>, IDeepCloneable<GameActionFightEvent.Types.Summons.Types.SummonsByActor>, IBufferMessage
					{
						// Token: 0x17000D14 RID: 3348
						// (get) Token: 0x060048B4 RID: 18612 RVA: 0x0031C460 File Offset: 0x0031A660
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByActor> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000D15 RID: 3349
						// (get) Token: 0x060048B5 RID: 18613 RVA: 0x0031C470 File Offset: 0x0031A670
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

						// Token: 0x17000D16 RID: 3350
						// (get) Token: 0x060048B6 RID: 18614 RVA: 0x0031C480 File Offset: 0x0031A680
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

						// Token: 0x060048B7 RID: 18615 RVA: 0x0031C490 File Offset: 0x0031A690
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SummonsByActor()
						{
						}

						// Token: 0x060048B8 RID: 18616 RVA: 0x0031C4A0 File Offset: 0x0031A6A0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SummonsByActor(GameActionFightEvent.Types.Summons.Types.SummonsByActor other)
						{
						}

						// Token: 0x060048B9 RID: 18617 RVA: 0x0031C4B0 File Offset: 0x0031A6B0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public GameActionFightEvent.Types.Summons.Types.SummonsByActor Clone()
						{
							return null;
						}

						// Token: 0x17000D17 RID: 3351
						// (get) Token: 0x060048BA RID: 18618 RVA: 0x0031C4C0 File Offset: 0x0031A6C0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public RepeatedField<ActorPositionInformation> Summons
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x060048BB RID: 18619 RVA: 0x0031C4D0 File Offset: 0x0031A6D0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060048BC RID: 18620 RVA: 0x0031C4E0 File Offset: 0x0031A6E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(GameActionFightEvent.Types.Summons.Types.SummonsByActor other)
						{
							return true;
						}

						// Token: 0x060048BD RID: 18621 RVA: 0x0031C4F0 File Offset: 0x0031A6F0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060048BE RID: 18622 RVA: 0x0031C500 File Offset: 0x0031A700
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060048BF RID: 18623 RVA: 0x0031C510 File Offset: 0x0031A710
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060048C0 RID: 18624 RVA: 0x0031C520 File Offset: 0x0031A720
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060048C1 RID: 18625 RVA: 0x0031C530 File Offset: 0x0031A730
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060048C2 RID: 18626 RVA: 0x0031C540 File Offset: 0x0031A740
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(GameActionFightEvent.Types.Summons.Types.SummonsByActor other)
						{
						}

						// Token: 0x060048C3 RID: 18627 RVA: 0x0031C550 File Offset: 0x0031A750
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060048C4 RID: 18628 RVA: 0x0031C560 File Offset: 0x0031A760
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060048C5 RID: 18629 RVA: 0x0031C570 File Offset: 0x0031A770
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SummonsByActor()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 1;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								default:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 5;
									break;
								case 1:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
									{
										num2 = 0;
									}
									break;
								case 2:
									return;
								case 3:
									GameActionFightEvent.Types.Summons.Types.SummonsByActor._parser = new MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByActor>(() => null);
									num2 = 4;
									break;
								case 4:
									GameActionFightEvent.Types.Summons.Types.SummonsByActor._repeated_summons_codec = FieldCodec.ForMessage<ActorPositionInformation>(10U, qqeH7gmD07JZLA3m1WUC.XVInXhlssT(qqeH7gmD07JZLA3m1WUC.Nt8mDCI6NhO));
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
									{
										num2 = 0;
									}
									break;
								case 5:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 3;
									break;
								}
							}
						}

						// Token: 0x060048C6 RID: 18630 RVA: 0x0031C660 File Offset: 0x0031A860
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool JCbylUgJGBRiiTBjW3or()
						{
							return true;
						}

						// Token: 0x060048C7 RID: 18631 RVA: 0x0031C668 File Offset: 0x0031A868
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static GameActionFightEvent.Types.Summons.Types.SummonsByActor KTsZ6ugJgMap8Js4qItl()
						{
							return null;
						}

						// Token: 0x0400195F RID: 6495
						private static readonly MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByActor> _parser;

						// Token: 0x04001960 RID: 6496
						private UnknownFieldSet _unknownFields;

						// Token: 0x04001961 RID: 6497
						public const int SummonsFieldNumber = 1;

						// Token: 0x04001962 RID: 6498
						private static readonly FieldCodec<ActorPositionInformation> _repeated_summons_codec;

						// Token: 0x04001963 RID: 6499
						private readonly RepeatedField<ActorPositionInformation> summons_;

						// Token: 0x04001964 RID: 6500
						private static GameActionFightEvent.Types.Summons.Types.SummonsByActor ogpmBsgJJLeMYMLRT7Qr;
					}

					// Token: 0x020005DF RID: 1503
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SummonsByContextInformation : IMessage<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation>, IMessage, IEquatable<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation>, IDeepCloneable<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation>, IBufferMessage
					{
						// Token: 0x17000D18 RID: 3352
						// (get) Token: 0x060048CD RID: 18637 RVA: 0x0031C670 File Offset: 0x0031A870
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000D19 RID: 3353
						// (get) Token: 0x060048CE RID: 18638 RVA: 0x0031C680 File Offset: 0x0031A880
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

						// Token: 0x17000D1A RID: 3354
						// (get) Token: 0x060048CF RID: 18639 RVA: 0x0031C690 File Offset: 0x0031A890
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

						// Token: 0x060048D0 RID: 18640 RVA: 0x0031C6A0 File Offset: 0x0031A8A0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SummonsByContextInformation()
						{
						}

						// Token: 0x060048D1 RID: 18641 RVA: 0x0031C6B0 File Offset: 0x0031A8B0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SummonsByContextInformation(GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation other)
						{
						}

						// Token: 0x060048D2 RID: 18642 RVA: 0x0031C6C0 File Offset: 0x0031A8C0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation Clone()
						{
							return null;
						}

						// Token: 0x17000D1B RID: 3355
						// (get) Token: 0x060048D3 RID: 18643 RVA: 0x0031C6D0 File Offset: 0x0031A8D0
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public RepeatedField<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation> Summons
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x060048D4 RID: 18644 RVA: 0x0031C6E0 File Offset: 0x0031A8E0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060048D5 RID: 18645 RVA: 0x0031C6F0 File Offset: 0x0031A8F0
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation other)
						{
							return true;
						}

						// Token: 0x060048D6 RID: 18646 RVA: 0x0031C700 File Offset: 0x0031A900
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060048D7 RID: 18647 RVA: 0x0031C710 File Offset: 0x0031A910
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060048D8 RID: 18648 RVA: 0x0031C720 File Offset: 0x0031A920
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060048D9 RID: 18649 RVA: 0x0031C730 File Offset: 0x0031A930
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060048DA RID: 18650 RVA: 0x0031C740 File Offset: 0x0031A940
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060048DB RID: 18651 RVA: 0x0031C750 File Offset: 0x0031A950
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation other)
						{
						}

						// Token: 0x060048DC RID: 18652 RVA: 0x0031C760 File Offset: 0x0031A960
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060048DD RID: 18653 RVA: 0x0031C770 File Offset: 0x0031A970
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060048DE RID: 18654 RVA: 0x0031C780 File Offset: 0x0031A980
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SummonsByContextInformation()
						{
							uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
							int num = 4;
							int num2 = num;
							for (;;)
							{
								switch (num2)
								{
								default:
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 5;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
									{
										num2 = 2;
									}
									break;
								case 1:
									return;
								case 2:
									GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation._repeated_summons_codec = FieldCodec.ForMessage<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation>(10U, rGumeTmQwcfuCnOgdQsV.XVInXhlssT(rGumeTmQwcfuCnOgdQsV.TO4mQQc8vtQ));
									num2 = 1;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
									{
										num2 = 1;
									}
									break;
								case 3:
									AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
									{
										num2 = 0;
									}
									break;
								case 4:
									xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
									num2 = 2;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
									{
										num2 = 3;
									}
									break;
								case 5:
									GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation._parser = new MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation>(() => null);
									num2 = 2;
									break;
								}
							}
						}

						// Token: 0x060048DF RID: 18655 RVA: 0x0031C89C File Offset: 0x0031AA9C
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool o1GPKfgJdGQJHejSPHdo()
						{
							return true;
						}

						// Token: 0x060048E0 RID: 18656 RVA: 0x0031C8A4 File Offset: 0x0031AAA4
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation AXwIu6gJ97OiHEWatUZt()
						{
							return null;
						}

						// Token: 0x04001967 RID: 6503
						private static readonly MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation> _parser;

						// Token: 0x04001968 RID: 6504
						private UnknownFieldSet _unknownFields;

						// Token: 0x04001969 RID: 6505
						public const int SummonsFieldNumber = 1;

						// Token: 0x0400196A RID: 6506
						private static readonly FieldCodec<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation> _repeated_summons_codec;

						// Token: 0x0400196B RID: 6507
						private readonly RepeatedField<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation> summons_;

						// Token: 0x0400196C RID: 6508
						private static GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation p5uMVXgJsQISXLMBYMs7;

						// Token: 0x020005E0 RID: 1504
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static class Types
						{
							// Token: 0x060048E1 RID: 18657 RVA: 0x00321344 File Offset: 0x0031F544
							[MethodImpl(MethodImplOptions.NoInlining)]
							static Types()
							{
								uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							}

							// Token: 0x020005E1 RID: 1505
							[DebuggerDisplay("{ToString(),nq}")]
							public sealed class SummonContextInformation : IMessage<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation>, IMessage, IEquatable<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation>, IDeepCloneable<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation>, IBufferMessage
							{
								// Token: 0x17000D1C RID: 3356
								// (get) Token: 0x060048E2 RID: 18658 RVA: 0x003231D4 File Offset: 0x003213D4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public static MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation> Parser
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x17000D1D RID: 3357
								// (get) Token: 0x060048E3 RID: 18659 RVA: 0x003231E4 File Offset: 0x003213E4
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

								// Token: 0x17000D1E RID: 3358
								// (get) Token: 0x060048E4 RID: 18660 RVA: 0x003231F4 File Offset: 0x003213F4
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

								// Token: 0x060048E5 RID: 18661 RVA: 0x00323204 File Offset: 0x00321404
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public SummonContextInformation()
								{
								}

								// Token: 0x060048E6 RID: 18662 RVA: 0x00323214 File Offset: 0x00321414
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public SummonContextInformation(GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation other)
								{
								}

								// Token: 0x060048E7 RID: 18663 RVA: 0x00323224 File Offset: 0x00321424
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation Clone()
								{
									return null;
								}

								// Token: 0x17000D1F RID: 3359
								// (get) Token: 0x060048E8 RID: 18664 RVA: 0x00323234 File Offset: 0x00321434
								// (set) Token: 0x060048E9 RID: 18665 RVA: 0x00323244 File Offset: 0x00321444
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								public EntitySpawnInformation SpawnInformation
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

								// Token: 0x17000D20 RID: 3360
								// (get) Token: 0x060048EA RID: 18666 RVA: 0x00323254 File Offset: 0x00321454
								// (set) Token: 0x060048EB RID: 18667 RVA: 0x00323264 File Offset: 0x00321464
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public int Wave
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

								// Token: 0x17000D21 RID: 3361
								// (get) Token: 0x060048EC RID: 18668 RVA: 0x00323274 File Offset: 0x00321474
								// (set) Token: 0x060048ED RID: 18669 RVA: 0x00323284 File Offset: 0x00321484
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public EntityLook Look
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

								// Token: 0x17000D22 RID: 3362
								// (get) Token: 0x060048EE RID: 18670 RVA: 0x00323294 File Offset: 0x00321494
								// (set) Token: 0x060048EF RID: 18671 RVA: 0x003232A4 File Offset: 0x003214A4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public FightCharacteristics Characteristics
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

								// Token: 0x17000D23 RID: 3363
								// (get) Token: 0x060048F0 RID: 18672 RVA: 0x003232B4 File Offset: 0x003214B4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								public RepeatedField<SpawnInformation> Summons
								{
									[MethodImpl(MethodImplOptions.NoInlining)]
									get
									{
										return null;
									}
								}

								// Token: 0x060048F1 RID: 18673 RVA: 0x003232C4 File Offset: 0x003214C4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override bool Equals(object other)
								{
									return true;
								}

								// Token: 0x060048F2 RID: 18674 RVA: 0x003232D4 File Offset: 0x003214D4
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public bool Equals(GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation other)
								{
									return true;
								}

								// Token: 0x060048F3 RID: 18675 RVA: 0x003232E4 File Offset: 0x003214E4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override int GetHashCode()
								{
									return 0;
								}

								// Token: 0x060048F4 RID: 18676 RVA: 0x003232F4 File Offset: 0x003214F4
								[GeneratedCode("protoc", null)]
								[DebuggerNonUserCode]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public override string ToString()
								{
									return null;
								}

								// Token: 0x060048F5 RID: 18677 RVA: 0x00323304 File Offset: 0x00321504
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void WriteTo(CodedOutputStream output)
								{
								}

								// Token: 0x060048F6 RID: 18678 RVA: 0x00323314 File Offset: 0x00321514
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalWriteTo(ref WriteContext output)
								{
								}

								// Token: 0x060048F7 RID: 18679 RVA: 0x00323324 File Offset: 0x00321524
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public int CalculateSize()
								{
									return 0;
								}

								// Token: 0x060048F8 RID: 18680 RVA: 0x00323334 File Offset: 0x00321534
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation other)
								{
								}

								// Token: 0x060048F9 RID: 18681 RVA: 0x00323344 File Offset: 0x00321544
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								public void MergeFrom(CodedInputStream input)
								{
								}

								// Token: 0x060048FA RID: 18682 RVA: 0x00323354 File Offset: 0x00321554
								[DebuggerNonUserCode]
								[GeneratedCode("protoc", null)]
								[MethodImpl(MethodImplOptions.NoInlining)]
								void IBufferMessage.InternalMergeFrom(ref ParseContext input)
								{
								}

								// Token: 0x060048FB RID: 18683 RVA: 0x00323364 File Offset: 0x00321564
								[MethodImpl(MethodImplOptions.NoInlining)]
								static SummonContextInformation()
								{
									uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
									int num = 4;
									int num2 = num;
									for (;;)
									{
										switch (num2)
										{
										default:
											GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation._repeated_summons_codec = FieldCodec.ForMessage<SpawnInformation>(42U, Ki7ZCUBjFAL2yq4MdsVc.XVInXhlssT(Ki7ZCUBjFAL2yq4MdsVc.V5fBjzjZXh3));
											num2 = 2;
											break;
										case 1:
											GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation._parser = new MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation>(() => null);
											num2 = 0;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
											{
												num2 = 0;
											}
											break;
										case 2:
											return;
										case 3:
											AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
											num2 = 5;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
											{
												num2 = 3;
											}
											break;
										case 4:
											xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
											num2 = 3;
											break;
										case 5:
											UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
											num2 = 1;
											if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
											{
												num2 = 1;
											}
											break;
										}
									}
								}

								// Token: 0x060048FC RID: 18684 RVA: 0x0032346C File Offset: 0x0032166C
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static bool OAME4Pgd5jL2Dr4UaB8K()
								{
									return true;
								}

								// Token: 0x060048FD RID: 18685 RVA: 0x00323474 File Offset: 0x00321674
								[MethodImpl(MethodImplOptions.NoInlining)]
								internal static GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation S5d2OUgdyQyJoRYjoBxn()
								{
									return null;
								}

								// Token: 0x0400196D RID: 6509
								private static readonly MessageParser<GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation> _parser;

								// Token: 0x0400196E RID: 6510
								private UnknownFieldSet _unknownFields;

								// Token: 0x0400196F RID: 6511
								public const int SpawnInformationFieldNumber = 1;

								// Token: 0x04001970 RID: 6512
								private EntitySpawnInformation spawnInformation_;

								// Token: 0x04001971 RID: 6513
								public const int WaveFieldNumber = 2;

								// Token: 0x04001972 RID: 6514
								private int wave_;

								// Token: 0x04001973 RID: 6515
								public const int LookFieldNumber = 3;

								// Token: 0x04001974 RID: 6516
								private EntityLook look_;

								// Token: 0x04001975 RID: 6517
								public const int CharacteristicsFieldNumber = 4;

								// Token: 0x04001976 RID: 6518
								private FightCharacteristics characteristics_;

								// Token: 0x04001977 RID: 6519
								public const int SummonsFieldNumber = 5;

								// Token: 0x04001978 RID: 6520
								private static readonly FieldCodec<SpawnInformation> _repeated_summons_codec;

								// Token: 0x04001979 RID: 6521
								private readonly RepeatedField<SpawnInformation> summons_;

								// Token: 0x0400197A RID: 6522
								private static GameActionFightEvent.Types.Summons.Types.SummonsByContextInformation.Types.SummonContextInformation lBGf9rgdaIq7m4PWBsDZ;
							}
						}
					}
				}
			}

			// Token: 0x020005E5 RID: 1509
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class MarkCells : IMessage<GameActionFightEvent.Types.MarkCells>, IMessage, IEquatable<GameActionFightEvent.Types.MarkCells>, IDeepCloneable<GameActionFightEvent.Types.MarkCells>, IBufferMessage
			{
				// Token: 0x17000D24 RID: 3364
				// (get) Token: 0x0600490D RID: 18701 RVA: 0x002FDE4C File Offset: 0x002FC04C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.MarkCells> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D25 RID: 3365
				// (get) Token: 0x0600490E RID: 18702 RVA: 0x002FDE5C File Offset: 0x002FC05C
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

				// Token: 0x17000D26 RID: 3366
				// (get) Token: 0x0600490F RID: 18703 RVA: 0x002FDE6C File Offset: 0x002FC06C
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

				// Token: 0x06004910 RID: 18704 RVA: 0x002FDE7C File Offset: 0x002FC07C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MarkCells()
				{
				}

				// Token: 0x06004911 RID: 18705 RVA: 0x002FDE8C File Offset: 0x002FC08C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public MarkCells(GameActionFightEvent.Types.MarkCells other)
				{
				}

				// Token: 0x06004912 RID: 18706 RVA: 0x002FDE9C File Offset: 0x002FC09C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.MarkCells Clone()
				{
					return null;
				}

				// Token: 0x17000D27 RID: 3367
				// (get) Token: 0x06004913 RID: 18707 RVA: 0x002FDEAC File Offset: 0x002FC0AC
				// (set) Token: 0x06004914 RID: 18708 RVA: 0x002FDEBC File Offset: 0x002FC0BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public FightMark Mark
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

				// Token: 0x06004915 RID: 18709 RVA: 0x002FDECC File Offset: 0x002FC0CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004916 RID: 18710 RVA: 0x002FDEDC File Offset: 0x002FC0DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.MarkCells other)
				{
					return true;
				}

				// Token: 0x06004917 RID: 18711 RVA: 0x002FDEEC File Offset: 0x002FC0EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004918 RID: 18712 RVA: 0x002FDEFC File Offset: 0x002FC0FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004919 RID: 18713 RVA: 0x002FDF0C File Offset: 0x002FC10C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600491A RID: 18714 RVA: 0x002FDF1C File Offset: 0x002FC11C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600491B RID: 18715 RVA: 0x002FDF2C File Offset: 0x002FC12C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600491C RID: 18716 RVA: 0x002FDF3C File Offset: 0x002FC13C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.MarkCells other)
				{
				}

				// Token: 0x0600491D RID: 18717 RVA: 0x002FDF4C File Offset: 0x002FC14C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600491E RID: 18718 RVA: 0x002FDF5C File Offset: 0x002FC15C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600491F RID: 18719 RVA: 0x002FDF6C File Offset: 0x002FC16C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static MarkCells()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							return;
						}
						GameActionFightEvent.Types.MarkCells._parser = new MessageParser<GameActionFightEvent.Types.MarkCells>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
						{
							num2 = 4;
						}
					}
				}

				// Token: 0x06004920 RID: 18720 RVA: 0x002FE064 File Offset: 0x002FC264
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool HH34giGbrUIW9JmJC2Uo()
				{
					return true;
				}

				// Token: 0x06004921 RID: 18721 RVA: 0x002FE06C File Offset: 0x002FC26C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.MarkCells fnA7PPGbVkMod7ACyfCf()
				{
					return null;
				}

				// Token: 0x04001981 RID: 6529
				private static readonly MessageParser<GameActionFightEvent.Types.MarkCells> _parser;

				// Token: 0x04001982 RID: 6530
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001983 RID: 6531
				public const int MarkFieldNumber = 1;

				// Token: 0x04001984 RID: 6532
				private FightMark mark_;

				// Token: 0x04001985 RID: 6533
				internal static GameActionFightEvent.Types.MarkCells QF3Tu5Gbh07TnfFWPeqt;
			}

			// Token: 0x020005E7 RID: 1511
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ModifyEffectsDuration : IMessage<GameActionFightEvent.Types.ModifyEffectsDuration>, IMessage, IEquatable<GameActionFightEvent.Types.ModifyEffectsDuration>, IDeepCloneable<GameActionFightEvent.Types.ModifyEffectsDuration>, IBufferMessage
			{
				// Token: 0x17000D28 RID: 3368
				// (get) Token: 0x06004927 RID: 18727 RVA: 0x002FE074 File Offset: 0x002FC274
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.ModifyEffectsDuration> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D29 RID: 3369
				// (get) Token: 0x06004928 RID: 18728 RVA: 0x002FE084 File Offset: 0x002FC284
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

				// Token: 0x17000D2A RID: 3370
				// (get) Token: 0x06004929 RID: 18729 RVA: 0x002FE094 File Offset: 0x002FC294
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

				// Token: 0x0600492A RID: 18730 RVA: 0x002FE0A4 File Offset: 0x002FC2A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ModifyEffectsDuration()
				{
				}

				// Token: 0x0600492B RID: 18731 RVA: 0x002FE0B4 File Offset: 0x002FC2B4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ModifyEffectsDuration(GameActionFightEvent.Types.ModifyEffectsDuration other)
				{
				}

				// Token: 0x0600492C RID: 18732 RVA: 0x002FE0C4 File Offset: 0x002FC2C4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ModifyEffectsDuration Clone()
				{
					return null;
				}

				// Token: 0x17000D2B RID: 3371
				// (get) Token: 0x0600492D RID: 18733 RVA: 0x002FE0D4 File Offset: 0x002FC2D4
				// (set) Token: 0x0600492E RID: 18734 RVA: 0x002FE0E4 File Offset: 0x002FC2E4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D2C RID: 3372
				// (get) Token: 0x0600492F RID: 18735 RVA: 0x002FE0F4 File Offset: 0x002FC2F4
				// (set) Token: 0x06004930 RID: 18736 RVA: 0x002FE104 File Offset: 0x002FC304
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x06004931 RID: 18737 RVA: 0x002FE114 File Offset: 0x002FC314
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004932 RID: 18738 RVA: 0x002FE124 File Offset: 0x002FC324
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ModifyEffectsDuration other)
				{
					return true;
				}

				// Token: 0x06004933 RID: 18739 RVA: 0x002FE134 File Offset: 0x002FC334
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004934 RID: 18740 RVA: 0x002FE144 File Offset: 0x002FC344
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004935 RID: 18741 RVA: 0x002FE154 File Offset: 0x002FC354
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004936 RID: 18742 RVA: 0x002FE164 File Offset: 0x002FC364
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004937 RID: 18743 RVA: 0x002FE174 File Offset: 0x002FC374
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004938 RID: 18744 RVA: 0x002FE184 File Offset: 0x002FC384
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ModifyEffectsDuration other)
				{
				}

				// Token: 0x06004939 RID: 18745 RVA: 0x002FE194 File Offset: 0x002FC394
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600493A RID: 18746 RVA: 0x002FE1A4 File Offset: 0x002FC3A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600493B RID: 18747 RVA: 0x002FE1B4 File Offset: 0x002FC3B4
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ModifyEffectsDuration()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						GameActionFightEvent.Types.ModifyEffectsDuration._parser = new MessageParser<GameActionFightEvent.Types.ModifyEffectsDuration>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x0600493C RID: 18748 RVA: 0x002FE280 File Offset: 0x002FC480
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool C3aIvmGbCcOBYxueBdgm()
				{
					return true;
				}

				// Token: 0x0600493D RID: 18749 RVA: 0x002FE288 File Offset: 0x002FC488
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ModifyEffectsDuration PwL6K0GbDqKoqVAtBrmQ()
				{
					return null;
				}

				// Token: 0x04001988 RID: 6536
				private static readonly MessageParser<GameActionFightEvent.Types.ModifyEffectsDuration> _parser;

				// Token: 0x04001989 RID: 6537
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400198A RID: 6538
				public const int TargetIdFieldNumber = 3;

				// Token: 0x0400198B RID: 6539
				private long targetId_;

				// Token: 0x0400198C RID: 6540
				public const int DeltaFieldNumber = 4;

				// Token: 0x0400198D RID: 6541
				private int delta_;

				// Token: 0x0400198E RID: 6542
				internal static GameActionFightEvent.Types.ModifyEffectsDuration kvdBLmGb0jlXq9crwBQI;
			}

			// Token: 0x020005E9 RID: 1513
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class StealKama : IMessage<GameActionFightEvent.Types.StealKama>, IMessage, IEquatable<GameActionFightEvent.Types.StealKama>, IDeepCloneable<GameActionFightEvent.Types.StealKama>, IBufferMessage
			{
				// Token: 0x17000D2D RID: 3373
				// (get) Token: 0x06004943 RID: 18755 RVA: 0x002FE290 File Offset: 0x002FC490
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.StealKama> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D2E RID: 3374
				// (get) Token: 0x06004944 RID: 18756 RVA: 0x002FE2A0 File Offset: 0x002FC4A0
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

				// Token: 0x17000D2F RID: 3375
				// (get) Token: 0x06004945 RID: 18757 RVA: 0x002FE2B0 File Offset: 0x002FC4B0
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

				// Token: 0x06004946 RID: 18758 RVA: 0x002FE2C0 File Offset: 0x002FC4C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public StealKama()
				{
				}

				// Token: 0x06004947 RID: 18759 RVA: 0x002FE2D0 File Offset: 0x002FC4D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public StealKama(GameActionFightEvent.Types.StealKama other)
				{
				}

				// Token: 0x06004948 RID: 18760 RVA: 0x002FE2E0 File Offset: 0x002FC4E0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.StealKama Clone()
				{
					return null;
				}

				// Token: 0x17000D30 RID: 3376
				// (get) Token: 0x06004949 RID: 18761 RVA: 0x002FE2F0 File Offset: 0x002FC4F0
				// (set) Token: 0x0600494A RID: 18762 RVA: 0x002FE300 File Offset: 0x002FC500
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D31 RID: 3377
				// (get) Token: 0x0600494B RID: 18763 RVA: 0x002FE310 File Offset: 0x002FC510
				// (set) Token: 0x0600494C RID: 18764 RVA: 0x002FE320 File Offset: 0x002FC520
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public long Amount
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

				// Token: 0x0600494D RID: 18765 RVA: 0x002FE330 File Offset: 0x002FC530
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600494E RID: 18766 RVA: 0x002FE340 File Offset: 0x002FC540
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.StealKama other)
				{
					return true;
				}

				// Token: 0x0600494F RID: 18767 RVA: 0x002FE350 File Offset: 0x002FC550
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004950 RID: 18768 RVA: 0x002FE360 File Offset: 0x002FC560
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004951 RID: 18769 RVA: 0x002FE370 File Offset: 0x002FC570
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004952 RID: 18770 RVA: 0x002FE380 File Offset: 0x002FC580
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004953 RID: 18771 RVA: 0x002FE390 File Offset: 0x002FC590
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004954 RID: 18772 RVA: 0x002FE3A0 File Offset: 0x002FC5A0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.StealKama other)
				{
				}

				// Token: 0x06004955 RID: 18773 RVA: 0x002FE3B0 File Offset: 0x002FC5B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004956 RID: 18774 RVA: 0x002FE3C0 File Offset: 0x002FC5C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004957 RID: 18775 RVA: 0x002FE3D0 File Offset: 0x002FC5D0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static StealKama()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 3;
							break;
						case 1:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							return;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							break;
						case 4:
							GameActionFightEvent.Types.StealKama._parser = new MessageParser<GameActionFightEvent.Types.StealKama>(() => null);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
							{
								num2 = 2;
							}
							break;
						}
					}
				}

				// Token: 0x06004958 RID: 18776 RVA: 0x002FE49C File Offset: 0x002FC69C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Sel1C3GbwQjKWqbey3e5()
				{
					return true;
				}

				// Token: 0x06004959 RID: 18777 RVA: 0x002FE4A4 File Offset: 0x002FC6A4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.StealKama beVJNRGbQ9Zkb4TRm0Gb()
				{
					return null;
				}

				// Token: 0x04001991 RID: 6545
				private static readonly MessageParser<GameActionFightEvent.Types.StealKama> _parser;

				// Token: 0x04001992 RID: 6546
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001993 RID: 6547
				public const int TargetIdFieldNumber = 3;

				// Token: 0x04001994 RID: 6548
				private long targetId_;

				// Token: 0x04001995 RID: 6549
				public const int AmountFieldNumber = 4;

				// Token: 0x04001996 RID: 6550
				private long amount_;

				// Token: 0x04001997 RID: 6551
				private static GameActionFightEvent.Types.StealKama uLuKMBGbtUyofAtcvlYc;
			}

			// Token: 0x020005EB RID: 1515
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ChangeLook : IMessage<GameActionFightEvent.Types.ChangeLook>, IMessage, IEquatable<GameActionFightEvent.Types.ChangeLook>, IDeepCloneable<GameActionFightEvent.Types.ChangeLook>, IBufferMessage
			{
				// Token: 0x17000D32 RID: 3378
				// (get) Token: 0x0600495F RID: 18783 RVA: 0x002FE4AC File Offset: 0x002FC6AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.ChangeLook> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D33 RID: 3379
				// (get) Token: 0x06004960 RID: 18784 RVA: 0x002FE4BC File Offset: 0x002FC6BC
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

				// Token: 0x17000D34 RID: 3380
				// (get) Token: 0x06004961 RID: 18785 RVA: 0x002FE4CC File Offset: 0x002FC6CC
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

				// Token: 0x06004962 RID: 18786 RVA: 0x002FE4DC File Offset: 0x002FC6DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ChangeLook()
				{
				}

				// Token: 0x06004963 RID: 18787 RVA: 0x002FE4EC File Offset: 0x002FC6EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ChangeLook(GameActionFightEvent.Types.ChangeLook other)
				{
				}

				// Token: 0x06004964 RID: 18788 RVA: 0x002FE4FC File Offset: 0x002FC6FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ChangeLook Clone()
				{
					return null;
				}

				// Token: 0x17000D35 RID: 3381
				// (get) Token: 0x06004965 RID: 18789 RVA: 0x002FE50C File Offset: 0x002FC70C
				// (set) Token: 0x06004966 RID: 18790 RVA: 0x002FE51C File Offset: 0x002FC71C
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

				// Token: 0x17000D36 RID: 3382
				// (get) Token: 0x06004967 RID: 18791 RVA: 0x002FE52C File Offset: 0x002FC72C
				// (set) Token: 0x06004968 RID: 18792 RVA: 0x002FE53C File Offset: 0x002FC73C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public EntityLook Look
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

				// Token: 0x06004969 RID: 18793 RVA: 0x002FE54C File Offset: 0x002FC74C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x0600496A RID: 18794 RVA: 0x002FE55C File Offset: 0x002FC75C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ChangeLook other)
				{
					return true;
				}

				// Token: 0x0600496B RID: 18795 RVA: 0x002FE56C File Offset: 0x002FC76C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x0600496C RID: 18796 RVA: 0x002FE57C File Offset: 0x002FC77C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0600496D RID: 18797 RVA: 0x002FE58C File Offset: 0x002FC78C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600496E RID: 18798 RVA: 0x002FE59C File Offset: 0x002FC79C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600496F RID: 18799 RVA: 0x002FE5AC File Offset: 0x002FC7AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004970 RID: 18800 RVA: 0x002FE5BC File Offset: 0x002FC7BC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ChangeLook other)
				{
				}

				// Token: 0x06004971 RID: 18801 RVA: 0x002FE5CC File Offset: 0x002FC7CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004972 RID: 18802 RVA: 0x002FE5DC File Offset: 0x002FC7DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004973 RID: 18803 RVA: 0x002FE5EC File Offset: 0x002FC7EC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ChangeLook()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							break;
						case 4:
							GameActionFightEvent.Types.ChangeLook._parser = new MessageParser<GameActionFightEvent.Types.ChangeLook>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}

				// Token: 0x06004974 RID: 18804 RVA: 0x002FE6B8 File Offset: 0x002FC8B8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool UCDu35GbTbb8FgC7k50F()
				{
					return true;
				}

				// Token: 0x06004975 RID: 18805 RVA: 0x002FE6C0 File Offset: 0x002FC8C0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ChangeLook MjDrRJGbpv9V1qUwm7aJ()
				{
					return null;
				}

				// Token: 0x0400199A RID: 6554
				private static readonly MessageParser<GameActionFightEvent.Types.ChangeLook> _parser;

				// Token: 0x0400199B RID: 6555
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400199C RID: 6556
				public const int TargetIdFieldNumber = 3;

				// Token: 0x0400199D RID: 6557
				private long targetId_;

				// Token: 0x0400199E RID: 6558
				public const int LookFieldNumber = 4;

				// Token: 0x0400199F RID: 6559
				private EntityLook look_;

				// Token: 0x040019A0 RID: 6560
				private static GameActionFightEvent.Types.ChangeLook dfbocmGb7Tbp3CAGxkTd;
			}

			// Token: 0x020005ED RID: 1517
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class TeleportOnSameMap : IMessage<GameActionFightEvent.Types.TeleportOnSameMap>, IMessage, IEquatable<GameActionFightEvent.Types.TeleportOnSameMap>, IDeepCloneable<GameActionFightEvent.Types.TeleportOnSameMap>, IBufferMessage
			{
				// Token: 0x17000D37 RID: 3383
				// (get) Token: 0x0600497B RID: 18811 RVA: 0x002FE6C8 File Offset: 0x002FC8C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.TeleportOnSameMap> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D38 RID: 3384
				// (get) Token: 0x0600497C RID: 18812 RVA: 0x002FE6D8 File Offset: 0x002FC8D8
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

				// Token: 0x17000D39 RID: 3385
				// (get) Token: 0x0600497D RID: 18813 RVA: 0x002FE6E8 File Offset: 0x002FC8E8
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

				// Token: 0x0600497E RID: 18814 RVA: 0x002FE6F8 File Offset: 0x002FC8F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TeleportOnSameMap()
				{
				}

				// Token: 0x0600497F RID: 18815 RVA: 0x002FE708 File Offset: 0x002FC908
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TeleportOnSameMap(GameActionFightEvent.Types.TeleportOnSameMap other)
				{
				}

				// Token: 0x06004980 RID: 18816 RVA: 0x002FE718 File Offset: 0x002FC918
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.TeleportOnSameMap Clone()
				{
					return null;
				}

				// Token: 0x17000D3A RID: 3386
				// (get) Token: 0x06004981 RID: 18817 RVA: 0x002FE728 File Offset: 0x002FC928
				// (set) Token: 0x06004982 RID: 18818 RVA: 0x002FE738 File Offset: 0x002FC938
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

				// Token: 0x17000D3B RID: 3387
				// (get) Token: 0x06004983 RID: 18819 RVA: 0x002FE748 File Offset: 0x002FC948
				// (set) Token: 0x06004984 RID: 18820 RVA: 0x002FE758 File Offset: 0x002FC958
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Cell
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

				// Token: 0x06004985 RID: 18821 RVA: 0x002FE768 File Offset: 0x002FC968
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004986 RID: 18822 RVA: 0x002FE778 File Offset: 0x002FC978
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.TeleportOnSameMap other)
				{
					return true;
				}

				// Token: 0x06004987 RID: 18823 RVA: 0x002FE788 File Offset: 0x002FC988
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004988 RID: 18824 RVA: 0x002FE798 File Offset: 0x002FC998
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004989 RID: 18825 RVA: 0x002FE7A8 File Offset: 0x002FC9A8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x0600498A RID: 18826 RVA: 0x002FE7B8 File Offset: 0x002FC9B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x0600498B RID: 18827 RVA: 0x002FE7C8 File Offset: 0x002FC9C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x0600498C RID: 18828 RVA: 0x002FE7D8 File Offset: 0x002FC9D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.TeleportOnSameMap other)
				{
				}

				// Token: 0x0600498D RID: 18829 RVA: 0x002FE7E8 File Offset: 0x002FC9E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x0600498E RID: 18830 RVA: 0x002FE7F8 File Offset: 0x002FC9F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x0600498F RID: 18831 RVA: 0x002FE808 File Offset: 0x002FCA08
				[MethodImpl(MethodImplOptions.NoInlining)]
				static TeleportOnSameMap()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							GameActionFightEvent.Types.TeleportOnSameMap._parser = new MessageParser<GameActionFightEvent.Types.TeleportOnSameMap>(() => null);
							num2 = 4;
							break;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
							{
								num2 = 2;
							}
							break;
						case 4:
							return;
						}
					}
				}

				// Token: 0x06004990 RID: 18832 RVA: 0x002FE8EC File Offset: 0x002FCAEC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool Gye1SiGbYVeOudXFAK6v()
				{
					return true;
				}

				// Token: 0x06004991 RID: 18833 RVA: 0x002FE8F4 File Offset: 0x002FCAF4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.TeleportOnSameMap fHZqLRGbbcqfS47vmL31()
				{
					return null;
				}

				// Token: 0x040019A3 RID: 6563
				private static readonly MessageParser<GameActionFightEvent.Types.TeleportOnSameMap> _parser;

				// Token: 0x040019A4 RID: 6564
				private UnknownFieldSet _unknownFields;

				// Token: 0x040019A5 RID: 6565
				public const int TargetIdFieldNumber = 1;

				// Token: 0x040019A6 RID: 6566
				private long targetId_;

				// Token: 0x040019A7 RID: 6567
				public const int CellFieldNumber = 2;

				// Token: 0x040019A8 RID: 6568
				private int cell_;

				// Token: 0x040019A9 RID: 6569
				internal static GameActionFightEvent.Types.TeleportOnSameMap MBf7BDGbHxdgpnoZ99Cp;
			}

			// Token: 0x020005EF RID: 1519
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ExchangePositions : IMessage<GameActionFightEvent.Types.ExchangePositions>, IMessage, IEquatable<GameActionFightEvent.Types.ExchangePositions>, IDeepCloneable<GameActionFightEvent.Types.ExchangePositions>, IBufferMessage
			{
				// Token: 0x17000D3C RID: 3388
				// (get) Token: 0x06004997 RID: 18839 RVA: 0x002FE8FC File Offset: 0x002FCAFC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.ExchangePositions> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D3D RID: 3389
				// (get) Token: 0x06004998 RID: 18840 RVA: 0x002FE90C File Offset: 0x002FCB0C
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

				// Token: 0x17000D3E RID: 3390
				// (get) Token: 0x06004999 RID: 18841 RVA: 0x002FE91C File Offset: 0x002FCB1C
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

				// Token: 0x0600499A RID: 18842 RVA: 0x002FE92C File Offset: 0x002FCB2C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangePositions()
				{
				}

				// Token: 0x0600499B RID: 18843 RVA: 0x002FE93C File Offset: 0x002FCB3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExchangePositions(GameActionFightEvent.Types.ExchangePositions other)
				{
				}

				// Token: 0x0600499C RID: 18844 RVA: 0x002FE94C File Offset: 0x002FCB4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ExchangePositions Clone()
				{
					return null;
				}

				// Token: 0x17000D3F RID: 3391
				// (get) Token: 0x0600499D RID: 18845 RVA: 0x002FE95C File Offset: 0x002FCB5C
				// (set) Token: 0x0600499E RID: 18846 RVA: 0x002FE96C File Offset: 0x002FCB6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D40 RID: 3392
				// (get) Token: 0x0600499F RID: 18847 RVA: 0x002FE97C File Offset: 0x002FCB7C
				// (set) Token: 0x060049A0 RID: 18848 RVA: 0x002FE98C File Offset: 0x002FCB8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int CasterCellId
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

				// Token: 0x17000D41 RID: 3393
				// (get) Token: 0x060049A1 RID: 18849 RVA: 0x002FE99C File Offset: 0x002FCB9C
				// (set) Token: 0x060049A2 RID: 18850 RVA: 0x002FE9AC File Offset: 0x002FCBAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int TargetCellId
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

				// Token: 0x060049A3 RID: 18851 RVA: 0x002FE9BC File Offset: 0x002FCBBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060049A4 RID: 18852 RVA: 0x002FE9CC File Offset: 0x002FCBCC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ExchangePositions other)
				{
					return true;
				}

				// Token: 0x060049A5 RID: 18853 RVA: 0x002FE9DC File Offset: 0x002FCBDC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060049A6 RID: 18854 RVA: 0x002FE9EC File Offset: 0x002FCBEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060049A7 RID: 18855 RVA: 0x002FE9FC File Offset: 0x002FCBFC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060049A8 RID: 18856 RVA: 0x002FEA0C File Offset: 0x002FCC0C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060049A9 RID: 18857 RVA: 0x002FEA1C File Offset: 0x002FCC1C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060049AA RID: 18858 RVA: 0x002FEA2C File Offset: 0x002FCC2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ExchangePositions other)
				{
				}

				// Token: 0x060049AB RID: 18859 RVA: 0x002FEA3C File Offset: 0x002FCC3C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060049AC RID: 18860 RVA: 0x002FEA4C File Offset: 0x002FCC4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060049AD RID: 18861 RVA: 0x002FEA5C File Offset: 0x002FCC5C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ExchangePositions()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							GameActionFightEvent.Types.ExchangePositions._parser = new MessageParser<GameActionFightEvent.Types.ExchangePositions>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						}
						break;
					}
				}

				// Token: 0x060049AE RID: 18862 RVA: 0x002FEB40 File Offset: 0x002FCD40
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool qWNEllGbPv5DHg6TG8Ii()
				{
					return true;
				}

				// Token: 0x060049AF RID: 18863 RVA: 0x002FEB48 File Offset: 0x002FCD48
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ExchangePositions ryOZuKGbSkx83LKcXdy3()
				{
					return null;
				}

				// Token: 0x040019AC RID: 6572
				private static readonly MessageParser<GameActionFightEvent.Types.ExchangePositions> _parser;

				// Token: 0x040019AD RID: 6573
				private UnknownFieldSet _unknownFields;

				// Token: 0x040019AE RID: 6574
				public const int TargetIdFieldNumber = 1;

				// Token: 0x040019AF RID: 6575
				private long targetId_;

				// Token: 0x040019B0 RID: 6576
				public const int CasterCellIdFieldNumber = 2;

				// Token: 0x040019B1 RID: 6577
				private int casterCellId_;

				// Token: 0x040019B2 RID: 6578
				public const int TargetCellIdFieldNumber = 3;

				// Token: 0x040019B3 RID: 6579
				private int targetCellId_;

				// Token: 0x040019B4 RID: 6580
				internal static GameActionFightEvent.Types.ExchangePositions yXBVCVGbiP04X3SS0r98;
			}

			// Token: 0x020005F1 RID: 1521
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SpellRemove : IMessage<GameActionFightEvent.Types.SpellRemove>, IMessage, IEquatable<GameActionFightEvent.Types.SpellRemove>, IDeepCloneable<GameActionFightEvent.Types.SpellRemove>, IBufferMessage
			{
				// Token: 0x17000D42 RID: 3394
				// (get) Token: 0x060049B5 RID: 18869 RVA: 0x002FEB50 File Offset: 0x002FCD50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.SpellRemove> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D43 RID: 3395
				// (get) Token: 0x060049B6 RID: 18870 RVA: 0x002FEB60 File Offset: 0x002FCD60
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

				// Token: 0x17000D44 RID: 3396
				// (get) Token: 0x060049B7 RID: 18871 RVA: 0x002FEB70 File Offset: 0x002FCD70
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

				// Token: 0x060049B8 RID: 18872 RVA: 0x002FEB80 File Offset: 0x002FCD80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellRemove()
				{
				}

				// Token: 0x060049B9 RID: 18873 RVA: 0x002FEB90 File Offset: 0x002FCD90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellRemove(GameActionFightEvent.Types.SpellRemove other)
				{
				}

				// Token: 0x060049BA RID: 18874 RVA: 0x002FEBA0 File Offset: 0x002FCDA0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.SpellRemove Clone()
				{
					return null;
				}

				// Token: 0x17000D45 RID: 3397
				// (get) Token: 0x060049BB RID: 18875 RVA: 0x002FEBB0 File Offset: 0x002FCDB0
				// (set) Token: 0x060049BC RID: 18876 RVA: 0x002FEBC0 File Offset: 0x002FCDC0
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

				// Token: 0x17000D46 RID: 3398
				// (get) Token: 0x060049BD RID: 18877 RVA: 0x002FEBD0 File Offset: 0x002FCDD0
				// (set) Token: 0x060049BE RID: 18878 RVA: 0x002FEBE0 File Offset: 0x002FCDE0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool VerboseCast
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

				// Token: 0x17000D47 RID: 3399
				// (get) Token: 0x060049BF RID: 18879 RVA: 0x002FEBF0 File Offset: 0x002FCDF0
				// (set) Token: 0x060049C0 RID: 18880 RVA: 0x002FEC00 File Offset: 0x002FCE00
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GameActionFightEvent.Types.SpellRemove.Types.EffectRemove EffectRemove
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

				// Token: 0x17000D48 RID: 3400
				// (get) Token: 0x060049C1 RID: 18881 RVA: 0x002FEC10 File Offset: 0x002FCE10
				// (set) Token: 0x060049C2 RID: 18882 RVA: 0x002FEC20 File Offset: 0x002FCE20
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

				// Token: 0x17000D49 RID: 3401
				// (get) Token: 0x060049C3 RID: 18883 RVA: 0x002FEC30 File Offset: 0x002FCE30
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasSpellId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x060049C4 RID: 18884 RVA: 0x002FEC40 File Offset: 0x002FCE40
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearSpellId()
				{
				}

				// Token: 0x17000D4A RID: 3402
				// (get) Token: 0x060049C5 RID: 18885 RVA: 0x002FEC50 File Offset: 0x002FCE50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GameActionFightEvent.Types.SpellRemove.ComplementOneofCase ComplementCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (GameActionFightEvent.Types.SpellRemove.ComplementOneofCase)null;
					}
				}

				// Token: 0x060049C6 RID: 18886 RVA: 0x002FEC64 File Offset: 0x002FCE64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearComplement()
				{
				}

				// Token: 0x060049C7 RID: 18887 RVA: 0x002FEC74 File Offset: 0x002FCE74
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060049C8 RID: 18888 RVA: 0x002FEC84 File Offset: 0x002FCE84
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.SpellRemove other)
				{
					return true;
				}

				// Token: 0x060049C9 RID: 18889 RVA: 0x002FEC94 File Offset: 0x002FCE94
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x060049CA RID: 18890 RVA: 0x002FECA4 File Offset: 0x002FCEA4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x060049CB RID: 18891 RVA: 0x002FECB4 File Offset: 0x002FCEB4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x060049CC RID: 18892 RVA: 0x002FECC4 File Offset: 0x002FCEC4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x060049CD RID: 18893 RVA: 0x002FECD4 File Offset: 0x002FCED4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x060049CE RID: 18894 RVA: 0x002FECE4 File Offset: 0x002FCEE4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.SpellRemove other)
				{
				}

				// Token: 0x060049CF RID: 18895 RVA: 0x002FECF4 File Offset: 0x002FCEF4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x060049D0 RID: 18896 RVA: 0x002FED04 File Offset: 0x002FCF04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x060049D1 RID: 18897 RVA: 0x002FED14 File Offset: 0x002FCF14
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SpellRemove()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						GameActionFightEvent.Types.SpellRemove._parser = new MessageParser<GameActionFightEvent.Types.SpellRemove>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x060049D2 RID: 18898 RVA: 0x002FEE0C File Offset: 0x002FD00C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool b7A2xQGbuvnKImbB2tHr()
				{
					return true;
				}

				// Token: 0x060049D3 RID: 18899 RVA: 0x002FEE14 File Offset: 0x002FD014
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.SpellRemove mfoHCHGb8RRqgrOO1Spr()
				{
					return null;
				}

				// Token: 0x040019B7 RID: 6583
				private static readonly MessageParser<GameActionFightEvent.Types.SpellRemove> _parser;

				// Token: 0x040019B8 RID: 6584
				private UnknownFieldSet _unknownFields;

				// Token: 0x040019B9 RID: 6585
				public const int TargetIdFieldNumber = 1;

				// Token: 0x040019BA RID: 6586
				private long targetId_;

				// Token: 0x040019BB RID: 6587
				public const int VerboseCastFieldNumber = 2;

				// Token: 0x040019BC RID: 6588
				private bool verboseCast_;

				// Token: 0x040019BD RID: 6589
				public const int EffectRemoveFieldNumber = 3;

				// Token: 0x040019BE RID: 6590
				public const int SpellIdFieldNumber = 4;

				// Token: 0x040019BF RID: 6591
				private object complement_;

				// Token: 0x040019C0 RID: 6592
				private GameActionFightEvent.Types.SpellRemove.ComplementOneofCase complementCase_;

				// Token: 0x040019C1 RID: 6593
				internal static GameActionFightEvent.Types.SpellRemove F4q1A1GbMAtXLuRxWwQ6;

				// Token: 0x020005F2 RID: 1522
				public enum ComplementOneofCase
				{
					// Token: 0x040019C3 RID: 6595
					None,
					// Token: 0x040019C4 RID: 6596
					EffectRemove = 3,
					// Token: 0x040019C5 RID: 6597
					SpellId
				}

				// Token: 0x020005F3 RID: 1523
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x060049D4 RID: 18900 RVA: 0x00313CA8 File Offset: 0x00311EA8
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x020005F4 RID: 1524
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class EffectRemove : IMessage<GameActionFightEvent.Types.SpellRemove.Types.EffectRemove>, IMessage, IEquatable<GameActionFightEvent.Types.SpellRemove.Types.EffectRemove>, IDeepCloneable<GameActionFightEvent.Types.SpellRemove.Types.EffectRemove>, IBufferMessage
					{
						// Token: 0x17000D4B RID: 3403
						// (get) Token: 0x060049D5 RID: 18901 RVA: 0x0031C8AC File Offset: 0x0031AAAC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public static MessageParser<GameActionFightEvent.Types.SpellRemove.Types.EffectRemove> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000D4C RID: 3404
						// (get) Token: 0x060049D6 RID: 18902 RVA: 0x0031C8BC File Offset: 0x0031AABC
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

						// Token: 0x17000D4D RID: 3405
						// (get) Token: 0x060049D7 RID: 18903 RVA: 0x0031C8CC File Offset: 0x0031AACC
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

						// Token: 0x060049D8 RID: 18904 RVA: 0x0031C8DC File Offset: 0x0031AADC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public EffectRemove()
						{
						}

						// Token: 0x060049D9 RID: 18905 RVA: 0x0031C8EC File Offset: 0x0031AAEC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public EffectRemove(GameActionFightEvent.Types.SpellRemove.Types.EffectRemove other)
						{
						}

						// Token: 0x060049DA RID: 18906 RVA: 0x0031C8FC File Offset: 0x0031AAFC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public GameActionFightEvent.Types.SpellRemove.Types.EffectRemove Clone()
						{
							return null;
						}

						// Token: 0x17000D4E RID: 3406
						// (get) Token: 0x060049DB RID: 18907 RVA: 0x0031C90C File Offset: 0x0031AB0C
						// (set) Token: 0x060049DC RID: 18908 RVA: 0x0031C91C File Offset: 0x0031AB1C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int Effect
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

						// Token: 0x17000D4F RID: 3407
						// (get) Token: 0x060049DD RID: 18909 RVA: 0x0031C92C File Offset: 0x0031AB2C
						// (set) Token: 0x060049DE RID: 18910 RVA: 0x0031C93C File Offset: 0x0031AB3C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public bool Trigger
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

						// Token: 0x060049DF RID: 18911 RVA: 0x0031C94C File Offset: 0x0031AB4C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x060049E0 RID: 18912 RVA: 0x0031C95C File Offset: 0x0031AB5C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(GameActionFightEvent.Types.SpellRemove.Types.EffectRemove other)
						{
							return true;
						}

						// Token: 0x060049E1 RID: 18913 RVA: 0x0031C96C File Offset: 0x0031AB6C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x060049E2 RID: 18914 RVA: 0x0031C97C File Offset: 0x0031AB7C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x060049E3 RID: 18915 RVA: 0x0031C98C File Offset: 0x0031AB8C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x060049E4 RID: 18916 RVA: 0x0031C99C File Offset: 0x0031AB9C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x060049E5 RID: 18917 RVA: 0x0031C9AC File Offset: 0x0031ABAC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x060049E6 RID: 18918 RVA: 0x0031C9BC File Offset: 0x0031ABBC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(GameActionFightEvent.Types.SpellRemove.Types.EffectRemove other)
						{
						}

						// Token: 0x060049E7 RID: 18919 RVA: 0x0031C9CC File Offset: 0x0031ABCC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x060049E8 RID: 18920 RVA: 0x0031C9DC File Offset: 0x0031ABDC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x060049E9 RID: 18921 RVA: 0x0031C9EC File Offset: 0x0031ABEC
						[MethodImpl(MethodImplOptions.NoInlining)]
						static EffectRemove()
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
										GameActionFightEvent.Types.SpellRemove.Types.EffectRemove._parser = new MessageParser<GameActionFightEvent.Types.SpellRemove.Types.EffectRemove>(() => null);
										num2 = 2;
										break;
									case 1:
										UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
										{
											num2 = 0;
										}
										break;
									case 2:
										return;
									case 3:
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
										{
											num2 = 1;
										}
										break;
									case 4:
										goto IL_59;
									}
								}
								IL_59:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num = 3;
							}
						}

						// Token: 0x060049EA RID: 18922 RVA: 0x0031CABC File Offset: 0x0031ACBC
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool avxcQbgJERXAOY7XjVw2()
						{
							return true;
						}

						// Token: 0x060049EB RID: 18923 RVA: 0x0031CAC4 File Offset: 0x0031ACC4
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static GameActionFightEvent.Types.SpellRemove.Types.EffectRemove w83CSFgJX1Qvr0K10lXR()
						{
							return null;
						}

						// Token: 0x040019C6 RID: 6598
						private static readonly MessageParser<GameActionFightEvent.Types.SpellRemove.Types.EffectRemove> _parser;

						// Token: 0x040019C7 RID: 6599
						private UnknownFieldSet _unknownFields;

						// Token: 0x040019C8 RID: 6600
						public const int EffectFieldNumber = 1;

						// Token: 0x040019C9 RID: 6601
						private int effect_;

						// Token: 0x040019CA RID: 6602
						public const int TriggerFieldNumber = 2;

						// Token: 0x040019CB RID: 6603
						private bool trigger_;

						// Token: 0x040019CC RID: 6604
						private static GameActionFightEvent.Types.SpellRemove.Types.EffectRemove DeRJRQgJ2hoeamr3cBPW;
					}
				}
			}

			// Token: 0x020005F7 RID: 1527
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Tackled : IMessage<GameActionFightEvent.Types.Tackled>, IMessage, IEquatable<GameActionFightEvent.Types.Tackled>, IDeepCloneable<GameActionFightEvent.Types.Tackled>, IBufferMessage
			{
				// Token: 0x17000D50 RID: 3408
				// (get) Token: 0x060049F6 RID: 18934 RVA: 0x002FEE1C File Offset: 0x002FD01C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.Tackled> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D51 RID: 3409
				// (get) Token: 0x060049F7 RID: 18935 RVA: 0x002FEE2C File Offset: 0x002FD02C
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

				// Token: 0x17000D52 RID: 3410
				// (get) Token: 0x060049F8 RID: 18936 RVA: 0x002FEE3C File Offset: 0x002FD03C
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

				// Token: 0x060049F9 RID: 18937 RVA: 0x002FEE4C File Offset: 0x002FD04C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Tackled()
				{
				}

				// Token: 0x060049FA RID: 18938 RVA: 0x002FEE5C File Offset: 0x002FD05C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Tackled(GameActionFightEvent.Types.Tackled other)
				{
				}

				// Token: 0x060049FB RID: 18939 RVA: 0x002FEE6C File Offset: 0x002FD06C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.Tackled Clone()
				{
					return null;
				}

				// Token: 0x17000D53 RID: 3411
				// (get) Token: 0x060049FC RID: 18940 RVA: 0x002FEE7C File Offset: 0x002FD07C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public RepeatedField<long> TacklersId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x060049FD RID: 18941 RVA: 0x002FEE8C File Offset: 0x002FD08C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x060049FE RID: 18942 RVA: 0x002FEE9C File Offset: 0x002FD09C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.Tackled other)
				{
					return true;
				}

				// Token: 0x060049FF RID: 18943 RVA: 0x002FEEAC File Offset: 0x002FD0AC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004A00 RID: 18944 RVA: 0x002FEEBC File Offset: 0x002FD0BC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004A01 RID: 18945 RVA: 0x002FEECC File Offset: 0x002FD0CC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004A02 RID: 18946 RVA: 0x002FEEDC File Offset: 0x002FD0DC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004A03 RID: 18947 RVA: 0x002FEEEC File Offset: 0x002FD0EC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004A04 RID: 18948 RVA: 0x002FEEFC File Offset: 0x002FD0FC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.Tackled other)
				{
				}

				// Token: 0x06004A05 RID: 18949 RVA: 0x002FEF0C File Offset: 0x002FD10C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004A06 RID: 18950 RVA: 0x002FEF1C File Offset: 0x002FD11C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004A07 RID: 18951 RVA: 0x002FEF2C File Offset: 0x002FD12C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Tackled()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					for (;;)
					{
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
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
								{
									num2 = 0;
								}
								break;
							case 2:
								xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
								{
									num2 = 0;
								}
								break;
							case 3:
								goto IL_AF;
							case 4:
								GameActionFightEvent.Types.Tackled._parser = new MessageParser<GameActionFightEvent.Types.Tackled>(() => null);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
								{
									num2 = 3;
								}
								break;
							case 5:
								return;
							}
						}
						IL_AF:
						GameActionFightEvent.Types.Tackled._repeated_tacklersId_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(10U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
						num = 5;
					}
				}

				// Token: 0x06004A08 RID: 18952 RVA: 0x002FF030 File Offset: 0x002FD230
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool U6ccbRGbqTFiEMOfLIAo()
				{
					return true;
				}

				// Token: 0x06004A09 RID: 18953 RVA: 0x002FF038 File Offset: 0x002FD238
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.Tackled Okf7PuGbFktHFpCQlY0r()
				{
					return null;
				}

				// Token: 0x040019D1 RID: 6609
				private static readonly MessageParser<GameActionFightEvent.Types.Tackled> _parser;

				// Token: 0x040019D2 RID: 6610
				private UnknownFieldSet _unknownFields;

				// Token: 0x040019D3 RID: 6611
				public const int TacklersIdFieldNumber = 1;

				// Token: 0x040019D4 RID: 6612
				private static readonly FieldCodec<long> _repeated_tacklersId_codec;

				// Token: 0x040019D5 RID: 6613
				private readonly RepeatedField<long> tacklersId_;

				// Token: 0x040019D6 RID: 6614
				internal static GameActionFightEvent.Types.Tackled Gq5d04GbZ9d8GQMQhmg9;
			}

			// Token: 0x020005F9 RID: 1529
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class PointsVariation : IMessage<GameActionFightEvent.Types.PointsVariation>, IMessage, IEquatable<GameActionFightEvent.Types.PointsVariation>, IDeepCloneable<GameActionFightEvent.Types.PointsVariation>, IBufferMessage
			{
				// Token: 0x17000D54 RID: 3412
				// (get) Token: 0x06004A0F RID: 18959 RVA: 0x002FF040 File Offset: 0x002FD240
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.PointsVariation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D55 RID: 3413
				// (get) Token: 0x06004A10 RID: 18960 RVA: 0x002FF050 File Offset: 0x002FD250
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

				// Token: 0x17000D56 RID: 3414
				// (get) Token: 0x06004A11 RID: 18961 RVA: 0x002FF060 File Offset: 0x002FD260
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

				// Token: 0x06004A12 RID: 18962 RVA: 0x002FF070 File Offset: 0x002FD270
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PointsVariation()
				{
				}

				// Token: 0x06004A13 RID: 18963 RVA: 0x002FF080 File Offset: 0x002FD280
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public PointsVariation(GameActionFightEvent.Types.PointsVariation other)
				{
				}

				// Token: 0x06004A14 RID: 18964 RVA: 0x002FF090 File Offset: 0x002FD290
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.PointsVariation Clone()
				{
					return null;
				}

				// Token: 0x17000D57 RID: 3415
				// (get) Token: 0x06004A15 RID: 18965 RVA: 0x002FF0A0 File Offset: 0x002FD2A0
				// (set) Token: 0x06004A16 RID: 18966 RVA: 0x002FF0B0 File Offset: 0x002FD2B0
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

				// Token: 0x17000D58 RID: 3416
				// (get) Token: 0x06004A17 RID: 18967 RVA: 0x002FF0C0 File Offset: 0x002FD2C0
				// (set) Token: 0x06004A18 RID: 18968 RVA: 0x002FF0D0 File Offset: 0x002FD2D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x06004A19 RID: 18969 RVA: 0x002FF0E0 File Offset: 0x002FD2E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004A1A RID: 18970 RVA: 0x002FF0F0 File Offset: 0x002FD2F0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.PointsVariation other)
				{
					return true;
				}

				// Token: 0x06004A1B RID: 18971 RVA: 0x002FF100 File Offset: 0x002FD300
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004A1C RID: 18972 RVA: 0x002FF110 File Offset: 0x002FD310
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004A1D RID: 18973 RVA: 0x002FF120 File Offset: 0x002FD320
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004A1E RID: 18974 RVA: 0x002FF130 File Offset: 0x002FD330
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004A1F RID: 18975 RVA: 0x002FF140 File Offset: 0x002FD340
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004A20 RID: 18976 RVA: 0x002FF150 File Offset: 0x002FD350
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.PointsVariation other)
				{
				}

				// Token: 0x06004A21 RID: 18977 RVA: 0x002FF160 File Offset: 0x002FD360
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004A22 RID: 18978 RVA: 0x002FF170 File Offset: 0x002FD370
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004A23 RID: 18979 RVA: 0x002FF180 File Offset: 0x002FD380
				[MethodImpl(MethodImplOptions.NoInlining)]
				static PointsVariation()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							GameActionFightEvent.Types.PointsVariation._parser = new MessageParser<GameActionFightEvent.Types.PointsVariation>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							continue;
						}
						break;
					}
				}

				// Token: 0x06004A24 RID: 18980 RVA: 0x002FF24C File Offset: 0x002FD44C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool TY8P1MGifVPeTDW6y2pQ()
				{
					return true;
				}

				// Token: 0x06004A25 RID: 18981 RVA: 0x002FF254 File Offset: 0x002FD454
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.PointsVariation tvdlw4GinUnQpLTi8Dsw()
				{
					return null;
				}

				// Token: 0x040019D9 RID: 6617
				private static readonly MessageParser<GameActionFightEvent.Types.PointsVariation> _parser;

				// Token: 0x040019DA RID: 6618
				private UnknownFieldSet _unknownFields;

				// Token: 0x040019DB RID: 6619
				public const int TargetIdFieldNumber = 1;

				// Token: 0x040019DC RID: 6620
				private long targetId_;

				// Token: 0x040019DD RID: 6621
				public const int DeltaFieldNumber = 2;

				// Token: 0x040019DE RID: 6622
				private int delta_;

				// Token: 0x040019DF RID: 6623
				private static GameActionFightEvent.Types.PointsVariation NPatMAGbzPAK5rrjc6u7;
			}

			// Token: 0x020005FB RID: 1531
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class InvisibleDetected : IMessage<GameActionFightEvent.Types.InvisibleDetected>, IMessage, IEquatable<GameActionFightEvent.Types.InvisibleDetected>, IDeepCloneable<GameActionFightEvent.Types.InvisibleDetected>, IBufferMessage
			{
				// Token: 0x17000D59 RID: 3417
				// (get) Token: 0x06004A2B RID: 18987 RVA: 0x002FF25C File Offset: 0x002FD45C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.InvisibleDetected> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D5A RID: 3418
				// (get) Token: 0x06004A2C RID: 18988 RVA: 0x002FF26C File Offset: 0x002FD46C
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

				// Token: 0x17000D5B RID: 3419
				// (get) Token: 0x06004A2D RID: 18989 RVA: 0x002FF27C File Offset: 0x002FD47C
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

				// Token: 0x06004A2E RID: 18990 RVA: 0x002FF28C File Offset: 0x002FD48C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public InvisibleDetected()
				{
				}

				// Token: 0x06004A2F RID: 18991 RVA: 0x002FF29C File Offset: 0x002FD49C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public InvisibleDetected(GameActionFightEvent.Types.InvisibleDetected other)
				{
				}

				// Token: 0x06004A30 RID: 18992 RVA: 0x002FF2AC File Offset: 0x002FD4AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.InvisibleDetected Clone()
				{
					return null;
				}

				// Token: 0x17000D5C RID: 3420
				// (get) Token: 0x06004A31 RID: 18993 RVA: 0x002FF2BC File Offset: 0x002FD4BC
				// (set) Token: 0x06004A32 RID: 18994 RVA: 0x002FF2CC File Offset: 0x002FD4CC
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

				// Token: 0x17000D5D RID: 3421
				// (get) Token: 0x06004A33 RID: 18995 RVA: 0x002FF2DC File Offset: 0x002FD4DC
				// (set) Token: 0x06004A34 RID: 18996 RVA: 0x002FF2EC File Offset: 0x002FD4EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Cell
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

				// Token: 0x06004A35 RID: 18997 RVA: 0x002FF2FC File Offset: 0x002FD4FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004A36 RID: 18998 RVA: 0x002FF30C File Offset: 0x002FD50C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.InvisibleDetected other)
				{
					return true;
				}

				// Token: 0x06004A37 RID: 18999 RVA: 0x002FF31C File Offset: 0x002FD51C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004A38 RID: 19000 RVA: 0x002FF32C File Offset: 0x002FD52C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004A39 RID: 19001 RVA: 0x002FF33C File Offset: 0x002FD53C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004A3A RID: 19002 RVA: 0x002FF34C File Offset: 0x002FD54C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004A3B RID: 19003 RVA: 0x002FF35C File Offset: 0x002FD55C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004A3C RID: 19004 RVA: 0x002FF36C File Offset: 0x002FD56C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.InvisibleDetected other)
				{
				}

				// Token: 0x06004A3D RID: 19005 RVA: 0x002FF37C File Offset: 0x002FD57C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004A3E RID: 19006 RVA: 0x002FF38C File Offset: 0x002FD58C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004A3F RID: 19007 RVA: 0x002FF39C File Offset: 0x002FD59C
				[MethodImpl(MethodImplOptions.NoInlining)]
				static InvisibleDetected()
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
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
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
							GameActionFightEvent.Types.InvisibleDetected._parser = new MessageParser<GameActionFightEvent.Types.InvisibleDetected>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004A40 RID: 19008 RVA: 0x002FF480 File Offset: 0x002FD680
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool phSGWEGiAQSp3uINpURp()
				{
					return true;
				}

				// Token: 0x06004A41 RID: 19009 RVA: 0x002FF488 File Offset: 0x002FD688
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.InvisibleDetected j2YEdRGiB7NU6rK9waUg()
				{
					return null;
				}

				// Token: 0x040019E2 RID: 6626
				private static readonly MessageParser<GameActionFightEvent.Types.InvisibleDetected> _parser;

				// Token: 0x040019E3 RID: 6627
				private UnknownFieldSet _unknownFields;

				// Token: 0x040019E4 RID: 6628
				public const int TargetIdFieldNumber = 1;

				// Token: 0x040019E5 RID: 6629
				private long targetId_;

				// Token: 0x040019E6 RID: 6630
				public const int CellFieldNumber = 2;

				// Token: 0x040019E7 RID: 6631
				private int cell_;

				// Token: 0x040019E8 RID: 6632
				internal static GameActionFightEvent.Types.InvisibleDetected S5VKYxGimgC7QhKnv2BL;
			}

			// Token: 0x020005FD RID: 1533
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class TargetedAbility : IMessage<GameActionFightEvent.Types.TargetedAbility>, IMessage, IEquatable<GameActionFightEvent.Types.TargetedAbility>, IDeepCloneable<GameActionFightEvent.Types.TargetedAbility>, IBufferMessage
			{
				// Token: 0x17000D5E RID: 3422
				// (get) Token: 0x06004A47 RID: 19015 RVA: 0x002FF490 File Offset: 0x002FD690
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.TargetedAbility> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D5F RID: 3423
				// (get) Token: 0x06004A48 RID: 19016 RVA: 0x002FF4A0 File Offset: 0x002FD6A0
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

				// Token: 0x17000D60 RID: 3424
				// (get) Token: 0x06004A49 RID: 19017 RVA: 0x002FF4B0 File Offset: 0x002FD6B0
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

				// Token: 0x06004A4A RID: 19018 RVA: 0x002FF4C0 File Offset: 0x002FD6C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TargetedAbility()
				{
				}

				// Token: 0x06004A4B RID: 19019 RVA: 0x002FF4D0 File Offset: 0x002FD6D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public TargetedAbility(GameActionFightEvent.Types.TargetedAbility other)
				{
				}

				// Token: 0x06004A4C RID: 19020 RVA: 0x002FF4E0 File Offset: 0x002FD6E0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.TargetedAbility Clone()
				{
					return null;
				}

				// Token: 0x17000D61 RID: 3425
				// (get) Token: 0x06004A4D RID: 19021 RVA: 0x002FF4F0 File Offset: 0x002FD6F0
				// (set) Token: 0x06004A4E RID: 19022 RVA: 0x002FF500 File Offset: 0x002FD700
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D62 RID: 3426
				// (get) Token: 0x06004A4F RID: 19023 RVA: 0x002FF510 File Offset: 0x002FD710
				// (set) Token: 0x06004A50 RID: 19024 RVA: 0x002FF520 File Offset: 0x002FD720
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int DestinationCell
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

				// Token: 0x17000D63 RID: 3427
				// (get) Token: 0x06004A51 RID: 19025 RVA: 0x002FF530 File Offset: 0x002FD730
				// (set) Token: 0x06004A52 RID: 19026 RVA: 0x002FF544 File Offset: 0x002FD744
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public FightSpellCastCritical Critical
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (FightSpellCastCritical)null;
					}
					[MethodImpl(MethodImplOptions.NoInlining)]
					set
					{
					}
				}

				// Token: 0x17000D64 RID: 3428
				// (get) Token: 0x06004A53 RID: 19027 RVA: 0x002FF554 File Offset: 0x002FD754
				// (set) Token: 0x06004A54 RID: 19028 RVA: 0x002FF564 File Offset: 0x002FD764
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool SilentCast
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

				// Token: 0x17000D65 RID: 3429
				// (get) Token: 0x06004A55 RID: 19029 RVA: 0x002FF574 File Offset: 0x002FD774
				// (set) Token: 0x06004A56 RID: 19030 RVA: 0x002FF584 File Offset: 0x002FD784
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool VerboseCast
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

				// Token: 0x17000D66 RID: 3430
				// (get) Token: 0x06004A57 RID: 19031 RVA: 0x002FF594 File Offset: 0x002FD794
				// (set) Token: 0x06004A58 RID: 19032 RVA: 0x002FF5A4 File Offset: 0x002FD7A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GameActionFightEvent.Types.TargetedAbility.Types.SpellCast SpellCast
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

				// Token: 0x17000D67 RID: 3431
				// (get) Token: 0x06004A59 RID: 19033 RVA: 0x002FF5B4 File Offset: 0x002FD7B4
				// (set) Token: 0x06004A5A RID: 19034 RVA: 0x002FF5C4 File Offset: 0x002FD7C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int WeaponGenericId
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

				// Token: 0x17000D68 RID: 3432
				// (get) Token: 0x06004A5B RID: 19035 RVA: 0x002FF5D4 File Offset: 0x002FD7D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public bool HasWeaponGenericId
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06004A5C RID: 19036 RVA: 0x002FF5E4 File Offset: 0x002FD7E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearWeaponGenericId()
				{
				}

				// Token: 0x17000D69 RID: 3433
				// (get) Token: 0x06004A5D RID: 19037 RVA: 0x002FF5F4 File Offset: 0x002FD7F4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public GameActionFightEvent.Types.TargetedAbility.FightOneofCase FightCase
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return (GameActionFightEvent.Types.TargetedAbility.FightOneofCase)null;
					}
				}

				// Token: 0x06004A5E RID: 19038 RVA: 0x002FF608 File Offset: 0x002FD808
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearFight()
				{
				}

				// Token: 0x06004A5F RID: 19039 RVA: 0x002FF618 File Offset: 0x002FD818
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004A60 RID: 19040 RVA: 0x002FF628 File Offset: 0x002FD828
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.TargetedAbility other)
				{
					return true;
				}

				// Token: 0x06004A61 RID: 19041 RVA: 0x002FF638 File Offset: 0x002FD838
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004A62 RID: 19042 RVA: 0x002FF648 File Offset: 0x002FD848
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004A63 RID: 19043 RVA: 0x002FF658 File Offset: 0x002FD858
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004A64 RID: 19044 RVA: 0x002FF668 File Offset: 0x002FD868
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004A65 RID: 19045 RVA: 0x002FF678 File Offset: 0x002FD878
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004A66 RID: 19046 RVA: 0x002FF688 File Offset: 0x002FD888
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.TargetedAbility other)
				{
				}

				// Token: 0x06004A67 RID: 19047 RVA: 0x002FF698 File Offset: 0x002FD898
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004A68 RID: 19048 RVA: 0x002FF6A8 File Offset: 0x002FD8A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004A69 RID: 19049 RVA: 0x002FF6B8 File Offset: 0x002FD8B8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static TargetedAbility()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 4;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
							continue;
						case 2:
							GameActionFightEvent.Types.TargetedAbility._parser = new MessageParser<GameActionFightEvent.Types.TargetedAbility>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 3;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004A6A RID: 19050 RVA: 0x002FF79C File Offset: 0x002FD99C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool PByaTyGi3S9C6EN6Ua2d()
				{
					return true;
				}

				// Token: 0x06004A6B RID: 19051 RVA: 0x002FF7A4 File Offset: 0x002FD9A4
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.TargetedAbility GiqISfGiRSh07aqx6tjw()
				{
					return null;
				}

				// Token: 0x040019EB RID: 6635
				private static readonly MessageParser<GameActionFightEvent.Types.TargetedAbility> _parser;

				// Token: 0x040019EC RID: 6636
				private UnknownFieldSet _unknownFields;

				// Token: 0x040019ED RID: 6637
				public const int TargetIdFieldNumber = 1;

				// Token: 0x040019EE RID: 6638
				private long targetId_;

				// Token: 0x040019EF RID: 6639
				public const int DestinationCellFieldNumber = 2;

				// Token: 0x040019F0 RID: 6640
				private int destinationCell_;

				// Token: 0x040019F1 RID: 6641
				public const int CriticalFieldNumber = 3;

				// Token: 0x040019F2 RID: 6642
				private FightSpellCastCritical critical_;

				// Token: 0x040019F3 RID: 6643
				public const int SilentCastFieldNumber = 4;

				// Token: 0x040019F4 RID: 6644
				private bool silentCast_;

				// Token: 0x040019F5 RID: 6645
				public const int VerboseCastFieldNumber = 5;

				// Token: 0x040019F6 RID: 6646
				private bool verboseCast_;

				// Token: 0x040019F7 RID: 6647
				public const int SpellCastFieldNumber = 6;

				// Token: 0x040019F8 RID: 6648
				public const int WeaponGenericIdFieldNumber = 7;

				// Token: 0x040019F9 RID: 6649
				private object fight_;

				// Token: 0x040019FA RID: 6650
				private GameActionFightEvent.Types.TargetedAbility.FightOneofCase fightCase_;

				// Token: 0x040019FB RID: 6651
				internal static GameActionFightEvent.Types.TargetedAbility pLDCF3Gieyy2vN6fP9NX;

				// Token: 0x020005FE RID: 1534
				public enum FightOneofCase
				{
					// Token: 0x040019FD RID: 6653
					None,
					// Token: 0x040019FE RID: 6654
					SpellCast = 6,
					// Token: 0x040019FF RID: 6655
					WeaponGenericId
				}

				// Token: 0x020005FF RID: 1535
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static class Types
				{
					// Token: 0x06004A6C RID: 19052 RVA: 0x00314080 File Offset: 0x00312280
					[MethodImpl(MethodImplOptions.NoInlining)]
					static Types()
					{
						uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					}

					// Token: 0x02000600 RID: 1536
					[DebuggerDisplay("{ToString(),nq}")]
					public sealed class SpellCast : IMessage<GameActionFightEvent.Types.TargetedAbility.Types.SpellCast>, IMessage, IEquatable<GameActionFightEvent.Types.TargetedAbility.Types.SpellCast>, IDeepCloneable<GameActionFightEvent.Types.TargetedAbility.Types.SpellCast>, IBufferMessage
					{
						// Token: 0x17000D6A RID: 3434
						// (get) Token: 0x06004A6D RID: 19053 RVA: 0x0031CACC File Offset: 0x0031ACCC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public static MessageParser<GameActionFightEvent.Types.TargetedAbility.Types.SpellCast> Parser
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x17000D6B RID: 3435
						// (get) Token: 0x06004A6E RID: 19054 RVA: 0x0031CADC File Offset: 0x0031ACDC
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

						// Token: 0x17000D6C RID: 3436
						// (get) Token: 0x06004A6F RID: 19055 RVA: 0x0031CAEC File Offset: 0x0031ACEC
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

						// Token: 0x06004A70 RID: 19056 RVA: 0x0031CAFC File Offset: 0x0031ACFC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SpellCast()
						{
						}

						// Token: 0x06004A71 RID: 19057 RVA: 0x0031CB0C File Offset: 0x0031AD0C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public SpellCast(GameActionFightEvent.Types.TargetedAbility.Types.SpellCast other)
						{
						}

						// Token: 0x06004A72 RID: 19058 RVA: 0x0031CB1C File Offset: 0x0031AD1C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public GameActionFightEvent.Types.TargetedAbility.Types.SpellCast Clone()
						{
							return null;
						}

						// Token: 0x17000D6D RID: 3437
						// (get) Token: 0x06004A73 RID: 19059 RVA: 0x0031CB2C File Offset: 0x0031AD2C
						// (set) Token: 0x06004A74 RID: 19060 RVA: 0x0031CB3C File Offset: 0x0031AD3C
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

						// Token: 0x17000D6E RID: 3438
						// (get) Token: 0x06004A75 RID: 19061 RVA: 0x0031CB4C File Offset: 0x0031AD4C
						// (set) Token: 0x06004A76 RID: 19062 RVA: 0x0031CB5C File Offset: 0x0031AD5C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						public int SpellLevel
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

						// Token: 0x17000D6F RID: 3439
						// (get) Token: 0x06004A77 RID: 19063 RVA: 0x0031CB6C File Offset: 0x0031AD6C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						public RepeatedField<int> PortalsId
						{
							[MethodImpl(MethodImplOptions.NoInlining)]
							get
							{
								return null;
							}
						}

						// Token: 0x06004A78 RID: 19064 RVA: 0x0031CB7C File Offset: 0x0031AD7C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override bool Equals(object other)
						{
							return true;
						}

						// Token: 0x06004A79 RID: 19065 RVA: 0x0031CB8C File Offset: 0x0031AD8C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public bool Equals(GameActionFightEvent.Types.TargetedAbility.Types.SpellCast other)
						{
							return true;
						}

						// Token: 0x06004A7A RID: 19066 RVA: 0x0031CB9C File Offset: 0x0031AD9C
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override int GetHashCode()
						{
							return 0;
						}

						// Token: 0x06004A7B RID: 19067 RVA: 0x0031CBAC File Offset: 0x0031ADAC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public override string ToString()
						{
							return null;
						}

						// Token: 0x06004A7C RID: 19068 RVA: 0x0031CBBC File Offset: 0x0031ADBC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void WriteTo(CodedOutputStream output)
						{
						}

						// Token: 0x06004A7D RID: 19069 RVA: 0x0031CBCC File Offset: 0x0031ADCC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalWriteTo(ref WriteContext output)
						{
						}

						// Token: 0x06004A7E RID: 19070 RVA: 0x0031CBDC File Offset: 0x0031ADDC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public int CalculateSize()
						{
							return 0;
						}

						// Token: 0x06004A7F RID: 19071 RVA: 0x0031CBEC File Offset: 0x0031ADEC
						[GeneratedCode("protoc", null)]
						[DebuggerNonUserCode]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(GameActionFightEvent.Types.TargetedAbility.Types.SpellCast other)
						{
						}

						// Token: 0x06004A80 RID: 19072 RVA: 0x0031CBFC File Offset: 0x0031ADFC
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						public void MergeFrom(CodedInputStream input)
						{
						}

						// Token: 0x06004A81 RID: 19073 RVA: 0x0031CC0C File Offset: 0x0031AE0C
						[DebuggerNonUserCode]
						[GeneratedCode("protoc", null)]
						[MethodImpl(MethodImplOptions.NoInlining)]
						void IBufferMessage.InternalMergeFrom(ref ParseContext input)
						{
						}

						// Token: 0x06004A82 RID: 19074 RVA: 0x0031CC1C File Offset: 0x0031AE1C
						[MethodImpl(MethodImplOptions.NoInlining)]
						static SpellCast()
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
									case 1:
										return;
									case 2:
										goto IL_39;
									case 3:
										AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
										num2 = 0;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									case 4:
										xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
										num2 = 3;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
										{
											num2 = 3;
											continue;
										}
										continue;
									case 5:
										GameActionFightEvent.Types.TargetedAbility.Types.SpellCast._repeated_portalsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
										num2 = 1;
										if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
										{
											num2 = 0;
											continue;
										}
										continue;
									}
									UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
									num2 = 0;
									if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
									{
										num2 = 2;
									}
								}
								IL_39:
								GameActionFightEvent.Types.TargetedAbility.Types.SpellCast._parser = new MessageParser<GameActionFightEvent.Types.TargetedAbility.Types.SpellCast>(() => null);
								num = 5;
							}
						}

						// Token: 0x06004A83 RID: 19075 RVA: 0x0031CD38 File Offset: 0x0031AF38
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static bool vI8WRqgJxiWcvvPlRBYn()
						{
							return true;
						}

						// Token: 0x06004A84 RID: 19076 RVA: 0x0031CD40 File Offset: 0x0031AF40
						[MethodImpl(MethodImplOptions.NoInlining)]
						internal static GameActionFightEvent.Types.TargetedAbility.Types.SpellCast mYgdjagJ4NFshwsfINpV()
						{
							return null;
						}

						// Token: 0x04001A00 RID: 6656
						private static readonly MessageParser<GameActionFightEvent.Types.TargetedAbility.Types.SpellCast> _parser;

						// Token: 0x04001A01 RID: 6657
						private UnknownFieldSet _unknownFields;

						// Token: 0x04001A02 RID: 6658
						public const int SpellIdFieldNumber = 1;

						// Token: 0x04001A03 RID: 6659
						private int spellId_;

						// Token: 0x04001A04 RID: 6660
						public const int SpellLevelFieldNumber = 2;

						// Token: 0x04001A05 RID: 6661
						private int spellLevel_;

						// Token: 0x04001A06 RID: 6662
						public const int PortalsIdFieldNumber = 3;

						// Token: 0x04001A07 RID: 6663
						private static readonly FieldCodec<int> _repeated_portalsId_codec;

						// Token: 0x04001A08 RID: 6664
						private readonly RepeatedField<int> portalsId_;

						// Token: 0x04001A09 RID: 6665
						private static GameActionFightEvent.Types.TargetedAbility.Types.SpellCast tiU5y1gJNWy2G1l42Kp5;
					}
				}
			}

			// Token: 0x02000603 RID: 1539
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Vanish : IMessage<GameActionFightEvent.Types.Vanish>, IMessage, IEquatable<GameActionFightEvent.Types.Vanish>, IDeepCloneable<GameActionFightEvent.Types.Vanish>, IBufferMessage
			{
				// Token: 0x17000D70 RID: 3440
				// (get) Token: 0x06004A8F RID: 19087 RVA: 0x002FF7AC File Offset: 0x002FD9AC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.Vanish> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D71 RID: 3441
				// (get) Token: 0x06004A90 RID: 19088 RVA: 0x002FF7BC File Offset: 0x002FD9BC
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

				// Token: 0x17000D72 RID: 3442
				// (get) Token: 0x06004A91 RID: 19089 RVA: 0x002FF7CC File Offset: 0x002FD9CC
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

				// Token: 0x06004A92 RID: 19090 RVA: 0x002FF7DC File Offset: 0x002FD9DC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Vanish()
				{
				}

				// Token: 0x06004A93 RID: 19091 RVA: 0x002FF7EC File Offset: 0x002FD9EC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Vanish(GameActionFightEvent.Types.Vanish other)
				{
				}

				// Token: 0x06004A94 RID: 19092 RVA: 0x002FF7FC File Offset: 0x002FD9FC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.Vanish Clone()
				{
					return null;
				}

				// Token: 0x17000D73 RID: 3443
				// (get) Token: 0x06004A95 RID: 19093 RVA: 0x002FF80C File Offset: 0x002FDA0C
				// (set) Token: 0x06004A96 RID: 19094 RVA: 0x002FF81C File Offset: 0x002FDA1C
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

				// Token: 0x06004A97 RID: 19095 RVA: 0x002FF82C File Offset: 0x002FDA2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004A98 RID: 19096 RVA: 0x002FF83C File Offset: 0x002FDA3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.Vanish other)
				{
					return true;
				}

				// Token: 0x06004A99 RID: 19097 RVA: 0x002FF84C File Offset: 0x002FDA4C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004A9A RID: 19098 RVA: 0x002FF85C File Offset: 0x002FDA5C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004A9B RID: 19099 RVA: 0x002FF86C File Offset: 0x002FDA6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004A9C RID: 19100 RVA: 0x002FF87C File Offset: 0x002FDA7C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004A9D RID: 19101 RVA: 0x002FF88C File Offset: 0x002FDA8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004A9E RID: 19102 RVA: 0x002FF89C File Offset: 0x002FDA9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.Vanish other)
				{
				}

				// Token: 0x06004A9F RID: 19103 RVA: 0x002FF8AC File Offset: 0x002FDAAC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004AA0 RID: 19104 RVA: 0x002FF8BC File Offset: 0x002FDABC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004AA1 RID: 19105 RVA: 0x002FF8CC File Offset: 0x002FDACC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Vanish()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						}
						GameActionFightEvent.Types.Vanish._parser = new MessageParser<GameActionFightEvent.Types.Vanish>(() => null);
						num2 = 4;
					}
				}

				// Token: 0x06004AA2 RID: 19106 RVA: 0x002FF998 File Offset: 0x002FDB98
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool KVA2SYGiJiAiIMmKrRp5()
				{
					return true;
				}

				// Token: 0x06004AA3 RID: 19107 RVA: 0x002FF9A0 File Offset: 0x002FDBA0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.Vanish zhlLKwGiGPGob8DYHfqf()
				{
					return null;
				}

				// Token: 0x04001A0E RID: 6670
				private static readonly MessageParser<GameActionFightEvent.Types.Vanish> _parser;

				// Token: 0x04001A0F RID: 6671
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A10 RID: 6672
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A11 RID: 6673
				private long targetId_;

				// Token: 0x04001A12 RID: 6674
				private static GameActionFightEvent.Types.Vanish LSrH5sGiOfV5x38aGas7;
			}

			// Token: 0x02000605 RID: 1541
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Kill : IMessage<GameActionFightEvent.Types.Kill>, IMessage, IEquatable<GameActionFightEvent.Types.Kill>, IDeepCloneable<GameActionFightEvent.Types.Kill>, IBufferMessage
			{
				// Token: 0x17000D74 RID: 3444
				// (get) Token: 0x06004AA9 RID: 19113 RVA: 0x002FF9A8 File Offset: 0x002FDBA8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.Kill> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D75 RID: 3445
				// (get) Token: 0x06004AAA RID: 19114 RVA: 0x002FF9B8 File Offset: 0x002FDBB8
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

				// Token: 0x17000D76 RID: 3446
				// (get) Token: 0x06004AAB RID: 19115 RVA: 0x002FF9C8 File Offset: 0x002FDBC8
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

				// Token: 0x06004AAC RID: 19116 RVA: 0x002FF9D8 File Offset: 0x002FDBD8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Kill()
				{
				}

				// Token: 0x06004AAD RID: 19117 RVA: 0x002FF9E8 File Offset: 0x002FDBE8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Kill(GameActionFightEvent.Types.Kill other)
				{
				}

				// Token: 0x06004AAE RID: 19118 RVA: 0x002FF9F8 File Offset: 0x002FDBF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.Kill Clone()
				{
					return null;
				}

				// Token: 0x17000D77 RID: 3447
				// (get) Token: 0x06004AAF RID: 19119 RVA: 0x002FFA08 File Offset: 0x002FDC08
				// (set) Token: 0x06004AB0 RID: 19120 RVA: 0x002FFA18 File Offset: 0x002FDC18
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

				// Token: 0x06004AB1 RID: 19121 RVA: 0x002FFA28 File Offset: 0x002FDC28
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004AB2 RID: 19122 RVA: 0x002FFA38 File Offset: 0x002FDC38
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.Kill other)
				{
					return true;
				}

				// Token: 0x06004AB3 RID: 19123 RVA: 0x002FFA48 File Offset: 0x002FDC48
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004AB4 RID: 19124 RVA: 0x002FFA58 File Offset: 0x002FDC58
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004AB5 RID: 19125 RVA: 0x002FFA68 File Offset: 0x002FDC68
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004AB6 RID: 19126 RVA: 0x002FFA78 File Offset: 0x002FDC78
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004AB7 RID: 19127 RVA: 0x002FFA88 File Offset: 0x002FDC88
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004AB8 RID: 19128 RVA: 0x002FFA98 File Offset: 0x002FDC98
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.Kill other)
				{
				}

				// Token: 0x06004AB9 RID: 19129 RVA: 0x002FFAA8 File Offset: 0x002FDCA8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004ABA RID: 19130 RVA: 0x002FFAB8 File Offset: 0x002FDCB8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004ABB RID: 19131 RVA: 0x002FFAC8 File Offset: 0x002FDCC8
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Kill()
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
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						}
						GameActionFightEvent.Types.Kill._parser = new MessageParser<GameActionFightEvent.Types.Kill>(() => null);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x06004ABC RID: 19132 RVA: 0x002FFBC0 File Offset: 0x002FDDC0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool fO3jXLGisvQ7bii5SSAZ()
				{
					return true;
				}

				// Token: 0x06004ABD RID: 19133 RVA: 0x002FFBC8 File Offset: 0x002FDDC8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.Kill cg71sjGidOLXeViZfPVT()
				{
					return null;
				}

				// Token: 0x04001A15 RID: 6677
				private static readonly MessageParser<GameActionFightEvent.Types.Kill> _parser;

				// Token: 0x04001A16 RID: 6678
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A17 RID: 6679
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A18 RID: 6680
				private long targetId_;

				// Token: 0x04001A19 RID: 6681
				internal static GameActionFightEvent.Types.Kill zGVMlcGigtbkcoJDheSN;
			}

			// Token: 0x02000607 RID: 1543
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Death : IMessage<GameActionFightEvent.Types.Death>, IMessage, IEquatable<GameActionFightEvent.Types.Death>, IDeepCloneable<GameActionFightEvent.Types.Death>, IBufferMessage
			{
				// Token: 0x17000D78 RID: 3448
				// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x002FFBD0 File Offset: 0x002FDDD0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.Death> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D79 RID: 3449
				// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x002FFBE0 File Offset: 0x002FDDE0
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

				// Token: 0x17000D7A RID: 3450
				// (get) Token: 0x06004AC5 RID: 19141 RVA: 0x002FFBF0 File Offset: 0x002FDDF0
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

				// Token: 0x06004AC6 RID: 19142 RVA: 0x002FFC00 File Offset: 0x002FDE00
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Death()
				{
				}

				// Token: 0x06004AC7 RID: 19143 RVA: 0x002FFC10 File Offset: 0x002FDE10
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Death(GameActionFightEvent.Types.Death other)
				{
				}

				// Token: 0x06004AC8 RID: 19144 RVA: 0x002FFC20 File Offset: 0x002FDE20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.Death Clone()
				{
					return null;
				}

				// Token: 0x17000D7B RID: 3451
				// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x002FFC30 File Offset: 0x002FDE30
				// (set) Token: 0x06004ACA RID: 19146 RVA: 0x002FFC40 File Offset: 0x002FDE40
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x06004ACB RID: 19147 RVA: 0x002FFC50 File Offset: 0x002FDE50
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004ACC RID: 19148 RVA: 0x002FFC60 File Offset: 0x002FDE60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.Death other)
				{
					return true;
				}

				// Token: 0x06004ACD RID: 19149 RVA: 0x002FFC70 File Offset: 0x002FDE70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004ACE RID: 19150 RVA: 0x002FFC80 File Offset: 0x002FDE80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004ACF RID: 19151 RVA: 0x002FFC90 File Offset: 0x002FDE90
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004AD0 RID: 19152 RVA: 0x002FFCA0 File Offset: 0x002FDEA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004AD1 RID: 19153 RVA: 0x002FFCB0 File Offset: 0x002FDEB0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004AD2 RID: 19154 RVA: 0x002FFCC0 File Offset: 0x002FDEC0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.Death other)
				{
				}

				// Token: 0x06004AD3 RID: 19155 RVA: 0x002FFCD0 File Offset: 0x002FDED0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004AD4 RID: 19156 RVA: 0x002FFCE0 File Offset: 0x002FDEE0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004AD5 RID: 19157 RVA: 0x002FFCF0 File Offset: 0x002FDEF0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Death()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							GameActionFightEvent.Types.Death._parser = new MessageParser<GameActionFightEvent.Types.Death>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 3:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004AD6 RID: 19158 RVA: 0x002FFDE8 File Offset: 0x002FDFE8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool BSrBgpGi2tgdJKxJgMbq()
				{
					return true;
				}

				// Token: 0x06004AD7 RID: 19159 RVA: 0x002FFDF0 File Offset: 0x002FDFF0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.Death taC8HZGiEidnq6grjIsH()
				{
					return null;
				}

				// Token: 0x04001A1C RID: 6684
				private static readonly MessageParser<GameActionFightEvent.Types.Death> _parser;

				// Token: 0x04001A1D RID: 6685
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A1E RID: 6686
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A1F RID: 6687
				private long targetId_;

				// Token: 0x04001A20 RID: 6688
				internal static GameActionFightEvent.Types.Death tlZcf6Gi9np9hXq7uhhs;
			}

			// Token: 0x02000609 RID: 1545
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SpellImmunity : IMessage<GameActionFightEvent.Types.SpellImmunity>, IMessage, IEquatable<GameActionFightEvent.Types.SpellImmunity>, IDeepCloneable<GameActionFightEvent.Types.SpellImmunity>, IBufferMessage
			{
				// Token: 0x17000D7C RID: 3452
				// (get) Token: 0x06004ADD RID: 19165 RVA: 0x002FFDF8 File Offset: 0x002FDFF8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.SpellImmunity> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D7D RID: 3453
				// (get) Token: 0x06004ADE RID: 19166 RVA: 0x002FFE08 File Offset: 0x002FE008
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

				// Token: 0x17000D7E RID: 3454
				// (get) Token: 0x06004ADF RID: 19167 RVA: 0x002FFE18 File Offset: 0x002FE018
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

				// Token: 0x06004AE0 RID: 19168 RVA: 0x002FFE28 File Offset: 0x002FE028
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellImmunity()
				{
				}

				// Token: 0x06004AE1 RID: 19169 RVA: 0x002FFE38 File Offset: 0x002FE038
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellImmunity(GameActionFightEvent.Types.SpellImmunity other)
				{
				}

				// Token: 0x06004AE2 RID: 19170 RVA: 0x002FFE48 File Offset: 0x002FE048
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.SpellImmunity Clone()
				{
					return null;
				}

				// Token: 0x17000D7F RID: 3455
				// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x002FFE58 File Offset: 0x002FE058
				// (set) Token: 0x06004AE4 RID: 19172 RVA: 0x002FFE68 File Offset: 0x002FE068
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D80 RID: 3456
				// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x002FFE78 File Offset: 0x002FE078
				// (set) Token: 0x06004AE6 RID: 19174 RVA: 0x002FFE88 File Offset: 0x002FE088
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
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

				// Token: 0x06004AE7 RID: 19175 RVA: 0x002FFE98 File Offset: 0x002FE098
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004AE8 RID: 19176 RVA: 0x002FFEA8 File Offset: 0x002FE0A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.SpellImmunity other)
				{
					return true;
				}

				// Token: 0x06004AE9 RID: 19177 RVA: 0x002FFEB8 File Offset: 0x002FE0B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004AEA RID: 19178 RVA: 0x002FFEC8 File Offset: 0x002FE0C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004AEB RID: 19179 RVA: 0x002FFED8 File Offset: 0x002FE0D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004AEC RID: 19180 RVA: 0x002FFEE8 File Offset: 0x002FE0E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004AED RID: 19181 RVA: 0x002FFEF8 File Offset: 0x002FE0F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004AEE RID: 19182 RVA: 0x002FFF08 File Offset: 0x002FE108
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.SpellImmunity other)
				{
				}

				// Token: 0x06004AEF RID: 19183 RVA: 0x002FFF18 File Offset: 0x002FE118
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004AF0 RID: 19184 RVA: 0x002FFF28 File Offset: 0x002FE128
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004AF1 RID: 19185 RVA: 0x002FFF38 File Offset: 0x002FE138
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SpellImmunity()
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
							num2 = 4;
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							GameActionFightEvent.Types.SpellImmunity._parser = new MessageParser<GameActionFightEvent.Types.SpellImmunity>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 3;
							continue;
						}
						break;
					}
				}

				// Token: 0x06004AF2 RID: 19186 RVA: 0x00300004 File Offset: 0x002FE204
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool O9rK1kGiNt59DbxGoCEm()
				{
					return true;
				}

				// Token: 0x06004AF3 RID: 19187 RVA: 0x0030000C File Offset: 0x002FE20C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.SpellImmunity zEh9QbGixlVODD4BnSOd()
				{
					return null;
				}

				// Token: 0x04001A23 RID: 6691
				private static readonly MessageParser<GameActionFightEvent.Types.SpellImmunity> _parser;

				// Token: 0x04001A24 RID: 6692
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A25 RID: 6693
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A26 RID: 6694
				private long targetId_;

				// Token: 0x04001A27 RID: 6695
				public const int SpellIdFieldNumber = 2;

				// Token: 0x04001A28 RID: 6696
				private int spellId_;

				// Token: 0x04001A29 RID: 6697
				private static GameActionFightEvent.Types.SpellImmunity d4IUhoGiXu2VX1rd7gMq;
			}

			// Token: 0x0200060B RID: 1547
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class SpellCoolDownVariation : IMessage<GameActionFightEvent.Types.SpellCoolDownVariation>, IMessage, IEquatable<GameActionFightEvent.Types.SpellCoolDownVariation>, IDeepCloneable<GameActionFightEvent.Types.SpellCoolDownVariation>, IBufferMessage
			{
				// Token: 0x17000D81 RID: 3457
				// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x00300014 File Offset: 0x002FE214
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.SpellCoolDownVariation> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D82 RID: 3458
				// (get) Token: 0x06004AFA RID: 19194 RVA: 0x00300024 File Offset: 0x002FE224
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

				// Token: 0x17000D83 RID: 3459
				// (get) Token: 0x06004AFB RID: 19195 RVA: 0x00300034 File Offset: 0x002FE234
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

				// Token: 0x06004AFC RID: 19196 RVA: 0x00300044 File Offset: 0x002FE244
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellCoolDownVariation()
				{
				}

				// Token: 0x06004AFD RID: 19197 RVA: 0x00300054 File Offset: 0x002FE254
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public SpellCoolDownVariation(GameActionFightEvent.Types.SpellCoolDownVariation other)
				{
				}

				// Token: 0x06004AFE RID: 19198 RVA: 0x00300064 File Offset: 0x002FE264
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.SpellCoolDownVariation Clone()
				{
					return null;
				}

				// Token: 0x17000D84 RID: 3460
				// (get) Token: 0x06004AFF RID: 19199 RVA: 0x00300074 File Offset: 0x002FE274
				// (set) Token: 0x06004B00 RID: 19200 RVA: 0x00300084 File Offset: 0x002FE284
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D85 RID: 3461
				// (get) Token: 0x06004B01 RID: 19201 RVA: 0x00300094 File Offset: 0x002FE294
				// (set) Token: 0x06004B02 RID: 19202 RVA: 0x003000A4 File Offset: 0x002FE2A4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
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

				// Token: 0x17000D86 RID: 3462
				// (get) Token: 0x06004B03 RID: 19203 RVA: 0x003000B4 File Offset: 0x002FE2B4
				// (set) Token: 0x06004B04 RID: 19204 RVA: 0x003000C4 File Offset: 0x002FE2C4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Value
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

				// Token: 0x06004B05 RID: 19205 RVA: 0x003000D4 File Offset: 0x002FE2D4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004B06 RID: 19206 RVA: 0x003000E4 File Offset: 0x002FE2E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.SpellCoolDownVariation other)
				{
					return true;
				}

				// Token: 0x06004B07 RID: 19207 RVA: 0x003000F4 File Offset: 0x002FE2F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004B08 RID: 19208 RVA: 0x00300104 File Offset: 0x002FE304
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004B09 RID: 19209 RVA: 0x00300114 File Offset: 0x002FE314
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004B0A RID: 19210 RVA: 0x00300124 File Offset: 0x002FE324
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004B0B RID: 19211 RVA: 0x00300134 File Offset: 0x002FE334
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004B0C RID: 19212 RVA: 0x00300144 File Offset: 0x002FE344
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.SpellCoolDownVariation other)
				{
				}

				// Token: 0x06004B0D RID: 19213 RVA: 0x00300154 File Offset: 0x002FE354
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004B0E RID: 19214 RVA: 0x00300164 File Offset: 0x002FE364
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004B0F RID: 19215 RVA: 0x00300174 File Offset: 0x002FE374
				[MethodImpl(MethodImplOptions.NoInlining)]
				static SpellCoolDownVariation()
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
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return;
						}
						GameActionFightEvent.Types.SpellCoolDownVariation._parser = new MessageParser<GameActionFightEvent.Types.SpellCoolDownVariation>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
						{
							num2 = 4;
						}
					}
				}

				// Token: 0x06004B10 RID: 19216 RVA: 0x00300258 File Offset: 0x002FE458
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool jkLnYaGijpIQAOjdGrWd()
				{
					return true;
				}

				// Token: 0x06004B11 RID: 19217 RVA: 0x00300260 File Offset: 0x002FE460
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.SpellCoolDownVariation smhNeMGiKO45im1iJBq4()
				{
					return null;
				}

				// Token: 0x04001A2C RID: 6700
				private static readonly MessageParser<GameActionFightEvent.Types.SpellCoolDownVariation> _parser;

				// Token: 0x04001A2D RID: 6701
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A2E RID: 6702
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A2F RID: 6703
				private long targetId_;

				// Token: 0x04001A30 RID: 6704
				public const int SpellIdFieldNumber = 2;

				// Token: 0x04001A31 RID: 6705
				private int spellId_;

				// Token: 0x04001A32 RID: 6706
				public const int ValueFieldNumber = 3;

				// Token: 0x04001A33 RID: 6707
				private int value_;

				// Token: 0x04001A34 RID: 6708
				internal static GameActionFightEvent.Types.SpellCoolDownVariation osjhxrGi4UKsjuusclsS;
			}

			// Token: 0x0200060D RID: 1549
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class LifePointsLost : IMessage<GameActionFightEvent.Types.LifePointsLost>, IMessage, IEquatable<GameActionFightEvent.Types.LifePointsLost>, IDeepCloneable<GameActionFightEvent.Types.LifePointsLost>, IBufferMessage
			{
				// Token: 0x17000D87 RID: 3463
				// (get) Token: 0x06004B17 RID: 19223 RVA: 0x00300268 File Offset: 0x002FE468
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public static MessageParser<GameActionFightEvent.Types.LifePointsLost> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D88 RID: 3464
				// (get) Token: 0x06004B18 RID: 19224 RVA: 0x00300278 File Offset: 0x002FE478
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

				// Token: 0x17000D89 RID: 3465
				// (get) Token: 0x06004B19 RID: 19225 RVA: 0x00300288 File Offset: 0x002FE488
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

				// Token: 0x06004B1A RID: 19226 RVA: 0x00300298 File Offset: 0x002FE498
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public LifePointsLost()
				{
				}

				// Token: 0x06004B1B RID: 19227 RVA: 0x003002A8 File Offset: 0x002FE4A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public LifePointsLost(GameActionFightEvent.Types.LifePointsLost other)
				{
				}

				// Token: 0x06004B1C RID: 19228 RVA: 0x003002B8 File Offset: 0x002FE4B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.LifePointsLost Clone()
				{
					return null;
				}

				// Token: 0x17000D8A RID: 3466
				// (get) Token: 0x06004B1D RID: 19229 RVA: 0x003002C8 File Offset: 0x002FE4C8
				// (set) Token: 0x06004B1E RID: 19230 RVA: 0x003002D8 File Offset: 0x002FE4D8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D8B RID: 3467
				// (get) Token: 0x06004B1F RID: 19231 RVA: 0x003002E8 File Offset: 0x002FE4E8
				// (set) Token: 0x06004B20 RID: 19232 RVA: 0x003002F8 File Offset: 0x002FE4F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Loss
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

				// Token: 0x17000D8C RID: 3468
				// (get) Token: 0x06004B21 RID: 19233 RVA: 0x00300308 File Offset: 0x002FE508
				// (set) Token: 0x06004B22 RID: 19234 RVA: 0x00300318 File Offset: 0x002FE518
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int PermanentDamages
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

				// Token: 0x17000D8D RID: 3469
				// (get) Token: 0x06004B23 RID: 19235 RVA: 0x00300328 File Offset: 0x002FE528
				// (set) Token: 0x06004B24 RID: 19236 RVA: 0x00300338 File Offset: 0x002FE538
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
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

				// Token: 0x17000D8E RID: 3470
				// (get) Token: 0x06004B25 RID: 19237 RVA: 0x00300348 File Offset: 0x002FE548
				// (set) Token: 0x06004B26 RID: 19238 RVA: 0x00300358 File Offset: 0x002FE558
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int ShieldLoss
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

				// Token: 0x17000D8F RID: 3471
				// (get) Token: 0x06004B27 RID: 19239 RVA: 0x00300368 File Offset: 0x002FE568
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public bool HasShieldLoss
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return true;
					}
				}

				// Token: 0x06004B28 RID: 19240 RVA: 0x00300378 File Offset: 0x002FE578
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void ClearShieldLoss()
				{
				}

				// Token: 0x06004B29 RID: 19241 RVA: 0x00300388 File Offset: 0x002FE588
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004B2A RID: 19242 RVA: 0x00300398 File Offset: 0x002FE598
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.LifePointsLost other)
				{
					return true;
				}

				// Token: 0x06004B2B RID: 19243 RVA: 0x003003A8 File Offset: 0x002FE5A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004B2C RID: 19244 RVA: 0x003003B8 File Offset: 0x002FE5B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004B2D RID: 19245 RVA: 0x003003C8 File Offset: 0x002FE5C8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004B2E RID: 19246 RVA: 0x003003D8 File Offset: 0x002FE5D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004B2F RID: 19247 RVA: 0x003003E8 File Offset: 0x002FE5E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004B30 RID: 19248 RVA: 0x003003F8 File Offset: 0x002FE5F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.LifePointsLost other)
				{
				}

				// Token: 0x06004B31 RID: 19249 RVA: 0x00300408 File Offset: 0x002FE608
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004B32 RID: 19250 RVA: 0x00300418 File Offset: 0x002FE618
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004B33 RID: 19251 RVA: 0x00300428 File Offset: 0x002FE628
				[MethodImpl(MethodImplOptions.NoInlining)]
				static LifePointsLost()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 2;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 5;
							break;
						case 1:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							return;
						case 4:
							GameActionFightEvent.Types.LifePointsLost.ShieldLossDefaultValue = 0;
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
							{
								num2 = 3;
							}
							break;
						case 5:
							GameActionFightEvent.Types.LifePointsLost._parser = new MessageParser<GameActionFightEvent.Types.LifePointsLost>(() => null);
							num2 = 4;
							break;
						}
					}
				}

				// Token: 0x06004B34 RID: 19252 RVA: 0x00300520 File Offset: 0x002FE720
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool SPWn8tGikuP0aMd1fPeb()
				{
					return true;
				}

				// Token: 0x06004B35 RID: 19253 RVA: 0x00300528 File Offset: 0x002FE728
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.LifePointsLost jEfR90GilAYjcjPls6dl()
				{
					return null;
				}

				// Token: 0x04001A37 RID: 6711
				private static readonly MessageParser<GameActionFightEvent.Types.LifePointsLost> _parser;

				// Token: 0x04001A38 RID: 6712
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A39 RID: 6713
				private int _hasBits0;

				// Token: 0x04001A3A RID: 6714
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A3B RID: 6715
				private long targetId_;

				// Token: 0x04001A3C RID: 6716
				public const int LossFieldNumber = 2;

				// Token: 0x04001A3D RID: 6717
				private int loss_;

				// Token: 0x04001A3E RID: 6718
				public const int PermanentDamagesFieldNumber = 3;

				// Token: 0x04001A3F RID: 6719
				private int permanentDamages_;

				// Token: 0x04001A40 RID: 6720
				public const int ElementIdFieldNumber = 4;

				// Token: 0x04001A41 RID: 6721
				private int elementId_;

				// Token: 0x04001A42 RID: 6722
				public const int ShieldLossFieldNumber = 5;

				// Token: 0x04001A43 RID: 6723
				private static readonly int ShieldLossDefaultValue;

				// Token: 0x04001A44 RID: 6724
				private int shieldLoss_;

				// Token: 0x04001A45 RID: 6725
				private static GameActionFightEvent.Types.LifePointsLost NNQnYcGiIZJa26tDVsLy;
			}

			// Token: 0x0200060F RID: 1551
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class LifePointsGain : IMessage<GameActionFightEvent.Types.LifePointsGain>, IMessage, IEquatable<GameActionFightEvent.Types.LifePointsGain>, IDeepCloneable<GameActionFightEvent.Types.LifePointsGain>, IBufferMessage
			{
				// Token: 0x17000D90 RID: 3472
				// (get) Token: 0x06004B3B RID: 19259 RVA: 0x00300530 File Offset: 0x002FE730
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.LifePointsGain> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D91 RID: 3473
				// (get) Token: 0x06004B3C RID: 19260 RVA: 0x00300540 File Offset: 0x002FE740
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

				// Token: 0x17000D92 RID: 3474
				// (get) Token: 0x06004B3D RID: 19261 RVA: 0x00300550 File Offset: 0x002FE750
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

				// Token: 0x06004B3E RID: 19262 RVA: 0x00300560 File Offset: 0x002FE760
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public LifePointsGain()
				{
				}

				// Token: 0x06004B3F RID: 19263 RVA: 0x00300570 File Offset: 0x002FE770
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public LifePointsGain(GameActionFightEvent.Types.LifePointsGain other)
				{
				}

				// Token: 0x06004B40 RID: 19264 RVA: 0x00300580 File Offset: 0x002FE780
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.LifePointsGain Clone()
				{
					return null;
				}

				// Token: 0x17000D93 RID: 3475
				// (get) Token: 0x06004B41 RID: 19265 RVA: 0x00300590 File Offset: 0x002FE790
				// (set) Token: 0x06004B42 RID: 19266 RVA: 0x003005A0 File Offset: 0x002FE7A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D94 RID: 3476
				// (get) Token: 0x06004B43 RID: 19267 RVA: 0x003005B0 File Offset: 0x002FE7B0
				// (set) Token: 0x06004B44 RID: 19268 RVA: 0x003005C0 File Offset: 0x002FE7C0
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

				// Token: 0x06004B45 RID: 19269 RVA: 0x003005D0 File Offset: 0x002FE7D0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004B46 RID: 19270 RVA: 0x003005E0 File Offset: 0x002FE7E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.LifePointsGain other)
				{
					return true;
				}

				// Token: 0x06004B47 RID: 19271 RVA: 0x003005F0 File Offset: 0x002FE7F0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004B48 RID: 19272 RVA: 0x00300600 File Offset: 0x002FE800
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004B49 RID: 19273 RVA: 0x00300610 File Offset: 0x002FE810
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004B4A RID: 19274 RVA: 0x00300620 File Offset: 0x002FE820
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004B4B RID: 19275 RVA: 0x00300630 File Offset: 0x002FE830
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004B4C RID: 19276 RVA: 0x00300640 File Offset: 0x002FE840
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.LifePointsGain other)
				{
				}

				// Token: 0x06004B4D RID: 19277 RVA: 0x00300650 File Offset: 0x002FE850
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004B4E RID: 19278 RVA: 0x00300660 File Offset: 0x002FE860
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004B4F RID: 19279 RVA: 0x00300670 File Offset: 0x002FE870
				[MethodImpl(MethodImplOptions.NoInlining)]
				static LifePointsGain()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 4:
							GameActionFightEvent.Types.LifePointsGain._parser = new MessageParser<GameActionFightEvent.Types.LifePointsGain>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004B50 RID: 19280 RVA: 0x00300754 File Offset: 0x002FE954
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool yuSs4AGiUSSBFSOThEwB()
				{
					return true;
				}

				// Token: 0x06004B51 RID: 19281 RVA: 0x0030075C File Offset: 0x002FE95C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.LifePointsGain rou5lsGivOXXjhQMGjDB()
				{
					return null;
				}

				// Token: 0x04001A48 RID: 6728
				private static readonly MessageParser<GameActionFightEvent.Types.LifePointsGain> _parser;

				// Token: 0x04001A49 RID: 6729
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A4A RID: 6730
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A4B RID: 6731
				private long targetId_;

				// Token: 0x04001A4C RID: 6732
				public const int DeltaFieldNumber = 2;

				// Token: 0x04001A4D RID: 6733
				private int delta_;

				// Token: 0x04001A4E RID: 6734
				internal static GameActionFightEvent.Types.LifePointsGain AsJlF3Gic1C5F5LLY1Ei;
			}

			// Token: 0x02000611 RID: 1553
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class RemovableEffect : IMessage<GameActionFightEvent.Types.RemovableEffect>, IMessage, IEquatable<GameActionFightEvent.Types.RemovableEffect>, IDeepCloneable<GameActionFightEvent.Types.RemovableEffect>, IBufferMessage
			{
				// Token: 0x17000D95 RID: 3477
				// (get) Token: 0x06004B57 RID: 19287 RVA: 0x00300764 File Offset: 0x002FE964
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.RemovableEffect> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D96 RID: 3478
				// (get) Token: 0x06004B58 RID: 19288 RVA: 0x00300774 File Offset: 0x002FE974
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

				// Token: 0x17000D97 RID: 3479
				// (get) Token: 0x06004B59 RID: 19289 RVA: 0x00300784 File Offset: 0x002FE984
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

				// Token: 0x06004B5A RID: 19290 RVA: 0x00300794 File Offset: 0x002FE994
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RemovableEffect()
				{
				}

				// Token: 0x06004B5B RID: 19291 RVA: 0x003007A4 File Offset: 0x002FE9A4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public RemovableEffect(GameActionFightEvent.Types.RemovableEffect other)
				{
				}

				// Token: 0x06004B5C RID: 19292 RVA: 0x003007B4 File Offset: 0x002FE9B4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.RemovableEffect Clone()
				{
					return null;
				}

				// Token: 0x17000D98 RID: 3480
				// (get) Token: 0x06004B5D RID: 19293 RVA: 0x003007C4 File Offset: 0x002FE9C4
				// (set) Token: 0x06004B5E RID: 19294 RVA: 0x003007D4 File Offset: 0x002FE9D4
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public FightRemovableEffect Effect
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

				// Token: 0x06004B5F RID: 19295 RVA: 0x003007E4 File Offset: 0x002FE9E4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004B60 RID: 19296 RVA: 0x003007F4 File Offset: 0x002FE9F4
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.RemovableEffect other)
				{
					return true;
				}

				// Token: 0x06004B61 RID: 19297 RVA: 0x00300804 File Offset: 0x002FEA04
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004B62 RID: 19298 RVA: 0x00300814 File Offset: 0x002FEA14
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004B63 RID: 19299 RVA: 0x00300824 File Offset: 0x002FEA24
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004B64 RID: 19300 RVA: 0x00300834 File Offset: 0x002FEA34
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004B65 RID: 19301 RVA: 0x00300844 File Offset: 0x002FEA44
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004B66 RID: 19302 RVA: 0x00300854 File Offset: 0x002FEA54
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.RemovableEffect other)
				{
				}

				// Token: 0x06004B67 RID: 19303 RVA: 0x00300864 File Offset: 0x002FEA64
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004B68 RID: 19304 RVA: 0x00300874 File Offset: 0x002FEA74
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004B69 RID: 19305 RVA: 0x00300884 File Offset: 0x002FEA84
				[MethodImpl(MethodImplOptions.NoInlining)]
				static RemovableEffect()
				{
					uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
					int num = 3;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							GameActionFightEvent.Types.RemovableEffect._parser = new MessageParser<GameActionFightEvent.Types.RemovableEffect>(() => null);
							num2 = 4;
							continue;
						case 2:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
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
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
						{
							num2 = 0;
						}
					}
				}

				// Token: 0x06004B6A RID: 19306 RVA: 0x00300950 File Offset: 0x002FEB50
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool v4uerTGi1XGfNtZedGIF()
				{
					return true;
				}

				// Token: 0x06004B6B RID: 19307 RVA: 0x00300958 File Offset: 0x002FEB58
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.RemovableEffect cF3p6AGiawprQB8RYRue()
				{
					return null;
				}

				// Token: 0x04001A51 RID: 6737
				private static readonly MessageParser<GameActionFightEvent.Types.RemovableEffect> _parser;

				// Token: 0x04001A52 RID: 6738
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A53 RID: 6739
				public const int EffectFieldNumber = 1;

				// Token: 0x04001A54 RID: 6740
				private FightRemovableEffect effect_;

				// Token: 0x04001A55 RID: 6741
				private static GameActionFightEvent.Types.RemovableEffect bQhEVEGioliTFyZgPTGo;
			}

			// Token: 0x02000613 RID: 1555
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class Slide : IMessage<GameActionFightEvent.Types.Slide>, IMessage, IEquatable<GameActionFightEvent.Types.Slide>, IDeepCloneable<GameActionFightEvent.Types.Slide>, IBufferMessage
			{
				// Token: 0x17000D99 RID: 3481
				// (get) Token: 0x06004B71 RID: 19313 RVA: 0x00300960 File Offset: 0x002FEB60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.Slide> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000D9A RID: 3482
				// (get) Token: 0x06004B72 RID: 19314 RVA: 0x00300970 File Offset: 0x002FEB70
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

				// Token: 0x17000D9B RID: 3483
				// (get) Token: 0x06004B73 RID: 19315 RVA: 0x00300980 File Offset: 0x002FEB80
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

				// Token: 0x06004B74 RID: 19316 RVA: 0x00300990 File Offset: 0x002FEB90
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Slide()
				{
				}

				// Token: 0x06004B75 RID: 19317 RVA: 0x003009A0 File Offset: 0x002FEBA0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Slide(GameActionFightEvent.Types.Slide other)
				{
				}

				// Token: 0x06004B76 RID: 19318 RVA: 0x003009B0 File Offset: 0x002FEBB0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.Slide Clone()
				{
					return null;
				}

				// Token: 0x17000D9C RID: 3484
				// (get) Token: 0x06004B77 RID: 19319 RVA: 0x003009C0 File Offset: 0x002FEBC0
				// (set) Token: 0x06004B78 RID: 19320 RVA: 0x003009D0 File Offset: 0x002FEBD0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000D9D RID: 3485
				// (get) Token: 0x06004B79 RID: 19321 RVA: 0x003009E0 File Offset: 0x002FEBE0
				// (set) Token: 0x06004B7A RID: 19322 RVA: 0x003009F0 File Offset: 0x002FEBF0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int StartCell
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

				// Token: 0x17000D9E RID: 3486
				// (get) Token: 0x06004B7B RID: 19323 RVA: 0x00300A00 File Offset: 0x002FEC00
				// (set) Token: 0x06004B7C RID: 19324 RVA: 0x00300A10 File Offset: 0x002FEC10
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int EndCell
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

				// Token: 0x06004B7D RID: 19325 RVA: 0x00300A20 File Offset: 0x002FEC20
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004B7E RID: 19326 RVA: 0x00300A30 File Offset: 0x002FEC30
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.Slide other)
				{
					return true;
				}

				// Token: 0x06004B7F RID: 19327 RVA: 0x00300A40 File Offset: 0x002FEC40
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004B80 RID: 19328 RVA: 0x00300A50 File Offset: 0x002FEC50
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004B81 RID: 19329 RVA: 0x00300A60 File Offset: 0x002FEC60
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004B82 RID: 19330 RVA: 0x00300A70 File Offset: 0x002FEC70
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004B83 RID: 19331 RVA: 0x00300A80 File Offset: 0x002FEC80
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004B84 RID: 19332 RVA: 0x00300A90 File Offset: 0x002FEC90
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.Slide other)
				{
				}

				// Token: 0x06004B85 RID: 19333 RVA: 0x00300AA0 File Offset: 0x002FECA0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004B86 RID: 19334 RVA: 0x00300AB0 File Offset: 0x002FECB0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004B87 RID: 19335 RVA: 0x00300AC0 File Offset: 0x002FECC0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static Slide()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
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
							GameActionFightEvent.Types.Slide._parser = new MessageParser<GameActionFightEvent.Types.Slide>(() => null);
							num2 = 3;
							continue;
						}
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
						{
							num2 = 2;
						}
					}
				}

				// Token: 0x06004B88 RID: 19336 RVA: 0x00300B8C File Offset: 0x002FED8C
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool D5JWhTGiye5sA8493GVH()
				{
					return true;
				}

				// Token: 0x06004B89 RID: 19337 RVA: 0x00300B94 File Offset: 0x002FED94
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.Slide cau4wmGi6vV2s4GyJFTv()
				{
					return null;
				}

				// Token: 0x04001A58 RID: 6744
				private static readonly MessageParser<GameActionFightEvent.Types.Slide> _parser;

				// Token: 0x04001A59 RID: 6745
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A5A RID: 6746
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A5B RID: 6747
				private long targetId_;

				// Token: 0x04001A5C RID: 6748
				public const int StartCellFieldNumber = 2;

				// Token: 0x04001A5D RID: 6749
				private int startCell_;

				// Token: 0x04001A5E RID: 6750
				public const int EndCellFieldNumber = 3;

				// Token: 0x04001A5F RID: 6751
				private int endCell_;

				// Token: 0x04001A60 RID: 6752
				private static GameActionFightEvent.Types.Slide fLWsadGi5MuAFjTAkblR;
			}

			// Token: 0x02000615 RID: 1557
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class DodgePointLoss : IMessage<GameActionFightEvent.Types.DodgePointLoss>, IMessage, IEquatable<GameActionFightEvent.Types.DodgePointLoss>, IDeepCloneable<GameActionFightEvent.Types.DodgePointLoss>, IBufferMessage
			{
				// Token: 0x17000D9F RID: 3487
				// (get) Token: 0x06004B8F RID: 19343 RVA: 0x00300B9C File Offset: 0x002FED9C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.DodgePointLoss> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DA0 RID: 3488
				// (get) Token: 0x06004B90 RID: 19344 RVA: 0x00300BAC File Offset: 0x002FEDAC
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

				// Token: 0x17000DA1 RID: 3489
				// (get) Token: 0x06004B91 RID: 19345 RVA: 0x00300BBC File Offset: 0x002FEDBC
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

				// Token: 0x06004B92 RID: 19346 RVA: 0x00300BCC File Offset: 0x002FEDCC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DodgePointLoss()
				{
				}

				// Token: 0x06004B93 RID: 19347 RVA: 0x00300BDC File Offset: 0x002FEDDC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public DodgePointLoss(GameActionFightEvent.Types.DodgePointLoss other)
				{
				}

				// Token: 0x06004B94 RID: 19348 RVA: 0x00300BEC File Offset: 0x002FEDEC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.DodgePointLoss Clone()
				{
					return null;
				}

				// Token: 0x17000DA2 RID: 3490
				// (get) Token: 0x06004B95 RID: 19349 RVA: 0x00300BFC File Offset: 0x002FEDFC
				// (set) Token: 0x06004B96 RID: 19350 RVA: 0x00300C0C File Offset: 0x002FEE0C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000DA3 RID: 3491
				// (get) Token: 0x06004B97 RID: 19351 RVA: 0x00300C1C File Offset: 0x002FEE1C
				// (set) Token: 0x06004B98 RID: 19352 RVA: 0x00300C2C File Offset: 0x002FEE2C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public int Amount
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

				// Token: 0x06004B99 RID: 19353 RVA: 0x00300C3C File Offset: 0x002FEE3C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004B9A RID: 19354 RVA: 0x00300C4C File Offset: 0x002FEE4C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.DodgePointLoss other)
				{
					return true;
				}

				// Token: 0x06004B9B RID: 19355 RVA: 0x00300C5C File Offset: 0x002FEE5C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004B9C RID: 19356 RVA: 0x00300C6C File Offset: 0x002FEE6C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004B9D RID: 19357 RVA: 0x00300C7C File Offset: 0x002FEE7C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004B9E RID: 19358 RVA: 0x00300C8C File Offset: 0x002FEE8C
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004B9F RID: 19359 RVA: 0x00300C9C File Offset: 0x002FEE9C
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004BA0 RID: 19360 RVA: 0x00300CAC File Offset: 0x002FEEAC
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.DodgePointLoss other)
				{
				}

				// Token: 0x06004BA1 RID: 19361 RVA: 0x00300CBC File Offset: 0x002FEEBC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004BA2 RID: 19362 RVA: 0x00300CCC File Offset: 0x002FEECC
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004BA3 RID: 19363 RVA: 0x00300CDC File Offset: 0x002FEEDC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static DodgePointLoss()
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
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 2:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 4;
							continue;
						case 4:
							GameActionFightEvent.Types.DodgePointLoss._parser = new MessageParser<GameActionFightEvent.Types.DodgePointLoss>(() => null);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}

				// Token: 0x06004BA4 RID: 19364 RVA: 0x00300DC0 File Offset: 0x002FEFC0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool AI1S2gGiWk5qlsi0GmeR()
				{
					return true;
				}

				// Token: 0x06004BA5 RID: 19365 RVA: 0x00300DC8 File Offset: 0x002FEFC8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.DodgePointLoss tVnqNFGihsomWPvc4gAr()
				{
					return null;
				}

				// Token: 0x04001A63 RID: 6755
				private static readonly MessageParser<GameActionFightEvent.Types.DodgePointLoss> _parser;

				// Token: 0x04001A64 RID: 6756
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A65 RID: 6757
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A66 RID: 6758
				private long targetId_;

				// Token: 0x04001A67 RID: 6759
				public const int AmountFieldNumber = 2;

				// Token: 0x04001A68 RID: 6760
				private int amount_;

				// Token: 0x04001A69 RID: 6761
				internal static GameActionFightEvent.Types.DodgePointLoss zSdk8oGiLNPIepoXYdlh;
			}

			// Token: 0x02000617 RID: 1559
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ReflectDamages : IMessage<GameActionFightEvent.Types.ReflectDamages>, IMessage, IEquatable<GameActionFightEvent.Types.ReflectDamages>, IDeepCloneable<GameActionFightEvent.Types.ReflectDamages>, IBufferMessage
			{
				// Token: 0x17000DA4 RID: 3492
				// (get) Token: 0x06004BAB RID: 19371 RVA: 0x00300DD0 File Offset: 0x002FEFD0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.ReflectDamages> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DA5 RID: 3493
				// (get) Token: 0x06004BAC RID: 19372 RVA: 0x00300DE0 File Offset: 0x002FEFE0
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

				// Token: 0x17000DA6 RID: 3494
				// (get) Token: 0x06004BAD RID: 19373 RVA: 0x00300DF0 File Offset: 0x002FEFF0
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

				// Token: 0x06004BAE RID: 19374 RVA: 0x00300E00 File Offset: 0x002FF000
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ReflectDamages()
				{
				}

				// Token: 0x06004BAF RID: 19375 RVA: 0x00300E10 File Offset: 0x002FF010
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ReflectDamages(GameActionFightEvent.Types.ReflectDamages other)
				{
				}

				// Token: 0x06004BB0 RID: 19376 RVA: 0x00300E20 File Offset: 0x002FF020
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ReflectDamages Clone()
				{
					return null;
				}

				// Token: 0x17000DA7 RID: 3495
				// (get) Token: 0x06004BB1 RID: 19377 RVA: 0x00300E30 File Offset: 0x002FF030
				// (set) Token: 0x06004BB2 RID: 19378 RVA: 0x00300E40 File Offset: 0x002FF040
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

				// Token: 0x06004BB3 RID: 19379 RVA: 0x00300E50 File Offset: 0x002FF050
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004BB4 RID: 19380 RVA: 0x00300E60 File Offset: 0x002FF060
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ReflectDamages other)
				{
					return true;
				}

				// Token: 0x06004BB5 RID: 19381 RVA: 0x00300E70 File Offset: 0x002FF070
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004BB6 RID: 19382 RVA: 0x00300E80 File Offset: 0x002FF080
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004BB7 RID: 19383 RVA: 0x00300E90 File Offset: 0x002FF090
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004BB8 RID: 19384 RVA: 0x00300EA0 File Offset: 0x002FF0A0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004BB9 RID: 19385 RVA: 0x00300EB0 File Offset: 0x002FF0B0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004BBA RID: 19386 RVA: 0x00300EC0 File Offset: 0x002FF0C0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ReflectDamages other)
				{
				}

				// Token: 0x06004BBB RID: 19387 RVA: 0x00300ED0 File Offset: 0x002FF0D0
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004BBC RID: 19388 RVA: 0x00300EE0 File Offset: 0x002FF0E0
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004BBD RID: 19389 RVA: 0x00300EF0 File Offset: 0x002FF0F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ReflectDamages()
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
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 0;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 2;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
							num2 = 1;
							if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						GameActionFightEvent.Types.ReflectDamages._parser = new MessageParser<GameActionFightEvent.Types.ReflectDamages>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
						{
							num2 = 1;
						}
					}
				}

				// Token: 0x06004BBE RID: 19390 RVA: 0x00300FE8 File Offset: 0x002FF1E8
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool zDXJVPGiViScwa3SNBNY()
				{
					return true;
				}

				// Token: 0x06004BBF RID: 19391 RVA: 0x00300FF0 File Offset: 0x002FF1F0
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ReflectDamages EPE0GbGi04TsutvhTH6n()
				{
					return null;
				}

				// Token: 0x04001A6C RID: 6764
				private static readonly MessageParser<GameActionFightEvent.Types.ReflectDamages> _parser;

				// Token: 0x04001A6D RID: 6765
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A6E RID: 6766
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A6F RID: 6767
				private long targetId_;

				// Token: 0x04001A70 RID: 6768
				internal static GameActionFightEvent.Types.ReflectDamages A3b3bCGirrSAsB36x8Cx;
			}

			// Token: 0x02000619 RID: 1561
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ReduceDamages : IMessage<GameActionFightEvent.Types.ReduceDamages>, IMessage, IEquatable<GameActionFightEvent.Types.ReduceDamages>, IDeepCloneable<GameActionFightEvent.Types.ReduceDamages>, IBufferMessage
			{
				// Token: 0x17000DA8 RID: 3496
				// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x00300FF8 File Offset: 0x002FF1F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.ReduceDamages> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DA9 RID: 3497
				// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x00301008 File Offset: 0x002FF208
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

				// Token: 0x17000DAA RID: 3498
				// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x00301018 File Offset: 0x002FF218
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

				// Token: 0x06004BC8 RID: 19400 RVA: 0x00301028 File Offset: 0x002FF228
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ReduceDamages()
				{
				}

				// Token: 0x06004BC9 RID: 19401 RVA: 0x00301038 File Offset: 0x002FF238
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ReduceDamages(GameActionFightEvent.Types.ReduceDamages other)
				{
				}

				// Token: 0x06004BCA RID: 19402 RVA: 0x00301048 File Offset: 0x002FF248
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ReduceDamages Clone()
				{
					return null;
				}

				// Token: 0x17000DAB RID: 3499
				// (get) Token: 0x06004BCB RID: 19403 RVA: 0x00301058 File Offset: 0x002FF258
				// (set) Token: 0x06004BCC RID: 19404 RVA: 0x00301068 File Offset: 0x002FF268
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
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

				// Token: 0x17000DAC RID: 3500
				// (get) Token: 0x06004BCD RID: 19405 RVA: 0x00301078 File Offset: 0x002FF278
				// (set) Token: 0x06004BCE RID: 19406 RVA: 0x00301088 File Offset: 0x002FF288
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				public int Amount
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

				// Token: 0x06004BCF RID: 19407 RVA: 0x00301098 File Offset: 0x002FF298
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004BD0 RID: 19408 RVA: 0x003010A8 File Offset: 0x002FF2A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ReduceDamages other)
				{
					return true;
				}

				// Token: 0x06004BD1 RID: 19409 RVA: 0x003010B8 File Offset: 0x002FF2B8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004BD2 RID: 19410 RVA: 0x003010C8 File Offset: 0x002FF2C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004BD3 RID: 19411 RVA: 0x003010D8 File Offset: 0x002FF2D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004BD4 RID: 19412 RVA: 0x003010E8 File Offset: 0x002FF2E8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004BD5 RID: 19413 RVA: 0x003010F8 File Offset: 0x002FF2F8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004BD6 RID: 19414 RVA: 0x00301108 File Offset: 0x002FF308
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ReduceDamages other)
				{
				}

				// Token: 0x06004BD7 RID: 19415 RVA: 0x00301118 File Offset: 0x002FF318
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004BD8 RID: 19416 RVA: 0x00301128 File Offset: 0x002FF328
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004BD9 RID: 19417 RVA: 0x00301138 File Offset: 0x002FF338
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ReduceDamages()
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
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 2:
								return;
							case 3:
								GameActionFightEvent.Types.ReduceDamages._parser = new MessageParser<GameActionFightEvent.Types.ReduceDamages>(() => null);
								num2 = 2;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								goto IL_98;
							}
							AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
							num2 = 4;
						}
						IL_98:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num = 3;
					}
				}

				// Token: 0x06004BDA RID: 19418 RVA: 0x00301208 File Offset: 0x002FF408
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool CEt5YyGiDQD3IiEE8uC8()
				{
					return true;
				}

				// Token: 0x06004BDB RID: 19419 RVA: 0x00301210 File Offset: 0x002FF410
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ReduceDamages ksRVt5Git5XdpbtKFFSi()
				{
					return null;
				}

				// Token: 0x04001A73 RID: 6771
				private static readonly MessageParser<GameActionFightEvent.Types.ReduceDamages> _parser;

				// Token: 0x04001A74 RID: 6772
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A75 RID: 6773
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A76 RID: 6774
				private long targetId_;

				// Token: 0x04001A77 RID: 6775
				public const int AmountFieldNumber = 2;

				// Token: 0x04001A78 RID: 6776
				private int amount_;

				// Token: 0x04001A79 RID: 6777
				private static GameActionFightEvent.Types.ReduceDamages Nw7E2SGiCmdrkwZZTRFH;
			}

			// Token: 0x0200061B RID: 1563
			[DebuggerDisplay("{ToString(),nq}")]
			public sealed class ReflectSpell : IMessage<GameActionFightEvent.Types.ReflectSpell>, IMessage, IEquatable<GameActionFightEvent.Types.ReflectSpell>, IDeepCloneable<GameActionFightEvent.Types.ReflectSpell>, IBufferMessage
			{
				// Token: 0x17000DAD RID: 3501
				// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x00301218 File Offset: 0x002FF418
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				public static MessageParser<GameActionFightEvent.Types.ReflectSpell> Parser
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						return null;
					}
				}

				// Token: 0x17000DAE RID: 3502
				// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x00301228 File Offset: 0x002FF428
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

				// Token: 0x17000DAF RID: 3503
				// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x00301238 File Offset: 0x002FF438
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

				// Token: 0x06004BE4 RID: 19428 RVA: 0x00301248 File Offset: 0x002FF448
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ReflectSpell()
				{
				}

				// Token: 0x06004BE5 RID: 19429 RVA: 0x00301258 File Offset: 0x002FF458
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ReflectSpell(GameActionFightEvent.Types.ReflectSpell other)
				{
				}

				// Token: 0x06004BE6 RID: 19430 RVA: 0x00301268 File Offset: 0x002FF468
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public GameActionFightEvent.Types.ReflectSpell Clone()
				{
					return null;
				}

				// Token: 0x17000DB0 RID: 3504
				// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x00301278 File Offset: 0x002FF478
				// (set) Token: 0x06004BE8 RID: 19432 RVA: 0x00301288 File Offset: 0x002FF488
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

				// Token: 0x06004BE9 RID: 19433 RVA: 0x00301298 File Offset: 0x002FF498
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override bool Equals(object other)
				{
					return true;
				}

				// Token: 0x06004BEA RID: 19434 RVA: 0x003012A8 File Offset: 0x002FF4A8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool Equals(GameActionFightEvent.Types.ReflectSpell other)
				{
					return true;
				}

				// Token: 0x06004BEB RID: 19435 RVA: 0x003012B8 File Offset: 0x002FF4B8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override int GetHashCode()
				{
					return 0;
				}

				// Token: 0x06004BEC RID: 19436 RVA: 0x003012C8 File Offset: 0x002FF4C8
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x06004BED RID: 19437 RVA: 0x003012D8 File Offset: 0x002FF4D8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void WriteTo(CodedOutputStream output)
				{
				}

				// Token: 0x06004BEE RID: 19438 RVA: 0x003012E8 File Offset: 0x002FF4E8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
				}

				// Token: 0x06004BEF RID: 19439 RVA: 0x003012F8 File Offset: 0x002FF4F8
				[DebuggerNonUserCode]
				[GeneratedCode("protoc", null)]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public int CalculateSize()
				{
					return 0;
				}

				// Token: 0x06004BF0 RID: 19440 RVA: 0x00301308 File Offset: 0x002FF508
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(GameActionFightEvent.Types.ReflectSpell other)
				{
				}

				// Token: 0x06004BF1 RID: 19441 RVA: 0x00301318 File Offset: 0x002FF518
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void MergeFrom(CodedInputStream input)
				{
				}

				// Token: 0x06004BF2 RID: 19442 RVA: 0x00301328 File Offset: 0x002FF528
				[GeneratedCode("protoc", null)]
				[DebuggerNonUserCode]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
				}

				// Token: 0x06004BF3 RID: 19443 RVA: 0x00301338 File Offset: 0x002FF538
				[MethodImpl(MethodImplOptions.NoInlining)]
				static ReflectSpell()
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
							case 1:
								return;
							case 2:
								GameActionFightEvent.Types.ReflectSpell._parser = new MessageParser<GameActionFightEvent.Types.ReflectSpell>(() => null);
								num2 = 1;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							case 3:
								AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
								num2 = 0;
								if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							case 4:
								goto IL_35;
							}
							UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
							num2 = 2;
						}
						IL_35:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num = 3;
					}
				}

				// Token: 0x06004BF4 RID: 19444 RVA: 0x00301408 File Offset: 0x002FF608
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static bool gpCtj8GiQtqDrbjYGCMi()
				{
					return true;
				}

				// Token: 0x06004BF5 RID: 19445 RVA: 0x00301410 File Offset: 0x002FF610
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static GameActionFightEvent.Types.ReflectSpell RsTjGVGi7pBEABby6dhV()
				{
					return null;
				}

				// Token: 0x04001A7C RID: 6780
				private static readonly MessageParser<GameActionFightEvent.Types.ReflectSpell> _parser;

				// Token: 0x04001A7D RID: 6781
				private UnknownFieldSet _unknownFields;

				// Token: 0x04001A7E RID: 6782
				public const int TargetIdFieldNumber = 1;

				// Token: 0x04001A7F RID: 6783
				private long targetId_;

				// Token: 0x04001A80 RID: 6784
				private static GameActionFightEvent.Types.ReflectSpell q1BweoGiwbVfBIten6Kh;
			}
		}
	}
}
