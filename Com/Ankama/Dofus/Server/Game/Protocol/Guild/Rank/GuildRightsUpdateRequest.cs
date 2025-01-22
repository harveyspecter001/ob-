using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Rank
{
	// Token: 0x020004C6 RID: 1222
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRightsUpdateRequest : IMessage<GuildRightsUpdateRequest>, IMessage, IEquatable<GuildRightsUpdateRequest>, IDeepCloneable<GuildRightsUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x001E3A50 File Offset: 0x001E1C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildRightsUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x001E3A60 File Offset: 0x001E1C60
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

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x001E3A70 File Offset: 0x001E1C70
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

		// Token: 0x06003A67 RID: 14951 RVA: 0x001E3A80 File Offset: 0x001E1C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRightsUpdateRequest()
		{
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x001E3A90 File Offset: 0x001E1C90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRightsUpdateRequest(GuildRightsUpdateRequest other)
		{
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x001E3AA0 File Offset: 0x001E1CA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRightsUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x001E3AB0 File Offset: 0x001E1CB0
		// (set) Token: 0x06003A6B RID: 14955 RVA: 0x001E3AC0 File Offset: 0x001E1CC0
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

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x001E3AD0 File Offset: 0x001E1CD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> Rights
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x001E3AE0 File Offset: 0x001E1CE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x001E3AF0 File Offset: 0x001E1CF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRightsUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x001E3B00 File Offset: 0x001E1D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x001E3B10 File Offset: 0x001E1D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x001E3B20 File Offset: 0x001E1D20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x001E3B30 File Offset: 0x001E1D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x001E3B40 File Offset: 0x001E1D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x001E3B50 File Offset: 0x001E1D50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRightsUpdateRequest other)
		{
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x001E3B60 File Offset: 0x001E1D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x001E3B70 File Offset: 0x001E1D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x001E3B80 File Offset: 0x001E1D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRightsUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					GuildRightsUpdateRequest._repeated_rights_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					GuildRightsUpdateRequest._parser = new MessageParser<GuildRightsUpdateRequest>(() => null);
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x001E3C98 File Offset: 0x001E1E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CRxqYDOQtgLJdt1ToDSF()
		{
			return true;
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x001E3CA0 File Offset: 0x001E1EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRightsUpdateRequest WL0btlOQw3dDeACUE8ph()
		{
			return null;
		}

		// Token: 0x04001447 RID: 5191
		private static readonly MessageParser<GuildRightsUpdateRequest> _parser;

		// Token: 0x04001448 RID: 5192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001449 RID: 5193
		public const int RankIdFieldNumber = 1;

		// Token: 0x0400144A RID: 5194
		private int rankId_;

		// Token: 0x0400144B RID: 5195
		public const int RightsFieldNumber = 2;

		// Token: 0x0400144C RID: 5196
		private static readonly FieldCodec<int> _repeated_rights_codec;

		// Token: 0x0400144D RID: 5197
		private readonly RepeatedField<int> rights_;

		// Token: 0x0400144E RID: 5198
		private static GuildRightsUpdateRequest RnWo95OQDerwDcEynHiw;
	}
}
