using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001B8 RID: 440
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestStepStartedEvent : IMessage<QuestStepStartedEvent>, IMessage, IEquatable<QuestStepStartedEvent>, IDeepCloneable<QuestStepStartedEvent>, IBufferMessage
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x001A5B58 File Offset: 0x001A3D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestStepStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x001A5B68 File Offset: 0x001A3D68
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x001A5B78 File Offset: 0x001A3D78
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

		// Token: 0x0600148A RID: 5258 RVA: 0x001A5B88 File Offset: 0x001A3D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepStartedEvent()
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x001A5B98 File Offset: 0x001A3D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepStartedEvent(QuestStepStartedEvent other)
		{
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x001A5BA8 File Offset: 0x001A3DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestStepStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x001A5BB8 File Offset: 0x001A3DB8
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x001A5BC8 File Offset: 0x001A3DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x001A5BD8 File Offset: 0x001A3DD8
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x001A5BE8 File Offset: 0x001A3DE8
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

		// Token: 0x06001491 RID: 5265 RVA: 0x001A5BF8 File Offset: 0x001A3DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x001A5C08 File Offset: 0x001A3E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestStepStartedEvent other)
		{
			return true;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x001A5C18 File Offset: 0x001A3E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x001A5C28 File Offset: 0x001A3E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x001A5C38 File Offset: 0x001A3E38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x001A5C48 File Offset: 0x001A3E48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x001A5C58 File Offset: 0x001A3E58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x001A5C68 File Offset: 0x001A3E68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestStepStartedEvent other)
		{
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x001A5C78 File Offset: 0x001A3E78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x001A5C88 File Offset: 0x001A3E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x001A5C98 File Offset: 0x001A3E98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestStepStartedEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					QuestStepStartedEvent._parser = new MessageParser<QuestStepStartedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x001A5D64 File Offset: 0x001A3F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EROhbEOoSD6l01BS5TUD()
		{
			return true;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x001A5D6C File Offset: 0x001A3F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestStepStartedEvent IxZkkUOoMnLPo0VfVnmd()
		{
			return null;
		}

		// Token: 0x04000755 RID: 1877
		private static readonly MessageParser<QuestStepStartedEvent> _parser;

		// Token: 0x04000756 RID: 1878
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000757 RID: 1879
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000758 RID: 1880
		private int questId_;

		// Token: 0x04000759 RID: 1881
		public const int StepIdFieldNumber = 2;

		// Token: 0x0400075A RID: 1882
		private int stepId_;

		// Token: 0x0400075B RID: 1883
		internal static QuestStepStartedEvent hVlJCUOoPYtg4h1njGuw;
	}
}
