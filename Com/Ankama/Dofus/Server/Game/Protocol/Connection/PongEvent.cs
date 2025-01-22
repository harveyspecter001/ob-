using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Connection
{
	// Token: 0x02000899 RID: 2201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PongEvent : IMessage<PongEvent>, IMessage, IEquatable<PongEvent>, IDeepCloneable<PongEvent>, IBufferMessage
	{
		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x0023055C File Offset: 0x0022E75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PongEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x0023056C File Offset: 0x0022E76C
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

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06006AE7 RID: 27367 RVA: 0x0023057C File Offset: 0x0022E77C
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

		// Token: 0x06006AE8 RID: 27368 RVA: 0x0023058C File Offset: 0x0022E78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PongEvent()
		{
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x0023059C File Offset: 0x0022E79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PongEvent(PongEvent other)
		{
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x002305AC File Offset: 0x0022E7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PongEvent Clone()
		{
			return null;
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06006AEB RID: 27371 RVA: 0x002305BC File Offset: 0x0022E7BC
		// (set) Token: 0x06006AEC RID: 27372 RVA: 0x002305CC File Offset: 0x0022E7CC
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

		// Token: 0x06006AED RID: 27373 RVA: 0x002305DC File Offset: 0x0022E7DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x002305EC File Offset: 0x0022E7EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PongEvent other)
		{
			return true;
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x002305FC File Offset: 0x0022E7FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x0023060C File Offset: 0x0022E80C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x0023061C File Offset: 0x0022E81C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x0023062C File Offset: 0x0022E82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x0023063C File Offset: 0x0022E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x0023064C File Offset: 0x0022E84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PongEvent other)
		{
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x0023065C File Offset: 0x0022E85C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x0023066C File Offset: 0x0022E86C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x0023067C File Offset: 0x0022E87C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PongEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					PongEvent._parser = new MessageParser<PongEvent>(() => null);
					num2 = 4;
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
			}
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x00230748 File Offset: 0x0022E948
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cZk5g0JmXYiNZ3fbQc1A()
		{
			return true;
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x00230750 File Offset: 0x0022E950
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PongEvent nuUkZ2JmNE5rRoOlWlBZ()
		{
			return null;
		}

		// Token: 0x04002565 RID: 9573
		private static readonly MessageParser<PongEvent> _parser;

		// Token: 0x04002566 RID: 9574
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002567 RID: 9575
		public const int QuietFieldNumber = 1;

		// Token: 0x04002568 RID: 9576
		private bool quiet_;

		// Token: 0x04002569 RID: 9577
		private static PongEvent mwwF3kJmEghWpb8Hk7io;
	}
}
