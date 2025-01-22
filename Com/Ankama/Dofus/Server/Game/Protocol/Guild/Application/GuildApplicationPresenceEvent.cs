using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x02000571 RID: 1393
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationPresenceEvent : IMessage<GuildApplicationPresenceEvent>, IMessage, IEquatable<GuildApplicationPresenceEvent>, IDeepCloneable<GuildApplicationPresenceEvent>, IBufferMessage
	{
		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x001F2944 File Offset: 0x001F0B44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildApplicationPresenceEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06004311 RID: 17169 RVA: 0x001F2954 File Offset: 0x001F0B54
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

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x001F2964 File Offset: 0x001F0B64
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

		// Token: 0x06004313 RID: 17171 RVA: 0x001F2974 File Offset: 0x001F0B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPresenceEvent()
		{
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x001F2984 File Offset: 0x001F0B84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPresenceEvent(GuildApplicationPresenceEvent other)
		{
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x001F2994 File Offset: 0x001F0B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationPresenceEvent Clone()
		{
			return null;
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x001F29A4 File Offset: 0x001F0BA4
		// (set) Token: 0x06004317 RID: 17175 RVA: 0x001F29B4 File Offset: 0x001F0BB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsApplication
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

		// Token: 0x06004318 RID: 17176 RVA: 0x001F29C4 File Offset: 0x001F0BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x001F29D4 File Offset: 0x001F0BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationPresenceEvent other)
		{
			return true;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x001F29E4 File Offset: 0x001F0BE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x001F29F4 File Offset: 0x001F0BF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x001F2A04 File Offset: 0x001F0C04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x001F2A14 File Offset: 0x001F0C14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x001F2A24 File Offset: 0x001F0C24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x001F2A34 File Offset: 0x001F0C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationPresenceEvent other)
		{
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x001F2A44 File Offset: 0x001F0C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x001F2A54 File Offset: 0x001F0C54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x001F2A64 File Offset: 0x001F0C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationPresenceEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					GuildApplicationPresenceEvent._parser = new MessageParser<GuildApplicationPresenceEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x001F2B48 File Offset: 0x001F0D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Uk4KDQOHwWhPpViWvlkn()
		{
			return true;
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x001F2B50 File Offset: 0x001F0D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationPresenceEvent FHobgvOHQkuaoVlEZdu9()
		{
			return null;
		}

		// Token: 0x04001720 RID: 5920
		private static readonly MessageParser<GuildApplicationPresenceEvent> _parser;

		// Token: 0x04001721 RID: 5921
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001722 RID: 5922
		public const int IsApplicationFieldNumber = 1;

		// Token: 0x04001723 RID: 5923
		private bool isApplication_;

		// Token: 0x04001724 RID: 5924
		internal static GuildApplicationPresenceEvent mDHf6mOHtYkgyssvL5WK;
	}
}
