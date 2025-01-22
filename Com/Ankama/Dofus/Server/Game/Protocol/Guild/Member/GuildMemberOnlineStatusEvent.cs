using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Member
{
	// Token: 0x020004D3 RID: 1235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMemberOnlineStatusEvent : IMessage<GuildMemberOnlineStatusEvent>, IMessage, IEquatable<GuildMemberOnlineStatusEvent>, IDeepCloneable<GuildMemberOnlineStatusEvent>, IBufferMessage
	{
		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x001E4F04 File Offset: 0x001E3104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMemberOnlineStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x001E4F14 File Offset: 0x001E3114
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

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x001E4F24 File Offset: 0x001E3124
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

		// Token: 0x06003B09 RID: 15113 RVA: 0x001E4F34 File Offset: 0x001E3134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberOnlineStatusEvent()
		{
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x001E4F44 File Offset: 0x001E3144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberOnlineStatusEvent(GuildMemberOnlineStatusEvent other)
		{
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x001E4F54 File Offset: 0x001E3154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMemberOnlineStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x001E4F64 File Offset: 0x001E3164
		// (set) Token: 0x06003B0D RID: 15117 RVA: 0x001E4F74 File Offset: 0x001E3174
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

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x001E4F84 File Offset: 0x001E3184
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x001E4F94 File Offset: 0x001E3194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Online
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x001E4FA4 File Offset: 0x001E31A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x001E4FB4 File Offset: 0x001E31B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMemberOnlineStatusEvent other)
		{
			return true;
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x001E4FC4 File Offset: 0x001E31C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x001E4FD4 File Offset: 0x001E31D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x001E4FE4 File Offset: 0x001E31E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x001E4FF4 File Offset: 0x001E31F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x001E5004 File Offset: 0x001E3204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x001E5014 File Offset: 0x001E3214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMemberOnlineStatusEvent other)
		{
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x001E5024 File Offset: 0x001E3224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x001E5034 File Offset: 0x001E3234
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x001E5044 File Offset: 0x001E3244
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMemberOnlineStatusEvent()
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
					GuildMemberOnlineStatusEvent._parser = new MessageParser<GuildMemberOnlineStatusEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x001E5110 File Offset: 0x001E3310
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RKYgtlO7mQUtijFfJqJn()
		{
			return true;
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x001E5118 File Offset: 0x001E3318
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMemberOnlineStatusEvent ULu4wRO7AhC3Axj99l2V()
		{
			return null;
		}

		// Token: 0x04001479 RID: 5241
		private static readonly MessageParser<GuildMemberOnlineStatusEvent> _parser;

		// Token: 0x0400147A RID: 5242
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400147B RID: 5243
		public const int MemberIdFieldNumber = 1;

		// Token: 0x0400147C RID: 5244
		private long memberId_;

		// Token: 0x0400147D RID: 5245
		public const int OnlineFieldNumber = 2;

		// Token: 0x0400147E RID: 5246
		private bool online_;

		// Token: 0x0400147F RID: 5247
		private static GuildMemberOnlineStatusEvent XAn7RFO7nRuIx7d2Yd3g;
	}
}
