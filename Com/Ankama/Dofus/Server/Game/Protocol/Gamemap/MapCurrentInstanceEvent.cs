using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000590 RID: 1424
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapCurrentInstanceEvent : IMessage<MapCurrentInstanceEvent>, IMessage, IEquatable<MapCurrentInstanceEvent>, IDeepCloneable<MapCurrentInstanceEvent>, IBufferMessage
	{
		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x001F6954 File Offset: 0x001F4B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapCurrentInstanceEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x001F6964 File Offset: 0x001F4B64
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

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x001F6974 File Offset: 0x001F4B74
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

		// Token: 0x060044A7 RID: 17575 RVA: 0x001F6984 File Offset: 0x001F4B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCurrentInstanceEvent()
		{
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x001F6994 File Offset: 0x001F4B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCurrentInstanceEvent(MapCurrentInstanceEvent other)
		{
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x001F69A4 File Offset: 0x001F4BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCurrentInstanceEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x001F69B4 File Offset: 0x001F4BB4
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x001F69C4 File Offset: 0x001F4BC4
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

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x001F69D4 File Offset: 0x001F4BD4
		// (set) Token: 0x060044AD RID: 17581 RVA: 0x001F69E4 File Offset: 0x001F4BE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long InstantiateMapId
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

		// Token: 0x060044AE RID: 17582 RVA: 0x001F69F4 File Offset: 0x001F4BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x001F6A04 File Offset: 0x001F4C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapCurrentInstanceEvent other)
		{
			return true;
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x001F6A14 File Offset: 0x001F4C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x001F6A24 File Offset: 0x001F4C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x001F6A34 File Offset: 0x001F4C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x001F6A44 File Offset: 0x001F4C44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x001F6A54 File Offset: 0x001F4C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x001F6A64 File Offset: 0x001F4C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapCurrentInstanceEvent other)
		{
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x001F6A74 File Offset: 0x001F4C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x001F6A84 File Offset: 0x001F4C84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x001F6A94 File Offset: 0x001F4C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapCurrentInstanceEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					MapCurrentInstanceEvent._parser = new MessageParser<MapCurrentInstanceEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ec5157afa0544a6c98f5c946af6813ad == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x001F6B78 File Offset: 0x001F4D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OAnjheOY1qgHPXoj46CP()
		{
			return true;
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x001F6B80 File Offset: 0x001F4D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapCurrentInstanceEvent posiZOOYaovOaeywICmD()
		{
			return null;
		}

		// Token: 0x04001799 RID: 6041
		private static readonly MessageParser<MapCurrentInstanceEvent> _parser;

		// Token: 0x0400179A RID: 6042
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400179B RID: 6043
		public const int MapIdFieldNumber = 1;

		// Token: 0x0400179C RID: 6044
		private long mapId_;

		// Token: 0x0400179D RID: 6045
		public const int InstantiateMapIdFieldNumber = 2;

		// Token: 0x0400179E RID: 6046
		private long instantiateMapId_;

		// Token: 0x0400179F RID: 6047
		private static MapCurrentInstanceEvent VSwW9tOYocKAAQAsZH78;
	}
}
