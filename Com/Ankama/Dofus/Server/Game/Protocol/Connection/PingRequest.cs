using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x02000897 RID: 2199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PingRequest : IMessage<PingRequest>, IMessage, IEquatable<PingRequest>, IDeepCloneable<PingRequest>, IBufferMessage
	{
		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x00230360 File Offset: 0x0022E560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PingRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06006ACC RID: 27340 RVA: 0x00230370 File Offset: 0x0022E570
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

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06006ACD RID: 27341 RVA: 0x00230380 File Offset: 0x0022E580
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

		// Token: 0x06006ACE RID: 27342 RVA: 0x00230390 File Offset: 0x0022E590
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PingRequest()
		{
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x002303A0 File Offset: 0x0022E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PingRequest(PingRequest other)
		{
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x002303B0 File Offset: 0x0022E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PingRequest Clone()
		{
			return null;
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x002303C0 File Offset: 0x0022E5C0
		// (set) Token: 0x06006AD2 RID: 27346 RVA: 0x002303D0 File Offset: 0x0022E5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Quiet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x002303E0 File Offset: 0x0022E5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x002303F0 File Offset: 0x0022E5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PingRequest other)
		{
			return true;
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00230400 File Offset: 0x0022E600
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00230410 File Offset: 0x0022E610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x00230420 File Offset: 0x0022E620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00230430 File Offset: 0x0022E630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00230440 File Offset: 0x0022E640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00230450 File Offset: 0x0022E650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PingRequest other)
		{
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x00230460 File Offset: 0x0022E660
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x00230470 File Offset: 0x0022E670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x00230480 File Offset: 0x0022E680
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PingRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PingRequest._parser = new MessageParser<PingRequest>(() => null);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x0023054C File Offset: 0x0022E74C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Pfps3gJm9cOGBrVwxMhj()
		{
			return true;
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x00230554 File Offset: 0x0022E754
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PingRequest Aoe6A4Jm2FxBnRUot4cp()
		{
			return null;
		}

		// Token: 0x0400255E RID: 9566
		private static readonly MessageParser<PingRequest> _parser;

		// Token: 0x0400255F RID: 9567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002560 RID: 9568
		public const int QuietFieldNumber = 1;

		// Token: 0x04002561 RID: 9569
		private bool quiet_;

		// Token: 0x04002562 RID: 9570
		internal static PingRequest s2Z5ImJmdvcl3AMUJG7e;
	}
}
