using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003BF RID: 959
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryRemoveEvent : IMessage<JobCrafterDirectoryRemoveEvent>, IMessage, IEquatable<JobCrafterDirectoryRemoveEvent>, IDeepCloneable<JobCrafterDirectoryRemoveEvent>, IBufferMessage
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x001CDD70 File Offset: 0x001CBF70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobCrafterDirectoryRemoveEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x001CDD80 File Offset: 0x001CBF80
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x001CDD90 File Offset: 0x001CBF90
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

		// Token: 0x06002CFC RID: 11516 RVA: 0x001CDDA0 File Offset: 0x001CBFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryRemoveEvent()
		{
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x001CDDB0 File Offset: 0x001CBFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryRemoveEvent(JobCrafterDirectoryRemoveEvent other)
		{
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x001CDDC0 File Offset: 0x001CBFC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryRemoveEvent Clone()
		{
			return null;
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x001CDDD0 File Offset: 0x001CBFD0
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x001CDDE0 File Offset: 0x001CBFE0
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x001CDDF0 File Offset: 0x001CBFF0
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x001CDE00 File Offset: 0x001CC000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PlayerId
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

		// Token: 0x06002D03 RID: 11523 RVA: 0x001CDE10 File Offset: 0x001CC010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x001CDE20 File Offset: 0x001CC020
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryRemoveEvent other)
		{
			return true;
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x001CDE30 File Offset: 0x001CC030
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x001CDE40 File Offset: 0x001CC040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x001CDE50 File Offset: 0x001CC050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x001CDE60 File Offset: 0x001CC060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x001CDE70 File Offset: 0x001CC070
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x001CDE80 File Offset: 0x001CC080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryRemoveEvent other)
		{
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x001CDE90 File Offset: 0x001CC090
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x001CDEA0 File Offset: 0x001CC0A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x001CDEB0 File Offset: 0x001CC0B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryRemoveEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					JobCrafterDirectoryRemoveEvent._parser = new MessageParser<JobCrafterDirectoryRemoveEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x001CDF94 File Offset: 0x001CC194
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hj4RkYOV7nt0L4oa0Wuj()
		{
			return true;
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x001CDF9C File Offset: 0x001CC19C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryRemoveEvent jOvt2DOVTbGOkgt6gT54()
		{
			return null;
		}

		// Token: 0x04000FCD RID: 4045
		private static readonly MessageParser<JobCrafterDirectoryRemoveEvent> _parser;

		// Token: 0x04000FCE RID: 4046
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FCF RID: 4047
		public const int JobIdFieldNumber = 1;

		// Token: 0x04000FD0 RID: 4048
		private int jobId_;

		// Token: 0x04000FD1 RID: 4049
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04000FD2 RID: 4050
		private long playerId_;

		// Token: 0x04000FD3 RID: 4051
		private static JobCrafterDirectoryRemoveEvent bdXi7jOVQU0ic7Dftf0n;
	}
}
