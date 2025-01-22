using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020007A1 RID: 1953
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeJobIndexStartedEvent : IMessage<ExchangeJobIndexStartedEvent>, IMessage, IEquatable<ExchangeJobIndexStartedEvent>, IDeepCloneable<ExchangeJobIndexStartedEvent>, IBufferMessage
	{
		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06005FBE RID: 24510 RVA: 0x0021EE4C File Offset: 0x0021D04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeJobIndexStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06005FBF RID: 24511 RVA: 0x0021EE5C File Offset: 0x0021D05C
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

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06005FC0 RID: 24512 RVA: 0x0021EE6C File Offset: 0x0021D06C
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

		// Token: 0x06005FC1 RID: 24513 RVA: 0x0021EE7C File Offset: 0x0021D07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeJobIndexStartedEvent()
		{
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x0021EE8C File Offset: 0x0021D08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeJobIndexStartedEvent(ExchangeJobIndexStartedEvent other)
		{
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x0021EE9C File Offset: 0x0021D09C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeJobIndexStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x0021EEAC File Offset: 0x0021D0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Jobs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x0021EEBC File Offset: 0x0021D0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x0021EECC File Offset: 0x0021D0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeJobIndexStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x0021EEDC File Offset: 0x0021D0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x0021EEEC File Offset: 0x0021D0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x0021EEFC File Offset: 0x0021D0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x0021EF0C File Offset: 0x0021D10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x0021EF1C File Offset: 0x0021D11C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x0021EF2C File Offset: 0x0021D12C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeJobIndexStartedEvent other)
		{
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x0021EF3C File Offset: 0x0021D13C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x0021EF4C File Offset: 0x0021D14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x0021EF5C File Offset: 0x0021D15C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeJobIndexStartedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						ExchangeJobIndexStartedEvent._parser = new MessageParser<ExchangeJobIndexStartedEvent>(() => null);
						num2 = 4;
						continue;
					case 2:
						goto IL_62;
					case 3:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 2;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						ExchangeJobIndexStartedEvent._repeated_jobs_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					return;
				}
				IL_62:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 5;
			}
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x0021F060 File Offset: 0x0021D260
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool zNWEN9Oq1dOXLmrjrn1X()
		{
			return true;
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x0021F068 File Offset: 0x0021D268
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeJobIndexStartedEvent YHYNprOqaHrR1wGcBVuP()
		{
			return null;
		}

		// Token: 0x040021A8 RID: 8616
		private static readonly MessageParser<ExchangeJobIndexStartedEvent> _parser;

		// Token: 0x040021A9 RID: 8617
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021AA RID: 8618
		public const int JobsFieldNumber = 1;

		// Token: 0x040021AB RID: 8619
		private static readonly FieldCodec<int> _repeated_jobs_codec;

		// Token: 0x040021AC RID: 8620
		private readonly RepeatedField<int> jobs_;

		// Token: 0x040021AD RID: 8621
		internal static ExchangeJobIndexStartedEvent FIqXeaOqojL2CrF4QQcJ;
	}
}
