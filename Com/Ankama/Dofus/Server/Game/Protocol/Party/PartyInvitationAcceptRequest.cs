using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x0200028A RID: 650
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationAcceptRequest : IMessage<PartyInvitationAcceptRequest>, IMessage, IEquatable<PartyInvitationAcceptRequest>, IDeepCloneable<PartyInvitationAcceptRequest>, IBufferMessage
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x001B73E4 File Offset: 0x001B55E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyInvitationAcceptRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x001B73F4 File Offset: 0x001B55F4
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

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x001B7404 File Offset: 0x001B5604
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

		// Token: 0x06001E43 RID: 7747 RVA: 0x001B7414 File Offset: 0x001B5614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationAcceptRequest()
		{
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x001B7424 File Offset: 0x001B5624
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationAcceptRequest(PartyInvitationAcceptRequest other)
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x001B7434 File Offset: 0x001B5634
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationAcceptRequest Clone()
		{
			return null;
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x001B7444 File Offset: 0x001B5644
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x001B7454 File Offset: 0x001B5654
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

		// Token: 0x06001E48 RID: 7752 RVA: 0x001B7464 File Offset: 0x001B5664
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x001B7474 File Offset: 0x001B5674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationAcceptRequest other)
		{
			return true;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x001B7484 File Offset: 0x001B5684
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x001B7494 File Offset: 0x001B5694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x001B74A4 File Offset: 0x001B56A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x001B74B4 File Offset: 0x001B56B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x001B74C4 File Offset: 0x001B56C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x001B74D4 File Offset: 0x001B56D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationAcceptRequest other)
		{
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x001B74E4 File Offset: 0x001B56E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x001B74F4 File Offset: 0x001B56F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x001B7504 File Offset: 0x001B5704
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationAcceptRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					PartyInvitationAcceptRequest._parser = new MessageParser<PartyInvitationAcceptRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x001B75E8 File Offset: 0x001B57E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MviRuGOyx2HHZJWGWYil()
		{
			return true;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x001B75F0 File Offset: 0x001B57F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationAcceptRequest NqV1INOy4k5C5RX0Up2O()
		{
			return null;
		}

		// Token: 0x04000AB8 RID: 2744
		private static readonly MessageParser<PartyInvitationAcceptRequest> _parser;

		// Token: 0x04000AB9 RID: 2745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ABA RID: 2746
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000ABB RID: 2747
		private int partyId_;

		// Token: 0x04000ABC RID: 2748
		internal static PartyInvitationAcceptRequest XBjGubOyNpaNwtyQd4aV;
	}
}
