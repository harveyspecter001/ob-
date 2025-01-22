using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight
{
	// Token: 0x0200067C RID: 1660
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightSlaveSwitchContextEvent : IMessage<FightSlaveSwitchContextEvent>, IMessage, IEquatable<FightSlaveSwitchContextEvent>, IDeepCloneable<FightSlaveSwitchContextEvent>, IBufferMessage
	{
		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x00205448 File Offset: 0x00203648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightSlaveSwitchContextEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x00205458 File Offset: 0x00203658
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

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x00205468 File Offset: 0x00203668
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

		// Token: 0x060050E9 RID: 20713 RVA: 0x00205478 File Offset: 0x00203678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSlaveSwitchContextEvent()
		{
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00205488 File Offset: 0x00203688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSlaveSwitchContextEvent(FightSlaveSwitchContextEvent other)
		{
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00205498 File Offset: 0x00203698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightSlaveSwitchContextEvent Clone()
		{
			return null;
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x002054A8 File Offset: 0x002036A8
		// (set) Token: 0x060050ED RID: 20717 RVA: 0x002054B8 File Offset: 0x002036B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MasterId
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

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x002054C8 File Offset: 0x002036C8
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x002054D8 File Offset: 0x002036D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SlaveId
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

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x002054E8 File Offset: 0x002036E8
		// (set) Token: 0x060050F1 RID: 20721 RVA: 0x002054F8 File Offset: 0x002036F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlaveTurn
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

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060050F2 RID: 20722 RVA: 0x00205508 File Offset: 0x00203708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpellItem> SlaveSpells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060050F3 RID: 20723 RVA: 0x00205518 File Offset: 0x00203718
		// (set) Token: 0x060050F4 RID: 20724 RVA: 0x00205528 File Offset: 0x00203728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterCharacteristics SlaveStats
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

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060050F5 RID: 20725 RVA: 0x00205538 File Offset: 0x00203738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<Shortcut> Shortcuts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00205548 File Offset: 0x00203748
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00205558 File Offset: 0x00203758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightSlaveSwitchContextEvent other)
		{
			return true;
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x00205568 File Offset: 0x00203768
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00205578 File Offset: 0x00203778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00205588 File Offset: 0x00203788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x00205598 File Offset: 0x00203798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x002055A8 File Offset: 0x002037A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x002055B8 File Offset: 0x002037B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightSlaveSwitchContextEvent other)
		{
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x002055C8 File Offset: 0x002037C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x002055D8 File Offset: 0x002037D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x002055E8 File Offset: 0x002037E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightSlaveSwitchContextEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					FightSlaveSwitchContextEvent._repeated_shortcuts_codec = FieldCodec.ForMessage<Shortcut>(50U, iW01yrnF9K4S4GUbqCXR.XVInXhlssT(iW01yrnF9K4S4GUbqCXR.S3AnF2miOx2));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					FightSlaveSwitchContextEvent._parser = new MessageParser<FightSlaveSwitchContextEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				case 6:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				FightSlaveSwitchContextEvent._repeated_slaveSpells_codec = FieldCodec.ForMessage<SpellItem>(34U, mxnHJZAmEfIaKxR2xwlg.XVInXhlssT(mxnHJZAmEfIaKxR2xwlg.hfmAmXrMZpw));
				num2 = 2;
			}
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x00205728 File Offset: 0x00203928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LLJeriOPfRoTqaVNcw0p()
		{
			return true;
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00205730 File Offset: 0x00203930
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightSlaveSwitchContextEvent jdjc9OOPnniga9gLkqZO()
		{
			return null;
		}

		// Token: 0x04001C6D RID: 7277
		private static readonly MessageParser<FightSlaveSwitchContextEvent> _parser;

		// Token: 0x04001C6E RID: 7278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C6F RID: 7279
		public const int MasterIdFieldNumber = 1;

		// Token: 0x04001C70 RID: 7280
		private long masterId_;

		// Token: 0x04001C71 RID: 7281
		public const int SlaveIdFieldNumber = 2;

		// Token: 0x04001C72 RID: 7282
		private long slaveId_;

		// Token: 0x04001C73 RID: 7283
		public const int SlaveTurnFieldNumber = 3;

		// Token: 0x04001C74 RID: 7284
		private int slaveTurn_;

		// Token: 0x04001C75 RID: 7285
		public const int SlaveSpellsFieldNumber = 4;

		// Token: 0x04001C76 RID: 7286
		private static readonly FieldCodec<SpellItem> _repeated_slaveSpells_codec;

		// Token: 0x04001C77 RID: 7287
		private readonly RepeatedField<SpellItem> slaveSpells_;

		// Token: 0x04001C78 RID: 7288
		public const int SlaveStatsFieldNumber = 5;

		// Token: 0x04001C79 RID: 7289
		private CharacterCharacteristics slaveStats_;

		// Token: 0x04001C7A RID: 7290
		public const int ShortcutsFieldNumber = 6;

		// Token: 0x04001C7B RID: 7291
		private static readonly FieldCodec<Shortcut> _repeated_shortcuts_codec;

		// Token: 0x04001C7C RID: 7292
		private readonly RepeatedField<Shortcut> shortcuts_;

		// Token: 0x04001C7D RID: 7293
		private static FightSlaveSwitchContextEvent TjmMFcOize83ILcaJGwZ;
	}
}
