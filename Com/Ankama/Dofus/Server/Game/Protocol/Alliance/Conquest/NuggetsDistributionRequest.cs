using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000DA5 RID: 3493
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NuggetsDistributionRequest : IMessage<NuggetsDistributionRequest>, IMessage, IEquatable<NuggetsDistributionRequest>, IDeepCloneable<NuggetsDistributionRequest>, IBufferMessage
	{
		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x0600A85C RID: 43100 RVA: 0x00295120 File Offset: 0x00293320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<NuggetsDistributionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x0600A85D RID: 43101 RVA: 0x00295130 File Offset: 0x00293330
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

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x0600A85E RID: 43102 RVA: 0x00295140 File Offset: 0x00293340
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

		// Token: 0x0600A85F RID: 43103 RVA: 0x00295150 File Offset: 0x00293350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsDistributionRequest()
		{
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x00295160 File Offset: 0x00293360
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsDistributionRequest(NuggetsDistributionRequest other)
		{
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x00295170 File Offset: 0x00293370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsDistributionRequest Clone()
		{
			return null;
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600A862 RID: 43106 RVA: 0x00295180 File Offset: 0x00293380
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<NuggetsBeneficiary> Beneficiaries
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x00295190 File Offset: 0x00293390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x002951A0 File Offset: 0x002933A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NuggetsDistributionRequest other)
		{
			return true;
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x002951B0 File Offset: 0x002933B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x002951C0 File Offset: 0x002933C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x002951D0 File Offset: 0x002933D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x002951E0 File Offset: 0x002933E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x002951F0 File Offset: 0x002933F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x00295200 File Offset: 0x00293400
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NuggetsDistributionRequest other)
		{
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x00295210 File Offset: 0x00293410
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x00295220 File Offset: 0x00293420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x00295230 File Offset: 0x00293430
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NuggetsDistributionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					NuggetsDistributionRequest._parser = new MessageParser<NuggetsDistributionRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					NuggetsDistributionRequest._repeated_beneficiaries_codec = FieldCodec.ForMessage<NuggetsBeneficiary>(10U, DfS8qX3RwRKrsRGyasWV.XVInXhlssT(DfS8qX3RwRKrsRGyasWV.kwe3RQ4f8Kq));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x00295338 File Offset: 0x00293538
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GkP82OJlhsX2BKk8uraa()
		{
			return true;
		}

		// Token: 0x0600A86F RID: 43119 RVA: 0x00295340 File Offset: 0x00293540
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NuggetsDistributionRequest SPCwpnJlrhNAYXTWIKsq()
		{
			return null;
		}

		// Token: 0x04003DF2 RID: 15858
		private static readonly MessageParser<NuggetsDistributionRequest> _parser;

		// Token: 0x04003DF3 RID: 15859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DF4 RID: 15860
		public const int BeneficiariesFieldNumber = 1;

		// Token: 0x04003DF5 RID: 15861
		private static readonly FieldCodec<NuggetsBeneficiary> _repeated_beneficiaries_codec;

		// Token: 0x04003DF6 RID: 15862
		private readonly RepeatedField<NuggetsBeneficiary> beneficiaries_;

		// Token: 0x04003DF7 RID: 15863
		private static NuggetsDistributionRequest m6WQqXJlWfFrMSmSWC58;
	}
}
