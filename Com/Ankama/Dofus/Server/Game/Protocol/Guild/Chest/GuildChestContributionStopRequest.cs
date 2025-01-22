using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest
{
	// Token: 0x0200053C RID: 1340
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildChestContributionStopRequest : IMessage<GuildChestContributionStopRequest>, IMessage, IEquatable<GuildChestContributionStopRequest>, IDeepCloneable<GuildChestContributionStopRequest>, IBufferMessage
	{
		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06004055 RID: 16469 RVA: 0x001EE738 File Offset: 0x001EC938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildChestContributionStopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x001EE748 File Offset: 0x001EC948
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

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x001EE758 File Offset: 0x001EC958
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

		// Token: 0x06004058 RID: 16472 RVA: 0x001EE768 File Offset: 0x001EC968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestContributionStopRequest()
		{
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x001EE778 File Offset: 0x001EC978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestContributionStopRequest(GuildChestContributionStopRequest other)
		{
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x001EE788 File Offset: 0x001EC988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildChestContributionStopRequest Clone()
		{
			return null;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x001EE798 File Offset: 0x001EC998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x001EE7A8 File Offset: 0x001EC9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildChestContributionStopRequest other)
		{
			return true;
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x001EE7B8 File Offset: 0x001EC9B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x001EE7C8 File Offset: 0x001EC9C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x001EE7D8 File Offset: 0x001EC9D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x001EE7E8 File Offset: 0x001EC9E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x001EE7F8 File Offset: 0x001EC9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x001EE808 File Offset: 0x001ECA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildChestContributionStopRequest other)
		{
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x001EE818 File Offset: 0x001ECA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x001EE828 File Offset: 0x001ECA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x001EE838 File Offset: 0x001ECA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildChestContributionStopRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					GuildChestContributionStopRequest._parser = new MessageParser<GuildChestContributionStopRequest>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x001EE904 File Offset: 0x001ECB04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tZ8KPmOp6vuVA8UMHrb8()
		{
			return true;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x001EE90C File Offset: 0x001ECB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildChestContributionStopRequest vFtalnOpL8800cDiwehQ()
		{
			return null;
		}

		// Token: 0x0400163E RID: 5694
		private static readonly MessageParser<GuildChestContributionStopRequest> _parser;

		// Token: 0x0400163F RID: 5695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001640 RID: 5696
		private static GuildChestContributionStopRequest Cx2y90OpyRip2rQb8JQ9;
	}
}
