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
	// Token: 0x0200008F RID: 143
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ZaapKnownListEvent : IMessage<ZaapKnownListEvent>, IMessage, IEquatable<ZaapKnownListEvent>, IDeepCloneable<ZaapKnownListEvent>, IBufferMessage
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0018C2A0 File Offset: 0x0018A4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ZaapKnownListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0018C2B0 File Offset: 0x0018A4B0
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0018C2C0 File Offset: 0x0018A4C0
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

		// Token: 0x060005E5 RID: 1509 RVA: 0x0018C2D0 File Offset: 0x0018A4D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapKnownListEvent()
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0018C2E0 File Offset: 0x0018A4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapKnownListEvent(ZaapKnownListEvent other)
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0018C2F0 File Offset: 0x0018A4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ZaapKnownListEvent Clone()
		{
			return null;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0018C300 File Offset: 0x0018A500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Destinations
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0018C310 File Offset: 0x0018A510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0018C320 File Offset: 0x0018A520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ZaapKnownListEvent other)
		{
			return true;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0018C330 File Offset: 0x0018A530
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0018C340 File Offset: 0x0018A540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0018C350 File Offset: 0x0018A550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0018C360 File Offset: 0x0018A560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0018C370 File Offset: 0x0018A570
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0018C380 File Offset: 0x0018A580
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ZaapKnownListEvent other)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0018C390 File Offset: 0x0018A590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0018C3A0 File Offset: 0x0018A5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0018C3B0 File Offset: 0x0018A5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ZaapKnownListEvent()
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
						goto IL_62;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						return;
					}
					ZaapKnownListEvent._parser = new MessageParser<ZaapKnownListEvent>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 0;
					}
				}
				IL_62:
				ZaapKnownListEvent._repeated_destinations_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(10U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
				num = 5;
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0018C4CC File Offset: 0x0018A6CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ligt0fOIAJtRo1X9bQCd()
		{
			return true;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0018C4D4 File Offset: 0x0018A6D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ZaapKnownListEvent Sbr1ZBOIBNoy53nNVb8X()
		{
			return null;
		}

		// Token: 0x04000238 RID: 568
		private static readonly MessageParser<ZaapKnownListEvent> _parser;

		// Token: 0x04000239 RID: 569
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400023A RID: 570
		public const int DestinationsFieldNumber = 1;

		// Token: 0x0400023B RID: 571
		private static readonly FieldCodec<long> _repeated_destinations_codec;

		// Token: 0x0400023C RID: 572
		private readonly RepeatedField<long> destinations_;

		// Token: 0x0400023D RID: 573
		internal static ZaapKnownListEvent YLG9IfOImoCiAEL6EU73;
	}
}
