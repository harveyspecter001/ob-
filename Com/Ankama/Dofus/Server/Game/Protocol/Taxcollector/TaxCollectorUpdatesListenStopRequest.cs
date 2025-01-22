using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000A9 RID: 169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorUpdatesListenStopRequest : IMessage<TaxCollectorUpdatesListenStopRequest>, IMessage, IEquatable<TaxCollectorUpdatesListenStopRequest>, IDeepCloneable<TaxCollectorUpdatesListenStopRequest>, IBufferMessage
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0018F768 File Offset: 0x0018D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorUpdatesListenStopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0018F778 File Offset: 0x0018D978
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0018F788 File Offset: 0x0018D988
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

		// Token: 0x0600074A RID: 1866 RVA: 0x0018F798 File Offset: 0x0018D998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListenStopRequest()
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0018F7A8 File Offset: 0x0018D9A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListenStopRequest(TaxCollectorUpdatesListenStopRequest other)
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0018F7B8 File Offset: 0x0018D9B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorUpdatesListenStopRequest Clone()
		{
			return null;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0018F7C8 File Offset: 0x0018D9C8
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0018F7D8 File Offset: 0x0018D9D8
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

		// Token: 0x0600074F RID: 1871 RVA: 0x0018F7E8 File Offset: 0x0018D9E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0018F7F8 File Offset: 0x0018D9F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorUpdatesListenStopRequest other)
		{
			return true;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0018F808 File Offset: 0x0018DA08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0018F818 File Offset: 0x0018DA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0018F828 File Offset: 0x0018DA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0018F838 File Offset: 0x0018DA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0018F848 File Offset: 0x0018DA48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0018F858 File Offset: 0x0018DA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorUpdatesListenStopRequest other)
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0018F868 File Offset: 0x0018DA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0018F878 File Offset: 0x0018DA78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0018F888 File Offset: 0x0018DA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorUpdatesListenStopRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					continue;
				case 2:
					TaxCollectorUpdatesListenStopRequest._parser = new MessageParser<TaxCollectorUpdatesListenStopRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0018F954 File Offset: 0x0018DB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool vWTKQSOIVVfTUbQ4GqNq()
		{
			return true;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0018F95C File Offset: 0x0018DB5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorUpdatesListenStopRequest oDcqIHOI0eoM52kBtVI0()
		{
			return null;
		}

		// Token: 0x040002BA RID: 698
		private static readonly MessageParser<TaxCollectorUpdatesListenStopRequest> _parser;

		// Token: 0x040002BB RID: 699
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002BC RID: 700
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x040002BD RID: 701
		private string taxCollectorUid_;

		// Token: 0x040002BE RID: 702
		private static TaxCollectorUpdatesListenStopRequest VxQgE9OIr3PpfcrdPOlV;
	}
}
