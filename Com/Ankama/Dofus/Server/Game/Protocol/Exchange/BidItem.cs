using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000771 RID: 1905
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BidItem : IMessage<BidItem>, IMessage, IEquatable<BidItem>, IDeepCloneable<BidItem>, IBufferMessage
	{
		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x0021C1B8 File Offset: 0x0021A3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BidItem> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06005D5B RID: 23899 RVA: 0x0021C1C8 File Offset: 0x0021A3C8
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

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06005D5C RID: 23900 RVA: 0x0021C1D8 File Offset: 0x0021A3D8
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

		// Token: 0x06005D5D RID: 23901 RVA: 0x0021C1E8 File Offset: 0x0021A3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidItem()
		{
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x0021C1F8 File Offset: 0x0021A3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidItem(BidItem other)
		{
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x0021C208 File Offset: 0x0021A408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidItem Clone()
		{
			return null;
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x0021C218 File Offset: 0x0021A418
		// (set) Token: 0x06005D61 RID: 23905 RVA: 0x0021C228 File Offset: 0x0021A428
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Uid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x0021C238 File Offset: 0x0021A438
		// (set) Token: 0x06005D63 RID: 23907 RVA: 0x0021C248 File Offset: 0x0021A448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quantity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06005D64 RID: 23908 RVA: 0x0021C258 File Offset: 0x0021A458
		// (set) Token: 0x06005D65 RID: 23909 RVA: 0x0021C268 File Offset: 0x0021A468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Gid
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

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06005D66 RID: 23910 RVA: 0x0021C278 File Offset: 0x0021A478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public RepeatedField<ObjectEffect> Effects
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x0021C288 File Offset: 0x0021A488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x0021C298 File Offset: 0x0021A498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(BidItem other)
		{
			return true;
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x0021C2A8 File Offset: 0x0021A4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x0021C2B8 File Offset: 0x0021A4B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x0021C2C8 File Offset: 0x0021A4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x0021C2D8 File Offset: 0x0021A4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x0021C2E8 File Offset: 0x0021A4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x0021C2F8 File Offset: 0x0021A4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(BidItem other)
		{
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x0021C308 File Offset: 0x0021A508
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x0021C318 File Offset: 0x0021A518
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x0021C328 File Offset: 0x0021A528
		[MethodImpl(MethodImplOptions.NoInlining)]
		static BidItem()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					BidItem._repeated_effects_codec = FieldCodec.ForMessage<ObjectEffect>(34U, P1SsVKnf4KAo6qkGT9ff.XVInXhlssT(P1SsVKnf4KAo6qkGT9ff.HVGnfjmP83g));
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					continue;
				case 5:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 4;
					continue;
				}
				BidItem._parser = new MessageParser<BidItem>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x0021C430 File Offset: 0x0021A630
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GDSLVROZ5lD7IFdh43wM()
		{
			return true;
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x0021C438 File Offset: 0x0021A638
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BidItem aJZulhOZyySlBYdrFVhf()
		{
			return null;
		}

		// Token: 0x040020CA RID: 8394
		private static readonly MessageParser<BidItem> _parser;

		// Token: 0x040020CB RID: 8395
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020CC RID: 8396
		public const int UidFieldNumber = 1;

		// Token: 0x040020CD RID: 8397
		private int uid_;

		// Token: 0x040020CE RID: 8398
		public const int QuantityFieldNumber = 2;

		// Token: 0x040020CF RID: 8399
		private int quantity_;

		// Token: 0x040020D0 RID: 8400
		public const int GidFieldNumber = 3;

		// Token: 0x040020D1 RID: 8401
		private long gid_;

		// Token: 0x040020D2 RID: 8402
		public const int EffectsFieldNumber = 4;

		// Token: 0x040020D3 RID: 8403
		private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

		// Token: 0x040020D4 RID: 8404
		private readonly RepeatedField<ObjectEffect> effects_;

		// Token: 0x040020D5 RID: 8405
		internal static BidItem uhQW8yOZajuhq83Cx4ky;
	}
}
