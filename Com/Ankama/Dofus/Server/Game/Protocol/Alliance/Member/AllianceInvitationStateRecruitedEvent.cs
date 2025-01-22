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
	// Token: 0x02000D3E RID: 3390
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInvitationStateRecruitedEvent : IMessage<AllianceInvitationStateRecruitedEvent>, IMessage, IEquatable<AllianceInvitationStateRecruitedEvent>, IDeepCloneable<AllianceInvitationStateRecruitedEvent>, IBufferMessage
	{
		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x0600A343 RID: 41795 RVA: 0x0028C4AC File Offset: 0x0028A6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceInvitationStateRecruitedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x0028C4BC File Offset: 0x0028A6BC
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

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600A345 RID: 41797 RVA: 0x0028C4CC File Offset: 0x0028A6CC
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

		// Token: 0x0600A346 RID: 41798 RVA: 0x0028C4DC File Offset: 0x0028A6DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationStateRecruitedEvent()
		{
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x0028C4EC File Offset: 0x0028A6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationStateRecruitedEvent(AllianceInvitationStateRecruitedEvent other)
		{
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x0028C4FC File Offset: 0x0028A6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationStateRecruitedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x0600A349 RID: 41801 RVA: 0x0028C50C File Offset: 0x0028A70C
		// (set) Token: 0x0600A34A RID: 41802 RVA: 0x0028C520 File Offset: 0x0028A720
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

		// Token: 0x0600A34B RID: 41803 RVA: 0x0028C530 File Offset: 0x0028A730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x0028C540 File Offset: 0x0028A740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInvitationStateRecruitedEvent other)
		{
			return true;
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x0028C550 File Offset: 0x0028A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x0028C560 File Offset: 0x0028A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x0028C570 File Offset: 0x0028A770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x0028C580 File Offset: 0x0028A780
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x0028C590 File Offset: 0x0028A790
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x0028C5A0 File Offset: 0x0028A7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInvitationStateRecruitedEvent other)
		{
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x0028C5B0 File Offset: 0x0028A7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x0028C5C0 File Offset: 0x0028A7C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x0028C5D0 File Offset: 0x0028A7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInvitationStateRecruitedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AllianceInvitationStateRecruitedEvent._parser = new MessageParser<AllianceInvitationStateRecruitedEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x0028C6B4 File Offset: 0x0028A8B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool d6gHTXJIIsZDTkpmg8WV()
		{
			return true;
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x0028C6BC File Offset: 0x0028A8BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInvitationStateRecruitedEvent Gl7Xh1JIkiE7QStaWoL4()
		{
			return null;
		}

		// Token: 0x04003C39 RID: 15417
		private static readonly MessageParser<AllianceInvitationStateRecruitedEvent> _parser;

		// Token: 0x04003C3A RID: 15418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C3B RID: 15419
		public const int InvitationStateFieldNumber = 1;

		// Token: 0x04003C3C RID: 15420
		private SocialGroupInvitationState invitationState_;

		// Token: 0x04003C3D RID: 15421
		internal static AllianceInvitationStateRecruitedEvent tHyY5MJIKIcyZxTGSumN;
	}
}
