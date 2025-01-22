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
	// Token: 0x020004F0 RID: 1264
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildModificationValidRequest : IMessage<GuildModificationValidRequest>, IMessage, IEquatable<GuildModificationValidRequest>, IDeepCloneable<GuildModificationValidRequest>, IBufferMessage
	{
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x001E89F4 File Offset: 0x001E6BF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildModificationValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x001E8A04 File Offset: 0x001E6C04
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

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06003C66 RID: 15462 RVA: 0x001E8A14 File Offset: 0x001E6C14
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

		// Token: 0x06003C67 RID: 15463 RVA: 0x001E8A24 File Offset: 0x001E6C24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationValidRequest()
		{
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x001E8A34 File Offset: 0x001E6C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationValidRequest(GuildModificationValidRequest other)
		{
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x001E8A44 File Offset: 0x001E6C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildModificationValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06003C6A RID: 15466 RVA: 0x001E8A54 File Offset: 0x001E6C54
		// (set) Token: 0x06003C6B RID: 15467 RVA: 0x001E8A64 File Offset: 0x001E6C64
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

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x001E8A74 File Offset: 0x001E6C74
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x001E8A84 File Offset: 0x001E6C84
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

		// Token: 0x06003C6E RID: 15470 RVA: 0x001E8A94 File Offset: 0x001E6C94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x001E8AA4 File Offset: 0x001E6CA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildModificationValidRequest other)
		{
			return true;
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x001E8AB4 File Offset: 0x001E6CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x001E8AC4 File Offset: 0x001E6CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x001E8AD4 File Offset: 0x001E6CD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x001E8AE4 File Offset: 0x001E6CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x001E8AF4 File Offset: 0x001E6CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x001E8B04 File Offset: 0x001E6D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildModificationValidRequest other)
		{
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x001E8B14 File Offset: 0x001E6D14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x001E8B24 File Offset: 0x001E6D24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x001E8B34 File Offset: 0x001E6D34
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildModificationValidRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					GuildModificationValidRequest._parser = new MessageParser<GuildModificationValidRequest>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b != 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8bcddcd5652944108a7732b451ab482c != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x001E8C2C File Offset: 0x001E6E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool USbPw2O7CE9UWOcVcGGF()
		{
			return true;
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x001E8C34 File Offset: 0x001E6E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildModificationValidRequest dWcEHnO7D7t0KBYyKSRX()
		{
			return null;
		}

		// Token: 0x04001502 RID: 5378
		private static readonly MessageParser<GuildModificationValidRequest> _parser;

		// Token: 0x04001503 RID: 5379
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001504 RID: 5380
		public const int NameFieldNumber = 1;

		// Token: 0x04001505 RID: 5381
		private string name_;

		// Token: 0x04001506 RID: 5382
		public const int EmblemFieldNumber = 2;

		// Token: 0x04001507 RID: 5383
		private SocialEmblem emblem_;

		// Token: 0x04001508 RID: 5384
		private static GuildModificationValidRequest SC74pMO70kinKktreigY;
	}
}
