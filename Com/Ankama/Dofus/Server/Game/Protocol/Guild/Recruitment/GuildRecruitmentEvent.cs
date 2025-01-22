using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Recruitment
{
	// Token: 0x020004B9 RID: 1209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildRecruitmentEvent : IMessage<GuildRecruitmentEvent>, IMessage, IEquatable<GuildRecruitmentEvent>, IDeepCloneable<GuildRecruitmentEvent>, IBufferMessage
	{
		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x001E27C8 File Offset: 0x001E09C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<GuildRecruitmentEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x001E27D8 File Offset: 0x001E09D8
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

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060039C7 RID: 14791 RVA: 0x001E27E8 File Offset: 0x001E09E8
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

		// Token: 0x060039C8 RID: 14792 RVA: 0x001E27F8 File Offset: 0x001E09F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentEvent()
		{
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x001E2808 File Offset: 0x001E0A08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentEvent(GuildRecruitmentEvent other)
		{
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x001E2818 File Offset: 0x001E0A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildRecruitmentEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060039CB RID: 14795 RVA: 0x001E2828 File Offset: 0x001E0A28
		// (set) Token: 0x060039CC RID: 14796 RVA: 0x001E2838 File Offset: 0x001E0A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuildRecruitmentInformation Recruitment
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

		// Token: 0x060039CD RID: 14797 RVA: 0x001E2848 File Offset: 0x001E0A48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x001E2858 File Offset: 0x001E0A58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildRecruitmentEvent other)
		{
			return true;
		}

		// Token: 0x060039CF RID: 14799 RVA: 0x001E2868 File Offset: 0x001E0A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060039D0 RID: 14800 RVA: 0x001E2878 File Offset: 0x001E0A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060039D1 RID: 14801 RVA: 0x001E2888 File Offset: 0x001E0A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060039D2 RID: 14802 RVA: 0x001E2898 File Offset: 0x001E0A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x001E28A8 File Offset: 0x001E0AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060039D4 RID: 14804 RVA: 0x001E28B8 File Offset: 0x001E0AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildRecruitmentEvent other)
		{
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x001E28C8 File Offset: 0x001E0AC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x001E28D8 File Offset: 0x001E0AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x001E28E8 File Offset: 0x001E0AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildRecruitmentEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildRecruitmentEvent._parser = new MessageParser<GuildRecruitmentEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x001E29E0 File Offset: 0x001E0BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool H7jdbuOQKK4xm4vwvwGh()
		{
			return true;
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x001E29E8 File Offset: 0x001E0BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildRecruitmentEvent nye4O9OQISDp8OQ7p35B()
		{
			return null;
		}

		// Token: 0x0400141A RID: 5146
		private static readonly MessageParser<GuildRecruitmentEvent> _parser;

		// Token: 0x0400141B RID: 5147
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400141C RID: 5148
		public const int RecruitmentFieldNumber = 1;

		// Token: 0x0400141D RID: 5149
		private GuildRecruitmentInformation recruitment_;

		// Token: 0x0400141E RID: 5150
		internal static GuildRecruitmentEvent d3guTGOQj1VAgb5v2X8w;
	}
}
