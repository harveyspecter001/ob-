using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank
{
	// Token: 0x020004C8 RID: 1224
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRankRemoveRequest : IMessage<GuildRankRemoveRequest>, IMessage, IEquatable<GuildRankRemoveRequest>, IDeepCloneable<GuildRankRemoveRequest>, IBufferMessage
	{
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x001E3CA8 File Offset: 0x001E1EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildRankRemoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x001E3CB8 File Offset: 0x001E1EB8
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

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x001E3CC8 File Offset: 0x001E1EC8
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

		// Token: 0x06003A82 RID: 14978 RVA: 0x001E3CD8 File Offset: 0x001E1ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankRemoveRequest()
		{
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x001E3CE8 File Offset: 0x001E1EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankRemoveRequest(GuildRankRemoveRequest other)
		{
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x001E3CF8 File Offset: 0x001E1EF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRankRemoveRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x001E3D08 File Offset: 0x001E1F08
		// (set) Token: 0x06003A86 RID: 14982 RVA: 0x001E3D18 File Offset: 0x001E1F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06003A87 RID: 14983 RVA: 0x001E3D28 File Offset: 0x001E1F28
		// (set) Token: 0x06003A88 RID: 14984 RVA: 0x001E3D38 File Offset: 0x001E1F38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NewRankId
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

		// Token: 0x06003A89 RID: 14985 RVA: 0x001E3D48 File Offset: 0x001E1F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x001E3D58 File Offset: 0x001E1F58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRankRemoveRequest other)
		{
			return true;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x001E3D68 File Offset: 0x001E1F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x001E3D78 File Offset: 0x001E1F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x001E3D88 File Offset: 0x001E1F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x001E3D98 File Offset: 0x001E1F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x001E3DA8 File Offset: 0x001E1FA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x001E3DB8 File Offset: 0x001E1FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRankRemoveRequest other)
		{
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x001E3DC8 File Offset: 0x001E1FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x001E3DD8 File Offset: 0x001E1FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x001E3DE8 File Offset: 0x001E1FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRankRemoveRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GuildRankRemoveRequest._parser = new MessageParser<GuildRankRemoveRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x001E3EE0 File Offset: 0x001E20E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xrsxsEOQ7op03ol81X3D()
		{
			return true;
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x001E3EE8 File Offset: 0x001E20E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRankRemoveRequest KxUuKAOQTKpVFJoTIQXY()
		{
			return null;
		}

		// Token: 0x04001451 RID: 5201
		private static readonly MessageParser<GuildRankRemoveRequest> _parser;

		// Token: 0x04001452 RID: 5202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001453 RID: 5203
		public const int RankIdFieldNumber = 1;

		// Token: 0x04001454 RID: 5204
		private int rankId_;

		// Token: 0x04001455 RID: 5205
		public const int NewRankIdFieldNumber = 2;

		// Token: 0x04001456 RID: 5206
		private int newRankId_;

		// Token: 0x04001457 RID: 5207
		private static GuildRankRemoveRequest l711r8OQQEkSMrU5PDqn;
	}
}
