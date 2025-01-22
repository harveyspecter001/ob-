using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000739 RID: 1849
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseItemRemovedEvent : IMessage<ExchangeBidHouseItemRemovedEvent>, IMessage, IEquatable<ExchangeBidHouseItemRemovedEvent>, IDeepCloneable<ExchangeBidHouseItemRemovedEvent>, IBufferMessage
	{
		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x00219034 File Offset: 0x00217234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseItemRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06005AB9 RID: 23225 RVA: 0x00219044 File Offset: 0x00217244
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

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06005ABA RID: 23226 RVA: 0x00219054 File Offset: 0x00217254
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

		// Token: 0x06005ABB RID: 23227 RVA: 0x00219064 File Offset: 0x00217264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseItemRemovedEvent()
		{
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00219074 File Offset: 0x00217274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseItemRemovedEvent(ExchangeBidHouseItemRemovedEvent other)
		{
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00219084 File Offset: 0x00217284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseItemRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06005ABE RID: 23230 RVA: 0x00219094 File Offset: 0x00217294
		// (set) Token: 0x06005ABF RID: 23231 RVA: 0x002190A4 File Offset: 0x002172A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SellId
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

		// Token: 0x06005AC0 RID: 23232 RVA: 0x002190B4 File Offset: 0x002172B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x002190C4 File Offset: 0x002172C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseItemRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x002190D4 File Offset: 0x002172D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x002190E4 File Offset: 0x002172E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x002190F4 File Offset: 0x002172F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00219104 File Offset: 0x00217304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00219114 File Offset: 0x00217314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x00219124 File Offset: 0x00217324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseItemRemovedEvent other)
		{
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x00219134 File Offset: 0x00217334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x00219144 File Offset: 0x00217344
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x00219154 File Offset: 0x00217354
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseItemRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 2:
					ExchangeBidHouseItemRemovedEvent._parser = new MessageParser<ExchangeBidHouseItemRemovedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x00219220 File Offset: 0x00217420
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QSXGpgO8vB6QNdSyDQMa()
		{
			return true;
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x00219228 File Offset: 0x00217428
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseItemRemovedEvent he8VNKO8oKkNa5jPo8Gd()
		{
			return null;
		}

		// Token: 0x04001FC6 RID: 8134
		private static readonly MessageParser<ExchangeBidHouseItemRemovedEvent> _parser;

		// Token: 0x04001FC7 RID: 8135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FC8 RID: 8136
		public const int SellIdFieldNumber = 1;

		// Token: 0x04001FC9 RID: 8137
		private int sellId_;

		// Token: 0x04001FCA RID: 8138
		internal static ExchangeBidHouseItemRemovedEvent xrqF5RO8U5JZvJn50eGY;
	}
}
