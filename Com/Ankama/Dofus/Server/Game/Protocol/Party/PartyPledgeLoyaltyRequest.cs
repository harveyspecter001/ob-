using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x0200029C RID: 668
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyPledgeLoyaltyRequest : IMessage<PartyPledgeLoyaltyRequest>, IMessage, IEquatable<PartyPledgeLoyaltyRequest>, IDeepCloneable<PartyPledgeLoyaltyRequest>, IBufferMessage
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x001B8788 File Offset: 0x001B6988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyPledgeLoyaltyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x001B8798 File Offset: 0x001B6998
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

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x001B87A8 File Offset: 0x001B69A8
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

		// Token: 0x06001F3B RID: 7995 RVA: 0x001B87B8 File Offset: 0x001B69B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyPledgeLoyaltyRequest()
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x001B87C8 File Offset: 0x001B69C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyPledgeLoyaltyRequest(PartyPledgeLoyaltyRequest other)
		{
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x001B87D8 File Offset: 0x001B69D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyPledgeLoyaltyRequest Clone()
		{
			return null;
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x001B87E8 File Offset: 0x001B69E8
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x001B87F8 File Offset: 0x001B69F8
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

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x001B8808 File Offset: 0x001B6A08
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x001B8818 File Offset: 0x001B6A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06001F42 RID: 8002 RVA: 0x001B8828 File Offset: 0x001B6A28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x001B8838 File Offset: 0x001B6A38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyPledgeLoyaltyRequest other)
		{
			return true;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x001B8848 File Offset: 0x001B6A48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x001B8858 File Offset: 0x001B6A58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x001B8868 File Offset: 0x001B6A68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x001B8878 File Offset: 0x001B6A78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x001B8888 File Offset: 0x001B6A88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x001B8898 File Offset: 0x001B6A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyPledgeLoyaltyRequest other)
		{
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x001B88A8 File Offset: 0x001B6AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x001B88B8 File Offset: 0x001B6AB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x001B88C8 File Offset: 0x001B6AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyPledgeLoyaltyRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PartyPledgeLoyaltyRequest._parser = new MessageParser<PartyPledgeLoyaltyRequest>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x001B89AC File Offset: 0x001B6BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KO9DcqOy725TEFY5A63A()
		{
			return true;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x001B89B4 File Offset: 0x001B6BB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyPledgeLoyaltyRequest jNQdXOOyT3MiVpWR6xK0()
		{
			return null;
		}

		// Token: 0x04000B05 RID: 2821
		private static readonly MessageParser<PartyPledgeLoyaltyRequest> _parser;

		// Token: 0x04000B06 RID: 2822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B07 RID: 2823
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000B08 RID: 2824
		private int partyId_;

		// Token: 0x04000B09 RID: 2825
		public const int LoyalFieldNumber = 2;

		// Token: 0x04000B0A RID: 2826
		private bool loyal_;

		// Token: 0x04000B0B RID: 2827
		internal static PartyPledgeLoyaltyRequest tE16B6OyQI64WmEFWUPl;
	}
}
