using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000768 RID: 1896
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountStockStartedEvent : IMessage<ExchangeMountStockStartedEvent>, IMessage, IEquatable<ExchangeMountStockStartedEvent>, IDeepCloneable<ExchangeMountStockStartedEvent>, IBufferMessage
	{
		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x0021BAE4 File Offset: 0x00219CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeMountStockStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06005CED RID: 23789 RVA: 0x0021BAF4 File Offset: 0x00219CF4
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

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x0021BB04 File Offset: 0x00219D04
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

		// Token: 0x06005CEF RID: 23791 RVA: 0x0021BB14 File Offset: 0x00219D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountStockStartedEvent()
		{
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x0021BB24 File Offset: 0x00219D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountStockStartedEvent(ExchangeMountStockStartedEvent other)
		{
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x0021BB34 File Offset: 0x00219D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountStockStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x0021BB44 File Offset: 0x00219D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ObjectItemInventory> Objects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x0021BB54 File Offset: 0x00219D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x0021BB64 File Offset: 0x00219D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountStockStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x0021BB74 File Offset: 0x00219D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x0021BB84 File Offset: 0x00219D84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x0021BB94 File Offset: 0x00219D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x0021BBA4 File Offset: 0x00219DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x0021BBB4 File Offset: 0x00219DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x0021BBC4 File Offset: 0x00219DC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountStockStartedEvent other)
		{
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x0021BBD4 File Offset: 0x00219DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x0021BBE4 File Offset: 0x00219DE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x0021BBF4 File Offset: 0x00219DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountStockStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						ExchangeMountStockStartedEvent._repeated_objects_codec = FieldCodec.ForMessage<ObjectItemInventory>(10U, MA8hA9n80ObjtPbmhEGb.XVInXhlssT(MA8hA9n80ObjtPbmhEGb.D4hn8C6OFiy));
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						return;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						break;
					case 3:
						ExchangeMountStockStartedEvent._parser = new MessageParser<ExchangeMountStockStartedEvent>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						goto IL_6E;
					case 5:
						goto IL_C0;
					}
				}
				IL_6E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 2;
				continue;
				IL_C0:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 4;
			}
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x0021BCEC File Offset: 0x00219EEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qSesowOZIyvKDp9b1ATs()
		{
			return true;
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x0021BCF4 File Offset: 0x00219EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountStockStartedEvent zb8TwYOZkE3E37fhvtMq()
		{
			return null;
		}

		// Token: 0x040020A3 RID: 8355
		private static readonly MessageParser<ExchangeMountStockStartedEvent> _parser;

		// Token: 0x040020A4 RID: 8356
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020A5 RID: 8357
		public const int ObjectsFieldNumber = 1;

		// Token: 0x040020A6 RID: 8358
		private static readonly FieldCodec<ObjectItemInventory> _repeated_objects_codec;

		// Token: 0x040020A7 RID: 8359
		private readonly RepeatedField<ObjectItemInventory> objects_;

		// Token: 0x040020A8 RID: 8360
		private static ExchangeMountStockStartedEvent Sjn2Z6OZK1DGK1UGeklQ;
	}
}
