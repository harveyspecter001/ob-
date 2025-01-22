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
	// Token: 0x02000AF8 RID: 2808
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightCharacteristics : IMessage<FightCharacteristics>, IMessage, IEquatable<FightCharacteristics>, IDeepCloneable<FightCharacteristics>, IBufferMessage
	{
		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x00265210 File Offset: 0x00263410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightCharacteristics> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600863E RID: 34366 RVA: 0x00265220 File Offset: 0x00263420
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

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x00265230 File Offset: 0x00263430
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

		// Token: 0x06008640 RID: 34368 RVA: 0x00265240 File Offset: 0x00263440
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightCharacteristics()
		{
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x00265250 File Offset: 0x00263450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightCharacteristics(FightCharacteristics other)
		{
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x00265260 File Offset: 0x00263460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightCharacteristics Clone()
		{
			return null;
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06008643 RID: 34371 RVA: 0x00265270 File Offset: 0x00263470
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

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x06008644 RID: 34372 RVA: 0x00265280 File Offset: 0x00263480
		// (set) Token: 0x06008645 RID: 34373 RVA: 0x00265290 File Offset: 0x00263490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Summoner
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

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x06008646 RID: 34374 RVA: 0x002652A0 File Offset: 0x002634A0
		// (set) Token: 0x06008647 RID: 34375 RVA: 0x002652B0 File Offset: 0x002634B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Summoned
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

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06008648 RID: 34376 RVA: 0x002652C0 File Offset: 0x002634C0
		// (set) Token: 0x06008649 RID: 34377 RVA: 0x002652D4 File Offset: 0x002634D4
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

		// Token: 0x0600864A RID: 34378 RVA: 0x002652E4 File Offset: 0x002634E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600864B RID: 34379 RVA: 0x002652F4 File Offset: 0x002634F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightCharacteristics other)
		{
			return true;
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x00265304 File Offset: 0x00263504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x00265314 File Offset: 0x00263514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x00265324 File Offset: 0x00263524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x00265334 File Offset: 0x00263534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06008650 RID: 34384 RVA: 0x00265344 File Offset: 0x00263544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x00265354 File Offset: 0x00263554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightCharacteristics other)
		{
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x00265364 File Offset: 0x00263564
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x00265374 File Offset: 0x00263574
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x00265384 File Offset: 0x00263584
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightCharacteristics()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					FightCharacteristics._repeated_characteristics_codec = FieldCodec.ForMessage<CharacterCharacteristic>(10U, oxaX2nvpkXxDqWMAo4I.XVInXhlssT(oxaX2nvpkXxDqWMAo4I.YgtvHEdYuN));
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					FightCharacteristics._parser = new MessageParser<FightCharacteristics>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 5:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x002654A0 File Offset: 0x002636A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool v3IwoJJsS0vsH4yoQU6D()
		{
			return true;
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x002654A8 File Offset: 0x002636A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightCharacteristics WMH29FJsM6scAyi96IxS()
		{
			return null;
		}

		// Token: 0x0400312B RID: 12587
		private static readonly MessageParser<FightCharacteristics> _parser;

		// Token: 0x0400312C RID: 12588
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400312D RID: 12589
		public const int CharacteristicsFieldNumber = 1;

		// Token: 0x0400312E RID: 12590
		private static readonly FieldCodec<CharacterCharacteristic> _repeated_characteristics_codec;

		// Token: 0x0400312F RID: 12591
		private readonly RepeatedField<CharacterCharacteristic> characteristics_;

		// Token: 0x04003130 RID: 12592
		public const int SummonerFieldNumber = 2;

		// Token: 0x04003131 RID: 12593
		private long summoner_;

		// Token: 0x04003132 RID: 12594
		public const int SummonedFieldNumber = 3;

		// Token: 0x04003133 RID: 12595
		private bool summoned_;

		// Token: 0x04003134 RID: 12596
		public const int InvisibilityStateFieldNumber = 4;

		// Token: 0x04003135 RID: 12597
		private FightInvisibilityState invisibilityState_;

		// Token: 0x04003136 RID: 12598
		internal static FightCharacteristics pliSyWJsPep8aUC97DX9;
	}
}
