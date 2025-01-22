using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x0200012A RID: 298
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellsEvent : IMessage<SpellsEvent>, IMessage, IEquatable<SpellsEvent>, IDeepCloneable<SpellsEvent>, IBufferMessage
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x001995B4 File Offset: 0x001977B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpellsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x001995C4 File Offset: 0x001977C4
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

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x001995D4 File Offset: 0x001977D4
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

		// Token: 0x06000D7A RID: 3450 RVA: 0x001995E4 File Offset: 0x001977E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellsEvent()
		{
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x001995F4 File Offset: 0x001977F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellsEvent(SpellsEvent other)
		{
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00199604 File Offset: 0x00197804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellsEvent Clone()
		{
			return null;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00199614 File Offset: 0x00197814
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00199624 File Offset: 0x00197824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SpellVisualisation
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

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00199634 File Offset: 0x00197834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SpellItem> HumanSpells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00199644 File Offset: 0x00197844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<SpellItem> MutantSpells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00199654 File Offset: 0x00197854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00199664 File Offset: 0x00197864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellsEvent other)
		{
			return true;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00199674 File Offset: 0x00197874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00199684 File Offset: 0x00197884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00199694 File Offset: 0x00197894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x001996A4 File Offset: 0x001978A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x001996B4 File Offset: 0x001978B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x001996C4 File Offset: 0x001978C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellsEvent other)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x001996D4 File Offset: 0x001978D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x001996E4 File Offset: 0x001978E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x001996F4 File Offset: 0x001978F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					SpellsEvent._parser = new MessageParser<SpellsEvent>(() => null);
					num2 = 6;
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					SpellsEvent._repeated_mutantSpells_codec = FieldCodec.ForMessage<SpellItem>(26U, rnJsxILsIw0B91mWIKF.XVInXhlssT(rnJsxILsIw0B91mWIKF.QiaLdxZkEv));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
					SpellsEvent._repeated_humanSpells_codec = FieldCodec.ForMessage<SpellItem>(18U, rnJsxILsIw0B91mWIKF.XVInXhlssT(rnJsxILsIw0B91mWIKF.QiaLdxZkEv));
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00199848 File Offset: 0x00197A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cef8GgOcVAcxR0mIPskm()
		{
			return true;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00199850 File Offset: 0x00197A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellsEvent rZ5bpKOc0hir9bXKGqjL()
		{
			return null;
		}

		// Token: 0x040004E8 RID: 1256
		private static readonly MessageParser<SpellsEvent> _parser;

		// Token: 0x040004E9 RID: 1257
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004EA RID: 1258
		public const int SpellVisualisationFieldNumber = 1;

		// Token: 0x040004EB RID: 1259
		private bool spellVisualisation_;

		// Token: 0x040004EC RID: 1260
		public const int HumanSpellsFieldNumber = 2;

		// Token: 0x040004ED RID: 1261
		private static readonly FieldCodec<SpellItem> _repeated_humanSpells_codec;

		// Token: 0x040004EE RID: 1262
		private readonly RepeatedField<SpellItem> humanSpells_;

		// Token: 0x040004EF RID: 1263
		public const int MutantSpellsFieldNumber = 3;

		// Token: 0x040004F0 RID: 1264
		private static readonly FieldCodec<SpellItem> _repeated_mutantSpells_codec;

		// Token: 0x040004F1 RID: 1265
		private readonly RepeatedField<SpellItem> mutantSpells_;

		// Token: 0x040004F2 RID: 1266
		internal static SpellsEvent HbRf2SOcr33CmChLSWVZ;
	}
}
