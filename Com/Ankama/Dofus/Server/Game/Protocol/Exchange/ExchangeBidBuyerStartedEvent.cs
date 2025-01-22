using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000773 RID: 1907
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidBuyerStartedEvent : IMessage<ExchangeBidBuyerStartedEvent>, IMessage, IEquatable<ExchangeBidBuyerStartedEvent>, IDeepCloneable<ExchangeBidBuyerStartedEvent>, IBufferMessage
	{
		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06005D79 RID: 23929 RVA: 0x0021C440 File Offset: 0x0021A640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidBuyerStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06005D7A RID: 23930 RVA: 0x0021C450 File Offset: 0x0021A650
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

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06005D7B RID: 23931 RVA: 0x0021C460 File Offset: 0x0021A660
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

		// Token: 0x06005D7C RID: 23932 RVA: 0x0021C470 File Offset: 0x0021A670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidBuyerStartedEvent()
		{
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x0021C480 File Offset: 0x0021A680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidBuyerStartedEvent(ExchangeBidBuyerStartedEvent other)
		{
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x0021C490 File Offset: 0x0021A690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidBuyerStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06005D7F RID: 23935 RVA: 0x0021C4A0 File Offset: 0x0021A6A0
		// (set) Token: 0x06005D80 RID: 23936 RVA: 0x0021C4B0 File Offset: 0x0021A6B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SellingConditions SellingConditions
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

		// Token: 0x06005D81 RID: 23937 RVA: 0x0021C4C0 File Offset: 0x0021A6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x0021C4D0 File Offset: 0x0021A6D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidBuyerStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x0021C4E0 File Offset: 0x0021A6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x0021C4F0 File Offset: 0x0021A6F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x0021C500 File Offset: 0x0021A700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x0021C510 File Offset: 0x0021A710
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x0021C520 File Offset: 0x0021A720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x0021C530 File Offset: 0x0021A730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidBuyerStartedEvent other)
		{
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x0021C540 File Offset: 0x0021A740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x0021C550 File Offset: 0x0021A750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x0021C560 File Offset: 0x0021A760
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidBuyerStartedEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ExchangeBidBuyerStartedEvent._parser = new MessageParser<ExchangeBidBuyerStartedEvent>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x0021C644 File Offset: 0x0021A844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yVVyOwOZLyPMFsEIIBPC()
		{
			return true;
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x0021C64C File Offset: 0x0021A84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidBuyerStartedEvent uSDb4vOZWGTx1uqHetrv()
		{
			return null;
		}

		// Token: 0x040020D8 RID: 8408
		private static readonly MessageParser<ExchangeBidBuyerStartedEvent> _parser;

		// Token: 0x040020D9 RID: 8409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020DA RID: 8410
		public const int SellingConditionsFieldNumber = 1;

		// Token: 0x040020DB RID: 8411
		private SellingConditions sellingConditions_;

		// Token: 0x040020DC RID: 8412
		private static ExchangeBidBuyerStartedEvent fljoIGOZ6p4F4gahDUEd;
	}
}
