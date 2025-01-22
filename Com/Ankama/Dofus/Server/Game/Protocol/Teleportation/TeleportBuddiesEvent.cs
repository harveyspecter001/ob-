using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000091 RID: 145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportBuddiesEvent : IMessage<TeleportBuddiesEvent>, IMessage, IEquatable<TeleportBuddiesEvent>, IDeepCloneable<TeleportBuddiesEvent>, IBufferMessage
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0018C4DC File Offset: 0x0018A6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportBuddiesEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0018C4EC File Offset: 0x0018A6EC
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0018C4FC File Offset: 0x0018A6FC
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

		// Token: 0x060005FE RID: 1534 RVA: 0x0018C50C File Offset: 0x0018A70C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesEvent()
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0018C51C File Offset: 0x0018A71C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesEvent(TeleportBuddiesEvent other)
		{
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0018C52C File Offset: 0x0018A72C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesEvent Clone()
		{
			return null;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0018C53C File Offset: 0x0018A73C
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0018C54C File Offset: 0x0018A74C
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

		// Token: 0x06000603 RID: 1539 RVA: 0x0018C55C File Offset: 0x0018A75C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0018C56C File Offset: 0x0018A76C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportBuddiesEvent other)
		{
			return true;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0018C57C File Offset: 0x0018A77C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0018C58C File Offset: 0x0018A78C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0018C59C File Offset: 0x0018A79C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0018C5AC File Offset: 0x0018A7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0018C5BC File Offset: 0x0018A7BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0018C5CC File Offset: 0x0018A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportBuddiesEvent other)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0018C5DC File Offset: 0x0018A7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0018C5EC File Offset: 0x0018A7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0018C5FC File Offset: 0x0018A7FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportBuddiesEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					TeleportBuddiesEvent._parser = new MessageParser<TeleportBuddiesEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0018C6C8 File Offset: 0x0018A8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pd47c8OI3Z4n9xCSbVXs()
		{
			return true;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0018C6D0 File Offset: 0x0018A8D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportBuddiesEvent EyYLX1OIRwlpiX4UR8JT()
		{
			return null;
		}

		// Token: 0x04000240 RID: 576
		private static readonly MessageParser<TeleportBuddiesEvent> _parser;

		// Token: 0x04000241 RID: 577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000242 RID: 578
		public const int DungeonIdFieldNumber = 1;

		// Token: 0x04000243 RID: 579
		private int dungeonId_;

		// Token: 0x04000244 RID: 580
		private static TeleportBuddiesEvent uyrAGZOIefZ3ba8b69uC;
	}
}
