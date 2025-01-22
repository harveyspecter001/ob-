using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x0200058E RID: 1422
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapCurrentEvent : IMessage<MapCurrentEvent>, IMessage, IEquatable<MapCurrentEvent>, IDeepCloneable<MapCurrentEvent>, IBufferMessage
	{
		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600448A RID: 17546 RVA: 0x001F672C File Offset: 0x001F492C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapCurrentEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x001F673C File Offset: 0x001F493C
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

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x001F674C File Offset: 0x001F494C
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

		// Token: 0x0600448D RID: 17549 RVA: 0x001F675C File Offset: 0x001F495C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCurrentEvent()
		{
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x001F676C File Offset: 0x001F496C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCurrentEvent(MapCurrentEvent other)
		{
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x001F677C File Offset: 0x001F497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapCurrentEvent Clone()
		{
			return null;
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x001F678C File Offset: 0x001F498C
		// (set) Token: 0x06004491 RID: 17553 RVA: 0x001F679C File Offset: 0x001F499C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06004492 RID: 17554 RVA: 0x001F67AC File Offset: 0x001F49AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x001F67BC File Offset: 0x001F49BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapCurrentEvent other)
		{
			return true;
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x001F67CC File Offset: 0x001F49CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x001F67DC File Offset: 0x001F49DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x001F67EC File Offset: 0x001F49EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x001F67FC File Offset: 0x001F49FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x001F680C File Offset: 0x001F4A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x001F681C File Offset: 0x001F4A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapCurrentEvent other)
		{
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x001F682C File Offset: 0x001F4A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x001F683C File Offset: 0x001F4A3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x001F684C File Offset: 0x001F4A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapCurrentEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edad103d99794972a048278f53152048 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					MapCurrentEvent._parser = new MessageParser<MapCurrentEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x001F6944 File Offset: 0x001F4B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LgGTTHOYUiOpwL1BT6Og()
		{
			return true;
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x001F694C File Offset: 0x001F4B4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapCurrentEvent uKWEAEOYvdLKfGF8Jg1S()
		{
			return null;
		}

		// Token: 0x04001792 RID: 6034
		private static readonly MessageParser<MapCurrentEvent> _parser;

		// Token: 0x04001793 RID: 6035
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001794 RID: 6036
		public const int MapIdFieldNumber = 1;

		// Token: 0x04001795 RID: 6037
		private long mapId_;

		// Token: 0x04001796 RID: 6038
		internal static MapCurrentEvent tvMCvjOYc42eSpRyb8nR;
	}
}
