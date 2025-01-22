using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002D8 RID: 728
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationCancelledEvent : IMessage<PartyInvitationCancelledEvent>, IMessage, IEquatable<PartyInvitationCancelledEvent>, IDeepCloneable<PartyInvitationCancelledEvent>, IBufferMessage
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x001BBA88 File Offset: 0x001B9C88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyInvitationCancelledEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x001BBA98 File Offset: 0x001B9C98
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x001BBAA8 File Offset: 0x001B9CA8
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

		// Token: 0x060021C7 RID: 8647 RVA: 0x001BBAB8 File Offset: 0x001B9CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelledEvent()
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x001BBAC8 File Offset: 0x001B9CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelledEvent(PartyInvitationCancelledEvent other)
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x001BBAD8 File Offset: 0x001B9CD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelledEvent Clone()
		{
			return null;
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x001BBAE8 File Offset: 0x001B9CE8
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x001BBAF8 File Offset: 0x001B9CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x001BBB08 File Offset: 0x001B9D08
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x001BBB18 File Offset: 0x001B9D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CancellerId
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x001BBB28 File Offset: 0x001B9D28
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x001BBB38 File Offset: 0x001B9D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x060021D0 RID: 8656 RVA: 0x001BBB48 File Offset: 0x001B9D48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x001BBB58 File Offset: 0x001B9D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationCancelledEvent other)
		{
			return true;
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x001BBB68 File Offset: 0x001B9D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x001BBB78 File Offset: 0x001B9D78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x001BBB88 File Offset: 0x001B9D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x001BBB98 File Offset: 0x001B9D98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x001BBBA8 File Offset: 0x001B9DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x001BBBB8 File Offset: 0x001B9DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationCancelledEvent other)
		{
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x001BBBC8 File Offset: 0x001B9DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x001BBBD8 File Offset: 0x001B9DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x001BBBE8 File Offset: 0x001B9DE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationCancelledEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					PartyInvitationCancelledEvent._parser = new MessageParser<PartyInvitationCancelledEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x001BBCB4 File Offset: 0x001B9EB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool V2kRH5O6uWn5qIgYVwEf()
		{
			return true;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x001BBCBC File Offset: 0x001B9EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationCancelledEvent HsqEl9O68Yb1Zsbe1pwC()
		{
			return null;
		}

		// Token: 0x04000BD9 RID: 3033
		private static readonly MessageParser<PartyInvitationCancelledEvent> _parser;

		// Token: 0x04000BDA RID: 3034
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BDB RID: 3035
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000BDC RID: 3036
		private int partyId_;

		// Token: 0x04000BDD RID: 3037
		public const int CancellerIdFieldNumber = 2;

		// Token: 0x04000BDE RID: 3038
		private long cancellerId_;

		// Token: 0x04000BDF RID: 3039
		public const int GuestIdFieldNumber = 3;

		// Token: 0x04000BE0 RID: 3040
		private long guestId_;

		// Token: 0x04000BE1 RID: 3041
		internal static PartyInvitationCancelledEvent lJaDmGO6MMXbyrMWNHol;
	}
}
