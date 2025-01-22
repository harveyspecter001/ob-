using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006EC RID: 1772
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeTaxCollectorRequest : IMessage<ExchangeTaxCollectorRequest>, IMessage, IEquatable<ExchangeTaxCollectorRequest>, IDeepCloneable<ExchangeTaxCollectorRequest>, IBufferMessage
	{
		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060056B2 RID: 22194 RVA: 0x002140D4 File Offset: 0x002122D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeTaxCollectorRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060056B3 RID: 22195 RVA: 0x002140E4 File Offset: 0x002122E4
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

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060056B4 RID: 22196 RVA: 0x002140F4 File Offset: 0x002122F4
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

		// Token: 0x060056B5 RID: 22197 RVA: 0x00214104 File Offset: 0x00212304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorRequest()
		{
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x00214114 File Offset: 0x00212314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorRequest(ExchangeTaxCollectorRequest other)
		{
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00214124 File Offset: 0x00212324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeTaxCollectorRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060056B8 RID: 22200 RVA: 0x00214134 File Offset: 0x00212334
		// (set) Token: 0x060056B9 RID: 22201 RVA: 0x00214144 File Offset: 0x00212344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TaxCollectorUuid
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

		// Token: 0x060056BA RID: 22202 RVA: 0x00214154 File Offset: 0x00212354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x00214164 File Offset: 0x00212364
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeTaxCollectorRequest other)
		{
			return true;
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00214174 File Offset: 0x00212374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00214184 File Offset: 0x00212384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00214194 File Offset: 0x00212394
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x002141A4 File Offset: 0x002123A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x002141B4 File Offset: 0x002123B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x002141C4 File Offset: 0x002123C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeTaxCollectorRequest other)
		{
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x002141D4 File Offset: 0x002123D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x002141E4 File Offset: 0x002123E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x002141F4 File Offset: 0x002123F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeTaxCollectorRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					ExchangeTaxCollectorRequest._parser = new MessageParser<ExchangeTaxCollectorRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x002142D8 File Offset: 0x002124D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zdBRvBOMwjnnE5PwcEAc()
		{
			return true;
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x002142E0 File Offset: 0x002124E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeTaxCollectorRequest VQqkp9OMQNSiFFC8wjrX()
		{
			return null;
		}

		// Token: 0x04001E61 RID: 7777
		private static readonly MessageParser<ExchangeTaxCollectorRequest> _parser;

		// Token: 0x04001E62 RID: 7778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E63 RID: 7779
		public const int TaxCollectorUuidFieldNumber = 1;

		// Token: 0x04001E64 RID: 7780
		private string taxCollectorUuid_;

		// Token: 0x04001E65 RID: 7781
		private static ExchangeTaxCollectorRequest JfBJ3SOMt91hHENHSRay;
	}
}
