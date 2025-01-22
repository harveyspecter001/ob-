using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000CFA RID: 3322
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRecruitmentUpdateRequest : IMessage<AllianceRecruitmentUpdateRequest>, IMessage, IEquatable<AllianceRecruitmentUpdateRequest>, IDeepCloneable<AllianceRecruitmentUpdateRequest>, IBufferMessage
	{
		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x00286EB8 File Offset: 0x002850B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceRecruitmentUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06009FCC RID: 40908 RVA: 0x00286EC8 File Offset: 0x002850C8
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

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x00286ED8 File Offset: 0x002850D8
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

		// Token: 0x06009FCE RID: 40910 RVA: 0x00286EE8 File Offset: 0x002850E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentUpdateRequest()
		{
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x00286EF8 File Offset: 0x002850F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentUpdateRequest(AllianceRecruitmentUpdateRequest other)
		{
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x00286F08 File Offset: 0x00285108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06009FD1 RID: 40913 RVA: 0x00286F18 File Offset: 0x00285118
		// (set) Token: 0x06009FD2 RID: 40914 RVA: 0x00286F28 File Offset: 0x00285128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AllianceRecruitmentInformation Information
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

		// Token: 0x06009FD3 RID: 40915 RVA: 0x00286F38 File Offset: 0x00285138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x00286F48 File Offset: 0x00285148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRecruitmentUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x00286F58 File Offset: 0x00285158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x00286F68 File Offset: 0x00285168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x00286F78 File Offset: 0x00285178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x00286F88 File Offset: 0x00285188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x00286F98 File Offset: 0x00285198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x00286FA8 File Offset: 0x002851A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRecruitmentUpdateRequest other)
		{
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x00286FB8 File Offset: 0x002851B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x00286FC8 File Offset: 0x002851C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x00286FD8 File Offset: 0x002851D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRecruitmentUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AllianceRecruitmentUpdateRequest._parser = new MessageParser<AllianceRecruitmentUpdateRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x002870BC File Offset: 0x002852BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool z0B8D6JjDWgQ6alZKkDy()
		{
			return true;
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x002870C4 File Offset: 0x002852C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRecruitmentUpdateRequest O7ZbbAJjteuJTYAFw75D()
		{
			return null;
		}

		// Token: 0x04003B30 RID: 15152
		private static readonly MessageParser<AllianceRecruitmentUpdateRequest> _parser;

		// Token: 0x04003B31 RID: 15153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B32 RID: 15154
		public const int InformationFieldNumber = 1;

		// Token: 0x04003B33 RID: 15155
		private AllianceRecruitmentInformation information_;

		// Token: 0x04003B34 RID: 15156
		internal static AllianceRecruitmentUpdateRequest JgFLVsJjCKDfROVJf6e3;
	}
}
