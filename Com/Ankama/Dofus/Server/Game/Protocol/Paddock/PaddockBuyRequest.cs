using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock
{
	// Token: 0x02000309 RID: 777
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PaddockBuyRequest : IMessage<PaddockBuyRequest>, IMessage, IEquatable<PaddockBuyRequest>, IDeepCloneable<PaddockBuyRequest>, IBufferMessage
	{
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x001BFCD4 File Offset: 0x001BDED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PaddockBuyRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x001BFCE4 File Offset: 0x001BDEE4
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

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x001BFCF4 File Offset: 0x001BDEF4
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

		// Token: 0x06002470 RID: 9328 RVA: 0x001BFD04 File Offset: 0x001BDF04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockBuyRequest()
		{
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x001BFD14 File Offset: 0x001BDF14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockBuyRequest(PaddockBuyRequest other)
		{
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x001BFD24 File Offset: 0x001BDF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PaddockBuyRequest Clone()
		{
			return null;
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x001BFD34 File Offset: 0x001BDF34
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x001BFD44 File Offset: 0x001BDF44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long ProposedPrice
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

		// Token: 0x06002475 RID: 9333 RVA: 0x001BFD54 File Offset: 0x001BDF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x001BFD64 File Offset: 0x001BDF64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PaddockBuyRequest other)
		{
			return true;
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x001BFD74 File Offset: 0x001BDF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x001BFD84 File Offset: 0x001BDF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x001BFD94 File Offset: 0x001BDF94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x001BFDA4 File Offset: 0x001BDFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x001BFDB4 File Offset: 0x001BDFB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x001BFDC4 File Offset: 0x001BDFC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PaddockBuyRequest other)
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x001BFDD4 File Offset: 0x001BDFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x001BFDE4 File Offset: 0x001BDFE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x001BFDF4 File Offset: 0x001BDFF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PaddockBuyRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					PaddockBuyRequest._parser = new MessageParser<PaddockBuyRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x001BFED8 File Offset: 0x001BE0D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IcemVLOWnRCK4rNSGGtD()
		{
			return true;
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x001BFEE0 File Offset: 0x001BE0E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PaddockBuyRequest zJkjigOWm2rhU8peKEHx()
		{
			return null;
		}

		// Token: 0x04000CF6 RID: 3318
		private static readonly MessageParser<PaddockBuyRequest> _parser;

		// Token: 0x04000CF7 RID: 3319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CF8 RID: 3320
		public const int ProposedPriceFieldNumber = 1;

		// Token: 0x04000CF9 RID: 3321
		private long proposedPrice_;

		// Token: 0x04000CFA RID: 3322
		private static PaddockBuyRequest HF5k7mOWfDOE9rD9wQKm;
	}
}
