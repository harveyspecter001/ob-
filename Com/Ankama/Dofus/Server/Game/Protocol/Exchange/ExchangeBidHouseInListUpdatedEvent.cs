using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000741 RID: 1857
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseInListUpdatedEvent : IMessage<ExchangeBidHouseInListUpdatedEvent>, IMessage, IEquatable<ExchangeBidHouseInListUpdatedEvent>, IDeepCloneable<ExchangeBidHouseInListUpdatedEvent>, IBufferMessage
	{
		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06005B26 RID: 23334 RVA: 0x002198FC File Offset: 0x00217AFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseInListUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06005B27 RID: 23335 RVA: 0x0021990C File Offset: 0x00217B0C
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

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x0021991C File Offset: 0x00217B1C
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

		// Token: 0x06005B29 RID: 23337 RVA: 0x0021992C File Offset: 0x00217B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListUpdatedEvent()
		{
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x0021993C File Offset: 0x00217B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListUpdatedEvent(ExchangeBidHouseInListUpdatedEvent other)
		{
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x0021994C File Offset: 0x00217B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x0021995C File Offset: 0x00217B5C
		// (set) Token: 0x06005B2D RID: 23341 RVA: 0x0021996C File Offset: 0x00217B6C
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

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x0021997C File Offset: 0x00217B7C
		// (set) Token: 0x06005B2F RID: 23343 RVA: 0x0021998C File Offset: 0x00217B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06005B30 RID: 23344 RVA: 0x0021999C File Offset: 0x00217B9C
		// (set) Token: 0x06005B31 RID: 23345 RVA: 0x002199AC File Offset: 0x00217BAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectType
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

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06005B32 RID: 23346 RVA: 0x002199BC File Offset: 0x00217BBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x002199CC File Offset: 0x00217BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Prices
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x002199DC File Offset: 0x00217BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x002199EC File Offset: 0x00217BEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseInListUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x002199FC File Offset: 0x00217BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x00219A0C File Offset: 0x00217C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x00219A1C File Offset: 0x00217C1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x00219A2C File Offset: 0x00217C2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x00219A3C File Offset: 0x00217C3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x00219A4C File Offset: 0x00217C4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseInListUpdatedEvent other)
		{
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x00219A5C File Offset: 0x00217C5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x00219A6C File Offset: 0x00217C6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x00219A7C File Offset: 0x00217C7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseInListUpdatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ExchangeBidHouseInListUpdatedEvent._repeated_prices_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(42U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					ExchangeBidHouseInListUpdatedEvent._parser = new MessageParser<ExchangeBidHouseInListUpdatedEvent>(() => null);
					num2 = 6;
					break;
				case 4:
					return;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					ExchangeBidHouseInListUpdatedEvent._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(34U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x00219BB8 File Offset: 0x00217DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qKFMKtO80GNK8Mk4loyq()
		{
			return true;
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x00219BC0 File Offset: 0x00217DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseInListUpdatedEvent QHpZsfO8CpgPFCfsHYtZ()
		{
			return null;
		}

		// Token: 0x04001FEC RID: 8172
		private static readonly MessageParser<ExchangeBidHouseInListUpdatedEvent> _parser;

		// Token: 0x04001FED RID: 8173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FEE RID: 8174
		public const int BidItemUidFieldNumber = 1;

		// Token: 0x04001FEF RID: 8175
		private int bidItemUid_;

		// Token: 0x04001FF0 RID: 8176
		public const int ObjectGidFieldNumber = 2;

		// Token: 0x04001FF1 RID: 8177
		private int objectGid_;

		// Token: 0x04001FF2 RID: 8178
		public const int ObjectTypeFieldNumber = 3;

		// Token: 0x04001FF3 RID: 8179
		private int objectType_;

		// Token: 0x04001FF4 RID: 8180
		public const int EffectsFieldNumber = 4;

		// Token: 0x04001FF5 RID: 8181
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x04001FF6 RID: 8182
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x04001FF7 RID: 8183
		public const int PricesFieldNumber = 5;

		// Token: 0x04001FF8 RID: 8184
		private static readonly FieldCodec<long> _repeated_prices_codec;

		// Token: 0x04001FF9 RID: 8185
		private readonly RepeatedField<long> prices_;

		// Token: 0x04001FFA RID: 8186
		private static ExchangeBidHouseInListUpdatedEvent ALjx0WO8VxSKoXFyi7wM;
	}
}
