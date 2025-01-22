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
	// Token: 0x020004F2 RID: 1266
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildCreationValidRequest : IMessage<GuildCreationValidRequest>, IMessage, IEquatable<GuildCreationValidRequest>, IDeepCloneable<GuildCreationValidRequest>, IBufferMessage
	{
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x001E8C3C File Offset: 0x001E6E3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildCreationValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06003C81 RID: 15489 RVA: 0x001E8C4C File Offset: 0x001E6E4C
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

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x001E8C5C File Offset: 0x001E6E5C
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

		// Token: 0x06003C83 RID: 15491 RVA: 0x001E8C6C File Offset: 0x001E6E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationValidRequest()
		{
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x001E8C7C File Offset: 0x001E6E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationValidRequest(GuildCreationValidRequest other)
		{
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x001E8C8C File Offset: 0x001E6E8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildCreationValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x001E8C9C File Offset: 0x001E6E9C
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x001E8CAC File Offset: 0x001E6EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06003C88 RID: 15496 RVA: 0x001E8CBC File Offset: 0x001E6EBC
		// (set) Token: 0x06003C89 RID: 15497 RVA: 0x001E8CCC File Offset: 0x001E6ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialEmblem Emblem
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

		// Token: 0x06003C8A RID: 15498 RVA: 0x001E8CDC File Offset: 0x001E6EDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x001E8CEC File Offset: 0x001E6EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildCreationValidRequest other)
		{
			return true;
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x001E8CFC File Offset: 0x001E6EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x001E8D0C File Offset: 0x001E6F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x001E8D1C File Offset: 0x001E6F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x001E8D2C File Offset: 0x001E6F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x001E8D3C File Offset: 0x001E6F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x001E8D4C File Offset: 0x001E6F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildCreationValidRequest other)
		{
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x001E8D5C File Offset: 0x001E6F5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x001E8D6C File Offset: 0x001E6F6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x001E8D7C File Offset: 0x001E6F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildCreationValidRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					GuildCreationValidRequest._parser = new MessageParser<GuildCreationValidRequest>(() => null);
					num2 = 3;
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x001E8E48 File Offset: 0x001E7048
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WOCTafO7wL3fXrPAaB28()
		{
			return true;
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x001E8E50 File Offset: 0x001E7050
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildCreationValidRequest OU7wjAO7QWwpWJixsV2V()
		{
			return null;
		}

		// Token: 0x0400150B RID: 5387
		private static readonly MessageParser<GuildCreationValidRequest> _parser;

		// Token: 0x0400150C RID: 5388
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400150D RID: 5389
		public const int NameFieldNumber = 1;

		// Token: 0x0400150E RID: 5390
		private string name_;

		// Token: 0x0400150F RID: 5391
		public const int EmblemFieldNumber = 2;

		// Token: 0x04001510 RID: 5392
		private SocialEmblem emblem_;

		// Token: 0x04001511 RID: 5393
		private static GuildCreationValidRequest WgDIQrO7tiUhdWo0l24i;
	}
}
