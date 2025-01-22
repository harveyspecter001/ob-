using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism
{
	// Token: 0x020001D1 RID: 465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrismListEvent : IMessage<PrismListEvent>, IMessage, IEquatable<PrismListEvent>, IDeepCloneable<PrismListEvent>, IBufferMessage
	{
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x001A7538 File Offset: 0x001A5738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrismListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x001A7548 File Offset: 0x001A5748
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x001A7558 File Offset: 0x001A5758
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

		// Token: 0x060015B5 RID: 5557 RVA: 0x001A7568 File Offset: 0x001A5768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismListEvent()
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x001A7578 File Offset: 0x001A5778
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismListEvent(PrismListEvent other)
		{
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x001A7588 File Offset: 0x001A5788
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrismListEvent Clone()
		{
			return null;
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x001A7598 File Offset: 0x001A5798
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<PrismLocalizedInformation> PrismLocalizedInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x001A75A8 File Offset: 0x001A57A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x001A75B8 File Offset: 0x001A57B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PrismListEvent other)
		{
			return true;
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x001A75C8 File Offset: 0x001A57C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x001A75D8 File Offset: 0x001A57D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x001A75E8 File Offset: 0x001A57E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x001A75F8 File Offset: 0x001A57F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x001A7608 File Offset: 0x001A5808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x001A7618 File Offset: 0x001A5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PrismListEvent other)
		{
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x001A7628 File Offset: 0x001A5828
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x001A7638 File Offset: 0x001A5838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x001A7648 File Offset: 0x001A5848
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PrismListEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_bd29ff3240cf44f4922b607ebfc502c7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 4:
					PrismListEvent._repeated_prismLocalizedInformation_codec = FieldCodec.ForMessage<PrismLocalizedInformation>(10U, uXkVISu6qcBBUwg89rL.XVInXhlssT(uXkVISu6qcBBUwg89rL.XXZuLkgxUw));
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_754dc3aa60ab403b80d29c83912847a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					PrismListEvent._parser = new MessageParser<PrismListEvent>(() => null);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x001A7750 File Offset: 0x001A5950
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BlKv2bO1K21acTq5xrab()
		{
			return true;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x001A7758 File Offset: 0x001A5958
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PrismListEvent V61yANO1IVAvkWiETjhA()
		{
			return null;
		}

		// Token: 0x040007B1 RID: 1969
		private static readonly MessageParser<PrismListEvent> _parser;

		// Token: 0x040007B2 RID: 1970
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007B3 RID: 1971
		public const int PrismLocalizedInformationFieldNumber = 1;

		// Token: 0x040007B4 RID: 1972
		private static readonly FieldCodec<PrismLocalizedInformation> _repeated_prismLocalizedInformation_codec;

		// Token: 0x040007B5 RID: 1973
		private readonly RepeatedField<PrismLocalizedInformation> prismLocalizedInformation_;

		// Token: 0x040007B6 RID: 1974
		private static PrismListEvent Y53y0dO1jaX8A9tL62Eo;
	}
}
