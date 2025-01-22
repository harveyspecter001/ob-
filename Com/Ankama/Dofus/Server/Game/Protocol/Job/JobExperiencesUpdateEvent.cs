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
	// Token: 0x020003AD RID: 941
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JobExperiencesUpdateEvent : IMessage<JobExperiencesUpdateEvent>, IMessage, IEquatable<JobExperiencesUpdateEvent>, IDeepCloneable<JobExperiencesUpdateEvent>, IBufferMessage
	{
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x001CD0AC File Offset: 0x001CB2AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<JobExperiencesUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x001CD0BC File Offset: 0x001CB2BC
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

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x001CD0CC File Offset: 0x001CB2CC
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

		// Token: 0x06002C27 RID: 11303 RVA: 0x001CD0DC File Offset: 0x001CB2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperiencesUpdateEvent()
		{
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x001CD0EC File Offset: 0x001CB2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperiencesUpdateEvent(JobExperiencesUpdateEvent other)
		{
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x001CD0FC File Offset: 0x001CB2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobExperiencesUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x001CD10C File Offset: 0x001CB30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JobExperience> Experiences
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x001CD11C File Offset: 0x001CB31C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x001CD12C File Offset: 0x001CB32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JobExperiencesUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x001CD13C File Offset: 0x001CB33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x001CD14C File Offset: 0x001CB34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x001CD15C File Offset: 0x001CB35C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x001CD16C File Offset: 0x001CB36C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x001CD17C File Offset: 0x001CB37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x001CD18C File Offset: 0x001CB38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JobExperiencesUpdateEvent other)
		{
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x001CD19C File Offset: 0x001CB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x001CD1AC File Offset: 0x001CB3AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x001CD1BC File Offset: 0x001CB3BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JobExperiencesUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					JobExperiencesUpdateEvent._parser = new MessageParser<JobExperiencesUpdateEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				JobExperiencesUpdateEvent._repeated_experiences_codec = FieldCodec.ForMessage<JobExperience>(10U, WOZoyNn712Lf7NVwasDF.XVInXhlssT(WOZoyNn712Lf7NVwasDF.PXMn7aySKxK));
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x001CD2D8 File Offset: 0x001CB4D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UvGA5FOVvXiyJILZto2x()
		{
			return true;
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x001CD2E0 File Offset: 0x001CB4E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JobExperiencesUpdateEvent OdXgHMOVoLsjmQvR03hB()
		{
			return null;
		}

		// Token: 0x04000F88 RID: 3976
		private static readonly MessageParser<JobExperiencesUpdateEvent> _parser;

		// Token: 0x04000F89 RID: 3977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F8A RID: 3978
		public const int ExperiencesFieldNumber = 1;

		// Token: 0x04000F8B RID: 3979
		private static readonly FieldCodec<JobExperience> _repeated_experiences_codec;

		// Token: 0x04000F8C RID: 3980
		private readonly RepeatedField<JobExperience> experiences_;

		// Token: 0x04000F8D RID: 3981
		private static JobExperiencesUpdateEvent kcHfywOVUyYX1QP7T28B;
	}
}
