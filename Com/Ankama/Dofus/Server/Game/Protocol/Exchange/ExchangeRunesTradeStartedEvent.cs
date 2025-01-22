using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000757 RID: 1879
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeRunesTradeStartedEvent : IMessage<ExchangeRunesTradeStartedEvent>, IMessage, IEquatable<ExchangeRunesTradeStartedEvent>, IDeepCloneable<ExchangeRunesTradeStartedEvent>, IBufferMessage
	{
		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06005C37 RID: 23607 RVA: 0x0021AF10 File Offset: 0x00219110
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeRunesTradeStartedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06005C38 RID: 23608 RVA: 0x0021AF20 File Offset: 0x00219120
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

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x0021AF30 File Offset: 0x00219130
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

		// Token: 0x06005C3A RID: 23610 RVA: 0x0021AF40 File Offset: 0x00219140
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRunesTradeStartedEvent()
		{
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x0021AF50 File Offset: 0x00219150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRunesTradeStartedEvent(ExchangeRunesTradeStartedEvent other)
		{
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x0021AF60 File Offset: 0x00219160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeRunesTradeStartedEvent Clone()
		{
			return null;
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x0021AF70 File Offset: 0x00219170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005C3E RID: 23614 RVA: 0x0021AF80 File Offset: 0x00219180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeRunesTradeStartedEvent other)
		{
			return true;
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x0021AF90 File Offset: 0x00219190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x0021AFA0 File Offset: 0x002191A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x0021AFB0 File Offset: 0x002191B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x0021AFC0 File Offset: 0x002191C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x0021AFD0 File Offset: 0x002191D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x0021AFE0 File Offset: 0x002191E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeRunesTradeStartedEvent other)
		{
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x0021AFF0 File Offset: 0x002191F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x0021B000 File Offset: 0x00219200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x0021B010 File Offset: 0x00219210
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeRunesTradeStartedEvent()
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
					case 1:
						goto IL_5E;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_beb4bf6468b041beb35559c1c0a11f4e == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						return;
					}
					goto Block_1;
				}
				IL_5E:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
				continue;
				IL_A0:
				ExchangeRunesTradeStartedEvent._parser = new MessageParser<ExchangeRunesTradeStartedEvent>(() => null);
				num = 4;
				continue;
				Block_1:
				goto IL_A0;
			}
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x0021B0E4 File Offset: 0x002192E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool sTG4tKOZOwupmJpHXIFB()
		{
			return true;
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x0021B0EC File Offset: 0x002192EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeRunesTradeStartedEvent e4h1TLOZJgIvqbIbUGRH()
		{
			return null;
		}

		// Token: 0x04002052 RID: 8274
		private static readonly MessageParser<ExchangeRunesTradeStartedEvent> _parser;

		// Token: 0x04002053 RID: 8275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002054 RID: 8276
		internal static ExchangeRunesTradeStartedEvent QJc9lDOZREGcEFhvk3FQ;
	}
}
