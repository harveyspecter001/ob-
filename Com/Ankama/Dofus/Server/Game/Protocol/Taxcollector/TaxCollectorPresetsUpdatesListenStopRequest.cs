using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000B3 RID: 179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorPresetsUpdatesListenStopRequest : IMessage<TaxCollectorPresetsUpdatesListenStopRequest>, IMessage, IEquatable<TaxCollectorPresetsUpdatesListenStopRequest>, IDeepCloneable<TaxCollectorPresetsUpdatesListenStopRequest>, IBufferMessage
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00190200 File Offset: 0x0018E400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorPresetsUpdatesListenStopRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00190210 File Offset: 0x0018E410
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00190220 File Offset: 0x0018E420
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

		// Token: 0x060007D2 RID: 2002 RVA: 0x00190230 File Offset: 0x0018E430
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsUpdatesListenStopRequest()
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00190240 File Offset: 0x0018E440
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsUpdatesListenStopRequest(TaxCollectorPresetsUpdatesListenStopRequest other)
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00190250 File Offset: 0x0018E450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorPresetsUpdatesListenStopRequest Clone()
		{
			return null;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00190260 File Offset: 0x0018E460
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00190270 File Offset: 0x0018E470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorPresetsUpdatesListenStopRequest other)
		{
			return true;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00190280 File Offset: 0x0018E480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00190290 File Offset: 0x0018E490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x001902A0 File Offset: 0x0018E4A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x001902B0 File Offset: 0x0018E4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x001902C0 File Offset: 0x0018E4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x001902D0 File Offset: 0x0018E4D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorPresetsUpdatesListenStopRequest other)
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x001902E0 File Offset: 0x0018E4E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x001902F0 File Offset: 0x0018E4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00190300 File Offset: 0x0018E500
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorPresetsUpdatesListenStopRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					TaxCollectorPresetsUpdatesListenStopRequest._parser = new MessageParser<TaxCollectorPresetsUpdatesListenStopRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a1661a64b3ed4c0083ecb953cd4f47ff == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x001903E4 File Offset: 0x0018E5E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool E6x2iHOIS7HTGy5W2DWl()
		{
			return true;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x001903EC File Offset: 0x0018E5EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorPresetsUpdatesListenStopRequest huUwW8OIMrib4iQsshhx()
		{
			return null;
		}

		// Token: 0x040002E3 RID: 739
		private static readonly MessageParser<TaxCollectorPresetsUpdatesListenStopRequest> _parser;

		// Token: 0x040002E4 RID: 740
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002E5 RID: 741
		internal static TaxCollectorPresetsUpdatesListenStopRequest uAiX78OIPXc4ySLNsHNx;
	}
}
