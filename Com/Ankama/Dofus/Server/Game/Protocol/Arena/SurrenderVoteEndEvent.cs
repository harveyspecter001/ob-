using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena
{
	// Token: 0x02000C55 RID: 3157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SurrenderVoteEndEvent : IMessage<SurrenderVoteEndEvent>, IMessage, IEquatable<SurrenderVoteEndEvent>, IDeepCloneable<SurrenderVoteEndEvent>, IBufferMessage
	{
		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x060097AA RID: 38826 RVA: 0x002787BC File Offset: 0x002769BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SurrenderVoteEndEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x060097AB RID: 38827 RVA: 0x002787CC File Offset: 0x002769CC
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

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x060097AC RID: 38828 RVA: 0x002787DC File Offset: 0x002769DC
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

		// Token: 0x060097AD RID: 38829 RVA: 0x002787EC File Offset: 0x002769EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteEndEvent()
		{
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x002787FC File Offset: 0x002769FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteEndEvent(SurrenderVoteEndEvent other)
		{
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x0027880C File Offset: 0x00276A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurrenderVoteEndEvent Clone()
		{
			return null;
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x060097B0 RID: 38832 RVA: 0x0027881C File Offset: 0x00276A1C
		// (set) Token: 0x060097B1 RID: 38833 RVA: 0x0027882C File Offset: 0x00276A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool VoteResult
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

		// Token: 0x060097B2 RID: 38834 RVA: 0x0027883C File Offset: 0x00276A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x0027884C File Offset: 0x00276A4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SurrenderVoteEndEvent other)
		{
			return true;
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x0027885C File Offset: 0x00276A5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x0027886C File Offset: 0x00276A6C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x0027887C File Offset: 0x00276A7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x0027888C File Offset: 0x00276A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x0027889C File Offset: 0x00276A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x002788AC File Offset: 0x00276AAC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SurrenderVoteEndEvent other)
		{
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x002788BC File Offset: 0x00276ABC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x002788CC File Offset: 0x00276ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x002788DC File Offset: 0x00276ADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SurrenderVoteEndEvent()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_575a5808a6e84ab3a7d8ef4c64aa28e4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				SurrenderVoteEndEvent._parser = new MessageParser<SurrenderVoteEndEvent>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x002789A8 File Offset: 0x00276BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R2FHEVJN3BvtwxycRjBD()
		{
			return true;
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x002789B0 File Offset: 0x00276BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SurrenderVoteEndEvent WLKAhcJNRMiGXAhsLHL0()
		{
			return null;
		}

		// Token: 0x04003856 RID: 14422
		private static readonly MessageParser<SurrenderVoteEndEvent> _parser;

		// Token: 0x04003857 RID: 14423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003858 RID: 14424
		public const int VoteResultFieldNumber = 1;

		// Token: 0x04003859 RID: 14425
		private bool voteResult_;

		// Token: 0x0400385A RID: 14426
		internal static SurrenderVoteEndEvent wW5LpqJNe2x9YREgCAXS;
	}
}
