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
	// Token: 0x0200072D RID: 1837
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeStartedEvent : IMessage<ExchangeStartedEvent>, IMessage, IEquatable<ExchangeStartedEvent>, IDeepCloneable<ExchangeStartedEvent>, IBufferMessage
	{
		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x06005A04 RID: 23044 RVA: 0x00218238 File Offset: 0x00216438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06005A05 RID: 23045 RVA: 0x00218248 File Offset: 0x00216448
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

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x00218258 File Offset: 0x00216458
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

		// Token: 0x06005A07 RID: 23047 RVA: 0x00218268 File Offset: 0x00216468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedEvent()
		{
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x00218278 File Offset: 0x00216478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedEvent(ExchangeStartedEvent other)
		{
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x00218288 File Offset: 0x00216488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06005A0A RID: 23050 RVA: 0x00218298 File Offset: 0x00216498
		// (set) Token: 0x06005A0B RID: 23051 RVA: 0x002182AC File Offset: 0x002164AC
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

		// Token: 0x06005A0C RID: 23052 RVA: 0x002182BC File Offset: 0x002164BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x002182CC File Offset: 0x002164CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x002182DC File Offset: 0x002164DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x002182EC File Offset: 0x002164EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x002182FC File Offset: 0x002164FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x0021830C File Offset: 0x0021650C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x0021831C File Offset: 0x0021651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x0021832C File Offset: 0x0021652C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeStartedEvent other)
		{
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x0021833C File Offset: 0x0021653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x0021834C File Offset: 0x0021654C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0021835C File Offset: 0x0021655C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeStartedEvent()
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
					ExchangeStartedEvent._parser = new MessageParser<ExchangeStartedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00218428 File Offset: 0x00216628
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GcRd0XO8GFkAT8qqRtBn()
		{
			return true;
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00218430 File Offset: 0x00216630
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeStartedEvent y9UKYxO8gv4DUS16ROyq()
		{
			return null;
		}

		// Token: 0x04001F84 RID: 8068
		private static readonly MessageParser<ExchangeStartedEvent> _parser;

		// Token: 0x04001F85 RID: 8069
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F86 RID: 8070
		public const int ExchangeTypeFieldNumber = 1;

		// Token: 0x04001F87 RID: 8071
		private ExchangeType exchangeType_;

		// Token: 0x04001F88 RID: 8072
		internal static ExchangeStartedEvent gnbO6aO8JQNqK1OB6yN1;
	}
}
