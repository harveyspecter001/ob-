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
	// Token: 0x020006FF RID: 1791
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobBookSubscribeRequest : IMessage<JobBookSubscribeRequest>, IMessage, IEquatable<JobBookSubscribeRequest>, IDeepCloneable<JobBookSubscribeRequest>, IBufferMessage
	{
		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x00215208 File Offset: 0x00213408
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobBookSubscribeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060057A7 RID: 22439 RVA: 0x00215218 File Offset: 0x00213418
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

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x00215228 File Offset: 0x00213428
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

		// Token: 0x060057A9 RID: 22441 RVA: 0x00215238 File Offset: 0x00213438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobBookSubscribeRequest()
		{
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x00215248 File Offset: 0x00213448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobBookSubscribeRequest(JobBookSubscribeRequest other)
		{
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x00215258 File Offset: 0x00213458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobBookSubscribeRequest Clone()
		{
			return null;
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x00215268 File Offset: 0x00213468
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> JobsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00215278 File Offset: 0x00213478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00215288 File Offset: 0x00213488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobBookSubscribeRequest other)
		{
			return true;
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00215298 File Offset: 0x00213498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x002152A8 File Offset: 0x002134A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x002152B8 File Offset: 0x002134B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x002152C8 File Offset: 0x002134C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x002152D8 File Offset: 0x002134D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x002152E8 File Offset: 0x002134E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobBookSubscribeRequest other)
		{
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x002152F8 File Offset: 0x002134F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00215308 File Offset: 0x00213508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x00215318 File Offset: 0x00213518
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobBookSubscribeRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					JobBookSubscribeRequest._parser = new MessageParser<JobBookSubscribeRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					JobBookSubscribeRequest._repeated_jobsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 5;
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					return;
				}
			}
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00215430 File Offset: 0x00213630
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PBIFDSOu3ptORAsv1hTP()
		{
			return true;
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00215438 File Offset: 0x00213638
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobBookSubscribeRequest zWs9HuOuRcjNBKSWfOuo()
		{
			return null;
		}

		// Token: 0x04001EAB RID: 7851
		private static readonly MessageParser<JobBookSubscribeRequest> _parser;

		// Token: 0x04001EAC RID: 7852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EAD RID: 7853
		public const int JobsIdFieldNumber = 1;

		// Token: 0x04001EAE RID: 7854
		private static readonly FieldCodec<int> _repeated_jobsId_codec;

		// Token: 0x04001EAF RID: 7855
		private readonly RepeatedField<int> jobsId_;

		// Token: 0x04001EB0 RID: 7856
		internal static JobBookSubscribeRequest OGAGmUOueupovCJ8Z9F7;
	}
}
