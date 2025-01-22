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
	// Token: 0x02000759 RID: 1881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeRecycleTradeStartedEvent : IMessage<ExchangeRecycleTradeStartedEvent>, IMessage, IEquatable<ExchangeRecycleTradeStartedEvent>, IDeepCloneable<ExchangeRecycleTradeStartedEvent>, IBufferMessage
	{
		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06005C4F RID: 23631 RVA: 0x0021B0F4 File Offset: 0x002192F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeRecycleTradeStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x0021B104 File Offset: 0x00219304
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

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06005C51 RID: 23633 RVA: 0x0021B114 File Offset: 0x00219314
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

		// Token: 0x06005C52 RID: 23634 RVA: 0x0021B124 File Offset: 0x00219324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRecycleTradeStartedEvent()
		{
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x0021B134 File Offset: 0x00219334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRecycleTradeStartedEvent(ExchangeRecycleTradeStartedEvent other)
		{
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x0021B144 File Offset: 0x00219344
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRecycleTradeStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06005C55 RID: 23637 RVA: 0x0021B154 File Offset: 0x00219354
		// (set) Token: 0x06005C56 RID: 23638 RVA: 0x0021B164 File Offset: 0x00219364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PercentToPrism
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

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06005C57 RID: 23639 RVA: 0x0021B174 File Offset: 0x00219374
		// (set) Token: 0x06005C58 RID: 23640 RVA: 0x0021B184 File Offset: 0x00219384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PercentToPlayer
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

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06005C59 RID: 23641 RVA: 0x0021B194 File Offset: 0x00219394
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> AdjacentSubareasPossessed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x0021B1A4 File Offset: 0x002193A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> AdjacentSubareasNotPossessed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x0021B1B4 File Offset: 0x002193B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x0021B1C4 File Offset: 0x002193C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeRecycleTradeStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x0021B1D4 File Offset: 0x002193D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x0021B1E4 File Offset: 0x002193E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x0021B1F4 File Offset: 0x002193F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x0021B204 File Offset: 0x00219404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x0021B214 File Offset: 0x00219414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x0021B224 File Offset: 0x00219424
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeRecycleTradeStartedEvent other)
		{
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x0021B234 File Offset: 0x00219434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x0021B244 File Offset: 0x00219444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x0021B254 File Offset: 0x00219454
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeRecycleTradeStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ExchangeRecycleTradeStartedEvent._repeated_adjacentSubareasNotPossessed_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(34U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 6;
					continue;
				case 4:
					ExchangeRecycleTradeStartedEvent._repeated_adjacentSubareasPossessed_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(26U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					ExchangeRecycleTradeStartedEvent._parser = new MessageParser<ExchangeRecycleTradeStartedEvent>(() => null);
					num2 = 4;
					continue;
				case 6:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 5;
			}
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x0021B374 File Offset: 0x00219574
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pt8IjcOZgY98jQc7MuCC()
		{
			return true;
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x0021B37C File Offset: 0x0021957C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeRecycleTradeStartedEvent ep1FG4OZsgfL6IcIUpxe()
		{
			return null;
		}

		// Token: 0x04002057 RID: 8279
		private static readonly MessageParser<ExchangeRecycleTradeStartedEvent> _parser;

		// Token: 0x04002058 RID: 8280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002059 RID: 8281
		public const int PercentToPrismFieldNumber = 1;

		// Token: 0x0400205A RID: 8282
		private int percentToPrism_;

		// Token: 0x0400205B RID: 8283
		public const int PercentToPlayerFieldNumber = 2;

		// Token: 0x0400205C RID: 8284
		private int percentToPlayer_;

		// Token: 0x0400205D RID: 8285
		public const int AdjacentSubareasPossessedFieldNumber = 3;

		// Token: 0x0400205E RID: 8286
		private static readonly FieldCodec<int> _repeated_adjacentSubareasPossessed_codec;

		// Token: 0x0400205F RID: 8287
		private readonly RepeatedField<int> adjacentSubareasPossessed_;

		// Token: 0x04002060 RID: 8288
		public const int AdjacentSubareasNotPossessedFieldNumber = 4;

		// Token: 0x04002061 RID: 8289
		private static readonly FieldCodec<int> _repeated_adjacentSubareasNotPossessed_codec;

		// Token: 0x04002062 RID: 8290
		private readonly RepeatedField<int> adjacentSubareasNotPossessed_;

		// Token: 0x04002063 RID: 8291
		private static ExchangeRecycleTradeStartedEvent GpXGrFOZGSWI1r5W2w30;
	}
}
