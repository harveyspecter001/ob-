using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002DC RID: 732
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyJoinErrorEvent : IMessage<PartyJoinErrorEvent>, IMessage, IEquatable<PartyJoinErrorEvent>, IDeepCloneable<PartyJoinErrorEvent>, IBufferMessage
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x001BBEE0 File Offset: 0x001BA0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyJoinErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x001BBEF0 File Offset: 0x001BA0F0
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

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x001BBF00 File Offset: 0x001BA100
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

		// Token: 0x06002201 RID: 8705 RVA: 0x001BBF10 File Offset: 0x001BA110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyJoinErrorEvent()
		{
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x001BBF20 File Offset: 0x001BA120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyJoinErrorEvent(PartyJoinErrorEvent other)
		{
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x001BBF30 File Offset: 0x001BA130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyJoinErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x001BBF40 File Offset: 0x001BA140
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x001BBF50 File Offset: 0x001BA150
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x001BBF60 File Offset: 0x001BA160
		// (set) Token: 0x06002207 RID: 8711 RVA: 0x001BBF74 File Offset: 0x001BA174
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PartyJoinErrorEvent.Types.PartyJoinError Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PartyJoinErrorEvent.Types.PartyJoinError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x001BBF84 File Offset: 0x001BA184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x001BBF94 File Offset: 0x001BA194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyJoinErrorEvent other)
		{
			return true;
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x001BBFA4 File Offset: 0x001BA1A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x001BBFB4 File Offset: 0x001BA1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x001BBFC4 File Offset: 0x001BA1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x001BBFD4 File Offset: 0x001BA1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x001BBFE4 File Offset: 0x001BA1E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x001BBFF4 File Offset: 0x001BA1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyJoinErrorEvent other)
		{
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x001BC004 File Offset: 0x001BA204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x001BC014 File Offset: 0x001BA214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x001BC024 File Offset: 0x001BA224
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyJoinErrorEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
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
					PartyJoinErrorEvent._parser = new MessageParser<PartyJoinErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x001BC0F0 File Offset: 0x001BA2F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yNSDkTOLfAQk19UCBc68()
		{
			return true;
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x001BC0F8 File Offset: 0x001BA2F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyJoinErrorEvent UfR4HNOLndwNIuUrtFiE()
		{
			return null;
		}

		// Token: 0x04000BED RID: 3053
		private static readonly MessageParser<PartyJoinErrorEvent> _parser;

		// Token: 0x04000BEE RID: 3054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BEF RID: 3055
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000BF0 RID: 3056
		private int partyId_;

		// Token: 0x04000BF1 RID: 3057
		public const int ReasonFieldNumber = 2;

		// Token: 0x04000BF2 RID: 3058
		private PartyJoinErrorEvent.Types.PartyJoinError reason_;

		// Token: 0x04000BF3 RID: 3059
		private static PartyJoinErrorEvent XV9yMsO6zdqQiSa8uOV1;

		// Token: 0x020002DD RID: 733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06002215 RID: 8725 RVA: 0x002B56F4 File Offset: 0x002B38F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020002DE RID: 734
			public enum PartyJoinError
			{
				// Token: 0x04000BF5 RID: 3061
				[OriginalName("UNKNOWN")]
				Unknown,
				// Token: 0x04000BF6 RID: 3062
				[OriginalName("PLAYER_NOT_FOUND")]
				PlayerNotFound,
				// Token: 0x04000BF7 RID: 3063
				[OriginalName("PARTY_NOT_FOUND")]
				PartyNotFound,
				// Token: 0x04000BF8 RID: 3064
				[OriginalName("PARTY_FULL")]
				PartyFull,
				// Token: 0x04000BF9 RID: 3065
				[OriginalName("PLAYER_BUSY")]
				PlayerBusy,
				// Token: 0x04000BFA RID: 3066
				[OriginalName("PLAYER_ALREADY_INVITED")]
				PlayerAlreadyInvited,
				// Token: 0x04000BFB RID: 3067
				[OriginalName("PLAYER_TOO_SOLICITED")]
				PlayerTooSolicited,
				// Token: 0x04000BFC RID: 3068
				[OriginalName("PLAYER_LOYAL")]
				PlayerLoyal,
				// Token: 0x04000BFD RID: 3069
				[OriginalName("UNMODIFIABLE")]
				Unmodifiable,
				// Token: 0x04000BFE RID: 3070
				[OriginalName("UNMET_CRITERION")]
				UnmetCriterion,
				// Token: 0x04000BFF RID: 3071
				[OriginalName("NOT_ENOUGH_ROOM")]
				NotEnoughRoom,
				// Token: 0x04000C00 RID: 3072
				[OriginalName("COMPOSITION_CHANGED")]
				CompositionChanged,
				// Token: 0x04000C01 RID: 3073
				[OriginalName("PLAYER_IN_TUTORIAL")]
				PlayerInTutorial
			}
		}
	}
}
