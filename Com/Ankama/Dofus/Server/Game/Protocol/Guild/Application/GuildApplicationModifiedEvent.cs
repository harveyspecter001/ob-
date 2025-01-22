using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application
{
	// Token: 0x0200056D RID: 1389
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildApplicationModifiedEvent : IMessage<GuildApplicationModifiedEvent>, IMessage, IEquatable<GuildApplicationModifiedEvent>, IDeepCloneable<GuildApplicationModifiedEvent>, IBufferMessage
	{
		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x001F24BC File Offset: 0x001F06BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildApplicationModifiedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x001F24CC File Offset: 0x001F06CC
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x001F24DC File Offset: 0x001F06DC
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

		// Token: 0x060042D9 RID: 17113 RVA: 0x001F24EC File Offset: 0x001F06EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationModifiedEvent()
		{
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x001F24FC File Offset: 0x001F06FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationModifiedEvent(GuildApplicationModifiedEvent other)
		{
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x001F250C File Offset: 0x001F070C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildApplicationModifiedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x001F251C File Offset: 0x001F071C
		// (set) Token: 0x060042DD RID: 17117 RVA: 0x001F252C File Offset: 0x001F072C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialApplicationInformation Application
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x001F253C File Offset: 0x001F073C
		// (set) Token: 0x060042DF RID: 17119 RVA: 0x001F2550 File Offset: 0x001F0750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialApplicationState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialApplicationState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x001F2560 File Offset: 0x001F0760
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x001F2570 File Offset: 0x001F0770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x060042E2 RID: 17122 RVA: 0x001F2580 File Offset: 0x001F0780
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x001F2590 File Offset: 0x001F0790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildApplicationModifiedEvent other)
		{
			return true;
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x001F25A0 File Offset: 0x001F07A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x001F25B0 File Offset: 0x001F07B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x001F25C0 File Offset: 0x001F07C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x001F25D0 File Offset: 0x001F07D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x001F25E0 File Offset: 0x001F07E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x001F25F0 File Offset: 0x001F07F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildApplicationModifiedEvent other)
		{
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x001F2600 File Offset: 0x001F0800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x001F2610 File Offset: 0x001F0810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x001F2620 File Offset: 0x001F0820
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildApplicationModifiedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					GuildApplicationModifiedEvent._parser = new MessageParser<GuildApplicationModifiedEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x001F26EC File Offset: 0x001F08EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dbI8mqOHrWG24BgQi3Fe()
		{
			return true;
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x001F26F4 File Offset: 0x001F08F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildApplicationModifiedEvent m4sncrOHVNHph4kOBFf4()
		{
			return null;
		}

		// Token: 0x0400170C RID: 5900
		private static readonly MessageParser<GuildApplicationModifiedEvent> _parser;

		// Token: 0x0400170D RID: 5901
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400170E RID: 5902
		public const int ApplicationFieldNumber = 1;

		// Token: 0x0400170F RID: 5903
		private SocialApplicationInformation application_;

		// Token: 0x04001710 RID: 5904
		public const int StateFieldNumber = 2;

		// Token: 0x04001711 RID: 5905
		private SocialApplicationState state_;

		// Token: 0x04001712 RID: 5906
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04001713 RID: 5907
		private long playerId_;

		// Token: 0x04001714 RID: 5908
		private static GuildApplicationModifiedEvent lvZKnfOHhkdUi3ChYY64;
	}
}
