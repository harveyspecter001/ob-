using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000095 RID: 149
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportToBuddyOfferEvent : IMessage<TeleportToBuddyOfferEvent>, IMessage, IEquatable<TeleportToBuddyOfferEvent>, IDeepCloneable<TeleportToBuddyOfferEvent>, IBufferMessage
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0018C938 File Offset: 0x0018AB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportToBuddyOfferEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0018C948 File Offset: 0x0018AB48
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0018C958 File Offset: 0x0018AB58
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

		// Token: 0x06000635 RID: 1589 RVA: 0x0018C968 File Offset: 0x0018AB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyOfferEvent()
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0018C978 File Offset: 0x0018AB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyOfferEvent(TeleportToBuddyOfferEvent other)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0018C988 File Offset: 0x0018AB88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyOfferEvent Clone()
		{
			return null;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0018C998 File Offset: 0x0018AB98
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x0018C9A8 File Offset: 0x0018ABA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonId
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0018C9B8 File Offset: 0x0018ABB8
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x0018C9C8 File Offset: 0x0018ABC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuddyId
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0018C9D8 File Offset: 0x0018ABD8
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x0018C9E8 File Offset: 0x0018ABE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimeLeft
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

		// Token: 0x0600063E RID: 1598 RVA: 0x0018C9F8 File Offset: 0x0018ABF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0018CA08 File Offset: 0x0018AC08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportToBuddyOfferEvent other)
		{
			return true;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0018CA18 File Offset: 0x0018AC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0018CA28 File Offset: 0x0018AC28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0018CA38 File Offset: 0x0018AC38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0018CA48 File Offset: 0x0018AC48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0018CA58 File Offset: 0x0018AC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0018CA68 File Offset: 0x0018AC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportToBuddyOfferEvent other)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0018CA78 File Offset: 0x0018AC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0018CA88 File Offset: 0x0018AC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0018CA98 File Offset: 0x0018AC98
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportToBuddyOfferEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					TeleportToBuddyOfferEvent._parser = new MessageParser<TeleportToBuddyOfferEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0018CB7C File Offset: 0x0018AD7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Rayi79OIsVsUeSniB1KB()
		{
			return true;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0018CB84 File Offset: 0x0018AD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportToBuddyOfferEvent JKcvXYOIdRYnBAyEdnyp()
		{
			return null;
		}

		// Token: 0x04000253 RID: 595
		private static readonly MessageParser<TeleportToBuddyOfferEvent> _parser;

		// Token: 0x04000254 RID: 596
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000255 RID: 597
		public const int DungeonIdFieldNumber = 1;

		// Token: 0x04000256 RID: 598
		private int dungeonId_;

		// Token: 0x04000257 RID: 599
		public const int BuddyIdFieldNumber = 2;

		// Token: 0x04000258 RID: 600
		private long buddyId_;

		// Token: 0x04000259 RID: 601
		public const int TimeLeftFieldNumber = 3;

		// Token: 0x0400025A RID: 602
		private int timeLeft_;

		// Token: 0x0400025B RID: 603
		internal static TeleportToBuddyOfferEvent Gjxq6HOIgKQOCeMjYfAc;
	}
}
