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
	// Token: 0x02000793 RID: 1939
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeMountFreeFromPaddockEvent : IMessage<ExchangeMountFreeFromPaddockEvent>, IMessage, IEquatable<ExchangeMountFreeFromPaddockEvent>, IDeepCloneable<ExchangeMountFreeFromPaddockEvent>, IBufferMessage
	{
		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06005F19 RID: 24345 RVA: 0x0021E170 File Offset: 0x0021C370
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ExchangeMountFreeFromPaddockEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06005F1A RID: 24346 RVA: 0x0021E180 File Offset: 0x0021C380
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

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06005F1B RID: 24347 RVA: 0x0021E190 File Offset: 0x0021C390
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

		// Token: 0x06005F1C RID: 24348 RVA: 0x0021E1A0 File Offset: 0x0021C3A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountFreeFromPaddockEvent()
		{
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x0021E1B0 File Offset: 0x0021C3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountFreeFromPaddockEvent(ExchangeMountFreeFromPaddockEvent other)
		{
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x0021E1C0 File Offset: 0x0021C3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeMountFreeFromPaddockEvent Clone()
		{
			return null;
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06005F1F RID: 24351 RVA: 0x0021E1D0 File Offset: 0x0021C3D0
		// (set) Token: 0x06005F20 RID: 24352 RVA: 0x0021E1E0 File Offset: 0x0021C3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
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

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06005F21 RID: 24353 RVA: 0x0021E1F0 File Offset: 0x0021C3F0
		// (set) Token: 0x06005F22 RID: 24354 RVA: 0x0021E200 File Offset: 0x0021C400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapCoordinates Coordinates
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

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06005F23 RID: 24355 RVA: 0x0021E210 File Offset: 0x0021C410
		// (set) Token: 0x06005F24 RID: 24356 RVA: 0x0021E220 File Offset: 0x0021C420
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Liberator
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

		// Token: 0x06005F25 RID: 24357 RVA: 0x0021E230 File Offset: 0x0021C430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005F26 RID: 24358 RVA: 0x0021E240 File Offset: 0x0021C440
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeMountFreeFromPaddockEvent other)
		{
			return true;
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x0021E250 File Offset: 0x0021C450
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x0021E260 File Offset: 0x0021C460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x0021E270 File Offset: 0x0021C470
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x0021E280 File Offset: 0x0021C480
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x0021E290 File Offset: 0x0021C490
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x0021E2A0 File Offset: 0x0021C4A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeMountFreeFromPaddockEvent other)
		{
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x0021E2B0 File Offset: 0x0021C4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x0021E2C0 File Offset: 0x0021C4C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x0021E2D0 File Offset: 0x0021C4D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeMountFreeFromPaddockEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					ExchangeMountFreeFromPaddockEvent._parser = new MessageParser<ExchangeMountFreeFromPaddockEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fec71c40d9f5414bbcabd5eeb74db805 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x0021E3B4 File Offset: 0x0021C5B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YgSFJKOqsofgS4ZWJtYo()
		{
			return true;
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x0021E3BC File Offset: 0x0021C5BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeMountFreeFromPaddockEvent d6peGmOqdPHxO3YQLLVQ()
		{
			return null;
		}

		// Token: 0x04002171 RID: 8561
		private static readonly MessageParser<ExchangeMountFreeFromPaddockEvent> _parser;

		// Token: 0x04002172 RID: 8562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002173 RID: 8563
		public const int NameFieldNumber = 1;

		// Token: 0x04002174 RID: 8564
		private string name_;

		// Token: 0x04002175 RID: 8565
		public const int CoordinatesFieldNumber = 2;

		// Token: 0x04002176 RID: 8566
		private MapCoordinates coordinates_;

		// Token: 0x04002177 RID: 8567
		public const int LiberatorFieldNumber = 3;

		// Token: 0x04002178 RID: 8568
		private string liberator_;

		// Token: 0x04002179 RID: 8569
		internal static ExchangeMountFreeFromPaddockEvent LlR82lOqgBTGjLdEdvGQ;
	}
}
