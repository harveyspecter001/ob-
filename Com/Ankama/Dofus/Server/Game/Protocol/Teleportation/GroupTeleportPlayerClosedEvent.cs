using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x0200009F RID: 159
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GroupTeleportPlayerClosedEvent : IMessage<GroupTeleportPlayerClosedEvent>, IMessage, IEquatable<GroupTeleportPlayerClosedEvent>, IDeepCloneable<GroupTeleportPlayerClosedEvent>, IBufferMessage
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0018D548 File Offset: 0x0018B748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GroupTeleportPlayerClosedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0018D558 File Offset: 0x0018B758
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0018D568 File Offset: 0x0018B768
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

		// Token: 0x060006CF RID: 1743 RVA: 0x0018D578 File Offset: 0x0018B778
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerClosedEvent()
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0018D588 File Offset: 0x0018B788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerClosedEvent(GroupTeleportPlayerClosedEvent other)
		{
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0018D598 File Offset: 0x0018B798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GroupTeleportPlayerClosedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0018D5A8 File Offset: 0x0018B7A8
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x0018D5B8 File Offset: 0x0018B7B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long MapId
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0018D5C8 File Offset: 0x0018B7C8
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x0018D5D8 File Offset: 0x0018B7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RequesterId
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

		// Token: 0x060006D6 RID: 1750 RVA: 0x0018D5E8 File Offset: 0x0018B7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0018D5F8 File Offset: 0x0018B7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GroupTeleportPlayerClosedEvent other)
		{
			return true;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0018D608 File Offset: 0x0018B808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0018D618 File Offset: 0x0018B818
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0018D628 File Offset: 0x0018B828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0018D638 File Offset: 0x0018B838
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0018D648 File Offset: 0x0018B848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0018D658 File Offset: 0x0018B858
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GroupTeleportPlayerClosedEvent other)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0018D668 File Offset: 0x0018B868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0018D678 File Offset: 0x0018B878
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0018D688 File Offset: 0x0018B888
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GroupTeleportPlayerClosedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				GroupTeleportPlayerClosedEvent._parser = new MessageParser<GroupTeleportPlayerClosedEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0018D780 File Offset: 0x0018B980
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lpXgfkOIUsGyghdSQNNe()
		{
			return true;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0018D788 File Offset: 0x0018B988
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GroupTeleportPlayerClosedEvent nOR0QcOIv8SsLAWsrpyu()
		{
			return null;
		}

		// Token: 0x0400028E RID: 654
		private static readonly MessageParser<GroupTeleportPlayerClosedEvent> _parser;

		// Token: 0x0400028F RID: 655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000290 RID: 656
		public const int MapIdFieldNumber = 1;

		// Token: 0x04000291 RID: 657
		private long mapId_;

		// Token: 0x04000292 RID: 658
		public const int RequesterIdFieldNumber = 2;

		// Token: 0x04000293 RID: 659
		private long requesterId_;

		// Token: 0x04000294 RID: 660
		private static GroupTeleportPlayerClosedEvent j7xK7jOIck56vq9YVyU2;
	}
}
