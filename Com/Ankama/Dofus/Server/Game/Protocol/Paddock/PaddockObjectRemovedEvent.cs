using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000313 RID: 787
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockObjectRemovedEvent : IMessage<PaddockObjectRemovedEvent>, IMessage, IEquatable<PaddockObjectRemovedEvent>, IDeepCloneable<PaddockObjectRemovedEvent>, IBufferMessage
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x001C07C0 File Offset: 0x001BE9C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddockObjectRemovedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x001C07D0 File Offset: 0x001BE9D0
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x001C07E0 File Offset: 0x001BE9E0
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

		// Token: 0x060024FC RID: 9468 RVA: 0x001C07F0 File Offset: 0x001BE9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectRemovedEvent()
		{
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x001C0800 File Offset: 0x001BEA00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectRemovedEvent(PaddockObjectRemovedEvent other)
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x001C0810 File Offset: 0x001BEA10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectRemovedEvent Clone()
		{
			return null;
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x001C0820 File Offset: 0x001BEA20
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x001C0830 File Offset: 0x001BEA30
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

		// Token: 0x06002501 RID: 9473 RVA: 0x001C0840 File Offset: 0x001BEA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x001C0850 File Offset: 0x001BEA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockObjectRemovedEvent other)
		{
			return true;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x001C0860 File Offset: 0x001BEA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x001C0870 File Offset: 0x001BEA70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x001C0880 File Offset: 0x001BEA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x001C0890 File Offset: 0x001BEA90
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x001C08A0 File Offset: 0x001BEAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x001C08B0 File Offset: 0x001BEAB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockObjectRemovedEvent other)
		{
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x001C08C0 File Offset: 0x001BEAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x001C08D0 File Offset: 0x001BEAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x001C08E0 File Offset: 0x001BEAE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockObjectRemovedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					PaddockObjectRemovedEvent._parser = new MessageParser<PaddockObjectRemovedEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x001C09D8 File Offset: 0x001BEBD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uj2PSxOWEurp4TE0CFyH()
		{
			return true;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x001C09E0 File Offset: 0x001BEBE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockObjectRemovedEvent dlmjXQOWXfidF8ZStnww()
		{
			return null;
		}

		// Token: 0x04000D23 RID: 3363
		private static readonly MessageParser<PaddockObjectRemovedEvent> _parser;

		// Token: 0x04000D24 RID: 3364
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D25 RID: 3365
		public const int CellIdFieldNumber = 1;

		// Token: 0x04000D26 RID: 3366
		private int cellId_;

		// Token: 0x04000D27 RID: 3367
		private static PaddockObjectRemovedEvent p50U2mOW2fjKD6fAQWHI;
	}
}
