using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000097 RID: 151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportToBuddyClosedEvent : IMessage<TeleportToBuddyClosedEvent>, IMessage, IEquatable<TeleportToBuddyClosedEvent>, IDeepCloneable<TeleportToBuddyClosedEvent>, IBufferMessage
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0018CB8C File Offset: 0x0018AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportToBuddyClosedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0018CB9C File Offset: 0x0018AD9C
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0018CBAC File Offset: 0x0018ADAC
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

		// Token: 0x06000653 RID: 1619 RVA: 0x0018CBBC File Offset: 0x0018ADBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyClosedEvent()
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0018CBCC File Offset: 0x0018ADCC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyClosedEvent(TeleportToBuddyClosedEvent other)
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0018CBDC File Offset: 0x0018ADDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportToBuddyClosedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0018CBEC File Offset: 0x0018ADEC
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x0018CBFC File Offset: 0x0018ADFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0018CC0C File Offset: 0x0018AE0C
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0018CC1C File Offset: 0x0018AE1C
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

		// Token: 0x0600065A RID: 1626 RVA: 0x0018CC2C File Offset: 0x0018AE2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0018CC3C File Offset: 0x0018AE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportToBuddyClosedEvent other)
		{
			return true;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0018CC4C File Offset: 0x0018AE4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0018CC5C File Offset: 0x0018AE5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0018CC6C File Offset: 0x0018AE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0018CC7C File Offset: 0x0018AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0018CC8C File Offset: 0x0018AE8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0018CC9C File Offset: 0x0018AE9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportToBuddyClosedEvent other)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0018CCAC File Offset: 0x0018AEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0018CCBC File Offset: 0x0018AEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0018CCCC File Offset: 0x0018AECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportToBuddyClosedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				TeleportToBuddyClosedEvent._parser = new MessageParser<TeleportToBuddyClosedEvent>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0018CDC4 File Offset: 0x0018AFC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iFwO8POI2e3e04LpXVap()
		{
			return true;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0018CDCC File Offset: 0x0018AFCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportToBuddyClosedEvent wV9TP2OIEv1nXE4ah0rQ()
		{
			return null;
		}

		// Token: 0x0400025E RID: 606
		private static readonly MessageParser<TeleportToBuddyClosedEvent> _parser;

		// Token: 0x0400025F RID: 607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000260 RID: 608
		public const int DungeonIdFieldNumber = 1;

		// Token: 0x04000261 RID: 609
		private int dungeonId_;

		// Token: 0x04000262 RID: 610
		public const int BuddyIdFieldNumber = 2;

		// Token: 0x04000263 RID: 611
		private long buddyId_;

		// Token: 0x04000264 RID: 612
		internal static TeleportToBuddyClosedEvent UyjR5hOI9ShUOnthZK3q;
	}
}
