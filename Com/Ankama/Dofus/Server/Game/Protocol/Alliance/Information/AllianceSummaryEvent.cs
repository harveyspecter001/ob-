using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D6E RID: 3438
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceSummaryEvent : IMessage<AllianceSummaryEvent>, IMessage, IEquatable<AllianceSummaryEvent>, IDeepCloneable<AllianceSummaryEvent>, IBufferMessage
	{
		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x0600A5AE RID: 42414 RVA: 0x00290D90 File Offset: 0x0028EF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceSummaryEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x0600A5AF RID: 42415 RVA: 0x00290DA0 File Offset: 0x0028EFA0
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

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x0600A5B0 RID: 42416 RVA: 0x00290DB0 File Offset: 0x0028EFB0
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

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x00290DC0 File Offset: 0x0028EFC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceSummaryEvent()
		{
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x00290DD0 File Offset: 0x0028EFD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceSummaryEvent(AllianceSummaryEvent other)
		{
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x00290DE0 File Offset: 0x0028EFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceSummaryEvent Clone()
		{
			return null;
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600A5B4 RID: 42420 RVA: 0x00290DF0 File Offset: 0x0028EFF0
		// (set) Token: 0x0600A5B5 RID: 42421 RVA: 0x00290E00 File Offset: 0x0028F000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Offset
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

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x0600A5B6 RID: 42422 RVA: 0x00290E10 File Offset: 0x0028F010
		// (set) Token: 0x0600A5B7 RID: 42423 RVA: 0x00290E20 File Offset: 0x0028F020
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Count
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

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x0600A5B8 RID: 42424 RVA: 0x00290E30 File Offset: 0x0028F030
		// (set) Token: 0x0600A5B9 RID: 42425 RVA: 0x00290E40 File Offset: 0x0028F040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Total
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

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x0600A5BA RID: 42426 RVA: 0x00290E50 File Offset: 0x0028F050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<AllianceInformation> Alliances
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x00290E60 File Offset: 0x0028F060
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x00290E70 File Offset: 0x0028F070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceSummaryEvent other)
		{
			return true;
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x00290E80 File Offset: 0x0028F080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x00290E90 File Offset: 0x0028F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x00290EA0 File Offset: 0x0028F0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x00290EB0 File Offset: 0x0028F0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x00290EC0 File Offset: 0x0028F0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x00290ED0 File Offset: 0x0028F0D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceSummaryEvent other)
		{
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x00290EE0 File Offset: 0x0028F0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x00290EF0 File Offset: 0x0028F0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x00290F00 File Offset: 0x0028F100
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceSummaryEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_39;
					case 3:
						goto IL_A3;
					case 4:
						AllianceSummaryEvent._parser = new MessageParser<AllianceSummaryEvent>(() => null);
						num2 = 3;
						continue;
					case 5:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 2;
					}
				}
				IL_39:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
				continue;
				IL_A3:
				AllianceSummaryEvent._repeated_alliances_codec = FieldCodec.ForMessage<AllianceInformation>(34U, D9Q3XwBKfGZ8CttGH3Kw.XVInXhlssT(D9Q3XwBKfGZ8CttGH3Kw.s8oBKn5CVJc));
				num = 5;
			}
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x00290FF8 File Offset: 0x0028F1F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UEnX5mJk1sbGXZRomwrS()
		{
			return true;
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x00291000 File Offset: 0x0028F200
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceSummaryEvent yY1ToXJka8OSrqm81utb()
		{
			return null;
		}

		// Token: 0x04003D16 RID: 15638
		private static readonly MessageParser<AllianceSummaryEvent> _parser;

		// Token: 0x04003D17 RID: 15639
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D18 RID: 15640
		public const int OffsetFieldNumber = 1;

		// Token: 0x04003D19 RID: 15641
		private long offset_;

		// Token: 0x04003D1A RID: 15642
		public const int CountFieldNumber = 2;

		// Token: 0x04003D1B RID: 15643
		private long count_;

		// Token: 0x04003D1C RID: 15644
		public const int TotalFieldNumber = 3;

		// Token: 0x04003D1D RID: 15645
		private long total_;

		// Token: 0x04003D1E RID: 15646
		public const int AlliancesFieldNumber = 4;

		// Token: 0x04003D1F RID: 15647
		private static readonly FieldCodec<AllianceInformation> _repeated_alliances_codec;

		// Token: 0x04003D20 RID: 15648
		private readonly RepeatedField<AllianceInformation> alliances_;

		// Token: 0x04003D21 RID: 15649
		private static AllianceSummaryEvent VYeSP2JkoTVBh3LMwmSE;
	}
}
