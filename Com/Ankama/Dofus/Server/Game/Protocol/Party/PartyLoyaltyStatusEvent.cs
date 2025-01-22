using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002F8 RID: 760
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyLoyaltyStatusEvent : IMessage<PartyLoyaltyStatusEvent>, IMessage, IEquatable<PartyLoyaltyStatusEvent>, IDeepCloneable<PartyLoyaltyStatusEvent>, IBufferMessage
	{
		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x001BDD08 File Offset: 0x001BBF08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyLoyaltyStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x001BDD18 File Offset: 0x001BBF18
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x001BDD28 File Offset: 0x001BBF28
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

		// Token: 0x06002382 RID: 9090 RVA: 0x001BDD38 File Offset: 0x001BBF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLoyaltyStatusEvent()
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x001BDD48 File Offset: 0x001BBF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLoyaltyStatusEvent(PartyLoyaltyStatusEvent other)
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x001BDD58 File Offset: 0x001BBF58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyLoyaltyStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x001BDD68 File Offset: 0x001BBF68
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x001BDD78 File Offset: 0x001BBF78
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

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x001BDD88 File Offset: 0x001BBF88
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x001BDD98 File Offset: 0x001BBF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Loyal
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

		// Token: 0x06002389 RID: 9097 RVA: 0x001BDDA8 File Offset: 0x001BBFA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x001BDDB8 File Offset: 0x001BBFB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyLoyaltyStatusEvent other)
		{
			return true;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x001BDDC8 File Offset: 0x001BBFC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x001BDDD8 File Offset: 0x001BBFD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x001BDDE8 File Offset: 0x001BBFE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x001BDDF8 File Offset: 0x001BBFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x001BDE08 File Offset: 0x001BC008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x001BDE18 File Offset: 0x001BC018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyLoyaltyStatusEvent other)
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x001BDE28 File Offset: 0x001BC028
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x001BDE38 File Offset: 0x001BC038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x001BDE48 File Offset: 0x001BC048
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyLoyaltyStatusEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						break;
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						goto IL_9C;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						return;
					}
				}
				IL_9C:
				PartyLoyaltyStatusEvent._parser = new MessageParser<PartyLoyaltyStatusEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x001BDF18 File Offset: 0x001BC118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bceUO2OLV1khwEjGLcM4()
		{
			return true;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x001BDF20 File Offset: 0x001BC120
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyLoyaltyStatusEvent WMs5trOL0Rt3chOf6vR0()
		{
			return null;
		}

		// Token: 0x04000C88 RID: 3208
		private static readonly MessageParser<PartyLoyaltyStatusEvent> _parser;

		// Token: 0x04000C89 RID: 3209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C8A RID: 3210
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C8B RID: 3211
		private int partyId_;

		// Token: 0x04000C8C RID: 3212
		public const int LoyalFieldNumber = 2;

		// Token: 0x04000C8D RID: 3213
		private bool loyal_;

		// Token: 0x04000C8E RID: 3214
		private static PartyLoyaltyStatusEvent LAKqxxOLrkPXsNwiuqP3;
	}
}
