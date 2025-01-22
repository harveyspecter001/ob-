using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006C6 RID: 1734
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectUseInWorkshopRequest : IMessage<ExchangeObjectUseInWorkshopRequest>, IMessage, IEquatable<ExchangeObjectUseInWorkshopRequest>, IDeepCloneable<ExchangeObjectUseInWorkshopRequest>, IBufferMessage
	{
		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x00211890 File Offset: 0x0020FA90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeObjectUseInWorkshopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x002118A0 File Offset: 0x0020FAA0
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

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x002118B0 File Offset: 0x0020FAB0
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

		// Token: 0x060054C4 RID: 21700 RVA: 0x002118C0 File Offset: 0x0020FAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectUseInWorkshopRequest()
		{
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x002118D0 File Offset: 0x0020FAD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectUseInWorkshopRequest(ExchangeObjectUseInWorkshopRequest other)
		{
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x002118E0 File Offset: 0x0020FAE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectUseInWorkshopRequest Clone()
		{
			return null;
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x002118F0 File Offset: 0x0020FAF0
		// (set) Token: 0x060054C8 RID: 21704 RVA: 0x00211900 File Offset: 0x0020FB00
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

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x060054C9 RID: 21705 RVA: 0x00211910 File Offset: 0x0020FB10
		// (set) Token: 0x060054CA RID: 21706 RVA: 0x00211920 File Offset: 0x0020FB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060054CB RID: 21707 RVA: 0x00211930 File Offset: 0x0020FB30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00211940 File Offset: 0x0020FB40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectUseInWorkshopRequest other)
		{
			return true;
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x00211950 File Offset: 0x0020FB50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x00211960 File Offset: 0x0020FB60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00211970 File Offset: 0x0020FB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00211980 File Offset: 0x0020FB80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x00211990 File Offset: 0x0020FB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x002119A0 File Offset: 0x0020FBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectUseInWorkshopRequest other)
		{
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x002119B0 File Offset: 0x0020FBB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x002119C0 File Offset: 0x0020FBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x002119D0 File Offset: 0x0020FBD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectUseInWorkshopRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ExchangeObjectUseInWorkshopRequest._parser = new MessageParser<ExchangeObjectUseInWorkshopRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00211AC8 File Offset: 0x0020FCC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RFxfKdOSHdALQW0HZYhd()
		{
			return true;
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00211AD0 File Offset: 0x0020FCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectUseInWorkshopRequest hDVlTHOSYqo9eny8H2aT()
		{
			return null;
		}

		// Token: 0x04001DD3 RID: 7635
		private static readonly MessageParser<ExchangeObjectUseInWorkshopRequest> _parser;

		// Token: 0x04001DD4 RID: 7636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DD5 RID: 7637
		public const int ObjectUidFieldNumber = 1;

		// Token: 0x04001DD6 RID: 7638
		private int objectUid_;

		// Token: 0x04001DD7 RID: 7639
		public const int QuantityFieldNumber = 2;

		// Token: 0x04001DD8 RID: 7640
		private int quantity_;

		// Token: 0x04001DD9 RID: 7641
		private static ExchangeObjectUseInWorkshopRequest ulBUKKOSpmbD8ibsxfDu;
	}
}
