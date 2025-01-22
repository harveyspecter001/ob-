using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D27 RID: 3367
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRankDeletionRequest : IMessage<AllianceRankDeletionRequest>, IMessage, IEquatable<AllianceRankDeletionRequest>, IDeepCloneable<AllianceRankDeletionRequest>, IBufferMessage
	{
		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x0028A454 File Offset: 0x00288654
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceRankDeletionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x0600A21C RID: 41500 RVA: 0x0028A464 File Offset: 0x00288664
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

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x0600A21D RID: 41501 RVA: 0x0028A474 File Offset: 0x00288674
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

		// Token: 0x0600A21E RID: 41502 RVA: 0x0028A484 File Offset: 0x00288684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankDeletionRequest()
		{
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x0028A494 File Offset: 0x00288694
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankDeletionRequest(AllianceRankDeletionRequest other)
		{
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x0028A4A4 File Offset: 0x002886A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankDeletionRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x0028A4B4 File Offset: 0x002886B4
		// (set) Token: 0x0600A222 RID: 41506 RVA: 0x0028A4C4 File Offset: 0x002886C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RankId
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

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600A223 RID: 41507 RVA: 0x0028A4D4 File Offset: 0x002886D4
		// (set) Token: 0x0600A224 RID: 41508 RVA: 0x0028A4E4 File Offset: 0x002886E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReplacementRankId
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

		// Token: 0x0600A225 RID: 41509 RVA: 0x0028A4F4 File Offset: 0x002886F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x0028A504 File Offset: 0x00288704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRankDeletionRequest other)
		{
			return true;
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x0028A514 File Offset: 0x00288714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x0028A524 File Offset: 0x00288724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x0028A534 File Offset: 0x00288734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x0028A544 File Offset: 0x00288744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x0028A554 File Offset: 0x00288754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x0028A564 File Offset: 0x00288764
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRankDeletionRequest other)
		{
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x0028A574 File Offset: 0x00288774
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x0028A584 File Offset: 0x00288784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x0028A594 File Offset: 0x00288794
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRankDeletionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_35;
					case 2:
						AllianceRankDeletionRequest._parser = new MessageParser<AllianceRankDeletionRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					return;
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x0028A67C File Offset: 0x0028887C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iM5RAQJKHLmYKcfBMe5e()
		{
			return true;
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x0028A684 File Offset: 0x00288884
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRankDeletionRequest zHbyUiJKY3iBrT1KVQoX()
		{
			return null;
		}

		// Token: 0x04003BE0 RID: 15328
		private static readonly MessageParser<AllianceRankDeletionRequest> _parser;

		// Token: 0x04003BE1 RID: 15329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE2 RID: 15330
		public const int RankIdFieldNumber = 1;

		// Token: 0x04003BE3 RID: 15331
		private int rankId_;

		// Token: 0x04003BE4 RID: 15332
		public const int ReplacementRankIdFieldNumber = 2;

		// Token: 0x04003BE5 RID: 15333
		private int replacementRankId_;

		// Token: 0x04003BE6 RID: 15334
		private static AllianceRankDeletionRequest fF0OELJKpUhTF7HtNqrf;
	}
}
