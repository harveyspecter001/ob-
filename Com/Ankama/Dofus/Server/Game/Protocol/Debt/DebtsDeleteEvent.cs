using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debt
{
	// Token: 0x020007FE RID: 2046
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DebtsDeleteEvent : IMessage<DebtsDeleteEvent>, IMessage, IEquatable<DebtsDeleteEvent>, IDeepCloneable<DebtsDeleteEvent>, IBufferMessage
	{
		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060063B8 RID: 25528 RVA: 0x002251A4 File Offset: 0x002233A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DebtsDeleteEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060063B9 RID: 25529 RVA: 0x002251B4 File Offset: 0x002233B4
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

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060063BA RID: 25530 RVA: 0x002251C4 File Offset: 0x002233C4
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

		// Token: 0x060063BB RID: 25531 RVA: 0x002251D4 File Offset: 0x002233D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebtsDeleteEvent()
		{
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x002251E4 File Offset: 0x002233E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebtsDeleteEvent(DebtsDeleteEvent other)
		{
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x002251F4 File Offset: 0x002233F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebtsDeleteEvent Clone()
		{
			return null;
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060063BE RID: 25534 RVA: 0x00225204 File Offset: 0x00223404
		// (set) Token: 0x060063BF RID: 25535 RVA: 0x00225218 File Offset: 0x00223418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public DebtsDeleteEvent.Types.DebtsDeletionReason Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DebtsDeleteEvent.Types.DebtsDeletionReason)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x00225228 File Offset: 0x00223428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<long> Debts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x00225238 File Offset: 0x00223438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x00225248 File Offset: 0x00223448
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DebtsDeleteEvent other)
		{
			return true;
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x00225258 File Offset: 0x00223458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060063C4 RID: 25540 RVA: 0x00225268 File Offset: 0x00223468
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x00225278 File Offset: 0x00223478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x00225288 File Offset: 0x00223488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00225298 File Offset: 0x00223498
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x002252A8 File Offset: 0x002234A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DebtsDeleteEvent other)
		{
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x002252B8 File Offset: 0x002234B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x002252C8 File Offset: 0x002234C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x002252D8 File Offset: 0x002234D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DebtsDeleteEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 3:
						goto IL_87;
					case 4:
						DebtsDeleteEvent._parser = new MessageParser<DebtsDeleteEvent>(() => null);
						num2 = 3;
						continue;
					case 5:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
					{
						num2 = 2;
					}
				}
				IL_87:
				DebtsDeleteEvent._repeated_debts_codec = VvZHhZNDXJ0wdfV8NAG.XVInXhlssT(18U, VvZHhZNDXJ0wdfV8NAG.zpwNtgb0bl);
				num = 5;
			}
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x002253DC File Offset: 0x002235DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WkidXJOz4F45E11m3a9E()
		{
			return true;
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x002253E4 File Offset: 0x002235E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DebtsDeleteEvent ADOQ4JOzjtuWZovRtEs1()
		{
			return null;
		}

		// Token: 0x04002312 RID: 8978
		private static readonly MessageParser<DebtsDeleteEvent> _parser;

		// Token: 0x04002313 RID: 8979
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002314 RID: 8980
		public const int ReasonFieldNumber = 1;

		// Token: 0x04002315 RID: 8981
		private DebtsDeleteEvent.Types.DebtsDeletionReason reason_;

		// Token: 0x04002316 RID: 8982
		public const int DebtsFieldNumber = 2;

		// Token: 0x04002317 RID: 8983
		private static readonly FieldCodec<long> _repeated_debts_codec;

		// Token: 0x04002318 RID: 8984
		private readonly RepeatedField<long> debts_;

		// Token: 0x04002319 RID: 8985
		private static DebtsDeleteEvent tcXlqXOzxQaK2vfa868T;

		// Token: 0x020007FF RID: 2047
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x060063CE RID: 25550 RVA: 0x002D4574 File Offset: 0x002D2774
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x02000800 RID: 2048
			public enum DebtsDeletionReason
			{
				// Token: 0x0400231B RID: 8987
				[OriginalName("UNKNOWN")]
				Unknown,
				// Token: 0x0400231C RID: 8988
				[OriginalName("ADMIN_COMMAND_REQUEST")]
				AdminCommandRequest,
				// Token: 0x0400231D RID: 8989
				[OriginalName("PAYED")]
				Payed,
				// Token: 0x0400231E RID: 8990
				[OriginalName("CANCELED")]
				Canceled
			}
		}
	}
}
