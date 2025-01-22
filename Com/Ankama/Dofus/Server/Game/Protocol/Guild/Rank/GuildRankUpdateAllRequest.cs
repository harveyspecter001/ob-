using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank
{
	// Token: 0x020004C2 RID: 1218
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRankUpdateAllRequest : IMessage<GuildRankUpdateAllRequest>, IMessage, IEquatable<GuildRankUpdateAllRequest>, IDeepCloneable<GuildRankUpdateAllRequest>, IBufferMessage
	{
		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x001E3600 File Offset: 0x001E1800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildRankUpdateAllRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x001E3610 File Offset: 0x001E1810
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

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x001E3620 File Offset: 0x001E1820
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

		// Token: 0x06003A34 RID: 14900 RVA: 0x001E3630 File Offset: 0x001E1830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankUpdateAllRequest()
		{
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x001E3640 File Offset: 0x001E1840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankUpdateAllRequest(GuildRankUpdateAllRequest other)
		{
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x001E3650 File Offset: 0x001E1850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankUpdateAllRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06003A37 RID: 14903 RVA: 0x001E3660 File Offset: 0x001E1860
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

		// Token: 0x06003A38 RID: 14904 RVA: 0x001E3670 File Offset: 0x001E1870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x001E3680 File Offset: 0x001E1880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRankUpdateAllRequest other)
		{
			return true;
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x001E3690 File Offset: 0x001E1890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x001E36A0 File Offset: 0x001E18A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x001E36B0 File Offset: 0x001E18B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x001E36C0 File Offset: 0x001E18C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x001E36D0 File Offset: 0x001E18D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x001E36E0 File Offset: 0x001E18E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRankUpdateAllRequest other)
		{
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x001E36F0 File Offset: 0x001E18F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x001E3700 File Offset: 0x001E1900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x001E3710 File Offset: 0x001E1910
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRankUpdateAllRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					GuildRankUpdateAllRequest._repeated_ranks_codec = FieldCodec.ForMessage<RankInformation>(10U, Q43ygLm2FgeO01lX3DCQ.XVInXhlssT(Q43ygLm2FgeO01lX3DCQ.hZLm2zjbuQy));
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					GuildRankUpdateAllRequest._parser = new MessageParser<GuildRankUpdateAllRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x001E3818 File Offset: 0x001E1A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o14WBnOQhlQE8et8GUna()
		{
			return true;
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x001E3820 File Offset: 0x001E1A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRankUpdateAllRequest bbQMeQOQrW4umBAJObst()
		{
			return null;
		}

		// Token: 0x04001438 RID: 5176
		private static readonly MessageParser<GuildRankUpdateAllRequest> _parser;

		// Token: 0x04001439 RID: 5177
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400143A RID: 5178
		public const int RanksFieldNumber = 1;

		// Token: 0x0400143B RID: 5179
		private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

		// Token: 0x0400143C RID: 5180
		private readonly RepeatedField<RankInformation> ranks_;

		// Token: 0x0400143D RID: 5181
		internal static GuildRankUpdateAllRequest QqSS50OQWLHxSEYeItvT;
	}
}
