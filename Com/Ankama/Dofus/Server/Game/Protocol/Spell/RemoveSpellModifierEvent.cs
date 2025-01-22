using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x0200011C RID: 284
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveSpellModifierEvent : IMessage<RemoveSpellModifierEvent>, IMessage, IEquatable<RemoveSpellModifierEvent>, IDeepCloneable<RemoveSpellModifierEvent>, IBufferMessage
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00198AB4 File Offset: 0x00196CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveSpellModifierEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00198AC4 File Offset: 0x00196CC4
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00198AD4 File Offset: 0x00196CD4
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

		// Token: 0x06000CEC RID: 3308 RVA: 0x00198AE4 File Offset: 0x00196CE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveSpellModifierEvent()
		{
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00198AF4 File Offset: 0x00196CF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveSpellModifierEvent(RemoveSpellModifierEvent other)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00198B04 File Offset: 0x00196D04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RemoveSpellModifierEvent Clone()
		{
			return null;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00198B14 File Offset: 0x00196D14
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00198B24 File Offset: 0x00196D24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ActorId
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00198B34 File Offset: 0x00196D34
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00198B48 File Offset: 0x00196D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpellModifierActionType ActionType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SpellModifierActionType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00198B58 File Offset: 0x00196D58
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00198B6C File Offset: 0x00196D6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SpellModifierType ModifierType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SpellModifierType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00198B7C File Offset: 0x00196D7C
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00198B8C File Offset: 0x00196D8C
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

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00198B9C File Offset: 0x00196D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00198BAC File Offset: 0x00196DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(RemoveSpellModifierEvent other)
		{
			return true;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00198BBC File Offset: 0x00196DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00198BCC File Offset: 0x00196DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00198BDC File Offset: 0x00196DDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00198BEC File Offset: 0x00196DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00198BFC File Offset: 0x00196DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00198C0C File Offset: 0x00196E0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(RemoveSpellModifierEvent other)
		{
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00198C1C File Offset: 0x00196E1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00198C2C File Offset: 0x00196E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00198C3C File Offset: 0x00196E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RemoveSpellModifierEvent()
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
					RemoveSpellModifierEvent._parser = new MessageParser<RemoveSpellModifierEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd != 0)
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

		// Token: 0x06000D02 RID: 3330 RVA: 0x00198D08 File Offset: 0x00196F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mZU56SOcktGgbm3nRS4E()
		{
			return true;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00198D10 File Offset: 0x00196F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static RemoveSpellModifierEvent n0fZKhOclaWBtu5yZaNB()
		{
			return null;
		}

		// Token: 0x040004AE RID: 1198
		private static readonly MessageParser<RemoveSpellModifierEvent> _parser;

		// Token: 0x040004AF RID: 1199
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004B0 RID: 1200
		public const int ActorIdFieldNumber = 1;

		// Token: 0x040004B1 RID: 1201
		private long actorId_;

		// Token: 0x040004B2 RID: 1202
		public const int ActionTypeFieldNumber = 2;

		// Token: 0x040004B3 RID: 1203
		private SpellModifierActionType actionType_;

		// Token: 0x040004B4 RID: 1204
		public const int ModifierTypeFieldNumber = 3;

		// Token: 0x040004B5 RID: 1205
		private SpellModifierType modifierType_;

		// Token: 0x040004B6 RID: 1206
		public const int SpellIdFieldNumber = 4;

		// Token: 0x040004B7 RID: 1207
		private int spellId_;

		// Token: 0x040004B8 RID: 1208
		private static RemoveSpellModifierEvent DuT5XWOcIKY4owNTjvBp;
	}
}
