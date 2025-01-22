using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x0200072F RID: 1839
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeStartedWithPodsEvent : IMessage<ExchangeStartedWithPodsEvent>, IMessage, IEquatable<ExchangeStartedWithPodsEvent>, IDeepCloneable<ExchangeStartedWithPodsEvent>, IBufferMessage
	{
		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x00218438 File Offset: 0x00216638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeStartedWithPodsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06005A1F RID: 23071 RVA: 0x00218448 File Offset: 0x00216648
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06005A20 RID: 23072 RVA: 0x00218458 File Offset: 0x00216658
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

		// Token: 0x06005A21 RID: 23073 RVA: 0x00218468 File Offset: 0x00216668
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithPodsEvent()
		{
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x00218478 File Offset: 0x00216678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithPodsEvent(ExchangeStartedWithPodsEvent other)
		{
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x00218488 File Offset: 0x00216688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedWithPodsEvent Clone()
		{
			return null;
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06005A24 RID: 23076 RVA: 0x00218498 File Offset: 0x00216698
		// (set) Token: 0x06005A25 RID: 23077 RVA: 0x002184AC File Offset: 0x002166AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeType ExchangeType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ExchangeType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06005A26 RID: 23078 RVA: 0x002184BC File Offset: 0x002166BC
		// (set) Token: 0x06005A27 RID: 23079 RVA: 0x002184CC File Offset: 0x002166CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FirstCharacterId
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

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06005A28 RID: 23080 RVA: 0x002184DC File Offset: 0x002166DC
		// (set) Token: 0x06005A29 RID: 23081 RVA: 0x002184EC File Offset: 0x002166EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstCharacterCurrentWeight
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

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06005A2A RID: 23082 RVA: 0x002184FC File Offset: 0x002166FC
		// (set) Token: 0x06005A2B RID: 23083 RVA: 0x0021850C File Offset: 0x0021670C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FirstCharacterMaxWeight
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

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06005A2C RID: 23084 RVA: 0x0021851C File Offset: 0x0021671C
		// (set) Token: 0x06005A2D RID: 23085 RVA: 0x0021852C File Offset: 0x0021672C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long SecondCharacterId
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

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06005A2E RID: 23086 RVA: 0x0021853C File Offset: 0x0021673C
		// (set) Token: 0x06005A2F RID: 23087 RVA: 0x0021854C File Offset: 0x0021674C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SecondCharacterCurrentWeight
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

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06005A30 RID: 23088 RVA: 0x0021855C File Offset: 0x0021675C
		// (set) Token: 0x06005A31 RID: 23089 RVA: 0x0021856C File Offset: 0x0021676C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondCharacterMaxWeight
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

		// Token: 0x06005A32 RID: 23090 RVA: 0x0021857C File Offset: 0x0021677C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x0021858C File Offset: 0x0021678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeStartedWithPodsEvent other)
		{
			return true;
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x0021859C File Offset: 0x0021679C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x002185AC File Offset: 0x002167AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x002185BC File Offset: 0x002167BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x002185CC File Offset: 0x002167CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x002185DC File Offset: 0x002167DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x002185EC File Offset: 0x002167EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeStartedWithPodsEvent other)
		{
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x002185FC File Offset: 0x002167FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x0021860C File Offset: 0x0021680C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x0021861C File Offset: 0x0021681C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeStartedWithPodsEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					ExchangeStartedWithPodsEvent._parser = new MessageParser<ExchangeStartedWithPodsEvent>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x002186E8 File Offset: 0x002168E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ubsPXLO8dxE9lwnRy2EU()
		{
			return true;
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x002186F0 File Offset: 0x002168F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeStartedWithPodsEvent g5JKRaO897eDidmvq5qb()
		{
			return null;
		}

		// Token: 0x04001F8B RID: 8075
		private static readonly MessageParser<ExchangeStartedWithPodsEvent> _parser;

		// Token: 0x04001F8C RID: 8076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F8D RID: 8077
		public const int ExchangeTypeFieldNumber = 1;

		// Token: 0x04001F8E RID: 8078
		private ExchangeType exchangeType_;

		// Token: 0x04001F8F RID: 8079
		public const int FirstCharacterIdFieldNumber = 2;

		// Token: 0x04001F90 RID: 8080
		private long firstCharacterId_;

		// Token: 0x04001F91 RID: 8081
		public const int FirstCharacterCurrentWeightFieldNumber = 3;

		// Token: 0x04001F92 RID: 8082
		private int firstCharacterCurrentWeight_;

		// Token: 0x04001F93 RID: 8083
		public const int FirstCharacterMaxWeightFieldNumber = 4;

		// Token: 0x04001F94 RID: 8084
		private int firstCharacterMaxWeight_;

		// Token: 0x04001F95 RID: 8085
		public const int SecondCharacterIdFieldNumber = 5;

		// Token: 0x04001F96 RID: 8086
		private long secondCharacterId_;

		// Token: 0x04001F97 RID: 8087
		public const int SecondCharacterCurrentWeightFieldNumber = 6;

		// Token: 0x04001F98 RID: 8088
		private int secondCharacterCurrentWeight_;

		// Token: 0x04001F99 RID: 8089
		public const int SecondCharacterMaxWeightFieldNumber = 7;

		// Token: 0x04001F9A RID: 8090
		private int secondCharacterMaxWeight_;

		// Token: 0x04001F9B RID: 8091
		private static ExchangeStartedWithPodsEvent aAyt9uO8sLcY6TADTler;
	}
}
