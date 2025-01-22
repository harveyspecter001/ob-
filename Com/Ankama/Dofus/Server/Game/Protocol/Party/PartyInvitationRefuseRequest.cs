using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x0200028C RID: 652
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationRefuseRequest : IMessage<PartyInvitationRefuseRequest>, IMessage, IEquatable<PartyInvitationRefuseRequest>, IDeepCloneable<PartyInvitationRefuseRequest>, IBufferMessage
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x001B75F8 File Offset: 0x001B57F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyInvitationRefuseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x001B7608 File Offset: 0x001B5808
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x001B7618 File Offset: 0x001B5818
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

		// Token: 0x06001E5D RID: 7773 RVA: 0x001B7628 File Offset: 0x001B5828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRefuseRequest()
		{
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x001B7638 File Offset: 0x001B5838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRefuseRequest(PartyInvitationRefuseRequest other)
		{
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x001B7648 File Offset: 0x001B5848
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRefuseRequest Clone()
		{
			return null;
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x001B7658 File Offset: 0x001B5858
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x001B7668 File Offset: 0x001B5868
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

		// Token: 0x06001E62 RID: 7778 RVA: 0x001B7678 File Offset: 0x001B5878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x001B7688 File Offset: 0x001B5888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationRefuseRequest other)
		{
			return true;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x001B7698 File Offset: 0x001B5898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x001B76A8 File Offset: 0x001B58A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x001B76B8 File Offset: 0x001B58B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x001B76C8 File Offset: 0x001B58C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x001B76D8 File Offset: 0x001B58D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x001B76E8 File Offset: 0x001B58E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationRefuseRequest other)
		{
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x001B76F8 File Offset: 0x001B58F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x001B7708 File Offset: 0x001B5908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x001B7718 File Offset: 0x001B5918
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationRefuseRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
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
					return;
				}
				PartyInvitationRefuseRequest._parser = new MessageParser<PartyInvitationRefuseRequest>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x001B77FC File Offset: 0x001B59FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool S7aorOOyK6fZhOIUwySD()
		{
			return true;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x001B7804 File Offset: 0x001B5A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationRefuseRequest Y9eFUEOyI6qoCft5lxiw()
		{
			return null;
		}

		// Token: 0x04000ABF RID: 2751
		private static readonly MessageParser<PartyInvitationRefuseRequest> _parser;

		// Token: 0x04000AC0 RID: 2752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AC1 RID: 2753
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AC2 RID: 2754
		private int partyId_;

		// Token: 0x04000AC3 RID: 2755
		internal static PartyInvitationRefuseRequest D7rOMXOyj5ilHcQmLrpd;
	}
}
