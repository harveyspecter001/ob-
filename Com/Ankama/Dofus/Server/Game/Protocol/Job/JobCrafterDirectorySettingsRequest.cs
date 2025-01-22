using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003A7 RID: 935
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectorySettingsRequest : IMessage<JobCrafterDirectorySettingsRequest>, IMessage, IEquatable<JobCrafterDirectorySettingsRequest>, IDeepCloneable<JobCrafterDirectorySettingsRequest>, IBufferMessage
	{
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x001CCA50 File Offset: 0x001CAC50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobCrafterDirectorySettingsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x001CCA60 File Offset: 0x001CAC60
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

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x001CCA70 File Offset: 0x001CAC70
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

		// Token: 0x06002BD8 RID: 11224 RVA: 0x001CCA80 File Offset: 0x001CAC80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettingsRequest()
		{
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x001CCA90 File Offset: 0x001CAC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettingsRequest(JobCrafterDirectorySettingsRequest other)
		{
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x001CCAA0 File Offset: 0x001CACA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettingsRequest Clone()
		{
			return null;
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x001CCAB0 File Offset: 0x001CACB0
		// (set) Token: 0x06002BDC RID: 11228 RVA: 0x001CCAC0 File Offset: 0x001CACC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public JobCrafterDirectorySettings Settings
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

		// Token: 0x06002BDD RID: 11229 RVA: 0x001CCAD0 File Offset: 0x001CACD0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x001CCAE0 File Offset: 0x001CACE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectorySettingsRequest other)
		{
			return true;
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x001CCAF0 File Offset: 0x001CACF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x001CCB00 File Offset: 0x001CAD00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x001CCB10 File Offset: 0x001CAD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x001CCB20 File Offset: 0x001CAD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x001CCB30 File Offset: 0x001CAD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x001CCB40 File Offset: 0x001CAD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectorySettingsRequest other)
		{
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x001CCB50 File Offset: 0x001CAD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x001CCB60 File Offset: 0x001CAD60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x001CCB70 File Offset: 0x001CAD70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectorySettingsRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					JobCrafterDirectorySettingsRequest._parser = new MessageParser<JobCrafterDirectorySettingsRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x001CCC54 File Offset: 0x001CAE54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ovxUgEOVxrYcZ65NLLhd()
		{
			return true;
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x001CCC5C File Offset: 0x001CAE5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectorySettingsRequest mdRGmAOV4wdlZ1Sctv9B()
		{
			return null;
		}

		// Token: 0x04000F70 RID: 3952
		private static readonly MessageParser<JobCrafterDirectorySettingsRequest> _parser;

		// Token: 0x04000F71 RID: 3953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F72 RID: 3954
		public const int SettingsFieldNumber = 1;

		// Token: 0x04000F73 RID: 3955
		private JobCrafterDirectorySettings settings_;

		// Token: 0x04000F74 RID: 3956
		private static JobCrafterDirectorySettingsRequest M1rp1oOVNlw1XTdHX05X;
	}
}
