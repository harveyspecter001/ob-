using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x0200097D RID: 2429
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachRoomUnlockResultEvent : IMessage<BreachRoomUnlockResultEvent>, IMessage, IEquatable<BreachRoomUnlockResultEvent>, IDeepCloneable<BreachRoomUnlockResultEvent>, IBufferMessage
	{
		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x0600759C RID: 30108 RVA: 0x0024320C File Offset: 0x0024140C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BreachRoomUnlockResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x0600759D RID: 30109 RVA: 0x0024321C File Offset: 0x0024141C
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

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x0024322C File Offset: 0x0024142C
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

		// Token: 0x0600759F RID: 30111 RVA: 0x0024323C File Offset: 0x0024143C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomUnlockResultEvent()
		{
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x0024324C File Offset: 0x0024144C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomUnlockResultEvent(BreachRoomUnlockResultEvent other)
		{
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x0024325C File Offset: 0x0024145C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachRoomUnlockResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060075A2 RID: 30114 RVA: 0x0024326C File Offset: 0x0024146C
		// (set) Token: 0x060075A3 RID: 30115 RVA: 0x0024327C File Offset: 0x0024147C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int RoomId
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

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060075A4 RID: 30116 RVA: 0x0024328C File Offset: 0x0024148C
		// (set) Token: 0x060075A5 RID: 30117 RVA: 0x002432A0 File Offset: 0x002414A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BreachRoomUnlockResultEvent.Types.BreachRoomUnlockResult Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BreachRoomUnlockResultEvent.Types.BreachRoomUnlockResult)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x002432B0 File Offset: 0x002414B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x002432C0 File Offset: 0x002414C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachRoomUnlockResultEvent other)
		{
			return true;
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x002432D0 File Offset: 0x002414D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x002432E0 File Offset: 0x002414E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x002432F0 File Offset: 0x002414F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00243300 File Offset: 0x00241500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00243310 File Offset: 0x00241510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00243320 File Offset: 0x00241520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachRoomUnlockResultEvent other)
		{
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x00243330 File Offset: 0x00241530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x00243340 File Offset: 0x00241540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00243350 File Offset: 0x00241550
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachRoomUnlockResultEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 4;
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						BreachRoomUnlockResultEvent._parser = new MessageParser<BreachRoomUnlockResultEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						goto IL_AC;
					}
				}
				IL_AC:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
			}
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00243420 File Offset: 0x00241620
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aU2ByJJRas4PCBC4126c()
		{
			return true;
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00243428 File Offset: 0x00241628
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachRoomUnlockResultEvent Pn2bT1JR5WKwj0seGvBr()
		{
			return null;
		}

		// Token: 0x040028F0 RID: 10480
		private static readonly MessageParser<BreachRoomUnlockResultEvent> _parser;

		// Token: 0x040028F1 RID: 10481
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F2 RID: 10482
		public const int RoomIdFieldNumber = 1;

		// Token: 0x040028F3 RID: 10483
		private int roomId_;

		// Token: 0x040028F4 RID: 10484
		public const int ResultFieldNumber = 2;

		// Token: 0x040028F5 RID: 10485
		private BreachRoomUnlockResultEvent.Types.BreachRoomUnlockResult result_;

		// Token: 0x040028F6 RID: 10486
		internal static BreachRoomUnlockResultEvent qdQ5fkJR1pVlo724V9WN;

		// Token: 0x0200097E RID: 2430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060075B3 RID: 30131 RVA: 0x002DDD38 File Offset: 0x002DBF38
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200097F RID: 2431
			public enum BreachRoomUnlockResult
			{
				// Token: 0x040028F8 RID: 10488
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x040028F9 RID: 10489
				[OriginalName("FAIL_NOT_ENOUGH_BUDGET")]
				FailNotEnoughBudget
			}
		}
	}
}
