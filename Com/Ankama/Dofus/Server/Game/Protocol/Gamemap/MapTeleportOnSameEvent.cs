using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000592 RID: 1426
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapTeleportOnSameEvent : IMessage<MapTeleportOnSameEvent>, IMessage, IEquatable<MapTeleportOnSameEvent>, IDeepCloneable<MapTeleportOnSameEvent>, IBufferMessage
	{
		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x001F6B88 File Offset: 0x001F4D88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapTeleportOnSameEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060044C1 RID: 17601 RVA: 0x001F6B98 File Offset: 0x001F4D98
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

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x001F6BA8 File Offset: 0x001F4DA8
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

		// Token: 0x060044C3 RID: 17603 RVA: 0x001F6BB8 File Offset: 0x001F4DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapTeleportOnSameEvent()
		{
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x001F6BC8 File Offset: 0x001F4DC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapTeleportOnSameEvent(MapTeleportOnSameEvent other)
		{
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x001F6BD8 File Offset: 0x001F4DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapTeleportOnSameEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x001F6BE8 File Offset: 0x001F4DE8
		// (set) Token: 0x060044C7 RID: 17607 RVA: 0x001F6BF8 File Offset: 0x001F4DF8
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

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060044C8 RID: 17608 RVA: 0x001F6C08 File Offset: 0x001F4E08
		// (set) Token: 0x060044C9 RID: 17609 RVA: 0x001F6C18 File Offset: 0x001F4E18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CellId
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

		// Token: 0x060044CA RID: 17610 RVA: 0x001F6C28 File Offset: 0x001F4E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x001F6C38 File Offset: 0x001F4E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapTeleportOnSameEvent other)
		{
			return true;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x001F6C48 File Offset: 0x001F4E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x001F6C58 File Offset: 0x001F4E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x001F6C68 File Offset: 0x001F4E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x001F6C78 File Offset: 0x001F4E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x001F6C88 File Offset: 0x001F4E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x001F6C98 File Offset: 0x001F4E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapTeleportOnSameEvent other)
		{
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x001F6CA8 File Offset: 0x001F4EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x001F6CB8 File Offset: 0x001F4EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x001F6CC8 File Offset: 0x001F4EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapTeleportOnSameEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MapTeleportOnSameEvent._parser = new MessageParser<MapTeleportOnSameEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x001F6DAC File Offset: 0x001F4FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CjNERdOYypcL8nmvd1SI()
		{
			return true;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x001F6DB4 File Offset: 0x001F4FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapTeleportOnSameEvent Gp5Sg0OY6Q6FB038M0gi()
		{
			return null;
		}

		// Token: 0x040017A2 RID: 6050
		private static readonly MessageParser<MapTeleportOnSameEvent> _parser;

		// Token: 0x040017A3 RID: 6051
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017A4 RID: 6052
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040017A5 RID: 6053
		private long playerId_;

		// Token: 0x040017A6 RID: 6054
		public const int CellIdFieldNumber = 2;

		// Token: 0x040017A7 RID: 6055
		private int cellId_;

		// Token: 0x040017A8 RID: 6056
		internal static MapTeleportOnSameEvent F42GZoOY5SyY6SfkP050;
	}
}
