using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BE4 RID: 3044
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakCancelBidRequest : IMessage<BakCancelBidRequest>, IMessage, IEquatable<BakCancelBidRequest>, IDeepCloneable<BakCancelBidRequest>, IBufferMessage
	{
		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600927E RID: 37502 RVA: 0x00271D20 File Offset: 0x0026FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BakCancelBidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x0600927F RID: 37503 RVA: 0x00271D30 File Offset: 0x0026FF30
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

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06009280 RID: 37504 RVA: 0x00271D40 File Offset: 0x0026FF40
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

		// Token: 0x06009281 RID: 37505 RVA: 0x00271D50 File Offset: 0x0026FF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakCancelBidRequest()
		{
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x00271D60 File Offset: 0x0026FF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakCancelBidRequest(BakCancelBidRequest other)
		{
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00271D70 File Offset: 0x0026FF70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakCancelBidRequest Clone()
		{
			return null;
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06009284 RID: 37508 RVA: 0x00271D80 File Offset: 0x0026FF80
		// (set) Token: 0x06009285 RID: 37509 RVA: 0x00271D90 File Offset: 0x0026FF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BidId
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

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06009286 RID: 37510 RVA: 0x00271DA0 File Offset: 0x0026FFA0
		// (set) Token: 0x06009287 RID: 37511 RVA: 0x00271DB4 File Offset: 0x0026FFB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BakCancelBidRequest.Types.BidCancellationType BidCancellationType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BakCancelBidRequest.Types.BidCancellationType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00271DC4 File Offset: 0x0026FFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x00271DD4 File Offset: 0x0026FFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakCancelBidRequest other)
		{
			return true;
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x00271DE4 File Offset: 0x0026FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x00271DF4 File Offset: 0x0026FFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x00271E04 File Offset: 0x00270004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x00271E14 File Offset: 0x00270014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x00271E24 File Offset: 0x00270024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x00271E34 File Offset: 0x00270034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakCancelBidRequest other)
		{
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x00271E44 File Offset: 0x00270044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009291 RID: 37521 RVA: 0x00271E54 File Offset: 0x00270054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x00271E64 File Offset: 0x00270064
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakCancelBidRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BakCancelBidRequest._parser = new MessageParser<BakCancelBidRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00271F48 File Offset: 0x00270148
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Hl5YkqJEKJ7Xjx1KQFkA()
		{
			return true;
		}

		// Token: 0x06009294 RID: 37524 RVA: 0x00271F50 File Offset: 0x00270150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakCancelBidRequest Ev5I32JEI5Hh3xXJuJxb()
		{
			return null;
		}

		// Token: 0x04003686 RID: 13958
		private static readonly MessageParser<BakCancelBidRequest> _parser;

		// Token: 0x04003687 RID: 13959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003688 RID: 13960
		public const int BidIdFieldNumber = 1;

		// Token: 0x04003689 RID: 13961
		private long bidId_;

		// Token: 0x0400368A RID: 13962
		public const int BidCancellationTypeFieldNumber = 2;

		// Token: 0x0400368B RID: 13963
		private BakCancelBidRequest.Types.BidCancellationType bidCancellationType_;

		// Token: 0x0400368C RID: 13964
		internal static BakCancelBidRequest koi0r1JEj54H22eUba2k;

		// Token: 0x02000BE5 RID: 3045
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06009295 RID: 37525 RVA: 0x002E6A58 File Offset: 0x002E4C58
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000BE6 RID: 3046
			public enum BidCancellationType
			{
				// Token: 0x0400368E RID: 13966
				[OriginalName("UNKNOWN_TYPE")]
				UnknownType,
				// Token: 0x0400368F RID: 13967
				[OriginalName("CLASSIC_TYPE")]
				ClassicType,
				// Token: 0x04003690 RID: 13968
				[OriginalName("FRAUD_TYPE")]
				FraudType
			}
		}
	}
}
