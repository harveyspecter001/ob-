using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D36 RID: 3382
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInvitationAnswerRequest : IMessage<AllianceInvitationAnswerRequest>, IMessage, IEquatable<AllianceInvitationAnswerRequest>, IDeepCloneable<AllianceInvitationAnswerRequest>, IBufferMessage
	{
		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x0028BC48 File Offset: 0x00289E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceInvitationAnswerRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x0600A2D8 RID: 41688 RVA: 0x0028BC58 File Offset: 0x00289E58
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

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x0600A2D9 RID: 41689 RVA: 0x0028BC68 File Offset: 0x00289E68
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

		// Token: 0x0600A2DA RID: 41690 RVA: 0x0028BC78 File Offset: 0x00289E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationAnswerRequest()
		{
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x0028BC88 File Offset: 0x00289E88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationAnswerRequest(AllianceInvitationAnswerRequest other)
		{
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x0028BC98 File Offset: 0x00289E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationAnswerRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x0028BCA8 File Offset: 0x00289EA8
		// (set) Token: 0x0600A2DE RID: 41694 RVA: 0x0028BCB8 File Offset: 0x00289EB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Accepted
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

		// Token: 0x0600A2DF RID: 41695 RVA: 0x0028BCC8 File Offset: 0x00289EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x0028BCD8 File Offset: 0x00289ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInvitationAnswerRequest other)
		{
			return true;
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x0028BCE8 File Offset: 0x00289EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x0028BCF8 File Offset: 0x00289EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x0028BD08 File Offset: 0x00289F08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x0028BD18 File Offset: 0x00289F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x0028BD28 File Offset: 0x00289F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x0028BD38 File Offset: 0x00289F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInvitationAnswerRequest other)
		{
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x0028BD48 File Offset: 0x00289F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x0028BD58 File Offset: 0x00289F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x0028BD68 File Offset: 0x00289F68
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInvitationAnswerRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AllianceInvitationAnswerRequest._parser = new MessageParser<AllianceInvitationAnswerRequest>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x0028BE4C File Offset: 0x0028A04C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool mp97vBJIgfXEcQS8QNGD()
		{
			return true;
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x0028BE54 File Offset: 0x0028A054
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInvitationAnswerRequest mo3iSxJIs6YaB8diDcQY()
		{
			return null;
		}

		// Token: 0x04003C19 RID: 15385
		private static readonly MessageParser<AllianceInvitationAnswerRequest> _parser;

		// Token: 0x04003C1A RID: 15386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C1B RID: 15387
		public const int AcceptedFieldNumber = 1;

		// Token: 0x04003C1C RID: 15388
		private bool accepted_;

		// Token: 0x04003C1D RID: 15389
		internal static AllianceInvitationAnswerRequest gvDpXxJIGVY5ANw0lhmW;
	}
}
