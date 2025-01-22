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
	// Token: 0x0200075B RID: 1883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeNpcShopStartedEvent : IMessage<ExchangeNpcShopStartedEvent>, IMessage, IEquatable<ExchangeNpcShopStartedEvent>, IDeepCloneable<ExchangeNpcShopStartedEvent>, IBufferMessage
	{
		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06005C6D RID: 23661 RVA: 0x0021B384 File Offset: 0x00219584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeNpcShopStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06005C6E RID: 23662 RVA: 0x0021B394 File Offset: 0x00219594
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

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06005C6F RID: 23663 RVA: 0x0021B3A4 File Offset: 0x002195A4
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

		// Token: 0x06005C70 RID: 23664 RVA: 0x0021B3B4 File Offset: 0x002195B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeNpcShopStartedEvent()
		{
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x0021B3C4 File Offset: 0x002195C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeNpcShopStartedEvent(ExchangeNpcShopStartedEvent other)
		{
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x0021B3D4 File Offset: 0x002195D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeNpcShopStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06005C73 RID: 23667 RVA: 0x0021B3E4 File Offset: 0x002195E4
		// (set) Token: 0x06005C74 RID: 23668 RVA: 0x0021B3F4 File Offset: 0x002195F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long NpcSellerId
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

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06005C75 RID: 23669 RVA: 0x0021B404 File Offset: 0x00219604
		// (set) Token: 0x06005C76 RID: 23670 RVA: 0x0021B414 File Offset: 0x00219614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int TokenId
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

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06005C77 RID: 23671 RVA: 0x0021B424 File Offset: 0x00219624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemMinimalInformation> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x0021B434 File Offset: 0x00219634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x0021B444 File Offset: 0x00219644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeNpcShopStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x0021B454 File Offset: 0x00219654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x0021B464 File Offset: 0x00219664
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x0021B474 File Offset: 0x00219674
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x0021B484 File Offset: 0x00219684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x0021B494 File Offset: 0x00219694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x0021B4A4 File Offset: 0x002196A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeNpcShopStartedEvent other)
		{
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x0021B4B4 File Offset: 0x002196B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x0021B4C4 File Offset: 0x002196C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x0021B4D4 File Offset: 0x002196D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeNpcShopStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					ExchangeNpcShopStartedEvent._parser = new MessageParser<ExchangeNpcShopStartedEvent>(() => null);
					num2 = 5;
					break;
				case 5:
					ExchangeNpcShopStartedEvent._repeated_objects_codec = FieldCodec.ForMessage<ItemMinimalInformation>(26U, RUqVfFA15E2LoJALhA1Z.XVInXhlssT(RUqVfFA15E2LoJALhA1Z.xLMA1ySOq5M));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x0021B5DC File Offset: 0x002197DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool La47crOZ9d2ucgrT1T0V()
		{
			return true;
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x0021B5E4 File Offset: 0x002197E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeNpcShopStartedEvent AmYZrGOZ2bpHd0rgVcFR()
		{
			return null;
		}

		// Token: 0x04002066 RID: 8294
		private static readonly MessageParser<ExchangeNpcShopStartedEvent> _parser;

		// Token: 0x04002067 RID: 8295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002068 RID: 8296
		public const int NpcSellerIdFieldNumber = 1;

		// Token: 0x04002069 RID: 8297
		private long npcSellerId_;

		// Token: 0x0400206A RID: 8298
		public const int TokenIdFieldNumber = 2;

		// Token: 0x0400206B RID: 8299
		private int tokenId_;

		// Token: 0x0400206C RID: 8300
		public const int ObjectsFieldNumber = 3;

		// Token: 0x0400206D RID: 8301
		private static readonly FieldCodec<ItemMinimalInformation> _repeated_objects_codec;

		// Token: 0x0400206E RID: 8302
		private readonly RepeatedField<ItemMinimalInformation> objects_;

		// Token: 0x0400206F RID: 8303
		private static ExchangeNpcShopStartedEvent HKcwoqOZdbhOXnXvgfuZ;
	}
}
