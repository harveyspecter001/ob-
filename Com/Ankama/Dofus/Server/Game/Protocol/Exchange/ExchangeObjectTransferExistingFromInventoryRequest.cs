using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006DC RID: 1756
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferExistingFromInventoryRequest : IMessage<ExchangeObjectTransferExistingFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferExistingFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferExistingFromInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x0021307C File Offset: 0x0021127C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectTransferExistingFromInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x060055E5 RID: 21989 RVA: 0x0021308C File Offset: 0x0021128C
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

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x0021309C File Offset: 0x0021129C
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

		// Token: 0x060055E7 RID: 21991 RVA: 0x002130AC File Offset: 0x002112AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferExistingFromInventoryRequest()
		{
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x002130BC File Offset: 0x002112BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferExistingFromInventoryRequest(ExchangeObjectTransferExistingFromInventoryRequest other)
		{
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x002130CC File Offset: 0x002112CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferExistingFromInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x002130DC File Offset: 0x002112DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x002130EC File Offset: 0x002112EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferExistingFromInventoryRequest other)
		{
			return true;
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x002130FC File Offset: 0x002112FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x0021310C File Offset: 0x0021130C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x0021311C File Offset: 0x0021131C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x0021312C File Offset: 0x0021132C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x0021313C File Offset: 0x0021133C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x0021314C File Offset: 0x0021134C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferExistingFromInventoryRequest other)
		{
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x0021315C File Offset: 0x0021135C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x0021316C File Offset: 0x0021136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x0021317C File Offset: 0x0021137C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferExistingFromInventoryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				ExchangeObjectTransferExistingFromInventoryRequest._parser = new MessageParser<ExchangeObjectTransferExistingFromInventoryRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x00213260 File Offset: 0x00211460
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KG3w0GOM4gisdopNDjBT()
		{
			return true;
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00213268 File Offset: 0x00211468
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferExistingFromInventoryRequest mecP63OMjrU9TvoXBxNF()
		{
			return null;
		}

		// Token: 0x04001E2B RID: 7723
		private static readonly MessageParser<ExchangeObjectTransferExistingFromInventoryRequest> _parser;

		// Token: 0x04001E2C RID: 7724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E2D RID: 7725
		private static ExchangeObjectTransferExistingFromInventoryRequest CN2RjqOMxgcWiacIQ0II;
	}
}
