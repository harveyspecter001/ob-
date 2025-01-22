using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000D5 RID: 213
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorUpdatesListeningConfirmationEvent : IMessage<TaxCollectorUpdatesListeningConfirmationEvent>, IMessage, IEquatable<TaxCollectorUpdatesListeningConfirmationEvent>, IDeepCloneable<TaxCollectorUpdatesListeningConfirmationEvent>, IBufferMessage
	{
		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x001924A0 File Offset: 0x001906A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorUpdatesListeningConfirmationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x001924B0 File Offset: 0x001906B0
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

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x001924C0 File Offset: 0x001906C0
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

		// Token: 0x06000988 RID: 2440 RVA: 0x001924D0 File Offset: 0x001906D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListeningConfirmationEvent()
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x001924E0 File Offset: 0x001906E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListeningConfirmationEvent(TaxCollectorUpdatesListeningConfirmationEvent other)
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x001924F0 File Offset: 0x001906F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListeningConfirmationEvent Clone()
		{
			return null;
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00192500 File Offset: 0x00190700
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00192510 File Offset: 0x00190710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaxCollectorInformation Information
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

		// Token: 0x0600098D RID: 2445 RVA: 0x00192520 File Offset: 0x00190720
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00192530 File Offset: 0x00190730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorUpdatesListeningConfirmationEvent other)
		{
			return true;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00192540 File Offset: 0x00190740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00192550 File Offset: 0x00190750
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00192560 File Offset: 0x00190760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00192570 File Offset: 0x00190770
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00192580 File Offset: 0x00190780
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00192590 File Offset: 0x00190790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorUpdatesListeningConfirmationEvent other)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x001925A0 File Offset: 0x001907A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x001925B0 File Offset: 0x001907B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x001925C0 File Offset: 0x001907C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorUpdatesListeningConfirmationEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 3:
					return;
				case 4:
					TaxCollectorUpdatesListeningConfirmationEvent._parser = new MessageParser<TaxCollectorUpdatesListeningConfirmationEvent>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x001926A4 File Offset: 0x001908A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kJS3G3Okhuwqi1g1AATZ()
		{
			return true;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x001926AC File Offset: 0x001908AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorUpdatesListeningConfirmationEvent dgG44dOkrtHoSVmFD2C5()
		{
			return null;
		}

		// Token: 0x04000392 RID: 914
		private static readonly MessageParser<TaxCollectorUpdatesListeningConfirmationEvent> _parser;

		// Token: 0x04000393 RID: 915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000394 RID: 916
		public const int InformationFieldNumber = 1;

		// Token: 0x04000395 RID: 917
		private TaxCollectorInformation information_;

		// Token: 0x04000396 RID: 918
		internal static TaxCollectorUpdatesListeningConfirmationEvent UqGq4dOkWopdWo3bH7Jc;
	}
}
