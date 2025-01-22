using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002C0 RID: 704
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoJoinDeactivatedEvent : IMessage<FightAutoJoinDeactivatedEvent>, IMessage, IEquatable<FightAutoJoinDeactivatedEvent>, IDeepCloneable<FightAutoJoinDeactivatedEvent>, IBufferMessage
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x001BA408 File Offset: 0x001B8608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightAutoJoinDeactivatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x001BA418 File Offset: 0x001B8618
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

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x001BA428 File Offset: 0x001B8628
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

		// Token: 0x060020AB RID: 8363 RVA: 0x001BA438 File Offset: 0x001B8638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivatedEvent()
		{
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x001BA448 File Offset: 0x001B8648
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivatedEvent(FightAutoJoinDeactivatedEvent other)
		{
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x001BA458 File Offset: 0x001B8658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x001BA468 File Offset: 0x001B8668
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x001BA478 File Offset: 0x001B8678
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

		// Token: 0x060020B0 RID: 8368 RVA: 0x001BA488 File Offset: 0x001B8688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x001BA498 File Offset: 0x001B8698
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoJoinDeactivatedEvent other)
		{
			return true;
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x001BA4A8 File Offset: 0x001B86A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x001BA4B8 File Offset: 0x001B86B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x001BA4C8 File Offset: 0x001B86C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x001BA4D8 File Offset: 0x001B86D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x001BA4E8 File Offset: 0x001B86E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x001BA4F8 File Offset: 0x001B86F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoJoinDeactivatedEvent other)
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x001BA508 File Offset: 0x001B8708
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x001BA518 File Offset: 0x001B8718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x001BA528 File Offset: 0x001B8728
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoJoinDeactivatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						FightAutoJoinDeactivatedEvent._parser = new MessageParser<FightAutoJoinDeactivatedEvent>(() => null);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				}
				IL_6F:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
				continue;
				goto IL_6F;
			}
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x001BA610 File Offset: 0x001B8810
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yEWLadO6cO2TAWtuwUkv()
		{
			return true;
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x001BA618 File Offset: 0x001B8818
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoJoinDeactivatedEvent e6XiPuO6UCXPHawj3jps()
		{
			return null;
		}

		// Token: 0x04000B73 RID: 2931
		private static readonly MessageParser<FightAutoJoinDeactivatedEvent> _parser;

		// Token: 0x04000B74 RID: 2932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B75 RID: 2933
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04000B76 RID: 2934
		private long playerId_;

		// Token: 0x04000B77 RID: 2935
		internal static FightAutoJoinDeactivatedEvent YGuZahO6l6bhVnoZMG6q;
	}
}
