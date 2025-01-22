using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004DD RID: 1245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMembershipEvent : IMessage<GuildMembershipEvent>, IMessage, IEquatable<GuildMembershipEvent>, IDeepCloneable<GuildMembershipEvent>, IBufferMessage
	{
		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003B89 RID: 15241 RVA: 0x001E5970 File Offset: 0x001E3B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMembershipEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x001E5980 File Offset: 0x001E3B80
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

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003B8B RID: 15243 RVA: 0x001E5990 File Offset: 0x001E3B90
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

		// Token: 0x06003B8C RID: 15244 RVA: 0x001E59A0 File Offset: 0x001E3BA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMembershipEvent()
		{
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x001E59B0 File Offset: 0x001E3BB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMembershipEvent(GuildMembershipEvent other)
		{
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x001E59C0 File Offset: 0x001E3BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMembershipEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003B8F RID: 15247 RVA: 0x001E59D0 File Offset: 0x001E3BD0
		// (set) Token: 0x06003B90 RID: 15248 RVA: 0x001E59E0 File Offset: 0x001E3BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildInformation GuildInformation
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

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003B91 RID: 15249 RVA: 0x001E59F0 File Offset: 0x001E3BF0
		// (set) Token: 0x06003B92 RID: 15250 RVA: 0x001E5A00 File Offset: 0x001E3C00
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

		// Token: 0x06003B93 RID: 15251 RVA: 0x001E5A10 File Offset: 0x001E3C10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x001E5A20 File Offset: 0x001E3C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMembershipEvent other)
		{
			return true;
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x001E5A30 File Offset: 0x001E3C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x001E5A40 File Offset: 0x001E3C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x001E5A50 File Offset: 0x001E3C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x001E5A60 File Offset: 0x001E3C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x001E5A70 File Offset: 0x001E3C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x001E5A80 File Offset: 0x001E3C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMembershipEvent other)
		{
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x001E5A90 File Offset: 0x001E3C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x001E5AA0 File Offset: 0x001E3CA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x001E5AB0 File Offset: 0x001E3CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMembershipEvent()
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
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					GuildMembershipEvent._parser = new MessageParser<GuildMembershipEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x001E5B7C File Offset: 0x001E3D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cqi9q9O7Xr5RymSDi83C()
		{
			return true;
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x001E5B84 File Offset: 0x001E3D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMembershipEvent rDKmR6O7NIucL3GpZilF()
		{
			return null;
		}

		// Token: 0x0400149F RID: 5279
		private static readonly MessageParser<GuildMembershipEvent> _parser;

		// Token: 0x040014A0 RID: 5280
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014A1 RID: 5281
		public const int GuildInformationFieldNumber = 1;

		// Token: 0x040014A2 RID: 5282
		private GuildInformation guildInformation_;

		// Token: 0x040014A3 RID: 5283
		public const int RankIdFieldNumber = 2;

		// Token: 0x040014A4 RID: 5284
		private int rankId_;

		// Token: 0x040014A5 RID: 5285
		private static GuildMembershipEvent gwUwpvO7EYr0GDNYSt9h;
	}
}
