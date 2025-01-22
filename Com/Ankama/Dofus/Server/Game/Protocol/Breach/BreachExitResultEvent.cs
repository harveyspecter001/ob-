using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach
{
	// Token: 0x02000981 RID: 2433
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BreachExitResultEvent : IMessage<BreachExitResultEvent>, IMessage, IEquatable<BreachExitResultEvent>, IDeepCloneable<BreachExitResultEvent>, IBufferMessage
	{
		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060075B9 RID: 30137 RVA: 0x00243430 File Offset: 0x00241630
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<BreachExitResultEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060075BA RID: 30138 RVA: 0x00243440 File Offset: 0x00241640
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

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060075BB RID: 30139 RVA: 0x00243450 File Offset: 0x00241650
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

		// Token: 0x060075BC RID: 30140 RVA: 0x00243460 File Offset: 0x00241660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachExitResultEvent()
		{
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00243470 File Offset: 0x00241670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachExitResultEvent(BreachExitResultEvent other)
		{
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00243480 File Offset: 0x00241680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BreachExitResultEvent Clone()
		{
			return null;
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060075BF RID: 30143 RVA: 0x00243490 File Offset: 0x00241690
		// (set) Token: 0x060075C0 RID: 30144 RVA: 0x002434A0 File Offset: 0x002416A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Exited
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

		// Token: 0x060075C1 RID: 30145 RVA: 0x002434B0 File Offset: 0x002416B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x002434C0 File Offset: 0x002416C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BreachExitResultEvent other)
		{
			return true;
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x002434D0 File Offset: 0x002416D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x002434E0 File Offset: 0x002416E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x002434F0 File Offset: 0x002416F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x00243500 File Offset: 0x00241700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00243510 File Offset: 0x00241710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00243520 File Offset: 0x00241720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BreachExitResultEvent other)
		{
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00243530 File Offset: 0x00241730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00243540 File Offset: 0x00241740
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00243550 File Offset: 0x00241750
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BreachExitResultEvent()
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
					num2 = 3;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				BreachExitResultEvent._parser = new MessageParser<BreachExitResultEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x0024361C File Offset: 0x0024181C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool M8t0a8JR60dUICDcRL7v()
		{
			return true;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00243624 File Offset: 0x00241824
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BreachExitResultEvent Tp9BkhJRLd0mUVo8IA6v()
		{
			return null;
		}

		// Token: 0x040028FC RID: 10492
		private static readonly MessageParser<BreachExitResultEvent> _parser;

		// Token: 0x040028FD RID: 10493
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028FE RID: 10494
		public const int ExitedFieldNumber = 1;

		// Token: 0x040028FF RID: 10495
		private bool exited_;

		// Token: 0x04002900 RID: 10496
		internal static BreachExitResultEvent uAoWMfJRycXBI3wyqi6a;
	}
}
