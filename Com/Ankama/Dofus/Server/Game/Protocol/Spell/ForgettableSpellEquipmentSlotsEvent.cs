using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Spell
{
	// Token: 0x02000120 RID: 288
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellEquipmentSlotsEvent : IMessage<ForgettableSpellEquipmentSlotsEvent>, IMessage, IEquatable<ForgettableSpellEquipmentSlotsEvent>, IDeepCloneable<ForgettableSpellEquipmentSlotsEvent>, IBufferMessage
	{
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00198F34 File Offset: 0x00197134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellEquipmentSlotsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00198F44 File Offset: 0x00197144
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00198F54 File Offset: 0x00197154
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

		// Token: 0x06000D28 RID: 3368 RVA: 0x00198F64 File Offset: 0x00197164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellEquipmentSlotsEvent()
		{
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00198F74 File Offset: 0x00197174
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellEquipmentSlotsEvent(ForgettableSpellEquipmentSlotsEvent other)
		{
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00198F84 File Offset: 0x00197184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellEquipmentSlotsEvent Clone()
		{
			return null;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00198F94 File Offset: 0x00197194
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00198FA4 File Offset: 0x001971A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quantity
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

		// Token: 0x06000D2D RID: 3373 RVA: 0x00198FB4 File Offset: 0x001971B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00198FC4 File Offset: 0x001971C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellEquipmentSlotsEvent other)
		{
			return true;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00198FD4 File Offset: 0x001971D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00198FE4 File Offset: 0x001971E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00198FF4 File Offset: 0x001971F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00199004 File Offset: 0x00197204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00199014 File Offset: 0x00197214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00199024 File Offset: 0x00197224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellEquipmentSlotsEvent other)
		{
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00199034 File Offset: 0x00197234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00199044 File Offset: 0x00197244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00199054 File Offset: 0x00197254
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellEquipmentSlotsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					ForgettableSpellEquipmentSlotsEvent._parser = new MessageParser<ForgettableSpellEquipmentSlotsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00199120 File Offset: 0x00197320
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YgiVfAOc1Gy1iXg2SUoU()
		{
			return true;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00199128 File Offset: 0x00197328
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellEquipmentSlotsEvent f8E5RZOcaxnbBNcLfic2()
		{
			return null;
		}

		// Token: 0x040004C4 RID: 1220
		private static readonly MessageParser<ForgettableSpellEquipmentSlotsEvent> _parser;

		// Token: 0x040004C5 RID: 1221
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004C6 RID: 1222
		public const int QuantityFieldNumber = 1;

		// Token: 0x040004C7 RID: 1223
		private int quantity_;

		// Token: 0x040004C8 RID: 1224
		internal static ForgettableSpellEquipmentSlotsEvent LI2KITOcoM0qXHnreYC8;
	}
}
