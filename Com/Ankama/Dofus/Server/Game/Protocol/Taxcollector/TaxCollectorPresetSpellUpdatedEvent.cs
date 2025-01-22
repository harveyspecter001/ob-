using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000DB RID: 219
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPresetSpellUpdatedEvent : IMessage<TaxCollectorPresetSpellUpdatedEvent>, IMessage, IEquatable<TaxCollectorPresetSpellUpdatedEvent>, IDeepCloneable<TaxCollectorPresetSpellUpdatedEvent>, IBufferMessage
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00192B38 File Offset: 0x00190D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorPresetSpellUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00192B48 File Offset: 0x00190D48
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00192B58 File Offset: 0x00190D58
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

		// Token: 0x060009D6 RID: 2518 RVA: 0x00192B68 File Offset: 0x00190D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellUpdatedEvent()
		{
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00192B78 File Offset: 0x00190D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellUpdatedEvent(TaxCollectorPresetSpellUpdatedEvent other)
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00192B88 File Offset: 0x00190D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetSpellUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00192B98 File Offset: 0x00190D98
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00192BA8 File Offset: 0x00190DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PresetUid
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00192BB8 File Offset: 0x00190DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TaxCollectorOrderedSpell> Spells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00192BC8 File Offset: 0x00190DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00192BD8 File Offset: 0x00190DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPresetSpellUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00192BE8 File Offset: 0x00190DE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00192BF8 File Offset: 0x00190DF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00192C08 File Offset: 0x00190E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00192C18 File Offset: 0x00190E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00192C28 File Offset: 0x00190E28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00192C38 File Offset: 0x00190E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPresetSpellUpdatedEvent other)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00192C48 File Offset: 0x00190E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00192C58 File Offset: 0x00190E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00192C68 File Offset: 0x00190E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPresetSpellUpdatedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					TaxCollectorPresetSpellUpdatedEvent._parser = new MessageParser<TaxCollectorPresetSpellUpdatedEvent>(() => null);
					num2 = 4;
					break;
				case 4:
					TaxCollectorPresetSpellUpdatedEvent._repeated_spells_codec = FieldCodec.ForMessage<TaxCollectorOrderedSpell>(18U, VNeXjioNI0Bas9sNLR3.XVInXhlssT(VNeXjioNI0Bas9sNLR3.M9pox3YLqv));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00192D58 File Offset: 0x00190F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JWnqTuOk7Zm8ARj9QJBc()
		{
			return true;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00192D60 File Offset: 0x00190F60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPresetSpellUpdatedEvent p2lXSXOkTNGv0wXuylAE()
		{
			return null;
		}

		// Token: 0x040003AB RID: 939
		private static readonly MessageParser<TaxCollectorPresetSpellUpdatedEvent> _parser;

		// Token: 0x040003AC RID: 940
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003AD RID: 941
		public const int PresetUidFieldNumber = 1;

		// Token: 0x040003AE RID: 942
		private string presetUid_;

		// Token: 0x040003AF RID: 943
		public const int SpellsFieldNumber = 2;

		// Token: 0x040003B0 RID: 944
		private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

		// Token: 0x040003B1 RID: 945
		private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

		// Token: 0x040003B2 RID: 946
		internal static TaxCollectorPresetSpellUpdatedEvent ayXFQyOkQG5hgT0OSfjc;
	}
}
