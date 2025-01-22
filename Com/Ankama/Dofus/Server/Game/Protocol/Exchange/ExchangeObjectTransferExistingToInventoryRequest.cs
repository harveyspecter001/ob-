using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006D4 RID: 1748
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferExistingToInventoryRequest : IMessage<ExchangeObjectTransferExistingToInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferExistingToInventoryRequest>, IDeepCloneable<ExchangeObjectTransferExistingToInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06005581 RID: 21889 RVA: 0x0021284C File Offset: 0x00210A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeObjectTransferExistingToInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06005582 RID: 21890 RVA: 0x0021285C File Offset: 0x00210A5C
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

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06005583 RID: 21891 RVA: 0x0021286C File Offset: 0x00210A6C
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

		// Token: 0x06005584 RID: 21892 RVA: 0x0021287C File Offset: 0x00210A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferExistingToInventoryRequest()
		{
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x0021288C File Offset: 0x00210A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferExistingToInventoryRequest(ExchangeObjectTransferExistingToInventoryRequest other)
		{
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x0021289C File Offset: 0x00210A9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferExistingToInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x002128AC File Offset: 0x00210AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x002128BC File Offset: 0x00210ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferExistingToInventoryRequest other)
		{
			return true;
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x002128CC File Offset: 0x00210ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x002128DC File Offset: 0x00210ADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x002128EC File Offset: 0x00210AEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x002128FC File Offset: 0x00210AFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x0021290C File Offset: 0x00210B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x0021291C File Offset: 0x00210B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferExistingToInventoryRequest other)
		{
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x0021292C File Offset: 0x00210B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x0021293C File Offset: 0x00210B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x0021294C File Offset: 0x00210B4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferExistingToInventoryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					ExchangeObjectTransferExistingToInventoryRequest._parser = new MessageParser<ExchangeObjectTransferExistingToInventoryRequest>(() => null);
					num2 = 4;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00212A18 File Offset: 0x00210C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QakT72OMOM7KLWPa6Xwy()
		{
			return true;
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x00212A20 File Offset: 0x00210C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferExistingToInventoryRequest BI0d2jOMJfVEFY2ow5cQ()
		{
			return null;
		}

		// Token: 0x04001E12 RID: 7698
		private static readonly MessageParser<ExchangeObjectTransferExistingToInventoryRequest> _parser;

		// Token: 0x04001E13 RID: 7699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E14 RID: 7700
		internal static ExchangeObjectTransferExistingToInventoryRequest MwLIFIOMRSZPn15J5hNi;
	}
}
