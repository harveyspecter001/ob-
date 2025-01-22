using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000C7 RID: 199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorHarvestedEvent : IMessage<TaxCollectorHarvestedEvent>, IMessage, IEquatable<TaxCollectorHarvestedEvent>, IDeepCloneable<TaxCollectorHarvestedEvent>, IBufferMessage
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x001918CC File Offset: 0x0018FACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorHarvestedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x001918DC File Offset: 0x0018FADC
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x001918EC File Offset: 0x0018FAEC
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

		// Token: 0x060008F2 RID: 2290 RVA: 0x001918FC File Offset: 0x0018FAFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorHarvestedEvent()
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0019190C File Offset: 0x0018FB0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorHarvestedEvent(TaxCollectorHarvestedEvent other)
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0019191C File Offset: 0x0018FB1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorHarvestedEvent Clone()
		{
			return null;
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0019192C File Offset: 0x0018FB2C
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x0019193C File Offset: 0x0018FB3C
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

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0019194C File Offset: 0x0018FB4C
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x0019195C File Offset: 0x0018FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HarvesterId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0019196C File Offset: 0x0018FB6C
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x0019197C File Offset: 0x0018FB7C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string HarvesterName
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

		// Token: 0x060008FB RID: 2299 RVA: 0x0019198C File Offset: 0x0018FB8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0019199C File Offset: 0x0018FB9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorHarvestedEvent other)
		{
			return true;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x001919AC File Offset: 0x0018FBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x001919BC File Offset: 0x0018FBBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x001919CC File Offset: 0x0018FBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x001919DC File Offset: 0x0018FBDC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x001919EC File Offset: 0x0018FBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x001919FC File Offset: 0x0018FBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorHarvestedEvent other)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00191A0C File Offset: 0x0018FC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00191A1C File Offset: 0x0018FC1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00191A2C File Offset: 0x0018FC2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorHarvestedEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					TaxCollectorHarvestedEvent._parser = new MessageParser<TaxCollectorHarvestedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 != 0)
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

		// Token: 0x06000906 RID: 2310 RVA: 0x00191B10 File Offset: 0x0018FD10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool aARGg2OkKIhWD8pw9ryU()
		{
			return true;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00191B18 File Offset: 0x0018FD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorHarvestedEvent nMRVfJOkICOwKow8dmhk()
		{
			return null;
		}

		// Token: 0x04000349 RID: 841
		private static readonly MessageParser<TaxCollectorHarvestedEvent> _parser;

		// Token: 0x0400034A RID: 842
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400034B RID: 843
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x0400034C RID: 844
		private string taxCollectorUid_;

		// Token: 0x0400034D RID: 845
		public const int HarvesterIdFieldNumber = 2;

		// Token: 0x0400034E RID: 846
		private long harvesterId_;

		// Token: 0x0400034F RID: 847
		public const int HarvesterNameFieldNumber = 3;

		// Token: 0x04000350 RID: 848
		private string harvesterName_;

		// Token: 0x04000351 RID: 849
		internal static TaxCollectorHarvestedEvent i556giOkjro50qxFf1H8;
	}
}
