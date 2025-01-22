using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006D8 RID: 1752
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectTransferListFromInventoryRequest : IMessage<ExchangeObjectTransferListFromInventoryRequest>, IMessage, IEquatable<ExchangeObjectTransferListFromInventoryRequest>, IDeepCloneable<ExchangeObjectTransferListFromInventoryRequest>, IBufferMessage
	{
		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x060055B1 RID: 21937 RVA: 0x00212C30 File Offset: 0x00210E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectTransferListFromInventoryRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x00212C40 File Offset: 0x00210E40
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

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x060055B3 RID: 21939 RVA: 0x00212C50 File Offset: 0x00210E50
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

		// Token: 0x060055B4 RID: 21940 RVA: 0x00212C60 File Offset: 0x00210E60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListFromInventoryRequest()
		{
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00212C70 File Offset: 0x00210E70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListFromInventoryRequest(ExchangeObjectTransferListFromInventoryRequest other)
		{
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00212C80 File Offset: 0x00210E80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectTransferListFromInventoryRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x060055B7 RID: 21943 RVA: 0x00212C90 File Offset: 0x00210E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ObjectsUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00212CA0 File Offset: 0x00210EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x00212CB0 File Offset: 0x00210EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectTransferListFromInventoryRequest other)
		{
			return true;
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x00212CC0 File Offset: 0x00210EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x00212CD0 File Offset: 0x00210ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00212CE0 File Offset: 0x00210EE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00212CF0 File Offset: 0x00210EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00212D00 File Offset: 0x00210F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00212D10 File Offset: 0x00210F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectTransferListFromInventoryRequest other)
		{
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00212D20 File Offset: 0x00210F20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00212D30 File Offset: 0x00210F30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00212D40 File Offset: 0x00210F40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectTransferListFromInventoryRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ExchangeObjectTransferListFromInventoryRequest._repeated_objectsUid_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					ExchangeObjectTransferListFromInventoryRequest._parser = new MessageParser<ExchangeObjectTransferListFromInventoryRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					return;
				}
			}
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00212E58 File Offset: 0x00211058
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n6isbhOM9uxX5lqnecE7()
		{
			return true;
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x00212E60 File Offset: 0x00211060
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectTransferListFromInventoryRequest X0g5dIOM2ptuHnf8h9o9()
		{
			return null;
		}

		// Token: 0x04001E1C RID: 7708
		private static readonly MessageParser<ExchangeObjectTransferListFromInventoryRequest> _parser;

		// Token: 0x04001E1D RID: 7709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E1E RID: 7710
		public const int ObjectsUidFieldNumber = 1;

		// Token: 0x04001E1F RID: 7711
		private static readonly FieldCodec<int> _repeated_objectsUid_codec;

		// Token: 0x04001E20 RID: 7712
		private readonly RepeatedField<int> objectsUid_;

		// Token: 0x04001E21 RID: 7713
		private static ExchangeObjectTransferListFromInventoryRequest DkxppTOMdaS5GeXUsR4g;
	}
}
