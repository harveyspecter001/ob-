using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003DB RID: 987
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobCrafterDirectorySettings : IMessage<JobCrafterDirectorySettings>, IMessage, IEquatable<JobCrafterDirectorySettings>, IDeepCloneable<JobCrafterDirectorySettings>, IBufferMessage
	{
		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x001CF09C File Offset: 0x001CD29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobCrafterDirectorySettings> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x001CF0AC File Offset: 0x001CD2AC
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

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x001CF0BC File Offset: 0x001CD2BC
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

		// Token: 0x06002E67 RID: 11879 RVA: 0x001CF0CC File Offset: 0x001CD2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettings()
		{
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x001CF0DC File Offset: 0x001CD2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettings(JobCrafterDirectorySettings other)
		{
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x001CF0EC File Offset: 0x001CD2EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobCrafterDirectorySettings Clone()
		{
			return null;
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x001CF0FC File Offset: 0x001CD2FC
		// (set) Token: 0x06002E6B RID: 11883 RVA: 0x001CF10C File Offset: 0x001CD30C
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

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x001CF11C File Offset: 0x001CD31C
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x001CF12C File Offset: 0x001CD32C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x001CF13C File Offset: 0x001CD33C
		// (set) Token: 0x06002E6F RID: 11887 RVA: 0x001CF14C File Offset: 0x001CD34C
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

		// Token: 0x06002E70 RID: 11888 RVA: 0x001CF15C File Offset: 0x001CD35C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x001CF16C File Offset: 0x001CD36C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobCrafterDirectorySettings other)
		{
			return true;
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x001CF17C File Offset: 0x001CD37C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x001CF18C File Offset: 0x001CD38C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x001CF19C File Offset: 0x001CD39C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x001CF1AC File Offset: 0x001CD3AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x001CF1BC File Offset: 0x001CD3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x001CF1CC File Offset: 0x001CD3CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobCrafterDirectorySettings other)
		{
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x001CF1DC File Offset: 0x001CD3DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x001CF1EC File Offset: 0x001CD3EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x001CF1FC File Offset: 0x001CD3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobCrafterDirectorySettings()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				JobCrafterDirectorySettings._parser = new MessageParser<JobCrafterDirectorySettings>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x001CF2C8 File Offset: 0x001CD4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nt6c25O0OjXKH4JLdITB()
		{
			return true;
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x001CF2D0 File Offset: 0x001CD4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobCrafterDirectorySettings b1tpwYO0JBZ2lEmqtriS()
		{
			return null;
		}

		// Token: 0x04001057 RID: 4183
		private static readonly MessageParser<JobCrafterDirectorySettings> _parser;

		// Token: 0x04001058 RID: 4184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001059 RID: 4185
		public const int JobIdFieldNumber = 1;

		// Token: 0x0400105A RID: 4186
		private int jobId_;

		// Token: 0x0400105B RID: 4187
		public const int MinLevelFieldNumber = 2;

		// Token: 0x0400105C RID: 4188
		private int minLevel_;

		// Token: 0x0400105D RID: 4189
		public const int FreeFieldNumber = 3;

		// Token: 0x0400105E RID: 4190
		private bool free_;

		// Token: 0x0400105F RID: 4191
		internal static JobCrafterDirectorySettings LBgy0MO0RafJUDpucus8;
	}
}
