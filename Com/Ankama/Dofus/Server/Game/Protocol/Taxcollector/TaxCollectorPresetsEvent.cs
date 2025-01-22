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
	// Token: 0x020000D9 RID: 217
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPresetsEvent : IMessage<TaxCollectorPresetsEvent>, IMessage, IEquatable<TaxCollectorPresetsEvent>, IDeepCloneable<TaxCollectorPresetsEvent>, IBufferMessage
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x001928FC File Offset: 0x00190AFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorPresetsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0019290C File Offset: 0x00190B0C
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0019291C File Offset: 0x00190B1C
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

		// Token: 0x060009BD RID: 2493 RVA: 0x0019292C File Offset: 0x00190B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsEvent()
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0019293C File Offset: 0x00190B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsEvent(TaxCollectorPresetsEvent other)
		{
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0019294C File Offset: 0x00190B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsEvent Clone()
		{
			return null;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0019295C File Offset: 0x00190B5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<TaxCollectorPreset> Presets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0019296C File Offset: 0x00190B6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0019297C File Offset: 0x00190B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPresetsEvent other)
		{
			return true;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0019298C File Offset: 0x00190B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0019299C File Offset: 0x00190B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x001929AC File Offset: 0x00190BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x001929BC File Offset: 0x00190BBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x001929CC File Offset: 0x00190BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x001929DC File Offset: 0x00190BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPresetsEvent other)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x001929EC File Offset: 0x00190BEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x001929FC File Offset: 0x00190BFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00192A0C File Offset: 0x00190C0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPresetsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TaxCollectorPresetsEvent._parser = new MessageParser<TaxCollectorPresetsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				TaxCollectorPresetsEvent._repeated_presets_codec = FieldCodec.ForMessage<TaxCollectorPreset>(10U, JavQsookerKHILCfFKk.XVInXhlssT(JavQsookerKHILCfFKk.iHIola8IQm));
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00192B28 File Offset: 0x00190D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dS9fGaOktBxHC2N93wrG()
		{
			return true;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00192B30 File Offset: 0x00190D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPresetsEvent MrXs5VOkw96Z9uuMPe5N()
		{
			return null;
		}

		// Token: 0x040003A3 RID: 931
		private static readonly MessageParser<TaxCollectorPresetsEvent> _parser;

		// Token: 0x040003A4 RID: 932
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003A5 RID: 933
		public const int PresetsFieldNumber = 1;

		// Token: 0x040003A6 RID: 934
		private static readonly FieldCodec<TaxCollectorPreset> _repeated_presets_codec;

		// Token: 0x040003A7 RID: 935
		private readonly RepeatedField<TaxCollectorPreset> presets_;

		// Token: 0x040003A8 RID: 936
		private static TaxCollectorPresetsEvent stijotOkDI4ujdhgS8p3;
	}
}
