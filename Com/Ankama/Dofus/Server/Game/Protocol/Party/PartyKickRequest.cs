using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x0200029A RID: 666
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyKickRequest : IMessage<PartyKickRequest>, IMessage, IEquatable<PartyKickRequest>, IDeepCloneable<PartyKickRequest>, IBufferMessage
	{
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x001B8554 File Offset: 0x001B6754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyKickRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x001B8564 File Offset: 0x001B6764
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x001B8574 File Offset: 0x001B6774
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

		// Token: 0x06001F1F RID: 7967 RVA: 0x001B8584 File Offset: 0x001B6784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyKickRequest()
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x001B8594 File Offset: 0x001B6794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyKickRequest(PartyKickRequest other)
		{
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x001B85A4 File Offset: 0x001B67A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyKickRequest Clone()
		{
			return null;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x001B85B4 File Offset: 0x001B67B4
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x001B85C4 File Offset: 0x001B67C4
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x001B85D4 File Offset: 0x001B67D4
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x001B85E4 File Offset: 0x001B67E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06001F26 RID: 7974 RVA: 0x001B85F4 File Offset: 0x001B67F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x001B8604 File Offset: 0x001B6804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyKickRequest other)
		{
			return true;
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x001B8614 File Offset: 0x001B6814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x001B8624 File Offset: 0x001B6824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x001B8634 File Offset: 0x001B6834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x001B8644 File Offset: 0x001B6844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x001B8654 File Offset: 0x001B6854
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x001B8664 File Offset: 0x001B6864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyKickRequest other)
		{
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x001B8674 File Offset: 0x001B6874
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x001B8684 File Offset: 0x001B6884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x001B8694 File Offset: 0x001B6894
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyKickRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				PartyKickRequest._parser = new MessageParser<PartyKickRequest>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x001B8778 File Offset: 0x001B6978
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ov3KTjOyth1BA04CtqXd()
		{
			return true;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x001B8780 File Offset: 0x001B6980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyKickRequest GB0EAAOywq3ff3wiAonr()
		{
			return null;
		}

		// Token: 0x04000AFC RID: 2812
		private static readonly MessageParser<PartyKickRequest> _parser;

		// Token: 0x04000AFD RID: 2813
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AFE RID: 2814
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AFF RID: 2815
		private int partyId_;

		// Token: 0x04000B00 RID: 2816
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000B01 RID: 2817
		private long playerId_;

		// Token: 0x04000B02 RID: 2818
		internal static PartyKickRequest qddemZOyDi6nHD7NBTyN;
	}
}
