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
	// Token: 0x020000D7 RID: 215
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorOrderedSpellUpdatedEvent : IMessage<TaxCollectorOrderedSpellUpdatedEvent>, IMessage, IEquatable<TaxCollectorOrderedSpellUpdatedEvent>, IDeepCloneable<TaxCollectorOrderedSpellUpdatedEvent>, IBufferMessage
	{
		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x001926B4 File Offset: 0x001908B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorOrderedSpellUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x001926C4 File Offset: 0x001908C4
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x001926D4 File Offset: 0x001908D4
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

		// Token: 0x060009A2 RID: 2466 RVA: 0x001926E4 File Offset: 0x001908E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellUpdatedEvent()
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x001926F4 File Offset: 0x001908F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellUpdatedEvent(TaxCollectorOrderedSpellUpdatedEvent other)
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00192704 File Offset: 0x00190904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00192714 File Offset: 0x00190914
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00192724 File Offset: 0x00190924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TaxCollectorUid
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

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00192734 File Offset: 0x00190934
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

		// Token: 0x060009A8 RID: 2472 RVA: 0x00192744 File Offset: 0x00190944
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00192754 File Offset: 0x00190954
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorOrderedSpellUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00192764 File Offset: 0x00190964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00192774 File Offset: 0x00190974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00192784 File Offset: 0x00190984
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00192794 File Offset: 0x00190994
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x001927A4 File Offset: 0x001909A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x001927B4 File Offset: 0x001909B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorOrderedSpellUpdatedEvent other)
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x001927C4 File Offset: 0x001909C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x001927D4 File Offset: 0x001909D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x001927E4 File Offset: 0x001909E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorOrderedSpellUpdatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					TaxCollectorOrderedSpellUpdatedEvent._parser = new MessageParser<TaxCollectorOrderedSpellUpdatedEvent>(() => null);
					num2 = 3;
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					TaxCollectorOrderedSpellUpdatedEvent._repeated_spells_codec = FieldCodec.ForMessage<TaxCollectorOrderedSpell>(18U, VNeXjioNI0Bas9sNLR3.XVInXhlssT(VNeXjioNI0Bas9sNLR3.M9pox3YLqv));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x001928EC File Offset: 0x00190AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O9W4wwOk0TX2mewBB4Gh()
		{
			return true;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x001928F4 File Offset: 0x00190AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorOrderedSpellUpdatedEvent tnTjNoOkC9IKjPmxAadx()
		{
			return null;
		}

		// Token: 0x04000399 RID: 921
		private static readonly MessageParser<TaxCollectorOrderedSpellUpdatedEvent> _parser;

		// Token: 0x0400039A RID: 922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400039B RID: 923
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x0400039C RID: 924
		private string taxCollectorUid_;

		// Token: 0x0400039D RID: 925
		public const int SpellsFieldNumber = 2;

		// Token: 0x0400039E RID: 926
		private static readonly FieldCodec<TaxCollectorOrderedSpell> _repeated_spells_codec;

		// Token: 0x0400039F RID: 927
		private readonly RepeatedField<TaxCollectorOrderedSpell> spells_;

		// Token: 0x040003A0 RID: 928
		private static TaxCollectorOrderedSpellUpdatedEvent Y6k1DPOkVGZLVIrIbVAs;
	}
}
