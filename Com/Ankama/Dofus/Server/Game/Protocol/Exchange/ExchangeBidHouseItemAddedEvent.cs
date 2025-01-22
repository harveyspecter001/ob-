using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000737 RID: 1847
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseItemAddedEvent : IMessage<ExchangeBidHouseItemAddedEvent>, IMessage, IEquatable<ExchangeBidHouseItemAddedEvent>, IDeepCloneable<ExchangeBidHouseItemAddedEvent>, IBufferMessage
	{
		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x00218DCC File Offset: 0x00216FCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeBidHouseItemAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x00218DDC File Offset: 0x00216FDC
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

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06005A9C RID: 23196 RVA: 0x00218DEC File Offset: 0x00216FEC
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

		// Token: 0x06005A9D RID: 23197 RVA: 0x00218DFC File Offset: 0x00216FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseItemAddedEvent()
		{
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x00218E0C File Offset: 0x0021700C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseItemAddedEvent(ExchangeBidHouseItemAddedEvent other)
		{
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x00218E1C File Offset: 0x0021701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseItemAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x00218E2C File Offset: 0x0021702C
		// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x00218E3C File Offset: 0x0021703C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BidItem Item
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

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x00218E4C File Offset: 0x0021704C
		// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x00218E5C File Offset: 0x0021705C
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

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x00218E6C File Offset: 0x0021706C
		// (set) Token: 0x06005AA5 RID: 23205 RVA: 0x00218E7C File Offset: 0x0021707C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long UnsoldDelay
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

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00218E8C File Offset: 0x0021708C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x00218E9C File Offset: 0x0021709C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseItemAddedEvent other)
		{
			return true;
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00218EAC File Offset: 0x002170AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00218EBC File Offset: 0x002170BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x00218ECC File Offset: 0x002170CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00218EDC File Offset: 0x002170DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00218EEC File Offset: 0x002170EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00218EFC File Offset: 0x002170FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseItemAddedEvent other)
		{
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x00218F0C File Offset: 0x0021710C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x00218F1C File Offset: 0x0021711C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x00218F2C File Offset: 0x0021712C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseItemAddedEvent()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				ExchangeBidHouseItemAddedEvent._parser = new MessageParser<ExchangeBidHouseItemAddedEvent>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x00219024 File Offset: 0x00217224
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rqxoMqO8lBARdHuNaVGK()
		{
			return true;
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x0021902C File Offset: 0x0021722C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseItemAddedEvent YNJIKUO8cfOc8OqsLVa5()
		{
			return null;
		}

		// Token: 0x04001FBB RID: 8123
		private static readonly MessageParser<ExchangeBidHouseItemAddedEvent> _parser;

		// Token: 0x04001FBC RID: 8124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FBD RID: 8125
		public const int ItemFieldNumber = 1;

		// Token: 0x04001FBE RID: 8126
		private BidItem item_;

		// Token: 0x04001FBF RID: 8127
		public const int PriceFieldNumber = 2;

		// Token: 0x04001FC0 RID: 8128
		private long price_;

		// Token: 0x04001FC1 RID: 8129
		public const int UnsoldDelayFieldNumber = 3;

		// Token: 0x04001FC2 RID: 8130
		private long unsoldDelay_;

		// Token: 0x04001FC3 RID: 8131
		private static ExchangeBidHouseItemAddedEvent KpkbxgO8k6AK087tUZhn;
	}
}
