using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x020003FF RID: 1023
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ObjectCellDeleteEvent : IMessage<ObjectCellDeleteEvent>, IMessage, IEquatable<ObjectCellDeleteEvent>, IDeepCloneable<ObjectCellDeleteEvent>, IBufferMessage
	{
		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x001D37BC File Offset: 0x001D19BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ObjectCellDeleteEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x001D37CC File Offset: 0x001D19CC
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

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x001D37DC File Offset: 0x001D19DC
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

		// Token: 0x0600303F RID: 12351 RVA: 0x001D37EC File Offset: 0x001D19EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectCellDeleteEvent()
		{
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x001D37FC File Offset: 0x001D19FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectCellDeleteEvent(ObjectCellDeleteEvent other)
		{
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x001D380C File Offset: 0x001D1A0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectCellDeleteEvent Clone()
		{
			return null;
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x001D381C File Offset: 0x001D1A1C
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x001D382C File Offset: 0x001D1A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
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

		// Token: 0x06003044 RID: 12356 RVA: 0x001D383C File Offset: 0x001D1A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x001D384C File Offset: 0x001D1A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ObjectCellDeleteEvent other)
		{
			return true;
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x001D385C File Offset: 0x001D1A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x001D386C File Offset: 0x001D1A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x001D387C File Offset: 0x001D1A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x001D388C File Offset: 0x001D1A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x001D389C File Offset: 0x001D1A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x001D38AC File Offset: 0x001D1AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ObjectCellDeleteEvent other)
		{
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x001D38BC File Offset: 0x001D1ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x001D38CC File Offset: 0x001D1ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x001D38DC File Offset: 0x001D1ADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ObjectCellDeleteEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ObjectCellDeleteEvent._parser = new MessageParser<ObjectCellDeleteEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x001D39A8 File Offset: 0x001D1BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool X56W0KO0qIx0e87PoANL()
		{
			return true;
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x001D39B0 File Offset: 0x001D1BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ObjectCellDeleteEvent R1suZOO0F83b2ZEe7ycD()
		{
			return null;
		}

		// Token: 0x040010EF RID: 4335
		private static readonly MessageParser<ObjectCellDeleteEvent> _parser;

		// Token: 0x040010F0 RID: 4336
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010F1 RID: 4337
		public const int CellIdFieldNumber = 1;

		// Token: 0x040010F2 RID: 4338
		private int cellId_;

		// Token: 0x040010F3 RID: 4339
		private static ObjectCellDeleteEvent XDAAkBO0ZTY52K4Tu25H;
	}
}
