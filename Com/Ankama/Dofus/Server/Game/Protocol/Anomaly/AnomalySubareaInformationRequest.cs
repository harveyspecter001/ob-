using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Anomaly
{
	// Token: 0x02000CDF RID: 3295
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AnomalySubareaInformationRequest : IMessage<AnomalySubareaInformationRequest>, IMessage, IEquatable<AnomalySubareaInformationRequest>, IDeepCloneable<AnomalySubareaInformationRequest>, IBufferMessage
	{
		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06009E99 RID: 40601 RVA: 0x00284354 File Offset: 0x00282554
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AnomalySubareaInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06009E9A RID: 40602 RVA: 0x00284364 File Offset: 0x00282564
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

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06009E9B RID: 40603 RVA: 0x00284374 File Offset: 0x00282574
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

		// Token: 0x06009E9C RID: 40604 RVA: 0x00284384 File Offset: 0x00282584
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalySubareaInformationRequest()
		{
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x00284394 File Offset: 0x00282594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalySubareaInformationRequest(AnomalySubareaInformationRequest other)
		{
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x002843A4 File Offset: 0x002825A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnomalySubareaInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x002843B4 File Offset: 0x002825B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x002843C4 File Offset: 0x002825C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AnomalySubareaInformationRequest other)
		{
			return true;
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x002843D4 File Offset: 0x002825D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x002843E4 File Offset: 0x002825E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x002843F4 File Offset: 0x002825F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x00284404 File Offset: 0x00282604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x00284414 File Offset: 0x00282614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x00284424 File Offset: 0x00282624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AnomalySubareaInformationRequest other)
		{
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x00284434 File Offset: 0x00282634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x00284444 File Offset: 0x00282644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x00284454 File Offset: 0x00282654
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AnomalySubareaInformationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					AnomalySubareaInformationRequest._parser = new MessageParser<AnomalySubareaInformationRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84ebe06b6d224edaa67fb45e43afb5d8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x0028454C File Offset: 0x0028274C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sF8BNWJj3QCVqJU34OdD()
		{
			return true;
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x00284554 File Offset: 0x00282754
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AnomalySubareaInformationRequest JcXmXKJjRUStEwQY1O2V()
		{
			return null;
		}

		// Token: 0x04003AC6 RID: 15046
		private static readonly MessageParser<AnomalySubareaInformationRequest> _parser;

		// Token: 0x04003AC7 RID: 15047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AC8 RID: 15048
		private static AnomalySubareaInformationRequest XiaXHsJjejL1rIIxy68Q;
	}
}
