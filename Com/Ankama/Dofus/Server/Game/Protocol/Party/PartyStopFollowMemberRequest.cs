using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000294 RID: 660
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyStopFollowMemberRequest : IMessage<PartyStopFollowMemberRequest>, IMessage, IEquatable<PartyStopFollowMemberRequest>, IDeepCloneable<PartyStopFollowMemberRequest>, IBufferMessage
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x001B7EE4 File Offset: 0x001B60E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyStopFollowMemberRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x001B7EF4 File Offset: 0x001B60F4
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x001B7F04 File Offset: 0x001B6104
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

		// Token: 0x06001ECF RID: 7887 RVA: 0x001B7F14 File Offset: 0x001B6114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyStopFollowMemberRequest()
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x001B7F24 File Offset: 0x001B6124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyStopFollowMemberRequest(PartyStopFollowMemberRequest other)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x001B7F34 File Offset: 0x001B6134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyStopFollowMemberRequest Clone()
		{
			return null;
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x001B7F44 File Offset: 0x001B6144
		// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x001B7F54 File Offset: 0x001B6154
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x001B7F64 File Offset: 0x001B6164
		// (set) Token: 0x06001ED5 RID: 7893 RVA: 0x001B7F74 File Offset: 0x001B6174
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x06001ED6 RID: 7894 RVA: 0x001B7F84 File Offset: 0x001B6184
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x001B7F94 File Offset: 0x001B6194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyStopFollowMemberRequest other)
		{
			return true;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x001B7FA4 File Offset: 0x001B61A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x001B7FB4 File Offset: 0x001B61B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x001B7FC4 File Offset: 0x001B61C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x001B7FD4 File Offset: 0x001B61D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x001B7FE4 File Offset: 0x001B61E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x001B7FF4 File Offset: 0x001B61F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyStopFollowMemberRequest other)
		{
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x001B8004 File Offset: 0x001B6204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x001B8014 File Offset: 0x001B6214
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x001B8024 File Offset: 0x001B6224
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyStopFollowMemberRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					PartyStopFollowMemberRequest._parser = new MessageParser<PartyStopFollowMemberRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x001B8108 File Offset: 0x001B6308
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ahoZ0wOy6DcHP2rboZjF()
		{
			return true;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x001B8110 File Offset: 0x001B6310
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyStopFollowMemberRequest vCVPxcOyLkxEnj8qWcPV()
		{
			return null;
		}

		// Token: 0x04000AE5 RID: 2789
		private static readonly MessageParser<PartyStopFollowMemberRequest> _parser;

		// Token: 0x04000AE6 RID: 2790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AE7 RID: 2791
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AE8 RID: 2792
		private int partyId_;

		// Token: 0x04000AE9 RID: 2793
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000AEA RID: 2794
		private long playerId_;

		// Token: 0x04000AEB RID: 2795
		internal static PartyStopFollowMemberRequest lCyqreOyyirR3F4B6bkT;
	}
}
