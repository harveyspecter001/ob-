using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003D9 RID: 985
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryJobInformation : IMessage<JobCrafterDirectoryJobInformation>, IMessage, IEquatable<JobCrafterDirectoryJobInformation>, IDeepCloneable<JobCrafterDirectoryJobInformation>, IBufferMessage
	{
		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x001CEE40 File Offset: 0x001CD040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobCrafterDirectoryJobInformation> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x001CEE50 File Offset: 0x001CD050
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x001CEE60 File Offset: 0x001CD060
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

		// Token: 0x06002E47 RID: 11847 RVA: 0x001CEE70 File Offset: 0x001CD070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryJobInformation()
		{
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x001CEE80 File Offset: 0x001CD080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryJobInformation(JobCrafterDirectoryJobInformation other)
		{
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x001CEE90 File Offset: 0x001CD090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryJobInformation Clone()
		{
			return null;
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x001CEEA0 File Offset: 0x001CD0A0
		// (set) Token: 0x06002E4B RID: 11851 RVA: 0x001CEEB0 File Offset: 0x001CD0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JobId
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x001CEEC0 File Offset: 0x001CD0C0
		// (set) Token: 0x06002E4D RID: 11853 RVA: 0x001CEED0 File Offset: 0x001CD0D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int JobLevel
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x001CEEE0 File Offset: 0x001CD0E0
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x001CEEF0 File Offset: 0x001CD0F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Free
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x001CEF00 File Offset: 0x001CD100
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x001CEF10 File Offset: 0x001CD110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinLevel
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

		// Token: 0x06002E52 RID: 11858 RVA: 0x001CEF20 File Offset: 0x001CD120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x001CEF30 File Offset: 0x001CD130
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryJobInformation other)
		{
			return true;
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x001CEF40 File Offset: 0x001CD140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x001CEF50 File Offset: 0x001CD150
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x001CEF60 File Offset: 0x001CD160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x001CEF70 File Offset: 0x001CD170
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x001CEF80 File Offset: 0x001CD180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x001CEF90 File Offset: 0x001CD190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryJobInformation other)
		{
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x001CEFA0 File Offset: 0x001CD1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x001CEFB0 File Offset: 0x001CD1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x001CEFC0 File Offset: 0x001CD1C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryJobInformation()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					JobCrafterDirectoryJobInformation._parser = new MessageParser<JobCrafterDirectoryJobInformation>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x001CF08C File Offset: 0x001CD28C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool L6ouiQO0eIYHt2yHEQyS()
		{
			return true;
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x001CF094 File Offset: 0x001CD294
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryJobInformation h4U6nRO03gEmq8VpZpxi()
		{
			return null;
		}

		// Token: 0x0400104A RID: 4170
		private static readonly MessageParser<JobCrafterDirectoryJobInformation> _parser;

		// Token: 0x0400104B RID: 4171
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400104C RID: 4172
		public const int JobIdFieldNumber = 1;

		// Token: 0x0400104D RID: 4173
		private int jobId_;

		// Token: 0x0400104E RID: 4174
		public const int JobLevelFieldNumber = 2;

		// Token: 0x0400104F RID: 4175
		private int jobLevel_;

		// Token: 0x04001050 RID: 4176
		public const int FreeFieldNumber = 3;

		// Token: 0x04001051 RID: 4177
		private bool free_;

		// Token: 0x04001052 RID: 4178
		public const int MinLevelFieldNumber = 4;

		// Token: 0x04001053 RID: 4179
		private int minLevel_;

		// Token: 0x04001054 RID: 4180
		internal static JobCrafterDirectoryJobInformation Gh1Wd4O0B6bIqCtcA0kI;
	}
}
