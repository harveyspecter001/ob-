using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment
{
	// Token: 0x02000D0C RID: 3340
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceApplicationListRequest : IMessage<AllianceApplicationListRequest>, IMessage, IEquatable<AllianceApplicationListRequest>, IDeepCloneable<AllianceApplicationListRequest>, IBufferMessage
	{
		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x0600A0B3 RID: 41139 RVA: 0x0028811C File Offset: 0x0028631C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceApplicationListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x0028812C File Offset: 0x0028632C
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

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600A0B5 RID: 41141 RVA: 0x0028813C File Offset: 0x0028633C
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

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x0028814C File Offset: 0x0028634C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListRequest()
		{
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x0028815C File Offset: 0x0028635C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListRequest(AllianceApplicationListRequest other)
		{
		}

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x0028816C File Offset: 0x0028636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceApplicationListRequest Clone()
		{
			return null;
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600A0B9 RID: 41145 RVA: 0x0028817C File Offset: 0x0028637C
		// (set) Token: 0x0600A0BA RID: 41146 RVA: 0x0028818C File Offset: 0x0028638C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Offset
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

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600A0BB RID: 41147 RVA: 0x0028819C File Offset: 0x0028639C
		// (set) Token: 0x0600A0BC RID: 41148 RVA: 0x002881AC File Offset: 0x002863AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Count
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

		// Token: 0x0600A0BD RID: 41149 RVA: 0x002881BC File Offset: 0x002863BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x002881CC File Offset: 0x002863CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceApplicationListRequest other)
		{
			return true;
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x002881DC File Offset: 0x002863DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x002881EC File Offset: 0x002863EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x002881FC File Offset: 0x002863FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x0028820C File Offset: 0x0028640C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x0028821C File Offset: 0x0028641C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x0028822C File Offset: 0x0028642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceApplicationListRequest other)
		{
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x0028823C File Offset: 0x0028643C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x0028824C File Offset: 0x0028644C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x0028825C File Offset: 0x0028645C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceApplicationListRequest()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AllianceApplicationListRequest._parser = new MessageParser<AllianceApplicationListRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x00288354 File Offset: 0x00286554
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool q246yDJKR3ic2OUIbTDm()
		{
			return true;
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x0028835C File Offset: 0x0028655C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceApplicationListRequest hLjQxLJKOjxEJwcZjH6b()
		{
			return null;
		}

		// Token: 0x04003B6D RID: 15213
		private static readonly MessageParser<AllianceApplicationListRequest> _parser;

		// Token: 0x04003B6E RID: 15214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B6F RID: 15215
		public const int OffsetFieldNumber = 1;

		// Token: 0x04003B70 RID: 15216
		private long offset_;

		// Token: 0x04003B71 RID: 15217
		public const int CountFieldNumber = 2;

		// Token: 0x04003B72 RID: 15218
		private long count_;

		// Token: 0x04003B73 RID: 15219
		internal static AllianceApplicationListRequest q7I1uZJK3eXs6XNNt3eV;
	}
}
