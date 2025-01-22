using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020007A5 RID: 1957
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SellingConditions : IMessage<SellingConditions>, IMessage, IEquatable<SellingConditions>, IDeepCloneable<SellingConditions>, IBufferMessage
	{
		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x0021F284 File Offset: 0x0021D484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SellingConditions> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x0021F294 File Offset: 0x0021D494
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

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06005FF3 RID: 24563 RVA: 0x0021F2A4 File Offset: 0x0021D4A4
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

		// Token: 0x06005FF4 RID: 24564 RVA: 0x0021F2B4 File Offset: 0x0021D4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SellingConditions()
		{
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x0021F2C4 File Offset: 0x0021D4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SellingConditions(SellingConditions other)
		{
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x0021F2D4 File Offset: 0x0021D4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SellingConditions Clone()
		{
			return null;
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x0021F2E4 File Offset: 0x0021D4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Quantities
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x0021F2F4 File Offset: 0x0021D4F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Types_
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x0021F304 File Offset: 0x0021D504
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x0021F314 File Offset: 0x0021D514
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public float TaxPercentage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (float)0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x0021F324 File Offset: 0x0021D524
		// (set) Token: 0x06005FFC RID: 24572 RVA: 0x0021F334 File Offset: 0x0021D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float TaxModificationPercentage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (float)0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x0021F344 File Offset: 0x0021D544
		// (set) Token: 0x06005FFE RID: 24574 RVA: 0x0021F354 File Offset: 0x0021D554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxItemLevel
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

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x0021F364 File Offset: 0x0021D564
		// (set) Token: 0x06006000 RID: 24576 RVA: 0x0021F374 File Offset: 0x0021D574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxItemPerAccount
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

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06006001 RID: 24577 RVA: 0x0021F384 File Offset: 0x0021D584
		// (set) Token: 0x06006002 RID: 24578 RVA: 0x0021F394 File Offset: 0x0021D594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NpcContextualId
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

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06006003 RID: 24579 RVA: 0x0021F3A4 File Offset: 0x0021D5A4
		// (set) Token: 0x06006004 RID: 24580 RVA: 0x0021F3B4 File Offset: 0x0021D5B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int UnsoldDelay
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

		// Token: 0x06006005 RID: 24581 RVA: 0x0021F3C4 File Offset: 0x0021D5C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x0021F3D4 File Offset: 0x0021D5D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SellingConditions other)
		{
			return true;
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x0021F3E4 File Offset: 0x0021D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x0021F3F4 File Offset: 0x0021D5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x0021F404 File Offset: 0x0021D604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x0021F414 File Offset: 0x0021D614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x0021F424 File Offset: 0x0021D624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x0021F434 File Offset: 0x0021D634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SellingConditions other)
		{
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x0021F444 File Offset: 0x0021D644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x0021F454 File Offset: 0x0021D654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x0021F464 File Offset: 0x0021D664
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SellingConditions()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					SellingConditions._repeated_quantities_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 6;
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					SellingConditions._parser = new MessageParser<SellingConditions>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					SellingConditions._repeated_types_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x0021F598 File Offset: 0x0021D798
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n7IbsHOqWC6wIZGsCooS()
		{
			return true;
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x0021F5A0 File Offset: 0x0021D7A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SellingConditions Qgh172OqhIWwiSaV7jRD()
		{
			return null;
		}

		// Token: 0x040021B7 RID: 8631
		private static readonly MessageParser<SellingConditions> _parser;

		// Token: 0x040021B8 RID: 8632
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021B9 RID: 8633
		public const int QuantitiesFieldNumber = 1;

		// Token: 0x040021BA RID: 8634
		private static readonly FieldCodec<int> _repeated_quantities_codec;

		// Token: 0x040021BB RID: 8635
		private readonly RepeatedField<int> quantities_;

		// Token: 0x040021BC RID: 8636
		public const int Types_FieldNumber = 2;

		// Token: 0x040021BD RID: 8637
		private static readonly FieldCodec<int> _repeated_types_codec;

		// Token: 0x040021BE RID: 8638
		private readonly RepeatedField<int> types_;

		// Token: 0x040021BF RID: 8639
		public const int TaxPercentageFieldNumber = 3;

		// Token: 0x040021C0 RID: 8640
		private float taxPercentage_;

		// Token: 0x040021C1 RID: 8641
		public const int TaxModificationPercentageFieldNumber = 4;

		// Token: 0x040021C2 RID: 8642
		private float taxModificationPercentage_;

		// Token: 0x040021C3 RID: 8643
		public const int MaxItemLevelFieldNumber = 5;

		// Token: 0x040021C4 RID: 8644
		private int maxItemLevel_;

		// Token: 0x040021C5 RID: 8645
		public const int MaxItemPerAccountFieldNumber = 6;

		// Token: 0x040021C6 RID: 8646
		private int maxItemPerAccount_;

		// Token: 0x040021C7 RID: 8647
		public const int NpcContextualIdFieldNumber = 7;

		// Token: 0x040021C8 RID: 8648
		private int npcContextualId_;

		// Token: 0x040021C9 RID: 8649
		public const int UnsoldDelayFieldNumber = 8;

		// Token: 0x040021CA RID: 8650
		private int unsoldDelay_;

		// Token: 0x040021CB RID: 8651
		internal static SellingConditions OHjuq3OqL8lyq4sNLqyH;
	}
}
