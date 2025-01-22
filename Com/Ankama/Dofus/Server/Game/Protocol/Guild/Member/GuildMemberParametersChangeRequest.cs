using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004CD RID: 1229
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMemberParametersChangeRequest : IMessage<GuildMemberParametersChangeRequest>, IMessage, IEquatable<GuildMemberParametersChangeRequest>, IDeepCloneable<GuildMemberParametersChangeRequest>, IBufferMessage
	{
		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x001E48CC File Offset: 0x001E2ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMemberParametersChangeRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x001E48DC File Offset: 0x001E2ADC
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

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x001E48EC File Offset: 0x001E2AEC
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

		// Token: 0x06003ABB RID: 15035 RVA: 0x001E48FC File Offset: 0x001E2AFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberParametersChangeRequest()
		{
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x001E490C File Offset: 0x001E2B0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberParametersChangeRequest(GuildMemberParametersChangeRequest other)
		{
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x001E491C File Offset: 0x001E2B1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberParametersChangeRequest Clone()
		{
			return null;
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x001E492C File Offset: 0x001E2B2C
		// (set) Token: 0x06003ABF RID: 15039 RVA: 0x001E493C File Offset: 0x001E2B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MemberId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x001E494C File Offset: 0x001E2B4C
		// (set) Token: 0x06003AC1 RID: 15041 RVA: 0x001E495C File Offset: 0x001E2B5C
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

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06003AC2 RID: 15042 RVA: 0x001E496C File Offset: 0x001E2B6C
		// (set) Token: 0x06003AC3 RID: 15043 RVA: 0x001E497C File Offset: 0x001E2B7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ExperienceGivenPercent
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

		// Token: 0x06003AC4 RID: 15044 RVA: 0x001E498C File Offset: 0x001E2B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x001E499C File Offset: 0x001E2B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMemberParametersChangeRequest other)
		{
			return true;
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x001E49AC File Offset: 0x001E2BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x001E49BC File Offset: 0x001E2BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x001E49CC File Offset: 0x001E2BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x001E49DC File Offset: 0x001E2BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x001E49EC File Offset: 0x001E2BEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x001E49FC File Offset: 0x001E2BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMemberParametersChangeRequest other)
		{
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x001E4A0C File Offset: 0x001E2C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x001E4A1C File Offset: 0x001E2C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x001E4A2C File Offset: 0x001E2C2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMemberParametersChangeRequest()
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
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					GuildMemberParametersChangeRequest._parser = new MessageParser<GuildMemberParametersChangeRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x001E4AF8 File Offset: 0x001E2CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yef7mNOQMKHVhOBlZKBh()
		{
			return true;
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x001E4B00 File Offset: 0x001E2D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMemberParametersChangeRequest esSsFpOQuZR7GWQoKh3L()
		{
			return null;
		}

		// Token: 0x04001464 RID: 5220
		private static readonly MessageParser<GuildMemberParametersChangeRequest> _parser;

		// Token: 0x04001465 RID: 5221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001466 RID: 5222
		public const int MemberIdFieldNumber = 1;

		// Token: 0x04001467 RID: 5223
		private long memberId_;

		// Token: 0x04001468 RID: 5224
		public const int RankIdFieldNumber = 2;

		// Token: 0x04001469 RID: 5225
		private int rankId_;

		// Token: 0x0400146A RID: 5226
		public const int ExperienceGivenPercentFieldNumber = 3;

		// Token: 0x0400146B RID: 5227
		private int experienceGivenPercent_;

		// Token: 0x0400146C RID: 5228
		private static GuildMemberParametersChangeRequest II8UPeOQSqZG92tuuV6B;
	}
}
