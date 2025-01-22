using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x02000093 RID: 147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportBuddiesRequestedEvent : IMessage<TeleportBuddiesRequestedEvent>, IMessage, IEquatable<TeleportBuddiesRequestedEvent>, IDeepCloneable<TeleportBuddiesRequestedEvent>, IBufferMessage
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0018C6D8 File Offset: 0x0018A8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportBuddiesRequestedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0018C6E8 File Offset: 0x0018A8E8
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0018C6F8 File Offset: 0x0018A8F8
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

		// Token: 0x06000618 RID: 1560 RVA: 0x0018C708 File Offset: 0x0018A908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesRequestedEvent()
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0018C718 File Offset: 0x0018A918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesRequestedEvent(TeleportBuddiesRequestedEvent other)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0018C728 File Offset: 0x0018A928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportBuddiesRequestedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0018C738 File Offset: 0x0018A938
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0018C748 File Offset: 0x0018A948
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0018C758 File Offset: 0x0018A958
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x0018C768 File Offset: 0x0018A968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long InviterId
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0018C778 File Offset: 0x0018A978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<long> InvalidBuddiesId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0018C788 File Offset: 0x0018A988
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0018C798 File Offset: 0x0018A998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportBuddiesRequestedEvent other)
		{
			return true;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0018C7A8 File Offset: 0x0018A9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0018C7B8 File Offset: 0x0018A9B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0018C7C8 File Offset: 0x0018A9C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0018C7D8 File Offset: 0x0018A9D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0018C7E8 File Offset: 0x0018A9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0018C7F8 File Offset: 0x0018A9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportBuddiesRequestedEvent other)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0018C808 File Offset: 0x0018AA08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0018C818 File Offset: 0x0018AA18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0018C828 File Offset: 0x0018AA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportBuddiesRequestedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TeleportBuddiesRequestedEvent._parser = new MessageParser<TeleportBuddiesRequestedEvent>(() => null);
					num2 = 3;
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					TeleportBuddiesRequestedEvent._repeated_invalidBuddiesId_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(26U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3d95367ca96c4434aae6fc13e6731c2c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb8096ad37114ad3a791519b69a785d5 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0018C928 File Offset: 0x0018AB28
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JSQUO9OIJiGL0KnEQnQQ()
		{
			return true;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0018C930 File Offset: 0x0018AB30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportBuddiesRequestedEvent HmYCfIOIGp1SX1YaVj2d()
		{
			return null;
		}

		// Token: 0x04000247 RID: 583
		private static readonly MessageParser<TeleportBuddiesRequestedEvent> _parser;

		// Token: 0x04000248 RID: 584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000249 RID: 585
		public const int DungeonIdFieldNumber = 1;

		// Token: 0x0400024A RID: 586
		private int dungeonId_;

		// Token: 0x0400024B RID: 587
		public const int InviterIdFieldNumber = 2;

		// Token: 0x0400024C RID: 588
		private long inviterId_;

		// Token: 0x0400024D RID: 589
		public const int InvalidBuddiesIdFieldNumber = 3;

		// Token: 0x0400024E RID: 590
		private static readonly FieldCodec<long> _repeated_invalidBuddiesId_codec;

		// Token: 0x0400024F RID: 591
		private readonly RepeatedField<long> invalidBuddiesId_;

		// Token: 0x04000250 RID: 592
		internal static TeleportBuddiesRequestedEvent q4QcSoOIO8SN9moa7lHR;
	}
}
