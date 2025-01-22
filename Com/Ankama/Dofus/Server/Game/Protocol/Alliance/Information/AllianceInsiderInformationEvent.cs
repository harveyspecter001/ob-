using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D68 RID: 3432
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInsiderInformationEvent : IMessage<AllianceInsiderInformationEvent>, IMessage, IEquatable<AllianceInsiderInformationEvent>, IDeepCloneable<AllianceInsiderInformationEvent>, IBufferMessage
	{
		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600A557 RID: 42327 RVA: 0x0029065C File Offset: 0x0028E85C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceInsiderInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600A558 RID: 42328 RVA: 0x0029066C File Offset: 0x0028E86C
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600A559 RID: 42329 RVA: 0x0029067C File Offset: 0x0028E87C
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

		// Token: 0x0600A55A RID: 42330 RVA: 0x0029068C File Offset: 0x0028E88C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInsiderInformationEvent()
		{
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x0029069C File Offset: 0x0028E89C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInsiderInformationEvent(AllianceInsiderInformationEvent other)
		{
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x002906AC File Offset: 0x0028E8AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInsiderInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600A55D RID: 42333 RVA: 0x002906BC File Offset: 0x0028E8BC
		// (set) Token: 0x0600A55E RID: 42334 RVA: 0x002906CC File Offset: 0x0028E8CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public AllianceInformation Information
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

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x002906DC File Offset: 0x0028E8DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<AllianceMemberInformation> Members
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x0600A560 RID: 42336 RVA: 0x002906EC File Offset: 0x0028E8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PrismLocalizedInformation> Prisms
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x0600A561 RID: 42337 RVA: 0x002906FC File Offset: 0x0028E8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TaxCollectorInformation> TaxCollectors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A562 RID: 42338 RVA: 0x0029070C File Offset: 0x0028E90C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A563 RID: 42339 RVA: 0x0029071C File Offset: 0x0028E91C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInsiderInformationEvent other)
		{
			return true;
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x0029072C File Offset: 0x0028E92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x0029073C File Offset: 0x0028E93C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x0029074C File Offset: 0x0028E94C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x0029075C File Offset: 0x0028E95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x0029076C File Offset: 0x0028E96C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x0029077C File Offset: 0x0028E97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInsiderInformationEvent other)
		{
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x0029078C File Offset: 0x0028E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A56B RID: 42347 RVA: 0x0029079C File Offset: 0x0028E99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x002907AC File Offset: 0x0028E9AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInsiderInformationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AllianceInsiderInformationEvent._repeated_taxCollectors_codec = FieldCodec.ForMessage<TaxCollectorInformation>(34U, OjQf6rlEHlpI64eK4V3.XVInXhlssT(OjQf6rlEHlpI64eK4V3.dhhlXuWfjX));
					num2 = 7;
					break;
				case 1:
					AllianceInsiderInformationEvent._parser = new MessageParser<AllianceInsiderInformationEvent>(() => null);
					num2 = 4;
					break;
				case 2:
					AllianceInsiderInformationEvent._repeated_prisms_codec = FieldCodec.ForMessage<PrismLocalizedInformation>(26U, uXkVISu6qcBBUwg89rL.XVInXhlssT(uXkVISu6qcBBUwg89rL.XXZuLkgxUw));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					AllianceInsiderInformationEvent._repeated_members_codec = FieldCodec.ForMessage<AllianceMemberInformation>(18U, ojVINbBKY7ZxaiHagOvA.XVInXhlssT(ojVINbBKY7ZxaiHagOvA.gKGBKbNdqDn));
					num2 = 2;
					break;
				case 5:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 6:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 5;
					break;
				case 7:
					return;
				}
			}
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x002908E4 File Offset: 0x0028EAE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WFjm29Jkjp7l1tt31p9S()
		{
			return true;
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x002908EC File Offset: 0x0028EAEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInsiderInformationEvent StQsEBJkKm2PMqTsNQSF()
		{
			return null;
		}

		// Token: 0x04003CEE RID: 15598
		private static readonly MessageParser<AllianceInsiderInformationEvent> _parser;

		// Token: 0x04003CEF RID: 15599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CF0 RID: 15600
		public const int InformationFieldNumber = 1;

		// Token: 0x04003CF1 RID: 15601
		private AllianceInformation information_;

		// Token: 0x04003CF2 RID: 15602
		public const int MembersFieldNumber = 2;

		// Token: 0x04003CF3 RID: 15603
		private static readonly FieldCodec<AllianceMemberInformation> _repeated_members_codec;

		// Token: 0x04003CF4 RID: 15604
		private readonly RepeatedField<AllianceMemberInformation> members_;

		// Token: 0x04003CF5 RID: 15605
		public const int PrismsFieldNumber = 3;

		// Token: 0x04003CF6 RID: 15606
		private static readonly FieldCodec<PrismLocalizedInformation> _repeated_prisms_codec;

		// Token: 0x04003CF7 RID: 15607
		private readonly RepeatedField<PrismLocalizedInformation> prisms_;

		// Token: 0x04003CF8 RID: 15608
		public const int TaxCollectorsFieldNumber = 4;

		// Token: 0x04003CF9 RID: 15609
		private static readonly FieldCodec<TaxCollectorInformation> _repeated_taxCollectors_codec;

		// Token: 0x04003CFA RID: 15610
		private readonly RepeatedField<TaxCollectorInformation> taxCollectors_;

		// Token: 0x04003CFB RID: 15611
		private static AllianceInsiderInformationEvent x6uprKJk4bXeJ2CPs18Y;
	}
}
