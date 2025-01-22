using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job
{
	// Token: 0x020003A9 RID: 937
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobDescriptionEvent : IMessage<JobDescriptionEvent>, IMessage, IEquatable<JobDescriptionEvent>, IDeepCloneable<JobDescriptionEvent>, IBufferMessage
	{
		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x001CCC64 File Offset: 0x001CAE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JobDescriptionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x001CCC74 File Offset: 0x001CAE74
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

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x001CCC84 File Offset: 0x001CAE84
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

		// Token: 0x06002BF2 RID: 11250 RVA: 0x001CCC94 File Offset: 0x001CAE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobDescriptionEvent()
		{
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x001CCCA4 File Offset: 0x001CAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobDescriptionEvent(JobDescriptionEvent other)
		{
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x001CCCB4 File Offset: 0x001CAEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobDescriptionEvent Clone()
		{
			return null;
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x001CCCC4 File Offset: 0x001CAEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JobDescription> Jobs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x001CCCD4 File Offset: 0x001CAED4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x001CCCE4 File Offset: 0x001CAEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobDescriptionEvent other)
		{
			return true;
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x001CCCF4 File Offset: 0x001CAEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x001CCD04 File Offset: 0x001CAF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x001CCD14 File Offset: 0x001CAF14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x001CCD24 File Offset: 0x001CAF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x001CCD34 File Offset: 0x001CAF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x001CCD44 File Offset: 0x001CAF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobDescriptionEvent other)
		{
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x001CCD54 File Offset: 0x001CAF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x001CCD64 File Offset: 0x001CAF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x001CCD74 File Offset: 0x001CAF74
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobDescriptionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						JobDescriptionEvent._repeated_jobs_codec = FieldCodec.ForMessage<JobDescription>(10U, jZHs2tn74Vn4ysT08EcY.XVInXhlssT(jZHs2tn74Vn4ysT08EcY.xAqn7jWdQDR));
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						JobDescriptionEvent._parser = new MessageParser<JobDescriptionEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 2;
						continue;
					case 4:
						goto IL_72;
					case 5:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					return;
				}
				IL_72:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x001CCE80 File Offset: 0x001CB080
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool msdFasOVKYmtYf13NmyT()
		{
			return true;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x001CCE88 File Offset: 0x001CB088
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobDescriptionEvent HAaTrBOVI1FNfIJbqhAC()
		{
			return null;
		}

		// Token: 0x04000F77 RID: 3959
		private static readonly MessageParser<JobDescriptionEvent> _parser;

		// Token: 0x04000F78 RID: 3960
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F79 RID: 3961
		public const int JobsFieldNumber = 1;

		// Token: 0x04000F7A RID: 3962
		private static readonly FieldCodec<JobDescription> _repeated_jobs_codec;

		// Token: 0x04000F7B RID: 3963
		private readonly RepeatedField<JobDescription> jobs_;

		// Token: 0x04000F7C RID: 3964
		private static JobDescriptionEvent QTdy8EOVjJptpmZX9Cjw;
	}
}
