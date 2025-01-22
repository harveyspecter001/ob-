using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Rank
{
	// Token: 0x02000D2F RID: 3375
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceRanksEvent : IMessage<AllianceRanksEvent>, IMessage, IEquatable<AllianceRanksEvent>, IDeepCloneable<AllianceRanksEvent>, IBufferMessage
	{
		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x0028ACA0 File Offset: 0x00288EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceRanksEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600A286 RID: 41606 RVA: 0x0028ACB0 File Offset: 0x00288EB0
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

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600A287 RID: 41607 RVA: 0x0028ACC0 File Offset: 0x00288EC0
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

		// Token: 0x0600A288 RID: 41608 RVA: 0x0028ACD0 File Offset: 0x00288ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRanksEvent()
		{
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x0028ACE0 File Offset: 0x00288EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRanksEvent(AllianceRanksEvent other)
		{
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x0028ACF0 File Offset: 0x00288EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceRanksEvent Clone()
		{
			return null;
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x0600A28B RID: 41611 RVA: 0x0028AD00 File Offset: 0x00288F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RankInformation> Ranks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x0028AD10 File Offset: 0x00288F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x0028AD20 File Offset: 0x00288F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceRanksEvent other)
		{
			return true;
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x0028AD30 File Offset: 0x00288F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x0028AD40 File Offset: 0x00288F40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x0028AD50 File Offset: 0x00288F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x0028AD60 File Offset: 0x00288F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x0028AD70 File Offset: 0x00288F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x0028AD80 File Offset: 0x00288F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceRanksEvent other)
		{
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x0028AD90 File Offset: 0x00288F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x0028ADA0 File Offset: 0x00288FA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x0028ADB0 File Offset: 0x00288FB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceRanksEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f428196b0d2a4e0999a7147fe49af888 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					break;
				case 3:
					AllianceRanksEvent._repeated_ranks_codec = FieldCodec.ForMessage<RankInformation>(10U, Q43ygLm2FgeO01lX3DCQ.XVInXhlssT(Q43ygLm2FgeO01lX3DCQ.hZLm2zjbuQy));
					num2 = 4;
					break;
				case 4:
					return;
				case 5:
					AllianceRanksEvent._parser = new MessageParser<AllianceRanksEvent>(() => null);
					num2 = 3;
					break;
				}
			}
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x0028AEA0 File Offset: 0x002890A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HnemCGJKzoo1PcHdNisD()
		{
			return true;
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x0028AEA8 File Offset: 0x002890A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceRanksEvent VGGXRfJIfimdZu1yidwE()
		{
			return null;
		}

		// Token: 0x04003BFE RID: 15358
		private static readonly MessageParser<AllianceRanksEvent> _parser;

		// Token: 0x04003BFF RID: 15359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C00 RID: 15360
		public const int RanksFieldNumber = 1;

		// Token: 0x04003C01 RID: 15361
		private static readonly FieldCodec<RankInformation> _repeated_ranks_codec;

		// Token: 0x04003C02 RID: 15362
		private readonly RepeatedField<RankInformation> ranks_;

		// Token: 0x04003C03 RID: 15363
		internal static AllianceRanksEvent cTBWeRJKFyu0YJGU5gpJ;
	}
}
