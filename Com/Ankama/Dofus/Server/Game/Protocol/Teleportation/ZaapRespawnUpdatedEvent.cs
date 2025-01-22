using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x0200008B RID: 139
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ZaapRespawnUpdatedEvent : IMessage<ZaapRespawnUpdatedEvent>, IMessage, IEquatable<ZaapRespawnUpdatedEvent>, IDeepCloneable<ZaapRespawnUpdatedEvent>, IBufferMessage
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0018BDEC File Offset: 0x00189FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ZaapRespawnUpdatedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0018BDFC File Offset: 0x00189FFC
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0018BE0C File Offset: 0x0018A00C
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

		// Token: 0x060005AC RID: 1452 RVA: 0x0018BE1C File Offset: 0x0018A01C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapRespawnUpdatedEvent()
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0018BE2C File Offset: 0x0018A02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapRespawnUpdatedEvent(ZaapRespawnUpdatedEvent other)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0018BE3C File Offset: 0x0018A03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapRespawnUpdatedEvent Clone()
		{
			return null;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0018BE4C File Offset: 0x0018A04C
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0018BE5C File Offset: 0x0018A05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x060005B1 RID: 1457 RVA: 0x0018BE6C File Offset: 0x0018A06C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0018BE7C File Offset: 0x0018A07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ZaapRespawnUpdatedEvent other)
		{
			return true;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0018BE8C File Offset: 0x0018A08C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0018BE9C File Offset: 0x0018A09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0018BEAC File Offset: 0x0018A0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0018BEBC File Offset: 0x0018A0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0018BECC File Offset: 0x0018A0CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0018BEDC File Offset: 0x0018A0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ZaapRespawnUpdatedEvent other)
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0018BEEC File Offset: 0x0018A0EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0018BEFC File Offset: 0x0018A0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0018BF0C File Offset: 0x0018A10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ZaapRespawnUpdatedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ZaapRespawnUpdatedEvent._parser = new MessageParser<ZaapRespawnUpdatedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_35;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						continue;
					}
					return;
				}
				IL_35:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0018BFDC File Offset: 0x0018A1DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool lgh73ROKqnHMtZe58lv9()
		{
			return true;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0018BFE4 File Offset: 0x0018A1E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ZaapRespawnUpdatedEvent LkDhqrOKF7YtHLmZ9U99()
		{
			return null;
		}

		// Token: 0x04000223 RID: 547
		private static readonly MessageParser<ZaapRespawnUpdatedEvent> _parser;

		// Token: 0x04000224 RID: 548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000225 RID: 549
		public const int MapIdFieldNumber = 1;

		// Token: 0x04000226 RID: 550
		private long mapId_;

		// Token: 0x04000227 RID: 551
		internal static ZaapRespawnUpdatedEvent FB3dTSOKZAjkhaJXvrB7;
	}
}
