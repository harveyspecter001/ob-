using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003AB RID: 939
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobLevelUpEvent : IMessage<JobLevelUpEvent>, IMessage, IEquatable<JobLevelUpEvent>, IDeepCloneable<JobLevelUpEvent>, IBufferMessage
	{
		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06002C08 RID: 11272 RVA: 0x001CCE90 File Offset: 0x001CB090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobLevelUpEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x001CCEA0 File Offset: 0x001CB0A0
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x001CCEB0 File Offset: 0x001CB0B0
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

		// Token: 0x06002C0B RID: 11275 RVA: 0x001CCEC0 File Offset: 0x001CB0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobLevelUpEvent()
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x001CCED0 File Offset: 0x001CB0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobLevelUpEvent(JobLevelUpEvent other)
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x001CCEE0 File Offset: 0x001CB0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobLevelUpEvent Clone()
		{
			return null;
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x001CCEF0 File Offset: 0x001CB0F0
		// (set) Token: 0x06002C0F RID: 11279 RVA: 0x001CCF00 File Offset: 0x001CB100
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NewLevel
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x001CCF10 File Offset: 0x001CB110
		// (set) Token: 0x06002C11 RID: 11281 RVA: 0x001CCF20 File Offset: 0x001CB120
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public JobDescription Job
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

		// Token: 0x06002C12 RID: 11282 RVA: 0x001CCF30 File Offset: 0x001CB130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x001CCF40 File Offset: 0x001CB140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobLevelUpEvent other)
		{
			return true;
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x001CCF50 File Offset: 0x001CB150
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x001CCF60 File Offset: 0x001CB160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x001CCF70 File Offset: 0x001CB170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x001CCF80 File Offset: 0x001CB180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x001CCF90 File Offset: 0x001CB190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x001CCFA0 File Offset: 0x001CB1A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobLevelUpEvent other)
		{
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x001CCFB0 File Offset: 0x001CB1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x001CCFC0 File Offset: 0x001CB1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x001CCFD0 File Offset: 0x001CB1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobLevelUpEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					JobLevelUpEvent._parser = new MessageParser<JobLevelUpEvent>(() => null);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x001CD09C File Offset: 0x001CB29C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TWCmmOOVlj4KXp6cTNLd()
		{
			return true;
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x001CD0A4 File Offset: 0x001CB2A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobLevelUpEvent WDPOX5OVccf9p3eASUrk()
		{
			return null;
		}

		// Token: 0x04000F7F RID: 3967
		private static readonly MessageParser<JobLevelUpEvent> _parser;

		// Token: 0x04000F80 RID: 3968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F81 RID: 3969
		public const int NewLevelFieldNumber = 1;

		// Token: 0x04000F82 RID: 3970
		private int newLevel_;

		// Token: 0x04000F83 RID: 3971
		public const int JobFieldNumber = 2;

		// Token: 0x04000F84 RID: 3972
		private JobDescription job_;

		// Token: 0x04000F85 RID: 3973
		internal static JobLevelUpEvent Y7wS17OVkjn69RffeBCV;
	}
}
