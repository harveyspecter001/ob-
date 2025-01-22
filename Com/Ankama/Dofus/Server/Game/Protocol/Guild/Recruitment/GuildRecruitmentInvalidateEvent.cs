using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Recruitment
{
	// Token: 0x020004BB RID: 1211
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRecruitmentInvalidateEvent : IMessage<GuildRecruitmentInvalidateEvent>, IMessage, IEquatable<GuildRecruitmentInvalidateEvent>, IDeepCloneable<GuildRecruitmentInvalidateEvent>, IBufferMessage
	{
		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x001E29F0 File Offset: 0x001E0BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildRecruitmentInvalidateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x001E2A00 File Offset: 0x001E0C00
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

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x001E2A10 File Offset: 0x001E0C10
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

		// Token: 0x060039E2 RID: 14818 RVA: 0x001E2A20 File Offset: 0x001E0C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentInvalidateEvent()
		{
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x001E2A30 File Offset: 0x001E0C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentInvalidateEvent(GuildRecruitmentInvalidateEvent other)
		{
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x001E2A40 File Offset: 0x001E0C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentInvalidateEvent Clone()
		{
			return null;
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x001E2A50 File Offset: 0x001E0C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x001E2A60 File Offset: 0x001E0C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRecruitmentInvalidateEvent other)
		{
			return true;
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x001E2A70 File Offset: 0x001E0C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x001E2A80 File Offset: 0x001E0C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x001E2A90 File Offset: 0x001E0C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x001E2AA0 File Offset: 0x001E0CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x001E2AB0 File Offset: 0x001E0CB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x001E2AC0 File Offset: 0x001E0CC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRecruitmentInvalidateEvent other)
		{
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x001E2AD0 File Offset: 0x001E0CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x001E2AE0 File Offset: 0x001E0CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x001E2AF0 File Offset: 0x001E0CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRecruitmentInvalidateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildRecruitmentInvalidateEvent._parser = new MessageParser<GuildRecruitmentInvalidateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x001E2BBC File Offset: 0x001E0DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V1ujx6OQlv169ygGUqvw()
		{
			return true;
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x001E2BC4 File Offset: 0x001E0DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRecruitmentInvalidateEvent iLIs5HOQc5geSkuHrvuu()
		{
			return null;
		}

		// Token: 0x04001421 RID: 5153
		private static readonly MessageParser<GuildRecruitmentInvalidateEvent> _parser;

		// Token: 0x04001422 RID: 5154
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001423 RID: 5155
		internal static GuildRecruitmentInvalidateEvent bgWPZbOQkDXV8JOOTunC;
	}
}
