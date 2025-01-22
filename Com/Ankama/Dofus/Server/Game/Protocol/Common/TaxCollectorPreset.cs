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
	// Token: 0x02000B9A RID: 2970
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPreset : IMessage<TaxCollectorPreset>, IMessage, IEquatable<TaxCollectorPreset>, IDeepCloneable<TaxCollectorPreset>, IBufferMessage
	{
		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06008EAB RID: 36523 RVA: 0x0026BFD8 File Offset: 0x0026A1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorPreset> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06008EAC RID: 36524 RVA: 0x0026BFE8 File Offset: 0x0026A1E8
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

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06008EAD RID: 36525 RVA: 0x0026BFF8 File Offset: 0x0026A1F8
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

		// Token: 0x06008EAE RID: 36526 RVA: 0x0026C008 File Offset: 0x0026A208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPreset()
		{
		}

		// Token: 0x06008EAF RID: 36527 RVA: 0x0026C018 File Offset: 0x0026A218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPreset(TaxCollectorPreset other)
		{
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x0026C028 File Offset: 0x0026A228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPreset Clone()
		{
			return null;
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06008EB1 RID: 36529 RVA: 0x0026C038 File Offset: 0x0026A238
		// (set) Token: 0x06008EB2 RID: 36530 RVA: 0x0026C048 File Offset: 0x0026A248
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06008EB3 RID: 36531 RVA: 0x0026C058 File Offset: 0x0026A258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<TaxCollectorOrderedSpell> Spells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x06008EB4 RID: 36532 RVA: 0x0026C068 File Offset: 0x0026A268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<CharacterCharacteristic> Characteristics
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x0026C078 File Offset: 0x0026A278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x0026C088 File Offset: 0x0026A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPreset other)
		{
			return true;
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x0026C098 File Offset: 0x0026A298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x0026C0A8 File Offset: 0x0026A2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008EB9 RID: 36537 RVA: 0x0026C0B8 File Offset: 0x0026A2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x0026C0C8 File Offset: 0x0026A2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x0026C0D8 File Offset: 0x0026A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x0026C0E8 File Offset: 0x0026A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPreset other)
		{
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x0026C0F8 File Offset: 0x0026A2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x0026C108 File Offset: 0x0026A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008EBF RID: 36543 RVA: 0x0026C118 File Offset: 0x0026A318
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPreset()
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
					TaxCollectorPreset._repeated_characteristics_codec = FieldCodec.ForMessage<CharacterCharacteristic>(26U, oxaX2nvpkXxDqWMAo4I.XVInXhlssT(oxaX2nvpkXxDqWMAo4I.YgtvHEdYuN));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 6;
					continue;
				case 6:
					TaxCollectorPreset._parser = new MessageParser<TaxCollectorPreset>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				TaxCollectorPreset._repeated_spells_codec = FieldCodec.ForMessage<TaxCollectorOrderedSpell>(18U, VNeXjioNI0Bas9sNLR3.XVInXhlssT(VNeXjioNI0Bas9sNLR3.M9pox3YLqv));
				num2 = 2;
			}
		}

		// Token: 0x06008EC0 RID: 36544 RVA: 0x0026C258 File Offset: 0x0026A458
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IbX6nFJ9uSCWyLWjDLOH()
		{
			return true;
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x0026C260 File Offset: 0x0026A460
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPreset b3w7lWJ98BrvlSIlCaD6()
		{
			return null;
		}

		// Token: 0x040034F4 RID: 13556
		private static readonly MessageParser<TaxCollectorPreset> _parser;

		// Token: 0x040034F5 RID: 13557
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034F6 RID: 13558
		public const int PresetUidFieldNumber = 1;

		// Token: 0x040034F7 RID: 13559
		private string presetUid_;

		// Token: 0x040034F8 RID: 13560
		public const int SpellsFieldNumber = 2;

		// Token: 0x040034F9 RID: 13561
		private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

		// Token: 0x040034FA RID: 13562
		private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

		// Token: 0x040034FB RID: 13563
		public const int CharacteristicsFieldNumber = 3;

		// Token: 0x040034FC RID: 13564
		private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

		// Token: 0x040034FD RID: 13565
		private readonly RepeatedField<CharacterCharacteristic> characteristics_;

		// Token: 0x040034FE RID: 13566
		private static TaxCollectorPreset or7e6qJ9MEJwMbpyhh2t;
	}
}
