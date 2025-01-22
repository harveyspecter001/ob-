using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Debug
{
	// Token: 0x020007EF RID: 2031
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DebugHighlightCellsEvent : IMessage<DebugHighlightCellsEvent>, IMessage, IEquatable<DebugHighlightCellsEvent>, IDeepCloneable<DebugHighlightCellsEvent>, IBufferMessage
	{
		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06006328 RID: 25384 RVA: 0x002243E0 File Offset: 0x002225E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DebugHighlightCellsEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06006329 RID: 25385 RVA: 0x002243F0 File Offset: 0x002225F0
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

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600632A RID: 25386 RVA: 0x00224400 File Offset: 0x00222600
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

		// Token: 0x0600632B RID: 25387 RVA: 0x00224410 File Offset: 0x00222610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugHighlightCellsEvent()
		{
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x00224420 File Offset: 0x00222620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugHighlightCellsEvent(DebugHighlightCellsEvent other)
		{
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x00224430 File Offset: 0x00222630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugHighlightCellsEvent Clone()
		{
			return null;
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600632E RID: 25390 RVA: 0x00224440 File Offset: 0x00222640
		// (set) Token: 0x0600632F RID: 25391 RVA: 0x00224450 File Offset: 0x00222650
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Color
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

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x00224460 File Offset: 0x00222660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Cells
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x00224470 File Offset: 0x00222670
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x00224480 File Offset: 0x00222680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(DebugHighlightCellsEvent other)
		{
			return true;
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x00224490 File Offset: 0x00222690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x002244A0 File Offset: 0x002226A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x002244B0 File Offset: 0x002226B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x002244C0 File Offset: 0x002226C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x002244D0 File Offset: 0x002226D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x002244E0 File Offset: 0x002226E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(DebugHighlightCellsEvent other)
		{
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x002244F0 File Offset: 0x002226F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00224500 File Offset: 0x00222700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00224510 File Offset: 0x00222710
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DebugHighlightCellsEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b79252eba1e243578ef10b6ab35a1392 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
					DebugHighlightCellsEvent._parser = new MessageParser<DebugHighlightCellsEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d290fa3fe5a2400180e3a32a20811234 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				DebugHighlightCellsEvent._repeated_cells_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 4;
			}
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x002245FC File Offset: 0x002227FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yg5NMxOze6PIc2VG5I7C()
		{
			return true;
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x00224604 File Offset: 0x00222804
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static DebugHighlightCellsEvent PraFDwOz3IMqHKAU6MCF()
		{
			return null;
		}

		// Token: 0x040022D7 RID: 8919
		private static readonly MessageParser<DebugHighlightCellsEvent> _parser;

		// Token: 0x040022D8 RID: 8920
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022D9 RID: 8921
		public const int ColorFieldNumber = 1;

		// Token: 0x040022DA RID: 8922
		private long color_;

		// Token: 0x040022DB RID: 8923
		public const int CellsFieldNumber = 2;

		// Token: 0x040022DC RID: 8924
		private static readonly FieldCodec<int> _repeated_cells_codec;

		// Token: 0x040022DD RID: 8925
		private readonly RepeatedField<int> cells_;

		// Token: 0x040022DE RID: 8926
		private static DebugHighlightCellsEvent S5rQ7KOzBZl2KUrnnJdP;
	}
}
