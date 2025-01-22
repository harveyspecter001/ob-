using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D31 RID: 3377
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRightsUpdateRequest : IMessage<AllianceRightsUpdateRequest>, IMessage, IEquatable<AllianceRightsUpdateRequest>, IDeepCloneable<AllianceRightsUpdateRequest>, IBufferMessage
	{
		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x0600A29E RID: 41630 RVA: 0x0028AEB0 File Offset: 0x002890B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceRightsUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x0028AEC0 File Offset: 0x002890C0
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

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x0600A2A0 RID: 41632 RVA: 0x0028AED0 File Offset: 0x002890D0
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

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x0028AEE0 File Offset: 0x002890E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRightsUpdateRequest()
		{
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x0028AEF0 File Offset: 0x002890F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRightsUpdateRequest(AllianceRightsUpdateRequest other)
		{
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x0028AF00 File Offset: 0x00289100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRightsUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600A2A4 RID: 41636 RVA: 0x0028AF10 File Offset: 0x00289110
		// (set) Token: 0x0600A2A5 RID: 41637 RVA: 0x0028AF20 File Offset: 0x00289120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankId
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

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x0600A2A6 RID: 41638 RVA: 0x0028AF30 File Offset: 0x00289130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Rights
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x0028AF40 File Offset: 0x00289140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x0028AF50 File Offset: 0x00289150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRightsUpdateRequest other)
		{
			return true;
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x0028AF60 File Offset: 0x00289160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x0028AF70 File Offset: 0x00289170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x0028AF80 File Offset: 0x00289180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x0028AF90 File Offset: 0x00289190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x0028AFA0 File Offset: 0x002891A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x0028AFB0 File Offset: 0x002891B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRightsUpdateRequest other)
		{
		}

		// Token: 0x0600A2AF RID: 41647 RVA: 0x0028AFC0 File Offset: 0x002891C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x0028AFD0 File Offset: 0x002891D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x0028AFE0 File Offset: 0x002891E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRightsUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						AllianceRightsUpdateRequest._repeated_rights_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 5;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
						{
							num2 = 5;
						}
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						AllianceRightsUpdateRequest._parser = new MessageParser<AllianceRightsUpdateRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b != 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						return;
					case 5:
						goto IL_F5;
					}
				}
				IL_F5:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x0028B0FC File Offset: 0x002892FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool P4nbxRJImLNFQ0ne8Jqx()
		{
			return true;
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x0028B104 File Offset: 0x00289304
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRightsUpdateRequest iBHSIJJIARyjaUjhP4MC()
		{
			return null;
		}

		// Token: 0x04003C06 RID: 15366
		private static readonly MessageParser<AllianceRightsUpdateRequest> _parser;

		// Token: 0x04003C07 RID: 15367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C08 RID: 15368
		public const int RankIdFieldNumber = 1;

		// Token: 0x04003C09 RID: 15369
		private int rankId_;

		// Token: 0x04003C0A RID: 15370
		public const int RightsFieldNumber = 2;

		// Token: 0x04003C0B RID: 15371
		private static readonly FieldCodec<int> _repeated_rights_codec;

		// Token: 0x04003C0C RID: 15372
		private readonly RepeatedField<int> rights_;

		// Token: 0x04003C0D RID: 15373
		private static AllianceRightsUpdateRequest rEmsnoJInKIh4ku9xVje;
	}
}
