using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002D6 RID: 726
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationCancelledForGuestEvent : IMessage<PartyInvitationCancelledForGuestEvent>, IMessage, IEquatable<PartyInvitationCancelledForGuestEvent>, IDeepCloneable<PartyInvitationCancelledForGuestEvent>, IBufferMessage
	{
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x001BB840 File Offset: 0x001B9A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyInvitationCancelledForGuestEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x001BB850 File Offset: 0x001B9A50
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x001BB860 File Offset: 0x001B9A60
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

		// Token: 0x060021AB RID: 8619 RVA: 0x001BB870 File Offset: 0x001B9A70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelledForGuestEvent()
		{
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x001BB880 File Offset: 0x001B9A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelledForGuestEvent(PartyInvitationCancelledForGuestEvent other)
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x001BB890 File Offset: 0x001B9A90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelledForGuestEvent Clone()
		{
			return null;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x001BB8A0 File Offset: 0x001B9AA0
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x001BB8B0 File Offset: 0x001B9AB0
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x001BB8C0 File Offset: 0x001B9AC0
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x001BB8D0 File Offset: 0x001B9AD0
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

		// Token: 0x060021B2 RID: 8626 RVA: 0x001BB8E0 File Offset: 0x001B9AE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x001BB8F0 File Offset: 0x001B9AF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationCancelledForGuestEvent other)
		{
			return true;
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x001BB900 File Offset: 0x001B9B00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x001BB910 File Offset: 0x001B9B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x001BB920 File Offset: 0x001B9B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x001BB930 File Offset: 0x001B9B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x001BB940 File Offset: 0x001B9B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x001BB950 File Offset: 0x001B9B50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationCancelledForGuestEvent other)
		{
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x001BB960 File Offset: 0x001B9B60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x001BB970 File Offset: 0x001B9B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x001BB980 File Offset: 0x001B9B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationCancelledForGuestEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					PartyInvitationCancelledForGuestEvent._parser = new MessageParser<PartyInvitationCancelledForGuestEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x001BBA78 File Offset: 0x001B9C78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dGId2CO6Pog7wht1slr4()
		{
			return true;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x001BBA80 File Offset: 0x001B9C80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationCancelledForGuestEvent M2UMyaO6S97SUr0uvjsi()
		{
			return null;
		}

		// Token: 0x04000BD0 RID: 3024
		private static readonly MessageParser<PartyInvitationCancelledForGuestEvent> _parser;

		// Token: 0x04000BD1 RID: 3025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BD2 RID: 3026
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000BD3 RID: 3027
		private int partyId_;

		// Token: 0x04000BD4 RID: 3028
		public const int CancellerIdFieldNumber = 2;

		// Token: 0x04000BD5 RID: 3029
		private long cancellerId_;

		// Token: 0x04000BD6 RID: 3030
		private static PartyInvitationCancelledForGuestEvent QljstYO6iEjI1FST5QS6;
	}
}
