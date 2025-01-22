using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003A5 RID: 933
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectoryListRequest : IMessage<JobCrafterDirectoryListRequest>, IMessage, IEquatable<JobCrafterDirectoryListRequest>, IDeepCloneable<JobCrafterDirectoryListRequest>, IBufferMessage
	{
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x001CC838 File Offset: 0x001CAA38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobCrafterDirectoryListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x001CC848 File Offset: 0x001CAA48
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

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x001CC858 File Offset: 0x001CAA58
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

		// Token: 0x06002BBE RID: 11198 RVA: 0x001CC868 File Offset: 0x001CAA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryListRequest()
		{
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x001CC878 File Offset: 0x001CAA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryListRequest(JobCrafterDirectoryListRequest other)
		{
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x001CC888 File Offset: 0x001CAA88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectoryListRequest Clone()
		{
			return null;
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x001CC898 File Offset: 0x001CAA98
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x001CC8A8 File Offset: 0x001CAAA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06002BC3 RID: 11203 RVA: 0x001CC8B8 File Offset: 0x001CAAB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x001CC8C8 File Offset: 0x001CAAC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectoryListRequest other)
		{
			return true;
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x001CC8D8 File Offset: 0x001CAAD8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x001CC8E8 File Offset: 0x001CAAE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x001CC8F8 File Offset: 0x001CAAF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x001CC908 File Offset: 0x001CAB08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x001CC918 File Offset: 0x001CAB18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x001CC928 File Offset: 0x001CAB28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectoryListRequest other)
		{
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x001CC938 File Offset: 0x001CAB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x001CC948 File Offset: 0x001CAB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x001CC958 File Offset: 0x001CAB58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectoryListRequest()
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
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						return;
					}
					break;
				}
				IL_36:
				JobCrafterDirectoryListRequest._parser = new MessageParser<JobCrafterDirectoryListRequest>(() => null);
				num = 4;
				continue;
				goto IL_36;
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x001CCA40 File Offset: 0x001CAC40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eq3E4YOVEnF1lqPH7wey()
		{
			return true;
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x001CCA48 File Offset: 0x001CAC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectoryListRequest IAgHAgOVXDY75nbOGYoY()
		{
			return null;
		}

		// Token: 0x04000F69 RID: 3945
		private static readonly MessageParser<JobCrafterDirectoryListRequest> _parser;

		// Token: 0x04000F6A RID: 3946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F6B RID: 3947
		public const int JobIdFieldNumber = 1;

		// Token: 0x04000F6C RID: 3948
		private int jobId_;

		// Token: 0x04000F6D RID: 3949
		internal static JobCrafterDirectoryListRequest OsvpNNOV2o0pEVTaMKk4;
	}
}
