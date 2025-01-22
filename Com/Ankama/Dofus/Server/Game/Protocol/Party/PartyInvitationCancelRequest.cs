using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x0200028E RID: 654
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationCancelRequest : IMessage<PartyInvitationCancelRequest>, IMessage, IEquatable<PartyInvitationCancelRequest>, IDeepCloneable<PartyInvitationCancelRequest>, IBufferMessage
	{
		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x001B780C File Offset: 0x001B5A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyInvitationCancelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x001B781C File Offset: 0x001B5A1C
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x001B782C File Offset: 0x001B5A2C
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

		// Token: 0x06001E77 RID: 7799 RVA: 0x001B783C File Offset: 0x001B5A3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelRequest()
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x001B784C File Offset: 0x001B5A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelRequest(PartyInvitationCancelRequest other)
		{
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x001B785C File Offset: 0x001B5A5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationCancelRequest Clone()
		{
			return null;
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x001B786C File Offset: 0x001B5A6C
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x001B787C File Offset: 0x001B5A7C
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

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x001B788C File Offset: 0x001B5A8C
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x001B789C File Offset: 0x001B5A9C
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

		// Token: 0x06001E7E RID: 7806 RVA: 0x001B78AC File Offset: 0x001B5AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x001B78BC File Offset: 0x001B5ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationCancelRequest other)
		{
			return true;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x001B78CC File Offset: 0x001B5ACC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x001B78DC File Offset: 0x001B5ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x001B78EC File Offset: 0x001B5AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x001B78FC File Offset: 0x001B5AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x001B790C File Offset: 0x001B5B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x001B791C File Offset: 0x001B5B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationCancelRequest other)
		{
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x001B792C File Offset: 0x001B5B2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x001B793C File Offset: 0x001B5B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x001B794C File Offset: 0x001B5B4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationCancelRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					PartyInvitationCancelRequest._parser = new MessageParser<PartyInvitationCancelRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x001B7A18 File Offset: 0x001B5C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fFObAxOyl72XYiysRAWV()
		{
			return true;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x001B7A20 File Offset: 0x001B5C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationCancelRequest UiMwQSOycL8QXYKr4XUY()
		{
			return null;
		}

		// Token: 0x04000AC6 RID: 2758
		private static readonly MessageParser<PartyInvitationCancelRequest> _parser;

		// Token: 0x04000AC7 RID: 2759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AC8 RID: 2760
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AC9 RID: 2761
		private int partyId_;

		// Token: 0x04000ACA RID: 2762
		public const int GuestIdFieldNumber = 2;

		// Token: 0x04000ACB RID: 2763
		private long guestId_;

		// Token: 0x04000ACC RID: 2764
		private static PartyInvitationCancelRequest CkAHBPOykeN5MFGsqP3s;
	}
}
