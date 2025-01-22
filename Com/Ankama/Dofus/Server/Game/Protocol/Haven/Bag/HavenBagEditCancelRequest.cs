using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200047F RID: 1151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagEditCancelRequest : IMessage<HavenBagEditCancelRequest>, IMessage, IEquatable<HavenBagEditCancelRequest>, IDeepCloneable<HavenBagEditCancelRequest>, IBufferMessage
	{
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x001DED44 File Offset: 0x001DCF44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HavenBagEditCancelRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x001DED54 File Offset: 0x001DCF54
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

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x001DED64 File Offset: 0x001DCF64
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

		// Token: 0x0600371C RID: 14108 RVA: 0x001DED74 File Offset: 0x001DCF74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditCancelRequest()
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x001DED84 File Offset: 0x001DCF84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditCancelRequest(HavenBagEditCancelRequest other)
		{
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x001DED94 File Offset: 0x001DCF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagEditCancelRequest Clone()
		{
			return null;
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x001DEDA4 File Offset: 0x001DCFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x001DEDB4 File Offset: 0x001DCFB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagEditCancelRequest other)
		{
			return true;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x001DEDC4 File Offset: 0x001DCFC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x001DEDD4 File Offset: 0x001DCFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x001DEDE4 File Offset: 0x001DCFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x001DEDF4 File Offset: 0x001DCFF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x001DEE04 File Offset: 0x001DD004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x001DEE14 File Offset: 0x001DD014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagEditCancelRequest other)
		{
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x001DEE24 File Offset: 0x001DD024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x001DEE34 File Offset: 0x001DD034
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x001DEE44 File Offset: 0x001DD044
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagEditCancelRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					HavenBagEditCancelRequest._parser = new MessageParser<HavenBagEditCancelRequest>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x001DEF10 File Offset: 0x001DD110
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JfWY8QOwA0JA4MFQCYGT()
		{
			return true;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x001DEF18 File Offset: 0x001DD118
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagEditCancelRequest NiwtI5OwBBTcplvTR30v()
		{
			return null;
		}

		// Token: 0x04001353 RID: 4947
		private static readonly MessageParser<HavenBagEditCancelRequest> _parser;

		// Token: 0x04001354 RID: 4948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001355 RID: 4949
		internal static HavenBagEditCancelRequest VJE6AJOwmrAHNBnlrHUO;
	}
}
