using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000290 RID: 656
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyAbdicateThroneRequest : IMessage<PartyAbdicateThroneRequest>, IMessage, IEquatable<PartyAbdicateThroneRequest>, IDeepCloneable<PartyAbdicateThroneRequest>, IBufferMessage
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x001B7A28 File Offset: 0x001B5C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyAbdicateThroneRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x001B7A38 File Offset: 0x001B5C38
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

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x001B7A48 File Offset: 0x001B5C48
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

		// Token: 0x06001E93 RID: 7827 RVA: 0x001B7A58 File Offset: 0x001B5C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyAbdicateThroneRequest()
		{
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x001B7A68 File Offset: 0x001B5C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyAbdicateThroneRequest(PartyAbdicateThroneRequest other)
		{
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x001B7A78 File Offset: 0x001B5C78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyAbdicateThroneRequest Clone()
		{
			return null;
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x001B7A88 File Offset: 0x001B5C88
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x001B7A98 File Offset: 0x001B5C98
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

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x001B7AA8 File Offset: 0x001B5CA8
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x001B7AB8 File Offset: 0x001B5CB8
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

		// Token: 0x06001E9A RID: 7834 RVA: 0x001B7AC8 File Offset: 0x001B5CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x001B7AD8 File Offset: 0x001B5CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyAbdicateThroneRequest other)
		{
			return true;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x001B7AE8 File Offset: 0x001B5CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x001B7AF8 File Offset: 0x001B5CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x001B7B08 File Offset: 0x001B5D08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x001B7B18 File Offset: 0x001B5D18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x001B7B28 File Offset: 0x001B5D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x001B7B38 File Offset: 0x001B5D38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyAbdicateThroneRequest other)
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x001B7B48 File Offset: 0x001B5D48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x001B7B58 File Offset: 0x001B5D58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x001B7B68 File Offset: 0x001B5D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyAbdicateThroneRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PartyAbdicateThroneRequest._parser = new MessageParser<PartyAbdicateThroneRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x001B7C4C File Offset: 0x001B5E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool T1qF2rOyvKXZEtmdtbfk()
		{
			return true;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x001B7C54 File Offset: 0x001B5E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyAbdicateThroneRequest I9PMQ4OyouCHi0QBiXns()
		{
			return null;
		}

		// Token: 0x04000ACF RID: 2767
		private static readonly MessageParser<PartyAbdicateThroneRequest> _parser;

		// Token: 0x04000AD0 RID: 2768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AD1 RID: 2769
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AD2 RID: 2770
		private int partyId_;

		// Token: 0x04000AD3 RID: 2771
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000AD4 RID: 2772
		private long playerId_;

		// Token: 0x04000AD5 RID: 2773
		private static PartyAbdicateThroneRequest nCVs5ZOyUYQPiLtHbJ01;
	}
}
