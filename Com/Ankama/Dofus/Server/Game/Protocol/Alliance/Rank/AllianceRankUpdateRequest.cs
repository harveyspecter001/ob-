using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D29 RID: 3369
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRankUpdateRequest : IMessage<AllianceRankUpdateRequest>, IMessage, IEquatable<AllianceRankUpdateRequest>, IDeepCloneable<AllianceRankUpdateRequest>, IBufferMessage
	{
		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600A237 RID: 41527 RVA: 0x0028A68C File Offset: 0x0028888C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceRankUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x0600A238 RID: 41528 RVA: 0x0028A69C File Offset: 0x0028889C
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

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x0600A239 RID: 41529 RVA: 0x0028A6AC File Offset: 0x002888AC
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

		// Token: 0x0600A23A RID: 41530 RVA: 0x0028A6BC File Offset: 0x002888BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankUpdateRequest()
		{
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x0028A6CC File Offset: 0x002888CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankUpdateRequest(AllianceRankUpdateRequest other)
		{
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x0028A6DC File Offset: 0x002888DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRankUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600A23D RID: 41533 RVA: 0x0028A6EC File Offset: 0x002888EC
		// (set) Token: 0x0600A23E RID: 41534 RVA: 0x0028A6FC File Offset: 0x002888FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RankInformation Rank
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

		// Token: 0x0600A23F RID: 41535 RVA: 0x0028A70C File Offset: 0x0028890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x0028A71C File Offset: 0x0028891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRankUpdateRequest other)
		{
			return true;
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x0028A72C File Offset: 0x0028892C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x0028A73C File Offset: 0x0028893C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x0028A74C File Offset: 0x0028894C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x0028A75C File Offset: 0x0028895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x0028A76C File Offset: 0x0028896C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x0028A77C File Offset: 0x0028897C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRankUpdateRequest other)
		{
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x0028A78C File Offset: 0x0028898C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x0028A79C File Offset: 0x0028899C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x0028A7AC File Offset: 0x002889AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRankUpdateRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AllianceRankUpdateRequest._parser = new MessageParser<AllianceRankUpdateRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x0028A878 File Offset: 0x00288A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LTnWPGJKi2i4K4vGLgME()
		{
			return true;
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x0028A880 File Offset: 0x00288A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRankUpdateRequest TmY6J1JKPYDqUZKyFcma()
		{
			return null;
		}

		// Token: 0x04003BE9 RID: 15337
		private static readonly MessageParser<AllianceRankUpdateRequest> _parser;

		// Token: 0x04003BEA RID: 15338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BEB RID: 15339
		public const int RankFieldNumber = 1;

		// Token: 0x04003BEC RID: 15340
		private RankInformation rank_;

		// Token: 0x04003BED RID: 15341
		internal static AllianceRankUpdateRequest ThwwyCJKbOQY77LqjXpr;
	}
}
