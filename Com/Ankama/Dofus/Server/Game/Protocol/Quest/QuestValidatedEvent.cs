using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001B2 RID: 434
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestValidatedEvent : IMessage<QuestValidatedEvent>, IMessage, IEquatable<QuestValidatedEvent>, IDeepCloneable<QuestValidatedEvent>, IBufferMessage
	{
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x001A550C File Offset: 0x001A370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestValidatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x001A551C File Offset: 0x001A371C
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x001A552C File Offset: 0x001A372C
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

		// Token: 0x06001438 RID: 5176 RVA: 0x001A553C File Offset: 0x001A373C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestValidatedEvent()
		{
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x001A554C File Offset: 0x001A374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestValidatedEvent(QuestValidatedEvent other)
		{
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x001A555C File Offset: 0x001A375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestValidatedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x001A556C File Offset: 0x001A376C
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x001A557C File Offset: 0x001A377C
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

		// Token: 0x0600143D RID: 5181 RVA: 0x001A558C File Offset: 0x001A378C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x001A559C File Offset: 0x001A379C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestValidatedEvent other)
		{
			return true;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x001A55AC File Offset: 0x001A37AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x001A55BC File Offset: 0x001A37BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x001A55CC File Offset: 0x001A37CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x001A55DC File Offset: 0x001A37DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x001A55EC File Offset: 0x001A37EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x001A55FC File Offset: 0x001A37FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestValidatedEvent other)
		{
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x001A560C File Offset: 0x001A380C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x001A561C File Offset: 0x001A381C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x001A562C File Offset: 0x001A382C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestValidatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					QuestValidatedEvent._parser = new MessageParser<QuestValidatedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x001A56F8 File Offset: 0x001A38F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool njHgF4OoQmFEwNfTOF1w()
		{
			return true;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x001A5700 File Offset: 0x001A3900
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestValidatedEvent r0SCCTOo7E0Y4jG8YwsC()
		{
			return null;
		}

		// Token: 0x0400073C RID: 1852
		private static readonly MessageParser<QuestValidatedEvent> _parser;

		// Token: 0x0400073D RID: 1853
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400073E RID: 1854
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400073F RID: 1855
		private int questId_;

		// Token: 0x04000740 RID: 1856
		internal static QuestValidatedEvent eunAPpOowFNd4GgPDtLP;
	}
}
