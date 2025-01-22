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
	// Token: 0x020002E6 RID: 742
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyNewMemberEvent : IMessage<PartyNewMemberEvent>, IMessage, IEquatable<PartyNewMemberEvent>, IDeepCloneable<PartyNewMemberEvent>, IBufferMessage
	{
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x001BC89C File Offset: 0x001BAA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyNewMemberEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x001BC8AC File Offset: 0x001BAAAC
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

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x001BC8BC File Offset: 0x001BAABC
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

		// Token: 0x0600227C RID: 8828 RVA: 0x001BC8CC File Offset: 0x001BAACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNewMemberEvent()
		{
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x001BC8DC File Offset: 0x001BAADC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNewMemberEvent(PartyNewMemberEvent other)
		{
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x001BC8EC File Offset: 0x001BAAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyNewMemberEvent Clone()
		{
			return null;
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x001BC8FC File Offset: 0x001BAAFC
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x001BC90C File Offset: 0x001BAB0C
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

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x001BC91C File Offset: 0x001BAB1C
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x001BC92C File Offset: 0x001BAB2C
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

		// Token: 0x06002283 RID: 8835 RVA: 0x001BC93C File Offset: 0x001BAB3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x001BC94C File Offset: 0x001BAB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyNewMemberEvent other)
		{
			return true;
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x001BC95C File Offset: 0x001BAB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x001BC96C File Offset: 0x001BAB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x001BC97C File Offset: 0x001BAB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x001BC98C File Offset: 0x001BAB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x001BC99C File Offset: 0x001BAB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x001BC9AC File Offset: 0x001BABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyNewMemberEvent other)
		{
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x001BC9BC File Offset: 0x001BABBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x001BC9CC File Offset: 0x001BABCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x001BC9DC File Offset: 0x001BABDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyNewMemberEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PartyNewMemberEvent._parser = new MessageParser<PartyNewMemberEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_75d02f7ff9124bffb9e59d2f14857aad != 0)
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5750350b4e81418bb3d8d7d0657de68b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x001BCAC0 File Offset: 0x001BACC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vHTNMBOLsSRHlHnq6iUS()
		{
			return true;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x001BCAC8 File Offset: 0x001BACC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyNewMemberEvent aQZtX2OLdWnqS1ith2gB()
		{
			return null;
		}

		// Token: 0x04000C2D RID: 3117
		private static readonly MessageParser<PartyNewMemberEvent> _parser;

		// Token: 0x04000C2E RID: 3118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C2F RID: 3119
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000C30 RID: 3120
		private int partyId_;

		// Token: 0x04000C31 RID: 3121
		public const int MemberFieldNumber = 2;

		// Token: 0x04000C32 RID: 3122
		private Character member_;

		// Token: 0x04000C33 RID: 3123
		internal static PartyNewMemberEvent EhQ46ROLgvVEqPB36XSr;
	}
}
