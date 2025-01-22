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
	// Token: 0x02000522 RID: 1314
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildMotdSetErrorEvent : IMessage<GuildMotdSetErrorEvent>, IMessage, IEquatable<GuildMotdSetErrorEvent>, IDeepCloneable<GuildMotdSetErrorEvent>, IBufferMessage
	{
		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x001EC050 File Offset: 0x001EA250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildMotdSetErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x001EC060 File Offset: 0x001EA260
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

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x001EC070 File Offset: 0x001EA270
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

		// Token: 0x06003F11 RID: 16145 RVA: 0x001EC080 File Offset: 0x001EA280
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdSetErrorEvent()
		{
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x001EC090 File Offset: 0x001EA290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdSetErrorEvent(GuildMotdSetErrorEvent other)
		{
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x001EC0A0 File Offset: 0x001EA2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildMotdSetErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x001EC0B0 File Offset: 0x001EA2B0
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x001EC0C4 File Offset: 0x001EA2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialNoticeError Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialNoticeError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x001EC0D4 File Offset: 0x001EA2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x001EC0E4 File Offset: 0x001EA2E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildMotdSetErrorEvent other)
		{
			return true;
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x001EC0F4 File Offset: 0x001EA2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x001EC104 File Offset: 0x001EA304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x001EC114 File Offset: 0x001EA314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x001EC124 File Offset: 0x001EA324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x001EC134 File Offset: 0x001EA334
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x001EC144 File Offset: 0x001EA344
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildMotdSetErrorEvent other)
		{
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x001EC154 File Offset: 0x001EA354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x001EC164 File Offset: 0x001EA364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x001EC174 File Offset: 0x001EA374
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildMotdSetErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					break;
				}
				IL_9C:
				GuildMotdSetErrorEvent._parser = new MessageParser<GuildMotdSetErrorEvent>(() => null);
				num = 2;
				continue;
				goto IL_9C;
			}
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x001EC244 File Offset: 0x001EA444
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool idN1bmOTSxymJay3lH7v()
		{
			return true;
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x001EC24C File Offset: 0x001EA44C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildMotdSetErrorEvent oQZsrjOTMMrE9TcGVd7n()
		{
			return null;
		}

		// Token: 0x040015D9 RID: 5593
		private static readonly MessageParser<GuildMotdSetErrorEvent> _parser;

		// Token: 0x040015DA RID: 5594
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015DB RID: 5595
		public const int ErrorFieldNumber = 1;

		// Token: 0x040015DC RID: 5596
		private SocialNoticeError error_;

		// Token: 0x040015DD RID: 5597
		internal static GuildMotdSetErrorEvent aCTqrVOTPShKeuqTTQFc;
	}
}
