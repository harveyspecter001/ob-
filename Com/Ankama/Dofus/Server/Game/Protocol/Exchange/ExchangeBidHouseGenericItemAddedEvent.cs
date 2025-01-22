using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200073B RID: 1851
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeBidHouseGenericItemAddedEvent : IMessage<ExchangeBidHouseGenericItemAddedEvent>, IMessage, IEquatable<ExchangeBidHouseGenericItemAddedEvent>, IDeepCloneable<ExchangeBidHouseGenericItemAddedEvent>, IBufferMessage
	{
		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06005AD2 RID: 23250 RVA: 0x00219230 File Offset: 0x00217430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeBidHouseGenericItemAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06005AD3 RID: 23251 RVA: 0x00219240 File Offset: 0x00217440
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

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06005AD4 RID: 23252 RVA: 0x00219250 File Offset: 0x00217450
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

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00219260 File Offset: 0x00217460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseGenericItemAddedEvent()
		{
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00219270 File Offset: 0x00217470
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseGenericItemAddedEvent(ExchangeBidHouseGenericItemAddedEvent other)
		{
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x00219280 File Offset: 0x00217480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeBidHouseGenericItemAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x00219290 File Offset: 0x00217490
		// (set) Token: 0x06005AD9 RID: 23257 RVA: 0x002192A0 File Offset: 0x002174A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int ObjectGid
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

		// Token: 0x06005ADA RID: 23258 RVA: 0x002192B0 File Offset: 0x002174B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x002192C0 File Offset: 0x002174C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeBidHouseGenericItemAddedEvent other)
		{
			return true;
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x002192D0 File Offset: 0x002174D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x002192E0 File Offset: 0x002174E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x002192F0 File Offset: 0x002174F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00219300 File Offset: 0x00217500
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x00219310 File Offset: 0x00217510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x00219320 File Offset: 0x00217520
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeBidHouseGenericItemAddedEvent other)
		{
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x00219330 File Offset: 0x00217530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00219340 File Offset: 0x00217540
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00219350 File Offset: 0x00217550
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeBidHouseGenericItemAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ExchangeBidHouseGenericItemAddedEvent._parser = new MessageParser<ExchangeBidHouseGenericItemAddedEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x00219434 File Offset: 0x00217634
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool nXBtkdO8albOImEaiTEE()
		{
			return true;
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x0021943C File Offset: 0x0021763C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeBidHouseGenericItemAddedEvent egYj0TO85vhaaMy7MFI8()
		{
			return null;
		}

		// Token: 0x04001FCD RID: 8141
		private static readonly MessageParser<ExchangeBidHouseGenericItemAddedEvent> _parser;

		// Token: 0x04001FCE RID: 8142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FCF RID: 8143
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x04001FD0 RID: 8144
		private int objectGid_;

		// Token: 0x04001FD1 RID: 8145
		internal static ExchangeBidHouseGenericItemAddedEvent paSJe9O81v4UQ0sAHEk1;
	}
}
