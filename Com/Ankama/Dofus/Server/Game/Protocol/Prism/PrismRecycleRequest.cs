using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001CF RID: 463
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismRecycleRequest : IMessage<PrismRecycleRequest>, IMessage, IEquatable<PrismRecycleRequest>, IDeepCloneable<PrismRecycleRequest>, IBufferMessage
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x001A7330 File Offset: 0x001A5530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PrismRecycleRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x001A7340 File Offset: 0x001A5540
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

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x001A7350 File Offset: 0x001A5550
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

		// Token: 0x0600159D RID: 5533 RVA: 0x001A7360 File Offset: 0x001A5560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismRecycleRequest()
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x001A7370 File Offset: 0x001A5570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismRecycleRequest(PrismRecycleRequest other)
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x001A7380 File Offset: 0x001A5580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismRecycleRequest Clone()
		{
			return null;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x001A7390 File Offset: 0x001A5590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x001A73A0 File Offset: 0x001A55A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismRecycleRequest other)
		{
			return true;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x001A73B0 File Offset: 0x001A55B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x001A73C0 File Offset: 0x001A55C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x001A73D0 File Offset: 0x001A55D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x001A73E0 File Offset: 0x001A55E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x001A73F0 File Offset: 0x001A55F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x001A7400 File Offset: 0x001A5600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismRecycleRequest other)
		{
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x001A7410 File Offset: 0x001A5610
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x001A7420 File Offset: 0x001A5620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x001A7430 File Offset: 0x001A5630
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismRecycleRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a232396280ec440785b393a90a40a809 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				PrismRecycleRequest._parser = new MessageParser<PrismRecycleRequest>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x001A7528 File Offset: 0x001A5728
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O9H3WZO1xtjoyGKSi6TH()
		{
			return true;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x001A7530 File Offset: 0x001A5730
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismRecycleRequest bUScpoO14k2HKv5IXQHX()
		{
			return null;
		}

		// Token: 0x040007AC RID: 1964
		private static readonly MessageParser<PrismRecycleRequest> _parser;

		// Token: 0x040007AD RID: 1965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007AE RID: 1966
		internal static PrismRecycleRequest xsuAhCO1NwbNFkJ5kqaH;
	}
}
