using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x020004F4 RID: 1268
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildInvitationRequest : IMessage<GuildInvitationRequest>, IMessage, IEquatable<GuildInvitationRequest>, IDeepCloneable<GuildInvitationRequest>, IBufferMessage
	{
		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06003C9C RID: 15516 RVA: 0x001E8E58 File Offset: 0x001E7058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildInvitationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x001E8E68 File Offset: 0x001E7068
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

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06003C9E RID: 15518 RVA: 0x001E8E78 File Offset: 0x001E7078
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

		// Token: 0x06003C9F RID: 15519 RVA: 0x001E8E88 File Offset: 0x001E7088
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationRequest()
		{
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x001E8E98 File Offset: 0x001E7098
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationRequest(GuildInvitationRequest other)
		{
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x001E8EA8 File Offset: 0x001E70A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationRequest Clone()
		{
			return null;
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06003CA2 RID: 15522 RVA: 0x001E8EB8 File Offset: 0x001E70B8
		// (set) Token: 0x06003CA3 RID: 15523 RVA: 0x001E8EC8 File Offset: 0x001E70C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long TargetId
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

		// Token: 0x06003CA4 RID: 15524 RVA: 0x001E8ED8 File Offset: 0x001E70D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x001E8EE8 File Offset: 0x001E70E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildInvitationRequest other)
		{
			return true;
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x001E8EF8 File Offset: 0x001E70F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x001E8F08 File Offset: 0x001E7108
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x001E8F18 File Offset: 0x001E7118
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x001E8F28 File Offset: 0x001E7128
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x001E8F38 File Offset: 0x001E7138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x001E8F48 File Offset: 0x001E7148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildInvitationRequest other)
		{
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x001E8F58 File Offset: 0x001E7158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x001E8F68 File Offset: 0x001E7168
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x001E8F78 File Offset: 0x001E7178
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildInvitationRequest()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				GuildInvitationRequest._parser = new MessageParser<GuildInvitationRequest>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x001E905C File Offset: 0x001E725C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TB0Td0O7TdwSHrxtsi9v()
		{
			return true;
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x001E9064 File Offset: 0x001E7264
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildInvitationRequest FPJCIkO7pwVPDTptnMjQ()
		{
			return null;
		}

		// Token: 0x04001514 RID: 5396
		private static readonly MessageParser<GuildInvitationRequest> _parser;

		// Token: 0x04001515 RID: 5397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001516 RID: 5398
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04001517 RID: 5399
		private long targetId_;

		// Token: 0x04001518 RID: 5400
		internal static GuildInvitationRequest wyCoP5O771VSWjYdFjCA;
	}
}
