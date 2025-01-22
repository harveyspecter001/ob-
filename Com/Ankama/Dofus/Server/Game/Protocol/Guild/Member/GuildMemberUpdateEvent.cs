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
	// Token: 0x020004D7 RID: 1239
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMemberUpdateEvent : IMessage<GuildMemberUpdateEvent>, IMessage, IEquatable<GuildMemberUpdateEvent>, IDeepCloneable<GuildMemberUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06003B3B RID: 15163 RVA: 0x001E5334 File Offset: 0x001E3534
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildMemberUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x001E5344 File Offset: 0x001E3544
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

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06003B3D RID: 15165 RVA: 0x001E5354 File Offset: 0x001E3554
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

		// Token: 0x06003B3E RID: 15166 RVA: 0x001E5364 File Offset: 0x001E3564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberUpdateEvent()
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x001E5374 File Offset: 0x001E3574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberUpdateEvent(GuildMemberUpdateEvent other)
		{
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x001E5384 File Offset: 0x001E3584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06003B41 RID: 15169 RVA: 0x001E5394 File Offset: 0x001E3594
		// (set) Token: 0x06003B42 RID: 15170 RVA: 0x001E53A4 File Offset: 0x001E35A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character Member
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

		// Token: 0x06003B43 RID: 15171 RVA: 0x001E53B4 File Offset: 0x001E35B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x001E53C4 File Offset: 0x001E35C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMemberUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x001E53D4 File Offset: 0x001E35D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x001E53E4 File Offset: 0x001E35E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x001E53F4 File Offset: 0x001E35F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x001E5404 File Offset: 0x001E3604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x001E5414 File Offset: 0x001E3614
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x001E5424 File Offset: 0x001E3624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMemberUpdateEvent other)
		{
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x001E5434 File Offset: 0x001E3634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x001E5444 File Offset: 0x001E3644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x001E5454 File Offset: 0x001E3654
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMemberUpdateEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GuildMemberUpdateEvent._parser = new MessageParser<GuildMemberUpdateEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x001E5538 File Offset: 0x001E3738
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WvPfmFO7OaBIjr1KD9db()
		{
			return true;
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x001E5540 File Offset: 0x001E3740
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMemberUpdateEvent ewXodVO7JXnFM3yPtGSi()
		{
			return null;
		}

		// Token: 0x0400148A RID: 5258
		private static readonly MessageParser<GuildMemberUpdateEvent> _parser;

		// Token: 0x0400148B RID: 5259
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400148C RID: 5260
		public const int MemberFieldNumber = 1;

		// Token: 0x0400148D RID: 5261
		private Character member_;

		// Token: 0x0400148E RID: 5262
		internal static GuildMemberUpdateEvent Sle9ogO7R9g3cuME5aBW;
	}
}
