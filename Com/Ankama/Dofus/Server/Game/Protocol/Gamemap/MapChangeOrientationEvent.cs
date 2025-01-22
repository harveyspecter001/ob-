using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200058C RID: 1420
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapChangeOrientationEvent : IMessage<MapChangeOrientationEvent>, IMessage, IEquatable<MapChangeOrientationEvent>, IDeepCloneable<MapChangeOrientationEvent>, IBufferMessage
	{
		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x001F64F4 File Offset: 0x001F46F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapChangeOrientationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x001F6504 File Offset: 0x001F4704
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

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x001F6514 File Offset: 0x001F4714
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

		// Token: 0x06004471 RID: 17521 RVA: 0x001F6524 File Offset: 0x001F4724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeOrientationEvent()
		{
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x001F6534 File Offset: 0x001F4734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeOrientationEvent(MapChangeOrientationEvent other)
		{
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x001F6544 File Offset: 0x001F4744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapChangeOrientationEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06004474 RID: 17524 RVA: 0x001F6554 File Offset: 0x001F4754
		// (set) Token: 0x06004475 RID: 17525 RVA: 0x001F6564 File Offset: 0x001F4764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ActorId
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

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x001F6574 File Offset: 0x001F4774
		// (set) Token: 0x06004477 RID: 17527 RVA: 0x001F6588 File Offset: 0x001F4788
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Direction Direction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Direction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x001F6598 File Offset: 0x001F4798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x001F65A8 File Offset: 0x001F47A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapChangeOrientationEvent other)
		{
			return true;
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x001F65B8 File Offset: 0x001F47B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x001F65C8 File Offset: 0x001F47C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x001F65D8 File Offset: 0x001F47D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x001F65E8 File Offset: 0x001F47E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x001F65F8 File Offset: 0x001F47F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x001F6608 File Offset: 0x001F4808
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapChangeOrientationEvent other)
		{
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x001F6618 File Offset: 0x001F4818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x001F6628 File Offset: 0x001F4828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x001F6638 File Offset: 0x001F4838
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapChangeOrientationEvent()
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
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					MapChangeOrientationEvent._parser = new MessageParser<MapChangeOrientationEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bb56171e99ce4222b4fe325d0bc89160 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x001F671C File Offset: 0x001F491C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool fDxD2LOYkQ65lvtJ809U()
		{
			return true;
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x001F6724 File Offset: 0x001F4924
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapChangeOrientationEvent jUhbatOYlwJIdluIPrSe()
		{
			return null;
		}

		// Token: 0x04001789 RID: 6025
		private static readonly MessageParser<MapChangeOrientationEvent> _parser;

		// Token: 0x0400178A RID: 6026
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400178B RID: 6027
		public const int ActorIdFieldNumber = 1;

		// Token: 0x0400178C RID: 6028
		private long actorId_;

		// Token: 0x0400178D RID: 6029
		public const int DirectionFieldNumber = 2;

		// Token: 0x0400178E RID: 6030
		private Direction direction_;

		// Token: 0x0400178F RID: 6031
		internal static MapChangeOrientationEvent HoaKKcOYIKewabXHWZTr;
	}
}
