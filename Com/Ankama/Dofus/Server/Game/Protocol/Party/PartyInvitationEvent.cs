using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002D2 RID: 722
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationEvent : IMessage<PartyInvitationEvent>, IMessage, IEquatable<PartyInvitationEvent>, IDeepCloneable<PartyInvitationEvent>, IBufferMessage
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x001BB24C File Offset: 0x001B944C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyInvitationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x001BB25C File Offset: 0x001B945C
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x001BB26C File Offset: 0x001B946C
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

		// Token: 0x0600215F RID: 8543 RVA: 0x001BB27C File Offset: 0x001B947C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationEvent()
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x001BB28C File Offset: 0x001B948C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationEvent(PartyInvitationEvent other)
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x001BB29C File Offset: 0x001B949C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationEvent Clone()
		{
			return null;
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x001BB2AC File Offset: 0x001B94AC
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x001BB2BC File Offset: 0x001B94BC
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

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x001BB2CC File Offset: 0x001B94CC
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x001BB2E0 File Offset: 0x001B94E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x001BB2F0 File Offset: 0x001B94F0
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x001BB300 File Offset: 0x001B9500
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

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x001BB310 File Offset: 0x001B9510
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x001BB320 File Offset: 0x001B9520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x001BB330 File Offset: 0x001B9530
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x001BB340 File Offset: 0x001B9540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x001BB350 File Offset: 0x001B9550
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x001BB360 File Offset: 0x001B9560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x001BB370 File Offset: 0x001B9570
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x001BB380 File Offset: 0x001B9580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ToPlayerId
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

		// Token: 0x06002170 RID: 8560 RVA: 0x001BB390 File Offset: 0x001B9590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x001BB3A0 File Offset: 0x001B95A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationEvent other)
		{
			return true;
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x001BB3B0 File Offset: 0x001B95B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x001BB3C0 File Offset: 0x001B95C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x001BB3D0 File Offset: 0x001B95D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x001BB3E0 File Offset: 0x001B95E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x001BB3F0 File Offset: 0x001B95F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x001BB400 File Offset: 0x001B9600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationEvent other)
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x001BB410 File Offset: 0x001B9610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x001BB420 File Offset: 0x001B9620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x001BB430 File Offset: 0x001B9630
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationEvent()
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
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					PartyInvitationEvent._parser = new MessageParser<PartyInvitationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x001BB4FC File Offset: 0x001B96FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nRuGOTO6Ty0EKqXal3hU()
		{
			return true;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x001BB504 File Offset: 0x001B9704
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationEvent u97YHxO6p3L2txhG5x8q()
		{
			return null;
		}

		// Token: 0x04000BA6 RID: 2982
		private static readonly MessageParser<PartyInvitationEvent> _parser;

		// Token: 0x04000BA7 RID: 2983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BA8 RID: 2984
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000BA9 RID: 2985
		private int partyId_;

		// Token: 0x04000BAA RID: 2986
		public const int PartyTypeFieldNumber = 2;

		// Token: 0x04000BAB RID: 2987
		private PartyType partyType_;

		// Token: 0x04000BAC RID: 2988
		public const int PartyNameFieldNumber = 3;

		// Token: 0x04000BAD RID: 2989
		private string partyName_;

		// Token: 0x04000BAE RID: 2990
		public const int MaxParticipantsFieldNumber = 4;

		// Token: 0x04000BAF RID: 2991
		private int maxParticipants_;

		// Token: 0x04000BB0 RID: 2992
		public const int FromPlayerIdFieldNumber = 5;

		// Token: 0x04000BB1 RID: 2993
		private long fromPlayerId_;

		// Token: 0x04000BB2 RID: 2994
		public const int FromPlayerNameFieldNumber = 6;

		// Token: 0x04000BB3 RID: 2995
		private string fromPlayerName_;

		// Token: 0x04000BB4 RID: 2996
		public const int ToPlayerIdFieldNumber = 7;

		// Token: 0x04000BB5 RID: 2997
		private long toPlayerId_;

		// Token: 0x04000BB6 RID: 2998
		internal static PartyInvitationEvent k9Z9akO67rF4nM2AMPdL;
	}
}
