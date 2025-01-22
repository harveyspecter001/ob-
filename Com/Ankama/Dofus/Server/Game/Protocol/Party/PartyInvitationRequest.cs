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
	// Token: 0x02000286 RID: 646
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationRequest : IMessage<PartyInvitationRequest>, IMessage, IEquatable<PartyInvitationRequest>, IDeepCloneable<PartyInvitationRequest>, IBufferMessage
	{
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x001B6F9C File Offset: 0x001B519C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PartyInvitationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x001B6FAC File Offset: 0x001B51AC
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x001B6FBC File Offset: 0x001B51BC
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

		// Token: 0x06001E0D RID: 7693 RVA: 0x001B6FCC File Offset: 0x001B51CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRequest()
		{
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x001B6FDC File Offset: 0x001B51DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRequest(PartyInvitationRequest other)
		{
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x001B6FEC File Offset: 0x001B51EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationRequest Clone()
		{
			return null;
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x001B6FFC File Offset: 0x001B51FC
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x001B700C File Offset: 0x001B520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSearch Target
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

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x001B701C File Offset: 0x001B521C
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x001B7030 File Offset: 0x001B5230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06001E14 RID: 7700 RVA: 0x001B7040 File Offset: 0x001B5240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x001B7050 File Offset: 0x001B5250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationRequest other)
		{
			return true;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x001B7060 File Offset: 0x001B5260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x001B7070 File Offset: 0x001B5270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x001B7080 File Offset: 0x001B5280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x001B7090 File Offset: 0x001B5290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x001B70A0 File Offset: 0x001B52A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x001B70B0 File Offset: 0x001B52B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationRequest other)
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x001B70C0 File Offset: 0x001B52C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x001B70D0 File Offset: 0x001B52D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x001B70E0 File Offset: 0x001B52E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					PartyInvitationRequest._parser = new MessageParser<PartyInvitationRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x001B71AC File Offset: 0x001B53AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ooIKSOOydrlPHli1XbSh()
		{
			return true;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x001B71B4 File Offset: 0x001B53B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationRequest IEf5tZOy9ZSMwsy0hXMd()
		{
			return null;
		}

		// Token: 0x04000AA8 RID: 2728
		private static readonly MessageParser<PartyInvitationRequest> _parser;

		// Token: 0x04000AA9 RID: 2729
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AAA RID: 2730
		public const int TargetFieldNumber = 1;

		// Token: 0x04000AAB RID: 2731
		private PlayerSearch target_;

		// Token: 0x04000AAC RID: 2732
		public const int PartyTypeFieldNumber = 2;

		// Token: 0x04000AAD RID: 2733
		private PartyType partyType_;

		// Token: 0x04000AAE RID: 2734
		private static PartyInvitationRequest lnQOwEOys1Mr7dMbkdLT;
	}
}
