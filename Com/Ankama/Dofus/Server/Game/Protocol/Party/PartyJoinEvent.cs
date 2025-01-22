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
	// Token: 0x020002E0 RID: 736
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyJoinEvent : IMessage<PartyJoinEvent>, IMessage, IEquatable<PartyJoinEvent>, IDeepCloneable<PartyJoinEvent>, IBufferMessage
	{
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x001BC100 File Offset: 0x001BA300
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyJoinEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x001BC110 File Offset: 0x001BA310
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

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x001BC120 File Offset: 0x001BA320
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

		// Token: 0x0600221E RID: 8734 RVA: 0x001BC130 File Offset: 0x001BA330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyJoinEvent()
		{
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x001BC140 File Offset: 0x001BA340
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyJoinEvent(PartyJoinEvent other)
		{
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x001BC150 File Offset: 0x001BA350
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyJoinEvent Clone()
		{
			return null;
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x001BC160 File Offset: 0x001BA360
		// (set) Token: 0x06002222 RID: 8738 RVA: 0x001BC170 File Offset: 0x001BA370
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x001BC180 File Offset: 0x001BA380
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x001BC194 File Offset: 0x001BA394
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x001BC1A4 File Offset: 0x001BA3A4
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x001BC1B4 File Offset: 0x001BA3B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x001BC1C4 File Offset: 0x001BA3C4
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x001BC1D4 File Offset: 0x001BA3D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int MaxParticipants
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

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x001BC1E4 File Offset: 0x001BA3E4
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

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x001BC1F4 File Offset: 0x001BA3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartyGuest> Guests
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x001BC204 File Offset: 0x001BA404
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x001BC214 File Offset: 0x001BA414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Restricted
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

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x001BC224 File Offset: 0x001BA424
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x001BC234 File Offset: 0x001BA434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0600222F RID: 8751 RVA: 0x001BC244 File Offset: 0x001BA444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x001BC254 File Offset: 0x001BA454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyJoinEvent other)
		{
			return true;
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x001BC264 File Offset: 0x001BA464
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x001BC274 File Offset: 0x001BA474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x001BC284 File Offset: 0x001BA484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x001BC294 File Offset: 0x001BA494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x001BC2A4 File Offset: 0x001BA4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x001BC2B4 File Offset: 0x001BA4B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyJoinEvent other)
		{
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x001BC2C4 File Offset: 0x001BA4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x001BC2D4 File Offset: 0x001BA4D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x001BC2E4 File Offset: 0x001BA4E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyJoinEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						PartyJoinEvent._repeated_members_codec = FieldCodec.ForMessage<Character>(42U, KWxTa1nj0mNl3ugStJav.XVInXhlssT(KWxTa1nj0mNl3ugStJav.clVnjC25VIU));
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 2:
						PartyJoinEvent._parser = new MessageParser<PartyJoinEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						PartyJoinEvent._repeated_guests_codec = FieldCodec.ForMessage<PartyGuest>(50U, fFyKwWn9cnV8AYM8oUfO.XVInXhlssT(fFyKwWn9cnV8AYM8oUfO.mfwn9URWYlM));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 6;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 6:
						goto IL_133;
					}
					return;
				}
				IL_133:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x001BC43C File Offset: 0x001BA63C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xgkvBgOLAC4jK3ZaW9Os()
		{
			return true;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x001BC444 File Offset: 0x001BA644
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyJoinEvent mjLpSVOLBMZZk6MYj9k6()
		{
			return null;
		}

		// Token: 0x04000C04 RID: 3076
		private static readonly MessageParser<PartyJoinEvent> _parser;

		// Token: 0x04000C05 RID: 3077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C06 RID: 3078
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C07 RID: 3079
		private int partyId_;

		// Token: 0x04000C08 RID: 3080
		public const int PartyTypeFieldNumber = 2;

		// Token: 0x04000C09 RID: 3081
		private PartyType partyType_;

		// Token: 0x04000C0A RID: 3082
		public const int LeaderIdFieldNumber = 3;

		// Token: 0x04000C0B RID: 3083
		private long leaderId_;

		// Token: 0x04000C0C RID: 3084
		public const int MaxParticipantsFieldNumber = 4;

		// Token: 0x04000C0D RID: 3085
		private int maxParticipants_;

		// Token: 0x04000C0E RID: 3086
		public const int MembersFieldNumber = 5;

		// Token: 0x04000C0F RID: 3087
		private static readonly FieldCodec<Character> _repeated_members_codec;

		// Token: 0x04000C10 RID: 3088
		private readonly RepeatedField<Character> members_;

		// Token: 0x04000C11 RID: 3089
		public const int GuestsFieldNumber = 6;

		// Token: 0x04000C12 RID: 3090
		private static readonly FieldCodec<PartyGuest> _repeated_guests_codec;

		// Token: 0x04000C13 RID: 3091
		private readonly RepeatedField<PartyGuest> guests_;

		// Token: 0x04000C14 RID: 3092
		public const int RestrictedFieldNumber = 7;

		// Token: 0x04000C15 RID: 3093
		private bool restricted_;

		// Token: 0x04000C16 RID: 3094
		public const int PartyNameFieldNumber = 8;

		// Token: 0x04000C17 RID: 3095
		private string partyName_;

		// Token: 0x04000C18 RID: 3096
		internal static PartyJoinEvent xyMQwSOLmQE1LgUiZ4U0;
	}
}
