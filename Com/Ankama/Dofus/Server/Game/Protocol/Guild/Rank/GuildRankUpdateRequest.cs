using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank
{
	// Token: 0x020004C4 RID: 1220
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRankUpdateRequest : IMessage<GuildRankUpdateRequest>, IMessage, IEquatable<GuildRankUpdateRequest>, IDeepCloneable<GuildRankUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06003A4A RID: 14922 RVA: 0x001E3828 File Offset: 0x001E1A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildRankUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x001E3838 File Offset: 0x001E1A38
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

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x001E3848 File Offset: 0x001E1A48
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

		// Token: 0x06003A4D RID: 14925 RVA: 0x001E3858 File Offset: 0x001E1A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankUpdateRequest()
		{
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x001E3868 File Offset: 0x001E1A68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankUpdateRequest(GuildRankUpdateRequest other)
		{
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x001E3878 File Offset: 0x001E1A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x001E3888 File Offset: 0x001E1A88
		// (set) Token: 0x06003A51 RID: 14929 RVA: 0x001E3898 File Offset: 0x001E1A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06003A52 RID: 14930 RVA: 0x001E38A8 File Offset: 0x001E1AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x001E38B8 File Offset: 0x001E1AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRankUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x001E38C8 File Offset: 0x001E1AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x001E38D8 File Offset: 0x001E1AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x001E38E8 File Offset: 0x001E1AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x001E38F8 File Offset: 0x001E1AF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003A58 RID: 14936 RVA: 0x001E3908 File Offset: 0x001E1B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003A59 RID: 14937 RVA: 0x001E3918 File Offset: 0x001E1B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRankUpdateRequest other)
		{
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x001E3928 File Offset: 0x001E1B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x001E3938 File Offset: 0x001E1B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x001E3948 File Offset: 0x001E1B48
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRankUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					GuildRankUpdateRequest._parser = new MessageParser<GuildRankUpdateRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x001E3A40 File Offset: 0x001E1C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gx2o8FOQ0k8IwxP44w8v()
		{
			return true;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x001E3A48 File Offset: 0x001E1C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRankUpdateRequest IZPCYZOQC2joEgSsffcn()
		{
			return null;
		}

		// Token: 0x04001440 RID: 5184
		private static readonly MessageParser<GuildRankUpdateRequest> _parser;

		// Token: 0x04001441 RID: 5185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001442 RID: 5186
		public const int RankFieldNumber = 1;

		// Token: 0x04001443 RID: 5187
		private RankInformation rank_;

		// Token: 0x04001444 RID: 5188
		internal static GuildRankUpdateRequest xQaZmhOQVYsOI6w9liCe;
	}
}
