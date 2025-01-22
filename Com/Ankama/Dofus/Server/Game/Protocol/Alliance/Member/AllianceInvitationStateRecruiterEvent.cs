using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D3C RID: 3388
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInvitationStateRecruiterEvent : IMessage<AllianceInvitationStateRecruiterEvent>, IMessage, IEquatable<AllianceInvitationStateRecruiterEvent>, IDeepCloneable<AllianceInvitationStateRecruiterEvent>, IBufferMessage
	{
		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600A327 RID: 41767 RVA: 0x0028C28C File Offset: 0x0028A48C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceInvitationStateRecruiterEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600A328 RID: 41768 RVA: 0x0028C29C File Offset: 0x0028A49C
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

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x0600A329 RID: 41769 RVA: 0x0028C2AC File Offset: 0x0028A4AC
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

		// Token: 0x0600A32A RID: 41770 RVA: 0x0028C2BC File Offset: 0x0028A4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationStateRecruiterEvent()
		{
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x0028C2CC File Offset: 0x0028A4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationStateRecruiterEvent(AllianceInvitationStateRecruiterEvent other)
		{
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x0028C2DC File Offset: 0x0028A4DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationStateRecruiterEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x0600A32D RID: 41773 RVA: 0x0028C2EC File Offset: 0x0028A4EC
		// (set) Token: 0x0600A32E RID: 41774 RVA: 0x0028C2FC File Offset: 0x0028A4FC
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

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x0600A32F RID: 41775 RVA: 0x0028C30C File Offset: 0x0028A50C
		// (set) Token: 0x0600A330 RID: 41776 RVA: 0x0028C320 File Offset: 0x0028A520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x0600A331 RID: 41777 RVA: 0x0028C330 File Offset: 0x0028A530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x0028C340 File Offset: 0x0028A540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInvitationStateRecruiterEvent other)
		{
			return true;
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x0028C350 File Offset: 0x0028A550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x0028C360 File Offset: 0x0028A560
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x0028C370 File Offset: 0x0028A570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x0028C380 File Offset: 0x0028A580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x0028C390 File Offset: 0x0028A590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x0028C3A0 File Offset: 0x0028A5A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInvitationStateRecruiterEvent other)
		{
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x0028C3B0 File Offset: 0x0028A5B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x0028C3C0 File Offset: 0x0028A5C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x0028C3D0 File Offset: 0x0028A5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInvitationStateRecruiterEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 != 0)
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
					AllianceInvitationStateRecruiterEvent._parser = new MessageParser<AllianceInvitationStateRecruiterEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
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

		// Token: 0x0600A33C RID: 41788 RVA: 0x0028C49C File Offset: 0x0028A69C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool dpGNnOJI4Bal4CiH2iDJ()
		{
			return true;
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x0028C4A4 File Offset: 0x0028A6A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInvitationStateRecruiterEvent boyp4cJIj4Vro8jG66tx()
		{
			return null;
		}

		// Token: 0x04003C30 RID: 15408
		private static readonly MessageParser<AllianceInvitationStateRecruiterEvent> _parser;

		// Token: 0x04003C31 RID: 15409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C32 RID: 15410
		public const int RecruitedNameFieldNumber = 1;

		// Token: 0x04003C33 RID: 15411
		private string recruitedName_;

		// Token: 0x04003C34 RID: 15412
		public const int InvitationStateFieldNumber = 2;

		// Token: 0x04003C35 RID: 15413
		private SocialGroupInvitationState invitationState_;

		// Token: 0x04003C36 RID: 15414
		internal static AllianceInvitationStateRecruiterEvent z6aiObJIxFVBLixpDKMg;
	}
}
