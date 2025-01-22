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
	// Token: 0x02000D3A RID: 3386
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInvitedEvent : IMessage<AllianceInvitedEvent>, IMessage, IEquatable<AllianceInvitedEvent>, IDeepCloneable<AllianceInvitedEvent>, IBufferMessage
	{
		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x0600A30B RID: 41739 RVA: 0x0028C058 File Offset: 0x0028A258
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceInvitedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x0600A30C RID: 41740 RVA: 0x0028C068 File Offset: 0x0028A268
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

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x0600A30D RID: 41741 RVA: 0x0028C078 File Offset: 0x0028A278
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

		// Token: 0x0600A30E RID: 41742 RVA: 0x0028C088 File Offset: 0x0028A288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitedEvent()
		{
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x0028C098 File Offset: 0x0028A298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitedEvent(AllianceInvitedEvent other)
		{
		}

		// Token: 0x0600A310 RID: 41744 RVA: 0x0028C0A8 File Offset: 0x0028A2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x0600A311 RID: 41745 RVA: 0x0028C0B8 File Offset: 0x0028A2B8
		// (set) Token: 0x0600A312 RID: 41746 RVA: 0x0028C0C8 File Offset: 0x0028A2C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string RecruiterName
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

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600A313 RID: 41747 RVA: 0x0028C0D8 File Offset: 0x0028A2D8
		// (set) Token: 0x0600A314 RID: 41748 RVA: 0x0028C0E8 File Offset: 0x0028A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceInformation AllianceInformation
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

		// Token: 0x0600A315 RID: 41749 RVA: 0x0028C0F8 File Offset: 0x0028A2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x0028C108 File Offset: 0x0028A308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInvitedEvent other)
		{
			return true;
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x0028C118 File Offset: 0x0028A318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x0028C128 File Offset: 0x0028A328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x0028C138 File Offset: 0x0028A338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x0028C148 File Offset: 0x0028A348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x0028C158 File Offset: 0x0028A358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x0028C168 File Offset: 0x0028A368
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInvitedEvent other)
		{
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x0028C178 File Offset: 0x0028A378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x0028C188 File Offset: 0x0028A388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x0028C198 File Offset: 0x0028A398
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInvitedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					AllianceInvitedEvent._parser = new MessageParser<AllianceInvitedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bf7d4de7efe04d679a42f99a7796f60d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x0028C27C File Offset: 0x0028A47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rJ4nu3JIXyWFmQGPAXZt()
		{
			return true;
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x0028C284 File Offset: 0x0028A484
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInvitedEvent PNNJoNJINQCeMGkPTPeG()
		{
			return null;
		}

		// Token: 0x04003C27 RID: 15399
		private static readonly MessageParser<AllianceInvitedEvent> _parser;

		// Token: 0x04003C28 RID: 15400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C29 RID: 15401
		public const int RecruiterNameFieldNumber = 1;

		// Token: 0x04003C2A RID: 15402
		private string recruiterName_;

		// Token: 0x04003C2B RID: 15403
		public const int AllianceInformationFieldNumber = 2;

		// Token: 0x04003C2C RID: 15404
		private AllianceInformation allianceInformation_;

		// Token: 0x04003C2D RID: 15405
		internal static AllianceInvitedEvent bWLBNUJIEGZ0AM9d2YcA;
	}
}
