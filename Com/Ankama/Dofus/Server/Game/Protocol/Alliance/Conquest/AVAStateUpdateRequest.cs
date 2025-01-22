using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000D7D RID: 3453
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AVAStateUpdateRequest : IMessage<AVAStateUpdateRequest>, IMessage, IEquatable<AVAStateUpdateRequest>, IDeepCloneable<AVAStateUpdateRequest>, IBufferMessage
	{
		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x0600A66D RID: 42605 RVA: 0x00293114 File Offset: 0x00291314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AVAStateUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x0600A66E RID: 42606 RVA: 0x00293124 File Offset: 0x00291324
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

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x00293134 File Offset: 0x00291334
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

		// Token: 0x0600A670 RID: 42608 RVA: 0x00293144 File Offset: 0x00291344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AVAStateUpdateRequest()
		{
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x00293154 File Offset: 0x00291354
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AVAStateUpdateRequest(AVAStateUpdateRequest other)
		{
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x00293164 File Offset: 0x00291364
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AVAStateUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x0600A673 RID: 42611 RVA: 0x00293174 File Offset: 0x00291374
		// (set) Token: 0x0600A674 RID: 42612 RVA: 0x00293184 File Offset: 0x00291384
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Enable
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

		// Token: 0x0600A675 RID: 42613 RVA: 0x00293194 File Offset: 0x00291394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x002931A4 File Offset: 0x002913A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AVAStateUpdateRequest other)
		{
			return true;
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x002931B4 File Offset: 0x002913B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x002931C4 File Offset: 0x002913C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x002931D4 File Offset: 0x002913D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x002931E4 File Offset: 0x002913E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A67B RID: 42619 RVA: 0x002931F4 File Offset: 0x002913F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A67C RID: 42620 RVA: 0x00293204 File Offset: 0x00291404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AVAStateUpdateRequest other)
		{
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x00293214 File Offset: 0x00291414
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x00293224 File Offset: 0x00291424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A67F RID: 42623 RVA: 0x00293234 File Offset: 0x00291434
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AVAStateUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					AVAStateUpdateRequest._parser = new MessageParser<AVAStateUpdateRequest>(() => null);
					num2 = 4;
					break;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ccea45e828ca4ede894a726afe0a41ea == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x00293318 File Offset: 0x00291518
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool caMsSSJkSpN21oZixxtU()
		{
			return true;
		}

		// Token: 0x0600A681 RID: 42625 RVA: 0x00293320 File Offset: 0x00291520
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AVAStateUpdateRequest svOMFLJkMilnJanuqWh3()
		{
			return null;
		}

		// Token: 0x04003D50 RID: 15696
		private static readonly MessageParser<AVAStateUpdateRequest> _parser;

		// Token: 0x04003D51 RID: 15697
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D52 RID: 15698
		public const int EnableFieldNumber = 1;

		// Token: 0x04003D53 RID: 15699
		private bool enable_;

		// Token: 0x04003D54 RID: 15700
		private static AVAStateUpdateRequest bySlJhJkPk7mi2PBE8NI;
	}
}
