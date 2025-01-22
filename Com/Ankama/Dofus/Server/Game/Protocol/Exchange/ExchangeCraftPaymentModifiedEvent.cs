using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020007A3 RID: 1955
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeCraftPaymentModifiedEvent : IMessage<ExchangeCraftPaymentModifiedEvent>, IMessage, IEquatable<ExchangeCraftPaymentModifiedEvent>, IDeepCloneable<ExchangeCraftPaymentModifiedEvent>, IBufferMessage
	{
		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06005FD7 RID: 24535 RVA: 0x0021F070 File Offset: 0x0021D270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeCraftPaymentModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x0021F080 File Offset: 0x0021D280
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

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06005FD9 RID: 24537 RVA: 0x0021F090 File Offset: 0x0021D290
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

		// Token: 0x06005FDA RID: 24538 RVA: 0x0021F0A0 File Offset: 0x0021D2A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftPaymentModifiedEvent()
		{
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x0021F0B0 File Offset: 0x0021D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftPaymentModifiedEvent(ExchangeCraftPaymentModifiedEvent other)
		{
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x0021F0C0 File Offset: 0x0021D2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftPaymentModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06005FDD RID: 24541 RVA: 0x0021F0D0 File Offset: 0x0021D2D0
		// (set) Token: 0x06005FDE RID: 24542 RVA: 0x0021F0E0 File Offset: 0x0021D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Kamas
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

		// Token: 0x06005FDF RID: 24543 RVA: 0x0021F0F0 File Offset: 0x0021D2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x0021F100 File Offset: 0x0021D300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeCraftPaymentModifiedEvent other)
		{
			return true;
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x0021F110 File Offset: 0x0021D310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x0021F120 File Offset: 0x0021D320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x0021F130 File Offset: 0x0021D330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x0021F140 File Offset: 0x0021D340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x0021F150 File Offset: 0x0021D350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x0021F160 File Offset: 0x0021D360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeCraftPaymentModifiedEvent other)
		{
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x0021F170 File Offset: 0x0021D370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x0021F180 File Offset: 0x0021D380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x0021F190 File Offset: 0x0021D390
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeCraftPaymentModifiedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				ExchangeCraftPaymentModifiedEvent._parser = new MessageParser<ExchangeCraftPaymentModifiedEvent>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x0021F274 File Offset: 0x0021D474
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool glGvHeOqy7ETuvaTu7qV()
		{
			return true;
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x0021F27C File Offset: 0x0021D47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeCraftPaymentModifiedEvent spBHGuOq6xtpTnFhxP7w()
		{
			return null;
		}

		// Token: 0x040021B0 RID: 8624
		private static readonly MessageParser<ExchangeCraftPaymentModifiedEvent> _parser;

		// Token: 0x040021B1 RID: 8625
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021B2 RID: 8626
		public const int KamasFieldNumber = 1;

		// Token: 0x040021B3 RID: 8627
		private long kamas_;

		// Token: 0x040021B4 RID: 8628
		internal static ExchangeCraftPaymentModifiedEvent mNVE5iOq5ALvK2sMegde;
	}
}
