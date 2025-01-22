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
	// Token: 0x020000BD RID: 189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorStateUpdateEvent : IMessage<TaxCollectorStateUpdateEvent>, IMessage, IEquatable<TaxCollectorStateUpdateEvent>, IDeepCloneable<TaxCollectorStateUpdateEvent>, IBufferMessage
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00190D1C File Offset: 0x0018EF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorStateUpdateEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00190D2C File Offset: 0x0018EF2C
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00190D3C File Offset: 0x0018EF3C
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

		// Token: 0x0600085A RID: 2138 RVA: 0x00190D4C File Offset: 0x0018EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorStateUpdateEvent()
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00190D5C File Offset: 0x0018EF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorStateUpdateEvent(TaxCollectorStateUpdateEvent other)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00190D6C File Offset: 0x0018EF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorStateUpdateEvent Clone()
		{
			return null;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00190D7C File Offset: 0x0018EF7C
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00190D8C File Offset: 0x0018EF8C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00190D9C File Offset: 0x0018EF9C
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00190DB0 File Offset: 0x0018EFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaxCollectorState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TaxCollectorState)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00190DC0 File Offset: 0x0018EFC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00190DD0 File Offset: 0x0018EFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorStateUpdateEvent other)
		{
			return true;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00190DE0 File Offset: 0x0018EFE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00190DF0 File Offset: 0x0018EFF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00190E00 File Offset: 0x0018F000
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00190E10 File Offset: 0x0018F010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00190E20 File Offset: 0x0018F020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00190E30 File Offset: 0x0018F030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorStateUpdateEvent other)
		{
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00190E40 File Offset: 0x0018F040
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00190E50 File Offset: 0x0018F050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00190E60 File Offset: 0x0018F060
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorStateUpdateEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_36;
					case 3:
						return;
					case 4:
						TaxCollectorStateUpdateEvent._parser = new MessageParser<TaxCollectorStateUpdateEvent>(() => null);
						num2 = 3;
						continue;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd == 0)
					{
						num2 = 2;
					}
				}
				IL_36:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 4;
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00190F30 File Offset: 0x0018F130
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool JGdZ9gOkRqG1JkrBI2NS()
		{
			return true;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00190F38 File Offset: 0x0018F138
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorStateUpdateEvent d8dy6tOkOY0Cse1MZJij()
		{
			return null;
		}

		// Token: 0x04000310 RID: 784
		private static readonly MessageParser<TaxCollectorStateUpdateEvent> _parser;

		// Token: 0x04000311 RID: 785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000312 RID: 786
		public const int TaxCollectorUidFieldNumber = 1;

		// Token: 0x04000313 RID: 787
		private string taxCollectorUid_;

		// Token: 0x04000314 RID: 788
		public const int StateFieldNumber = 2;

		// Token: 0x04000315 RID: 789
		private TaxCollectorState state_;

		// Token: 0x04000316 RID: 790
		internal static TaxCollectorStateUpdateEvent HcrpIqOk3gvdd0Oa1h70;
	}
}
