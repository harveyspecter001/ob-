using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002DA RID: 730
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationRefusedEvent : IMessage<PartyInvitationRefusedEvent>, IMessage, IEquatable<PartyInvitationRefusedEvent>, IDeepCloneable<PartyInvitationRefusedEvent>, IBufferMessage
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x001BBCC4 File Offset: 0x001B9EC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyInvitationRefusedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x001BBCD4 File Offset: 0x001B9ED4
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x001BBCE4 File Offset: 0x001B9EE4
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

		// Token: 0x060021E5 RID: 8677 RVA: 0x001BBCF4 File Offset: 0x001B9EF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRefusedEvent()
		{
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x001BBD04 File Offset: 0x001B9F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRefusedEvent(PartyInvitationRefusedEvent other)
		{
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x001BBD14 File Offset: 0x001B9F14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRefusedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x001BBD24 File Offset: 0x001B9F24
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x001BBD34 File Offset: 0x001B9F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartyId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x001BBD44 File Offset: 0x001B9F44
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x001BBD54 File Offset: 0x001B9F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GuestId
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

		// Token: 0x060021EC RID: 8684 RVA: 0x001BBD64 File Offset: 0x001B9F64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x001BBD74 File Offset: 0x001B9F74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationRefusedEvent other)
		{
			return true;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x001BBD84 File Offset: 0x001B9F84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x001BBD94 File Offset: 0x001B9F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x001BBDA4 File Offset: 0x001B9FA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x001BBDB4 File Offset: 0x001B9FB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x001BBDC4 File Offset: 0x001B9FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x001BBDD4 File Offset: 0x001B9FD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationRefusedEvent other)
		{
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x001BBDE4 File Offset: 0x001B9FE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x001BBDF4 File Offset: 0x001B9FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x001BBE04 File Offset: 0x001BA004
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationRefusedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				PartyInvitationRefusedEvent._parser = new MessageParser<PartyInvitationRefusedEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x001BBED0 File Offset: 0x001BA0D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EcFsdAO6q2PkXBidHNXo()
		{
			return true;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x001BBED8 File Offset: 0x001BA0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationRefusedEvent IakchuO6Fp0KVLQPdjII()
		{
			return null;
		}

		// Token: 0x04000BE4 RID: 3044
		private static readonly MessageParser<PartyInvitationRefusedEvent> _parser;

		// Token: 0x04000BE5 RID: 3045
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BE6 RID: 3046
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000BE7 RID: 3047
		private int partyId_;

		// Token: 0x04000BE8 RID: 3048
		public const int GuestIdFieldNumber = 2;

		// Token: 0x04000BE9 RID: 3049
		private long guestId_;

		// Token: 0x04000BEA RID: 3050
		private static PartyInvitationRefusedEvent kiGkvxO6Zp5WVQRUD9oS;
	}
}
