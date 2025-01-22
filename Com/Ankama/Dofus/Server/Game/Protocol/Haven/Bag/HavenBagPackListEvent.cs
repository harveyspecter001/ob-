using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x02000497 RID: 1175
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagPackListEvent : IMessage<HavenBagPackListEvent>, IMessage, IEquatable<HavenBagPackListEvent>, IDeepCloneable<HavenBagPackListEvent>, IBufferMessage
	{
		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x001E01C8 File Offset: 0x001DE3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagPackListEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x001E01D8 File Offset: 0x001DE3D8
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

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x001E01E8 File Offset: 0x001DE3E8
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

		// Token: 0x06003837 RID: 14391 RVA: 0x001E01F8 File Offset: 0x001DE3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPackListEvent()
		{
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x001E0208 File Offset: 0x001DE408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPackListEvent(HavenBagPackListEvent other)
		{
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x001E0218 File Offset: 0x001DE418
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPackListEvent Clone()
		{
			return null;
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x001E0228 File Offset: 0x001DE428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PacksId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x001E0238 File Offset: 0x001DE438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x001E0248 File Offset: 0x001DE448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagPackListEvent other)
		{
			return true;
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x001E0258 File Offset: 0x001DE458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x001E0268 File Offset: 0x001DE468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x001E0278 File Offset: 0x001DE478
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x001E0288 File Offset: 0x001DE488
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x001E0298 File Offset: 0x001DE498
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x001E02A8 File Offset: 0x001DE4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagPackListEvent other)
		{
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x001E02B8 File Offset: 0x001DE4B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x001E02C8 File Offset: 0x001DE4C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x001E02D8 File Offset: 0x001DE4D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagPackListEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c416bce7c284d26be32b0826807851c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 5;
					continue;
				case 5:
					HavenBagPackListEvent._parser = new MessageParser<HavenBagPackListEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b1afd787bbcb47c0becd53e79f55ec2b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				HavenBagPackListEvent._repeated_packsId_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
				num2 = 3;
			}
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x001E03C4 File Offset: 0x001DE5C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oajGHTOwyDqOR3OIGEJF()
		{
			return true;
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x001E03CC File Offset: 0x001DE5CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagPackListEvent IsJGGrOw6xig0Iy1rXcQ()
		{
			return null;
		}

		// Token: 0x040013A3 RID: 5027
		private static readonly MessageParser<HavenBagPackListEvent> _parser;

		// Token: 0x040013A4 RID: 5028
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013A5 RID: 5029
		public const int PacksIdFieldNumber = 1;

		// Token: 0x040013A6 RID: 5030
		private static readonly FieldCodec<int> _repeated_packsId_codec;

		// Token: 0x040013A7 RID: 5031
		private readonly RepeatedField<int> packsId_;

		// Token: 0x040013A8 RID: 5032
		internal static HavenBagPackListEvent TEMYoIOw5WEhLcXbhyFh;
	}
}
