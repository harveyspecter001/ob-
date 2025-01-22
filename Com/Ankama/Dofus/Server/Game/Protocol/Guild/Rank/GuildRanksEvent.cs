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
	// Token: 0x020004CA RID: 1226
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRanksEvent : IMessage<GuildRanksEvent>, IMessage, IEquatable<GuildRanksEvent>, IDeepCloneable<GuildRanksEvent>, IBufferMessage
	{
		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x001E3EF0 File Offset: 0x001E20F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildRanksEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x001E3F00 File Offset: 0x001E2100
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

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06003A9D RID: 15005 RVA: 0x001E3F10 File Offset: 0x001E2110
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

		// Token: 0x06003A9E RID: 15006 RVA: 0x001E3F20 File Offset: 0x001E2120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRanksEvent()
		{
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x001E3F30 File Offset: 0x001E2130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRanksEvent(GuildRanksEvent other)
		{
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x001E3F40 File Offset: 0x001E2140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRanksEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x001E3F50 File Offset: 0x001E2150
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

		// Token: 0x06003AA2 RID: 15010 RVA: 0x001E3F60 File Offset: 0x001E2160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x001E3F70 File Offset: 0x001E2170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRanksEvent other)
		{
			return true;
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x001E3F80 File Offset: 0x001E2180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x001E3F90 File Offset: 0x001E2190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x001E3FA0 File Offset: 0x001E21A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x001E3FB0 File Offset: 0x001E21B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x001E3FC0 File Offset: 0x001E21C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x001E3FD0 File Offset: 0x001E21D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRanksEvent other)
		{
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x001E3FE0 File Offset: 0x001E21E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x001E3FF0 File Offset: 0x001E21F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x001E4000 File Offset: 0x001E2200
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRanksEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_6E;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						continue;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						GuildRanksEvent._repeated_ranks_codec = FieldCodec.ForMessage<RankInformation>(10U, Q43ygLm2FgeO01lX3DCQ.XVInXhlssT(Q43ygLm2FgeO01lX3DCQ.hZLm2zjbuQy));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_6E:
				GuildRanksEvent._parser = new MessageParser<GuildRanksEvent>(() => null);
				num = 5;
			}
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x001E410C File Offset: 0x001E230C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GVOeIdOQHV9xxFlvBDkP()
		{
			return true;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x001E4114 File Offset: 0x001E2314
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRanksEvent eF1HgYOQY1f2jWNmcSBg()
		{
			return null;
		}

		// Token: 0x0400145A RID: 5210
		private static readonly MessageParser<GuildRanksEvent> _parser;

		// Token: 0x0400145B RID: 5211
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400145C RID: 5212
		public const int RanksFieldNumber = 1;

		// Token: 0x0400145D RID: 5213
		private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

		// Token: 0x0400145E RID: 5214
		private readonly RepeatedField<RankInformation> ranks_;

		// Token: 0x0400145F RID: 5215
		private static GuildRanksEvent qgcnSAOQpQ90arXHVhA8;
	}
}
