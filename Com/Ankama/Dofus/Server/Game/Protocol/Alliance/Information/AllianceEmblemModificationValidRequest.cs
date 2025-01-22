using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D4D RID: 3405
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceEmblemModificationValidRequest : IMessage<AllianceEmblemModificationValidRequest>, IMessage, IEquatable<AllianceEmblemModificationValidRequest>, IDeepCloneable<AllianceEmblemModificationValidRequest>, IBufferMessage
	{
		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600A405 RID: 41989 RVA: 0x0028EBCC File Offset: 0x0028CDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceEmblemModificationValidRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600A406 RID: 41990 RVA: 0x0028EBDC File Offset: 0x0028CDDC
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

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x0600A407 RID: 41991 RVA: 0x0028EBEC File Offset: 0x0028CDEC
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

		// Token: 0x0600A408 RID: 41992 RVA: 0x0028EBFC File Offset: 0x0028CDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceEmblemModificationValidRequest()
		{
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x0028EC0C File Offset: 0x0028CE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceEmblemModificationValidRequest(AllianceEmblemModificationValidRequest other)
		{
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x0028EC1C File Offset: 0x0028CE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceEmblemModificationValidRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x0600A40B RID: 41995 RVA: 0x0028EC2C File Offset: 0x0028CE2C
		// (set) Token: 0x0600A40C RID: 41996 RVA: 0x0028EC3C File Offset: 0x0028CE3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public SocialEmblem AllianceEmblem
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

		// Token: 0x0600A40D RID: 41997 RVA: 0x0028EC4C File Offset: 0x0028CE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x0028EC5C File Offset: 0x0028CE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceEmblemModificationValidRequest other)
		{
			return true;
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x0028EC6C File Offset: 0x0028CE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x0028EC7C File Offset: 0x0028CE7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x0028EC8C File Offset: 0x0028CE8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x0028EC9C File Offset: 0x0028CE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x0028ECAC File Offset: 0x0028CEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x0028ECBC File Offset: 0x0028CEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceEmblemModificationValidRequest other)
		{
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x0028ECCC File Offset: 0x0028CECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x0028ECDC File Offset: 0x0028CEDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x0028ECEC File Offset: 0x0028CEEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceEmblemModificationValidRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AllianceEmblemModificationValidRequest._parser = new MessageParser<AllianceEmblemModificationValidRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1255b6ea0c3b4bc59d153e0b78ee5a99 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x0028EDD0 File Offset: 0x0028CFD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rD8s0YJITT6uMQaq7TUa()
		{
			return true;
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x0028EDD8 File Offset: 0x0028CFD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceEmblemModificationValidRequest FcM8h0JIphnGm3VEXk2T()
		{
			return null;
		}

		// Token: 0x04003C74 RID: 15476
		private static readonly MessageParser<AllianceEmblemModificationValidRequest> _parser;

		// Token: 0x04003C75 RID: 15477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C76 RID: 15478
		public const int AllianceEmblemFieldNumber = 1;

		// Token: 0x04003C77 RID: 15479
		private SocialEmblem allianceEmblem_;

		// Token: 0x04003C78 RID: 15480
		private static AllianceEmblemModificationValidRequest Ael7gWJI7i2VsWBbPwGs;
	}
}
