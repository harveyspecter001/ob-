using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002C8 RID: 712
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoReadyActivatedEvent : IMessage<FightAutoReadyActivatedEvent>, IMessage, IEquatable<FightAutoReadyActivatedEvent>, IDeepCloneable<FightAutoReadyActivatedEvent>, IBufferMessage
	{
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x001BAA18 File Offset: 0x001B8C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoReadyActivatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x001BAA28 File Offset: 0x001B8C28
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

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x001BAA38 File Offset: 0x001B8C38
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

		// Token: 0x060020F8 RID: 8440 RVA: 0x001BAA48 File Offset: 0x001B8C48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivatedEvent()
		{
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x001BAA58 File Offset: 0x001B8C58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivatedEvent(FightAutoReadyActivatedEvent other)
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x001BAA68 File Offset: 0x001B8C68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoReadyActivatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x001BAA78 File Offset: 0x001B8C78
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x001BAA88 File Offset: 0x001B8C88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
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

		// Token: 0x060020FD RID: 8445 RVA: 0x001BAA98 File Offset: 0x001B8C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x001BAAA8 File Offset: 0x001B8CA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoReadyActivatedEvent other)
		{
			return true;
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x001BAAB8 File Offset: 0x001B8CB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x001BAAC8 File Offset: 0x001B8CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x001BAAD8 File Offset: 0x001B8CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x001BAAE8 File Offset: 0x001B8CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x001BAAF8 File Offset: 0x001B8CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x001BAB08 File Offset: 0x001B8D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoReadyActivatedEvent other)
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x001BAB18 File Offset: 0x001B8D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x001BAB28 File Offset: 0x001B8D28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x001BAB38 File Offset: 0x001B8D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoReadyActivatedEvent()
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
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					FightAutoReadyActivatedEvent._parser = new MessageParser<FightAutoReadyActivatedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x001BAC30 File Offset: 0x001B8E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UQ0KnbO6LiEOJOUb7YVQ()
		{
			return true;
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x001BAC38 File Offset: 0x001B8E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoReadyActivatedEvent mJ01nFO6WkZhs7GNvgIY()
		{
			return null;
		}

		// Token: 0x04000B89 RID: 2953
		private static readonly MessageParser<FightAutoReadyActivatedEvent> _parser;

		// Token: 0x04000B8A RID: 2954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B8B RID: 2955
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000B8C RID: 2956
		private long playerId_;

		// Token: 0x04000B8D RID: 2957
		private static FightAutoReadyActivatedEvent GMfaJGO661u3yeKqfKlq;
	}
}
