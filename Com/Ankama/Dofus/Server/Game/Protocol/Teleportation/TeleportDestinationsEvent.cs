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
	// Token: 0x0200008D RID: 141
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportDestinationsEvent : IMessage<TeleportDestinationsEvent>, IMessage, IEquatable<TeleportDestinationsEvent>, IDeepCloneable<TeleportDestinationsEvent>, IBufferMessage
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0018BFEC File Offset: 0x0018A1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportDestinationsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0018BFFC File Offset: 0x0018A1FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0018C00C File Offset: 0x0018A20C
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

		// Token: 0x060005C6 RID: 1478 RVA: 0x0018C01C File Offset: 0x0018A21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportDestinationsEvent()
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0018C02C File Offset: 0x0018A22C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportDestinationsEvent(TeleportDestinationsEvent other)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0018C03C File Offset: 0x0018A23C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportDestinationsEvent Clone()
		{
			return null;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0018C04C File Offset: 0x0018A24C
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0018C060 File Offset: 0x0018A260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Teleporter Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Teleporter)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0018C070 File Offset: 0x0018A270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TeleportDestination> Destinations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0018C080 File Offset: 0x0018A280
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0018C090 File Offset: 0x0018A290
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SpawnMapId
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0018C0A0 File Offset: 0x0018A2A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasSpawnMapId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0018C0B0 File Offset: 0x0018A2B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSpawnMapId()
		{
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0018C0C0 File Offset: 0x0018A2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0018C0D0 File Offset: 0x0018A2D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportDestinationsEvent other)
		{
			return true;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0018C0E0 File Offset: 0x0018A2E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0018C0F0 File Offset: 0x0018A2F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0018C100 File Offset: 0x0018A300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0018C110 File Offset: 0x0018A310
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0018C120 File Offset: 0x0018A320
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0018C130 File Offset: 0x0018A330
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportDestinationsEvent other)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0018C140 File Offset: 0x0018A340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0018C150 File Offset: 0x0018A350
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0018C160 File Offset: 0x0018A360
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportDestinationsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TeleportDestinationsEvent._repeated_destinations_codec = FieldCodec.ForMessage<TeleportDestination>(18U, edjO57ESK7cipLXaZm6.XVInXhlssT(edjO57ESK7cipLXaZm6.PvsEMkRiXA));
					num2 = 2;
					continue;
				case 2:
					TeleportDestinationsEvent.SpawnMapIdDefaultValue = 0L;
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 6;
					continue;
				case 6:
					TeleportDestinationsEvent._parser = new MessageParser<TeleportDestinationsEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fc95f38c3f7f4096b9c30dd67655cbfd == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0018C290 File Offset: 0x0018A490
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AchywwOIfLVZKnJM4sqf()
		{
			return true;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0018C298 File Offset: 0x0018A498
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportDestinationsEvent E1OeD4OIndyc7eMCmqcQ()
		{
			return null;
		}

		// Token: 0x0400022A RID: 554
		private static readonly MessageParser<TeleportDestinationsEvent> _parser;

		// Token: 0x0400022B RID: 555
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400022C RID: 556
		private int _hasBits0;

		// Token: 0x0400022D RID: 557
		public const int TypeFieldNumber = 1;

		// Token: 0x0400022E RID: 558
		private Teleporter type_;

		// Token: 0x0400022F RID: 559
		public const int DestinationsFieldNumber = 2;

		// Token: 0x04000230 RID: 560
		private static readonly FieldCodec<TeleportDestination> _repeated_destinations_codec;

		// Token: 0x04000231 RID: 561
		private readonly RepeatedField<TeleportDestination> destinations_;

		// Token: 0x04000232 RID: 562
		public const int SpawnMapIdFieldNumber = 3;

		// Token: 0x04000233 RID: 563
		private static readonly long SpawnMapIdDefaultValue;

		// Token: 0x04000234 RID: 564
		private long spawnMapId_;

		// Token: 0x04000235 RID: 565
		private static TeleportDestinationsEvent LipWHNOKzZQkel70asCg;
	}
}
