using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000317 RID: 791
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockObjectsAddedEvent : IMessage<PaddockObjectsAddedEvent>, IMessage, IEquatable<PaddockObjectsAddedEvent>, IDeepCloneable<PaddockObjectsAddedEvent>, IBufferMessage
	{
		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x001C0BE4 File Offset: 0x001BEDE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddockObjectsAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x001C0BF4 File Offset: 0x001BEDF4
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

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x001C0C04 File Offset: 0x001BEE04
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

		// Token: 0x06002530 RID: 9520 RVA: 0x001C0C14 File Offset: 0x001BEE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectsAddedEvent()
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x001C0C24 File Offset: 0x001BEE24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectsAddedEvent(PaddockObjectsAddedEvent other)
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x001C0C34 File Offset: 0x001BEE34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectsAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x001C0C44 File Offset: 0x001BEE44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectInRolePlay> PaddockItem
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x001C0C54 File Offset: 0x001BEE54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x001C0C64 File Offset: 0x001BEE64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockObjectsAddedEvent other)
		{
			return true;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x001C0C74 File Offset: 0x001BEE74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x001C0C84 File Offset: 0x001BEE84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x001C0C94 File Offset: 0x001BEE94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x001C0CA4 File Offset: 0x001BEEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x001C0CB4 File Offset: 0x001BEEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x001C0CC4 File Offset: 0x001BEEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockObjectsAddedEvent other)
		{
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x001C0CD4 File Offset: 0x001BEED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x001C0CE4 File Offset: 0x001BEEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x001C0CF4 File Offset: 0x001BEEF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockObjectsAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					PaddockObjectsAddedEvent._parser = new MessageParser<PaddockObjectsAddedEvent>(() => null);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					PaddockObjectsAddedEvent._repeated_paddockItem_codec = FieldCodec.ForMessage<ObjectInRolePlay>(10U, CF3fbNn5Y1qo69YIf7GE.XVInXhlssT(CF3fbNn5Y1qo69YIf7GE.Krsn5b9wcjd));
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					break;
				}
			}
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x001C0DE4 File Offset: 0x001BEFE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CJ52AvOWKt0u1KWJtCdp()
		{
			return true;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x001C0DEC File Offset: 0x001BEFEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockObjectsAddedEvent lqU2pVOWICm2adecBKA5()
		{
			return null;
		}

		// Token: 0x04000D31 RID: 3377
		private static readonly MessageParser<PaddockObjectsAddedEvent> _parser;

		// Token: 0x04000D32 RID: 3378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D33 RID: 3379
		public const int PaddockItemFieldNumber = 1;

		// Token: 0x04000D34 RID: 3380
		private static readonly FieldCodec<ObjectInRolePlay> _repeated_paddockItem_codec;

		// Token: 0x04000D35 RID: 3381
		private readonly RepeatedField<ObjectInRolePlay> paddockItem_;

		// Token: 0x04000D36 RID: 3382
		internal static PaddockObjectsAddedEvent iUFd7yOWjatAZqJuLdBQ;
	}
}
