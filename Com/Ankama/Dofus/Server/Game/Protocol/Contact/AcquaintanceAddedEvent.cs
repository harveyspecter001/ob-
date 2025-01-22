using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x0200084E RID: 2126
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcquaintanceAddedEvent : IMessage<AcquaintanceAddedEvent>, IMessage, IEquatable<AcquaintanceAddedEvent>, IDeepCloneable<AcquaintanceAddedEvent>, IBufferMessage
	{
		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x0022CE48 File Offset: 0x0022B048
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AcquaintanceAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x0600675D RID: 26461 RVA: 0x0022CE58 File Offset: 0x0022B058
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

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x0022CE68 File Offset: 0x0022B068
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

		// Token: 0x0600675F RID: 26463 RVA: 0x0022CE78 File Offset: 0x0022B078
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceAddedEvent()
		{
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x0022CE88 File Offset: 0x0022B088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceAddedEvent(AcquaintanceAddedEvent other)
		{
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x0022CE98 File Offset: 0x0022B098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AcquaintanceAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x0022CEA8 File Offset: 0x0022B0A8
		// (set) Token: 0x06006763 RID: 26467 RVA: 0x0022CEB8 File Offset: 0x0022B0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcquaintanceInformation Acquaintance
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

		// Token: 0x06006764 RID: 26468 RVA: 0x0022CEC8 File Offset: 0x0022B0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x0022CED8 File Offset: 0x0022B0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AcquaintanceAddedEvent other)
		{
			return true;
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x0022CEE8 File Offset: 0x0022B0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x0022CEF8 File Offset: 0x0022B0F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006768 RID: 26472 RVA: 0x0022CF08 File Offset: 0x0022B108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006769 RID: 26473 RVA: 0x0022CF18 File Offset: 0x0022B118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x0022CF28 File Offset: 0x0022B128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x0022CF38 File Offset: 0x0022B138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AcquaintanceAddedEvent other)
		{
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x0022CF48 File Offset: 0x0022B148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x0022CF58 File Offset: 0x0022B158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600676E RID: 26478 RVA: 0x0022CF68 File Offset: 0x0022B168
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AcquaintanceAddedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_27e7f4c4d739495cbd098064683bd12f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AcquaintanceAddedEvent._parser = new MessageParser<AcquaintanceAddedEvent>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x0022D04C File Offset: 0x0022B24C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool EX79gUJnGhBvlgD59gBg()
		{
			return true;
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x0022D054 File Offset: 0x0022B254
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AcquaintanceAddedEvent z5uhKPJngLyLnZuWJLgD()
		{
			return null;
		}

		// Token: 0x04002436 RID: 9270
		private static readonly MessageParser<AcquaintanceAddedEvent> _parser;

		// Token: 0x04002437 RID: 9271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002438 RID: 9272
		public const int AcquaintanceFieldNumber = 1;

		// Token: 0x04002439 RID: 9273
		private AcquaintanceInformation acquaintance_;

		// Token: 0x0400243A RID: 9274
		internal static AcquaintanceAddedEvent EI59ufJnJTPF1V7tpSZB;
	}
}
