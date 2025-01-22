using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D25 RID: 3365
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRankUpdateAllRequest : IMessage<AllianceRankUpdateAllRequest>, IMessage, IEquatable<AllianceRankUpdateAllRequest>, IDeepCloneable<AllianceRankUpdateAllRequest>, IBufferMessage
	{
		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600A202 RID: 41474 RVA: 0x0028A218 File Offset: 0x00288418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceRankUpdateAllRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x0028A228 File Offset: 0x00288428
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

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x0600A204 RID: 41476 RVA: 0x0028A238 File Offset: 0x00288438
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

		// Token: 0x0600A205 RID: 41477 RVA: 0x0028A248 File Offset: 0x00288448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankUpdateAllRequest()
		{
		}

		// Token: 0x0600A206 RID: 41478 RVA: 0x0028A258 File Offset: 0x00288458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankUpdateAllRequest(AllianceRankUpdateAllRequest other)
		{
		}

		// Token: 0x0600A207 RID: 41479 RVA: 0x0028A268 File Offset: 0x00288468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankUpdateAllRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x0600A208 RID: 41480 RVA: 0x0028A278 File Offset: 0x00288478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RankInformation> Ranks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A209 RID: 41481 RVA: 0x0028A288 File Offset: 0x00288488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A20A RID: 41482 RVA: 0x0028A298 File Offset: 0x00288498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRankUpdateAllRequest other)
		{
			return true;
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x0028A2A8 File Offset: 0x002884A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x0028A2B8 File Offset: 0x002884B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x0028A2C8 File Offset: 0x002884C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x0028A2D8 File Offset: 0x002884D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x0028A2E8 File Offset: 0x002884E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x0028A2F8 File Offset: 0x002884F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRankUpdateAllRequest other)
		{
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x0028A308 File Offset: 0x00288508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x0028A318 File Offset: 0x00288518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x0028A328 File Offset: 0x00288528
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRankUpdateAllRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceRankUpdateAllRequest._parser = new MessageParser<AllianceRankUpdateAllRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AllianceRankUpdateAllRequest._repeated_ranks_codec = FieldCodec.ForMessage<RankInformation>(10U, Q43ygLm2FgeO01lX3DCQ.XVInXhlssT(Q43ygLm2FgeO01lX3DCQ.hZLm2zjbuQy));
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x0028A444 File Offset: 0x00288644
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bStLGCJK7K4kAewh5N09()
		{
			return true;
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x0028A44C File Offset: 0x0028864C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRankUpdateAllRequest UEEVR8JKTdrZs5aF7xZn()
		{
			return null;
		}

		// Token: 0x04003BD8 RID: 15320
		private static readonly MessageParser<AllianceRankUpdateAllRequest> _parser;

		// Token: 0x04003BD9 RID: 15321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BDA RID: 15322
		public const int RanksFieldNumber = 1;

		// Token: 0x04003BDB RID: 15323
		private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

		// Token: 0x04003BDC RID: 15324
		private readonly RepeatedField<RankInformation> ranks_;

		// Token: 0x04003BDD RID: 15325
		private static AllianceRankUpdateAllRequest Yh57cdJKQMR8QOfyT38m;
	}
}
