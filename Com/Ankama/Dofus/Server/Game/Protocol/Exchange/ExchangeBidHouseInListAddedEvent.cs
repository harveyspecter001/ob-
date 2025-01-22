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
	// Token: 0x0200073F RID: 1855
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseInListAddedEvent : IMessage<ExchangeBidHouseInListAddedEvent>, IMessage, IEquatable<ExchangeBidHouseInListAddedEvent>, IDeepCloneable<ExchangeBidHouseInListAddedEvent>, IBufferMessage
	{
		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x0021965C File Offset: 0x0021785C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidHouseInListAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06005B07 RID: 23303 RVA: 0x0021966C File Offset: 0x0021786C
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06005B08 RID: 23304 RVA: 0x0021967C File Offset: 0x0021787C
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

		// Token: 0x06005B09 RID: 23305 RVA: 0x0021968C File Offset: 0x0021788C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListAddedEvent()
		{
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x0021969C File Offset: 0x0021789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListAddedEvent(ExchangeBidHouseInListAddedEvent other)
		{
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x002196AC File Offset: 0x002178AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseInListAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06005B0C RID: 23308 RVA: 0x002196BC File Offset: 0x002178BC
		// (set) Token: 0x06005B0D RID: 23309 RVA: 0x002196CC File Offset: 0x002178CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06005B0E RID: 23310 RVA: 0x002196DC File Offset: 0x002178DC
		// (set) Token: 0x06005B0F RID: 23311 RVA: 0x002196EC File Offset: 0x002178EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06005B10 RID: 23312 RVA: 0x002196FC File Offset: 0x002178FC
		// (set) Token: 0x06005B11 RID: 23313 RVA: 0x0021970C File Offset: 0x0021790C
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

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06005B12 RID: 23314 RVA: 0x0021971C File Offset: 0x0021791C
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

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06005B13 RID: 23315 RVA: 0x0021972C File Offset: 0x0021792C
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

		// Token: 0x06005B14 RID: 23316 RVA: 0x0021973C File Offset: 0x0021793C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x0021974C File Offset: 0x0021794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseInListAddedEvent other)
		{
			return true;
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x0021975C File Offset: 0x0021795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x0021976C File Offset: 0x0021796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x0021977C File Offset: 0x0021797C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x0021978C File Offset: 0x0021798C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x0021979C File Offset: 0x0021799C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x002197AC File Offset: 0x002179AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseInListAddedEvent other)
		{
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x002197BC File Offset: 0x002179BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x002197CC File Offset: 0x002179CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x002197DC File Offset: 0x002179DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseInListAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					ExchangeBidHouseInListAddedEvent._parser = new MessageParser<ExchangeBidHouseInListAddedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ExchangeBidHouseInListAddedEvent._repeated_prices_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(42U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 4;
					continue;
				case 4:
					return;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					continue;
				}
				ExchangeBidHouseInListAddedEvent._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(34U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
				num2 = 3;
			}
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x002198EC File Offset: 0x00217AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EyIaU6O8hYZnCvQZLkSh()
		{
			return true;
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x002198F4 File Offset: 0x00217AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseInListAddedEvent rrRi6RO8rgMkCekWUl23()
		{
			return null;
		}

		// Token: 0x04001FDB RID: 8155
		private static readonly MessageParser<ExchangeBidHouseInListAddedEvent> _parser;

		// Token: 0x04001FDC RID: 8156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FDD RID: 8157
		public const int BidItemUidFieldNumber = 1;

		// Token: 0x04001FDE RID: 8158
		private int bidItemUid_;

		// Token: 0x04001FDF RID: 8159
		public const int ObjectGidFieldNumber = 2;

		// Token: 0x04001FE0 RID: 8160
		private int objectGid_;

		// Token: 0x04001FE1 RID: 8161
		public const int ObjectTypeFieldNumber = 3;

		// Token: 0x04001FE2 RID: 8162
		private int objectType_;

		// Token: 0x04001FE3 RID: 8163
		public const int EffectsFieldNumber = 4;

		// Token: 0x04001FE4 RID: 8164
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x04001FE5 RID: 8165
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x04001FE6 RID: 8166
		public const int PricesFieldNumber = 5;

		// Token: 0x04001FE7 RID: 8167
		private static readonly FieldCodec<long> _repeated_prices_codec;

		// Token: 0x04001FE8 RID: 8168
		private readonly RepeatedField<long> prices_;

		// Token: 0x04001FE9 RID: 8169
		private static ExchangeBidHouseInListAddedEvent B0Hw8RO8Ws6D3kmfmfKY;
	}
}
