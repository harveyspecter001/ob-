using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000131 RID: 305
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SmileyEvent : IMessage<SmileyEvent>, IMessage, IEquatable<SmileyEvent>, IDeepCloneable<SmileyEvent>, IBufferMessage
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0019AFEC File Offset: 0x001991EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SmileyEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0019AFFC File Offset: 0x001991FC
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0019B00C File Offset: 0x0019920C
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

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0019B01C File Offset: 0x0019921C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmileyEvent()
		{
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0019B02C File Offset: 0x0019922C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmileyEvent(SmileyEvent other)
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0019B03C File Offset: 0x0019923C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SmileyEvent Clone()
		{
			return null;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x0019B04C File Offset: 0x0019924C
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x0019B05C File Offset: 0x0019925C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long EntityId
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0019B06C File Offset: 0x0019926C
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0019B07C File Offset: 0x0019927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SmileyId
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

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0019B08C File Offset: 0x0019928C
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x0019B09C File Offset: 0x0019929C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccountId
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

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0019B0AC File Offset: 0x001992AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAccountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0019B0BC File Offset: 0x001992BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAccountId()
		{
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0019B0CC File Offset: 0x001992CC
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x0019B0DC File Offset: 0x001992DC
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0019B0EC File Offset: 0x001992EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0019B0FC File Offset: 0x001992FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearCellId()
		{
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0019B10C File Offset: 0x0019930C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0019B11C File Offset: 0x0019931C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SmileyEvent other)
		{
			return true;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0019B12C File Offset: 0x0019932C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0019B13C File Offset: 0x0019933C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0019B14C File Offset: 0x0019934C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0019B15C File Offset: 0x0019935C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0019B16C File Offset: 0x0019936C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0019B17C File Offset: 0x0019937C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SmileyEvent other)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0019B18C File Offset: 0x0019938C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0019B19C File Offset: 0x0019939C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0019B1AC File Offset: 0x001993AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SmileyEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					SmileyEvent._parser = new MessageParser<SmileyEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					SmileyEvent.CellIdDefaultValue = 0;
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 6:
					return;
				}
				SmileyEvent.AccountIdDefaultValue = 0L;
				num2 = 0;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0019B2E0 File Offset: 0x001994E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tJtZPfOcbhHYi4J7IxqY()
		{
			return true;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0019B2E8 File Offset: 0x001994E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SmileyEvent l2PGXtOciU8YdXSCQoCS()
		{
			return null;
		}

		// Token: 0x0400050B RID: 1291
		private static readonly MessageParser<SmileyEvent> _parser;

		// Token: 0x0400050C RID: 1292
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400050D RID: 1293
		private int _hasBits0;

		// Token: 0x0400050E RID: 1294
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400050F RID: 1295
		private long entityId_;

		// Token: 0x04000510 RID: 1296
		public const int SmileyIdFieldNumber = 2;

		// Token: 0x04000511 RID: 1297
		private int smileyId_;

		// Token: 0x04000512 RID: 1298
		public const int AccountIdFieldNumber = 3;

		// Token: 0x04000513 RID: 1299
		private static readonly long AccountIdDefaultValue;

		// Token: 0x04000514 RID: 1300
		private long accountId_;

		// Token: 0x04000515 RID: 1301
		public const int CellIdFieldNumber = 4;

		// Token: 0x04000516 RID: 1302
		private static readonly int CellIdDefaultValue;

		// Token: 0x04000517 RID: 1303
		private int cellId_;

		// Token: 0x04000518 RID: 1304
		internal static SmileyEvent M4icbfOcYaiZdSI8pr65;
	}
}
