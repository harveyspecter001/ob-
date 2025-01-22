using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000321 RID: 801
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockObjectAnimationPlayEvent : IMessage<PaddockObjectAnimationPlayEvent>, IMessage, IEquatable<PaddockObjectAnimationPlayEvent>, IDeepCloneable<PaddockObjectAnimationPlayEvent>, IBufferMessage
	{
		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x001C14A4 File Offset: 0x001BF6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PaddockObjectAnimationPlayEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x001C14B4 File Offset: 0x001BF6B4
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

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x001C14C4 File Offset: 0x001BF6C4
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

		// Token: 0x060025A0 RID: 9632 RVA: 0x001C14D4 File Offset: 0x001BF6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectAnimationPlayEvent()
		{
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x001C14E4 File Offset: 0x001BF6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectAnimationPlayEvent(PaddockObjectAnimationPlayEvent other)
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x001C14F4 File Offset: 0x001BF6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockObjectAnimationPlayEvent Clone()
		{
			return null;
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x001C1504 File Offset: 0x001BF704
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<int> CellsId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x001C1514 File Offset: 0x001BF714
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x001C1524 File Offset: 0x001BF724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockObjectAnimationPlayEvent other)
		{
			return true;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x001C1534 File Offset: 0x001BF734
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x001C1544 File Offset: 0x001BF744
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x001C1554 File Offset: 0x001BF754
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x001C1564 File Offset: 0x001BF764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x001C1574 File Offset: 0x001BF774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x001C1584 File Offset: 0x001BF784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockObjectAnimationPlayEvent other)
		{
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x001C1594 File Offset: 0x001BF794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x001C15A4 File Offset: 0x001BF7A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x001C15B4 File Offset: 0x001BF7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockObjectAnimationPlayEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					PaddockObjectAnimationPlayEvent._repeated_cellsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 5;
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					PaddockObjectAnimationPlayEvent._parser = new MessageParser<PaddockObjectAnimationPlayEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					break;
				case 5:
					return;
				}
			}
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x001C16B4 File Offset: 0x001BF8B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool W0jZgAOW6vPkUTKs7Iy5()
		{
			return true;
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x001C16BC File Offset: 0x001BF8BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockObjectAnimationPlayEvent f9pHd8OWLd3b3CWPNJgi()
		{
			return null;
		}

		// Token: 0x04000D59 RID: 3417
		private static readonly MessageParser<PaddockObjectAnimationPlayEvent> _parser;

		// Token: 0x04000D5A RID: 3418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D5B RID: 3419
		public const int CellsIdFieldNumber = 1;

		// Token: 0x04000D5C RID: 3420
		private static readonly FieldCodec<int> _repeated_cellsId_codec;

		// Token: 0x04000D5D RID: 3421
		private readonly RepeatedField<int> cellsId_;

		// Token: 0x04000D5E RID: 3422
		internal static PaddockObjectAnimationPlayEvent jM6xJCOWyFwtPqAYXaa0;
	}
}
