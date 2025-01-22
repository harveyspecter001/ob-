using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000CF8 RID: 3320
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRecruitmentInformationRequest : IMessage<AllianceRecruitmentInformationRequest>, IMessage, IEquatable<AllianceRecruitmentInformationRequest>, IDeepCloneable<AllianceRecruitmentInformationRequest>, IBufferMessage
	{
		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x00286CC4 File Offset: 0x00284EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceRecruitmentInformationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06009FB4 RID: 40884 RVA: 0x00286CD4 File Offset: 0x00284ED4
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

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x06009FB5 RID: 40885 RVA: 0x00286CE4 File Offset: 0x00284EE4
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

		// Token: 0x06009FB6 RID: 40886 RVA: 0x00286CF4 File Offset: 0x00284EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformationRequest()
		{
		}

		// Token: 0x06009FB7 RID: 40887 RVA: 0x00286D04 File Offset: 0x00284F04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformationRequest(AllianceRecruitmentInformationRequest other)
		{
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x00286D14 File Offset: 0x00284F14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRecruitmentInformationRequest Clone()
		{
			return null;
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x00286D24 File Offset: 0x00284F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009FBA RID: 40890 RVA: 0x00286D34 File Offset: 0x00284F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRecruitmentInformationRequest other)
		{
			return true;
		}

		// Token: 0x06009FBB RID: 40891 RVA: 0x00286D44 File Offset: 0x00284F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x00286D54 File Offset: 0x00284F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009FBD RID: 40893 RVA: 0x00286D64 File Offset: 0x00284F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x00286D74 File Offset: 0x00284F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x00286D84 File Offset: 0x00284F84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x00286D94 File Offset: 0x00284F94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRecruitmentInformationRequest other)
		{
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x00286DA4 File Offset: 0x00284FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x00286DB4 File Offset: 0x00284FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x00286DC4 File Offset: 0x00284FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRecruitmentInformationRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
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
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AllianceRecruitmentInformationRequest._parser = new MessageParser<AllianceRecruitmentInformationRequest>(() => null);
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x00286EA8 File Offset: 0x002850A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qF6xnVJjVUZnBKbbxLLk()
		{
			return true;
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x00286EB0 File Offset: 0x002850B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRecruitmentInformationRequest nEnL6tJj0rxtLe0erQYe()
		{
			return null;
		}

		// Token: 0x04003B2B RID: 15147
		private static readonly MessageParser<AllianceRecruitmentInformationRequest> _parser;

		// Token: 0x04003B2C RID: 15148
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B2D RID: 15149
		internal static AllianceRecruitmentInformationRequest F4jLJ5JjrxOpiXPkPS49;
	}
}
