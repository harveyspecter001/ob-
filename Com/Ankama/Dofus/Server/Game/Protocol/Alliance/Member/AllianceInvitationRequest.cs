using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member
{
	// Token: 0x02000D34 RID: 3380
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceInvitationRequest : IMessage<AllianceInvitationRequest>, IMessage, IEquatable<AllianceInvitationRequest>, IDeepCloneable<AllianceInvitationRequest>, IBufferMessage
	{
		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x0600A2BD RID: 41661 RVA: 0x0028BA4C File Offset: 0x00289C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceInvitationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x0600A2BE RID: 41662 RVA: 0x0028BA5C File Offset: 0x00289C5C
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

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x0600A2BF RID: 41663 RVA: 0x0028BA6C File Offset: 0x00289C6C
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

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x0028BA7C File Offset: 0x00289C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationRequest()
		{
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x0028BA8C File Offset: 0x00289C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationRequest(AllianceInvitationRequest other)
		{
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x0028BA9C File Offset: 0x00289C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceInvitationRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x0600A2C3 RID: 41667 RVA: 0x0028BAAC File Offset: 0x00289CAC
		// (set) Token: 0x0600A2C4 RID: 41668 RVA: 0x0028BABC File Offset: 0x00289CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CharacterId
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

		// Token: 0x0600A2C5 RID: 41669 RVA: 0x0028BACC File Offset: 0x00289CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x0028BADC File Offset: 0x00289CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceInvitationRequest other)
		{
			return true;
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x0028BAEC File Offset: 0x00289CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x0028BAFC File Offset: 0x00289CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x0028BB0C File Offset: 0x00289D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x0028BB1C File Offset: 0x00289D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x0028BB2C File Offset: 0x00289D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x0028BB3C File Offset: 0x00289D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceInvitationRequest other)
		{
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x0028BB4C File Offset: 0x00289D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x0028BB5C File Offset: 0x00289D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x0028BB6C File Offset: 0x00289D6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceInvitationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceInvitationRequest._parser = new MessageParser<AllianceInvitationRequest>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x0028BC38 File Offset: 0x00289E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QjuGblJIOoZuPJEHPmbn()
		{
			return true;
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x0028BC40 File Offset: 0x00289E40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceInvitationRequest QfYESiJIJWAcOAYaN7Jd()
		{
			return null;
		}

		// Token: 0x04003C12 RID: 15378
		private static readonly MessageParser<AllianceInvitationRequest> _parser;

		// Token: 0x04003C13 RID: 15379
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C14 RID: 15380
		public const int CharacterIdFieldNumber = 1;

		// Token: 0x04003C15 RID: 15381
		private long characterId_;

		// Token: 0x04003C16 RID: 15382
		internal static AllianceInvitationRequest Idbi3gJIR8oxZlO7AoPi;
	}
}
