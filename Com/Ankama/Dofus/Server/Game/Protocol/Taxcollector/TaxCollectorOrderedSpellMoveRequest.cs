using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000AF RID: 175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorOrderedSpellMoveRequest : IMessage<TaxCollectorOrderedSpellMoveRequest>, IMessage, IEquatable<TaxCollectorOrderedSpellMoveRequest>, IDeepCloneable<TaxCollectorOrderedSpellMoveRequest>, IBufferMessage
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0018FDB4 File Offset: 0x0018DFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorOrderedSpellMoveRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0018FDC4 File Offset: 0x0018DFC4
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0018FDD4 File Offset: 0x0018DFD4
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

		// Token: 0x0600079C RID: 1948 RVA: 0x0018FDE4 File Offset: 0x0018DFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellMoveRequest()
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0018FDF4 File Offset: 0x0018DFF4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellMoveRequest(TaxCollectorOrderedSpellMoveRequest other)
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0018FE04 File Offset: 0x0018E004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellMoveRequest Clone()
		{
			return null;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0018FE14 File Offset: 0x0018E014
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0018FE24 File Offset: 0x0018E024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TaxCollectorUid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0018FE34 File Offset: 0x0018E034
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x0018FE44 File Offset: 0x0018E044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FromSlotId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0018FE54 File Offset: 0x0018E054
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x0018FE64 File Offset: 0x0018E064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToSlotId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0018FE74 File Offset: 0x0018E074
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0018FE84 File Offset: 0x0018E084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorOrderedSpellMoveRequest other)
		{
			return true;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0018FE94 File Offset: 0x0018E094
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0018FEA4 File Offset: 0x0018E0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0018FEB4 File Offset: 0x0018E0B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0018FEC4 File Offset: 0x0018E0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0018FED4 File Offset: 0x0018E0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0018FEE4 File Offset: 0x0018E0E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorOrderedSpellMoveRequest other)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0018FEF4 File Offset: 0x0018E0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0018FF04 File Offset: 0x0018E104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0018FF14 File Offset: 0x0018E114
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorOrderedSpellMoveRequest()
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
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9977cdd0d7324aea8156198254612854 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					TaxCollectorOrderedSpellMoveRequest._parser = new MessageParser<TaxCollectorOrderedSpellMoveRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cbc97c474bef497cb3347d66c4ad6889 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0018FFF8 File Offset: 0x0018E1F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool SNcvnGOIpLBWkNibUW3M()
		{
			return true;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00190000 File Offset: 0x0018E200
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorOrderedSpellMoveRequest l4eeB6OIHdmLYRBUyx21()
		{
			return null;
		}

		// Token: 0x040002D3 RID: 723
		private static readonly MessageParser<TaxCollectorOrderedSpellMoveRequest> _parser;

		// Token: 0x040002D4 RID: 724
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002D5 RID: 725
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x040002D6 RID: 726
		private string taxCollectorUid_;

		// Token: 0x040002D7 RID: 727
		public const int FromSlotIdFieldNumber = 2;

		// Token: 0x040002D8 RID: 728
		private int fromSlotId_;

		// Token: 0x040002D9 RID: 729
		public const int ToSlotIdFieldNumber = 3;

		// Token: 0x040002DA RID: 730
		private int toSlotId_;

		// Token: 0x040002DB RID: 731
		private static TaxCollectorOrderedSpellMoveRequest yQJZSeOITr07o9nhkCkW;
	}
}
