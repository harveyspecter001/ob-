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
	// Token: 0x020000BF RID: 191
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorAddedEvent : IMessage<TaxCollectorAddedEvent>, IMessage, IEquatable<TaxCollectorAddedEvent>, IDeepCloneable<TaxCollectorAddedEvent>, IBufferMessage
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00190F40 File Offset: 0x0018F140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorAddedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00190F50 File Offset: 0x0018F150
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

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00190F60 File Offset: 0x0018F160
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

		// Token: 0x06000876 RID: 2166 RVA: 0x00190F70 File Offset: 0x0018F170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAddedEvent()
		{
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00190F80 File Offset: 0x0018F180
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAddedEvent(TaxCollectorAddedEvent other)
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00190F90 File Offset: 0x0018F190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorAddedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00190FA0 File Offset: 0x0018F1A0
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00190FB0 File Offset: 0x0018F1B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long CallerId
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00190FC0 File Offset: 0x0018F1C0
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00190FD0 File Offset: 0x0018F1D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public TaxCollectorInformation TaxCollector
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

		// Token: 0x0600087D RID: 2173 RVA: 0x00190FE0 File Offset: 0x0018F1E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00190FF0 File Offset: 0x0018F1F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorAddedEvent other)
		{
			return true;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00191000 File Offset: 0x0018F200
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00191010 File Offset: 0x0018F210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00191020 File Offset: 0x0018F220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00191030 File Offset: 0x0018F230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00191040 File Offset: 0x0018F240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00191050 File Offset: 0x0018F250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorAddedEvent other)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00191060 File Offset: 0x0018F260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00191070 File Offset: 0x0018F270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00191080 File Offset: 0x0018F280
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorAddedEvent()
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
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				TaxCollectorAddedEvent._parser = new MessageParser<TaxCollectorAddedEvent>(() => null);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00191164 File Offset: 0x0018F364
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OtaoEGOkG9WuQjHTSl0I()
		{
			return true;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0019116C File Offset: 0x0018F36C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorAddedEvent j9UBYwOkgCUfmOAfpNxt()
		{
			return null;
		}

		// Token: 0x04000319 RID: 793
		private static readonly MessageParser<TaxCollectorAddedEvent> _parser;

		// Token: 0x0400031A RID: 794
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400031B RID: 795
		public const int CallerIdFieldNumber = 1;

		// Token: 0x0400031C RID: 796
		private long callerId_;

		// Token: 0x0400031D RID: 797
		public const int TaxCollectorFieldNumber = 2;

		// Token: 0x0400031E RID: 798
		private TaxCollectorInformation taxCollector_;

		// Token: 0x0400031F RID: 799
		internal static TaxCollectorAddedEvent kP7LYjOkJEu0PtktR6mo;
	}
}
