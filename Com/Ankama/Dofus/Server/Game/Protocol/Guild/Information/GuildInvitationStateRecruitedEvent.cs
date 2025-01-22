using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000516 RID: 1302
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildInvitationStateRecruitedEvent : IMessage<GuildInvitationStateRecruitedEvent>, IMessage, IEquatable<GuildInvitationStateRecruitedEvent>, IDeepCloneable<GuildInvitationStateRecruitedEvent>, IBufferMessage
	{
		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x001EB310 File Offset: 0x001E9510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildInvitationStateRecruitedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x001EB320 File Offset: 0x001E9520
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

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06003E65 RID: 15973 RVA: 0x001EB330 File Offset: 0x001E9530
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

		// Token: 0x06003E66 RID: 15974 RVA: 0x001EB340 File Offset: 0x001E9540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationStateRecruitedEvent()
		{
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x001EB350 File Offset: 0x001E9550
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationStateRecruitedEvent(GuildInvitationStateRecruitedEvent other)
		{
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x001EB360 File Offset: 0x001E9560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationStateRecruitedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x001EB370 File Offset: 0x001E9570
		// (set) Token: 0x06003E6A RID: 15978 RVA: 0x001EB384 File Offset: 0x001E9584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialGroupInvitationState InvitationState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialGroupInvitationState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x001EB394 File Offset: 0x001E9594
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x001EB3A4 File Offset: 0x001E95A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildInvitationStateRecruitedEvent other)
		{
			return true;
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x001EB3B4 File Offset: 0x001E95B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x001EB3C4 File Offset: 0x001E95C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x001EB3D4 File Offset: 0x001E95D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x001EB3E4 File Offset: 0x001E95E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x001EB3F4 File Offset: 0x001E95F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x001EB404 File Offset: 0x001E9604
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildInvitationStateRecruitedEvent other)
		{
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x001EB414 File Offset: 0x001E9614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x001EB424 File Offset: 0x001E9624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x001EB434 File Offset: 0x001E9634
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildInvitationStateRecruitedEvent()
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
					default:
						goto IL_35;
					case 1:
						return;
					case 2:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						break;
					case 4:
						GuildInvitationStateRecruitedEvent._parser = new MessageParser<GuildInvitationStateRecruitedEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_35:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x001EB504 File Offset: 0x001E9704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wvvVdWOTWNn12fH3wkBo()
		{
			return true;
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x001EB50C File Offset: 0x001E970C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildInvitationStateRecruitedEvent oqYULGOThqUuBUvUIQZM()
		{
			return null;
		}

		// Token: 0x0400159E RID: 5534
		private static readonly MessageParser<GuildInvitationStateRecruitedEvent> _parser;

		// Token: 0x0400159F RID: 5535
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015A0 RID: 5536
		public const int InvitationStateFieldNumber = 1;

		// Token: 0x040015A1 RID: 5537
		private SocialGroupInvitationState invitationState_;

		// Token: 0x040015A2 RID: 5538
		private static GuildInvitationStateRecruitedEvent po9URfOTLovFh0EcTWg2;
	}
}
