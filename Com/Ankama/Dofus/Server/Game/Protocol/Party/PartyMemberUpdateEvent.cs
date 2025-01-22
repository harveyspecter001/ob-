using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002E4 RID: 740
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyMemberUpdateEvent : IMessage<PartyMemberUpdateEvent>, IMessage, IEquatable<PartyMemberUpdateEvent>, IDeepCloneable<PartyMemberUpdateEvent>, IBufferMessage
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x001BC668 File Offset: 0x001BA868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyMemberUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x001BC678 File Offset: 0x001BA878
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

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x001BC688 File Offset: 0x001BA888
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

		// Token: 0x06002260 RID: 8800 RVA: 0x001BC698 File Offset: 0x001BA898
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberUpdateEvent()
		{
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x001BC6A8 File Offset: 0x001BA8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberUpdateEvent(PartyMemberUpdateEvent other)
		{
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x001BC6B8 File Offset: 0x001BA8B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyMemberUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x001BC6C8 File Offset: 0x001BA8C8
		// (set) Token: 0x06002264 RID: 8804 RVA: 0x001BC6D8 File Offset: 0x001BA8D8
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

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x001BC6E8 File Offset: 0x001BA8E8
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x001BC6F8 File Offset: 0x001BA8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Character Member
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

		// Token: 0x06002267 RID: 8807 RVA: 0x001BC708 File Offset: 0x001BA908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x001BC718 File Offset: 0x001BA918
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyMemberUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x001BC728 File Offset: 0x001BA928
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x001BC738 File Offset: 0x001BA938
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x001BC748 File Offset: 0x001BA948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x001BC758 File Offset: 0x001BA958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x001BC768 File Offset: 0x001BA968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x001BC778 File Offset: 0x001BA978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyMemberUpdateEvent other)
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x001BC788 File Offset: 0x001BA988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x001BC798 File Offset: 0x001BA998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x001BC7A8 File Offset: 0x001BA9A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyMemberUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PartyMemberUpdateEvent._parser = new MessageParser<PartyMemberUpdateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_da5c0a8c113b40929f7e789b49b9a0dd == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x001BC88C File Offset: 0x001BAA8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zmC5eaOLJQYfloljxY2P()
		{
			return true;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x001BC894 File Offset: 0x001BAA94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyMemberUpdateEvent H1GxcVOLGX3FHbunlh67()
		{
			return null;
		}

		// Token: 0x04000C24 RID: 3108
		private static readonly MessageParser<PartyMemberUpdateEvent> _parser;

		// Token: 0x04000C25 RID: 3109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C26 RID: 3110
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C27 RID: 3111
		private int partyId_;

		// Token: 0x04000C28 RID: 3112
		public const int MemberFieldNumber = 2;

		// Token: 0x04000C29 RID: 3113
		private Character member_;

		// Token: 0x04000C2A RID: 3114
		private static PartyMemberUpdateEvent S0u2MjOLO3N9JIEmxkwd;
	}
}
