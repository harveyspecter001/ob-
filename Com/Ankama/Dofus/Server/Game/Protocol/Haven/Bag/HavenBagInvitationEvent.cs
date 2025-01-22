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
	// Token: 0x020004A7 RID: 1191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagInvitationEvent : IMessage<HavenBagInvitationEvent>, IMessage, IEquatable<HavenBagInvitationEvent>, IDeepCloneable<HavenBagInvitationEvent>, IBufferMessage
	{
		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x001E1064 File Offset: 0x001DF264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagInvitationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x001E1074 File Offset: 0x001DF274
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

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x001E1084 File Offset: 0x001DF284
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

		// Token: 0x060038EC RID: 14572 RVA: 0x001E1094 File Offset: 0x001DF294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationEvent()
		{
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x001E10A4 File Offset: 0x001DF2A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationEvent(HavenBagInvitationEvent other)
		{
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x001E10B4 File Offset: 0x001DF2B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagInvitationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x001E10C4 File Offset: 0x001DF2C4
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x001E10D4 File Offset: 0x001DF2D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Character GuestInformation
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

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x001E10E4 File Offset: 0x001DF2E4
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x001E10F4 File Offset: 0x001DF2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Accepted
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

		// Token: 0x060038F3 RID: 14579 RVA: 0x001E1104 File Offset: 0x001DF304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x001E1114 File Offset: 0x001DF314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagInvitationEvent other)
		{
			return true;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x001E1124 File Offset: 0x001DF324
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x001E1134 File Offset: 0x001DF334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x001E1144 File Offset: 0x001DF344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x001E1154 File Offset: 0x001DF354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x001E1164 File Offset: 0x001DF364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x001E1174 File Offset: 0x001DF374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagInvitationEvent other)
		{
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x001E1184 File Offset: 0x001DF384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x001E1194 File Offset: 0x001DF394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x001E11A4 File Offset: 0x001DF3A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagInvitationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				HavenBagInvitationEvent._parser = new MessageParser<HavenBagInvitationEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x001E1288 File Offset: 0x001DF488
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool llGtHSOwS17vFTW3UStL()
		{
			return true;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x001E1290 File Offset: 0x001DF490
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagInvitationEvent oVfuuQOwMso9lmVoJZEp()
		{
			return null;
		}

		// Token: 0x040013DA RID: 5082
		private static readonly MessageParser<HavenBagInvitationEvent> _parser;

		// Token: 0x040013DB RID: 5083
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013DC RID: 5084
		public const int GuestInformationFieldNumber = 1;

		// Token: 0x040013DD RID: 5085
		private Character guestInformation_;

		// Token: 0x040013DE RID: 5086
		public const int AcceptedFieldNumber = 2;

		// Token: 0x040013DF RID: 5087
		private bool accepted_;

		// Token: 0x040013E0 RID: 5088
		private static HavenBagInvitationEvent nHO6V8OwP8Y2k4dxwa9V;
	}
}
