using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200070B RID: 1803
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseBuyRequest : IMessage<ExchangeBidHouseBuyRequest>, IMessage, IEquatable<ExchangeBidHouseBuyRequest>, IDeepCloneable<ExchangeBidHouseBuyRequest>, IBufferMessage
	{
		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x0600582F RID: 22575 RVA: 0x00215CE4 File Offset: 0x00213EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidHouseBuyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06005830 RID: 22576 RVA: 0x00215CF4 File Offset: 0x00213EF4
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

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06005831 RID: 22577 RVA: 0x00215D04 File Offset: 0x00213F04
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

		// Token: 0x06005832 RID: 22578 RVA: 0x00215D14 File Offset: 0x00213F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseBuyRequest()
		{
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00215D24 File Offset: 0x00213F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseBuyRequest(ExchangeBidHouseBuyRequest other)
		{
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x00215D34 File Offset: 0x00213F34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseBuyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06005835 RID: 22581 RVA: 0x00215D44 File Offset: 0x00213F44
		// (set) Token: 0x06005836 RID: 22582 RVA: 0x00215D54 File Offset: 0x00213F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BidItemUid
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

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x00215D64 File Offset: 0x00213F64
		// (set) Token: 0x06005838 RID: 22584 RVA: 0x00215D74 File Offset: 0x00213F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quantity
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

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06005839 RID: 22585 RVA: 0x00215D84 File Offset: 0x00213F84
		// (set) Token: 0x0600583A RID: 22586 RVA: 0x00215D94 File Offset: 0x00213F94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Price
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

		// Token: 0x0600583B RID: 22587 RVA: 0x00215DA4 File Offset: 0x00213FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00215DB4 File Offset: 0x00213FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseBuyRequest other)
		{
			return true;
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x00215DC4 File Offset: 0x00213FC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00215DD4 File Offset: 0x00213FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x00215DE4 File Offset: 0x00213FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x00215DF4 File Offset: 0x00213FF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x00215E04 File Offset: 0x00214004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x00215E14 File Offset: 0x00214014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseBuyRequest other)
		{
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x00215E24 File Offset: 0x00214024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x00215E34 File Offset: 0x00214034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x00215E44 File Offset: 0x00214044
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseBuyRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ExchangeBidHouseBuyRequest._parser = new MessageParser<ExchangeBidHouseBuyRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x00215F10 File Offset: 0x00214110
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CCrBMxOujbwW2q7fco78()
		{
			return true;
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x00215F18 File Offset: 0x00214118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseBuyRequest nC4EsUOuKDrMoQn1u1b7()
		{
			return null;
		}

		// Token: 0x04001EEC RID: 7916
		private static readonly MessageParser<ExchangeBidHouseBuyRequest> _parser;

		// Token: 0x04001EED RID: 7917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EEE RID: 7918
		public const int BidItemUidFieldNumber = 1;

		// Token: 0x04001EEF RID: 7919
		private int bidItemUid_;

		// Token: 0x04001EF0 RID: 7920
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001EF1 RID: 7921
		private int quantity_;

		// Token: 0x04001EF2 RID: 7922
		public const int PriceFieldNumber = 3;

		// Token: 0x04001EF3 RID: 7923
		private long price_;

		// Token: 0x04001EF4 RID: 7924
		internal static ExchangeBidHouseBuyRequest Gnl4UrOu4vi3Y4rJjdrq;
	}
}
