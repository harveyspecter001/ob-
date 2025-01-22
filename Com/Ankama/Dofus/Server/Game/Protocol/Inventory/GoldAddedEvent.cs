using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory
{
	// Token: 0x02000409 RID: 1033
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GoldAddedEvent : IMessage<GoldAddedEvent>, IMessage, IEquatable<GoldAddedEvent>, IDeepCloneable<GoldAddedEvent>, IBufferMessage
	{
		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x001D4288 File Offset: 0x001D2488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GoldAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x001D4298 File Offset: 0x001D2498
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

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x001D42A8 File Offset: 0x001D24A8
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

		// Token: 0x060030C3 RID: 12483 RVA: 0x001D42B8 File Offset: 0x001D24B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GoldAddedEvent()
		{
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x001D42C8 File Offset: 0x001D24C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GoldAddedEvent(GoldAddedEvent other)
		{
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x001D42D8 File Offset: 0x001D24D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GoldAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x001D42E8 File Offset: 0x001D24E8
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x001D42F8 File Offset: 0x001D24F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Sum
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

		// Token: 0x060030C8 RID: 12488 RVA: 0x001D4308 File Offset: 0x001D2508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x001D4318 File Offset: 0x001D2518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(GoldAddedEvent other)
		{
			return true;
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x001D4328 File Offset: 0x001D2528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x001D4338 File Offset: 0x001D2538
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x001D4348 File Offset: 0x001D2548
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x001D4358 File Offset: 0x001D2558
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x001D4368 File Offset: 0x001D2568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x001D4378 File Offset: 0x001D2578
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(GoldAddedEvent other)
		{
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x001D4388 File Offset: 0x001D2588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x001D4398 File Offset: 0x001D2598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x001D43A8 File Offset: 0x001D25A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static GoldAddedEvent()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					GoldAddedEvent._parser = new MessageParser<GoldAddedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x001D448C File Offset: 0x001D268C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool owJXmjOCs9e26eY6CHwe()
		{
			return true;
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x001D4494 File Offset: 0x001D2694
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GoldAddedEvent WXSXn0OCdbhfxR4PwSJb()
		{
			return null;
		}

		// Token: 0x04001118 RID: 4376
		private static readonly MessageParser<GoldAddedEvent> _parser;

		// Token: 0x04001119 RID: 4377
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400111A RID: 4378
		public const int SumFieldNumber = 1;

		// Token: 0x0400111B RID: 4379
		private long sum_;

		// Token: 0x0400111C RID: 4380
		internal static GoldAddedEvent cItADcOCgaoMctX2nGdg;
	}
}
