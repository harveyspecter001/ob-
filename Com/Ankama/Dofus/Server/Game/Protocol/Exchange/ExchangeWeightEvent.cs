using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000781 RID: 1921
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeWeightEvent : IMessage<ExchangeWeightEvent>, IMessage, IEquatable<ExchangeWeightEvent>, IDeepCloneable<ExchangeWeightEvent>, IBufferMessage
	{
		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06005E26 RID: 24102 RVA: 0x0021CD44 File Offset: 0x0021AF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeWeightEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06005E27 RID: 24103 RVA: 0x0021CD54 File Offset: 0x0021AF54
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

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06005E28 RID: 24104 RVA: 0x0021CD64 File Offset: 0x0021AF64
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

		// Token: 0x06005E29 RID: 24105 RVA: 0x0021CD74 File Offset: 0x0021AF74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeWeightEvent()
		{
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x0021CD84 File Offset: 0x0021AF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeWeightEvent(ExchangeWeightEvent other)
		{
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0021CD94 File Offset: 0x0021AF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeWeightEvent Clone()
		{
			return null;
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06005E2C RID: 24108 RVA: 0x0021CDA4 File Offset: 0x0021AFA4
		// (set) Token: 0x06005E2D RID: 24109 RVA: 0x0021CDB4 File Offset: 0x0021AFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentWeight
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

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06005E2E RID: 24110 RVA: 0x0021CDC4 File Offset: 0x0021AFC4
		// (set) Token: 0x06005E2F RID: 24111 RVA: 0x0021CDD4 File Offset: 0x0021AFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxWeight
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

		// Token: 0x06005E30 RID: 24112 RVA: 0x0021CDE4 File Offset: 0x0021AFE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x0021CDF4 File Offset: 0x0021AFF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeWeightEvent other)
		{
			return true;
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x0021CE04 File Offset: 0x0021B004
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x0021CE14 File Offset: 0x0021B014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x0021CE24 File Offset: 0x0021B024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x0021CE34 File Offset: 0x0021B034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x0021CE44 File Offset: 0x0021B044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x0021CE54 File Offset: 0x0021B054
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeWeightEvent other)
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x0021CE64 File Offset: 0x0021B064
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x0021CE74 File Offset: 0x0021B074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x0021CE84 File Offset: 0x0021B084
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeWeightEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				ExchangeWeightEvent._parser = new MessageParser<ExchangeWeightEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x0021CF50 File Offset: 0x0021B150
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ac1JGOOZThF8vjpkPj5p()
		{
			return true;
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x0021CF58 File Offset: 0x0021B158
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeWeightEvent m9c3f4OZpQfYl7tb5IbQ()
		{
			return null;
		}

		// Token: 0x0400211B RID: 8475
		private static readonly MessageParser<ExchangeWeightEvent> _parser;

		// Token: 0x0400211C RID: 8476
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400211D RID: 8477
		public const int CurrentWeightFieldNumber = 1;

		// Token: 0x0400211E RID: 8478
		private int currentWeight_;

		// Token: 0x0400211F RID: 8479
		public const int MaxWeightFieldNumber = 2;

		// Token: 0x04002120 RID: 8480
		private int maxWeight_;

		// Token: 0x04002121 RID: 8481
		internal static ExchangeWeightEvent twlHp0OZ7AWWVeqTB48i;
	}
}
