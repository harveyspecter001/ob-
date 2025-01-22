using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006F4 RID: 1780
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeCraftPaymentModificationRequest : IMessage<ExchangeCraftPaymentModificationRequest>, IMessage, IEquatable<ExchangeCraftPaymentModificationRequest>, IDeepCloneable<ExchangeCraftPaymentModificationRequest>, IBufferMessage
	{
		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x00214964 File Offset: 0x00212B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeCraftPaymentModificationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x0600571F RID: 22303 RVA: 0x00214974 File Offset: 0x00212B74
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

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x00214984 File Offset: 0x00212B84
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

		// Token: 0x06005721 RID: 22305 RVA: 0x00214994 File Offset: 0x00212B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftPaymentModificationRequest()
		{
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x002149A4 File Offset: 0x00212BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftPaymentModificationRequest(ExchangeCraftPaymentModificationRequest other)
		{
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x002149B4 File Offset: 0x00212BB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeCraftPaymentModificationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06005724 RID: 22308 RVA: 0x002149C4 File Offset: 0x00212BC4
		// (set) Token: 0x06005725 RID: 22309 RVA: 0x002149D4 File Offset: 0x00212BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Quantity
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

		// Token: 0x06005726 RID: 22310 RVA: 0x002149E4 File Offset: 0x00212BE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x002149F4 File Offset: 0x00212BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeCraftPaymentModificationRequest other)
		{
			return true;
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x00214A04 File Offset: 0x00212C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00214A14 File Offset: 0x00212C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00214A24 File Offset: 0x00212C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00214A34 File Offset: 0x00212C34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00214A44 File Offset: 0x00212C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x00214A54 File Offset: 0x00212C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeCraftPaymentModificationRequest other)
		{
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x00214A64 File Offset: 0x00212C64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x00214A74 File Offset: 0x00212C74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x00214A84 File Offset: 0x00212C84
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeCraftPaymentModificationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					ExchangeCraftPaymentModificationRequest._parser = new MessageParser<ExchangeCraftPaymentModificationRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x00214B68 File Offset: 0x00212D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MqwpkDOMuWD9YEaOrVIA()
		{
			return true;
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00214B70 File Offset: 0x00212D70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeCraftPaymentModificationRequest COpRMROM8UEKTbE4tHWu()
		{
			return null;
		}

		// Token: 0x04001E81 RID: 7809
		private static readonly MessageParser<ExchangeCraftPaymentModificationRequest> _parser;

		// Token: 0x04001E82 RID: 7810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E83 RID: 7811
		public const int QuantityFieldNumber = 1;

		// Token: 0x04001E84 RID: 7812
		private long quantity_;

		// Token: 0x04001E85 RID: 7813
		private static ExchangeCraftPaymentModificationRequest LlMf5HOMMGOCMh74wpcT;
	}
}
