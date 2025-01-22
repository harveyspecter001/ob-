using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000307 RID: 775
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockSellRequest : IMessage<PaddockSellRequest>, IMessage, IEquatable<PaddockSellRequest>, IDeepCloneable<PaddockSellRequest>, IBufferMessage
	{
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x001BFAA0 File Offset: 0x001BDCA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<PaddockSellRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x001BFAB0 File Offset: 0x001BDCB0
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

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x001BFAC0 File Offset: 0x001BDCC0
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

		// Token: 0x06002454 RID: 9300 RVA: 0x001BFAD0 File Offset: 0x001BDCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockSellRequest()
		{
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x001BFAE0 File Offset: 0x001BDCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockSellRequest(PaddockSellRequest other)
		{
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x001BFAF0 File Offset: 0x001BDCF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockSellRequest Clone()
		{
			return null;
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x001BFB00 File Offset: 0x001BDD00
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x001BFB10 File Offset: 0x001BDD10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Price
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

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x001BFB20 File Offset: 0x001BDD20
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x001BFB30 File Offset: 0x001BDD30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool ForSale
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x001BFB40 File Offset: 0x001BDD40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x001BFB50 File Offset: 0x001BDD50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockSellRequest other)
		{
			return true;
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x001BFB60 File Offset: 0x001BDD60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x001BFB70 File Offset: 0x001BDD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x001BFB80 File Offset: 0x001BDD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x001BFB90 File Offset: 0x001BDD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x001BFBA0 File Offset: 0x001BDDA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x001BFBB0 File Offset: 0x001BDDB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockSellRequest other)
		{
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x001BFBC0 File Offset: 0x001BDDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x001BFBD0 File Offset: 0x001BDDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x001BFBE0 File Offset: 0x001BDDE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockSellRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					PaddockSellRequest._parser = new MessageParser<PaddockSellRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_33aa8f74862341cc9386ec2586b137b3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x001BFCC4 File Offset: 0x001BDEC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool K6sb6IOLFBP9IjghvIsm()
		{
			return true;
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x001BFCCC File Offset: 0x001BDECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockSellRequest wZpvELOLzKDLBLULZCpp()
		{
			return null;
		}

		// Token: 0x04000CED RID: 3309
		private static readonly MessageParser<PaddockSellRequest> _parser;

		// Token: 0x04000CEE RID: 3310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CEF RID: 3311
		public const int PriceFieldNumber = 1;

		// Token: 0x04000CF0 RID: 3312
		private long price_;

		// Token: 0x04000CF1 RID: 3313
		public const int ForSaleFieldNumber = 2;

		// Token: 0x04000CF2 RID: 3314
		private bool forSale_;

		// Token: 0x04000CF3 RID: 3315
		internal static PaddockSellRequest Y6Ahn8OLqVqTt5QuNrIZ;
	}
}
