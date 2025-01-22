using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006CE RID: 1742
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferAllToInventoryRequest : IMessage<ExchangeObjectTransferAllToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferAllToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferAllToInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06005537 RID: 21815 RVA: 0x002121E4 File Offset: 0x002103E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeObjectTransferAllToInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06005538 RID: 21816 RVA: 0x002121F4 File Offset: 0x002103F4
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

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06005539 RID: 21817 RVA: 0x00212204 File Offset: 0x00210404
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

		// Token: 0x0600553A RID: 21818 RVA: 0x00212214 File Offset: 0x00210414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferAllToInventoryRequest()
		{
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00212224 File Offset: 0x00210424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferAllToInventoryRequest(ExchangeObjectTransferAllToInventoryRequest other)
		{
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x00212234 File Offset: 0x00210434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferAllToInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x00212244 File Offset: 0x00210444
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00212254 File Offset: 0x00210454
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferAllToInventoryRequest other)
		{
			return true;
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00212264 File Offset: 0x00210464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00212274 File Offset: 0x00210474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x00212284 File Offset: 0x00210484
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x00212294 File Offset: 0x00210494
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x002122A4 File Offset: 0x002104A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x002122B4 File Offset: 0x002104B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferAllToInventoryRequest other)
		{
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x002122C4 File Offset: 0x002104C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x002122D4 File Offset: 0x002104D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x002122E4 File Offset: 0x002104E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferAllToInventoryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ExchangeObjectTransferAllToInventoryRequest._parser = new MessageParser<ExchangeObjectTransferAllToInventoryRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x002123B0 File Offset: 0x002105B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RYIFmCOSzr6Mj0pqltud()
		{
			return true;
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x002123B8 File Offset: 0x002105B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferAllToInventoryRequest l8xLKLOMfCOM793agckg()
		{
			return null;
		}

		// Token: 0x04001DFD RID: 7677
		private static readonly MessageParser<ExchangeObjectTransferAllToInventoryRequest> _parser;

		// Token: 0x04001DFE RID: 7678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DFF RID: 7679
		private static ExchangeObjectTransferAllToInventoryRequest P9Z4YTOSFglXS2238A2b;
	}
}
