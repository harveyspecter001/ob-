using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic
{
	// Token: 0x02000BD6 RID: 3030
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BasicLatencyStatsEvent : IMessage<BasicLatencyStatsEvent>, IMessage, IEquatable<BasicLatencyStatsEvent>, IDeepCloneable<BasicLatencyStatsEvent>, IBufferMessage
	{
		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x060091E5 RID: 37349 RVA: 0x002703D8 File Offset: 0x0026E5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BasicLatencyStatsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x060091E6 RID: 37350 RVA: 0x002703E8 File Offset: 0x0026E5E8
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

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x060091E7 RID: 37351 RVA: 0x002703F8 File Offset: 0x0026E5F8
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

		// Token: 0x060091E8 RID: 37352 RVA: 0x00270408 File Offset: 0x0026E608
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BasicLatencyStatsEvent()
		{
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x00270418 File Offset: 0x0026E618
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BasicLatencyStatsEvent(BasicLatencyStatsEvent other)
		{
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x00270428 File Offset: 0x0026E628
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BasicLatencyStatsEvent Clone()
		{
			return null;
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x00270438 File Offset: 0x0026E638
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x00270448 File Offset: 0x0026E648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BasicLatencyStatsEvent other)
		{
			return true;
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x00270458 File Offset: 0x0026E658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060091EE RID: 37358 RVA: 0x00270468 File Offset: 0x0026E668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060091EF RID: 37359 RVA: 0x00270478 File Offset: 0x0026E678
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x00270488 File Offset: 0x0026E688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x00270498 File Offset: 0x0026E698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x002704A8 File Offset: 0x0026E6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BasicLatencyStatsEvent other)
		{
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x002704B8 File Offset: 0x0026E6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x002704C8 File Offset: 0x0026E6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x002704D8 File Offset: 0x0026E6D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BasicLatencyStatsEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					BasicLatencyStatsEvent._parser = new MessageParser<BasicLatencyStatsEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_84e8372c05a04e64bc9c50e146de2ba5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x002705D0 File Offset: 0x0026E7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C8vjdVJ2FAV9li3QAe49()
		{
			return true;
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x002705D8 File Offset: 0x0026E7D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BasicLatencyStatsEvent BfjsCRJ2zl0bd3gnCL77()
		{
			return null;
		}

		// Token: 0x04003657 RID: 13911
		private static readonly MessageParser<BasicLatencyStatsEvent> _parser;

		// Token: 0x04003658 RID: 13912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003659 RID: 13913
		internal static BasicLatencyStatsEvent W9lgeOJ2qbNUkTqNTe3Z;
	}
}
