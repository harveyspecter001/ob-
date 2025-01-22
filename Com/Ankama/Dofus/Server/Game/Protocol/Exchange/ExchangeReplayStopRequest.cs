using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x020006E2 RID: 1762
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeReplayStopRequest : IMessage<ExchangeReplayStopRequest>, IMessage, IEquatable<ExchangeReplayStopRequest>, IDeepCloneable<ExchangeReplayStopRequest>, IBufferMessage
	{
		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06005630 RID: 22064 RVA: 0x00213680 File Offset: 0x00211880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeReplayStopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x00213690 File Offset: 0x00211890
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

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06005632 RID: 22066 RVA: 0x002136A0 File Offset: 0x002118A0
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

		// Token: 0x06005633 RID: 22067 RVA: 0x002136B0 File Offset: 0x002118B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReplayStopRequest()
		{
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x002136C0 File Offset: 0x002118C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReplayStopRequest(ExchangeReplayStopRequest other)
		{
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x002136D0 File Offset: 0x002118D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeReplayStopRequest Clone()
		{
			return null;
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x002136E0 File Offset: 0x002118E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x002136F0 File Offset: 0x002118F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeReplayStopRequest other)
		{
			return true;
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x00213700 File Offset: 0x00211900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x00213710 File Offset: 0x00211910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x00213720 File Offset: 0x00211920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x00213730 File Offset: 0x00211930
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x00213740 File Offset: 0x00211940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x00213750 File Offset: 0x00211950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeReplayStopRequest other)
		{
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x00213760 File Offset: 0x00211960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00213770 File Offset: 0x00211970
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x00213780 File Offset: 0x00211980
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeReplayStopRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					ExchangeReplayStopRequest._parser = new MessageParser<ExchangeReplayStopRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3627010391fc4172a35661a89e9c5533 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x00213864 File Offset: 0x00211A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h4aMI1OMonrPGbl15i8y()
		{
			return true;
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x0021386C File Offset: 0x00211A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeReplayStopRequest MEZFC5OM1q5jKvYOsH39()
		{
			return null;
		}

		// Token: 0x04001E3E RID: 7742
		private static readonly MessageParser<ExchangeReplayStopRequest> _parser;

		// Token: 0x04001E3F RID: 7743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E40 RID: 7744
		internal static ExchangeReplayStopRequest jrwqibOMvB3iWCfpmaV8;
	}
}
