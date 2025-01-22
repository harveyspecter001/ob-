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
	// Token: 0x02000747 RID: 1863
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseOfflineSoldItemsEvent : IMessage<ExchangeBidHouseOfflineSoldItemsEvent>, IMessage, IEquatable<ExchangeBidHouseOfflineSoldItemsEvent>, IDeepCloneable<ExchangeBidHouseOfflineSoldItemsEvent>, IBufferMessage
	{
		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x0021A02C File Offset: 0x0021822C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseOfflineSoldItemsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06005B7E RID: 23422 RVA: 0x0021A03C File Offset: 0x0021823C
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

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06005B7F RID: 23423 RVA: 0x0021A04C File Offset: 0x0021824C
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

		// Token: 0x06005B80 RID: 23424 RVA: 0x0021A05C File Offset: 0x0021825C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseOfflineSoldItemsEvent()
		{
		}

		// Token: 0x06005B81 RID: 23425 RVA: 0x0021A06C File Offset: 0x0021826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseOfflineSoldItemsEvent(ExchangeBidHouseOfflineSoldItemsEvent other)
		{
		}

		// Token: 0x06005B82 RID: 23426 RVA: 0x0021A07C File Offset: 0x0021827C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseOfflineSoldItemsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06005B83 RID: 23427 RVA: 0x0021A08C File Offset: 0x0021828C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectGidWithQuantity> BidHouseItems
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B84 RID: 23428 RVA: 0x0021A09C File Offset: 0x0021829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005B85 RID: 23429 RVA: 0x0021A0AC File Offset: 0x002182AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseOfflineSoldItemsEvent other)
		{
			return true;
		}

		// Token: 0x06005B86 RID: 23430 RVA: 0x0021A0BC File Offset: 0x002182BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005B87 RID: 23431 RVA: 0x0021A0CC File Offset: 0x002182CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x0021A0DC File Offset: 0x002182DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x0021A0EC File Offset: 0x002182EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x0021A0FC File Offset: 0x002182FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x0021A10C File Offset: 0x0021830C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseOfflineSoldItemsEvent other)
		{
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x0021A11C File Offset: 0x0021831C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x0021A12C File Offset: 0x0021832C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x0021A13C File Offset: 0x0021833C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseOfflineSoldItemsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
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
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 4:
						ExchangeBidHouseOfflineSoldItemsEvent._parser = new MessageParser<ExchangeBidHouseOfflineSoldItemsEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					break;
				}
				IL_76:
				ExchangeBidHouseOfflineSoldItemsEvent._repeated_bidHouseItems_codec = FieldCodec.ForMessage<ObjectGidWithQuantity>(10U, hKDwCgAvDnD1E1yKRZW2.XVInXhlssT(hKDwCgAvDnD1E1yKRZW2.pYwAvtKyGS9));
				num = 5;
				continue;
				goto IL_76;
			}
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x0021A230 File Offset: 0x00218430
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T8CllAO8HQUGX0t6Xw7e()
		{
			return true;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x0021A238 File Offset: 0x00218438
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseOfflineSoldItemsEvent FObSv0O8YYwZVNpZY8YQ()
		{
			return null;
		}

		// Token: 0x04002010 RID: 8208
		private static readonly MessageParser<ExchangeBidHouseOfflineSoldItemsEvent> _parser;

		// Token: 0x04002011 RID: 8209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002012 RID: 8210
		public const int BidHouseItemsFieldNumber = 1;

		// Token: 0x04002013 RID: 8211
		private static readonly FieldCodec<ObjectGidWithQuantity> _repeated_bidHouseItems_codec;

		// Token: 0x04002014 RID: 8212
		private readonly RepeatedField<ObjectGidWithQuantity> bidHouseItems_;

		// Token: 0x04002015 RID: 8213
		internal static ExchangeBidHouseOfflineSoldItemsEvent AD0I25O8pDZ6NQZRqrqU;
	}
}
