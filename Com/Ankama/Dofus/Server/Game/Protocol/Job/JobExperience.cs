using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003D3 RID: 979
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobExperience : IMessage<JobExperience>, IMessage, IEquatable<JobExperience>, IDeepCloneable<JobExperience>, IBufferMessage
	{
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x001CE66C File Offset: 0x001CC86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobExperience> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x001CE67C File Offset: 0x001CC87C
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

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x001CE68C File Offset: 0x001CC88C
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

		// Token: 0x06002DDF RID: 11743 RVA: 0x001CE69C File Offset: 0x001CC89C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperience()
		{
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x001CE6AC File Offset: 0x001CC8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperience(JobExperience other)
		{
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x001CE6BC File Offset: 0x001CC8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperience Clone()
		{
			return null;
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x001CE6CC File Offset: 0x001CC8CC
		// (set) Token: 0x06002DE3 RID: 11747 RVA: 0x001CE6DC File Offset: 0x001CC8DC
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x001CE6EC File Offset: 0x001CC8EC
		// (set) Token: 0x06002DE5 RID: 11749 RVA: 0x001CE6FC File Offset: 0x001CC8FC
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

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x001CE70C File Offset: 0x001CC90C
		// (set) Token: 0x06002DE7 RID: 11751 RVA: 0x001CE71C File Offset: 0x001CC91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long JobXp
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

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x001CE72C File Offset: 0x001CC92C
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x001CE73C File Offset: 0x001CC93C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long JobXpLevelFloor
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

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x001CE74C File Offset: 0x001CC94C
		// (set) Token: 0x06002DEB RID: 11755 RVA: 0x001CE75C File Offset: 0x001CC95C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long JobXpNextLevelFloor
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

		// Token: 0x06002DEC RID: 11756 RVA: 0x001CE76C File Offset: 0x001CC96C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x001CE77C File Offset: 0x001CC97C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobExperience other)
		{
			return true;
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x001CE78C File Offset: 0x001CC98C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x001CE79C File Offset: 0x001CC99C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x001CE7AC File Offset: 0x001CC9AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x001CE7BC File Offset: 0x001CC9BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x001CE7CC File Offset: 0x001CC9CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x001CE7DC File Offset: 0x001CC9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobExperience other)
		{
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x001CE7EC File Offset: 0x001CC9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x001CE7FC File Offset: 0x001CC9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x001CE80C File Offset: 0x001CCA0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobExperience()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					JobExperience._parser = new MessageParser<JobExperience>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x001CE8F0 File Offset: 0x001CCAF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eqFSHaOVZKc3o61oQ12I()
		{
			return true;
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x001CE8F8 File Offset: 0x001CCAF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobExperience SkVsbMOVq7x6cSIm0njN()
		{
			return null;
		}

		// Token: 0x0400101B RID: 4123
		private static readonly MessageParser<JobExperience> _parser;

		// Token: 0x0400101C RID: 4124
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400101D RID: 4125
		public const int JobIdFieldNumber = 1;

		// Token: 0x0400101E RID: 4126
		private int jobId_;

		// Token: 0x0400101F RID: 4127
		public const int JobLevelFieldNumber = 2;

		// Token: 0x04001020 RID: 4128
		private int jobLevel_;

		// Token: 0x04001021 RID: 4129
		public const int JobXpFieldNumber = 3;

		// Token: 0x04001022 RID: 4130
		private long jobXp_;

		// Token: 0x04001023 RID: 4131
		public const int JobXpLevelFloorFieldNumber = 4;

		// Token: 0x04001024 RID: 4132
		private long jobXpLevelFloor_;

		// Token: 0x04001025 RID: 4133
		public const int JobXpNextLevelFloorFieldNumber = 5;

		// Token: 0x04001026 RID: 4134
		private long jobXpNextLevelFloor_;

		// Token: 0x04001027 RID: 4135
		internal static JobExperience YtBYiuOV8M5N9q6cVJ05;
	}
}
