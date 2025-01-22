using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000B1 RID: 177
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPresetsUpdatesListenStartRequest : IMessage<TaxCollectorPresetsUpdatesListenStartRequest>, IMessage, IEquatable<TaxCollectorPresetsUpdatesListenStartRequest>, IDeepCloneable<TaxCollectorPresetsUpdatesListenStartRequest>, IBufferMessage
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00190008 File Offset: 0x0018E208
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<TaxCollectorPresetsUpdatesListenStartRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00190018 File Offset: 0x0018E218
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00190028 File Offset: 0x0018E228
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

		// Token: 0x060007BA RID: 1978 RVA: 0x00190038 File Offset: 0x0018E238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsUpdatesListenStartRequest()
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00190048 File Offset: 0x0018E248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsUpdatesListenStartRequest(TaxCollectorPresetsUpdatesListenStartRequest other)
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00190058 File Offset: 0x0018E258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsUpdatesListenStartRequest Clone()
		{
			return null;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00190068 File Offset: 0x0018E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00190078 File Offset: 0x0018E278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPresetsUpdatesListenStartRequest other)
		{
			return true;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00190088 File Offset: 0x0018E288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00190098 File Offset: 0x0018E298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x001900A8 File Offset: 0x0018E2A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x001900B8 File Offset: 0x0018E2B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x001900C8 File Offset: 0x0018E2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x001900D8 File Offset: 0x0018E2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPresetsUpdatesListenStartRequest other)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x001900E8 File Offset: 0x0018E2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x001900F8 File Offset: 0x0018E2F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00190108 File Offset: 0x0018E308
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPresetsUpdatesListenStartRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_C1;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 4:
						TaxCollectorPresetsUpdatesListenStartRequest._parser = new MessageParser<TaxCollectorPresetsUpdatesListenStartRequest>(() => null);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_C1:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 3;
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x001901F0 File Offset: 0x0018E3F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QvGWCmOIbPEeT5d5ti1f()
		{
			return true;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x001901F8 File Offset: 0x0018E3F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPresetsUpdatesListenStartRequest gv8y9OOIixW6DH4cLOHN()
		{
			return null;
		}

		// Token: 0x040002DE RID: 734
		private static readonly MessageParser<TaxCollectorPresetsUpdatesListenStartRequest> _parser;

		// Token: 0x040002DF RID: 735
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002E0 RID: 736
		private static TaxCollectorPresetsUpdatesListenStartRequest GtXQEoOIYItA8qFHPDjj;
	}
}
