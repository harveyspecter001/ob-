using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000A7 RID: 167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorUpdatesListenStartRequest : IMessage<TaxCollectorUpdatesListenStartRequest>, IMessage, IEquatable<TaxCollectorUpdatesListenStartRequest>, IDeepCloneable<TaxCollectorUpdatesListenStartRequest>, IBufferMessage
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0018F554 File Offset: 0x0018D754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorUpdatesListenStartRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0018F564 File Offset: 0x0018D764
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0018F574 File Offset: 0x0018D774
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

		// Token: 0x06000730 RID: 1840 RVA: 0x0018F584 File Offset: 0x0018D784
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListenStartRequest()
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0018F594 File Offset: 0x0018D794
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListenStartRequest(TaxCollectorUpdatesListenStartRequest other)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0018F5A4 File Offset: 0x0018D7A4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListenStartRequest Clone()
		{
			return null;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x0018F5B4 File Offset: 0x0018D7B4
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x0018F5C4 File Offset: 0x0018D7C4
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

		// Token: 0x06000735 RID: 1845 RVA: 0x0018F5D4 File Offset: 0x0018D7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0018F5E4 File Offset: 0x0018D7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorUpdatesListenStartRequest other)
		{
			return true;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0018F5F4 File Offset: 0x0018D7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0018F604 File Offset: 0x0018D804
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0018F614 File Offset: 0x0018D814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0018F624 File Offset: 0x0018D824
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0018F634 File Offset: 0x0018D834
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0018F644 File Offset: 0x0018D844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorUpdatesListenStartRequest other)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0018F654 File Offset: 0x0018D854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0018F664 File Offset: 0x0018D864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0018F674 File Offset: 0x0018D874
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorUpdatesListenStartRequest()
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
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2a0b5d2fd63d4e6892bcec4e63fd2e52 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					TaxCollectorUpdatesListenStartRequest._parser = new MessageParser<TaxCollectorUpdatesListenStartRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_47f1b3c36e024d4bb84ccbe58986ef1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0018F758 File Offset: 0x0018D958
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k2gQKXOIWA6IYeRAkGXc()
		{
			return true;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0018F760 File Offset: 0x0018D960
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorUpdatesListenStartRequest fwJyfOOIhIQ0bqCxaEOi()
		{
			return null;
		}

		// Token: 0x040002B3 RID: 691
		private static readonly MessageParser<TaxCollectorUpdatesListenStartRequest> _parser;

		// Token: 0x040002B4 RID: 692
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002B5 RID: 693
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x040002B6 RID: 694
		private string taxCollectorUid_;

		// Token: 0x040002B7 RID: 695
		private static TaxCollectorUpdatesListenStartRequest BicWbNOILR9iQbAobuna;
	}
}
