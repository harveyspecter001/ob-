using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000AB RID: 171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorOrderedSpellAddRequest : IMessage<TaxCollectorOrderedSpellAddRequest>, IMessage, IEquatable<TaxCollectorOrderedSpellAddRequest>, IDeepCloneable<TaxCollectorOrderedSpellAddRequest>, IBufferMessage
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0018F964 File Offset: 0x0018DB64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorOrderedSpellAddRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0018F974 File Offset: 0x0018DB74
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0018F984 File Offset: 0x0018DB84
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

		// Token: 0x06000764 RID: 1892 RVA: 0x0018F994 File Offset: 0x0018DB94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellAddRequest()
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0018F9A4 File Offset: 0x0018DBA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellAddRequest(TaxCollectorOrderedSpellAddRequest other)
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0018F9B4 File Offset: 0x0018DBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorOrderedSpellAddRequest Clone()
		{
			return null;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x0018F9C4 File Offset: 0x0018DBC4
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x0018F9D4 File Offset: 0x0018DBD4
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0018F9E4 File Offset: 0x0018DBE4
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x0018F9F4 File Offset: 0x0018DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaxCollectorOrderedSpell AddedSpell
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

		// Token: 0x0600076B RID: 1899 RVA: 0x0018FA04 File Offset: 0x0018DC04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0018FA14 File Offset: 0x0018DC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorOrderedSpellAddRequest other)
		{
			return true;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0018FA24 File Offset: 0x0018DC24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0018FA34 File Offset: 0x0018DC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0018FA44 File Offset: 0x0018DC44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0018FA54 File Offset: 0x0018DC54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0018FA64 File Offset: 0x0018DC64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0018FA74 File Offset: 0x0018DC74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorOrderedSpellAddRequest other)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0018FA84 File Offset: 0x0018DC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0018FA94 File Offset: 0x0018DC94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0018FAA4 File Offset: 0x0018DCA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorOrderedSpellAddRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					TaxCollectorOrderedSpellAddRequest._parser = new MessageParser<TaxCollectorOrderedSpellAddRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_49584b71853e42899c7da5fbe454bd16 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0018FB88 File Offset: 0x0018DD88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TX5LJcOIDlvVOUNs5khh()
		{
			return true;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0018FB90 File Offset: 0x0018DD90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorOrderedSpellAddRequest sHbdT0OItjcfd3cNi1G4()
		{
			return null;
		}

		// Token: 0x040002C1 RID: 705
		private static readonly MessageParser<TaxCollectorOrderedSpellAddRequest> _parser;

		// Token: 0x040002C2 RID: 706
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002C3 RID: 707
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x040002C4 RID: 708
		private string taxCollectorUid_;

		// Token: 0x040002C5 RID: 709
		public const int AddedSpellFieldNumber = 2;

		// Token: 0x040002C6 RID: 710
		private TaxCollectorOrderedSpell addedSpell_;

		// Token: 0x040002C7 RID: 711
		private static TaxCollectorOrderedSpellAddRequest AsCH35OIChHwtij9SgiW;
	}
}
