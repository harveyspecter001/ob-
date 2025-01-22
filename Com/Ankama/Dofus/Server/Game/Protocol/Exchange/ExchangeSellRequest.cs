using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006F8 RID: 1784
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeSellRequest : IMessage<ExchangeSellRequest>, IMessage, IEquatable<ExchangeSellRequest>, IDeepCloneable<ExchangeSellRequest>, IBufferMessage
	{
		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06005754 RID: 22356 RVA: 0x00214DAC File Offset: 0x00212FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeSellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06005755 RID: 22357 RVA: 0x00214DBC File Offset: 0x00212FBC
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

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x00214DCC File Offset: 0x00212FCC
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

		// Token: 0x06005757 RID: 22359 RVA: 0x00214DDC File Offset: 0x00212FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSellRequest()
		{
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x00214DEC File Offset: 0x00212FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSellRequest(ExchangeSellRequest other)
		{
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x00214DFC File Offset: 0x00212FFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeSellRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x00214E0C File Offset: 0x0021300C
		// (set) Token: 0x0600575B RID: 22363 RVA: 0x00214E1C File Offset: 0x0021301C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x00214E2C File Offset: 0x0021302C
		// (set) Token: 0x0600575D RID: 22365 RVA: 0x00214E3C File Offset: 0x0021303C
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

		// Token: 0x0600575E RID: 22366 RVA: 0x00214E4C File Offset: 0x0021304C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x00214E5C File Offset: 0x0021305C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeSellRequest other)
		{
			return true;
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x00214E6C File Offset: 0x0021306C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x00214E7C File Offset: 0x0021307C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x00214E8C File Offset: 0x0021308C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00214E9C File Offset: 0x0021309C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x00214EAC File Offset: 0x002130AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x00214EBC File Offset: 0x002130BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeSellRequest other)
		{
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x00214ECC File Offset: 0x002130CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x00214EDC File Offset: 0x002130DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00214EEC File Offset: 0x002130EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeSellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					return;
				case 2:
					ExchangeSellRequest._parser = new MessageParser<ExchangeSellRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x00214FE4 File Offset: 0x002131E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zNmdPOOufCSulqFv20BY()
		{
			return true;
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x00214FEC File Offset: 0x002131EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeSellRequest EZllgoOunm9MhZ2vOjNB()
		{
			return null;
		}

		// Token: 0x04001E91 RID: 7825
		private static readonly MessageParser<ExchangeSellRequest> _parser;

		// Token: 0x04001E92 RID: 7826
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E93 RID: 7827
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001E94 RID: 7828
		private int objectUid_;

		// Token: 0x04001E95 RID: 7829
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001E96 RID: 7830
		private int quantity_;

		// Token: 0x04001E97 RID: 7831
		internal static ExchangeSellRequest HbEMplOMzkAH1tgMT449;
	}
}
