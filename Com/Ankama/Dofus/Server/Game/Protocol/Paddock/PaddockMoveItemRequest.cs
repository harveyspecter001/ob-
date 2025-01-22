using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x0200030D RID: 781
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockMoveItemRequest : IMessage<PaddockMoveItemRequest>, IMessage, IEquatable<PaddockMoveItemRequest>, IDeepCloneable<PaddockMoveItemRequest>, IBufferMessage
	{
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x001C00FC File Offset: 0x001BE2FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddockMoveItemRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x001C010C File Offset: 0x001BE30C
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

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x001C011C File Offset: 0x001BE31C
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

		// Token: 0x060024A4 RID: 9380 RVA: 0x001C012C File Offset: 0x001BE32C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockMoveItemRequest()
		{
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x001C013C File Offset: 0x001BE33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockMoveItemRequest(PaddockMoveItemRequest other)
		{
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x001C014C File Offset: 0x001BE34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockMoveItemRequest Clone()
		{
			return null;
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x001C015C File Offset: 0x001BE35C
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x001C016C File Offset: 0x001BE36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OldCellId
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

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x001C017C File Offset: 0x001BE37C
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x001C018C File Offset: 0x001BE38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewCellId
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

		// Token: 0x060024AB RID: 9387 RVA: 0x001C019C File Offset: 0x001BE39C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x001C01AC File Offset: 0x001BE3AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockMoveItemRequest other)
		{
			return true;
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x001C01BC File Offset: 0x001BE3BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x001C01CC File Offset: 0x001BE3CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x001C01DC File Offset: 0x001BE3DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x001C01EC File Offset: 0x001BE3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x001C01FC File Offset: 0x001BE3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x001C020C File Offset: 0x001BE40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockMoveItemRequest other)
		{
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x001C021C File Offset: 0x001BE41C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x001C022C File Offset: 0x001BE42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x001C023C File Offset: 0x001BE43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockMoveItemRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					PaddockMoveItemRequest._parser = new MessageParser<PaddockMoveItemRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x001C0308 File Offset: 0x001BE508
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tB3LkxOWRIrDBZvZXhRp()
		{
			return true;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x001C0310 File Offset: 0x001BE510
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockMoveItemRequest kqnFRsOWOZhxZffvA1M3()
		{
			return null;
		}

		// Token: 0x04000D04 RID: 3332
		private static readonly MessageParser<PaddockMoveItemRequest> _parser;

		// Token: 0x04000D05 RID: 3333
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D06 RID: 3334
		public const int OldCellIdFieldNumber = 1;

		// Token: 0x04000D07 RID: 3335
		private int oldCellId_;

		// Token: 0x04000D08 RID: 3336
		public const int NewCellIdFieldNumber = 2;

		// Token: 0x04000D09 RID: 3337
		private int newCellId_;

		// Token: 0x04000D0A RID: 3338
		internal static PaddockMoveItemRequest JmBhlrOW3HHWekaBym0C;
	}
}
