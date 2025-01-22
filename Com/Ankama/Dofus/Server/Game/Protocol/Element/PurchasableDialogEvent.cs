using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element
{
	// Token: 0x020007CC RID: 1996
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PurchasableDialogEvent : IMessage<PurchasableDialogEvent>, IMessage, IEquatable<PurchasableDialogEvent>, IDeepCloneable<PurchasableDialogEvent>, IBufferMessage
	{
		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x060061D3 RID: 25043 RVA: 0x00221EA0 File Offset: 0x002200A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PurchasableDialogEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x060061D4 RID: 25044 RVA: 0x00221EB0 File Offset: 0x002200B0
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

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x00221EC0 File Offset: 0x002200C0
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

		// Token: 0x060061D6 RID: 25046 RVA: 0x00221ED0 File Offset: 0x002200D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PurchasableDialogEvent()
		{
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x00221EE0 File Offset: 0x002200E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PurchasableDialogEvent(PurchasableDialogEvent other)
		{
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x00221EF0 File Offset: 0x002200F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PurchasableDialogEvent Clone()
		{
			return null;
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x00221F00 File Offset: 0x00220100
		// (set) Token: 0x060061DA RID: 25050 RVA: 0x00221F14 File Offset: 0x00220114
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PurchasableDialogEvent.Types.Action Action
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PurchasableDialogEvent.Types.Action)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x00221F24 File Offset: 0x00220124
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x00221F34 File Offset: 0x00220134
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PurchasableId
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

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x00221F44 File Offset: 0x00220144
		// (set) Token: 0x060061DE RID: 25054 RVA: 0x00221F54 File Offset: 0x00220154
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int PurchasableInstanceId
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x00221F64 File Offset: 0x00220164
		// (set) Token: 0x060061E0 RID: 25056 RVA: 0x00221F74 File Offset: 0x00220174
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool SecondHand
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x00221F84 File Offset: 0x00220184
		// (set) Token: 0x060061E2 RID: 25058 RVA: 0x00221F94 File Offset: 0x00220194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Price
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

		// Token: 0x060061E3 RID: 25059 RVA: 0x00221FA4 File Offset: 0x002201A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x00221FB4 File Offset: 0x002201B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PurchasableDialogEvent other)
		{
			return true;
		}

		// Token: 0x060061E5 RID: 25061 RVA: 0x00221FC4 File Offset: 0x002201C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x00221FD4 File Offset: 0x002201D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x00221FE4 File Offset: 0x002201E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x00221FF4 File Offset: 0x002201F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x00222004 File Offset: 0x00220204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x00222014 File Offset: 0x00220214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PurchasableDialogEvent other)
		{
		}

		// Token: 0x060061EB RID: 25067 RVA: 0x00222024 File Offset: 0x00220224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x00222034 File Offset: 0x00220234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060061ED RID: 25069 RVA: 0x00222044 File Offset: 0x00220244
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PurchasableDialogEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					PurchasableDialogEvent._parser = new MessageParser<PurchasableDialogEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f9c0f687924238a6a5f1548cc32497 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x00222128 File Offset: 0x00220328
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool pU9MK6OFKrCd4L1ZFvOD()
		{
			return true;
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x00222130 File Offset: 0x00220330
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PurchasableDialogEvent EilUvhOFI0aThl4rpP9p()
		{
			return null;
		}

		// Token: 0x0400225D RID: 8797
		private static readonly MessageParser<PurchasableDialogEvent> _parser;

		// Token: 0x0400225E RID: 8798
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400225F RID: 8799
		public const int ActionFieldNumber = 1;

		// Token: 0x04002260 RID: 8800
		private PurchasableDialogEvent.Types.Action action_;

		// Token: 0x04002261 RID: 8801
		public const int PurchasableIdFieldNumber = 2;

		// Token: 0x04002262 RID: 8802
		private long purchasableId_;

		// Token: 0x04002263 RID: 8803
		public const int PurchasableInstanceIdFieldNumber = 3;

		// Token: 0x04002264 RID: 8804
		private int purchasableInstanceId_;

		// Token: 0x04002265 RID: 8805
		public const int SecondHandFieldNumber = 4;

		// Token: 0x04002266 RID: 8806
		private bool secondHand_;

		// Token: 0x04002267 RID: 8807
		public const int PriceFieldNumber = 5;

		// Token: 0x04002268 RID: 8808
		private long price_;

		// Token: 0x04002269 RID: 8809
		internal static PurchasableDialogEvent v3OtfEOFjNQQ0SJxcwUq;

		// Token: 0x020007CD RID: 1997
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060061F0 RID: 25072 RVA: 0x002D35B8 File Offset: 0x002D17B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007CE RID: 1998
			public enum Action
			{
				// Token: 0x0400226B RID: 8811
				[OriginalName("BUY")]
				Buy,
				// Token: 0x0400226C RID: 8812
				[OriginalName("SELL")]
				Sell
			}
		}
	}
}
