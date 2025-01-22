using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak
{
	// Token: 0x02000BEA RID: 3050
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BakActionEvent : IMessage<BakActionEvent>, IMessage, IEquatable<BakActionEvent>, IDeepCloneable<BakActionEvent>, IBufferMessage
	{
		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x060092BB RID: 37563 RVA: 0x002721D0 File Offset: 0x002703D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BakActionEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x060092BC RID: 37564 RVA: 0x002721E0 File Offset: 0x002703E0
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

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x002721F0 File Offset: 0x002703F0
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

		// Token: 0x060092BE RID: 37566 RVA: 0x00272200 File Offset: 0x00270400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakActionEvent()
		{
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x00272210 File Offset: 0x00270410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakActionEvent(BakActionEvent other)
		{
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x00272220 File Offset: 0x00270420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BakActionEvent Clone()
		{
			return null;
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x060092C1 RID: 37569 RVA: 0x00272230 File Offset: 0x00270430
		// (set) Token: 0x060092C2 RID: 37570 RVA: 0x00272240 File Offset: 0x00270440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Kamas
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

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x060092C3 RID: 37571 RVA: 0x00272250 File Offset: 0x00270450
		// (set) Token: 0x060092C4 RID: 37572 RVA: 0x00272260 File Offset: 0x00270460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Amount
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

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x060092C5 RID: 37573 RVA: 0x00272270 File Offset: 0x00270470
		// (set) Token: 0x060092C6 RID: 37574 RVA: 0x00272280 File Offset: 0x00270480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rate
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

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x060092C7 RID: 37575 RVA: 0x00272290 File Offset: 0x00270490
		// (set) Token: 0x060092C8 RID: 37576 RVA: 0x002722A4 File Offset: 0x002704A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public BidAction BidAction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BidAction)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x060092C9 RID: 37577 RVA: 0x002722B4 File Offset: 0x002704B4
		// (set) Token: 0x060092CA RID: 37578 RVA: 0x002722C4 File Offset: 0x002704C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TransactionUuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060092CB RID: 37579 RVA: 0x002722D4 File Offset: 0x002704D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x002722E4 File Offset: 0x002704E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BakActionEvent other)
		{
			return true;
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x002722F4 File Offset: 0x002704F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x00272304 File Offset: 0x00270504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x00272314 File Offset: 0x00270514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x00272324 File Offset: 0x00270524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x00272334 File Offset: 0x00270534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060092D2 RID: 37586 RVA: 0x00272344 File Offset: 0x00270544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BakActionEvent other)
		{
		}

		// Token: 0x060092D3 RID: 37587 RVA: 0x00272354 File Offset: 0x00270554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060092D4 RID: 37588 RVA: 0x00272364 File Offset: 0x00270564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x00272374 File Offset: 0x00270574
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BakActionEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BakActionEvent._parser = new MessageParser<BakActionEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47cd139c12e84189830c64cb3f345b2a != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x00272440 File Offset: 0x00270640
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xNgJV8JEv5NXm2NCI627()
		{
			return true;
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x00272448 File Offset: 0x00270648
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BakActionEvent mqRaPAJEoiy0qHLMD2X6()
		{
			return null;
		}

		// Token: 0x040036A0 RID: 13984
		private static readonly MessageParser<BakActionEvent> _parser;

		// Token: 0x040036A1 RID: 13985
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A2 RID: 13986
		public const int KamasFieldNumber = 1;

		// Token: 0x040036A3 RID: 13987
		private long kamas_;

		// Token: 0x040036A4 RID: 13988
		public const int AmountFieldNumber = 2;

		// Token: 0x040036A5 RID: 13989
		private long amount_;

		// Token: 0x040036A6 RID: 13990
		public const int RateFieldNumber = 3;

		// Token: 0x040036A7 RID: 13991
		private int rate_;

		// Token: 0x040036A8 RID: 13992
		public const int BidActionFieldNumber = 4;

		// Token: 0x040036A9 RID: 13993
		private BidAction bidAction_;

		// Token: 0x040036AA RID: 13994
		public const int TransactionUuidFieldNumber = 5;

		// Token: 0x040036AB RID: 13995
		private string transactionUuid_;

		// Token: 0x040036AC RID: 13996
		private static BakActionEvent XuuY7hJEUGHL4pohYgMb;
	}
}
