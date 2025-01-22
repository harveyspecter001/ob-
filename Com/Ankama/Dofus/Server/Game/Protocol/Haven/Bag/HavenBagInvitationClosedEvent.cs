using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x020004A5 RID: 1189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagInvitationClosedEvent : IMessage<HavenBagInvitationClosedEvent>, IMessage, IEquatable<HavenBagInvitationClosedEvent>, IDeepCloneable<HavenBagInvitationClosedEvent>, IBufferMessage
	{
		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x001E0E50 File Offset: 0x001DF050
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagInvitationClosedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x001E0E60 File Offset: 0x001DF060
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

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x001E0E70 File Offset: 0x001DF070
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

		// Token: 0x060038D2 RID: 14546 RVA: 0x001E0E80 File Offset: 0x001DF080
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationClosedEvent()
		{
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x001E0E90 File Offset: 0x001DF090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationClosedEvent(HavenBagInvitationClosedEvent other)
		{
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x001E0EA0 File Offset: 0x001DF0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationClosedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x001E0EB0 File Offset: 0x001DF0B0
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x001E0EC0 File Offset: 0x001DF0C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character HostInformation
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

		// Token: 0x060038D7 RID: 14551 RVA: 0x001E0ED0 File Offset: 0x001DF0D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x001E0EE0 File Offset: 0x001DF0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagInvitationClosedEvent other)
		{
			return true;
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x001E0EF0 File Offset: 0x001DF0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x001E0F00 File Offset: 0x001DF100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x001E0F10 File Offset: 0x001DF110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x001E0F20 File Offset: 0x001DF120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x001E0F30 File Offset: 0x001DF130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x001E0F40 File Offset: 0x001DF140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagInvitationClosedEvent other)
		{
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x001E0F50 File Offset: 0x001DF150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x001E0F60 File Offset: 0x001DF160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x001E0F70 File Offset: 0x001DF170
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagInvitationClosedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				HavenBagInvitationClosedEvent._parser = new MessageParser<HavenBagInvitationClosedEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x001E1054 File Offset: 0x001DF254
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MaxxAZOwbVLtGv2FMROW()
		{
			return true;
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x001E105C File Offset: 0x001DF25C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagInvitationClosedEvent BvV8oIOwilRuRXJNJaj2()
		{
			return null;
		}

		// Token: 0x040013D3 RID: 5075
		private static readonly MessageParser<HavenBagInvitationClosedEvent> _parser;

		// Token: 0x040013D4 RID: 5076
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013D5 RID: 5077
		public const int HostInformationFieldNumber = 1;

		// Token: 0x040013D6 RID: 5078
		private Character hostInformation_;

		// Token: 0x040013D7 RID: 5079
		private static HavenBagInvitationClosedEvent lgi6LcOwY9GUsdmAItyH;
	}
}
