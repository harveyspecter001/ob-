using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001B6 RID: 438
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestStepValidatedEvent : IMessage<QuestStepValidatedEvent>, IMessage, IEquatable<QuestStepValidatedEvent>, IDeepCloneable<QuestStepValidatedEvent>, IBufferMessage
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x001A5924 File Offset: 0x001A3B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestStepValidatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x001A5934 File Offset: 0x001A3B34
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x001A5944 File Offset: 0x001A3B44
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

		// Token: 0x0600146E RID: 5230 RVA: 0x001A5954 File Offset: 0x001A3B54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepValidatedEvent()
		{
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x001A5964 File Offset: 0x001A3B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepValidatedEvent(QuestStepValidatedEvent other)
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x001A5974 File Offset: 0x001A3B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepValidatedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x001A5984 File Offset: 0x001A3B84
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x001A5994 File Offset: 0x001A3B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x001A59A4 File Offset: 0x001A3BA4
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x001A59B4 File Offset: 0x001A3BB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int StepId
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

		// Token: 0x06001475 RID: 5237 RVA: 0x001A59C4 File Offset: 0x001A3BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x001A59D4 File Offset: 0x001A3BD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestStepValidatedEvent other)
		{
			return true;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x001A59E4 File Offset: 0x001A3BE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x001A59F4 File Offset: 0x001A3BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x001A5A04 File Offset: 0x001A3C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x001A5A14 File Offset: 0x001A3C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x001A5A24 File Offset: 0x001A3C24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x001A5A34 File Offset: 0x001A3C34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestStepValidatedEvent other)
		{
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x001A5A44 File Offset: 0x001A3C44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x001A5A54 File Offset: 0x001A3C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x001A5A64 File Offset: 0x001A3C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestStepValidatedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				QuestStepValidatedEvent._parser = new MessageParser<QuestStepValidatedEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_274177d15b49437b930eadc18b6bc419 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x001A5B48 File Offset: 0x001A3D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool rUiT0IOob1Zb5ToqXJCm()
		{
			return true;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x001A5B50 File Offset: 0x001A3D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestStepValidatedEvent hmtWhKOoiqDwxCIAigxS()
		{
			return null;
		}

		// Token: 0x0400074C RID: 1868
		private static readonly MessageParser<QuestStepValidatedEvent> _parser;

		// Token: 0x0400074D RID: 1869
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400074E RID: 1870
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400074F RID: 1871
		private int questId_;

		// Token: 0x04000750 RID: 1872
		public const int StepIdFieldNumber = 2;

		// Token: 0x04000751 RID: 1873
		private int stepId_;

		// Token: 0x04000752 RID: 1874
		private static QuestStepValidatedEvent qjy53JOoY3oIhsA05H2H;
	}
}
