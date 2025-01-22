using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003D5 RID: 981
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryEntry : IMessage<JobCrafterDirectoryEntry>, IMessage, IEquatable<JobCrafterDirectoryEntry>, IDeepCloneable<JobCrafterDirectoryEntry>, IBufferMessage
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x001CE900 File Offset: 0x001CCB00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobCrafterDirectoryEntry> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x001CE910 File Offset: 0x001CCB10
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

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x001CE920 File Offset: 0x001CCB20
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

		// Token: 0x06002E01 RID: 11777 RVA: 0x001CE930 File Offset: 0x001CCB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryEntry()
		{
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x001CE940 File Offset: 0x001CCB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryEntry(JobCrafterDirectoryEntry other)
		{
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x001CE950 File Offset: 0x001CCB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryEntry Clone()
		{
			return null;
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x001CE960 File Offset: 0x001CCB60
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x001CE970 File Offset: 0x001CCB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JobCrafterDirectoryPlayerInformation PlayerInformation
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x001CE980 File Offset: 0x001CCB80
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x001CE990 File Offset: 0x001CCB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JobCrafterDirectoryJobInformation JobInformation
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

		// Token: 0x06002E08 RID: 11784 RVA: 0x001CE9A0 File Offset: 0x001CCBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x001CE9B0 File Offset: 0x001CCBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryEntry other)
		{
			return true;
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x001CE9C0 File Offset: 0x001CCBC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x001CE9D0 File Offset: 0x001CCBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x001CE9E0 File Offset: 0x001CCBE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x001CE9F0 File Offset: 0x001CCBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x001CEA00 File Offset: 0x001CCC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x001CEA10 File Offset: 0x001CCC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryEntry other)
		{
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x001CEA20 File Offset: 0x001CCC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x001CEA30 File Offset: 0x001CCC30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x001CEA40 File Offset: 0x001CCC40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryEntry()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						JobCrafterDirectoryEntry._parser = new MessageParser<JobCrafterDirectoryEntry>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_5E;
					}
					goto Block_1;
				}
				IL_5E:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
				continue;
				IL_AF:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 2;
				continue;
				Block_1:
				goto IL_AF;
			}
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x001CEB14 File Offset: 0x001CCD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R7XW2TOVzHesc4R5wh6n()
		{
			return true;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x001CEB1C File Offset: 0x001CCD1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryEntry Dk0MOlO0fDfXGbWdaBD9()
		{
			return null;
		}

		// Token: 0x0400102A RID: 4138
		private static readonly MessageParser<JobCrafterDirectoryEntry> _parser;

		// Token: 0x0400102B RID: 4139
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400102C RID: 4140
		public const int PlayerInformationFieldNumber = 1;

		// Token: 0x0400102D RID: 4141
		private JobCrafterDirectoryPlayerInformation playerInformation_;

		// Token: 0x0400102E RID: 4142
		public const int JobInformationFieldNumber = 2;

		// Token: 0x0400102F RID: 4143
		private JobCrafterDirectoryJobInformation jobInformation_;

		// Token: 0x04001030 RID: 4144
		private static JobCrafterDirectoryEntry ztImC7OVFj9MuDcnsVlb;
	}
}
