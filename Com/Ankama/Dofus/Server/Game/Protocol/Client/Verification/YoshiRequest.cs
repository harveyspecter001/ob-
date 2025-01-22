using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification
{
	// Token: 0x020008B6 RID: 2230
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class YoshiRequest : IMessage<YoshiRequest>, IMessage, IEquatable<YoshiRequest>, IDeepCloneable<YoshiRequest>, IBufferMessage
	{
		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06006C54 RID: 27732 RVA: 0x002326B0 File Offset: 0x002308B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<YoshiRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06006C55 RID: 27733 RVA: 0x002326C0 File Offset: 0x002308C0
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

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06006C56 RID: 27734 RVA: 0x002326D0 File Offset: 0x002308D0
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

		// Token: 0x06006C57 RID: 27735 RVA: 0x002326E0 File Offset: 0x002308E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public YoshiRequest()
		{
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x002326F0 File Offset: 0x002308F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public YoshiRequest(YoshiRequest other)
		{
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00232700 File Offset: 0x00230900
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public YoshiRequest Clone()
		{
			return null;
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00232710 File Offset: 0x00230910
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x00232720 File Offset: 0x00230920
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(YoshiRequest other)
		{
			return true;
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00232730 File Offset: 0x00230930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00232740 File Offset: 0x00230940
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x00232750 File Offset: 0x00230950
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x00232760 File Offset: 0x00230960
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x00232770 File Offset: 0x00230970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x00232780 File Offset: 0x00230980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(YoshiRequest other)
		{
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x00232790 File Offset: 0x00230990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x002327A0 File Offset: 0x002309A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x002327B0 File Offset: 0x002309B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static YoshiRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					YoshiRequest._parser = new MessageParser<YoshiRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_04386f1bc2b74ed7bf9e945df9bd9bd0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x002328A8 File Offset: 0x00230AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HpfcTQJAfjdTqWFdJ4LB()
		{
			return true;
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x002328B0 File Offset: 0x00230AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static YoshiRequest E4R8eSJAnD86MPuSRaQw()
		{
			return null;
		}

		// Token: 0x040025C9 RID: 9673
		private static readonly MessageParser<YoshiRequest> _parser;

		// Token: 0x040025CA RID: 9674
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025CB RID: 9675
		internal static YoshiRequest iCDG7mJmzTbwkMEdORdT;
	}
}
