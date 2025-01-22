using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest
{
	// Token: 0x020001B4 RID: 436
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuestObjectiveValidatedEvent : IMessage<QuestObjectiveValidatedEvent>, IMessage, IEquatable<QuestObjectiveValidatedEvent>, IDeepCloneable<QuestObjectiveValidatedEvent>, IBufferMessage
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x001A5708 File Offset: 0x001A3908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestObjectiveValidatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x001A5718 File Offset: 0x001A3918
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x001A5728 File Offset: 0x001A3928
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

		// Token: 0x06001452 RID: 5202 RVA: 0x001A5738 File Offset: 0x001A3938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveValidatedEvent()
		{
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x001A5748 File Offset: 0x001A3948
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveValidatedEvent(QuestObjectiveValidatedEvent other)
		{
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x001A5758 File Offset: 0x001A3958
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public QuestObjectiveValidatedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x001A5768 File Offset: 0x001A3968
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x001A5778 File Offset: 0x001A3978
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

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x001A5788 File Offset: 0x001A3988
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x001A5798 File Offset: 0x001A3998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectiveId
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

		// Token: 0x06001459 RID: 5209 RVA: 0x001A57A8 File Offset: 0x001A39A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x001A57B8 File Offset: 0x001A39B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(QuestObjectiveValidatedEvent other)
		{
			return true;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x001A57C8 File Offset: 0x001A39C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x001A57D8 File Offset: 0x001A39D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x001A57E8 File Offset: 0x001A39E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x001A57F8 File Offset: 0x001A39F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x001A5808 File Offset: 0x001A3A08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x001A5818 File Offset: 0x001A3A18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(QuestObjectiveValidatedEvent other)
		{
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x001A5828 File Offset: 0x001A3A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x001A5838 File Offset: 0x001A3A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x001A5848 File Offset: 0x001A3A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		static QuestObjectiveValidatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					QuestObjectiveValidatedEvent._parser = new MessageParser<QuestObjectiveValidatedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x001A5914 File Offset: 0x001A3B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool f1ZHhPOopKk7CuFwDU39()
		{
			return true;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x001A591C File Offset: 0x001A3B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static QuestObjectiveValidatedEvent fiNxpZOoHhIsJ5NWWWgj()
		{
			return null;
		}

		// Token: 0x04000743 RID: 1859
		private static readonly MessageParser<QuestObjectiveValidatedEvent> _parser;

		// Token: 0x04000744 RID: 1860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000745 RID: 1861
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000746 RID: 1862
		private int questId_;

		// Token: 0x04000747 RID: 1863
		public const int ObjectiveIdFieldNumber = 2;

		// Token: 0x04000748 RID: 1864
		private int objectiveId_;

		// Token: 0x04000749 RID: 1865
		private static QuestObjectiveValidatedEvent EVadWnOoTPac7HAYUNC0;
	}
}
