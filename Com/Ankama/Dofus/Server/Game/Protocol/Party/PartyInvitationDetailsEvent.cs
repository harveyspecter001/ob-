using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002D4 RID: 724
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationDetailsEvent : IMessage<PartyInvitationDetailsEvent>, IMessage, IEquatable<PartyInvitationDetailsEvent>, IDeepCloneable<PartyInvitationDetailsEvent>, IBufferMessage
	{
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x001BB50C File Offset: 0x001B970C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyInvitationDetailsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x001BB51C File Offset: 0x001B971C
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x001BB52C File Offset: 0x001B972C
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

		// Token: 0x06002185 RID: 8581 RVA: 0x001BB53C File Offset: 0x001B973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationDetailsEvent()
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x001BB54C File Offset: 0x001B974C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationDetailsEvent(PartyInvitationDetailsEvent other)
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x001BB55C File Offset: 0x001B975C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationDetailsEvent Clone()
		{
			return null;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x001BB56C File Offset: 0x001B976C
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x001BB57C File Offset: 0x001B977C
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x001BB58C File Offset: 0x001B978C
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x001BB5A0 File Offset: 0x001B97A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PartyType PartyType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PartyType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x001BB5B0 File Offset: 0x001B97B0
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x001BB5C0 File Offset: 0x001B97C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PartyName
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

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x001BB5D0 File Offset: 0x001B97D0
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x001BB5E0 File Offset: 0x001B97E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long FromPlayerId
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x001BB5F0 File Offset: 0x001B97F0
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x001BB600 File Offset: 0x001B9800
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string FromPlayerName
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x001BB610 File Offset: 0x001B9810
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x001BB620 File Offset: 0x001B9820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LeaderId
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x001BB630 File Offset: 0x001B9830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Character> Members
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x001BB640 File Offset: 0x001B9840
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<PartyGuest> Guests
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x001BB650 File Offset: 0x001B9850
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x001BB660 File Offset: 0x001B9860
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationDetailsEvent other)
		{
			return true;
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x001BB670 File Offset: 0x001B9870
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x001BB680 File Offset: 0x001B9880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x001BB690 File Offset: 0x001B9890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x001BB6A0 File Offset: 0x001B98A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x001BB6B0 File Offset: 0x001B98B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x001BB6C0 File Offset: 0x001B98C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationDetailsEvent other)
		{
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x001BB6D0 File Offset: 0x001B98D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x001BB6E0 File Offset: 0x001B98E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x001BB6F0 File Offset: 0x001B98F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationDetailsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 3:
					PartyInvitationDetailsEvent._repeated_guests_codec = FieldCodec.ForMessage<PartyGuest>(66U, fFyKwWn9cnV8AYM8oUfO.XVInXhlssT(fFyKwWn9cnV8AYM8oUfO.mfwn9URWYlM));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
					PartyInvitationDetailsEvent._parser = new MessageParser<PartyInvitationDetailsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PartyInvitationDetailsEvent._repeated_members_codec = FieldCodec.ForMessage<Character>(58U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
				num2 = 3;
			}
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x001BB830 File Offset: 0x001B9A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WmUsZbO6YxHWhHOAY0GO()
		{
			return true;
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x001BB838 File Offset: 0x001B9A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationDetailsEvent H0XqHeO6bX6aZd1FAbtx()
		{
			return null;
		}

		// Token: 0x04000BB9 RID: 3001
		private static readonly MessageParser<PartyInvitationDetailsEvent> _parser;

		// Token: 0x04000BBA RID: 3002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BBB RID: 3003
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000BBC RID: 3004
		private int partyId_;

		// Token: 0x04000BBD RID: 3005
		public const int PartyTypeFieldNumber = 2;

		// Token: 0x04000BBE RID: 3006
		private PartyType partyType_;

		// Token: 0x04000BBF RID: 3007
		public const int PartyNameFieldNumber = 3;

		// Token: 0x04000BC0 RID: 3008
		private string partyName_;

		// Token: 0x04000BC1 RID: 3009
		public const int FromPlayerIdFieldNumber = 4;

		// Token: 0x04000BC2 RID: 3010
		private long fromPlayerId_;

		// Token: 0x04000BC3 RID: 3011
		public const int FromPlayerNameFieldNumber = 5;

		// Token: 0x04000BC4 RID: 3012
		private string fromPlayerName_;

		// Token: 0x04000BC5 RID: 3013
		public const int LeaderIdFieldNumber = 6;

		// Token: 0x04000BC6 RID: 3014
		private long leaderId_;

		// Token: 0x04000BC7 RID: 3015
		public const int MembersFieldNumber = 7;

		// Token: 0x04000BC8 RID: 3016
		private static readonly FieldCodec<Character> _repeated_members_codec;

		// Token: 0x04000BC9 RID: 3017
		private readonly RepeatedField<Character> members_;

		// Token: 0x04000BCA RID: 3018
		public const int GuestsFieldNumber = 8;

		// Token: 0x04000BCB RID: 3019
		private static readonly FieldCodec<PartyGuest> _repeated_guests_codec;

		// Token: 0x04000BCC RID: 3020
		private readonly RepeatedField<PartyGuest> guests_;

		// Token: 0x04000BCD RID: 3021
		private static PartyInvitationDetailsEvent oNv3QtO6H0bcuFFrwitD;
	}
}
