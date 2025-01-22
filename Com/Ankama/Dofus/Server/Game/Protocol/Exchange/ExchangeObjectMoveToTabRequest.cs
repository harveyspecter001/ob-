using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006C8 RID: 1736
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectMoveToTabRequest : IMessage<ExchangeObjectMoveToTabRequest>, IMessage, IEquatable<ExchangeObjectMoveToTabRequest>, IDeepCloneable<ExchangeObjectMoveToTabRequest>, IBufferMessage
	{
		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x00211AD8 File Offset: 0x0020FCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectMoveToTabRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060054DE RID: 21726 RVA: 0x00211AE8 File Offset: 0x0020FCE8
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

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x060054DF RID: 21727 RVA: 0x00211AF8 File Offset: 0x0020FCF8
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

		// Token: 0x060054E0 RID: 21728 RVA: 0x00211B08 File Offset: 0x0020FD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMoveToTabRequest()
		{
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x00211B18 File Offset: 0x0020FD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMoveToTabRequest(ExchangeObjectMoveToTabRequest other)
		{
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x00211B28 File Offset: 0x0020FD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectMoveToTabRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x060054E3 RID: 21731 RVA: 0x00211B38 File Offset: 0x0020FD38
		// (set) Token: 0x060054E4 RID: 21732 RVA: 0x00211B48 File Offset: 0x0020FD48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectUid
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

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x060054E5 RID: 21733 RVA: 0x00211B58 File Offset: 0x0020FD58
		// (set) Token: 0x060054E6 RID: 21734 RVA: 0x00211B68 File Offset: 0x0020FD68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x00211B78 File Offset: 0x0020FD78
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x00211B88 File Offset: 0x0020FD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabNumber
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

		// Token: 0x060054E9 RID: 21737 RVA: 0x00211B98 File Offset: 0x0020FD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00211BA8 File Offset: 0x0020FDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectMoveToTabRequest other)
		{
			return true;
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x00211BB8 File Offset: 0x0020FDB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x00211BC8 File Offset: 0x0020FDC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x00211BD8 File Offset: 0x0020FDD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00211BE8 File Offset: 0x0020FDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x00211BF8 File Offset: 0x0020FDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x00211C08 File Offset: 0x0020FE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectMoveToTabRequest other)
		{
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00211C18 File Offset: 0x0020FE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00211C28 File Offset: 0x0020FE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00211C38 File Offset: 0x0020FE38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectMoveToTabRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					ExchangeObjectMoveToTabRequest._parser = new MessageParser<ExchangeObjectMoveToTabRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x00211D30 File Offset: 0x0020FF30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool g7Iv8NOSittsRDPEc0yW()
		{
			return true;
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x00211D38 File Offset: 0x0020FF38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectMoveToTabRequest rtjrubOSPvTUkPyPe198()
		{
			return null;
		}

		// Token: 0x04001DDC RID: 7644
		private static readonly MessageParser<ExchangeObjectMoveToTabRequest> _parser;

		// Token: 0x04001DDD RID: 7645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DDE RID: 7646
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001DDF RID: 7647
		private int objectUid_;

		// Token: 0x04001DE0 RID: 7648
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001DE1 RID: 7649
		private int quantity_;

		// Token: 0x04001DE2 RID: 7650
		public const int TabNumberFieldNumber = 3;

		// Token: 0x04001DE3 RID: 7651
		private int tabNumber_;

		// Token: 0x04001DE4 RID: 7652
		internal static ExchangeObjectMoveToTabRequest jbZtHVOSboOLWeUhEj2g;
	}
}
