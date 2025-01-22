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
	// Token: 0x0200072B RID: 1835
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeRequestedTradeEvent : IMessage<ExchangeRequestedTradeEvent>, IMessage, IEquatable<ExchangeRequestedTradeEvent>, IDeepCloneable<ExchangeRequestedTradeEvent>, IBufferMessage
	{
		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060059E6 RID: 23014 RVA: 0x00217FF4 File Offset: 0x002161F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeRequestedTradeEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060059E7 RID: 23015 RVA: 0x00218004 File Offset: 0x00216204
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

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060059E8 RID: 23016 RVA: 0x00218014 File Offset: 0x00216214
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

		// Token: 0x060059E9 RID: 23017 RVA: 0x00218024 File Offset: 0x00216224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRequestedTradeEvent()
		{
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x00218034 File Offset: 0x00216234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRequestedTradeEvent(ExchangeRequestedTradeEvent other)
		{
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x00218044 File Offset: 0x00216244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRequestedTradeEvent Clone()
		{
			return null;
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x00218054 File Offset: 0x00216254
		// (set) Token: 0x060059ED RID: 23021 RVA: 0x00218068 File Offset: 0x00216268
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060059EE RID: 23022 RVA: 0x00218078 File Offset: 0x00216278
		// (set) Token: 0x060059EF RID: 23023 RVA: 0x00218088 File Offset: 0x00216288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SourceId
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

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060059F0 RID: 23024 RVA: 0x00218098 File Offset: 0x00216298
		// (set) Token: 0x060059F1 RID: 23025 RVA: 0x002180A8 File Offset: 0x002162A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
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

		// Token: 0x060059F2 RID: 23026 RVA: 0x002180B8 File Offset: 0x002162B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x002180C8 File Offset: 0x002162C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeRequestedTradeEvent other)
		{
			return true;
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x002180D8 File Offset: 0x002162D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x002180E8 File Offset: 0x002162E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x002180F8 File Offset: 0x002162F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00218108 File Offset: 0x00216308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x00218118 File Offset: 0x00216318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x00218128 File Offset: 0x00216328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeRequestedTradeEvent other)
		{
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x00218138 File Offset: 0x00216338
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x00218148 File Offset: 0x00216348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x00218158 File Offset: 0x00216358
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeRequestedTradeEvent()
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
						goto IL_35;
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 3;
						break;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						return;
					}
				}
				IL_35:
				ExchangeRequestedTradeEvent._parser = new MessageParser<ExchangeRequestedTradeEvent>(() => null);
				num = 4;
			}
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x00218228 File Offset: 0x00216428
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bUAoIXO8Ry9X3WN5VMYg()
		{
			return true;
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x00218230 File Offset: 0x00216430
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeRequestedTradeEvent GR61nZO8OVl4olplEuQx()
		{
			return null;
		}

		// Token: 0x04001F79 RID: 8057
		private static readonly MessageParser<ExchangeRequestedTradeEvent> _parser;

		// Token: 0x04001F7A RID: 8058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F7B RID: 8059
		public const int ExchangeTypeFieldNumber = 1;

		// Token: 0x04001F7C RID: 8060
		private ExchangeType exchangeType_;

		// Token: 0x04001F7D RID: 8061
		public const int SourceIdFieldNumber = 2;

		// Token: 0x04001F7E RID: 8062
		private long sourceId_;

		// Token: 0x04001F7F RID: 8063
		public const int TargetIdFieldNumber = 3;

		// Token: 0x04001F80 RID: 8064
		private long targetId_;

		// Token: 0x04001F81 RID: 8065
		internal static ExchangeRequestedTradeEvent d9trt1O839I3udHJ3RKB;
	}
}
