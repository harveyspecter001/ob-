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
	// Token: 0x02000520 RID: 1312
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMotdEvent : IMessage<GuildMotdEvent>, IMessage, IEquatable<GuildMotdEvent>, IDeepCloneable<GuildMotdEvent>, IBufferMessage
	{
		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06003EF4 RID: 16116 RVA: 0x001EBE50 File Offset: 0x001EA050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMotdEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x001EBE60 File Offset: 0x001EA060
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

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06003EF6 RID: 16118 RVA: 0x001EBE70 File Offset: 0x001EA070
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

		// Token: 0x06003EF7 RID: 16119 RVA: 0x001EBE80 File Offset: 0x001EA080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdEvent()
		{
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x001EBE90 File Offset: 0x001EA090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdEvent(GuildMotdEvent other)
		{
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x001EBEA0 File Offset: 0x001EA0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06003EFA RID: 16122 RVA: 0x001EBEB0 File Offset: 0x001EA0B0
		// (set) Token: 0x06003EFB RID: 16123 RVA: 0x001EBEC0 File Offset: 0x001EA0C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialNoticeInformation Motd
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

		// Token: 0x06003EFC RID: 16124 RVA: 0x001EBED0 File Offset: 0x001EA0D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x001EBEE0 File Offset: 0x001EA0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMotdEvent other)
		{
			return true;
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x001EBEF0 File Offset: 0x001EA0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x001EBF00 File Offset: 0x001EA100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x001EBF10 File Offset: 0x001EA110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x001EBF20 File Offset: 0x001EA120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x001EBF30 File Offset: 0x001EA130
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x001EBF40 File Offset: 0x001EA140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMotdEvent other)
		{
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x001EBF50 File Offset: 0x001EA150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x001EBF60 File Offset: 0x001EA160
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x001EBF70 File Offset: 0x001EA170
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMotdEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
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
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					case 3:
						GuildMotdEvent._parser = new MessageParser<GuildMotdEvent>(() => null);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
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
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x001EC040 File Offset: 0x001EA240
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R55XF1OTbK9SwXtqYy1U()
		{
			return true;
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x001EC048 File Offset: 0x001EA248
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMotdEvent xB2EfoOTiauSB8ygsw3r()
		{
			return null;
		}

		// Token: 0x040015D2 RID: 5586
		private static readonly MessageParser<GuildMotdEvent> _parser;

		// Token: 0x040015D3 RID: 5587
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015D4 RID: 5588
		public const int MotdFieldNumber = 1;

		// Token: 0x040015D5 RID: 5589
		private SocialNoticeInformation motd_;

		// Token: 0x040015D6 RID: 5590
		private static GuildMotdEvent S0rQEPOTYTQ6M42QE6PX;
	}
}
