using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200075D RID: 1885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMultiCraftOkEvent : IMessage<ExchangeMultiCraftOkEvent>, IMessage, IEquatable<ExchangeMultiCraftOkEvent>, IDeepCloneable<ExchangeMultiCraftOkEvent>, IBufferMessage
	{
		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x0021B5EC File Offset: 0x002197EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMultiCraftOkEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06005C8B RID: 23691 RVA: 0x0021B5FC File Offset: 0x002197FC
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

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x0021B60C File Offset: 0x0021980C
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

		// Token: 0x06005C8D RID: 23693 RVA: 0x0021B61C File Offset: 0x0021981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftOkEvent()
		{
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x0021B62C File Offset: 0x0021982C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftOkEvent(ExchangeMultiCraftOkEvent other)
		{
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x0021B63C File Offset: 0x0021983C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMultiCraftOkEvent Clone()
		{
			return null;
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06005C90 RID: 23696 RVA: 0x0021B64C File Offset: 0x0021984C
		// (set) Token: 0x06005C91 RID: 23697 RVA: 0x0021B65C File Offset: 0x0021985C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InitiatorId
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

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06005C92 RID: 23698 RVA: 0x0021B66C File Offset: 0x0021986C
		// (set) Token: 0x06005C93 RID: 23699 RVA: 0x0021B67C File Offset: 0x0021987C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OtherId
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

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06005C94 RID: 23700 RVA: 0x0021B68C File Offset: 0x0021988C
		// (set) Token: 0x06005C95 RID: 23701 RVA: 0x0021B6A0 File Offset: 0x002198A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ExchangeType Role
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x0021B6B0 File Offset: 0x002198B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x0021B6C0 File Offset: 0x002198C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMultiCraftOkEvent other)
		{
			return true;
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x0021B6D0 File Offset: 0x002198D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x0021B6E0 File Offset: 0x002198E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x0021B6F0 File Offset: 0x002198F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x0021B700 File Offset: 0x00219900
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x0021B710 File Offset: 0x00219910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x0021B720 File Offset: 0x00219920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMultiCraftOkEvent other)
		{
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x0021B730 File Offset: 0x00219930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x0021B740 File Offset: 0x00219940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x0021B750 File Offset: 0x00219950
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMultiCraftOkEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					ExchangeMultiCraftOkEvent._parser = new MessageParser<ExchangeMultiCraftOkEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x0021B834 File Offset: 0x00219A34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LAufemOZXqoiXZq3uHWj()
		{
			return true;
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x0021B83C File Offset: 0x00219A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMultiCraftOkEvent TJEX5qOZNQZUm3bIoe3d()
		{
			return null;
		}

		// Token: 0x04002072 RID: 8306
		private static readonly MessageParser<ExchangeMultiCraftOkEvent> _parser;

		// Token: 0x04002073 RID: 8307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002074 RID: 8308
		public const int InitiatorIdFieldNumber = 1;

		// Token: 0x04002075 RID: 8309
		private long initiatorId_;

		// Token: 0x04002076 RID: 8310
		public const int OtherIdFieldNumber = 2;

		// Token: 0x04002077 RID: 8311
		private long otherId_;

		// Token: 0x04002078 RID: 8312
		public const int RoleFieldNumber = 3;

		// Token: 0x04002079 RID: 8313
		private ExchangeType role_;

		// Token: 0x0400207A RID: 8314
		internal static ExchangeMultiCraftOkEvent sAHGrlOZEkhMSI7H0WEK;
	}
}
