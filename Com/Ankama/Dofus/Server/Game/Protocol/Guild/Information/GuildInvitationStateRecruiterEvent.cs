using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information
{
	// Token: 0x02000514 RID: 1300
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GuildInvitationStateRecruiterEvent : IMessage<GuildInvitationStateRecruiterEvent>, IMessage, IEquatable<GuildInvitationStateRecruiterEvent>, IDeepCloneable<GuildInvitationStateRecruiterEvent>, IBufferMessage
	{
		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06003E45 RID: 15941 RVA: 0x001EB0B8 File Offset: 0x001E92B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GuildInvitationStateRecruiterEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x001EB0C8 File Offset: 0x001E92C8
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

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06003E47 RID: 15943 RVA: 0x001EB0D8 File Offset: 0x001E92D8
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

		// Token: 0x06003E48 RID: 15944 RVA: 0x001EB0E8 File Offset: 0x001E92E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationStateRecruiterEvent()
		{
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x001EB0F8 File Offset: 0x001E92F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationStateRecruiterEvent(GuildInvitationStateRecruiterEvent other)
		{
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x001EB108 File Offset: 0x001E9308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GuildInvitationStateRecruiterEvent Clone()
		{
			return null;
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06003E4B RID: 15947 RVA: 0x001EB118 File Offset: 0x001E9318
		// (set) Token: 0x06003E4C RID: 15948 RVA: 0x001EB128 File Offset: 0x001E9328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RecruitedName
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06003E4D RID: 15949 RVA: 0x001EB138 File Offset: 0x001E9338
		// (set) Token: 0x06003E4E RID: 15950 RVA: 0x001EB14C File Offset: 0x001E934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialGroupInvitationState InvitationState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SocialGroupInvitationState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06003E4F RID: 15951 RVA: 0x001EB15C File Offset: 0x001E935C
		// (set) Token: 0x06003E50 RID: 15952 RVA: 0x001EB16C File Offset: 0x001E936C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecruitedId
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

		// Token: 0x06003E51 RID: 15953 RVA: 0x001EB17C File Offset: 0x001E937C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x001EB18C File Offset: 0x001E938C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GuildInvitationStateRecruiterEvent other)
		{
			return true;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x001EB19C File Offset: 0x001E939C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x001EB1AC File Offset: 0x001E93AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x001EB1BC File Offset: 0x001E93BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x001EB1CC File Offset: 0x001E93CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x001EB1DC File Offset: 0x001E93DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x001EB1EC File Offset: 0x001E93EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GuildInvitationStateRecruiterEvent other)
		{
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x001EB1FC File Offset: 0x001E93FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x001EB20C File Offset: 0x001E940C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x001EB21C File Offset: 0x001E941C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GuildInvitationStateRecruiterEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					GuildInvitationStateRecruiterEvent._parser = new MessageParser<GuildInvitationStateRecruiterEvent>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x001EB300 File Offset: 0x001E9500
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bEBEaXOTySsVZkU2lhZq()
		{
			return true;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x001EB308 File Offset: 0x001E9508
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GuildInvitationStateRecruiterEvent vG8vwvOT6uIYVDybJ2Cr()
		{
			return null;
		}

		// Token: 0x04001593 RID: 5523
		private static readonly MessageParser<GuildInvitationStateRecruiterEvent> _parser;

		// Token: 0x04001594 RID: 5524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001595 RID: 5525
		public const int RecruitedNameFieldNumber = 1;

		// Token: 0x04001596 RID: 5526
		private string recruitedName_;

		// Token: 0x04001597 RID: 5527
		public const int InvitationStateFieldNumber = 2;

		// Token: 0x04001598 RID: 5528
		private SocialGroupInvitationState invitationState_;

		// Token: 0x04001599 RID: 5529
		public const int RecruitedIdFieldNumber = 3;

		// Token: 0x0400159A RID: 5530
		private int recruitedId_;

		// Token: 0x0400159B RID: 5531
		internal static GuildInvitationStateRecruiterEvent htGTrDOT5bUQa9Tbhavx;
	}
}
