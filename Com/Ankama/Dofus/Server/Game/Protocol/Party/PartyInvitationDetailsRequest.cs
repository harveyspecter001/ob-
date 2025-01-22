using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x02000288 RID: 648
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PartyInvitationDetailsRequest : IMessage<PartyInvitationDetailsRequest>, IMessage, IEquatable<PartyInvitationDetailsRequest>, IDeepCloneable<PartyInvitationDetailsRequest>, IBufferMessage
	{
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x001B71BC File Offset: 0x001B53BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartyInvitationDetailsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x001B71CC File Offset: 0x001B53CC
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

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x001B71DC File Offset: 0x001B53DC
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

		// Token: 0x06001E29 RID: 7721 RVA: 0x001B71EC File Offset: 0x001B53EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationDetailsRequest()
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x001B71FC File Offset: 0x001B53FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationDetailsRequest(PartyInvitationDetailsRequest other)
		{
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x001B720C File Offset: 0x001B540C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PartyInvitationDetailsRequest Clone()
		{
			return null;
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x001B721C File Offset: 0x001B541C
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x001B722C File Offset: 0x001B542C
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

		// Token: 0x06001E2E RID: 7726 RVA: 0x001B723C File Offset: 0x001B543C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x001B724C File Offset: 0x001B544C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PartyInvitationDetailsRequest other)
		{
			return true;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x001B725C File Offset: 0x001B545C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x001B726C File Offset: 0x001B546C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x001B727C File Offset: 0x001B547C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x001B728C File Offset: 0x001B548C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x001B729C File Offset: 0x001B549C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x001B72AC File Offset: 0x001B54AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PartyInvitationDetailsRequest other)
		{
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x001B72BC File Offset: 0x001B54BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x001B72CC File Offset: 0x001B54CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x001B72DC File Offset: 0x001B54DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PartyInvitationDetailsRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				PartyInvitationDetailsRequest._parser = new MessageParser<PartyInvitationDetailsRequest>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x001B73D4 File Offset: 0x001B55D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool O7a67vOyEDIS9SJWxVR1()
		{
			return true;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x001B73DC File Offset: 0x001B55DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PartyInvitationDetailsRequest g5vEWGOyXgB1kYNGX31i()
		{
			return null;
		}

		// Token: 0x04000AB1 RID: 2737
		private static readonly MessageParser<PartyInvitationDetailsRequest> _parser;

		// Token: 0x04000AB2 RID: 2738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AB3 RID: 2739
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04000AB4 RID: 2740
		private int partyId_;

		// Token: 0x04000AB5 RID: 2741
		internal static PartyInvitationDetailsRequest VMm8DZOy2tBZcZg6J6Zc;
	}
}
