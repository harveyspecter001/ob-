using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B2C RID: 2860
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Shortcut : IMessage<Shortcut>, IMessage, IEquatable<Shortcut>, IDeepCloneable<Shortcut>, IBufferMessage
	{
		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060088C2 RID: 35010 RVA: 0x002664A8 File Offset: 0x002646A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Shortcut> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x002664B8 File Offset: 0x002646B8
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

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060088C4 RID: 35012 RVA: 0x002664C8 File Offset: 0x002646C8
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

		// Token: 0x060088C5 RID: 35013 RVA: 0x002664D8 File Offset: 0x002646D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Shortcut()
		{
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x002664E8 File Offset: 0x002646E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Shortcut(Shortcut other)
		{
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x002664F8 File Offset: 0x002646F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Shortcut Clone()
		{
			return null;
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060088C8 RID: 35016 RVA: 0x00266508 File Offset: 0x00264708
		// (set) Token: 0x060088C9 RID: 35017 RVA: 0x00266518 File Offset: 0x00264718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
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

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060088CA RID: 35018 RVA: 0x00266528 File Offset: 0x00264728
		// (set) Token: 0x060088CB RID: 35019 RVA: 0x00266538 File Offset: 0x00264738
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ShortcutObjectItem ShortcutObjectItem
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

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060088CC RID: 35020 RVA: 0x00266548 File Offset: 0x00264748
		// (set) Token: 0x060088CD RID: 35021 RVA: 0x00266558 File Offset: 0x00264758
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ShortcutPreset ShortcutPreset
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

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060088CE RID: 35022 RVA: 0x00266568 File Offset: 0x00264768
		// (set) Token: 0x060088CF RID: 35023 RVA: 0x00266578 File Offset: 0x00264778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortcutSpell ShortcutSpell
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

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060088D0 RID: 35024 RVA: 0x00266588 File Offset: 0x00264788
		// (set) Token: 0x060088D1 RID: 35025 RVA: 0x00266598 File Offset: 0x00264798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ShortcutSmiley ShortcutSmiley
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

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060088D2 RID: 35026 RVA: 0x002665A8 File Offset: 0x002647A8
		// (set) Token: 0x060088D3 RID: 35027 RVA: 0x002665B8 File Offset: 0x002647B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ShortcutEmote ShortcutEmote
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

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060088D4 RID: 35028 RVA: 0x002665C8 File Offset: 0x002647C8
		// (set) Token: 0x060088D5 RID: 35029 RVA: 0x002665D8 File Offset: 0x002647D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ShortcutCosmeticObject ShortcutCosmeticObject
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

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060088D6 RID: 35030 RVA: 0x002665E8 File Offset: 0x002647E8
		// (set) Token: 0x060088D7 RID: 35031 RVA: 0x002665F8 File Offset: 0x002647F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortcutOutfit ShortcutOutfit
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

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060088D8 RID: 35032 RVA: 0x00266608 File Offset: 0x00264808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Shortcut.ShortcutOneofCase ShortcutCase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Shortcut.ShortcutOneofCase)null;
			}
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x0026661C File Offset: 0x0026481C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearShortcut()
		{
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x0026662C File Offset: 0x0026482C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x0026663C File Offset: 0x0026483C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Shortcut other)
		{
			return true;
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x0026664C File Offset: 0x0026484C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x0026665C File Offset: 0x0026485C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x0026666C File Offset: 0x0026486C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x0026667C File Offset: 0x0026487C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x0026668C File Offset: 0x0026488C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x0026669C File Offset: 0x0026489C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Shortcut other)
		{
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x002666AC File Offset: 0x002648AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x002666BC File Offset: 0x002648BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x002666CC File Offset: 0x002648CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Shortcut()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Shortcut._parser = new MessageParser<Shortcut>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 1;
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

		// Token: 0x060088E5 RID: 35045 RVA: 0x00266798 File Offset: 0x00264998
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KR6a0OJdGmrvNj0s8C0I()
		{
			return true;
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x002667A0 File Offset: 0x002649A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Shortcut x3TDS2JdgMiSTS4pHRNM()
		{
			return null;
		}

		// Token: 0x04003260 RID: 12896
		private static readonly MessageParser<Shortcut> _parser;

		// Token: 0x04003261 RID: 12897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003262 RID: 12898
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04003263 RID: 12899
		private int slotId_;

		// Token: 0x04003264 RID: 12900
		public const int ShortcutObjectItemFieldNumber = 2;

		// Token: 0x04003265 RID: 12901
		public const int ShortcutPresetFieldNumber = 3;

		// Token: 0x04003266 RID: 12902
		public const int ShortcutSpellFieldNumber = 4;

		// Token: 0x04003267 RID: 12903
		public const int ShortcutSmileyFieldNumber = 5;

		// Token: 0x04003268 RID: 12904
		public const int ShortcutEmoteFieldNumber = 6;

		// Token: 0x04003269 RID: 12905
		public const int ShortcutCosmeticObjectFieldNumber = 7;

		// Token: 0x0400326A RID: 12906
		public const int ShortcutOutfitFieldNumber = 8;

		// Token: 0x0400326B RID: 12907
		private object shortcut_;

		// Token: 0x0400326C RID: 12908
		private Shortcut.ShortcutOneofCase shortcutCase_;

		// Token: 0x0400326D RID: 12909
		internal static Shortcut qC1QY2JdJnKqFoT9o2bN;

		// Token: 0x02000B2D RID: 2861
		public enum ShortcutOneofCase
		{
			// Token: 0x0400326F RID: 12911
			None,
			// Token: 0x04003270 RID: 12912
			ShortcutObjectItem = 2,
			// Token: 0x04003271 RID: 12913
			ShortcutPreset,
			// Token: 0x04003272 RID: 12914
			ShortcutSpell,
			// Token: 0x04003273 RID: 12915
			ShortcutSmiley,
			// Token: 0x04003274 RID: 12916
			ShortcutEmote,
			// Token: 0x04003275 RID: 12917
			ShortcutCosmeticObject,
			// Token: 0x04003276 RID: 12918
			ShortcutOutfit
		}
	}
}
