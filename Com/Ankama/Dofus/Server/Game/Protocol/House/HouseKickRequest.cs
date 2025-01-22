using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House
{
	// Token: 0x02000453 RID: 1107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HouseKickRequest : IMessage<HouseKickRequest>, IMessage, IEquatable<HouseKickRequest>, IDeepCloneable<HouseKickRequest>, IBufferMessage
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x001DB004 File Offset: 0x001D9204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HouseKickRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x001DB014 File Offset: 0x001D9214
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

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x001DB024 File Offset: 0x001D9224
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

		// Token: 0x060034A1 RID: 13473 RVA: 0x001DB034 File Offset: 0x001D9234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseKickRequest()
		{
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x001DB044 File Offset: 0x001D9244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseKickRequest(HouseKickRequest other)
		{
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x001DB054 File Offset: 0x001D9254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HouseKickRequest Clone()
		{
			return null;
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x001DB064 File Offset: 0x001D9264
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x001DB074 File Offset: 0x001D9274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x060034A6 RID: 13478 RVA: 0x001DB084 File Offset: 0x001D9284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x001DB094 File Offset: 0x001D9294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HouseKickRequest other)
		{
			return true;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x001DB0A4 File Offset: 0x001D92A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x001DB0B4 File Offset: 0x001D92B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x001DB0C4 File Offset: 0x001D92C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x001DB0D4 File Offset: 0x001D92D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x001DB0E4 File Offset: 0x001D92E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x001DB0F4 File Offset: 0x001D92F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HouseKickRequest other)
		{
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x001DB104 File Offset: 0x001D9304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x001DB114 File Offset: 0x001D9314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x001DB124 File Offset: 0x001D9324
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HouseKickRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					HouseKickRequest._parser = new MessageParser<HouseKickRequest>(() => null);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x001DB208 File Offset: 0x001D9408
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CRG9L1OtmuwvktltDCsh()
		{
			return true;
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x001DB210 File Offset: 0x001D9410
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HouseKickRequest sGjHKoOtAU2uuRtaBxra()
		{
			return null;
		}

		// Token: 0x04001262 RID: 4706
		private static readonly MessageParser<HouseKickRequest> _parser;

		// Token: 0x04001263 RID: 4707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001264 RID: 4708
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04001265 RID: 4709
		private long playerId_;

		// Token: 0x04001266 RID: 4710
		private static HouseKickRequest LOwr1UOtnYsHaLXNUY9f;
	}
}
